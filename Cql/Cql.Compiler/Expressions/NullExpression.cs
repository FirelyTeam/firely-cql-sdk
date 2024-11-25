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
using Hl7.Cql.Compiler.Infrastructure;

namespace Hl7.Cql.Compiler.Expressions;

#pragma warning disable CS1591
internal static class NullExpression
{
    public static readonly ConstantExpression Object = Typed<object>.Instance;
    public static readonly ConstantExpression String = Typed<string>.Instance;
    public static readonly ConstantExpression Int32 = Typed<int?>.Instance;

    public static ConstantExpression ForType<TType>()
        => Typed<TType>.Instance;

    private static readonly MethodInfo ForType_GenericDefinitionMethodInfo =
        ReflectionUtility.GenericMethodDefinitionOf(() => ForType<object>());

    public static ConstantExpression ForType(Type type) =>
        (ConstantExpression)ForType_GenericDefinitionMethodInfo.MakeGenericMethod(type).Invoke(null, [])!;

    public static bool IsNullConstant(this Expression expression) =>
        expression is ConstantExpression { Value: null };

    private static class Typed<T>
    {
        public static readonly ConstantExpression Instance = Expression.Constant(null, typeof(T));
    }
}