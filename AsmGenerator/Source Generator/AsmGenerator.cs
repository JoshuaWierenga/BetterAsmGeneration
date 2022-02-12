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

            VariableInfo? variablesInfo = null;
            if (variablesCallArguments != null)
            {
                variablesInfo = GetVariablesCallInfo(variablesCallArguments);
            }

            List<(string mnemonic, List<string> operands)> instructionData = new();
            StringBuilder sbInstruction = new();

            foreach (ArgumentSyntax argument in assemblerCallArguments.Arguments)
            {
                ExpressionSyntax asmData = argument.Expression;
                ITypeSymbol? typeSymbol = ModelExtensions.GetTypeInfo(semanticModel, asmData).Type;
                switch (asmData)
                {
                    case IdentifierNameSyntax identifier when typeSymbol?.Name == "Instruction":
                        string instructionLabel = identifier.Identifier.ValueText.ToLower();
                        instructionData.Add((instructionLabel, new List<string>()));
                        sbInstruction.Append(instructionLabel);
                        break;
                    //TODO Support Memory
                    case IdentifierNameSyntax identifier when typeSymbol is
                    {
                        Name: "AssemblerRegister8" or "AssemblerRegister16" or "AssemblerRegister32"
                        or "AssemblerRegister64"
                    } && instructionData.Count > 0:
                        string operandLabel = identifier.Identifier.ValueText.ToLower();
                        (string variable, string register)? match =
                            variablesInfo?.Variables.LastOrDefault(v => v.variable == operandLabel);
                        if (match is { register: { } })
                        {
                            operandLabel = match.Value.register;
                        }

                        instructionData.Last().operands.Add(operandLabel);
                        sbInstruction.Append(operandLabel);

                        break;
                    case LiteralExpressionSyntax literal when literal.IsKind(SyntaxKind.NumericLiteralExpression) &&
                                                              instructionData.Count > 0:
                        string literalValue = literal.Token.ValueText;
                        instructionData.Last().operands.Add(literalValue);
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
            assemblyInfos.Add(new AssemblyInfo(instructionData, asmGuidString, variablesInfo));
        }

        return assemblyInfos;
    }

    private static VariableInfo GetVariablesCallInfo(BaseArgumentListSyntax variablesCallArguments)
    {
        IEnumerable<(string variable, string register)> variables =
            from argument in variablesCallArguments.Arguments
            select argument.ToString().Replace(" ", "").Split('=')
            into splitArgumentString
            select (splitArgumentString[0], splitArgumentString[1]);

        return new VariableInfo(variables.ToList());
    }

    private static void GenerateAsmFunctions(StringBuilder sb, IReadOnlyList<AssemblyInfo> assemblyInfos)
    {
        const string indent = "        ";

        sb.AppendLine(
@" // <auto-generated />
using AsmGenerator;
using Iced.Intel;
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
            sb.AppendLine($"case \"{asmGenerationInfo.Guid}\":");
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
        foreach ((string? mnemonic, List<string>? operands) in assemblyInfo.InstructionData)
        {
            sb.AppendLine($"{indent}assembler.{mnemonic}({string.Join(", ", operands)});");
        }
    }
}
