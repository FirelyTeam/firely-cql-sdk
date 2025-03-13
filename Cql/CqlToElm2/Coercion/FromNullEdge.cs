using Hl7.Cql.CqlToElm2.Expressions;
using Hl7.Cql.CqlToElm2.Symbols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Coercion;
internal class FromNullEdge : CoercionEdge
{
    public FromNullEdge(CoercionNode anyNode, CoercionNode to) : base(anyNode, to)
    {
    }

    public override CoercionCost Cost => CoercionCost.FromNull;

    public override Expression Convert(Expression expression) => new NullExpression(To.Type);

    public override bool Equals(object? obj) => obj switch
    {
        FromNullEdge other => other.To == To,
        _ => false
    };

    public override int GetHashCode() => HashCode.Combine(typeof(FromNullEdge), To);
}
