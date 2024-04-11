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
    protected MethodCallExpression ConvertParametersThenBindMethod(
        string methodName,
        params Expression[] expressions)
    {
        var methods = ICqlOperatorsExpressions.ICqlOperators_MethodInfos_By_Name[methodName];

        foreach (var method in methods)
        {
            var methodParameters = method.GetParameters();
            if (methodParameters.Length == expressions.Length)
            {
                ConversionType[] conversions = expressions.SelectToArray((e,i) => CanConvert(e.Type, methodParameters[i].ParameterType));
                if (conversions.Any(c => c == ConversionType.Incompatible))
                    continue;

                var convertedExpressions = expressions.SelectToArray((e,i) => Convert(e, methodParameters[i].ParameterType, conversions[i]));

                var call = BindToMethod(method, convertedExpressions);
                return call;
            }
        }

        var types = string.Join(", ", expressions.Select(e => e.Type.Name));
        throw new ArgumentException($"No suitable method found {methodName}({types}).", nameof(methodName));
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

    /// <summary>
    /// Calls methods with a signature of Method%lt;T&gt;(Argument%lt;T&gt;)
    /// </summary>
    protected MethodCallExpression BindUnaryGenericOperator(
        string methodName,
        Expression operand)
    {
        Type? elementType = null;
        if (operand.Type.IsGenericType)
        {
            var operandGenericArguments = operand.Type.GetGenericArguments();
            elementType = operandGenericArguments[0];
        }
        else if (TypeResolver.ImplementsGenericIEnumerable(operand.Type))
            elementType = TypeResolver.GetListElementType(operand.Type);

        if (elementType != null)
        {
            var methods = ICqlOperatorsExpressions.ICqlOperators_MethodInfos_By_Name[methodName]
                .Where(m => m.IsGenericMethod && m.GetGenericArguments().Length == 1);
            foreach (var method in methods)
            {
                var genericMethod = method.MakeGenericMethod(elementType);
                var methodParameters = genericMethod.GetParameters();
                if (methodParameters.Length == 1)
                {
                    var operandConversion = CanConvert(operand.Type, methodParameters[0].ParameterType);
                    if (operandConversion == ConversionType.Incompatible)
                        continue;
                    var operandParameter = operand;
                    if (operandConversion == ConversionType.Convertible)
                        operandParameter = Convert(operandParameter, methodParameters[0].ParameterType, operandConversion);

                    var call = BindToMethod(genericMethod, operandParameter);
                    return call;
                }
            }
            throw new ArgumentException($"No suitable unary method {methodName}({operand.Type}) could be found.", nameof(methodName));
        }
        throw new ArgumentException("Operands to this method must be generic with a single generic type parameter, e.g. IEnumerable<T>", nameof(operand));
    }

    protected MethodCallExpression BindBinaryGenericOperator(
        string methodName,
        Expression left,
        Expression right,
        bool genericArgumentFromRight = false)
    {
        var methods = ICqlOperatorsExpressions.ICqlOperators_MethodInfos_By_Name[methodName]
            .Where(m => m.IsGenericMethod);
        foreach (var method in methods)
        {
            var methodParameters = method.GetParameters();
            if (methodParameters.Length == 2)
            {
                Type? genericType;
                if (genericArgumentFromRight)
                    genericType = right.Type.GetGenericArguments()[0];
                else
                    genericType = left.Type.GetGenericArguments()[0];
                var genericMethod = method.MakeGenericMethod(genericType);
                methodParameters = genericMethod.GetParameters();
                var leftConversion = CanConvert(left.Type, methodParameters[0].ParameterType);
                var rightConversion = CanConvert(right.Type, methodParameters[1].ParameterType);
                if (leftConversion == ConversionType.Incompatible || rightConversion == ConversionType.Incompatible)
                    continue;
                left = Convert(left, methodParameters[0].ParameterType, leftConversion);
                right = Convert(right, methodParameters[1].ParameterType, rightConversion);
                var call = BindToMethod(method, [genericType], left, right);
                return call;
            }
        }
        throw new ArgumentException($"No suitable binary method {methodName}({left.Type}, {right.Type}) could be found.", nameof(methodName));
    }

    protected Expression BindBinaryGenericOperatorOrNull(
        string methodName,
        Expression left,
        Expression right,
        bool genericArgumentFromRight = false)
    {
        var methods = ICqlOperatorsExpressions.ICqlOperators_MethodInfos_By_Name[methodName];
        foreach (var method in methods)
        {
            var methodParameters = method.GetParameters();
            if (methodParameters.Length == 2)
            {
                Type? genericType;
                if (genericArgumentFromRight)
                    genericType = right.Type.GetGenericArguments()[0];
                else
                    genericType = left.Type.GetGenericArguments()[0];
                var genericMethod = method.MakeGenericMethod(genericType);
                methodParameters = genericMethod.GetParameters();
                var leftConversion = CanConvert(left.Type, methodParameters[0].ParameterType);
                var rightConversion = CanConvert(right.Type, methodParameters[1].ParameterType);
                if (leftConversion == ConversionType.Incompatible || rightConversion == ConversionType.Incompatible)
                    continue;
                left = Convert(left, methodParameters[0].ParameterType, leftConversion);
                right = Convert(right, methodParameters[1].ParameterType, rightConversion);
                var call = BindToMethod(method, [genericType], left, right);
                return call;
            }
        }
        return Expression.Constant(null, typeof(object));
    }

    protected MethodCallExpression BindTernaryGenericOperator(
        string methodName,
        Expression left,
        Expression right,
        Expression precision,
        bool genericParameterFromRight = false)
    {
        var methods = ICqlOperatorsExpressions.ICqlOperators_MethodInfos_By_Name[methodName]
            .Where(m => m.IsGenericMethod);
        foreach (var method in methods)
        {
            var methodParameters = method.GetParameters();
            if (methodParameters.Length == 3)
            {
                Type? genericType = null;
                if (genericParameterFromRight)
                {
                    genericType = right.Type.GetGenericArguments()[0];
                }
                else
                {
                    genericType = left.Type.GetGenericArguments()[0];
                }
                var genericMethod = method.MakeGenericMethod(genericType);
                methodParameters = genericMethod.GetParameters();
                var leftConversion = CanConvert(left.Type, methodParameters[0].ParameterType);
                var rightConversion = CanConvert(right.Type, methodParameters[1].ParameterType);
                var precisionConversion = CanConvert(precision.Type, methodParameters[2].ParameterType);
                if (leftConversion == ConversionType.Incompatible
                    || rightConversion == ConversionType.Incompatible
                    || precisionConversion == ConversionType.Incompatible)
                    continue;
                left = Convert(left, methodParameters[0].ParameterType, leftConversion);
                right = Convert(right, methodParameters[1].ParameterType, rightConversion);
                precision = Convert(precision, methodParameters[2].ParameterType, precisionConversion);
                var call = BindToMethod(genericMethod, left, right, precision);
                return call;
            }
        }
        throw new ArgumentException($"No suitable binary method {methodName}({left.Type}, {right.Type}) could be found.", nameof(methodName));
    }

    protected static MethodCallExpression BindToMethod(MethodInfo method, params Expression[] expressions)
    {
        var call = Expression.Call(CqlContextExpressions.Operators_PropertyExpression, method, expressions);
        return call;
    }

    protected static MethodCallExpression BindToMethod(
        string methodName,
        params Expression[]? arguments)
    {
        var call = Expression.Call(CqlContextExpressions.Operators_PropertyExpression, methodName, null, arguments);
        return call;
    }

    protected static MethodCallExpression BindToMethod(
        string methodName,
        Type[] typeArguments,
        params Expression[]? arguments)
    {
        var call = Expression.Call(CqlContextExpressions.Operators_PropertyExpression, methodName, typeArguments, arguments);
        return call;
    }

    protected static MethodCallExpression BindToMethod(
        MethodInfo methodInfo,
        Type[] typeArguments,
        params Expression[]? arguments)
    {
        var call = Expression.Call(CqlContextExpressions.Operators_PropertyExpression, methodInfo.MakeGenericMethod(typeArguments), arguments);
        return call;
    }

    /// <summary>
    /// ICqlOperators.Convert&lt;convertToType&gt;(source as object)
    /// </summary>
    protected static MethodCallExpression BindToConvert(
        Type convertToType,
        Expression source)
    {
        source = Expression.TypeAs(source, typeof(object));
        MethodCallExpression call = BindToMethod(nameof(ICqlOperators.Convert), [convertToType], source);
        return call;
    }
}