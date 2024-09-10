/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System.Linq.Expressions;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Facilitates binding to <see cref="CqlContext"/> methods.
/// </summary>
internal class CqlContextBinder()
{
    /// <summary>
    /// Creates an expression which resolves a parameter in the CQL context,
    /// by binding to calling <see cref="CqlContext.ResolveParameter"/>.
    /// </summary>
    /// <param name="libraryKey">The key of the library containing the parameter.</param>
    /// <param name="parameterName">The name of the parameter.</param>
    /// <param name="defaultValue">The default value of the parameter.</param>
    /// <returns>The resolved parameter expression.</returns>
    public virtual Expression ResolveParameter(
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
