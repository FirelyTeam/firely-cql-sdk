using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Hl7.Cql.Compiler.Infrastructure;

internal static class ReflectionUtility
{
    public static ConstructorInfo? ConstructorOf<T>(Expression<Func<T>> fnToCtor)
        => fnToCtor.Body is NewExpression ne
            ? ne.Constructor
            : null;

    public static MethodInfo? MethodOf(Expression<Action> fnToMethodCall)
        => fnToMethodCall.Body is MethodCallExpression mce
            ? mce.Method
            : null;

    public static MethodInfo? GenericDefinitionMethodOf(Expression<Action> fnToMethodCall) =>
        MethodOf(fnToMethodCall)
        ?.GetGenericMethodDefinition();
}