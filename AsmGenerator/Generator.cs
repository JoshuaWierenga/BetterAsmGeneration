using Iced.Intel;

namespace AsmGenerator;

public static class Generator
{
    public static Assembler AddVariables(this Assembler assembler, params VariableData[] _)
    {
        // Variables are handled by the source generator, this function is only here to ensure compilation is possible
        return assembler;
    }
}