using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AsmGenerator.Asm_Source_Generator;

internal class AsmSyntaxReceiver : ISyntaxReceiver
{
    public List<Tuple<ArgumentListSyntax, bool>> AssemblerCalls { get; } = new();

    public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
    {
        if (syntaxNode is InvocationExpressionSyntax
            {
                ArgumentList:
                {
                    Arguments.Count: > 0
                } arguments,
                Expression: MemberAccessExpressionSyntax
                {
                    Name.Identifier.ValueText: "AddInstructions",
                } instructions
            })
        {
            switch (instructions.Expression)
            {
                case InvocationExpressionSyntax // var.AddVariables(...).AddInstructions(...)
                {
                    Expression: MemberAccessExpressionSyntax
                    {
                        Name.Identifier.ValueText: "AddVariables"
                    }
                }:
                    AssemblerCalls.Add(new Tuple<ArgumentListSyntax, bool>(arguments, true));
                    break;
                case IdentifierNameSyntax: // var.AddInstructions(...))
                    AssemblerCalls.Add(new Tuple<ArgumentListSyntax, bool>(arguments, false));
                    break;
            }
        }
    }
}
