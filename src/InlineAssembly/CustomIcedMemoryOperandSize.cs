namespace InlineAssembly;

// Keep in sync with https://github.com/icedland/iced/blob/master/src/csharp/Intel/Iced/Intel/Assembler/MemoryOperandSize.g.cs
// TODO Add Iced as submodule and just include the file directly
internal enum CustomIcedMemoryOperandSize
{
    None,
    Byte,
    Word,
    Dword,
    Qword,
    Tbyte,
    Fword,
    Xword,
    Yword,
    Zword,
}
