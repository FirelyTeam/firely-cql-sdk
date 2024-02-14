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
    private static MethodInfo MethodOf(
        Expression<Action> fnToMethodCall,
        [CallerArgumentExpression(nameof(fnToMethodCall))] string expression = "") =>
        (fnToMethodCall.Body is MethodCallExpression mce
            ? mce.Method
            : null) 
            ?? throw new InvalidOperationException($"Expression is not a method: '{expression}'.");

    /// <summary>
    /// Retrieves the generic method definition for the specified method call expression.
    /// </summary>
    /// <param name="fnToMethodCall">The expression representing the method call.</param>
    /// <param name="expression">The expression string.</param>
    /// <returns>The generic method definition.</returns>
    public static MethodInfo GenericDefinitionMethodOf(
        Expression<Action> fnToMethodCall,
        [CallerArgumentExpression(nameof(fnToMethodCall))] string expression = "") =>
        (MethodOf(fnToMethodCall, expression)
            ?.GetGenericMethodDefinition())
            ?? throw new InvalidOperationException($"Expression is not a generic method: '{expression}'.");

    /// <summary>
    /// Checks if the specified type is nullable.
    /// </summary>
    /// <param name="type">The type to check.</param>
    /// <returns>True if the type is nullable, false otherwise.</returns>
    public static bool IsNullable(this Type type) => type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
}
