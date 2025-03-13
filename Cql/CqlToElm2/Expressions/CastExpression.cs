using Hl7.Cql.CqlToElm2.Symbols;
using System.Collections.Generic;

namespace Hl7.Cql.CqlToElm2.Expressions;

internal class CastExpression : Expression
{
    public CastExpression(Expression expression, TypeSymbol type): base(type)
    {
        Expression = expression;
    }
    public Expression Expression { get; }

}