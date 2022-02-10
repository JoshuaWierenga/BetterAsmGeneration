using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AsmGenerator.Source_Generator
{
    internal class SyntaxReceiver : ISyntaxReceiver
    {
        public List<SyntaxNode> AssemblerParseCalls { get; } = new();

        public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
        {
            //TODO Support more than one call
            if (AssemblerParseCalls.Count > 0)
            {
                return;
            }

            if (syntaxNode is InvocationExpressionSyntax
                {
                    Expression: MemberAccessExpressionSyntax
                    {
                        Name.Identifier.ValueText: "Parse",
                        Expression: MemberAccessExpressionSyntax
                        {
                            Name.Identifier.ValueText: "CompileTimeBetterInstructionCollection"
                        }
                    }
                })
            {
                AssemblerParseCalls.Add(syntaxNode);
            }
        }
    }
}
