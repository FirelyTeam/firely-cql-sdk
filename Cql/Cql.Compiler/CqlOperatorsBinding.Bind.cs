using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Hl7.Cql.Abstractions.Infrastructure;
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

    // @formatter:off
    private const BindOptions BindOption_ConvertArguments    = (BindOptions)0x_01;
    private const BindOptions BindOption_GenericFrom2ndArg   = (BindOptions)0x_02;
    private const BindOptions BindOption_ReturnNullOverError = (BindOptions)0x_04;

    [Flags]
    protected enum BindOptions
    {
        None                           = 0,
        ConvertArguments               = BindOption_ConvertArguments,
        ConvertArgumentsGeneric2ndArg  = BindOption_ConvertArguments | BindOption_GenericFrom2ndArg,
        ReturnNullOverError            = BindOption_ReturnNullOverError,
    }
    // @formatter:on

    protected Expression BindToMethod(
        string methodName,
        BindOptions options,
        params Expression[] arguments)
    {
        if (options == BindOptions.None)
        {
            var call = Expression.Call(CqlContextExpressions.Operators_PropertyExpression, methodName, null, arguments);
            return call;
        }

        if (options.HasFlag(BindOption_ConvertArguments))
        {
            var methods = ICqlOperators_MethodInfos_By_Name[methodName];

            foreach (var method in methods)
            {
                MethodInfo bindMethod;
                if (method is { IsGenericMethodDefinition:true })
                {
                    var genericType = options.HasFlag(BindOption_GenericFrom2ndArg)
                        ? arguments[1].Type.GetGenericArguments()[0]
                        : arguments[0].Type.GetGenericArguments()[0];

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

            if (options.HasFlag(BindOption_ReturnNullOverError))
                return Expression.Constant(null, typeof(object));

            var types = string.Join(", ", arguments.Select(e => e.Type.Name));
            throw new ArgumentException($"No suitable method found {methodName}({types}).", nameof(methodName));
        }

        throw new ArgumentOutOfRangeException(nameof(options), options, "Invalid BindOptions");
    }

    protected static MethodCallExpression BindToMethod(
        string methodName,
        Type[] typeArguments,
        params Expression[] arguments) =>
        Expression.Call(CqlContextExpressions.Operators_PropertyExpression, methodName, typeArguments, arguments);

    private static MethodCallExpression BindToMethod(
        MethodInfo method,
        params Expression[] expressions) =>
        Expression.Call(CqlContextExpressions.Operators_PropertyExpression, method, expressions);
}