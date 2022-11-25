using AsmLib;
using AsmToDelegate;
using Iced.Intel;
using System;
using System.Diagnostics;
using static AsmLib.Instructions;
using static Iced.Intel.AssemblerRegisters;

unsafe
{
    Assembler asm = new(bitness: 64);
    asm.AddInstructions( /* language = asm */ """
        mov rax rcx
        add rax rdx
        ret
    """);

    var addFunction = asm.ToFunctionPointerWinX64<ulong, ulong, ulong>();
    Debug.Assert(44ul == addFunction(31, 13));
    Console.WriteLine("Add two integers: 31 + 13 = " + addFunction(31, 13));

    AssemblerRegister64 a, b, c, d;

    Assembler asm2 = new(bitness: 64);
    asm2.AddVariables
    (
        a = rcx,
        b = rdx,
        c = r8,
        d = r9
    ).AddInstructions
    (
        mov, rax, a,
        imul, rax, b,
        mov, rbx, c,
        imul, rbx, d,
        add, rax, rbx,
        ret
    );

    var addFunction2 = asm2.ToFunctionPointerWinX64<long, long, long, long, long>();
    Debug.Assert(210L == addFunction2(5, 2, 10, 20));
    Console.WriteLine("Something complex: 5 * 2 + 10 * 20 = " + addFunction2(5, 2, 10, 20));

    Assembler asm3 = new(bitness: 64);
    asm3.AddInstructions
    (
        rdtsc,
        shl, rdx, 32,
        add, rax, rdx,
        ret
    );

    var tsc = asm3.ToFunctionPointerWinX64<ulong>();
    Console.WriteLine($"{tsc()} cycles since last reset");
}
