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
using Hl7.Cql.Runtime;
using elm = Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilderContext
    {
        private Expression Collapse(elm.Collapse e)
        {
            var operand = this.TranslateExpression(e.operand![0]!);
            if (IsOrImplementsIEnumerableOfT(operand.Type))
            {
                var elementType = _typeManager.Resolver.GetListElementType(operand.Type, @throw: true)!;
                if (IsInterval(elementType, out var pointType))
                {
                    var precision = Expression.Constant(null, typeof(string));
                    if (e.operand.Length > 1 && e.operand[1] is elm.Quantity quant)
                    {
                        precision = Expression.Constant(quant.unit, typeof(string));
                    }
                    return this.OperatorBinding.Bind(CqlOperator.Collapse, this.RuntimeContextParameter, operand, precision);
                }
            }
            throw new NotImplementedException().WithContext(this);
        }

        private Expression Contains(elm.Contains e)
        {
            var left = this.TranslateExpression(e!.operand![0]!);
            var right = this.TranslateExpression(e.operand[1]!);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                var elementType = _typeManager.Resolver.GetListElementType(left.Type, @throw: true)!;
                if (elementType != right.Type)
                {
                    if (elementType.IsAssignableFrom(right.Type))
                    {
                        right = this.ChangeType(right, elementType);
                    }
                    else throw this.NewExpressionBuildingException($"Cannot convert Contains target {TypeManager.PrettyTypeName(right.Type)} to {TypeManager.PrettyTypeName(elementType)}");
                }
                var call = this.OperatorBinding.Bind(CqlOperator.ListContains, this.RuntimeContextParameter, left, right);
                return call;
            }
            else if (IsInterval(left.Type, out var pointType))
            {
                var call = this.OperatorBinding.Bind(CqlOperator.IntervalContains, this.RuntimeContextParameter, left, right, precision);
                return call;
            }
            throw new NotImplementedException().WithContext(this);
        }

        private Expression End(elm.End e) =>
            UnaryOperator(CqlOperator.IntervalEnd, e);

        private Expression? Ends(elm.Ends e)
        {
            var left = this.TranslateExpression(e.operand![0]);
            var right = this.TranslateExpression(e.operand![1]);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    return this.OperatorBinding.Bind(CqlOperator.Ends, this.RuntimeContextParameter, left, right, precision);

                }
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression Except(elm.Except e)
        {
            var left = this.TranslateExpression(e.operand![0]);
            var right = this.TranslateExpression(e.operand![1]);
            if (IsOrImplementsIEnumerableOfT(left.Type) && IsOrImplementsIEnumerableOfT(right.Type))
            {
                return this.OperatorBinding.Bind(CqlOperator.ListExcept, this.RuntimeContextParameter, left, right);
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    return this.OperatorBinding.Bind(CqlOperator.IntervalExcept, this.RuntimeContextParameter, left, right);

                }
                else throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression? Expand(elm.Expand e)
        {
            ExpressionBuilderContext ctx = this;
            var source = ctx.TranslateExpression(e!.operand![0]!);
            var quantity = ctx.TranslateExpression(e!.operand![1]!);
            return ctx.OperatorBinding.Bind(CqlOperator.Expand, ctx.RuntimeContextParameter, source, quantity);
        }

        protected Expression In(elm.In e)
        {
            var left = this.TranslateExpression(e.operand![0]!);
            var right = this.TranslateExpression(e.operand![1]!);
            if (IsOrImplementsIEnumerableOfT(right.Type))
            {
                return this.OperatorBinding.Bind(CqlOperator.InList, this.RuntimeContextParameter, left, right);
            }
            else if (IsInterval(right.Type, out var rightElementType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);

                return this.OperatorBinding.Bind(CqlOperator.InInterval, this.RuntimeContextParameter, left, right, precision);

            }
            else throw new NotImplementedException().WithContext(this);
        }


        protected Expression? Includes(elm.Includes e)
        {
            var left = this.TranslateExpression(e.operand![0]);
            var right = this.TranslateExpression(e.operand![1]);
            if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                var leftElementType = _typeManager.Resolver.GetListElementType(left.Type);
                if (IsOrImplementsIEnumerableOfT(right.Type))
                {
                    var rightElementType = _typeManager.Resolver.GetListElementType(left.Type);
                    if (leftElementType != rightElementType)
                        throw this.NewExpressionBuildingException();
                    return this.OperatorBinding.Bind(CqlOperator.ListIncludesList, this.RuntimeContextParameter, left, right);
                }
                else
                {
                    if (leftElementType != right.Type)
                        throw this.NewExpressionBuildingException();
                    return this.OperatorBinding.Bind(CqlOperator.ListIncludesElement, this.RuntimeContextParameter, left, right);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var pointType))
                {
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return this.OperatorBinding.Bind(CqlOperator.IntervalIncludesInterval, this.RuntimeContextParameter, left, right, precision);
                }
                else
                {
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return this.OperatorBinding.Bind(CqlOperator.IntervalIncludesElement, this.RuntimeContextParameter, left, right, precision);
                }
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression IncludedIn(elm.IncludedIn e)
        {
            var left = this.TranslateExpression(e.operand![0]);
            var right = this.TranslateExpression(e.operand![1]);
            if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                var leftElementType = _typeManager.Resolver.GetListElementType(left.Type);
                if (IsOrImplementsIEnumerableOfT(right.Type))
                {
                    var rightElementType = _typeManager.Resolver.GetListElementType(left.Type);
                    if (leftElementType != rightElementType)
                        throw this.NewExpressionBuildingException();
                    return this.OperatorBinding.Bind(CqlOperator.ListIncludesList, this.RuntimeContextParameter, right, left);
                }
                else
                {
                    if (leftElementType != right.Type)
                        throw this.NewExpressionBuildingException();
                    return this.OperatorBinding.Bind(CqlOperator.ListIncludesElement, this.RuntimeContextParameter, right, left);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType) && IsInterval(right.Type, out var rightPointType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);
                return this.OperatorBinding.Bind(CqlOperator.IntervalIncludesInterval, this.RuntimeContextParameter, right, left, precision);
            }
            else if (IsInterval(right.Type, out var pointType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);
                if (left.Type != pointType)
                    throw this.NewExpressionBuildingException();
                return this.OperatorBinding.Bind(CqlOperator.IntervalIncludesElement, this.RuntimeContextParameter, right, left, precision);

            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression Intersect(elm.Intersect e)
        {
            var left = this.TranslateExpression(e.operand![0]!);
            var right = this.TranslateExpression(e.operand![1]!);
            if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                return this.OperatorBinding.Bind(CqlOperator.ListIntersect, this.RuntimeContextParameter, left, right);
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    return this.OperatorBinding.Bind(CqlOperator.IntervalIntersect, this.RuntimeContextParameter, left, right);
                }
                else throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression? Meets(elm.Meets e)
        {
            var left = this.TranslateExpression(e.operand![0]);
            var right = this.TranslateExpression(e.operand![1]);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return this.OperatorBinding.Bind(CqlOperator.Meets, this.RuntimeContextParameter, left, right, precision);
                }
                else throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        private Expression? MeetsAfter(elm.MeetsAfter e)
        {
            var left = this.TranslateExpression(e.operand![0]);
            var right = this.TranslateExpression(e.operand![1]);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return this.OperatorBinding.Bind(CqlOperator.MeetsAfter, this.RuntimeContextParameter, left, right, precision);
                }
                else throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        private Expression? MeetsBefore(elm.MeetsBefore e)
        {
            var left = this.TranslateExpression(e.operand![0]);
            var right = this.TranslateExpression(e.operand![1]);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {

                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return this.OperatorBinding.Bind(CqlOperator.MeetsBefore, this.RuntimeContextParameter, left, right, precision);
                }
                else throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression Overlaps(elm.Overlaps e)
        {
            var left = this.TranslateExpression(e.operand![0]);
            var right = this.TranslateExpression(e.operand![1]);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return this.OperatorBinding.Bind(CqlOperator.Overlaps, this.RuntimeContextParameter, left, right, precision);
                }
                else throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        private Expression OverlapsBefore(elm.OverlapsBefore e)
        {
            var left = this.TranslateExpression(e.operand![0]);
            var right = this.TranslateExpression(e.operand![1]);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return this.OperatorBinding.Bind(CqlOperator.OverlapsBefore, this.RuntimeContextParameter, left, right, precision);
                }
                else throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        private Expression OverlapsAfter(elm.OverlapsAfter e)
        {
            var left = this.TranslateExpression(e.operand![0]);
            var right = this.TranslateExpression(e.operand![1]);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return this.OperatorBinding.Bind(CqlOperator.OverlapsAfter, this.RuntimeContextParameter, left, right, precision);
                }
                else throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }




        protected Expression? PointFrom(elm.PointFrom e) =>
            UnaryOperator(CqlOperator.PointFrom, e);

        protected Expression? ProperIncludes(elm.ProperIncludes e)
        {
            var left = this.TranslateExpression(e.operand![0]);
            var right = this.TranslateExpression(e.operand![1]);
            if (IsInterval(left.Type, out var leftPointType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);
                if (IsInterval(right.Type, out var rightPointType))
                {
                    return this.OperatorBinding.Bind(CqlOperator.IntervalProperlyIncludesInterval, this.RuntimeContextParameter, left, right, precision);
                }
                else
                {
                    return this.OperatorBinding.Bind(CqlOperator.IntervalProperlyIncludesElement, this.RuntimeContextParameter, left, right, precision);
                }
            }
            else if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                var leftElementType = _typeManager.Resolver.GetListElementType(left.Type);
                if (IsOrImplementsIEnumerableOfT(right.Type))
                {
                    var rightElementType = _typeManager.Resolver.GetListElementType(right.Type);
                    return this.OperatorBinding.Bind(CqlOperator.ListProperlyIncludesList, this.RuntimeContextParameter, left, right);
                }
                else
                {
                    return this.OperatorBinding.Bind(CqlOperator.ListProperlyIncludesElement, this.RuntimeContextParameter, left, right);
                }
            }
            throw new NotImplementedException().WithContext(this);
        }


        protected Expression? ProperIncludedIn(elm.ProperIncludedIn e)
        {
            var left = this.TranslateExpression(e.operand![0]);
            var right = this.TranslateExpression(e.operand![1]);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return this.OperatorBinding.Bind(CqlOperator.IntervalProperlyIncludesInterval, this.RuntimeContextParameter, right, left, precision);
                }
            }
            else if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                var leftElementType = _typeManager.Resolver.GetListElementType(left.Type);
                if (IsOrImplementsIEnumerableOfT(right.Type))
                {
                    var rightElementType = _typeManager.Resolver.GetListElementType(right.Type);
                    if (leftElementType != rightElementType)
                        throw this.NewExpressionBuildingException();
                    return this.OperatorBinding.Bind(CqlOperator.ListProperlyIncludesList, this.RuntimeContextParameter, right, left);
                }
            }
            else if (IsInterval(right.Type, out var rightPointType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);
                return this.OperatorBinding.Bind(CqlOperator.IntervalProperlyIncludesElement, this.RuntimeContextParameter, right, left, precision);
            }
            throw new NotImplementedException().WithContext(this);
        }

        private Expression? ProperIn(elm.ProperIn e)
        {
            var element = this.TranslateExpression(e.operand![0]);
            var intervalOrList = this.TranslateExpression(e.operand![1]);
            if (IsInterval(intervalOrList.Type, out var pointType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);
                return this.OperatorBinding.Bind(CqlOperator.IntervalProperlyIncludesElement, this.RuntimeContextParameter, intervalOrList, element, precision);
            }
            else if (IsOrImplementsIEnumerableOfT(intervalOrList.Type))
            {
                return this.OperatorBinding.Bind(CqlOperator.ListProperlyIncludesElement, this.RuntimeContextParameter, intervalOrList, element);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression? ProperContains(elm.ProperContains e)
        {
            var left = this.TranslateExpression(e.operand![0]);
            var right = this.TranslateExpression(e.operand![1]);
            if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                var leftElementType = _typeManager.Resolver.GetListElementType(left.Type);
                if (IsOrImplementsIEnumerableOfT(right.Type))
                {
                    var rightElementType = _typeManager.Resolver.GetListElementType(right.Type);
                    if (leftElementType != rightElementType)
                        throw this.NewExpressionBuildingException();
                    return this.OperatorBinding.Bind(CqlOperator.ListProperlyIncludesList, this.RuntimeContextParameter, left, right);
                }
                else
                {
                    if (leftElementType != right.Type)
                        throw this.NewExpressionBuildingException();
                    return this.OperatorBinding.Bind(CqlOperator.ListProperlyIncludesElement, this.RuntimeContextParameter, left, right);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (leftPointType != right.Type)
                    throw this.NewExpressionBuildingException();
                var precision = Precision(e.precision, e.precisionSpecified);
                return this.OperatorBinding.Bind(CqlOperator.IntervalProperlyIncludesElement, this.RuntimeContextParameter, left, right, precision);
            }
            throw new NotImplementedException().WithContext(this);
        }


        protected Expression Start(elm.Start start) =>
            UnaryOperator(CqlOperator.IntervalStart, start);


        protected Expression? Starts(elm.Starts e)
        {
            var left = this.TranslateExpression(e.operand![0]);
            var right = this.TranslateExpression(e.operand![1]);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return this.OperatorBinding.Bind(CqlOperator.Starts, this.RuntimeContextParameter, left, right, precision);

                }
            }
            throw new NotImplementedException().WithContext(this);
        }


        protected Expression Union(elm.Union e)
        {
            var left = this.TranslateExpression(e.operand![0]);
            var right = this.TranslateExpression(e.operand![1]);
            if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                var leftElementType = _typeManager.Resolver.GetListElementType(left.Type);
                if (IsOrImplementsIEnumerableOfT(right.Type))
                {
                    var rightElementType = _typeManager.Resolver.GetListElementType(right.Type);
                    if (leftElementType != rightElementType)
                        throw this.NewExpressionBuildingException();
                    return this.OperatorBinding.Bind(CqlOperator.ListUnion, this.RuntimeContextParameter, left, right);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    return this.OperatorBinding.Bind(CqlOperator.IntervalUnion, this.RuntimeContextParameter, left, right);
                }
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression? Width(elm.Width e) =>
            UnaryOperator(CqlOperator.Width, e);

    }
}
