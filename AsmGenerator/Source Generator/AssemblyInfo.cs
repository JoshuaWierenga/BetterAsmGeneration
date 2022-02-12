using System.Collections.Generic;

namespace AsmGenerator.Source_Generator;

internal class AssemblyInfo
{
    internal List<(string mnemonic, List<string> operands)> InstructionData;
    internal string Guid;
    internal VariableInfo? VariableInfo;

    public AssemblyInfo(List<(string mnemonic, List<string> operands)> instructionData, string guid,
        VariableInfo? variablesInfo)
    {
        InstructionData = instructionData;
        Guid = guid;
        VariableInfo = variablesInfo;
    }
}
