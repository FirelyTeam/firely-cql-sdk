using System;
using System.Collections.Generic;
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
            // OR 'from' is a nullable value type and 'to' is the underlying type e.g. int? -> int
            result = (arg.NewAssignToTypeExpression(to), TypeConversion.AssignableType);
            return true;
        }

        if (_typeConverter?.CanConvert(from, to) == true)
        {
            var bindToGenericMethod =
                BindToGenericMethod(
                    nameof(ICqlOperators.Convert),
                    [to],
                    arg.NewAssignToTypeExpression<object>()
                );
            result = (bindToGenericMethod, TypeConversion.OperatorConvert);
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
        }

        result = default;
        return false;
    }

    private enum TypeConversion
    {
        NoMatch = 0,
        ExactType = 1,

        /// <summary>
        /// e.g. String is assignable to Object, and  'from' is a subtype of 'to' e.g. string -> object
        /// </summary>
        AssignableType = 2,

        SimpleConvert = 3,
        OperatorConvert = 4,
    }

    private MethodCallExpression BindToBestMethodOverload(
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
