using System.Collections.Generic;

namespace AsmGenerator.Source_Generator;

internal class VariableInfo
{
    //TODO Add more fields or remove VariableInfo wrapper
    internal IReadOnlyList<(string variable, string register)> Variables;

    internal VariableInfo(IReadOnlyList<(string variable, string register)> variables)
    {
        Variables = variables;
    }
}
