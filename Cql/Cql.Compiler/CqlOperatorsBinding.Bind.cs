using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;

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
        Expression[] args = arguments; // So we don't modify the original array
        var methods = ICqlOperators_MethodInfos_By_Name[methodName];

        for (int i = 0; i < 2; i++) // Try twice, first with all arguments, then without the last one
        {
            Expression[] bindArgs = new Expression[args.Length];

            foreach (var method in methods)
            {
                for (int argIndexForGenericMethod = 0;
                     argIndexForGenericMethod < Math.Min(args.Length, 2);
                     argIndexForGenericMethod++) // Try to get generic type from argument up to the second one
                {
                    MethodInfo bindMethod;
                    if (method is { IsGenericMethodDefinition: true })
                    {
                        if (!args[argIndexForGenericMethod].Type.IsGenericType)
                            continue; // Not a generic argument, try again

                        var genericType = args[argIndexForGenericMethod].Type.GetGenericArguments()[0];
                        bindMethod = method.MakeGenericMethod(genericType);
                    }
                    else
                    {
                        bindMethod = method;
                    }

                    ParameterInfo[] methodParameters = bindMethod.GetParameters();
                    if (methodParameters.Length != args.Length)
                        continue;

                    bool ConvertBindArguments()
                    {
                        for (int i = 0; i < args.Length; i++)
                        {
                            if (!TryConvert(args[i].Type, methodParameters[i].ParameterType, args[i], out bindArgs[i]!))
                                return false;
                        }
                        return true;
                    }

                    if (!ConvertBindArguments())
                        continue;

                    var call = Expression.Call(CqlContextExpressions.Operators_PropertyExpression, bindMethod, bindArgs);
                    return call;
                }
            }

            if (i == 0 && args[^1] is ConstantExpression { Value: null })
            {
                // Handles precision cases where the last argument might be supplied or not
                args = args[..^1];
                continue;
            }

            break;
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

    private static bool IsInterval(Type type) =>
        type.IsGenericType
        && type.GetGenericTypeDefinition() == typeof(CqlInterval<>);
}