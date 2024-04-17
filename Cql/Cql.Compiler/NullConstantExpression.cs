using System;
using System.Linq.Expressions;
using System.Reflection;
using Hl7.Cql.Compiler.Infrastructure;

namespace Hl7.Cql.Compiler;

#pragma warning disable CS1591
internal static class NullConstantExpression
{
    public static ConstantExpression Object = Typed<object>.Instance;
    public static ConstantExpression String = Typed<string>.Instance;
    public static ConstantExpression Int32  = Typed<int?>.Instance;

    public static ConstantExpression ForType<TType>()
        => Typed<TType>.Instance;

    private static readonly MethodInfo _ForType_GenericDefinitionMethodInfo =
        ReflectionUtility.GenericDefinitionMethodOf(() => ForType<object>());

    public static ConstantExpression ForType(Type type) =>
        (ConstantExpression)_ForType_GenericDefinitionMethodInfo.MakeGenericMethod(type).Invoke(null, [])!;

    private static class Typed<T>
    {
        public static readonly ConstantExpression Instance = Expression.Constant(null, typeof(T));
    }
}
