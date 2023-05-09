using Ncqa.Cql.Runtime;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using elm = Ncqa.Elm.Expressions;

namespace Ncqa.Cql.MeasureCompiler
{
    public partial class ExpressionBuilder
    {
        private Expression Collapse(elm.CollapseExpression e, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(e.operand![0]!, ctx);
            if (IsOrImplementsIEnumerableOfT(operand.Type))
            {
                var elementType = TypeResolver.GetListElementType(operand.Type, @throw: true)!;
                if (IsInterval(elementType, out var pointType))
                {
                    var precision = Expression.Constant(null, typeof(string));
                    if (e.operand.Length > 1 && e.operand[1] is elm.QuantityExpression quant)
                    {
                        precision = Expression.Constant(quant.unit, typeof(string));
                    }
                    return Operators.Bind(CqlOperator.Collapse, ctx.RuntimeContextParameter, operand, precision);
                }
            }
            throw new NotImplementedException();
        }

        private Expression Contains(elm.ContainsExpression e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e!.operand![0]!, ctx);
            var right = TranslateExpression(e.operand[1]!, ctx);
            var precision = Expression.Constant(e.precision, typeof(string));
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
                var call = Operators.Bind(CqlOperator.ListContains, ctx.RuntimeContextParameter, left, right);
                return call;
            }
            else if (IsInterval(left.Type, out var pointType))
            {
                var call = Operators.Bind(CqlOperator.IntervalContains, ctx.RuntimeContextParameter, left, right, precision);
                return call;
            }
            throw new NotImplementedException();
        }

        private Expression End(elm.EndExpression e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.IntervalEnd, e, ctx);

        private Expression? Ends(elm.EndsExpression e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            var precision = Expression.Constant(e.precision, typeof(string));
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw new InvalidOperationException();
                    return Operators.Bind(CqlOperator.Ends, ctx.RuntimeContextParameter, left, right, precision);

                }
            }
            throw new NotImplementedException();
        }

        protected Expression Except(elm.ExceptExpression e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            if (IsOrImplementsIEnumerableOfT(left.Type) && IsOrImplementsIEnumerableOfT(right.Type))
            {
                return Operators.Bind(CqlOperator.ListExcept, ctx.RuntimeContextParameter, left, right);
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw new InvalidOperationException();
                    return Operators.Bind(CqlOperator.IntervalExcept, ctx.RuntimeContextParameter, left, right);

                }
                else throw new NotImplementedException();
            }
            throw new NotImplementedException();
        }

        protected Expression? Expand(elm.ExpandExpression e, ExpressionBuilderContext ctx)
        {
            var source = TranslateExpression(e!.operand![0]!, ctx);
            var quantity = TranslateExpression(e!.operand![1]!, ctx);
            return Operators.Bind(CqlOperator.Expand, ctx.RuntimeContextParameter, source, quantity);
        }

        protected Expression In(elm.InExpression e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0]!, ctx);
            var right = TranslateExpression(e.operand![1]!, ctx);
            if (IsOrImplementsIEnumerableOfT(right.Type))
            {
                return Operators.Bind(CqlOperator.InList, ctx.RuntimeContextParameter, left, right);
            }
            else if (IsInterval(right.Type, out var rightElementType))
            {
                var precision = Expression.Constant(e.precision, typeof(string));

                return Operators.Bind(CqlOperator.InInterval, ctx.RuntimeContextParameter, left, right, precision);

            }
            else throw new NotImplementedException();
        }


        protected Expression? Includes(elm.IncludesExpression e, ExpressionBuilderContext ctx)
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
                    return Operators.Bind(CqlOperator.ListIncludesList, ctx.RuntimeContextParameter, left, right);
                }
                else
                {
                    if (leftElementType != right.Type)
                        throw new InvalidOperationException();
                    return Operators.Bind(CqlOperator.ListIncludesElement, ctx.RuntimeContextParameter, left, right);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var pointType))
                {
                    var precision = Expression.Constant(e.precision, typeof(string));
                    return Operators.Bind(CqlOperator.IntervalIncludesInterval, ctx.RuntimeContextParameter, left, right, precision);
                }
                else
                {
                    var precision = Expression.Constant(e.precision, typeof(string));
                    return Operators.Bind(CqlOperator.IntervalIncludesElement, ctx.RuntimeContextParameter, left, right, precision);
                }
            }
            throw new NotImplementedException();
        }

        protected Expression IncludedIn(elm.IncludedInExpression e, ExpressionBuilderContext ctx)
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
                    return Operators.Bind(CqlOperator.ListIncludesList, ctx.RuntimeContextParameter, right, left);
                }
                else
                {
                    if (leftElementType != right.Type)
                        throw new InvalidOperationException();
                    return Operators.Bind(CqlOperator.ListIncludesElement, ctx.RuntimeContextParameter, right, left);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType) && IsInterval(right.Type, out var rightPointType))
            {
                var precision = Expression.Constant(e.precision, typeof(string));
                return Operators.Bind(CqlOperator.IntervalIncludesInterval, ctx.RuntimeContextParameter, right, left, precision);
            }
            else if (IsInterval(right.Type, out var pointType))
            {
                var precision = Expression.Constant(e.precision, typeof(string));
                if (left.Type != pointType)
                    throw new InvalidOperationException();
                return Operators.Bind(CqlOperator.IntervalIncludesElement, ctx.RuntimeContextParameter, right, left, precision);

            }
            throw new NotImplementedException();
        }

        protected Expression Intersect(elm.IntersectExpression e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0]!, ctx);
            var right = TranslateExpression(e.operand![1]!, ctx);
            if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                return Operators.Bind(CqlOperator.ListIntersect, ctx.RuntimeContextParameter, left, right);
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    return Operators.Bind(CqlOperator.IntervalIntersect, ctx.RuntimeContextParameter, left, right);
                }
                else throw new NotImplementedException();
            }
            throw new NotImplementedException();
        }

        protected Expression? Meets(elm.MeetsExpression e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw new InvalidOperationException();
                    var precision = Expression.Constant(e.precision, typeof(string));
                    return Operators.Bind(CqlOperator.Meets, ctx.RuntimeContextParameter, left, right, precision);
                }
                else throw new NotImplementedException();
            }
            throw new NotImplementedException();
        }

        private Expression? MeetsAfter(elm.MeetsAfterExpression e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw new InvalidOperationException();
                    var precision = Expression.Constant(e.precision, typeof(string));
                    return Operators.Bind(CqlOperator.MeetsAfter, ctx.RuntimeContextParameter, left, right, precision);
                }
                else throw new NotImplementedException();
            }
            throw new NotImplementedException();
        }

        private Expression? MeetsBefore(elm.MeetsBeforeExpression e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {

                    if (leftPointType != rightPointType)
                        throw new InvalidOperationException();
                    var precision = Expression.Constant(e.precision, typeof(string));
                    return Operators.Bind(CqlOperator.MeetsBefore, ctx.RuntimeContextParameter, left, right, precision);
                }
                else throw new NotImplementedException();
            }
            throw new NotImplementedException();
        }

        protected Expression Overlaps(elm.OverlapsExpression e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw new InvalidOperationException();
                    var precision = Expression.Constant(e.precision, typeof(string));
                    return Operators.Bind(CqlOperator.Overlaps, ctx.RuntimeContextParameter, left, right, precision);
                }
                else throw new NotImplementedException();
            }
            throw new NotImplementedException();
        }

        private Expression OverlapsBefore(elm.OverlapsBeforeExpression e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw new InvalidOperationException();
                    var precision = Expression.Constant(e.precision, typeof(string));
                    return Operators.Bind(CqlOperator.OverlapsBefore, ctx.RuntimeContextParameter, left, right, precision);
                }
                else throw new NotImplementedException();
            }
            throw new NotImplementedException();
        }

        private Expression OverlapsAfter(elm.OverlapsAfterExpression e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw new InvalidOperationException();
                    var precision = Expression.Constant(e.precision, typeof(string));
                    return Operators.Bind(CqlOperator.OverlapsAfter, ctx.RuntimeContextParameter, left, right, precision);
                }
                else throw new NotImplementedException();
            }
            throw new NotImplementedException();
        }




        protected Expression? PointFrom(elm.PointFromExpression e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.PointFrom, e, ctx);

        protected Expression? ProperIncludes(elm.ProperIncludesExpression e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    var precision = Expression.Constant(e.precision, typeof(string));
                    return Operators.Bind(CqlOperator.IntervalProperlyIncludesInterval, ctx.RuntimeContextParameter, left, right, precision);
                }
            }
            else if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                var leftElementType = TypeResolver.GetListElementType(left.Type);
                if (IsOrImplementsIEnumerableOfT(right.Type))
                {
                    var rightElementType = TypeResolver.GetListElementType(right.Type);
                    return Operators.Bind(CqlOperator.ListProperlyIncludesList, ctx.RuntimeContextParameter, left, right);
                }
            }
            throw new NotImplementedException();
        }


        protected Expression? ProperIncludedIn(elm.ProperIncludedInExpression pie, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(pie.operand![0], ctx);
            var right = TranslateExpression(pie.operand![1], ctx);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    var precision = Expression.Constant(pie.precision, typeof(string));
                    return Operators.Bind(CqlOperator.IntervalProperlyIncludesInterval, ctx.RuntimeContextParameter, right, left, precision);
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
                    return Operators.Bind(CqlOperator.ListProperlyIncludesList, ctx.RuntimeContextParameter, right, left);
                }
            }
            throw new NotImplementedException();
        }

        private Expression? ProperIn(elm.ProperInExpression e, ExpressionBuilderContext ctx)
        {
            var element = TranslateExpression(e.operand![0], ctx);
            var intervalOrList = TranslateExpression(e.operand![1], ctx);
            if (IsInterval(intervalOrList.Type, out var pointType))
            {
                var precision = Expression.Constant(e.precision, typeof(string));
                return Operators.Bind(CqlOperator.IntervalProperlyIncludesElement, ctx.RuntimeContextParameter, intervalOrList, element, precision);
            }
            else if (IsOrImplementsIEnumerableOfT(intervalOrList.Type))
            {
                return Operators.Bind(CqlOperator.ListProperlyIncludesElement, ctx.RuntimeContextParameter, intervalOrList, element);
            }
            throw new NotImplementedException();
        }

        protected Expression? ProperContains(elm.ProperContainsExpression e, ExpressionBuilderContext ctx)
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
                    return Operators.Bind(CqlOperator.ListProperlyIncludesList, ctx.RuntimeContextParameter, left, right);
                }
                else
                {
                    if (leftElementType != right.Type)
                        throw new InvalidOperationException();
                    return Operators.Bind(CqlOperator.ListProperlyIncludesElement, ctx.RuntimeContextParameter, left, right);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (leftPointType != right.Type)
                    throw new InvalidOperationException();
                var precision = Expression.Constant(e.precision, typeof(string));
                return Operators.Bind(CqlOperator.IntervalProperlyIncludesElement, ctx.RuntimeContextParameter, left, right, precision);
            }
            throw new NotImplementedException();
        }


        protected Expression Start(elm.StartExpression start, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.IntervalStart, start, ctx);


        protected Expression? Starts(elm.StartsExpression e, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(e.operand![0], ctx);
            var right = TranslateExpression(e.operand![1], ctx);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw new InvalidOperationException();
                    var precision = Expression.Constant(e.precision, typeof(string));
                    return Operators.Bind(CqlOperator.Starts, ctx.RuntimeContextParameter, left, right, precision);

                }
            }
            throw new NotImplementedException();
        }


        protected Expression Union(elm.UnionExpression e, ExpressionBuilderContext ctx)
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
                    return Operators.Bind(CqlOperator.ListUnion, ctx.RuntimeContextParameter, left, right);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw new InvalidOperationException();
                    return Operators.Bind(CqlOperator.IntervalUnion, ctx.RuntimeContextParameter, left, right);
                }
            }
            throw new NotImplementedException();
        }

        protected Expression? Width(elm.WidthExpression e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Width, e, ctx);
    }
}
