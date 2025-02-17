using Hl7.Cql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Symbols;

internal class FunctionSymbol : Symbol
{
    public FunctionSymbol(string name, AccessModifier accessModifier, TypeSymbol returnType,
        params OperandSymbol[] operands) : base(name)
    {
        AccessModifier = accessModifier;
        Operands = operands.AsReadOnly();
        Type = returnType;
    }

    public override TypeSymbol Type { get; }

    public override AccessModifier AccessModifier { get; }

    public override SymbolType SymbolType => SymbolType.Function;

    public IReadOnlyList<OperandSymbol> Operands { get; private set; }

}
