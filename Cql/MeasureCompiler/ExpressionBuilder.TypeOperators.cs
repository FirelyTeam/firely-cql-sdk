using Ncqa.Cql.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using elm = Ncqa.Elm.Expressions;

namespace Ncqa.Cql.MeasureCompiler
{
    public partial class ExpressionBuilder
    {
        protected Expression As(elm.AsExpression @as, ExpressionBuilderContext ctx)
        {
            if (@as.operand is elm.ListExpression list)
            {
                // create new ListType[0]; instead of new object[0] as IEnumerable<object> as IEnumerable<ListType>;
                if ((list.element?.Length ?? 0) == 0)
                {
                    var type = TypeManager.TypeFor(ThisLibraryKey, @as.asTypeSpecifier!, ctx);
                    if (IsOrImplementsIEnumerableOfT(type))
                    {
                        var listElementType = TypeResolver.GetElementType(type);
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
                if (@as.operand!.type == "Null")
                {
                    var type = TypeManager.TypeFor(ThisLibraryKey, @as.asTypeSpecifier!, ctx);
                    var defaultExpression = Expression.Default(type);
                    return Expression.TypeAs(defaultExpression, type);
                }
                else
                {
                    var type = TypeManager.TypeFor(ThisLibraryKey, @as.asTypeSpecifier!, ctx);
                    var operand = TranslateExpression(@as.operand!, ctx);
                    return Expression.TypeAs(operand, type);
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(@as.asType))
                    throw new ArgumentException("asType cannot be null", nameof(@as));
                if (@as.operand == null)
                    throw new ArgumentException("operand cannot be null", nameof(@as));
                var type = TypeResolver.ResolveType(@as.asType!);
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

        protected Expression Is(elm.IsExpression @is, ExpressionBuilderContext ctx)
        {
            var type = TypeResolver.ResolveType(@is.isTypeSpecifier!.resultTypeName!);
            var op = TranslateExpression(@is.operand!, ctx);
            var isExpression = Expression.TypeIs(op, type);
            var nullable = Expression.TypeAs(isExpression, typeof(bool?));
            return nullable;
        }

        private Expression? Descendents(elm.DescendentsExpression e, ExpressionBuilderContext ctx)
        {
            if (e.operand == null)
                return Expression.Constant(null, typeof(IEnumerable<object>));
            else
                return UnaryOperator(CqlOperator.Descendents, e, ctx);
        }

        /// <summary>
        /// Changes units on a quantity.
        /// e.g.
        /// convert FHIRHelpers.ToQuantity ( First.ConceptionQuantity ) to weeks
        /// </summary>
        /// <param name="cqe"></param>
        /// <param name="ctx"></param>
        /// <returns></returns>
        protected Expression ConvertQuantity(elm.ConvertQuantityExpression cqe, ExpressionBuilderContext ctx)
        {
            var quantity = TranslateExpression(cqe.operand![0], ctx);
            var unit = TranslateExpression(cqe.operand![1], ctx);
            var call = Operators.Bind(CqlOperator.ConvertQuantity, ctx.RuntimeContextParameter, quantity, unit);
            return call;
        }


        protected Expression? ConvertsToLong(elm.ConvertsToLongExpression e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.ConvertsToLong, e, ctx);

        private Expression? ConvertsToInteger(elm.ConvertsToIntegerExpression e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.ConvertsToInteger, e, ctx);

        protected Expression? ConvertsToDecimal(elm.ConvertsToDecimalExpression e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.ConvertsToDecimal, e, ctx);

        protected Expression? ConvertsToDateTime(elm.ConvertsToDateTimeExpression e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.ConvertsToDateTime, e, ctx);

        protected Expression? ConvertsToDate(elm.ConvertsToDateExpression e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.ConvertsToDate, e, ctx);

        protected Expression? ConvertsToBoolean(elm.ConvertsToBooleanExpression e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.ConvertsToDate, e, ctx);

        private Expression? ConvertsToQuantity(elm.ConvertsToQuantityExpression e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.ConvertsToQuantity, e, ctx);

        private Expression? ConvertsToString(elm.ConvertsToStringExpression e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.ConvertsToString, e, ctx);

        private Expression? ConvertsToTime(elm.ConvertsToTimeExpression e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.ConvertsToTime, e, ctx);


        protected Expression? ToBoolean(elm.ToBooleanExpression e, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(e.operand!, ctx);
            return ChangeType(operand, typeof(bool?), ctx);
        }

        protected Expression? ToConcept(elm.ToConceptExpression e, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(e.operand!, ctx);
            return ChangeType(operand, TypeResolver.ConceptType, ctx);
        }

        protected Expression? ToDate(elm.ToDateExpression e, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(e.operand!, ctx);
            return ChangeType(operand, TypeResolver.DateType, ctx);
        }

        protected Expression ToDateTime(elm.ToDateTimeExpression e, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(e.operand!, ctx);
            return ChangeType(operand, TypeResolver.DateTimeType, ctx);
        }


        protected Expression ToDecimal(elm.ToDecimalExpression e, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(e.operand!, ctx);
            return ChangeType(operand, typeof(decimal?), ctx);
        }

        protected Expression ToLong(elm.ToLongExpression e, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(e.operand!, ctx);
            return ChangeType(operand, typeof(decimal?), ctx);
        }

        protected Expression? ToInteger(elm.ToIntegerExpression e, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(e.operand!, ctx);
            return ChangeType(operand, typeof(int?), ctx);
        }

        protected Expression? ToQuantity(elm.ToQuantityExpression tq, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(tq.operand!, ctx);
            return ChangeType(operand, TypeResolver.QuantityType, ctx);
        }

        protected Expression? ToString(elm.ToStringExpression e, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(e.operand!, ctx);
            return ChangeType(operand, typeof(string), ctx);
        }
        protected Expression? ToTime(elm.ToTimeExpression e, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(e.operand!, ctx);
            return ChangeType(operand, TypeResolver.TimeType, ctx);
        }

        protected Expression ToList(elm.ToListExpression e, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(e.operand!, ctx);
            var call = Operators.Bind(CqlOperator.ToList, ctx.RuntimeContextParameter, operand);
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
                var inputElementType = TypeResolver.GetElementType(input.Type, true)!;
                var outputElementType = TypeResolver.GetElementType(outputType, true)!;
                var lambdaParameter = Expression.Parameter(inputElementType, TypeNameToIdentifier(inputElementType, ctx));
                var lambdaBody = ChangeType(lambdaParameter, outputElementType, ctx);
                var lambda = Expression.Lambda(lambdaBody, lambdaParameter);
                var callSelect = Operators.Bind(CqlOperator.Select, ctx.RuntimeContextParameter, input, lambda);
                return callSelect;
            }
            else
            {
                var call = Operators.Bind(CqlOperator.Convert, ctx.RuntimeContextParameter, input, Expression.Constant(outputType, typeof(Type)));
                return call;
            }
        }
    }
}
