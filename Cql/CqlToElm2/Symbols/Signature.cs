using Hl7.Cql.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Symbols;
[DebuggerDisplay("{ToString()}")]
internal class Signature
{
    public Signature(params TypeSymbol[] operands)
    {
        Operands = operands.AsReadOnly();
    }

    public bool IsGeneric => Operands.Any(o => o.TypeDefinition switch
    {
        GenericTypeDefinition or GenericArgumentType => true,
        _ => false
    });

    public IReadOnlyList<TypeSymbol> Operands { get; private set; }

    public override string ToString() => $"({string.Join(", ", Operands.Select(o=>o.ToString()))})";

    public override int GetHashCode() {
        var code = new HashCode();
        code.Add(typeof(Signature));
        foreach (var operand in Operands)
            code.Add(operand);
        return code.ToHashCode();
    }

    public override bool Equals(object? obj) =>
        obj switch
        {
            Signature signature => Operands.SequenceEqual(signature.Operands),
            _ => false
        };
}

