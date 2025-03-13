using Hl7.Cql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Symbols;
internal class LibrarySymbol : SymbolContainer
{
    public LibrarySymbol(string name, Version version, SymbolTable symbols) : base(name, symbols)
    {
        Version = version;
    }

    public Version Version { get; }


    public override AccessModifier AccessModifier => AccessModifier.Public;

    public override SymbolType SymbolType => SymbolType.Library;

    public override TypeSymbol Type => throw new NotImplementedException();

    public LibrarySymbol Alias(string name) => new LibrarySymbol(name, Version, Symbols);

}
