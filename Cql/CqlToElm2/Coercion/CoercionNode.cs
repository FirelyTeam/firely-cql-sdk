using Hl7.Cql.CqlToElm2.Symbols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Coercion;
internal class CoercionNode
{
    public CoercionNode(TypeSymbol type)
    {
        Type = type;
    }

    public TypeSymbol Type { get; }

    public override bool Equals(object? obj) =>
       obj switch
       {
           CoercionNode other => other.Type == Type,
           _ => false
       };

    public override int GetHashCode() => HashCode.Combine(typeof(CoercionNode), Type);

    public override string ToString() => Type.ToString();

}
