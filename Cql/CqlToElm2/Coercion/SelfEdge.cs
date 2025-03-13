using Hl7.Cql.CqlToElm2.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Coercion;
internal class SelfEdge : CoercionEdge
{
    public SelfEdge(CoercionNode node) : base(node, node)
    {
    }

    public override CoercionCost Cost => CoercionCost.ExactMatch;

    public override Expression Convert(Expression expression) => expression;

    public override bool Equals(object? obj) => obj switch
    {
        SelfEdge other => other.From == From && other.To == To,
        _ => false
    };

    public override int GetHashCode() => HashCode.Combine(typeof(SelfEdge), From, To);

}
