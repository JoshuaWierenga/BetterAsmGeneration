using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace AsmGenerator.Source_Generator;

[Generator]
internal class AsmGenerator : ISourceGenerator
{
    public void Initialize(GeneratorInitializationContext context)
    {
        context.RegisterForSyntaxNotifications(() => new AsmSyntaxReceiver());
    }

    public void Execute(GeneratorExecutionContext context)
    {
        if (context.SyntaxReceiver is not AsmSyntaxReceiver syntaxReceiver)
        {
            throw new InvalidOperationException("We were given the wrong syntax receiver.");
        }

        List<Tuple<ArgumentListSyntax, ArgumentListSyntax?>> assemblyCalls = syntaxReceiver.AddCalls;

        IReadOnlyList<AssemblyInfo> assemblyInfos = GetAssemblyCallsInfo(context.Compilation, assemblyCalls);

        StringBuilder sb = new();
        GenerateAsmFunctions(sb, assemblyInfos);

        context.AddSource("AsmConverter.g.cs", sb.ToString());
    }

    private static IReadOnlyList<AssemblyInfo> GetAssemblyCallsInfo(Compilation compilation,
        List<Tuple<ArgumentListSyntax, ArgumentListSyntax?>> assemblerCalls)
    {
        List<AssemblyInfo> assemblyInfos = new();

        HashSet<Guid> existingAssemblies = new();
        using MD5 md5 = MD5.Create();

        foreach ((ArgumentListSyntax assemblerCallArguments, ArgumentListSyntax? variablesCallArguments) in
                 assemblerCalls)
        {
            SemanticModel semanticModel = compilation.GetSemanticModel(assemblerCallArguments.SyntaxTree);

            IReadOnlyList<(string variable, string register)>? variables = null;
            if (variablesCallArguments != null)
            {
                variables = GetVariablesCallInfo(variablesCallArguments);
            }

            List<(string mnemonic, List<string> operands)> instructions = new();
            HashSet<string> labels = new();
            StringBuilder sbInstruction = new();

            foreach (ArgumentSyntax argument in assemblerCallArguments.Arguments)
            {
                ExpressionSyntax asmData = argument.Expression;
                ITypeSymbol? typeSymbol = ModelExtensions.GetTypeInfo(semanticModel, asmData).Type;

                switch (asmData)
                {
                    //Instruction Mnemonic
                    case IdentifierNameSyntax identifier when typeSymbol?.Name == "Instruction":
                        string instructionLabel = identifier.Identifier.ValueText.ToLower();

                        if (instructionLabel == "emitlabel")
                        {
                            instructions.Add(("Label", new List<string>()));
                            sbInstruction.Append("emit label");
                        }
                        else
                        {
                            instructions.Add((instructionLabel, new List<string>()));
                            sbInstruction.Append(instructionLabel);
                        }
                        break;
                    //Register
                    case IdentifierNameSyntax identifier when typeSymbol is
                    {
                        Name: "AssemblerRegister8" or "AssemblerRegister16" or "AssemblerRegister32"
                        or "AssemblerRegister64" or "AssemblerRegisterXMM" or "AssemblerRegisterYMM"
                        or "AssemblerRegisterZMM"
                    } && instructions.Count > 0:
                        string operandLabel = identifier.Identifier.ValueText.ToLower();
                        (string variable, string register)? match =
                            variables?.LastOrDefault(v => v.variable == operandLabel);
                        if (match is { register: { } })
                        {
                            operandLabel = match.Value.register;
                        }

                        instructions.Last().operands.Add(operandLabel);
                        sbInstruction.Append(operandLabel);

                        break;
                    //TODO Fully support Memory and support in combination with variables
                    //Memory Access
                    case ElementAccessExpressionSyntax element when typeSymbol is
                    {
                        Name: "AssemblerMemoryOperand"
                    } && instructions.Count > 0:
                        string memoryOperand = element.ToFullString();
                        instructions.Last().operands.Add(memoryOperand);
                        sbInstruction.Append(memoryOperand);
                        break;
                    //Label
                    case IdentifierNameSyntax label when typeSymbol?.Name == "Label":
                        string labelName = label.Identifier.ValueText;
                        instructions.Last().operands.Add(labelName);
                        labels.Add(labelName);
                        sbInstruction.Append(labelName);
                        break;
                    //TODO Support floating point, check how assembly normally handles them
                    //Number
                    case LiteralExpressionSyntax literal when literal.IsKind(SyntaxKind.NumericLiteralExpression) &&
                                                              instructions.Count > 0:
                        string literalValue = literal.Token.ValueText;
                        instructions.Last().operands.Add(literalValue);
                        sbInstruction.Append(literalValue);
                        break;
                    default:
                        throw new ArgumentException("Invalid type passed into asm block. Type was " +
                                                    typeSymbol?.ToDisplayString());
                }
            }

            // get a stable id for the code in a reasonably quick way
            string asmString = sbInstruction.ToString();
            byte[] asmHash = md5.ComputeHash(Encoding.Default.GetBytes(asmString));
            Guid asmGuid = new(asmHash);

            if (existingAssemblies.Contains(asmGuid)) continue;

            existingAssemblies.Add(asmGuid);
            string asmGuidString = asmGuid.ToString("N");
            assemblyInfos.Add(new AssemblyInfo(asmGuidString, instructions, labels));
        }

        return assemblyInfos;
    }

    private static IReadOnlyList<(string variable, string register)> GetVariablesCallInfo(
        BaseArgumentListSyntax variablesCallArguments)
    {
        IEnumerable<(string variable, string register)> variables =
            from argument in variablesCallArguments.Arguments
            select argument.ToString().Replace(" ", "").Split('=')
            into splitArgumentString
            select (splitArgumentString[0], splitArgumentString[1]);

        return variables.ToList();
    }

    private static void GenerateAsmFunctions(StringBuilder sb, IReadOnlyList<AssemblyInfo> assemblyInfos)
    {
        const string indent = "        ";

        sb.AppendLine(
@" // <auto-generated />
using AsmGenerator;
using Iced.Intel;
using System;
using static Iced.Intel.AssemblerRegisters;

namespace AsmGenerator
{
    internal static class Generator
    {");
        GenerateAsmWrapperMethod(sb, assemblyInfos, indent);

        foreach (AssemblyInfo assemblyInfo in assemblyInfos)
        {
            GenerateAsmConverterMethod(sb, assemblyInfo, indent);
        }

        sb.AppendLine(
            @"    }
}");
    }

    private static void GenerateAsmWrapperMethod(StringBuilder sb, IReadOnlyList<AssemblyInfo> assemblerInfos,
        string indent)
    {
        //TODO Write summary
        sb.AppendLine($"{indent}// <summary> </summary>");
        sb.AppendLine(
            $"{indent}public static void AddInstructions(this Assembler assembler, params AssemblyData[] assembly)");
        sb.AppendLine($"{indent}{{");

        if (!assemblerInfos.Any())
        {
            sb.AppendLine($"{indent}// This will be filled in by the generator once you call it");
            sb.AppendLine($"{indent}throw new Exception(\"This shouldn't be possible.\");");
        }
        else
        {
            GenerateAsmWrapperMethodBody(sb, assemblerInfos, indent + "    ");
        }

        sb.AppendLine($"{indent}}}");
        sb.AppendLine();
    }

    private static void GenerateAsmWrapperMethodBody(StringBuilder sb, IEnumerable<AssemblyInfo> assemblerInfos,
        string indent)
    {
        sb.AppendLine($"{indent}string guid = AssemblyData.GetGuid(assembly);");
        sb.AppendLine();
        sb.AppendLine($"{indent}switch (guid)");
        sb.AppendLine($"{indent}{{");

        GenerateAsmWrapperMethodBodySwitchBody(sb, assemblerInfos, indent + "    ");

        sb.AppendLine($"{indent}}}");
    }

    private static void GenerateAsmWrapperMethodBodySwitchBody(StringBuilder sb,
        IEnumerable<AssemblyInfo> assemblerInfos, string indent)
    {
        string innerIndent = indent + "    ";

        foreach (AssemblyInfo asmGenerationInfo in assemblerInfos)
        {
            sb.AppendLine($"{indent}case \"{asmGenerationInfo.Guid}\":");
            sb.AppendLine($"{innerIndent}Instructions{asmGenerationInfo.Guid}(assembler);");
            sb.AppendLine($"{innerIndent}break;");
        }
    }

    private static void GenerateAsmConverterMethod(StringBuilder sb, AssemblyInfo assemblyInfo, string indent)
    {
        //TODO Write summary
        sb.AppendLine($"{indent}// <summary> </summary>");
        sb.AppendLine($"{indent}private static void Instructions{assemblyInfo.Guid}(Assembler assembler)");
        sb.AppendLine($"{indent}{{");

        GenerateAsmConverterMethodBody(sb, assemblyInfo, indent + "    ");

        sb.AppendLine($"{indent}}}");
        sb.AppendLine();
    }

    private static void GenerateAsmConverterMethodBody(StringBuilder sb, AssemblyInfo assemblyInfo, string indent)
    {
        //TODO Used provided variable, is that possible due to the lack of ref?
        foreach (string label in assemblyInfo.Labels)
        {
            sb.AppendLine($"{indent}Label {label} = assembler.CreateLabel();");
        }

        sb.AppendLine();

        foreach ((string mnemonic, List<string> operands) in assemblyInfo.Instructions)
        {
            //TODO Find a better way to do this
            string labelRef = mnemonic == "Label" ? "ref " : "";

            sb.AppendLine($"{indent}assembler.{mnemonic}({labelRef}{string.Join(", ", operands)});");
        }
    }
}
