namespace InlineAssembly;

internal static class GeneratorMemorySizes
{
    // This list allows InlineAssembly.Generator to check if a pair of tokens token are a memory size when given
    // string format assembly without having to use reflection to access the full register list directly
    // TODO Consider supporting iced memory factory size names as well
    internal static string[] MemorySizes = {
        "",
        "byte",
        "word",
        "dword",
        "qword",
        "tbyte",
        "fword",
        "xword",
        "yword",
        "zword",
    };
}
