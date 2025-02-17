using Hl7.Cql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Symbols;
internal class RefSymbol : Symbol
{
    public RefSymbol(Symbol symbol) : base($"Ref({symbol.Name})")
    {
        Symbol = symbol;
    }

    public override AccessModifier AccessModifier => AccessModifier.Public;

    public override TypeSymbol Type => Symbol.Type;

    public override SymbolType SymbolType => SymbolType.Reference;

    public Symbol Symbol { get; }
}
internal static class RefSymbolExtensions
{
    public static RefSymbol ToRef(this Symbol symbol) => symbol switch
    {
        RefSymbol => throw new ArgumentException($"Cannot create a ref to a ref"),
        _ => new RefSymbol(symbol)
    };
}