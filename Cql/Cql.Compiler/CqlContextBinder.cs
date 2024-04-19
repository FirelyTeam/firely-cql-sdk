using System.Linq.Expressions;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Represents a binder to <see cref="CqlContext"/>.
/// </summary>
internal class CqlContextBinder : ContextBinder
{
    /// <summary>
    /// Creates an expression which resolves a parameter in the CQL context,
    /// by binding to calling <see cref="CqlContext.ResolveParameter"/>.
    /// </summary>
    /// <param name="libraryKey">The key of the library containing the parameter.</param>
    /// <param name="parameterName">The name of the parameter.</param>
    /// <param name="defaultValue">The default value of the parameter.</param>
    /// <returns>The resolved parameter expression.</returns>
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
