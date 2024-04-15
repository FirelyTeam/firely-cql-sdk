using System;
using System.Linq.Expressions;
using System.Reflection;
using Hl7.Cql.Compiler.Infrastructure;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler;

#pragma warning disable CS1591

internal static class CqlExpressions
{
    private static readonly Type CqlContextType = typeof(CqlContext);

    private static readonly CqlContext CqlContextInstance = default!;

    public static readonly ParameterExpression ParameterExpression = Expression.Parameter(CqlContextType, "context");

    private static readonly PropertyInfo Operators_PropertyInfo = ReflectionUtility.PropertyOf(() => CqlContextInstance.Operators);

    public static readonly MemberExpression Operators_PropertyExpression = Expression.Property(ParameterExpression, Operators_PropertyInfo);

    private static PropertyInfo Definitions_PropertyInfo = ReflectionUtility.PropertyOf(() => CqlContextInstance.Definitions);

    public static MemberExpression Definitions_PropertyExpression = Expression.Property(ParameterExpression, Definitions_PropertyInfo);

    public static ConstantExpression NullObject_ConstantExpression = CachedNullConstant<object>.Instance;

    public static ConstantExpression NullString_ConstantExpression = CachedNullConstant<string>.Instance;

    public static ConstantExpression ConstantExpressionForType<TType>() => CachedNullConstant<TType>.Instance;

    private static readonly MethodInfo _genericDefinitionMethodOfConstantExpressionForType = ReflectionUtility.GenericDefinitionMethodOf(() => ConstantExpressionForType<object>());

    public static ConstantExpression ConstantExpressionForType(Type type)
    {
        if (type == typeof(object))
        {
            return NullObject_ConstantExpression;
        }
        if (type == typeof(string))
        {
            return NullString_ConstantExpression;
        }
        return (ConstantExpression)_genericDefinitionMethodOfConstantExpressionForType
            .MakeGenericMethod(type)
            .Invoke(null, [])!;
    }

    private static class CachedNullConstant<T>
    {
        public static readonly ConstantExpression Instance = Expression.Constant(null, typeof(T));
    }
}