using Hl7.Cql.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Symbols;
internal class ValueSetSymbol : Symbol
{
    public ValueSetSymbol(string name, AccessModifier accessModifier, string uri, Version version, IReadOnlyCollection<CodeSystemSymbol> codeSystems, TypeSymbol valueSetType) : base(name)
    {
        AccessModifier = accessModifier;
        Uri = uri;
        Version = version;
        CodeSystems = codeSystems;
        Type = valueSetType;
    }

    public override AccessModifier AccessModifier { get; }
    public string Uri { get; }
    public Version Version { get; }
    public IReadOnlyCollection<CodeSystemSymbol> CodeSystems { get; }
    public override TypeSymbol Type { get; }

    public override SymbolType SymbolType => SymbolType.ValueSet;
}
