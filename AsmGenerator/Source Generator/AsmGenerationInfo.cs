using System;
using System.Collections.Generic;

namespace AsmGenerator.Source_Generator;

internal class AsmGenerationInfo
{
    public List<Tuple<string, List<string>>> InstructionLabels;

    public string InstructionGuid;

    public AsmGenerationInfo(List<Tuple<string, List<string>>> instructionLabels, string instructionGuid)
    {
        InstructionLabels = instructionLabels;
        InstructionGuid = instructionGuid;
    }
}
