using AsmToDelegate;
using Iced.Intel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using static AsmGenerator.Instructions;
using static Iced.Intel.AssemblerRegisters;

namespace AsmGenerator.Tests;

[TestClass]
public unsafe class VectorTests
{
    [TestMethod]
    public void Sse2AdditionTest()
    {
        Vector128<int> lower = Vector128.Create(1, 2, 3, 4);
        Vector128<int> upper = Vector128.Create(5, 6, 7, 8);
        Vector128<int> result = Vector128<int>.Zero;

        //TODO Automate this conversion and figure out a way to actually return a vector
        //I tried returning a pointer to a vector but couldn't convert that back to a C# vector type
        void* pLower = Unsafe.AsPointer(ref lower);
        void* pUpper = Unsafe.AsPointer(ref upper);
        void* pResult = Unsafe.AsPointer(ref result);
        IntPtr iLower = new(pLower);
        IntPtr iUpper = new(pUpper);
        IntPtr iResult = new(pResult);

        Assembler asmVec = new(64);
        //TODO Support both AssemblerMemoryOperandBuilder and Vector{64, 128, 256} directly, no real option for 512 until C# supports it
        asmVec.AddInstructions(
            movdqa, xmm0, __[rcx],
            movdqa, xmm1, __[rdx],
            paddd, xmm0, xmm1,
            movdqa, __[r8], xmm0,
            ret
        );

        var vectorAdd =
            asmVec.ToFunctionPointerWinX64<IntPtr, IntPtr, IntPtr, byte>();

        vectorAdd(iLower, iUpper, iResult);
        Assert.AreEqual(Sse2.Add(lower, upper), result);
    }
}
