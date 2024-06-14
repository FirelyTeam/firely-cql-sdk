/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Hl7.Cql.Compiler.Infrastructure;


/// <summary>
/// Utility class for reflection operations.
/// </summary>
internal static class ReflectionUtility
{
    /// <summary>
    /// Retrieves the constructor information for the specified constructor call expression.
    /// </summary>
    /// <typeparam name="T">The type to retrieve the constructor for.</typeparam>
    /// <param name="fnToCtor">The expression representing the constructor.</param>
    /// <param name="expression">The expression string.</param>
    /// <returns>The constructor information.</returns>
    public static ConstructorInfo ConstructorOf<T>(
        Expression<Func<T>> fnToCtor,
        [CallerArgumentExpression(nameof(fnToCtor))] string expression = "") =>
        (fnToCtor.Body is NewExpression ne
            ? ne.Constructor
            : null)
            ?? throw new InvalidOperationException($"Expression is not a constructor: '{expression}'.");

    /// <summary>
    /// Retrieves the method information for the specified method call expression.
    /// </summary>
    /// <param name="fnToMethodCall">The expression representing the method call.</param>
    /// <param name="expression">The expression string.</param>
    /// <returns>The method information.</returns>
    public static MethodInfo MethodOf(
        Expression<Action> fnToMethodCall,
        [CallerArgumentExpression(nameof(fnToMethodCall))] string expression = "") =>
        (fnToMethodCall.Body is MethodCallExpression mce
            ? mce.Method
            : null)
            ?? throw new InvalidOperationException($"Expression is not a method: '{expression}'.");

    /// <summary>
    /// Retrieves the member information for the specified member expression.
    /// </summary>
    /// <param name="fnToMember">The expression representing the member.</param>
    /// <param name="expression">The expression string.</param>
    /// <returns>The member information.</returns>
    private static MemberInfo MemberOf<T>(
        Expression<Func<T>> fnToMember,
        [CallerArgumentExpression(nameof(fnToMember))] string expression = "") =>
        (fnToMember.Body is MemberExpression mce
            ? mce.Member
            : null)
            ?? throw new InvalidOperationException($"Expression is not a member: '{expression}'.");

    /// <summary>
    /// Retrieves the member information for the specified property expression.
    /// </summary>
    /// <param name="fnToProperty">The expression representing the property.</param>
    /// <param name="expression">The expression string.</param>
    /// <returns>The property information.</returns>
    public static PropertyInfo PropertyOf<T>(
        Expression<Func<T>> fnToProperty,
        [CallerArgumentExpression(nameof(fnToProperty))] string expression = "") =>
        MemberOf(fnToProperty, expression) as PropertyInfo
        ?? throw new InvalidOperationException($"Expression is not a property: '{expression}'.");

    /// <summary>
    /// Retrieves the generic method definition for the specified method call expression.
    /// </summary>
    /// <param name="fnToMethodCall">The expression representing the method call.</param>
    /// <param name="expression">The expression string.</param>
    /// <returns>The generic method definition.</returns>
    public static MethodInfo GenericMethodDefinitionOf(
        Expression<Action> fnToMethodCall,
        [CallerArgumentExpression(nameof(fnToMethodCall))] string expression = "") =>
        (MethodOf(fnToMethodCall, expression)
            ?.GetGenericMethodDefinition())
            ?? throw new InvalidOperationException($"Expression is not a generic method: '{expression}'.");
}