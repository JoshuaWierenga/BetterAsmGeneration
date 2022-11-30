using System.Collections.Generic;

namespace InlineAssembly.Generator;

internal class AssemblyInfo
{
    internal string InHash;
    internal readonly string OutHash;

    internal readonly IReadOnlyList<(string mnemonic, List<string> operands)> Instructions;
    internal readonly IReadOnlyCollection<string> Labels;

    internal AssemblyInfo(string inHash, string outHash,
        IReadOnlyList<(string mnemonic, List<string> operands)> instructionData,
        IReadOnlyCollection<string> labelData)
    {
        InHash = inHash;
        OutHash = outHash;

        Instructions = instructionData;
        Labels = labelData;
    }
}
