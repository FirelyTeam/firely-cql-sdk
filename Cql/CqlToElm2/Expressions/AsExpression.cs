using Hl7.Cql.CqlToElm2.Symbols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Expressions;
internal class AsExpression : Expression
{
    public AsExpression(Expression expression, TypeSymbol type): base(type)
    {
        Expression = expression;
    }
    public Expression Expression { get; }
}
