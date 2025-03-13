using Hl7.Cql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Symbols;
internal class OperandSymbol : Symbol
{
    public OperandSymbol(string name, TypeSymbol operandType) : base(name)
    {
        Type = operandType;
    }

    public override TypeSymbol Type { get; }

    public override AccessModifier AccessModifier => AccessModifier.Public;

    public override SymbolType SymbolType => SymbolType.Operand;

}
