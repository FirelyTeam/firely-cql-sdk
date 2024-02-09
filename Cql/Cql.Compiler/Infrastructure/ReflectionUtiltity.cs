using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Hl7.Cql.Compiler.Infrastructure;

internal static class ReflectionUtility
{
    public static ConstructorInfo ConstructorOf<T>(
        Expression<Func<T>> fnToCtor, 
        [CallerArgumentExpression(nameof(fnToCtor))] string expression = "")
        => (fnToCtor.Body is NewExpression ne
            ? ne.Constructor
            : null).CheckNotNull(message: $"Expression is not a constructor: '{expression}'.");

    private static MethodInfo MethodOf(
        Expression<Action> fnToMethodCall,
        [CallerArgumentExpression(nameof(fnToMethodCall))] string expression = "")
        => (fnToMethodCall.Body is MethodCallExpression mce
            ? mce.Method
            : null).CheckNotNull(message: $"Expression is not a method: '{expression}'.");

    public static MethodInfo GenericDefinitionMethodOf(
        Expression<Action> fnToMethodCall,
        [CallerArgumentExpression(nameof(fnToMethodCall))] string expression = "") =>
        (MethodOf(fnToMethodCall, expression)
        ?.GetGenericMethodDefinition())
        .CheckNotNull(message: $"Expression is not a generic method: '{expression}'.");
}