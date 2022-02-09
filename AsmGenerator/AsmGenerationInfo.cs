using System;
using System.Collections.Generic;

namespace AsmGenerator;

internal class AsmGenerationInfo
{
    public List<Tuple<string, List<string>>> InstructionLabels;

    public AsmGenerationInfo(List<Tuple<string, List<string>>> instructionLabels)
    {
        InstructionLabels = instructionLabels;
    }
}