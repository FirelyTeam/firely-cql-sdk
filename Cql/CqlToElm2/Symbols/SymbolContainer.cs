using Hl7.Cql.CqlToElm2.Coercion;
using Hl7.Cql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Symbols;
internal abstract class SymbolContainer : Symbol
{
    protected SymbolContainer(string name, SymbolTable symbols) : base(name)
    {
        Symbols = symbols;
    }

    public SymbolTable Symbols { get; }

    public override AccessModifier AccessModifier => throw new NotImplementedException();

    public override TypeSymbol Type => throw new NotImplementedException();

    public override SymbolType SymbolType => throw new NotImplementedException();

}
