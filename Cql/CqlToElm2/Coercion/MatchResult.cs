using Hl7.Cql.CqlToElm2.Expressions;
using Hl7.Cql.CqlToElm2.Symbols;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.CqlToElm2.Coercion;

internal record MatchResult(Signature Signature, IReadOnlyList<IReadOnlyList<CoercionEdge>> ArgumentConversions)
{
    public int Hops => ArgumentConversions.Sum(path => path.Count);
    public int Cost => ArgumentConversions.Sum(path => path.Sum(p => (int)p.Cost));

    public bool IsCompatible => Cost < (int)CoercionCost.Incompatible;

    private static Expression Coerce(Expression argument, IReadOnlyList<CoercionEdge> coercions) =>
        coercions.Aggregate(argument, (arg, edge) => edge.Convert(arg));

    public Expression[] CoerceArguments(IList<Expression> arguments) =>
        arguments.Select((arg, index) => Coerce(arg, ArgumentConversions[index])).ToArray();

}