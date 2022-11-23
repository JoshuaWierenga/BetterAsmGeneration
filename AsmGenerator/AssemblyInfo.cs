using System.Collections.Generic;

namespace AsmGenerator;

internal class AssemblyInfo
{
    internal readonly string Guid;

    internal readonly IReadOnlyList<(string mnemonic, List<string> operands)> Instructions;
    internal readonly IReadOnlyCollection<string> Labels;

    public AssemblyInfo(string guid,
        IReadOnlyList<(string mnemonic, List<string> operands)> instructionData,
        IReadOnlyCollection<string> labelData)
    {
        Guid = guid;

        Instructions = instructionData;
        Labels = labelData;
    }
}
