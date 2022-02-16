using AsmGenerator;
using AsmToDelegate;
using Iced.Intel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static AsmGenerator.Instructions;
using static Iced.Intel.AssemblerRegisters;

namespace AsmGenerator.Tests;

[TestClass]
public class LabelTests
{
    [TestMethod]
    public unsafe void LoopTest()
    {
        //TODO Support AnonymousLabels and .@B, .@F
        Assembler asm = new(64);
        Label label = asm.CreateLabel();

        asm.AddInstructions
        (
            mov, rax, 0,

            EmitLabel, label,
            inc, rax,
            cmp, rax, 5,
            jl, label,
            ret
        );

        var loop = asm.ToFunctionPointerWinX64<long>();

        long result = loop();
        Assert.AreEqual(result, 5);
    }
}