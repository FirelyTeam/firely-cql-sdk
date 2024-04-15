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

    /// <summary>
    ///
    /// <para>
    /// This method tries to match the method name with the arguments against the ICqlOperators methods.
    /// It also converts the arguments to the correct types if necessary.
    /// It returns the MethodInfo and the converted arguments, if successful.
    /// If no method is found, it throws an ArgumentException when <param name="throwError"></param> is <c>true</c>;
    /// otherwise , it returns <c>null</c> for method on the resulting tuple.
    /// </para>
    ///
    /// <para>
    /// The discovery of the correct method is done in two steps:
    /// The first step tries to match the arguments with the method parameters.
    /// The second step tries to match the arguments with the method parameters, but without the last argument.
    /// This last step is useful for methods that have a null argument at the end, which is commonly used for precision cases.
    ///</para>
    ///
    /// <para>
    /// For generic methods, it tries to match the generic type from the first argument, and if it fails, it tries the second argument.
    /// </para>
    ///
    /// </summary>
    private (MethodInfo? method, Expression[] arguments) ResolveMethodInfoWithPotentialArgumentConversions(
        string methodName,
        Expression[] arguments,
        bool throwError = true)
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

                    return (bindMethod, bindArgs);
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

        if (throwError)
        {
            var types = string.Join(", ", arguments.Select(e => e.Type.Name));
            throw new ArgumentException($"No suitable method found {methodName}({types}).", nameof(methodName));
        }

        return (null, arguments);
    }


    private MethodCallExpression BindToMethodConvertArgs(
        string methodName,
        params Expression[] arguments)
    {
        var (methodInfo, convertedArgs) = ResolveMethodInfoWithPotentialArgumentConversions(methodName, arguments);
        var call = Expression.Call(CqlContextExpressions.Operators_PropertyExpression, methodInfo!, convertedArgs);
        return call;
    }

    private static MethodCallExpression BindToMethod(
        string methodName,
        params Expression[] arguments) =>
        Expression.Call(CqlContextExpressions.Operators_PropertyExpression, methodName, null, arguments);

    private static MethodCallExpression BindToGenericMethod(
        string methodName,
        Type[] genericTypeArguments,
        params Expression[] arguments) =>
        Expression.Call(CqlContextExpressions.Operators_PropertyExpression, methodName, genericTypeArguments, arguments);

    private static MethodCallExpression BindToMethod(
        MethodInfo method,
        params Expression[] expressions) =>
        Expression.Call(CqlContextExpressions.Operators_PropertyExpression, method, expressions);

    private static bool IsInterval(Type type) =>
        type.IsGenericType
        && type.GetGenericTypeDefinition() == typeof(CqlInterval<>);
}