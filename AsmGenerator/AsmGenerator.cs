using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
        GenerateAsm(sb, assemblyInfos);

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

            string inString;
            string outString;

            bool isStringFormat = assemblerCallArguments.OpenParenToken.TrailingTrivia.Any(t =>
                t.IsKind(SyntaxKind.MultiLineCommentTrivia) && StringAsmDetectRegex.IsMatch(t.ToString()));

            if (isStringFormat)
            {
                if (assemblerCallArguments.Arguments[0].Expression is LiteralExpressionSyntax argument)
                {
                    ParseStringInstructions(argument.Token.ValueText, variables, out inString, out outString);
                }
                else
                {
                    throw new ArgumentException("Invalid string argument was passed into AddInstructions.");
                }
            }
            else
            {
                ParseParamsInstructions(assemblerCallArguments.Arguments, semanticModel, variables, out inString,
                    out outString);
            }

            // There are two ways to turn the input given to AddInstructions into a string that doesn't depend
            // on the formatting of the input in the case of the string format asm, those involve concatenating
            // the given tokens either before or after optimisation. For the time being that is the difference
            // between taking register variables as the name of the variable or the register they represent.
            // The issue is that at runtime, string format asm will always be processed pre optimisation and
            // params array format asm will always be processed post optimisation since the variables will
            // be stripped out before the function call in that case.
            // This makes it difficult to optimise the number of generated functions since the two formats will
            // not give the same hash whenever variables are involved, even if they are the same and so the
            // generated functions match. To solve this, I have replaced the switch that was used at runtime
            // to figure out which emitted function to use for a given call to AddInstructions with a hashmap
            // between strings representing the hashes and delegates representing the functions. This allows
            // improving runtime performance by removing branching whenever possible and so means that more
            // cases can be added without issue.
            // For convenience, I have decided that the post optimisation hash is the primary hash and so whenever
            // string format asm is used, both pre and post optimisation hashes are generated with both mapping
            // to the same function in the resulting hashmap.
            string outHash = AsmLib.HashGeneration.ToHash(outString);
            string inHash = isStringFormat && variables != null ? AsmLib.HashGeneration.ToHash(inString) : outHash;

            AssemblyInfo match = assemblyInfos.Find(asm => asm.OutHash == outHash);
            if (match != null)
            {
                // Only want to set InHash if we have actually determined it
                if (isStringFormat)
                {
                    match.InHash = inHash;
                }

                continue;
            }

            assemblyInfos.Add(new AssemblyInfo(inHash, outHash, _instructions, _labels));
        }

        return assemblyInfos;
    }

    // TODO Remove debug statements
    private static void ParseStringInstructions(string instructionString,
        IReadOnlyList<(string variable, string register)>? variables, out string inString, out string outString)
    {
        StringBuilder sbInString = new();
        StringBuilder sbOutString = new();

        string[] tokens =
            instructionString.Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        HashSet<string> potentialLabelList = new();

        foreach (string token in tokens)
        {
            string lowerToken = token.ToLower();
            sbInString.Append(lowerToken);

            // Instruction Mnemonic
            if (AsmLib.GeneratorInstructions.Instructions.Contains(token))
            {
                if (lowerToken == "emitlabel")
                {
                    throw new ArgumentException("EmitLabel is not supported with string instructions, just write the name of the label and then a colon.");
                }

                _instructions!.Add((lowerToken, new List<string>()));
                sbOutString.Append(lowerToken);

                Debug.WriteLine($"{token} is an instruction");
                continue;
            }

            // Register
            if (_instructions!.Count > 0 && AsmLib.GeneratorRegisters.Registers.Contains(token))
            {
                _instructions.Last().operands.Add(lowerToken);
                sbOutString.Append(lowerToken);

                Debug.WriteLine($"{token} is a register");
                continue;
            }

            // Register Variable
            (string variable, string register)? match =
                variables?.LastOrDefault(v => v.variable == lowerToken);
            if (match is { register: { } })
            {
                _instructions.Last().operands.Add(match.Value.register);
                sbOutString.Append(match.Value.register);

                Debug.WriteLine($"{token} is a variable corresponding to {match.Value.register}");
                continue;
            }

            // Label definition 
            if (lowerToken.EndsWith(":"))
            {
                string labelName = lowerToken.Substring(0, lowerToken.Length - 1);

                if (_labels!.Contains(labelName))
                {
                    throw new ArgumentException($"The label {token} was defined more than once");
                }

                _instructions.Add(("Label", new List<string> { labelName }));
                _labels.Add(labelName);
                sbOutString.Append(labelName);

                Debug.WriteLine($"{token} is a label definition");
                continue;
            }

            // Label usage after definition
            if (_labels!.Contains(lowerToken))
            {
                _instructions.Last().operands.Add(lowerToken);
                sbOutString.Append(lowerToken);

                Debug.WriteLine($"{token} is a label usage after definition");
                continue;
            }

            if (lowerToken.StartsWith("[") && lowerToken.EndsWith("]"))
            {
                string indirectRegisterAddress = "__" + lowerToken;

                _instructions.Last().operands.Add(indirectRegisterAddress);
                sbOutString.Append("__" + indirectRegisterAddress);

                Debug.WriteLine($"{token} is as indirect register address");
                continue;
            }

            //Number
            if (long.TryParse(token, out _) || ulong.TryParse(token, out _))
            {
                _instructions.Last().operands.Add(lowerToken);
                sbOutString.Append(lowerToken);

                Debug.WriteLine($"{token} is an immediate");
                continue;
            }

            // Assume any other token is label usage before definition
            _instructions.Last().operands.Add(lowerToken);
            sbOutString.Append(lowerToken);
            potentialLabelList.Add(token); // Use original token for error reporting

            Debug.WriteLine($"{token} may be a label usage before definition");
        }

        foreach (string potentialLabel in potentialLabelList)
        {
            string lowerPotentialLabel = potentialLabel.ToLower();

            if (_labels!.Contains(lowerPotentialLabel))
            {
                Debug.WriteLine($"{lowerPotentialLabel} was a label usage before definition");
                continue;
            }

            Debug.WriteLine($"{potentialLabel} was not understood");

            throw new ArgumentException($"Invalid token passed into asm block: {potentialLabel}");
        }

        inString = sbInString.ToString();
        outString = sbOutString.ToString();
    }

    private static void ParseParamsInstructions(SeparatedSyntaxList<ArgumentSyntax> tokenList,
        SemanticModel semanticModel, IReadOnlyList<(string variable, string register)>? variables, out string inString,
        out string outString)
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
                    string labelName = label.Identifier.ValueText.ToLower();
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

        inString = outString = sbInstructions.ToString();
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

    private static void GenerateAsm(StringBuilder sb, IReadOnlyList<AssemblyInfo> assemblyInfos)
    {
        const string indent = "    ";

        //TODO Use namespace containing function call?
        sb.AppendLine(
$@"// <auto-generated />
using Iced.Intel;
using System;
using System.Collections.Generic;
using static Iced.Intel.AssemblerRegisters;

namespace AsmLib
{{
{indent}internal static class Generator
{indent}{{");
        GenerateAsmDictionary(sb, assemblyInfos, indent + "    ");

        GenerateAsmWrapperMethod(sb, AssemblyFormat.Params, indent + "    ");
        GenerateAsmWrapperMethod(sb, AssemblyFormat.String, indent + "    ");

        foreach (AssemblyInfo assemblyInfo in assemblyInfos)
        {
            GenerateAsmConverterMethod(sb, assemblyInfo, indent + "    ");
        }

        sb.AppendLine(
$@"{indent}}}
}}");
    }

    private static void GenerateAsmDictionary(StringBuilder sb, IEnumerable<AssemblyInfo> assemblyInfos,
        string indent)
    {
        // This is only marked internal so that the testing library can access it
        sb.AppendLine($"{indent}internal static Dictionary<string, Action<Assembler>> Implementations = new()");
        sb.AppendLine($"{indent}{{");

        GenerateAsmDictionaryBody(sb, assemblyInfos, indent + "    ");

        sb.AppendLine($"{indent}}};");
        sb.AppendLine();
    }

    private static void GenerateAsmDictionaryBody(StringBuilder sb, IEnumerable<AssemblyInfo> assemblyInfos,
        string indent)
    {
        foreach (AssemblyInfo assemblyInfo in assemblyInfos)
        {
            // This is only the case for string format assembly containing labels
            if (assemblyInfo.InHash != assemblyInfo.OutHash)
            {
                sb.AppendLine($"{indent}{{\"{assemblyInfo.InHash}\", Instructions{assemblyInfo.OutHash}}},");
            }

            sb.AppendLine($"{indent}{{\"{assemblyInfo.OutHash}\", Instructions{assemblyInfo.OutHash}}},");
        }
    }

    private static void GenerateAsmWrapperMethod(StringBuilder sb, AssemblyFormat format, string indent)
    {
        string parameter = format == AssemblyFormat.Params ? "params AssemblyData[] assembly" : "string assembly";

        //TODO Write summary
        sb.AppendLine($"{indent}// <summary> </summary>");
        sb.AppendLine($"{indent}public static void AddInstructions(this Assembler assembler, {parameter})");
        sb.AppendLine($"{indent}{{");

        GenerateAsmWrapperMethodBody(sb, indent + "    ");

        sb.AppendLine($"{indent}}}");
        sb.AppendLine();
    }

    private static void GenerateAsmWrapperMethodBody(StringBuilder sb, string indent)
    {
        sb.AppendLine($"{indent}string hash = HashGeneration.ToHash(assembly);");
        sb.AppendLine($"{indent}Implementations[hash](assembler);");
    }

    private static void GenerateAsmConverterMethod(StringBuilder sb, AssemblyInfo assemblyInfo, string indent)
    {
        //TODO Write summary
        sb.AppendLine($"{indent}// <summary> </summary>");
        sb.AppendLine($"{indent}private static void Instructions{assemblyInfo.OutHash}(Assembler assembler)");
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
