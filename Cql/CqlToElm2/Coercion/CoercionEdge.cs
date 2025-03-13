using Hl7.Cql.CqlToElm2.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Coercion;
internal abstract class CoercionEdge
{
    protected CoercionEdge(CoercionNode from, CoercionNode to)
    {
        From = from;
        To = to;
    }

    public CoercionNode From { get; }

    public CoercionNode To { get; }

    public abstract CoercionCost Cost { get; }

    public abstract Expression Convert(Expression expression);

    public override string ToString() => $"{From} -> {To} [{Enum.GetName(Cost)} = {(int)Cost}]";
}
