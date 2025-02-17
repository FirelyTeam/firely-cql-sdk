using Hl7.Cql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Symbols;
internal class CodeSymbol : Symbol
{
    public CodeSymbol(string name, AccessModifier accessModifier, string code, string? display, CodeSystemSymbol codeSystem, TypeSymbol type) : base(name)
    {
        AccessModifier = accessModifier;
        Code = code;
        Display = display;
        CodeSystem = codeSystem;
        Type = type;
    }

    public override AccessModifier AccessModifier { get; }
    public string Code { get; }
    public string? Display { get; }
    public CodeSystemSymbol CodeSystem { get; }
    public override TypeSymbol Type { get; }

    public override SymbolType SymbolType => SymbolType.Code;

}