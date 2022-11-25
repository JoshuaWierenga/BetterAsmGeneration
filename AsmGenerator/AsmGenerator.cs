using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AsmGenerator;

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

    private static readonly Regex StringAsmDetectRegex = new(@"\/\* ?language ?= ?asm ?\*\/",
        RegexOptions.IgnoreCase | RegexOptions.Compiled);

    private static List<(string mnemonic, List<string> operands)>? _instructions;
    private static HashSet<string>? _labels;

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

            _instructions = new List<(string mnemonic, List<string> operands)>();
            _labels = new HashSet<string>();

            byte[] argumentsHash;

            bool inString = assemblerCallArguments.OpenParenToken.TrailingTrivia.Any(t =>
                t.IsKind(SyntaxKind.MultiLineCommentTrivia) && StringAsmDetectRegex.IsMatch(t.ToString()));

            if (inString)
            {
                if (assemblerCallArguments.Arguments[0].Expression is LiteralExpressionSyntax argument)
                {
                    ParseStringInstructions(argument.Token.ValueText, variables);

                    argumentsHash = md5.ComputeHash(Encoding.Default.GetBytes(argument.Token.ValueText));
                }
                else
                {
                    throw new ArgumentException("Invalid string argument was passed into AddInstructions.");
                }
            }
            else
            {
                string asmString = ParseParamsInstructions(assemblerCallArguments.Arguments, semanticModel, variables);

                // TODO use string format hashing method so that the same code in both formats gives the same hash and so
                // avoids duplicating functions
                // get a stable id for the code in a reasonably quick way
                argumentsHash = md5.ComputeHash(Encoding.Default.GetBytes(asmString));
            }

            Guid asmGuid = new(argumentsHash);

            if (existingAssemblies.Contains(asmGuid)) continue;

            existingAssemblies.Add(asmGuid);
            string asmGuidString = asmGuid.ToString("N");
            assemblyInfos.Add(new AssemblyInfo(asmGuidString, _instructions, _labels));
        }

        return assemblyInfos;
    }

    // TODO Remove reflection as much as possible
    // TODO Remove debug statements
    private static void ParseStringInstructions(string instructionString,
        IReadOnlyList<(string variable, string register)>? variables)
    {
        string[] tokens =
            instructionString.Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string token in tokens)
        {
            string lowerToken = token.ToLower();

            // Instruction Mnemonic
            FieldInfo? instruction = typeof(AsmLib.Instructions).GetField(token);
            if (instruction != null)
            {
                // TODO Support labels
                if (lowerToken == "emitlabel")
                {
                    throw new ArgumentException("EmitLabel is not currently supported with string instructions");

                }
                else
                {
                    _instructions!.Add((lowerToken, new List<string>()));
                }

                Debug.WriteLine($"{token} is an instruction");
                continue;
            }

            // Register
            FieldInfo? register = typeof(Iced.Intel.AssemblerRegisters).GetField(token);
            if (_instructions!.Count > 0 && register != null)
            {
                _instructions.Last().operands.Add(lowerToken);

                Debug.WriteLine($"{token} is a register");
                continue;
            }

            // Register Variable
            (string variable, string register)? match =
                variables?.LastOrDefault(v => v.variable == lowerToken);
            if (match is { register: { } })
            {
                _instructions.Last().operands.Add(match.Value.register);

                Debug.WriteLine($"{token} is a variable corresponding to {match.Value.register}");
                continue;
            }

            // TODO Support memory accesses and labels

            //Number
            if (long.TryParse(token, out _) || ulong.TryParse(token, out _))
            {
                _instructions.Last().operands.Add(lowerToken);

                Debug.WriteLine($"{token} is an immediate");
                continue;
            }

            Debug.WriteLine($"{token} was not understood");

            throw new ArgumentException($"Invalid token passed into asm block: {token}");
        }
    }

    private static string ParseParamsInstructions(SeparatedSyntaxList<ArgumentSyntax> tokenList, SemanticModel semanticModel,
        IReadOnlyList<(string variable, string register)>? variables)
    {
        StringBuilder sbInstructions = new();

        foreach (ArgumentSyntax argument in tokenList)
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
                        _instructions!.Add(("Label", new List<string>()));
                        sbInstructions.Append("emit label");
                    }
                    else
                    {
                        _instructions!.Add((instructionLabel, new List<string>()));
                        sbInstructions.Append(instructionLabel);
                    }

                    break;
                //Register
                case IdentifierNameSyntax identifier when typeSymbol is
                {
                    Name: "AssemblerRegister8" or "AssemblerRegister16" or "AssemblerRegister32"
                    or "AssemblerRegister64" or "AssemblerRegisterXMM" or "AssemblerRegisterYMM"
                    or "AssemblerRegisterZMM"
                } && _instructions!.Count > 0:
                    string operandLabel = identifier.Identifier.ValueText.ToLower();
                    (string variable, string register)? match =
                        variables?.LastOrDefault(v => v.variable == operandLabel);
                    if (match is { register: { } })
                    {
                        operandLabel = match.Value.register;
                    }

                    _instructions.Last().operands.Add(operandLabel);
                    sbInstructions.Append(operandLabel);

                    break;
                //TODO Fully support Memory and support in combination with variables
                //Memory Access
                case ElementAccessExpressionSyntax element when typeSymbol is
                {
                    Name: "AssemblerMemoryOperand"
                } && _instructions!.Count > 0:
                    string memoryOperand = element.ToFullString();
                    _instructions.Last().operands.Add(memoryOperand);
                    sbInstructions.Append(memoryOperand);
                    break;
                //Label
                case IdentifierNameSyntax label when typeSymbol?.Name == "Label":
                    string labelName = label.Identifier.ValueText;
                    _instructions!.Last().operands.Add(labelName);
                    _labels!.Add(labelName);
                    sbInstructions.Append(labelName);
                    break;
                //TODO Support floating point, check how assembly normally handles them
                //Number
                case LiteralExpressionSyntax literal when literal.IsKind(SyntaxKind.NumericLiteralExpression) &&
                                                          _instructions!.Count > 0:
                    string literalValue = literal.Token.ValueText;
                    _instructions.Last().operands.Add(literalValue);
                    sbInstructions.Append(literalValue);
                    break;
                default:
                    throw new ArgumentException("Invalid type passed into asm block. Type was " +
                                                typeSymbol?.ToDisplayString());
            }
        }

        return sbInstructions.ToString();
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

        //TODO Use namespace containing function call?
        sb.AppendLine(
@" // <auto-generated />
using AsmLib;
using Iced.Intel;
using System;
using static Iced.Intel.AssemblerRegisters;

namespace AsmLib
{
    internal static class Generator
    {");
        GenerateAsmWrappersMethod(sb, assemblyInfos, indent);

        foreach (AssemblyInfo assemblyInfo in assemblyInfos)
        {
            GenerateAsmConverterMethod(sb, assemblyInfo, indent);
        }

        sb.AppendLine(
            @"    }
}");
    }

    private static void GenerateAsmWrappersMethod(StringBuilder sb, IReadOnlyList<AssemblyInfo> assemblerInfos,
        string indent)
    {
        GenerateAsmWrapperMethod(sb, indent, AssemblyFormat.Params);
        GenerateAsmWrapperMethod(sb, indent, AssemblyFormat.String);

        GenerateAsmHandlerMethod(sb, assemblerInfos, indent);
    }

    private static void GenerateAsmWrapperMethod(StringBuilder sb, string indent, AssemblyFormat format)
    {
        string parameter = format == AssemblyFormat.Params ? "params AssemblyData[] assembly" : "string assembly";

        sb.AppendLine($"{indent}public static void AddInstructions(this Assembler assembler, {parameter})");
        sb.AppendLine($"{indent}{{");

        GenerateAsmWrapperMethodBody(sb, indent + "    ", format);

        sb.AppendLine($"{indent}}}");
        sb.AppendLine();
    }

    private static void GenerateAsmWrapperMethodBody(StringBuilder sb, string indent, AssemblyFormat format)
    {
        sb.AppendLine($"{indent}string guid = AssemblyData.GetGuid{format}(assembly);");
        sb.AppendLine($"{indent}FindInstructions(assembler, guid);");
    }

    private static void GenerateAsmHandlerMethod(StringBuilder sb, IReadOnlyList<AssemblyInfo> assemblerInfos,
        string indent)
    {
        sb.AppendLine($"{indent}// <summary> </summary>");
        sb.AppendLine($"{indent}private static void FindInstructions(this Assembler assembler, string guid)");
        sb.AppendLine($"{indent}{{");

        if (!assemblerInfos.Any())
        {
            sb.AppendLine($"{indent}// This will be filled in by the generator once you call this function");
            sb.AppendLine($"{indent}throw new Exception(\"This shouldn't be possible.\");");
        }
        else
        {
            GenerateAsmHandlerMethodBody(sb, assemblerInfos, indent + "    ");
        }

        sb.AppendLine($"{indent}}}");
        sb.AppendLine();
    }

    private static void GenerateAsmHandlerMethodBody(StringBuilder sb, IEnumerable<AssemblyInfo> assemblerInfos,
        string indent)
    {
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

        if (assemblyInfo.Labels.Count != 0)
        {
            sb.AppendLine();
        }

        foreach ((string mnemonic, List<string> operands) in assemblyInfo.Instructions)
        {
            //TODO Find a better way to do this
            string labelRef = mnemonic == "Label" ? "ref " : "";

            sb.AppendLine($"{indent}assembler.{mnemonic}({labelRef}{string.Join(", ", operands)});");
        }
    }
}
