using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AsmGenerator.Source_Generator;

internal class AsmSyntaxReceiver : ISyntaxReceiver
{
    //TODO Remove or use
    //public List<InvocationExpressionSyntax> AddVariablesCalls { get; } = new();
    //TODO use features of ArgumentListSyntax or switch to BaseArgumentListSyntax
    public List<Tuple<ArgumentListSyntax, ArgumentListSyntax?>> AddCalls { get; } = new();

    public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
    {
        if (syntaxNode is not InvocationExpressionSyntax
            {
                ArgumentList:
                {
                    Arguments.Count: not 0
                } asmArgList
            } asmInvocation)
        {
            return;
        }

        MemberAccessExpressionSyntax? member = asmInvocation.Expression as MemberAccessExpressionSyntax;

        switch (member?.Name.Identifier.ValueText)
        {
            //TODO Support AddVariables on its own or remove. disabled currently as I am worried about ordering problems
            //i.e. calling AddInstructions and then AddVariables, ideally variables wouldn't appear(and if ideal setup is followed the variables won't even be assigned)
            //in the assembly but not sure if that is likely to occur and if so how to prevent it
            //var.AddVariables(...)
            /*case "AddVariables" when member.Expression is IdentifierNameSyntax:
                AddVariablesCalls.Add(invocation);
                break;*/
            //var.AddInstructions(...)
            case "AddInstructions" when member.Expression is IdentifierNameSyntax:
                AddCalls.Add(new Tuple<ArgumentListSyntax, ArgumentListSyntax?>(asmArgList, null));
                break;
            //TODO Remove compound invocation and just require calling both functions separately in correct order?
            //var.AddVariables(...).AddInstructions(...)
            case "AddInstructions" when member.Expression is InvocationExpressionSyntax
            {
                ArgumentList: { } varArgList,
                Expression: MemberAccessExpressionSyntax
                {
                    Name.Identifier.ValueText: "AddVariables",
                    Expression: IdentifierNameSyntax
                }
            }:
                AddCalls.Add(new Tuple<ArgumentListSyntax, ArgumentListSyntax?>(asmArgList, varArgList));
                break;
        }
    }
}
