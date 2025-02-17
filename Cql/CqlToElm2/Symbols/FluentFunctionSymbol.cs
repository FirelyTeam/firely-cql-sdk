using Hl7.Cql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Symbols;
internal class FluentFunctionSymbol : FunctionSymbol
{
    public FluentFunctionSymbol(string name,
        AccessModifier accessModifier,
        TypeSymbol returnType,
        params OperandSymbol[] operands) : base(name, accessModifier, returnType, operands)
    {
    }

    public override SymbolType SymbolType => SymbolType.FluentFunction;
}
