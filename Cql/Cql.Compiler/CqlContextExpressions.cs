using System;
using System.Linq.Expressions;
using System.Reflection;
using Hl7.Cql.Compiler.Infrastructure;
using Hl7.Cql.Operators;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler;

#pragma warning disable CS1591

internal class CqlContextExpressions
{
    private static readonly Type CqlContextType = typeof(CqlContext);
    private static readonly CqlContext CqlContext = default!;

    public static readonly ParameterExpression ParameterExpression = Expression.Parameter(CqlContextType, "context");

    private static PropertyInfo Operators_PropertyInfo { get; } = ReflectionUtility.PropertyOf(() => CqlContext.Operators);

    public static MemberExpression Operators_PropertyExpression { get; } = Expression.Property(ParameterExpression, Operators_PropertyInfo);

    public static MethodCallExpression Operators_MethodCallExpression(
        MethodInfo methodInfo,
        params Expression[]? arguments)
    {
        var call = Expression.Call(Operators_PropertyExpression, methodInfo, arguments);
        return call;
    }

    public static MethodCallExpression Operators_MethodCallExpression(
        string methodName,
        params Expression[]? arguments)
    {
        var call = Expression.Call(Operators_PropertyExpression, methodName, null, arguments);
        return call;
    }

    public static MethodCallExpression Operators_MethodCallExpression(
        MethodInfo methodInfo,
        Type[] typeArguments,
        params Expression[]? arguments)
    {
        var call = Expression.Call(Operators_PropertyExpression, methodInfo.MakeGenericMethod(typeArguments), arguments);
        return call;
    }

    public static MethodCallExpression Operators_MethodCallExpression(
        string methodName,
        Type[] typeArguments,
        params Expression[]? arguments)
    {
        var call = Expression.Call(Operators_PropertyExpression, methodName, typeArguments, arguments);
        return call;
    }


    private static PropertyInfo Definitions_PropertyInfo { get; } = ReflectionUtility.PropertyOf(() => CqlContext.Definitions);

    public static MemberExpression Definitions_PropertyExpression { get; } = Expression.Property(ParameterExpression, Definitions_PropertyInfo);
}

internal class ICqlOperatorsExpressions
{
    public static readonly Type ICqlOperatorsType = typeof(ICqlOperators);

    private static readonly ICqlOperators ICqlOperators = default!;

    /// <summary>
    /// ICqlOperators.Convert&lt;T&gt;(object?) method.
    /// </summary>
    private static MethodInfo Convert_GenericMethodDefinition { get; } = ReflectionUtility.MethodOf(() => ICqlOperators.Convert<object>(default!)).GetGenericMethodDefinition();

    /// <summary>
    /// ICqlOperators.Convert&lt;convertToType&gt;(source as object)
    /// </summary>
    public static MethodCallExpression Convert_MethodCallExpression(
        Type convertToType,
        Expression source)
    {
        source = Expression.TypeAs(source, typeof(object));
        MethodCallExpression call = CqlContextExpressions.Operators_MethodCallExpression(nameof(ICqlOperators.Convert), [convertToType], source);
        return call;
    }
}