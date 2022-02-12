using System;
using System.Collections.Generic;

namespace AsmGenerator.Asm_Source_Generator;

internal class AsmGenerationInfo
{
    public readonly IReadOnlyList<Tuple<string, List<Tuple<string, bool>>>> InstructionLabels;

    public readonly string InstructionGuid;

    //TODO Use or remove
    //public bool IncludesVariables;

    public readonly IReadOnlyList<int> VariablePositions;

    public AsmGenerationInfo(IReadOnlyList<Tuple<string, List<Tuple<string, bool>>>> instructionLabels, 
        string instructionGuid, IReadOnlyList<int> variablePositions)
    {
        InstructionLabels = instructionLabels;
        InstructionGuid = instructionGuid;
        VariablePositions = variablePositions;
    }
}
