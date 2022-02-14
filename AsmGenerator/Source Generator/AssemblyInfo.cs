using System.Collections.Generic;

namespace AsmGenerator.Source_Generator;

internal class AssemblyInfo
{
    internal readonly IReadOnlyList<(string mnemonic, List<string> operands)> InstructionData;
    internal readonly string Guid;
    internal readonly IReadOnlyList<(string variable, string register)>? VariableInfo;

    public AssemblyInfo(IReadOnlyList<(string mnemonic, List<string> operands)> instructionData, string guid,
        IReadOnlyList<(string variable, string register)>? variablesInfo)
    {
        InstructionData = instructionData;
        Guid = guid;
        VariableInfo = variablesInfo;
    }
}
