using Hl7.Cql.Model;
using Hl7.Cql.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Symbols;
internal class ConceptSymbol: Symbol
{
    public ConceptSymbol(string name, AccessModifier accessModifier, string? display, IReadOnlyCollection<CodeSymbol> codes, TypeSymbol conceptType): base(name)
    {
        AccessModifier = accessModifier;
        Display = display;
        Codes = codes;
        Type = conceptType;
    }

    public string? Display { get; }
    public IReadOnlyCollection<CodeSymbol> Codes { get; }
    public override AccessModifier AccessModifier { get; }

    public override TypeSymbol Type { get; }

    public override SymbolType SymbolType => SymbolType.Concept;

}
