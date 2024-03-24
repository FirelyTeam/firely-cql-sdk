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
                    return _operatorBinding.Bind(CqlOperator.Collapse, ExpressionBuilder.ContextParameter, operand, precision);
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
                var call = _operatorBinding.Bind(CqlOperator.ListContains, ExpressionBuilder.ContextParameter, left, right);
                return call;
            }
            else if (IsInterval(left.Type, out var pointType))
            {
                var call = _operatorBinding.Bind(CqlOperator.IntervalContains, ExpressionBuilder.ContextParameter, left, right, precision);
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
                    return _operatorBinding.Bind(CqlOperator.Ends, ExpressionBuilder.ContextParameter, left, right, precision);

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
                return _operatorBinding.Bind(CqlOperator.ListExcept, ExpressionBuilder.ContextParameter, left, right);
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    return _operatorBinding.Bind(CqlOperator.IntervalExcept, ExpressionBuilder.ContextParameter, left, right);

                }
                else throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression? Expand(elm.Expand e)
        {
            var source = this.TranslateExpression(e!.operand![0]!);
            var quantity = this.TranslateExpression(e!.operand![1]!);
            return _operatorBinding.Bind(CqlOperator.Expand, ExpressionBuilder.ContextParameter, source, quantity);
        }

        protected Expression In(elm.In e)
        {
            var left = TranslateExpression(e.operand![0]!);
            var right = TranslateExpression(e.operand![1]!);
            if (IsOrImplementsIEnumerableOfT(right.Type))
            {
                return _operatorBinding.Bind(CqlOperator.InList, ExpressionBuilder.ContextParameter, left, right);
            }
            else if (IsInterval(right.Type, out var rightElementType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);

                return _operatorBinding.Bind(CqlOperator.InInterval, ExpressionBuilder.ContextParameter, left, right, precision);

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
                    return _operatorBinding.Bind(CqlOperator.ListIncludesList, ExpressionBuilder.ContextParameter, left, right);
                }
                else
                {
                    if (leftElementType != right.Type)
                        throw this.NewExpressionBuildingException();
                    return _operatorBinding.Bind(CqlOperator.ListIncludesElement, ExpressionBuilder.ContextParameter, left, right);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var pointType))
                {
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return _operatorBinding.Bind(CqlOperator.IntervalIncludesInterval, ExpressionBuilder.ContextParameter, left, right, precision);
                }
                else
                {
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return _operatorBinding.Bind(CqlOperator.IntervalIncludesElement, ExpressionBuilder.ContextParameter, left, right, precision);
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
                    return _operatorBinding.Bind(CqlOperator.ListIncludesList, ExpressionBuilder.ContextParameter, right, left);
                }
                else
                {
                    if (leftElementType != right.Type)
                        throw this.NewExpressionBuildingException();
                    return _operatorBinding.Bind(CqlOperator.ListIncludesElement, ExpressionBuilder.ContextParameter, right, left);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType) && IsInterval(right.Type, out var rightPointType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);
                return _operatorBinding.Bind(CqlOperator.IntervalIncludesInterval, ExpressionBuilder.ContextParameter, right, left, precision);
            }
            else if (IsInterval(right.Type, out var pointType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);
                if (left.Type != pointType)
                    throw this.NewExpressionBuildingException();
                return _operatorBinding.Bind(CqlOperator.IntervalIncludesElement, ExpressionBuilder.ContextParameter, right, left, precision);

            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression Intersect(elm.Intersect e)
        {
            var left = TranslateExpression(e.operand![0]!);
            var right = TranslateExpression(e.operand![1]!);
            if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                return _operatorBinding.Bind(CqlOperator.ListIntersect, ExpressionBuilder.ContextParameter, left, right);
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    return _operatorBinding.Bind(CqlOperator.IntervalIntersect, ExpressionBuilder.ContextParameter, left, right);
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
                    return _operatorBinding.Bind(CqlOperator.Meets, ExpressionBuilder.ContextParameter, left, right, precision);
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
                    return _operatorBinding.Bind(CqlOperator.MeetsAfter, ExpressionBuilder.ContextParameter, left, right, precision);
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
                    return _operatorBinding.Bind(CqlOperator.MeetsBefore, ExpressionBuilder.ContextParameter, left, right, precision);
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
                    return _operatorBinding.Bind(CqlOperator.Overlaps, ExpressionBuilder.ContextParameter, left, right, precision);
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
                    return _operatorBinding.Bind(CqlOperator.OverlapsBefore, ExpressionBuilder.ContextParameter, left, right, precision);
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
                    return _operatorBinding.Bind(CqlOperator.OverlapsAfter, ExpressionBuilder.ContextParameter, left, right, precision);
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
                    return _operatorBinding.Bind(CqlOperator.IntervalProperlyIncludesInterval, ExpressionBuilder.ContextParameter, left, right, precision);
                }
                else
                {
                    return _operatorBinding.Bind(CqlOperator.IntervalProperlyIncludesElement, ExpressionBuilder.ContextParameter, left, right, precision);
                }
            }
            else if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                var leftElementType = _typeManager.Resolver.GetListElementType(left.Type);
                if (IsOrImplementsIEnumerableOfT(right.Type))
                {
                    var rightElementType = _typeManager.Resolver.GetListElementType(right.Type);
                    return _operatorBinding.Bind(CqlOperator.ListProperlyIncludesList, ExpressionBuilder.ContextParameter, left, right);
                }
                else
                {
                    return _operatorBinding.Bind(CqlOperator.ListProperlyIncludesElement, ExpressionBuilder.ContextParameter, left, right);
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
                    return _operatorBinding.Bind(CqlOperator.IntervalProperlyIncludesInterval, ExpressionBuilder.ContextParameter, right, left, precision);
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
                    return _operatorBinding.Bind(CqlOperator.ListProperlyIncludesList, ExpressionBuilder.ContextParameter, right, left);
                }
            }
            else if (IsInterval(right.Type, out var rightPointType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);
                return _operatorBinding.Bind(CqlOperator.IntervalProperlyIncludesElement, ExpressionBuilder.ContextParameter, right, left, precision);
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
                return _operatorBinding.Bind(CqlOperator.IntervalProperlyIncludesElement, ExpressionBuilder.ContextParameter, intervalOrList, element, precision);
            }
            else if (IsOrImplementsIEnumerableOfT(intervalOrList.Type))
            {
                return _operatorBinding.Bind(CqlOperator.ListProperlyIncludesElement, ExpressionBuilder.ContextParameter, intervalOrList, element);
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
                    return _operatorBinding.Bind(CqlOperator.ListProperlyIncludesList, ExpressionBuilder.ContextParameter, left, right);
                }
                else
                {
                    if (leftElementType != right.Type)
                        throw this.NewExpressionBuildingException();
                    return _operatorBinding.Bind(CqlOperator.ListProperlyIncludesElement, ExpressionBuilder.ContextParameter, left, right);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (leftPointType != right.Type)
                    throw this.NewExpressionBuildingException();
                var precision = Precision(e.precision, e.precisionSpecified);
                return _operatorBinding.Bind(CqlOperator.IntervalProperlyIncludesElement, ExpressionBuilder.ContextParameter, left, right, precision);
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
                    return _operatorBinding.Bind(CqlOperator.Starts, ExpressionBuilder.ContextParameter, left, right, precision);

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
                    return _operatorBinding.Bind(CqlOperator.ListUnion, ExpressionBuilder.ContextParameter, left, right);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    return _operatorBinding.Bind(CqlOperator.IntervalUnion, ExpressionBuilder.ContextParameter, left, right);
                }
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression? Width(elm.Width e) =>
            UnaryOperator(CqlOperator.Width, e);

    }
}
