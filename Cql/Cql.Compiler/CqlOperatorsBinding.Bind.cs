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
    public static readonly IReadOnlyDictionary<string, MethodInfo[]> ICqlOperators_MethodInfos_By_Name =
        typeof(ICqlOperators)
        .GetMethods(BindingFlags.Instance | BindingFlags.Public)
        .GroupBy(m => m.Name)
        .ToDictionary(m => m.Key, m => m.ToArray());

    // @formatter:off
    private const BindOptions BindOption_ConvertArguments    = (BindOptions)0x_01;
    private const BindOptions BindOption_Generic             = (BindOptions)0x_02;
    private const BindOptions BindOption_GenericFrom2ndArg   = (BindOptions)0x_04;
    private const BindOptions BindOption_ReturnNullOverError = (BindOptions)0x_08;

    [Flags]
    protected enum BindOptions
    {
        None                           = 0,
        ConvertArguments               = BindOption_ConvertArguments,
        ConvertArgumentsGeneric        = BindOption_ConvertArguments | BindOption_Generic,
        ConvertArgumentsGeneric2ndArg  = BindOption_ConvertArguments | BindOption_Generic | BindOption_GenericFrom2ndArg,
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
            var methods = ICqlOperators_MethodInfos_By_Name[methodName].AsEnumerable();
            if (options.HasFlag(BindOption_Generic)) methods = methods.Where(m => m.IsGenericMethod);

            foreach (var curMethod in methods)
            {
                var method = curMethod;
                var methodParameters = method.GetParameters();
                if (methodParameters.Length == arguments.Length)
                {
                    Type[] parameterTypes = methodParameters.SelectToArray(p => p.ParameterType);
                    if (options.HasFlag(BindOption_Generic))
                    {
                        var genericType = options.HasFlag(BindOption_GenericFrom2ndArg)
                            ? arguments[1].Type.GetGenericArguments()[0]
                            : arguments[0].Type.GetGenericArguments()[0];
                        method = method.MakeGenericMethod(genericType);
                        parameterTypes = method.GetParameters().SelectToArray(p => p.ParameterType);
                    }

                    ConversionType[] conversions = arguments.SelectToArray((e, i) => CanConvert(e.Type, parameterTypes[i]));
                    if (conversions.Any(c => c == ConversionType.Incompatible))
                        continue;

                    arguments = arguments.SelectToArray((e, i) => Convert(e, parameterTypes[i], conversions[i]));
                    var call = Expression.Call(CqlContextExpressions.Operators_PropertyExpression, method, arguments);
                    return call;
                }
            }

            if (options.HasFlag(BindOption_ReturnNullOverError))
                return Expression.Constant(null, typeof(object));

            var types = string.Join(", ", arguments.Select(e => e.Type.Name));
            throw new ArgumentException($"No suitable method found {methodName}({types}).", nameof(methodName));
        }

        throw new ArgumentOutOfRangeException(nameof(options), options, "Invalid BindOptions");
    }

    protected static MethodCallExpression BindToGenericMethod(
        string methodName,
        Type[] typeArguments,
        params Expression[]? arguments)
    {
        var call = Expression.Call(CqlContextExpressions.Operators_PropertyExpression, methodName, typeArguments, arguments);
        return call;
    }

    protected static MethodCallExpression BindToMethod(
        MethodInfo method,
        params Expression[] expressions)
    {
        var call = Expression.Call(CqlContextExpressions.Operators_PropertyExpression, method, expressions);
        return call;
    }
}