using AsmLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static AsmLib.Instructions;
using static Iced.Intel.AssemblerRegisters;

namespace AsmGenerator.Tests;

[TestClass]
public class FormatTests
{
    [TestMethod]
    public void FormatMatchTest()
    {
        string paramsGuid = AssemblyData.GetGuidParams(new AssemblyData[]
        {
            mov, rax, 3,
            ret
        });

        string stringGuid = AssemblyData.GetGuidString(@"
            mov rax 3
            ret
        ");

        Assert.AreEqual(paramsGuid, stringGuid);
    }

    [TestMethod]
    public void StringFormatFormattingIndependentTest()
    {
        string stringGuid1 = AssemblyData.GetGuidString(@"
            mov rax 3
            ret
        ");

        string stringGuid2 = AssemblyData.GetGuidString(@"
            mov rax 
3

                         ret
        ");

        Assert.AreEqual(stringGuid1, stringGuid2);
    }
}