using System.Linq.Expressions;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler;

internal class CqlContextBinder : ContextBinder
{
    public override Expression ResolveParameter(
        string libraryKey,
        string parameterName,
        Expression defaultValue) =>
        Expression.Call(
            CqlExpressions.ParameterExpression,
            nameof(CqlContext.ResolveParameter),
            null,
            Expression.Constant(libraryKey),
            Expression.Constant(parameterName),
            defaultValue
        );
}