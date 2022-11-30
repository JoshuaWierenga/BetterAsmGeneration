using System;
using System.Runtime.CompilerServices;
using AsmToDelegate;
using Iced.Intel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static InlineAssembly.Instructions;
using static Iced.Intel.AssemblerRegisters;

namespace InlineAssembly.Tests;

[TestClass]
public unsafe class IndirectAddressingTests
{
    [TestMethod]
    public void DefaultSizeTest()
    {
        int input = 5;
        int paramsOutput = 1;
        int stringOutput = 1;
        IntPtr iInput = new(Unsafe.AsPointer(ref input));
        IntPtr iParamsOutput = new(Unsafe.AsPointer(ref paramsOutput));
        IntPtr iStringOutput = new(Unsafe.AsPointer(ref stringOutput));

        Assembler paramsAsm = new(bitness: 64);
        paramsAsm.AddInstructions(
            mov, eax, __[rcx],
            inc, eax,
            mov, __[rdx], eax,
            ret
        );

        Assembler stringAsm = new(bitness: 64);
        stringAsm.AddInstructions(/* language = asm */ @"
            mov eax [rcx]
            inc eax
            mov [rdx] eax
            ret
        ");

        var paramsFunc = paramsAsm.ToFunctionPointerWinX64<IntPtr, IntPtr, byte>();
        var stringFunc = stringAsm.ToFunctionPointerWinX64<IntPtr, IntPtr, byte>();

        paramsFunc(iInput, iParamsOutput);
        stringFunc(iInput, iStringOutput);
        Assert.AreEqual(6, paramsOutput);
        Assert.AreEqual(6, stringOutput);
    }

    [TestMethod]
    public void CustomSizeTest()
    {
        int paramsValue = 5;
        int stringValue = 5;
        IntPtr iParamsValue = new(Unsafe.AsPointer(ref paramsValue));
        IntPtr iStringValue = new(Unsafe.AsPointer(ref stringValue));

        Assembler paramsAsm = new(bitness: 64);
        paramsAsm.AddInstructions(
            inc, __dword_ptr[rcx],
            ret
        );

        Assembler stringAsm = new(bitness: 64);
        stringAsm.AddInstructions(/* language = asm */ @"
            inc DWORD PTR [rcx]
            ret
        ");

        var paramsFunc = paramsAsm.ToFunctionPointerWinX64<IntPtr, byte>();
        var stringFunc = stringAsm.ToFunctionPointerWinX64<IntPtr, byte>();

        paramsFunc(iParamsValue);
        stringFunc(iStringValue);
        Assert.AreEqual(6, paramsValue);
        Assert.AreEqual(6, stringValue);
    }
}
