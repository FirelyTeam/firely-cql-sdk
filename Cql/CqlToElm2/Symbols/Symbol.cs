using Hl7.Cql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Symbols;
internal abstract class Symbol
{
    protected Symbol(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public abstract AccessModifier AccessModifier { get; }

    public List<Error> Errors { get; } = new();

    public abstract TypeSymbol Type { get; }

    public abstract SymbolType SymbolType { get; }



    public override string ToString() => Name;
    public override bool Equals(object? obj) => obj is Symbol symbol && Name == symbol.Name;
    public override int GetHashCode() => HashCode.Combine(Name);
}