using AsmGenerator;
using AsmToDelegate;
using static AsmGenerator.Instructions;
using static Iced.Intel.AssemblerRegisters;

unsafe
{
    /*var asm = CompileTimeBetterInstructionCollection.Parse
    (
        mov, rax, rcx,
        add, rax, rdx,
        ret
    );

    var addFunction = asm.ToFunctionPointerWinX64<ulong, ulong, ulong>();
    Debug.Assert(44ul == addFunction(31, 13));
    Console.WriteLine("Add two integers: 31 + 13 = " + addFunction(31, 13));*/

    //TODO Support variables
    /*var a = rcx;
    var b = rdx;
    var c = r8;
    var d = r9;

    var asm2 = CompileTimeBetterInstructionCollection.Parse
    (
        mov, rax, a,
        imul, rax, b,
        mov, rbx, c,
        imul, rbx, d,
        add, rax, rbx,
        ret
    );

    var addFunction2 = asm.ToFunctionPointerWinX64<long, long, long, long, long>();
    Debug.Assert(210L == addFunction2(5, 2, 10, 20));
    Console.WriteLine("Something complex: 5 * 2 + 10 * 20 = " + add(5, 2, 10, 20));*/

    //TODO Support constants in generated Assembler
    var asm3 = AsmGenerator.CompileTimeBetterInstructionCollection.Parse
    (
        rdtsc,
        shl, rdx, 32,
        add, rax, rdx,
        ret
    );

    var tsc = asm3.ToFunctionPointerWinX64<ulong>();
    Console.WriteLine($"{tsc()} cycles since last reset");
}