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
using System.Linq.Expressions;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {
        private Expression Collapse(Elm.Collapse e, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(e.operand![0]!, ctx);
            if (IsOrImplementsIEnumerableOfT(operand.Type))
            {
                var elementType = TypeResolver.GetListElementType(operand.Type, @throw: true)!;
                if (IsInterval(elementType, out var pointType))
                {
                    var precision = Expression.Constant(null, typeof(string));
                    if (e.operand.Length > 1 && e.operand[1] is Elm.Quantity quant)
                    {
                        precision = Expression.Constant(quant.unit, typeof(string));
                    }
                    return OperatorBinding.Bind(CqlOperator.Collapse, ctx.RuntimeContextParameter, operand, precision);
                }
            }
            throw new NotImplementedException();
        }

        private Expression Contains(Elm.Contains e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e!.operand![0]!, ctx);
            var right = TranslateExpression(e.operand[1]!, ctx);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                var elementType = TypeResolver.GetListElementType(left.Type, @throw: true)!;
                if (elementType != right.Type)
                {
                    if (elementType.IsAssignableFrom(right.Type))
                    {
                        right = ChangeType(right, elementType, ctx);
                    }
                    else throw new ArgumentException($"Cannot convert Contains target {TypeManager.PrettyTypeName(right.Type)} to {TypeManager.PrettyTypeName(elementType)}", nameof(e));
                }
                var call = OperatorBinding.Bind(CqlOperator.ListContains, ctx.RuntimeContextParameter, left, right);
                return call;
            }
            else if (IsInterval(left.Type, out var pointType))
            {
                var call = OperatorBinding.Bind(CqlOperator.IntervalContains, ctx.RuntimeContextParameter, left, right, precision);
                return call;
            }
            throw new NotImplementedException();
        }

        private Expression End(Elm.End e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.IntervalEnd, e, ctx);

        private Expression? Ends(Elm.Ends e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw new InvalidOperationException();
                    return OperatorBinding.Bind(CqlOperator.Ends, ctx.RuntimeContextParameter, left, right, precision);

                }
            }
            throw new NotImplementedException();
        }

        protected Expression Except(Elm.Except e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            if (IsOrImplementsIEnumerableOfT(left.Type) && IsOrImplementsIEnumerableOfT(right.Type))
            {
                return OperatorBinding.Bind(CqlOperator.ListExcept, ctx.RuntimeContextParameter, left, right);
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw new InvalidOperationException();
                    return OperatorBinding.Bind(CqlOperator.IntervalExcept, ctx.RuntimeContextParameter, left, right);

                }
                else throw new NotImplementedException();
            }
            throw new NotImplementedException();
        }

        protected Expression? Expand(Elm.Expand e, ExpressionBuilderContext ctx)
        {
            var source = TranslateExpression(e!.operand![0]!, ctx);
            var quantity = TranslateExpression(e!.operand![1]!, ctx);
            return OperatorBinding.Bind(CqlOperator.Expand, ctx.RuntimeContextParameter, source, quantity);
        }

        protected Expression In(Elm.In e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0]!, ctx);
            var right = TranslateExpression(e.operand![1]!, ctx);
            if (IsOrImplementsIEnumerableOfT(right.Type))
            {
                return OperatorBinding.Bind(CqlOperator.InList, ctx.RuntimeContextParameter, left, right);
            }
            else if (IsInterval(right.Type, out var rightElementType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);

                return OperatorBinding.Bind(CqlOperator.InInterval, ctx.RuntimeContextParameter, left, right, precision);

            }
            else throw new NotImplementedException();
        }


        protected Expression? Includes(Elm.Includes e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                var leftElementType = TypeResolver.GetListElementType(left.Type);
                if (IsOrImplementsIEnumerableOfT(right.Type))
                {
                    var rightElementType = TypeResolver.GetListElementType(left.Type);
                    if (leftElementType != rightElementType)
                        throw new InvalidOperationException();
                    return OperatorBinding.Bind(CqlOperator.ListIncludesList, ctx.RuntimeContextParameter, left, right);
                }
                else
                {
                    if (leftElementType != right.Type)
                        throw new InvalidOperationException();
                    return OperatorBinding.Bind(CqlOperator.ListIncludesElement, ctx.RuntimeContextParameter, left, right);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var pointType))
                {
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return OperatorBinding.Bind(CqlOperator.IntervalIncludesInterval, ctx.RuntimeContextParameter, left, right, precision);
                }
                else
                {
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return OperatorBinding.Bind(CqlOperator.IntervalIncludesElement, ctx.RuntimeContextParameter, left, right, precision);
                }
            }
            throw new NotImplementedException();
        }

        protected Expression IncludedIn(Elm.IncludedIn e, ExpressionBuilderContext ctx)
        {

            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                var leftElementType = TypeResolver.GetListElementType(left.Type);
                if (IsOrImplementsIEnumerableOfT(right.Type))
                {
                    var rightElementType = TypeResolver.GetListElementType(left.Type);
                    if (leftElementType != rightElementType)
                        throw new InvalidOperationException();
                    return OperatorBinding.Bind(CqlOperator.ListIncludesList, ctx.RuntimeContextParameter, right, left);
                }
                else
                {
                    if (leftElementType != right.Type)
                        throw new InvalidOperationException();
                    return OperatorBinding.Bind(CqlOperator.ListIncludesElement, ctx.RuntimeContextParameter, right, left);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType) && IsInterval(right.Type, out var rightPointType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);
                return OperatorBinding.Bind(CqlOperator.IntervalIncludesInterval, ctx.RuntimeContextParameter, right, left, precision);
            }
            else if (IsInterval(right.Type, out var pointType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);
                if (left.Type != pointType)
                    throw new InvalidOperationException($"IncludedIn requires that the operands have compatible types.");
                return OperatorBinding.Bind(CqlOperator.IntervalIncludesElement, ctx.RuntimeContextParameter, right, left, precision);

            }
            throw new NotImplementedException();
        }

        protected Expression Intersect(Elm.Intersect e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0]!, ctx);
            var right = TranslateExpression(e.operand![1]!, ctx);
            if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                return OperatorBinding.Bind(CqlOperator.ListIntersect, ctx.RuntimeContextParameter, left, right);
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    return OperatorBinding.Bind(CqlOperator.IntervalIntersect, ctx.RuntimeContextParameter, left, right);
                }
                else throw new NotImplementedException();
            }
            throw new NotImplementedException();
        }

        protected Expression? Meets(Elm.Meets e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw new InvalidOperationException();
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return OperatorBinding.Bind(CqlOperator.Meets, ctx.RuntimeContextParameter, left, right, precision);
                }
                else throw new NotImplementedException();
            }
            throw new NotImplementedException();
        }

        private Expression? MeetsAfter(Elm.MeetsAfter e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw new InvalidOperationException();
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return OperatorBinding.Bind(CqlOperator.MeetsAfter, ctx.RuntimeContextParameter, left, right, precision);
                }
                else throw new NotImplementedException();
            }
            throw new NotImplementedException();
        }

        private Expression? MeetsBefore(Elm.MeetsBefore e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {

                    if (leftPointType != rightPointType)
                        throw new InvalidOperationException();
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return OperatorBinding.Bind(CqlOperator.MeetsBefore, ctx.RuntimeContextParameter, left, right, precision);
                }
                else throw new NotImplementedException();
            }
            throw new NotImplementedException();
        }

        protected Expression Overlaps(Elm.Overlaps e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw new InvalidOperationException();
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return OperatorBinding.Bind(CqlOperator.Overlaps, ctx.RuntimeContextParameter, left, right, precision);
                }
                else throw new NotImplementedException();
            }
            throw new NotImplementedException();
        }

        private Expression OverlapsBefore(Elm.OverlapsBefore e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw new InvalidOperationException();
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return OperatorBinding.Bind(CqlOperator.OverlapsBefore, ctx.RuntimeContextParameter, left, right, precision);
                }
                else throw new NotImplementedException();
            }
            throw new NotImplementedException();
        }

        private Expression OverlapsAfter(Elm.OverlapsAfter e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw new InvalidOperationException();
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return OperatorBinding.Bind(CqlOperator.OverlapsAfter, ctx.RuntimeContextParameter, left, right, precision);
                }
                else throw new NotImplementedException();
            }
            throw new NotImplementedException();
        }




        protected Expression? PointFrom(Elm.PointFrom e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.PointFrom, e, ctx);

        protected Expression? ProperIncludes(Elm.ProperIncludes e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            if (IsInterval(left.Type, out var leftPointType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);
                if (IsInterval(right.Type, out var rightPointType))
                {
                    return OperatorBinding.Bind(CqlOperator.IntervalProperlyIncludesInterval, ctx.RuntimeContextParameter, left, right, precision);
                }
                else
                {
                    return OperatorBinding.Bind(CqlOperator.IntervalProperlyIncludesElement, ctx.RuntimeContextParameter, left, right, precision);
                }
            }
            else if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                var leftElementType = TypeResolver.GetListElementType(left.Type);
                if (IsOrImplementsIEnumerableOfT(right.Type))
                {
                    var rightElementType = TypeResolver.GetListElementType(right.Type);
                    return OperatorBinding.Bind(CqlOperator.ListProperlyIncludesList, ctx.RuntimeContextParameter, left, right);
                }
                else
                {
                    return OperatorBinding.Bind(CqlOperator.ListProperlyIncludesElement, ctx.RuntimeContextParameter, left, right);
                }
            }
            throw new NotImplementedException();
        }


        protected Expression? ProperIncludedIn(Elm.ProperIncludedIn e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return OperatorBinding.Bind(CqlOperator.IntervalProperlyIncludesInterval, ctx.RuntimeContextParameter, right, left, precision);
                }
            }
            else if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                var leftElementType = TypeResolver.GetListElementType(left.Type);
                if (IsOrImplementsIEnumerableOfT(right.Type))
                {
                    var rightElementType = TypeResolver.GetListElementType(right.Type);
                    if (leftElementType != rightElementType)
                        throw new InvalidOperationException();
                    return OperatorBinding.Bind(CqlOperator.ListProperlyIncludesList, ctx.RuntimeContextParameter, right, left);
                }
            }
            else if (IsInterval(right.Type, out var rightPointType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);
                return OperatorBinding.Bind(CqlOperator.IntervalProperlyIncludesElement, ctx.RuntimeContextParameter, right, left, precision);
            }
            throw new NotImplementedException();
        }

        private Expression? ProperIn(Elm.ProperIn e, ExpressionBuilderContext ctx)
        {
            var element = TranslateExpression(e.operand![0], ctx);
            var intervalOrList = TranslateExpression(e.operand![1], ctx);
            if (IsInterval(intervalOrList.Type, out var pointType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);
                return OperatorBinding.Bind(CqlOperator.IntervalProperlyIncludesElement, ctx.RuntimeContextParameter, intervalOrList, element, precision);
            }
            else if (IsOrImplementsIEnumerableOfT(intervalOrList.Type))
            {
                return OperatorBinding.Bind(CqlOperator.ListProperlyIncludesElement, ctx.RuntimeContextParameter, intervalOrList, element);
            }
            throw new NotImplementedException();
        }

        protected Expression? ProperContains(Elm.ProperContains e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                var leftElementType = TypeResolver.GetListElementType(left.Type);
                if (IsOrImplementsIEnumerableOfT(right.Type))
                {
                    var rightElementType = TypeResolver.GetListElementType(right.Type);
                    if (leftElementType != rightElementType)
                        throw new InvalidOperationException();
                    return OperatorBinding.Bind(CqlOperator.ListProperlyIncludesList, ctx.RuntimeContextParameter, left, right);
                }
                else
                {
                    if (leftElementType != right.Type)
                        throw new InvalidOperationException();
                    return OperatorBinding.Bind(CqlOperator.ListProperlyIncludesElement, ctx.RuntimeContextParameter, left, right);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (leftPointType != right.Type)
                    throw new InvalidOperationException();
                var precision = Precision(e.precision, e.precisionSpecified);
                return OperatorBinding.Bind(CqlOperator.IntervalProperlyIncludesElement, ctx.RuntimeContextParameter, left, right, precision);
            }
            throw new NotImplementedException();
        }


        protected Expression Start(Elm.Start start, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.IntervalStart, start, ctx);


        protected Expression? Starts(Elm.Starts e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw new InvalidOperationException();
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return OperatorBinding.Bind(CqlOperator.Starts, ctx.RuntimeContextParameter, left, right, precision);

                }
            }
            throw new NotImplementedException();
        }


        protected Expression Union(Elm.Union e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                var leftElementType = TypeResolver.GetListElementType(left.Type);
                if (IsOrImplementsIEnumerableOfT(right.Type))
                {
                    var rightElementType = TypeResolver.GetListElementType(right.Type);
                    if (leftElementType != rightElementType)
                        throw new InvalidOperationException();
                    return OperatorBinding.Bind(CqlOperator.ListUnion, ctx.RuntimeContextParameter, left, right);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw new InvalidOperationException();
                    return OperatorBinding.Bind(CqlOperator.IntervalUnion, ctx.RuntimeContextParameter, left, right);
                }
            }
            throw new NotImplementedException();
        }

        protected Expression? Width(Elm.Width e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Width, e, ctx);
    }
}
