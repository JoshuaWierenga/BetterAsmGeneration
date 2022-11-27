using AsmLib;
using AsmToDelegate;
using Iced.Intel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static AsmLib.Instructions;
using static Iced.Intel.AssemblerRegisters;

namespace AsmGenerator.Tests;

[TestClass]
public class LabelTests
{
    [TestMethod]
    public unsafe void LoopTest()
    {
        //TODO Support AnonymousLabels and .@B, .@F
        Assembler paramsAsm = new(64);
        Label paramsLabel = paramsAsm.CreateLabel("paramsLabel");
        paramsAsm.AddInstructions
        (
            mov, rax, 0,

            EmitLabel, paramsLabel,
            inc, rax,
            cmp, rax, 5,
            jl, paramsLabel,
            ret
        );

        //Assembler stringAsm = new(bitness: 64);
        //Label stringLabel = stringAsm.CreateLabel();
        /*stringAsm.AddInstructions(/* language = asm *//* @"
            mov rax 0

stringLabel:
            inc rax
            cmp rax 5
            jl stringLabel
            ret
        ");*/


        var paramsFunc = paramsAsm.ToFunctionPointerWinX64<long>();
        //var stringFunc = stringAsm.ToFunctionPointerWinX64<long>();

        Assert.AreEqual(5, paramsFunc());
        //Assert.AreEqual(5, stringFunc());
    }
}