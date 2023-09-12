#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using elm = Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {
        protected Expression As(elm.As @as, ExpressionBuilderContext ctx)
        {
            if (@as.operand is elm.List list)
            {
                // create new ListType[0]; instead of new object[0] as IEnumerable<object> as IEnumerable<ListType>;
                if ((list.element?.Length ?? 0) == 0)
                {
                    var type = TypeManager.TypeFor(@as.asTypeSpecifier!, ctx);
                    if (IsOrImplementsIEnumerableOfT(type))
                    {
                        var listElementType = TypeResolver.GetListElementType(type) ?? throw new InvalidOperationException($"{type} was expected to be a list type.");
                        var newArray = Expression.NewArrayBounds(listElementType, Expression.Constant(0));
                        var typeAs = Expression.TypeAs(newArray, type);
                        return typeAs;
                    }
                    else
                    {
                        throw new InvalidOperationException("Cannot use as operator on a list if the as type is not also a list type.");
                    }
                }
            }

            // asTypeSpecifier is an expression with its own resulttypespecifier that actually contains the real type
            if (@as.asTypeSpecifier != null)
            {
                if (@as.operand is elm.Null)
                {
                    var type = TypeManager.TypeFor(@as.asTypeSpecifier!, ctx);
                    var defaultExpression = Expression.Default(type);
                    return Expression.TypeAs(defaultExpression, type);
                }
                else
                {
                    var type = TypeManager.TypeFor(@as.asTypeSpecifier!, ctx);
                    var operand = TranslateExpression(@as.operand!, ctx);
                    return Expression.TypeAs(operand, type);
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(@as.asType.Name))
                    throw new ArgumentException("asType cannot be null", nameof(@as));
                if (@as.operand == null)
                    throw new ArgumentException("operand cannot be null", nameof(@as));
                var type = TypeResolver.ResolveType(@as.asType.Name!);
                var operand = TranslateExpression(@as.operand, ctx);
                if (type!.IsValueType)
                    return Expression.Convert(operand, type);
                else if (operand is ConstantExpression ce && ce.Value == null)
                    return Expression.Constant(null, type);
                else
                {
                    if (!type.IsAssignableFrom(operand.Type))
                        ctx.LogWarning($"Potentially unsafe cast from {TypeManager.PrettyTypeName(operand.Type)} to type {TypeManager.PrettyTypeName(type)}", @as.operand);
                    return Expression.TypeAs(operand, type);
                }
            }
        }

        protected Expression Children() => throw new NotImplementedException();

        protected Expression Is(elm.Is @is, ExpressionBuilderContext ctx)
        {
            var op = TranslateExpression(@is.operand!, ctx);
            Type? type = null;
            if (@is.isTypeSpecifier != null) 
            {
                if (@is.isTypeSpecifier is elm.ChoiceTypeSpecifier choice)
                {
                    var firstChoiceType = TypeManager.TypeFor(choice.choice[0], ctx)
                            ?? throw new InvalidOperationException($"Could not resolve type for Is expression");
                    Expression result = Expression.TypeIs(op, firstChoiceType);
                    for (int i = 1; i < choice.choice.Length; i++)
                    {
                        var cti = TypeManager.TypeFor(choice.choice[i], ctx)
                            ?? throw new InvalidOperationException($"Could not resolve type for Is expression");
                        var ie = Expression.TypeIs(op, cti);
                        result = Expression.Or(result, ie);
                    }
                    var ta = Expression.TypeAs(result, typeof(bool?));
                    return ta;
                }
                type = TypeManager.TypeFor(@is.isTypeSpecifier, ctx)
                    ?? throw new InvalidOperationException($"Could not resolve type for Is expression");
            }
            else if (!string.IsNullOrWhiteSpace(@is.isType?.Name)) 
            {
                type = TypeResolver.ResolveType(@is.isType.Name)
                    ?? throw new InvalidOperationException($"Could not resolve type {@is.isType.Name}");
            }
            if (type == null)
                throw new InvalidOperationException($"Could not identify Is type specifer via {nameof(elm.Is.isTypeSpecifier)} or {nameof(elm.Is.isType)}.");
            var isExpression = Expression.TypeIs(op, type);
            var nullable = Expression.TypeAs(isExpression, typeof(bool?));
            return nullable;
        }

        private Expression? Descendents(elm.Descendents e, ExpressionBuilderContext ctx)
        {
            if (e.source == null)
                return Expression.Constant(null, typeof(IEnumerable<object>));
            else
            {
                var source = TranslateExpression(e.source, ctx);
                var call = OperatorBinding.Bind(CqlOperator.Descendents, ctx.RuntimeContextParameter, source);
                return call;
            }
        }

        /// <summary>
        /// Changes units on a quantity.
        /// e.g.
        /// convert FHIRHelpers.ToQuantity ( First.ConceptionQuantity ) to weeks
        /// </summary>
        /// <param name="cqe"></param>
        /// <param name="ctx"></param>
        /// <returns></returns>
        protected Expression ConvertQuantity(elm.ConvertQuantity cqe, ExpressionBuilderContext ctx)
        {
            var quantity = TranslateExpression(cqe.operand![0], ctx);
            var unit = TranslateExpression(cqe.operand![1], ctx);
            var call = OperatorBinding.Bind(CqlOperator.ConvertQuantity, ctx.RuntimeContextParameter, quantity, unit);
            return call;
        }

        protected Expression? ConvertsToLong(elm.ConvertsToLong e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.ConvertsToLong, e, ctx);

        private Expression? ConvertsToInteger(elm.ConvertsToInteger e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.ConvertsToInteger, e, ctx);

        protected Expression? ConvertsToDecimal(elm.ConvertsToDecimal e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.ConvertsToDecimal, e, ctx);

        protected Expression? ConvertsToDateTime(elm.ConvertsToDateTime e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.ConvertsToDateTime, e, ctx);

        protected Expression? ConvertsToDate(elm.ConvertsToDate e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.ConvertsToDate, e, ctx);

        protected Expression? ConvertsToBoolean(elm.ConvertsToBoolean e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.ConvertsToDate, e, ctx);

        private Expression? ConvertsToQuantity(elm.ConvertsToQuantity e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.ConvertsToQuantity, e, ctx);

        private Expression? ConvertsToString(elm.ConvertsToString e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.ConvertsToString, e, ctx);

        private Expression? ConvertsToTime(elm.ConvertsToTime e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.ConvertsToTime, e, ctx);


        protected Expression? ToBoolean(elm.ToBoolean e, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(e.operand!, ctx);
            return ChangeType(operand, typeof(bool?), ctx);
        }

        protected Expression? ToConcept(elm.ToConcept e, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(e.operand!, ctx);
            return ChangeType(operand, TypeResolver.ConceptType, ctx);
        }

        protected Expression? ToDate(elm.ToDate e, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(e.operand!, ctx);
            return ChangeType(operand, TypeResolver.DateType, ctx);
        }

        protected Expression ToDateTime(elm.ToDateTime e, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(e.operand!, ctx);
            return ChangeType(operand, TypeResolver.DateTimeType, ctx);
        }


        protected Expression ToDecimal(elm.ToDecimal e, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(e.operand!, ctx);
            return ChangeType(operand, typeof(decimal?), ctx);
        }

        protected Expression ToLong(elm.ToLong e, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(e.operand!, ctx);
            return ChangeType(operand, typeof(long?), ctx);
        }

        protected Expression? ToInteger(elm.ToInteger e, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(e.operand!, ctx);
            return ChangeType(operand, typeof(int?), ctx);
        }

        protected Expression? ToQuantity(elm.ToQuantity tq, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(tq.operand!, ctx);
            return ChangeType(operand, TypeResolver.QuantityType, ctx);
        }

        protected Expression? ToString(elm.ToString e, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(e.operand!, ctx);
            return ChangeType(operand, typeof(string), ctx);
        }
        protected Expression? ToTime(elm.ToTime e, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(e.operand!, ctx);
            return ChangeType(operand, TypeResolver.TimeType, ctx);
        }

        protected Expression ToList(elm.ToList e, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(e.operand!, ctx);
            var call = OperatorBinding.Bind(CqlOperator.ToList, ctx.RuntimeContextParameter, operand);
            return call;
        }

        private Expression ChangeType(Expression input, Type outputType, ExpressionBuilderContext ctx)
        {
            if (input.Type == outputType)
                return input;
            else if (input.Type == typeof(object) || outputType.IsAssignableFrom(input.Type))
                return Expression.TypeAs(input, outputType);
            else if (IsOrImplementsIEnumerableOfT(input.Type)
                && IsOrImplementsIEnumerableOfT(outputType))
            {
                var inputElementType = TypeResolver.GetListElementType(input.Type, true)!;
                var outputElementType = TypeResolver.GetListElementType(outputType, true)!;
                var lambdaParameter = Expression.Parameter(inputElementType, TypeNameToIdentifier(inputElementType, ctx));
                var lambdaBody = ChangeType(lambdaParameter, outputElementType, ctx);
                var lambda = Expression.Lambda(lambdaBody, lambdaParameter);
                var callSelect = OperatorBinding.Bind(CqlOperator.Select, ctx.RuntimeContextParameter, input, lambda);
                return callSelect;
            }
            else
            {
                var call = OperatorBinding.Bind(CqlOperator.Convert, ctx.RuntimeContextParameter, input, Expression.Constant(outputType, typeof(Type)));
                return call;
            }
        }
    }
}
