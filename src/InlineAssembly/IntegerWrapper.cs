using System.Runtime.InteropServices;

namespace InlineAssembly;

[StructLayout(LayoutKind.Explicit)]
internal readonly struct IntegerWrapper
{
    [FieldOffset(0)]
    internal readonly sbyte intS8 = 0;
    [FieldOffset(0)]
    internal readonly byte intU8 = 0;

    [FieldOffset(0)]
    internal readonly short intS16 = 0;
    [FieldOffset(0)]
    internal readonly ushort intU16 = 0;

    [FieldOffset(0)]
    internal readonly int intS32 = 0;
    [FieldOffset(0)]
    internal readonly uint intU32 = 0;

    [FieldOffset(0)]
    internal readonly long intS64 = 0;
    [FieldOffset(0)]
    internal readonly ulong intU64 = 0;

    internal IntegerWrapper(byte intU8)
    {
        this.intU8 = intU8;
    }
    internal IntegerWrapper(sbyte intS8)
    {
        this.intS8 = intS8;
    }

    internal IntegerWrapper(ushort intU16)
    {
        this.intU16 = intU16;
    }
    internal IntegerWrapper(short intS16)
    {
        this.intS16 = intS16;
    }

    internal IntegerWrapper(uint intU32)
    {
        this.intU32 = intU32;
    }
    internal IntegerWrapper(int intS32)
    {
        this.intS32 = intS32;
    }

    internal IntegerWrapper(ulong intU64)
    {
        this.intU64 = intU64;
    }
    internal IntegerWrapper(long intS64)
    {
        this.intS64 = intS64;
    }
}
