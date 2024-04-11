using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Operators;

namespace Hl7.Cql.Compiler;

#pragma warning disable CS1591
partial class CqlOperatorsBinding
{
    [Flags]
    protected enum BindOptions
    {
        None                           = 0,

        ConvertArguments               = BindOption_ConvertArguments,
        ConvertArgumentsGeneric         = BindOption_ConvertArguments | BindOption_Generic,
        ConvertArgumentsGeneric2ndArg  = BindOption_ConvertArguments | BindOption_Generic | BindOption_GenericFrom2ndArg,

        ReturnNullOverError            = BindOption_ReturnNullOverError,
    }

    private const BindOptions BindOption_ConvertArguments    = (BindOptions)1;
    private const BindOptions BindOption_Generic             = (BindOptions)2;
    private const BindOptions BindOption_GenericFrom2ndArg   = (BindOptions)4;
    private const BindOptions BindOption_ReturnNullOverError = (BindOptions)8;

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

        var bindOptionConvertArguments   = options.HasFlag(BindOption_ConvertArguments);
        var bindOptionGeneric            = options.HasFlag(BindOption_Generic);
        var bindOptionGenericFrom2ndArg  = options.HasFlag(BindOption_GenericFrom2ndArg);
        var bindOptionReturnNullOverError= options.HasFlag(BindOption_ReturnNullOverError);

        if (bindOptionConvertArguments)
        {
            var methods = ICqlOperatorsExpressions.ICqlOperators_MethodInfos_By_Name[methodName].AsEnumerable();
            if (bindOptionGeneric) methods = methods.Where(m => m.IsGenericMethod);

            foreach (var curMethod in methods)
            {
                var method = curMethod;
                var methodParameters = method.GetParameters();
                if (methodParameters.Length == arguments.Length)
                {
                    Type[] parameterTypes = methodParameters.SelectToArray(p => p.ParameterType);
                    //Type[] methodTypeArgs = [];
                    if (bindOptionGeneric)
                    {
                        var genericType = bindOptionGenericFrom2ndArg
                            ? arguments[1].Type.GetGenericArguments()[0]
                            : arguments[0].Type.GetGenericArguments()[0];
                        method = method.MakeGenericMethod(genericType);
                        parameterTypes = method.GetParameters().SelectToArray(p => p.ParameterType);
                        //methodTypeArgs = [genericType];
                    }
                    ConversionType[] conversions = arguments.SelectToArray((e, i) => CanConvert(e.Type, parameterTypes[i]));
                    if (conversions.Any(c => c == ConversionType.Incompatible))
                        continue;

                    arguments = arguments.SelectToArray((e, i) => Convert(e, parameterTypes[i], conversions[i]));

                    var call = Expression.Call(CqlContextExpressions.Operators_PropertyExpression, method, arguments);
                    return call;
                }
            }

            if (bindOptionReturnNullOverError)
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

    protected MethodCallExpression BindBinaryOperatorWithPrecision(
        string methodName,
        Expression left,
        Expression right,
        Expression precision)
    {
        var methods = ICqlOperatorsExpressions.ICqlOperators_MethodInfos_By_Name[methodName];
        foreach (var method in methods)
        {
            var methodParameters = method.GetParameters();
            if (methodParameters.Length > 1)
            {
                var leftConversion = CanConvert(left.Type, methodParameters[0].ParameterType);
                var rightConversion = CanConvert(right.Type, methodParameters[1].ParameterType);
                if (leftConversion != ConversionType.Incompatible
                    && rightConversion != ConversionType.Incompatible)
                {
                    left = Convert(left, methodParameters[0].ParameterType, leftConversion);
                    right = Convert(right, methodParameters[1].ParameterType, rightConversion);
                    if (methodParameters.Length <= 2)
                        return BindToMethod(method, left, right);

                    var precisionConversion = CanConvert(precision.Type, methodParameters[2].ParameterType);
                    if (precisionConversion == ConversionType.Incompatible)
                        continue;
                    precision = Convert(precision, methodParameters[2].ParameterType, precisionConversion);
                    return BindToMethod(method, left, right, precision);
                }
            }
        }
        throw new ArgumentException($"No suitable binary method {methodName}({left.Type}, {right.Type}) could be found.", nameof(methodName));
    }

    protected MethodCallExpression BindUnaryOperatorWithPrecision(
        string methodName,
        Expression operand,
        Expression precision)
    {
        var methods = ICqlOperatorsExpressions.ICqlOperators_MethodInfos_By_Name[methodName];
        foreach (var method in methods)
        {
            var methodParameters = method.GetParameters();
            if (methodParameters.Length == 2)
            {
                var operandConversion = CanConvert(operand.Type, methodParameters[0].ParameterType);
                if (operandConversion == ConversionType.Incompatible)
                    continue;
                var operandParameter = operand;
                if (operandConversion == ConversionType.Convertible)
                    operandParameter = Convert(operandParameter, methodParameters[0].ParameterType, operandConversion);
                else if (operandConversion == ConversionType.Assignable)
                    operandParameter = Expression.TypeAs(operandParameter, methodParameters[0].ParameterType);
                var call = BindToMethod(method, operandParameter, precision);
                return call;
            }
        }
        throw new ArgumentException($"No suitable unary method {methodName}({operand.Type}) could be found.", nameof(methodName));
    }

    protected static MethodCallExpression BindToMethod(
        MethodInfo method,
        params Expression[] expressions)
    {
        var call = Expression.Call(CqlContextExpressions.Operators_PropertyExpression, method, expressions);
        return call;
    }
}