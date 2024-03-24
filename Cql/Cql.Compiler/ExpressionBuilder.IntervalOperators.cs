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
    internal partial class ContextualExpressionBuilder
    {
        private Expression Collapse(elm.Collapse e)
        {
            var operand = TranslateExpression(e.operand![0]!);
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
                    return OperatorBinding.Bind(CqlOperator.Collapse, RuntimeContextParameter, operand, precision);
                }
            }
            throw new NotImplementedException().WithContext(this);
        }

        private Expression Contains(elm.Contains e)
        {
            var left = TranslateExpression(e!.operand![0]!);
            var right = TranslateExpression(e.operand[1]!);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                var elementType = _typeManager.Resolver.GetListElementType(left.Type, @throw: true)!;
                if (elementType != right.Type)
                {
                    if (elementType.IsAssignableFrom(right.Type))
                    {
                        right = ChangeType(right, elementType);
                    }
                    else throw this.NewExpressionBuildingException($"Cannot convert Contains target {TypeManager.PrettyTypeName(right.Type)} to {TypeManager.PrettyTypeName(elementType)}");
                }
                var call = OperatorBinding.Bind(CqlOperator.ListContains, RuntimeContextParameter, left, right);
                return call;
            }
            else if (IsInterval(left.Type, out var pointType))
            {
                var call = OperatorBinding.Bind(CqlOperator.IntervalContains, RuntimeContextParameter, left, right, precision);
                return call;
            }
            throw new NotImplementedException().WithContext(this);
        }

        private Expression End(elm.End e) =>
            UnaryOperator(CqlOperator.IntervalEnd, e);

        private Expression? Ends(elm.Ends e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    return OperatorBinding.Bind(CqlOperator.Ends, RuntimeContextParameter, left, right, precision);

                }
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression Except(elm.Except e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (IsOrImplementsIEnumerableOfT(left.Type) && IsOrImplementsIEnumerableOfT(right.Type))
            {
                return OperatorBinding.Bind(CqlOperator.ListExcept, RuntimeContextParameter, left, right);
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    return OperatorBinding.Bind(CqlOperator.IntervalExcept, RuntimeContextParameter, left, right);

                }
                else throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression? Expand(elm.Expand e)
        {
            var source = this.TranslateExpression(e!.operand![0]!);
            var quantity = this.TranslateExpression(e!.operand![1]!);
            return OperatorBinding.Bind(CqlOperator.Expand, this.RuntimeContextParameter, source, quantity);
        }

        protected Expression In(elm.In e)
        {
            var left = TranslateExpression(e.operand![0]!);
            var right = TranslateExpression(e.operand![1]!);
            if (IsOrImplementsIEnumerableOfT(right.Type))
            {
                return OperatorBinding.Bind(CqlOperator.InList, RuntimeContextParameter, left, right);
            }
            else if (IsInterval(right.Type, out var rightElementType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);

                return OperatorBinding.Bind(CqlOperator.InInterval, RuntimeContextParameter, left, right, precision);

            }
            else throw new NotImplementedException().WithContext(this);
        }


        protected Expression? Includes(elm.Includes e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                var leftElementType = _typeManager.Resolver.GetListElementType(left.Type);
                if (IsOrImplementsIEnumerableOfT(right.Type))
                {
                    var rightElementType = _typeManager.Resolver.GetListElementType(left.Type);
                    if (leftElementType != rightElementType)
                        throw this.NewExpressionBuildingException();
                    return OperatorBinding.Bind(CqlOperator.ListIncludesList, RuntimeContextParameter, left, right);
                }
                else
                {
                    if (leftElementType != right.Type)
                        throw this.NewExpressionBuildingException();
                    return OperatorBinding.Bind(CqlOperator.ListIncludesElement, RuntimeContextParameter, left, right);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var pointType))
                {
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return OperatorBinding.Bind(CqlOperator.IntervalIncludesInterval, RuntimeContextParameter, left, right, precision);
                }
                else
                {
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return OperatorBinding.Bind(CqlOperator.IntervalIncludesElement, RuntimeContextParameter, left, right, precision);
                }
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression IncludedIn(elm.IncludedIn e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                var leftElementType = _typeManager.Resolver.GetListElementType(left.Type);
                if (IsOrImplementsIEnumerableOfT(right.Type))
                {
                    var rightElementType = _typeManager.Resolver.GetListElementType(left.Type);
                    if (leftElementType != rightElementType)
                        throw this.NewExpressionBuildingException();
                    return OperatorBinding.Bind(CqlOperator.ListIncludesList, RuntimeContextParameter, right, left);
                }
                else
                {
                    if (leftElementType != right.Type)
                        throw this.NewExpressionBuildingException();
                    return OperatorBinding.Bind(CqlOperator.ListIncludesElement, RuntimeContextParameter, right, left);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType) && IsInterval(right.Type, out var rightPointType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);
                return OperatorBinding.Bind(CqlOperator.IntervalIncludesInterval, RuntimeContextParameter, right, left, precision);
            }
            else if (IsInterval(right.Type, out var pointType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);
                if (left.Type != pointType)
                    throw this.NewExpressionBuildingException();
                return OperatorBinding.Bind(CqlOperator.IntervalIncludesElement, RuntimeContextParameter, right, left, precision);

            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression Intersect(elm.Intersect e)
        {
            var left = TranslateExpression(e.operand![0]!);
            var right = TranslateExpression(e.operand![1]!);
            if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                return OperatorBinding.Bind(CqlOperator.ListIntersect, RuntimeContextParameter, left, right);
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    return OperatorBinding.Bind(CqlOperator.IntervalIntersect, RuntimeContextParameter, left, right);
                }
                else throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression? Meets(elm.Meets e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return OperatorBinding.Bind(CqlOperator.Meets, RuntimeContextParameter, left, right, precision);
                }
                else throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        private Expression? MeetsAfter(elm.MeetsAfter e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return OperatorBinding.Bind(CqlOperator.MeetsAfter, RuntimeContextParameter, left, right, precision);
                }
                else throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        private Expression? MeetsBefore(elm.MeetsBefore e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {

                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return OperatorBinding.Bind(CqlOperator.MeetsBefore, RuntimeContextParameter, left, right, precision);
                }
                else throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression Overlaps(elm.Overlaps e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return OperatorBinding.Bind(CqlOperator.Overlaps, RuntimeContextParameter, left, right, precision);
                }
                else throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        private Expression OverlapsBefore(elm.OverlapsBefore e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return OperatorBinding.Bind(CqlOperator.OverlapsBefore, RuntimeContextParameter, left, right, precision);
                }
                else throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        private Expression OverlapsAfter(elm.OverlapsAfter e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return OperatorBinding.Bind(CqlOperator.OverlapsAfter, RuntimeContextParameter, left, right, precision);
                }
                else throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }




        protected Expression? PointFrom(elm.PointFrom e) =>
            UnaryOperator(CqlOperator.PointFrom, e);

        protected Expression? ProperIncludes(elm.ProperIncludes e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (IsInterval(left.Type, out var leftPointType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);
                if (IsInterval(right.Type, out var rightPointType))
                {
                    return OperatorBinding.Bind(CqlOperator.IntervalProperlyIncludesInterval, RuntimeContextParameter, left, right, precision);
                }
                else
                {
                    return OperatorBinding.Bind(CqlOperator.IntervalProperlyIncludesElement, RuntimeContextParameter, left, right, precision);
                }
            }
            else if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                var leftElementType = _typeManager.Resolver.GetListElementType(left.Type);
                if (IsOrImplementsIEnumerableOfT(right.Type))
                {
                    var rightElementType = _typeManager.Resolver.GetListElementType(right.Type);
                    return OperatorBinding.Bind(CqlOperator.ListProperlyIncludesList, RuntimeContextParameter, left, right);
                }
                else
                {
                    return OperatorBinding.Bind(CqlOperator.ListProperlyIncludesElement, RuntimeContextParameter, left, right);
                }
            }
            throw new NotImplementedException().WithContext(this);
        }


        protected Expression? ProperIncludedIn(elm.ProperIncludedIn e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return OperatorBinding.Bind(CqlOperator.IntervalProperlyIncludesInterval, RuntimeContextParameter, right, left, precision);
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
                    return OperatorBinding.Bind(CqlOperator.ListProperlyIncludesList, RuntimeContextParameter, right, left);
                }
            }
            else if (IsInterval(right.Type, out var rightPointType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);
                return OperatorBinding.Bind(CqlOperator.IntervalProperlyIncludesElement, RuntimeContextParameter, right, left, precision);
            }
            throw new NotImplementedException().WithContext(this);
        }

        private Expression? ProperIn(elm.ProperIn e)
        {
            var element = TranslateExpression(e.operand![0]);
            var intervalOrList = TranslateExpression(e.operand![1]);
            if (IsInterval(intervalOrList.Type, out var pointType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);
                return OperatorBinding.Bind(CqlOperator.IntervalProperlyIncludesElement, RuntimeContextParameter, intervalOrList, element, precision);
            }
            else if (IsOrImplementsIEnumerableOfT(intervalOrList.Type))
            {
                return OperatorBinding.Bind(CqlOperator.ListProperlyIncludesElement, RuntimeContextParameter, intervalOrList, element);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression? ProperContains(elm.ProperContains e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                var leftElementType = _typeManager.Resolver.GetListElementType(left.Type);
                if (IsOrImplementsIEnumerableOfT(right.Type))
                {
                    var rightElementType = _typeManager.Resolver.GetListElementType(right.Type);
                    if (leftElementType != rightElementType)
                        throw this.NewExpressionBuildingException();
                    return OperatorBinding.Bind(CqlOperator.ListProperlyIncludesList, RuntimeContextParameter, left, right);
                }
                else
                {
                    if (leftElementType != right.Type)
                        throw this.NewExpressionBuildingException();
                    return OperatorBinding.Bind(CqlOperator.ListProperlyIncludesElement, RuntimeContextParameter, left, right);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (leftPointType != right.Type)
                    throw this.NewExpressionBuildingException();
                var precision = Precision(e.precision, e.precisionSpecified);
                return OperatorBinding.Bind(CqlOperator.IntervalProperlyIncludesElement, RuntimeContextParameter, left, right, precision);
            }
            throw new NotImplementedException().WithContext(this);
        }


        protected Expression Start(elm.Start start) =>
            UnaryOperator(CqlOperator.IntervalStart, start);


        protected Expression? Starts(elm.Starts e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return OperatorBinding.Bind(CqlOperator.Starts, RuntimeContextParameter, left, right, precision);

                }
            }
            throw new NotImplementedException().WithContext(this);
        }


        protected Expression Union(elm.Union e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                var leftElementType = _typeManager.Resolver.GetListElementType(left.Type);
                if (IsOrImplementsIEnumerableOfT(right.Type))
                {
                    var rightElementType = _typeManager.Resolver.GetListElementType(right.Type);
                    if (leftElementType != rightElementType)
                        throw this.NewExpressionBuildingException();
                    return OperatorBinding.Bind(CqlOperator.ListUnion, RuntimeContextParameter, left, right);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    return OperatorBinding.Bind(CqlOperator.IntervalUnion, RuntimeContextParameter, left, right);
                }
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression? Width(elm.Width e) =>
            UnaryOperator(CqlOperator.Width, e);

    }
}
