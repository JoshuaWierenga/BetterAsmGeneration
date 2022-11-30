using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using AsmToDelegate;
using Iced.Intel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static InlineAssembly.Instructions;
using static Iced.Intel.AssemblerRegisters;

namespace InlineAssembly.Tests;

[TestClass]
public unsafe class VectorTests
{
    [TestMethod]
    public void Sse2AdditionTest()
    {
        Vector128<int> lower = Vector128.Create(1, 2, 3, 4);
        Vector128<int> upper = Vector128.Create(5, 6, 7, 8);
        Vector128<int> paramsResult = Vector128<int>.Zero;
        Vector128<int> stringResult = Vector128<int>.Zero;

        //TODO Automate this conversion and figure out a way to actually return a vector
        //I tried returning a pointer to a vector but couldn't convert that back to a C# vector type
        void* pLower = Unsafe.AsPointer(ref lower);
        void* pUpper = Unsafe.AsPointer(ref upper);
        void* pParamsResult = Unsafe.AsPointer(ref paramsResult);
        void* pStringResult = Unsafe.AsPointer(ref stringResult);
        IntPtr iLower = new(pLower);
        IntPtr iUpper = new(pUpper);
        IntPtr iParamsResult = new(pParamsResult);
        IntPtr iStringResult = new(pStringResult);

        Assembler paramsAsm = new(bitness: 64);
        //TODO Support both AssemblerMemoryOperandBuilder and Vector{64, 128, 256} directly, no real option for 512 until C# supports it
        paramsAsm.AddInstructions(
            movdqa, xmm0, __[rcx],
            movdqa, xmm1, __[rdx],
            paddd, xmm0, xmm1,
            movdqa, __[r8], xmm0,
            ret
        );

        Assembler stringAsm = new(bitness: 64);
        stringAsm.AddInstructions(/* language = asm */ @"
            movdqa xmm0 [rcx]
            movdqa xmm1 [rdx]
            paddd xmm0 xmm1
            movdqa [r8] xmm0
            ret
        ");

        var paramsFunc = paramsAsm.ToFunctionPointerWinX64<IntPtr, IntPtr, IntPtr, byte>();
        var stringFunc = stringAsm.ToFunctionPointerWinX64<IntPtr, IntPtr, IntPtr, byte>();

        paramsFunc(iLower, iUpper, iParamsResult);
        stringFunc(iLower, iUpper, iStringResult);
        Assert.AreEqual(Sse2.Add(lower, upper), paramsResult);
        Assert.AreEqual(Sse2.Add(lower, upper), stringResult);
    }

    //From https://github.com/lazear/assembly/blob/d1baab8/vectors.asm#L81-L92
    [TestMethod]
    public void See3MagnitudeTest()
    {
        Vector128<float> input = Vector128.Create(1.0f, 2.0f, 3.0f, 4.0f);
        Vector128<float> paramsResult = Vector128<float>.Zero;
        Vector128<float> stringResult = Vector128<float>.Zero;

        Vector128<float> cSharpResult = Sse.Multiply(input, input);
        cSharpResult = Sse3.HorizontalAdd(cSharpResult, cSharpResult);
        cSharpResult = Sse3.HorizontalAdd(cSharpResult, cSharpResult);
        cSharpResult = Sse.Sqrt(cSharpResult);

        void* pInput = Unsafe.AsPointer(ref input);
        void* pParamsResult = Unsafe.AsPointer(ref paramsResult);
        void* pStringResult = Unsafe.AsPointer(ref stringResult);
        IntPtr iInput = new(pInput);
        IntPtr iParamsResult = new(pParamsResult);
        IntPtr iStringResult = new(pStringResult);

        Assembler paramsAsm = new(bitness: 64);
        paramsAsm.AddInstructions(
            movaps, xmm0, __[rcx],
            mulps, xmm0, xmm0,
            haddps, xmm0, xmm0,
            haddps, xmm0, xmm0,
            sqrtps, xmm0, xmm0,
            movaps, __[rdx], xmm0,
            ret
        );

        Assembler stringAsm = new(bitness: 64);
        stringAsm.AddInstructions(/* language = asm */ @"
            movaps xmm0 [rcx]
            mulps xmm0 xmm0
            haddps xmm0 xmm0
            haddps xmm0 xmm0
            sqrtps xmm0 xmm0
            movaps [rdx] xmm0
            ret
        ");

        var paramsFunc = paramsAsm.ToFunctionPointerWinX64<IntPtr, IntPtr, byte>();
        var stringFunc = stringAsm.ToFunctionPointerWinX64<IntPtr, IntPtr, byte>();

        paramsFunc(iInput, iParamsResult);
        stringFunc(iInput, iStringResult);
        Assert.AreEqual(cSharpResult, paramsResult);
        Assert.AreEqual(cSharpResult, stringResult);
    }
}
