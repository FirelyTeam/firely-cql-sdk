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
        private Expression Collapse(Elm.Collapse e)
        {
            var operand = TranslateExpression(e.operand![0]!);
            if (IsOrImplementsIEnumerableOfT(operand.Type))
            {
                var elementType = _typeManager.Resolver.GetListElementType(operand.Type, @throw: true)!;
                if (IsInterval(elementType, out var pointType))
                {
                    var precision = Expression.Constant(null, typeof(string));
                    if (e.operand.Length > 1 && e.operand[1] is Elm.Quantity quant)
                    {
                        precision = Expression.Constant(quant.unit, typeof(string));
                    }
                    return _operatorBinding.Bind(CqlOperator.Collapse, LibraryDefinitionsBuilder.ContextParameter, operand, precision);
                }
            }
            throw new NotImplementedException().WithContext(this);
        }

        private Expression Contains(Elm.Contains e)
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
                var call = _operatorBinding.Bind(CqlOperator.ListContains, LibraryDefinitionsBuilder.ContextParameter, left, right);
                return call;
            }
            else if (IsInterval(left.Type, out var pointType))
            {
                var call = _operatorBinding.Bind(CqlOperator.IntervalContains, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);
                return call;
            }
            throw new NotImplementedException().WithContext(this);
        }

        private Expression End(Elm.End e) =>
            UnaryOperator(CqlOperator.IntervalEnd, e);

        private Expression? Ends(Elm.Ends e)
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
                    return _operatorBinding.Bind(CqlOperator.Ends, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);

                }
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression Except(Elm.Except e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (IsOrImplementsIEnumerableOfT(left.Type) && IsOrImplementsIEnumerableOfT(right.Type))
            {
                return _operatorBinding.Bind(CqlOperator.ListExcept, LibraryDefinitionsBuilder.ContextParameter, left, right);
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    return _operatorBinding.Bind(CqlOperator.IntervalExcept, LibraryDefinitionsBuilder.ContextParameter, left, right);

                }
                else throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression? Expand(Elm.Expand e)
        {
            var source = this.TranslateExpression(e!.operand![0]!);
            var quantity = this.TranslateExpression(e!.operand![1]!);
            return _operatorBinding.Bind(CqlOperator.Expand, LibraryDefinitionsBuilder.ContextParameter, source, quantity);
        }

        protected Expression In(Elm.In e)
        {
            var left = TranslateExpression(e.operand![0]!);
            var right = TranslateExpression(e.operand![1]!);
            if (IsOrImplementsIEnumerableOfT(right.Type))
            {
                return _operatorBinding.Bind(CqlOperator.InList, LibraryDefinitionsBuilder.ContextParameter, left, right);
            }
            else if (IsInterval(right.Type, out var rightElementType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);

                return _operatorBinding.Bind(CqlOperator.InInterval, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);

            }
            else throw new NotImplementedException().WithContext(this);
        }


        protected Expression? Includes(Elm.Includes e)
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
                    return _operatorBinding.Bind(CqlOperator.ListIncludesList, LibraryDefinitionsBuilder.ContextParameter, left, right);
                }
                else
                {
                    if (leftElementType != right.Type)
                        throw this.NewExpressionBuildingException();
                    return _operatorBinding.Bind(CqlOperator.ListIncludesElement, LibraryDefinitionsBuilder.ContextParameter, left, right);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var pointType))
                {
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return _operatorBinding.Bind(CqlOperator.IntervalIncludesInterval, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);
                }
                else
                {
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return _operatorBinding.Bind(CqlOperator.IntervalIncludesElement, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);
                }
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression IncludedIn(Elm.IncludedIn e)
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
                    return _operatorBinding.Bind(CqlOperator.ListIncludesList, LibraryDefinitionsBuilder.ContextParameter, right, left);
                }
                else
                {
                    if (leftElementType != right.Type)
                        throw this.NewExpressionBuildingException();
                    return _operatorBinding.Bind(CqlOperator.ListIncludesElement, LibraryDefinitionsBuilder.ContextParameter, right, left);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType) && IsInterval(right.Type, out var rightPointType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);
                return _operatorBinding.Bind(CqlOperator.IntervalIncludesInterval, LibraryDefinitionsBuilder.ContextParameter, right, left, precision);
            }
            else if (IsInterval(right.Type, out var pointType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);
                if (left.Type != pointType)
                    throw this.NewExpressionBuildingException();
                return _operatorBinding.Bind(CqlOperator.IntervalIncludesElement, LibraryDefinitionsBuilder.ContextParameter, right, left, precision);

            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression Intersect(Elm.Intersect e)
        {
            var left = TranslateExpression(e.operand![0]!);
            var right = TranslateExpression(e.operand![1]!);
            if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                return _operatorBinding.Bind(CqlOperator.ListIntersect, LibraryDefinitionsBuilder.ContextParameter, left, right);
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    return _operatorBinding.Bind(CqlOperator.IntervalIntersect, LibraryDefinitionsBuilder.ContextParameter, left, right);
                }
                else throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression? Meets(Elm.Meets e)
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
                    return _operatorBinding.Bind(CqlOperator.Meets, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);
                }
                else throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        private Expression? MeetsAfter(Elm.MeetsAfter e)
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
                    return _operatorBinding.Bind(CqlOperator.MeetsAfter, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);
                }
                else throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        private Expression? MeetsBefore(Elm.MeetsBefore e)
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
                    return _operatorBinding.Bind(CqlOperator.MeetsBefore, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);
                }
                else throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression Overlaps(Elm.Overlaps e)
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
                    return _operatorBinding.Bind(CqlOperator.Overlaps, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);
                }
                else throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        private Expression OverlapsBefore(Elm.OverlapsBefore e)
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
                    return _operatorBinding.Bind(CqlOperator.OverlapsBefore, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);
                }
                else throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        private Expression OverlapsAfter(Elm.OverlapsAfter e)
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
                    return _operatorBinding.Bind(CqlOperator.OverlapsAfter, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);
                }
                else throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }




        protected Expression? PointFrom(Elm.PointFrom e) =>
            UnaryOperator(CqlOperator.PointFrom, e);

        protected Expression? ProperIncludes(Elm.ProperIncludes e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (IsInterval(left.Type, out var leftPointType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);
                if (IsInterval(right.Type, out var rightPointType))
                {
                    return _operatorBinding.Bind(CqlOperator.IntervalProperlyIncludesInterval, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);
                }
                else
                {
                    return _operatorBinding.Bind(CqlOperator.IntervalProperlyIncludesElement, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);
                }
            }
            else if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                var leftElementType = _typeManager.Resolver.GetListElementType(left.Type);
                if (IsOrImplementsIEnumerableOfT(right.Type))
                {
                    var rightElementType = _typeManager.Resolver.GetListElementType(right.Type);
                    return _operatorBinding.Bind(CqlOperator.ListProperlyIncludesList, LibraryDefinitionsBuilder.ContextParameter, left, right);
                }
                else
                {
                    return _operatorBinding.Bind(CqlOperator.ListProperlyIncludesElement, LibraryDefinitionsBuilder.ContextParameter, left, right);
                }
            }
            throw new NotImplementedException().WithContext(this);
        }


        protected Expression? ProperIncludedIn(Elm.ProperIncludedIn e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return _operatorBinding.Bind(CqlOperator.IntervalProperlyIncludesInterval, LibraryDefinitionsBuilder.ContextParameter, right, left, precision);
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
                    return _operatorBinding.Bind(CqlOperator.ListProperlyIncludesList, LibraryDefinitionsBuilder.ContextParameter, right, left);
                }
            }
            else if (IsInterval(right.Type, out var rightPointType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);
                return _operatorBinding.Bind(CqlOperator.IntervalProperlyIncludesElement, LibraryDefinitionsBuilder.ContextParameter, right, left, precision);
            }
            throw new NotImplementedException().WithContext(this);
        }

        private Expression? ProperIn(Elm.ProperIn e)
        {
            var element = TranslateExpression(e.operand![0]);
            var intervalOrList = TranslateExpression(e.operand![1]);
            if (IsInterval(intervalOrList.Type, out var pointType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);
                return _operatorBinding.Bind(CqlOperator.IntervalProperlyIncludesElement, LibraryDefinitionsBuilder.ContextParameter, intervalOrList, element, precision);
            }
            else if (IsOrImplementsIEnumerableOfT(intervalOrList.Type))
            {
                return _operatorBinding.Bind(CqlOperator.ListProperlyIncludesElement, LibraryDefinitionsBuilder.ContextParameter, intervalOrList, element);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression? ProperContains(Elm.ProperContains e)
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
                    return _operatorBinding.Bind(CqlOperator.ListProperlyIncludesList, LibraryDefinitionsBuilder.ContextParameter, left, right);
                }
                else
                {
                    if (leftElementType != right.Type)
                        throw this.NewExpressionBuildingException();
                    return _operatorBinding.Bind(CqlOperator.ListProperlyIncludesElement, LibraryDefinitionsBuilder.ContextParameter, left, right);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (leftPointType != right.Type)
                    throw this.NewExpressionBuildingException();
                var precision = Precision(e.precision, e.precisionSpecified);
                return _operatorBinding.Bind(CqlOperator.IntervalProperlyIncludesElement, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);
            }
            throw new NotImplementedException().WithContext(this);
        }


        protected Expression Start(Elm.Start start) =>
            UnaryOperator(CqlOperator.IntervalStart, start);


        protected Expression? Starts(Elm.Starts e)
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
                    return _operatorBinding.Bind(CqlOperator.Starts, LibraryDefinitionsBuilder.ContextParameter, left, right, precision);

                }
            }
            throw new NotImplementedException().WithContext(this);
        }


        protected Expression Union(Elm.Union e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                var leftElementType = _typeManager.Resolver.GetListElementType(left.Type)!;
                if (IsOrImplementsIEnumerableOfT(right.Type))
                {
                    var rightElementType = _typeManager.Resolver.GetListElementType(right.Type)!;
                    if (leftElementType != rightElementType)
                        throw this.NewExpressionBuildingException($"Union requires both operands to be of the same type, " +
                                                                  $"but left is {leftElementType.Name} and right is {rightElementType.Name}.");
                    return _operatorBinding.Bind(CqlOperator.ListUnion, LibraryDefinitionsBuilder.ContextParameter, left, right);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    return _operatorBinding.Bind(CqlOperator.IntervalUnion, LibraryDefinitionsBuilder.ContextParameter, left, right);
                }
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression? Width(Elm.Width e) =>
            UnaryOperator(CqlOperator.Width, e);

    }
}
