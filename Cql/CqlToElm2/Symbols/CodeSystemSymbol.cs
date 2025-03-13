using Hl7.Cql.Model;
using Hl7.Cql.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Symbols;
internal class CodeSystemSymbol : Symbol
{
    public CodeSystemSymbol(string name, AccessModifier accessModifier, string uri, Version version, TypeSymbol type) : base(name)
    {
        AccessModifier = accessModifier;
        Uri = uri;
        Version = version;
        Type = type;
    }

    public override AccessModifier AccessModifier { get; }
    public string Uri { get; }
    public Version Version { get; }
    public override TypeSymbol Type { get; }

    public override SymbolType SymbolType => SymbolType.CodeSystem;
}
