using Hl7.Cql.CqlToElm2.Expressions;
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
        OperandSymbol[] operands,
        Expression? body) : base(name, accessModifier, returnType, operands, body)
    {
    }

    public override SymbolType SymbolType => SymbolType.FluentFunction;
}
