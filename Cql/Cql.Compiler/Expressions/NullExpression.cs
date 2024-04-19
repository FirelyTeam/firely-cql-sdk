using System;
using System.Linq.Expressions;
using System.Reflection;
using Hl7.Cql.Compiler.Infrastructure;

namespace Hl7.Cql.Compiler.Expressions;

#pragma warning disable CS1591
internal static class NullExpression
{
    public static readonly ConstantExpression Object = Typed<object>.Instance;
    public static readonly ConstantExpression String = Typed<string>.Instance;
    public static readonly ConstantExpression Int32  = Typed<int?>.Instance;

    public static ConstantExpression ForType<TType>()
        => Typed<TType>.Instance;

    private static readonly MethodInfo ForType_GenericDefinitionMethodInfo =
        ReflectionUtility.GenericDefinitionMethodOf(() => ForType<object>());

    public static ConstantExpression ForType(Type type) =>
        (ConstantExpression)ForType_GenericDefinitionMethodInfo.MakeGenericMethod(type).Invoke(null, [])!;

    private static class Typed<T>
    {
        public static readonly ConstantExpression Instance = Expression.Constant(null, typeof(T));
    }
}
