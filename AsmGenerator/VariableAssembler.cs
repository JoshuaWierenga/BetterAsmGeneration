using System;
using Iced.Intel;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace AsmGenerator;

//TODO Remove
public class VariableAssembler
{
    public readonly Assembler Assembler;

    public readonly IReadOnlyDictionary<string, VariableData> Variables;

    public VariableAssembler(Assembler assembler, IReadOnlyDictionary<string, VariableData> variables)
    {
        Assembler = assembler;
        Variables = variables;
    }
}