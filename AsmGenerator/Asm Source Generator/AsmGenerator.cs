#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AsmGenerator.Asm_Source_Generator;

[Generator]
internal class AsmGenerator : ISourceGenerator
{
    private const string AsmWrapperMethodBodyStub = @"
            // This will be filled in by the generator once you call it
            throw new Exception(""This shouldn't be possible."");
";

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

        List<Tuple<ArgumentListSyntax, bool>> assemblerCalls = syntaxReceiver.AssemblerCalls;

        IEnumerable<AsmGenerationInfo> asmGenerationInfos =
            GetAsmGenerationInfo(context.Compilation, assemblerCalls);

        StringBuilder sb = new();
        GenerateAsmConverter(context, sb, asmGenerationInfos);

        context.AddSource("AsmConverter.cs", sb.ToString());
    }

    private static IEnumerable<AsmGenerationInfo> GetAsmGenerationInfo(Compilation compilation,
        List<Tuple<ArgumentListSyntax, bool>> assemblerCalls)
    {
        HashSet<Guid> existingAssemblies = new();

        using MD5 md5 = MD5.Create();

        //TODO Use includesVariables or remove
        foreach ((ArgumentListSyntax assemblerCallArguments, bool includesVariables) in assemblerCalls)
        {
            SemanticModel semanticModel = compilation.GetSemanticModel(assemblerCallArguments.SyntaxTree);

            List<Tuple<string, List<Tuple<string, bool>>>> instructionData = new();
            List<int> variablePositions = new();
            StringBuilder sbInstruction = new();

            //TODO Remove
            //Debugger.Launch();

            for (int i = 0; i < assemblerCallArguments.Arguments.Count; i++)
            {
                ExpressionSyntax asmData = assemblerCallArguments.Arguments[i].Expression;
                ITypeSymbol? typeSymbol = semanticModel.GetTypeInfo(asmData).Type;
                switch (asmData)
                {
                    case IdentifierNameSyntax identifier when typeSymbol?.Name == "Instruction":
                        string instructionLabel = identifier.Identifier.ValueText.ToLower();
                        instructionData.Add(new Tuple<string, List<Tuple<string, bool>>>(instructionLabel,
                            new List<Tuple<string, bool>>()));
                        sbInstruction.Append(instructionLabel);
                        break;
                    case IdentifierNameSyntax identifier when instructionData.Count > 0:
                        string operandLabel = identifier.Identifier.ValueText.ToLower();
                        //TODO Improve, should be easy enough once variable information is available here
                        //TODO Remove dependance on manually added Register Class, I tried using the source generator method of
                        //referencing packages but it caused AsmMessaround to start complaining about C:\lib\netstandard2.0\Iced.dll not existing
                        if (Enum.TryParse<IcedRegister>(operandLabel, true, out _))
                        {
                            instructionData.Last().Item2.Add(new Tuple<string, bool>(operandLabel, false));
                            sbInstruction.Append(operandLabel);
                        }
                        else
                        {
                            instructionData.Last().Item2.Add(new Tuple<string, bool>(operandLabel, true));
                            variablePositions.Add(i);
                            // At this point with only have variable names but at runtime
                            // we only have register names and so using variables in
                            // the guid would prevent function linking at runtime
                            // Once the source generators are merged this won't be a problem
                        }

                        break;
                    case LiteralExpressionSyntax literal when instructionData.Count > 0:
                        string literalValue = literal.Token.ValueText;
                        instructionData.Last().Item2.Add(new Tuple<string, bool>(literalValue, false));
                        sbInstruction.Append(literalValue);
                        break;
                    default:
                        //TODO Tidy!
                        throw new Exception();
                }
            }

            // get a stable id for the code in a reasonably quick way
            string asmString = sbInstruction.ToString();
            byte[] asmHash = md5.ComputeHash(Encoding.Default.GetBytes(asmString));
            Guid asmGuid = new(asmHash);

            if (existingAssemblies.Contains(asmGuid)) continue;

            existingAssemblies.Add(asmGuid);
            string asmGuidString = asmGuid.ToString("N");
            yield return new AsmGenerationInfo(instructionData, asmGuidString, variablePositions);
        }
    }

    private static void GenerateAsmConverter(GeneratorExecutionContext context, StringBuilder sb,
        IEnumerable<AsmGenerationInfo> asmGenerationInfos)
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
        GenerateAsmWrapperMethod(context, sb, asmGenerationInfos, indent, !asmGenerationInfos.Any(info => info.VariablePositions.Count == 0), false);
        GenerateAsmWrapperMethod(context, sb, asmGenerationInfos, indent, !asmGenerationInfos.Any(info => info.VariablePositions.Count != 0), true);

        foreach (AsmGenerationInfo asmGenerationInfo in asmGenerationInfos)
        {
            GenerateAsmConverterMethod(context, sb, asmGenerationInfo, indent);
        }

        sb.AppendLine(
            @"    }
}");
    }

    //TODO Write summary
    private static void GenerateAsmWrapperMethod(GeneratorExecutionContext context, StringBuilder sb,
        IEnumerable<AsmGenerationInfo> asmGenerationInfos, string indent, bool empty, bool forVariables)
    {
        string extensionType = forVariables ? "VariableAssembler" : "Assembler";

        sb.AppendLine($"{indent}// <summary> </summary>");
        sb.AppendLine(
            $"{indent}public static void AddInstructions(this {extensionType} assembler, params AssemblyData[] assembly)");
        sb.AppendLine($"{indent}{{");

        if (empty)
        {
            sb.AppendLine(AsmWrapperMethodBodyStub);
        }
        else
        {
            GenerateAsmWrapperMethodBody(context, sb, asmGenerationInfos, indent + "    ", forVariables);
        }

        sb.AppendLine($"{indent}}}");
        sb.AppendLine();
    }

    private static void GenerateAsmWrapperMethodBody(GeneratorExecutionContext context, StringBuilder sb,
        IEnumerable<AsmGenerationInfo> asmGenerationInfos, string indent, bool forVariables)
    {
        if (!forVariables)
        {
            sb.AppendLine($"{indent}string guid = AssemblyData.GetGuid(assembly);");
            sb.AppendLine();
            sb.AppendLine($"{indent}switch (guid)");
        }
        else
        {
            sb.AppendLine($"{indent}switch (assembly.Length)");
        }
        sb.AppendLine($"{indent}{{");

        GenerateAsmWrapperMethodBodySwitchBody(context, sb, asmGenerationInfos, indent + "    ", forVariables);

        sb.AppendLine($"{indent}}}");
    }

    private static void GenerateAsmWrapperMethodBodySwitchBody(GeneratorExecutionContext context, StringBuilder sb,
        IEnumerable<AsmGenerationInfo> asmGenerationInfos, string indent, bool forVariables)
    {
        string innerIndent = indent + "    ";

        foreach (AsmGenerationInfo asmGenerationInfo in asmGenerationInfos)
        {
            if (forVariables == (asmGenerationInfo.VariablePositions.Count != 0))
            {
                sb.Append($"{indent}case ");

                if (forVariables)
                {
                    int tokenCount = asmGenerationInfo.InstructionLabels.Count
                        + asmGenerationInfo.InstructionLabels
                        .Select(l => l.Item2.Count)
                        .Aggregate((a, b) => a + b);
                    string variablePositions = string.Join(", ", asmGenerationInfo.VariablePositions);
                    sb.Append($"{tokenCount} when AssemblyData.GetGuid(assembly, new []{{{variablePositions}}}) == ");
                }

                sb.AppendLine($"\"{asmGenerationInfo.InstructionGuid}\":");
                sb.AppendLine($"{innerIndent}Instructions{asmGenerationInfo.InstructionGuid}(assembler);");
                sb.AppendLine($"{innerIndent}break;");
            }
        }

        sb.AppendLine($"{indent}default:");
        //TODO Add better exception, same for stub version
        sb.AppendLine($"{innerIndent}throw new Exception(\"This shouldn't be possible.\");");
    }

    //TODO Write summary
    private static void GenerateAsmConverterMethod(GeneratorExecutionContext context, StringBuilder sb,
        AsmGenerationInfo asmGenerationInfo, string indent)
    {
        string extensionType = asmGenerationInfo.VariablePositions.Count != 0 ? "VariableAssembler" : "Assembler";

        sb.AppendLine($"{indent}// <summary> </summary>");
        sb.AppendLine(
            $"{indent}private static void Instructions{asmGenerationInfo.InstructionGuid}({extensionType} assembler)");
        sb.AppendLine($"{indent}{{");

        GenerateAsmConverterMethodBody(context, sb, asmGenerationInfo, indent + "    ");

        sb.AppendLine($"{indent}}}");
        sb.AppendLine();
    }

    private static void GenerateAsmConverterMethodBody(GeneratorExecutionContext context, StringBuilder sb,
        AsmGenerationInfo asmGenerationInfo, string indent)
    {
        string assemblerMember = asmGenerationInfo.VariablePositions.Count != 0 ? ".Assembler" : "";

        foreach ((string mnemonic, List<Tuple<string, bool>> operands) in asmGenerationInfo.InstructionLabels)
        {
            IEnumerable<string> actualOperands =
                operands.Select(o => o.Item2 ? $"assembler.Variables[\"{o.Item1}\"]" : o.Item1);

            sb.AppendLine($"{indent}assembler{assemblerMember}.{mnemonic}({string.Join(", ", actualOperands)});");
        }
    }
}
