using Hl7.Cql.CqlToElm2.Expressions;
using Hl7.Cql.CqlToElm2.Symbols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Coercion;
internal class SubtypeEdge : CoercionEdge
{
    public SubtypeEdge(CoercionNode from, CoercionNode to) : base(from, to)
    {
    }

    public override CoercionCost Cost => CoercionCost.Subtype;

    // cqf cql-to-elm does not perform the as here and just returns expression
    // returning an as is more expressive and makes downstream tooling easier.
    public override Expression Convert(Expression expression) =>
        expression switch
        {
            NullExpression @null => new NullExpression(To.Type),
            _ => new AsExpression(expression, To.Type)
        };

    public override bool Equals(object? obj) => obj switch
    {
        SubtypeEdge other => other.From == From && other.To == To,
        _ => false
    };

    public override int GetHashCode() => HashCode.Combine(typeof(SubtypeEdge), From, To);


}
