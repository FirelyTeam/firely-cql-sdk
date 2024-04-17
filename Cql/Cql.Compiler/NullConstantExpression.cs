using System;
using System.Linq.Expressions;
using System.Reflection;
using Hl7.Cql.Compiler.Infrastructure;

namespace Hl7.Cql.Compiler;

#pragma warning disable CS1591
internal class NullConstantExpression
{
    public static ConstantExpression Object = Typed<object>.Instance;
    public static ConstantExpression String = Typed<string>.Instance;

    public static ConstantExpression ForType<TType>()
        => Typed<TType>.Instance;

    private static readonly MethodInfo _genericDefinitionMethodOfNull_ConstantExpression = ReflectionUtility.GenericDefinitionMethodOf(() => ForType<object>());

    public static ConstantExpression ForType(Type type)
    {
        if (type == typeof(object))
        {
            return Object;
        }
        if (type == typeof(string))
        {
            return String;
        }
        return (ConstantExpression)_genericDefinitionMethodOfNull_ConstantExpression
            .MakeGenericMethod(type)
            .Invoke(null, [])!;
    }

    private static class Typed<T>
    {
        public static readonly ConstantExpression Instance = Expression.Constant(null, typeof(T));
    }
}