using System;
using System.Collections.Generic;

namespace AsmGenerator.Var_Source_Generator;

internal class VarGenerationInfo
{
    //TODO Revert to Tuple<string, string>
    internal List<Tuple<string, string, int>> Variables;

    public VarGenerationInfo(List<Tuple<string, string, int>> variables)
    {
        Variables = variables;
    }
}
