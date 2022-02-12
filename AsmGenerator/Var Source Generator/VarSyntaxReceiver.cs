using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AsmGenerator.Var_Source_Generator;

internal class VarSyntaxReceiver : ISyntaxReceiver
{
    public List<ArgumentListSyntax> VariableCalls { get; } = new();

    public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
    {
        //TODO Support more than one call
        if (VariableCalls.Count > 0)
        {
            return;
        }

        if (syntaxNode is InvocationExpressionSyntax
            {
                ArgumentList:
                {
                    Arguments.Count: > 0
                } arguments,
                Expression: MemberAccessExpressionSyntax
                {
                    Name.Identifier.ValueText: "AddVariables",
                    Expression: IdentifierNameSyntax
                }
            })
        {
            VariableCalls.Add(arguments);
        }
    }
}
