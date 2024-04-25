/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Linq.Expressions;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Operators;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Binds <see cref="CqlOperator"/>s to <see cref="Expression"/>s.
/// </summary>
internal abstract class OperatorsBinder
{
    /// <summary>
    /// Binds a <paramref name="methodName"/> on <see cref="ICqlOperators"/> to an <see cref="Expression"/>.
    /// </summary>
    /// <param name="methodName">The method to bind to.</param>
    /// <param name="args">The arguments that will be bound to the closest matching overload.</param>
    /// <returns>A <see cref="MethodCallExpression"/> that binds to a method on <see cref="ICqlOperators"/>.</returns>
    public abstract Expression BindToMethod(
        string methodName,
        params Expression[] args);

    /// <summary>
    /// Converts the given <paramref name="expression"/> to the specified type <paramref name="type"/>.
    /// </summary>
    /// <param name="expression">The expression to convert.</param>
    /// <param name="type">The type to convert the expression to.</param>
    /// <returns>The converted expression.</returns>
    public abstract Expression ConvertToType(Expression expression, Type type);

    /// <summary>
    /// Converts the given <paramref name="expression"/> to the specified type <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The type to convert the expression to.</typeparam>
    /// <param name="expression">The expression to convert.</param>
    /// <returns>The converted expression.</returns>
    public Expression ConvertToType<T>(Expression expression) =>
        ConvertToType(expression, typeof(T));

    /// <summary>
    /// Casts the given <paramref name="expression"/> to the specified type <paramref name="type"/>.
    /// </summary>
    /// <param name="expression">The expression to cast.</param>
    /// <param name="type">The type to cast the expression to.</param>
    /// <returns>The expression that was cast.</returns>
    public abstract Expression CastToType(Expression expression, Type type);
}