using System;
using System.Linq.Expressions;
using System.Reflection;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler;

#pragma warning disable CS1591
internal class CqlContextExpressions
{
    /// <summary>
    /// The context parameter for expressions.
    /// </summary>
    public static readonly ParameterExpression CqlContext_Parameter = Expression.Parameter(typeof(CqlContext), "context");

    public static readonly MemberExpression CqlContext_Operators_Property = Expression.Property(CqlContext_Parameter, PropertyInfos.CqlContext_Operators);
    public static Type CqlContext_Operators_Type => CqlContext_Operators_Property.Type; // ICqlOperators;

    public static readonly MemberExpression CqlContext_Definitions_Property = Expression.Property(CqlContext_Parameter, PropertyInfos.CqlContext_Definitions);

    public static MethodCallExpression Call_CqlContext_Operators(
        MethodInfo methodName,
        params Expression[]? arguments) =>
        Expression.Call(CqlContext_Operators_Property, methodName, arguments);
}