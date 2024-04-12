using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Hl7.Cql.Operators;

namespace Hl7.Cql.Compiler;

#pragma warning disable CS1591
partial class CqlOperatorsBinding
{
    private static readonly IReadOnlyDictionary<string, MethodInfo[]> ICqlOperators_MethodInfos_By_Name =
        typeof(ICqlOperators)
        .GetMethods(BindingFlags.Instance | BindingFlags.Public)
        .GroupBy(m => m.Name)
        .ToDictionary(m => m.Key, m => m.ToArray());

    private static readonly ConstantExpression NullObject_ConstantExpression = Expression.Constant(null, typeof(object));

    private MethodCallExpression? BindToMethodConvertArgsOrNull(
        string methodName,
        params Expression[] arguments)
    {
        var methods = ICqlOperators_MethodInfos_By_Name[methodName];

        foreach (var method in methods)
        {
            MethodInfo bindMethod;
            if (method is { IsGenericMethodDefinition: true })
            {
                var genericType = arguments switch
                {
                [{ }, { Type.IsGenericType: true } a1, ..] => a1.Type.GetGenericArguments()[0],
                [{ } a0, ..] => a0.Type.GetGenericArguments()[0],
                    _ => null!, // Can't happen
                };
                bindMethod = method.MakeGenericMethod(genericType);
            }
            else
            {
                bindMethod = method;
            }

            ParameterInfo[] methodParameters = bindMethod.GetParameters();
            if (methodParameters.Length != arguments.Length)
                continue;

            Expression[]? ConvertArguments()
            {
                Expression[] arr = new Expression[arguments.Length];
                for (int i = 0; i < arguments.Length; i++)
                {
                    if (!TryConvert(arguments[i].Type, methodParameters[i].ParameterType, arguments[i], out arr[i]!))
                        return null;
                }
                return arr;
            }

            var bindArguments = ConvertArguments();
            if (bindArguments is null)
                continue;

            var call = Expression.Call(CqlContextExpressions.Operators_PropertyExpression, bindMethod, bindArguments);
            return call;
        }

        return null;
    }


    private MethodCallExpression BindToMethodConvertArgs(
        string methodName,
        params Expression[] arguments)
    {
        return BindToMethodConvertArgsOrNull(methodName, arguments)
            ?? throw NoMethodFoundException();

        ArgumentException NoMethodFoundException()
        {
            var types = string.Join(", ", arguments.Select(e => e.Type.Name));
            return new ArgumentException($"No suitable method found {methodName}({types}).", nameof(methodName));
        }
    }

    private static MethodCallExpression BindToMethod(
        string methodName,
        params Expression[] arguments) =>
        Expression.Call(CqlContextExpressions.Operators_PropertyExpression, methodName, null, arguments);

    private static MethodCallExpression BindToMethod(
        string methodName,
        Type[] typeArguments,
        params Expression[] arguments) =>
        Expression.Call(CqlContextExpressions.Operators_PropertyExpression, methodName, typeArguments, arguments);

    private static MethodCallExpression BindToMethod(
        MethodInfo method,
        params Expression[] expressions) =>
        Expression.Call(CqlContextExpressions.Operators_PropertyExpression, method, expressions);
}