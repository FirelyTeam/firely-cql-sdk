using Hl7.Cql.CqlToElm2.Symbols;
using Hl7.Cql.CqlToElm2.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Expressions;
internal abstract class Expression: Element
{
    protected Expression(TypeSymbol type)
    {
        Type = type;
    }
    public TypeSymbol Type { get; }
}
