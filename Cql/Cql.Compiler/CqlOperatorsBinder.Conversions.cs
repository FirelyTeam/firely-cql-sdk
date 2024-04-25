using System;
using System.Linq.Expressions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Compiler.Expressions;
using Hl7.Cql.Operators;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler;

partial class CqlOperatorsBinder
{
    private bool TryConvert(
        Expression arg,
        Type to,
        out (Expression arg, TypeConversion conversion) result)
    {
        Type from = arg.Type;

        if (from == to)
        {
            // Exact match
            result = (arg, TypeConversion.ExactType);
            return true;
        }

        if (from.IsAssignableTo(to))
        {
            // 'from' is a subtype of 'to' e.g. string -> object
            result = (Expression.Convert(arg, to), TypeConversion.SubType);
            return true;
        }

        if (arg is ConstantExpression fromConstant)
        {
            if (fromConstant.Value is null && to.IsNullable(out _))
            {
                // Null values to a type that can accept nulls e.g. default(string) or default(int?)
                result = (NullExpression.ForType(to), TypeConversion.ExactType);
                return true;
            }

            if (fromConstant.Value is Enum enumValue && to == typeof(string) )
            {
                // Enum values to lowercase string e.g DateTimePrecision.Year -> "year"
                var name = Enum.GetName(enumValue.GetType(), enumValue);
                if (name is null)
                    throw new InvalidOperationException($"Enum value {enumValue} is not defined in enum type {enumValue.GetType()}");

                result = (Expression.Constant(name.ToLowerInvariant()), TypeConversion.SimpleConvert);
                return true;
            }

            if (fromConstant.Type.IsValueType && to.IsNullableValueType(out var toUnderlyingType) && fromConstant.Type == toUnderlyingType)
            {
                // Value type values to nullable type e.g. int -> int?
                result = (Expression.Convert(arg, to), TypeConversion.SimpleConvert);
                return true;
            }
        }

        if (_typeConverter?.CanConvert(from, to) == true)
        {
            result = (BindToGenericMethod(
                nameof(ICqlOperators.Convert),
                [to],
                arg.ConvertExpression<object>()
                ), TypeConversion.OperatorConvert);
            return true;
        }

        if (from == typeof(object))
        {
            // Just cast up and hope for the best
            result = (Expression.Convert(arg, to), TypeConversion.SuperType);
            return true;
        }

        result = default;
        return false;
    }

    private enum TypeConversion
    {
        NoMatch = 0,
        ExactType = 1,
        SubType = 2,
        SimpleConvert = 3,
        OperatorConvert = 4,
        SuperType = 5, // Unresolved object
    }

    private MethodCallExpression BindToMethodConvertArgs(
        string methodName,
        params Expression[] arguments)
    {
        var (methodInfo, convertedArgs) = ResolveMethodInfoWithPotentialArgumentConversions(methodName, arguments);
        var call = Expression.Call(CqlExpressions.Operators_PropertyExpression, methodInfo!, convertedArgs);
        return call;
    }

    internal static MethodCallExpression CallCreateValueSetFacade(Expression operand)
    {
        var createFacadeMethod = typeof(ICqlOperators).GetMethod(nameof(ICqlOperators.CreateValueSetFacade))!;
        var call = Expression.Call(CqlExpressions.Operators_PropertyExpression, createFacadeMethod, operand);
        return call;
    }
}
