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
using Hl7.Cql.Compiler.Infrastructure;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {
        private Expression Collapse(Elm.Collapse e)
        {
            var operand = TranslateExpression(e.operand![0]!);
            if (_typeResolver.IsListType(operand.Type))
            {
                var elementType = _typeResolver.GetListElementType(operand.Type, throwError: true)!;
                if (elementType.IsCqlInterval(out var pointType))
                {
                    var precision = NullConstantExpression.String;
                    if (e.operand.Length > 1 && e.operand[1] is Elm.Quantity quant)
                    {
                        precision = Expression.Constant(quant.unit, typeof(string));
                    }

                    return _operatorsBinder.BindToMethod(CqlOperator.Collapse, operand, precision);
                }
            }
            throw new NotImplementedException().WithContext(this);
        }

        private Expression Contains(Elm.Contains e)
        {
            var left = TranslateExpression(e!.operand![0]!);
            var right = TranslateExpression(e.operand[1]!);
            var precision = Precision(e);
            if (_typeResolver.IsListType(left.Type))
            {
                var elementType = _typeResolver.GetListElementType(left.Type, throwError: true)!;
                if (elementType != right.Type)
                {
                    if (elementType.IsAssignableFrom(right.Type))
                    {
                        right = ChangeType(right, elementType);
                    }
                    else throw this.NewExpressionBuildingException($"Cannot convert Contains target {TypeManager.PrettyTypeName(right.Type)} to {TypeManager.PrettyTypeName(elementType)}");
                }

                return _operatorsBinder.BindToMethod(CqlOperator.ListContains, left, right);
            }

            if (left.Type.IsCqlInterval(out var pointType))
            {
                return _operatorsBinder.BindToMethod(CqlOperator.IntervalContains, left, right, precision);
            }
            throw new NotImplementedException().WithContext(this);
        }

        private Expression? Ends(Elm.Ends e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            var precision = Precision(e);
            if (left.Type.IsCqlInterval(out var leftPointType))
            {
                if (right.Type.IsCqlInterval(out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    return _operatorsBinder.BindToMethod(CqlOperator.Ends, left, right, precision);

                }
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression Except(Elm.Except e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (_typeResolver.IsListType(left.Type) && _typeResolver.IsListType(right.Type))
            {
                return _operatorsBinder.BindToMethod(CqlOperator.ListExcept, left, right);
            }

            if (left.Type.IsCqlInterval(out var leftPointType))
            {
                if (right.Type.IsCqlInterval(out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    return _operatorsBinder.BindToMethod(CqlOperator.IntervalExcept, left, right);

                }

                throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression In(Elm.In e)
        {
            var left = TranslateExpression(e.operand![0]!);
            var right = TranslateExpression(e.operand![1]!);
            if (_typeResolver.IsListType(right.Type))
            {
                return _operatorsBinder.BindToMethod(CqlOperator.InList, left, right);
            }

            if (right.Type.IsCqlInterval(out var rightElementType))
            {
                var precision = Precision(e);

                return _operatorsBinder.BindToMethod(CqlOperator.InInterval, left, right, precision);

            }
            throw new NotImplementedException().WithContext(this);
        }


        protected Expression? Includes(Elm.Includes e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (_typeResolver.IsListType(left.Type))
            {
                var leftElementType = _typeResolver.GetListElementType(left.Type);
                if (_typeResolver.IsListType(right.Type))
                {
                    var rightElementType = _typeResolver.GetListElementType(left.Type);
                    if (leftElementType != rightElementType)
                        throw this.NewExpressionBuildingException();
                    return _operatorsBinder.BindToMethod(CqlOperator.ListIncludesList, left, right);
                }

                if (leftElementType != right.Type)
                    throw this.NewExpressionBuildingException();
                return _operatorsBinder.BindToMethod(CqlOperator.ListIncludesElement, left, right);
            }

            if (left.Type.IsCqlInterval(out var leftPointType))
            {
                if (right.Type.IsCqlInterval(out var pointType))
                {
                    var precision = Precision(e);
                    return _operatorsBinder.BindToMethod(CqlOperator.IntervalIncludesInterval, left, right, precision);
                }
                else
                {
                    var precision = Precision(e);
                    return _operatorsBinder.BindToMethod(CqlOperator.IntervalIncludesElement, left, right, precision);
                }
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression IncludedIn(Elm.IncludedIn e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (_typeResolver.IsListType(left.Type))
            {
                var leftElementType = _typeResolver.GetListElementType(left.Type);
                if (_typeResolver.IsListType(right.Type))
                {
                    var rightElementType = _typeResolver.GetListElementType(left.Type);
                    if (leftElementType != rightElementType)
                        throw this.NewExpressionBuildingException();
                    return _operatorsBinder.BindToMethod(CqlOperator.ListIncludesList, right, left);
                }

                if (leftElementType != right.Type)
                    throw this.NewExpressionBuildingException();
                return _operatorsBinder.BindToMethod(CqlOperator.ListIncludesElement, right, left);
            }

            if (left.Type.IsCqlInterval(out var leftPointType) && right.Type.IsCqlInterval(out var rightPointType))
            {
                var precision = Precision(e);
                return _operatorsBinder.BindToMethod(CqlOperator.IntervalIncludesInterval, right, left, precision);
            }
            if (right.Type.IsCqlInterval(out var pointType))
            {
                var precision = Precision(e);
                if (left.Type != pointType)
                    throw this.NewExpressionBuildingException();
                return _operatorsBinder.BindToMethod(CqlOperator.IntervalIncludesElement, right, left, precision);

            }

            throw new NotImplementedException().WithContext(this);
        }

        protected Expression Intersect(Elm.Intersect e)
        {
            var left = TranslateExpression(e.operand![0]!);
            var right = TranslateExpression(e.operand![1]!);
            if (_typeResolver.IsListType(left.Type))
            {
                return _operatorsBinder.BindToMethod(CqlOperator.ListIntersect, left, right);
            }

            if (left.Type.IsCqlInterval(out var leftPointType))
            {
                if (right.Type.IsCqlInterval(out var rightPointType))
                {
                    return _operatorsBinder.BindToMethod(CqlOperator.IntervalIntersect, left, right);
                }

                throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression? Meets(Elm.Meets e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (left.Type.IsCqlInterval(out var leftPointType))
            {
                if (right.Type.IsCqlInterval(out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    var precision = Precision(e);
                    return _operatorsBinder.BindToMethod(CqlOperator.Meets, left, right, precision);
                }

                throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        private Expression? MeetsAfter(Elm.MeetsAfter e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (left.Type.IsCqlInterval(out var leftPointType))
            {
                if (right.Type.IsCqlInterval(out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    var precision = Precision(e);
                    return _operatorsBinder.BindToMethod(CqlOperator.MeetsAfter, left, right, precision);
                }

                throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        private Expression? MeetsBefore(Elm.MeetsBefore e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (left.Type.IsCqlInterval(out var leftPointType))
            {
                if (right.Type.IsCqlInterval(out var rightPointType))
                {

                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    var precision = Precision(e);
                    return _operatorsBinder.BindToMethod(CqlOperator.MeetsBefore, left, right, precision);
                }

                throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression Overlaps(Elm.Overlaps e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (left.Type.IsCqlInterval(out var leftPointType))
            {
                if (right.Type.IsCqlInterval(out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    var precision = Precision(e);
                    return _operatorsBinder.BindToMethod(CqlOperator.Overlaps, left, right, precision);
                }

                throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        private Expression OverlapsBefore(Elm.OverlapsBefore e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (left.Type.IsCqlInterval(out var leftPointType))
            {
                if (right.Type.IsCqlInterval(out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    var precision = Precision(e);
                    return _operatorsBinder.BindToMethod(CqlOperator.OverlapsBefore, left, right, precision);
                }

                throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        private Expression OverlapsAfter(Elm.OverlapsAfter e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (left.Type.IsCqlInterval(out var leftPointType))
            {
                if (right.Type.IsCqlInterval(out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    var precision = Precision(e);
                    return _operatorsBinder.BindToMethod(CqlOperator.OverlapsAfter, left, right, precision);
                }

                throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression? ProperIncludes(Elm.ProperIncludes e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (left.Type.IsCqlInterval(out var leftPointType))
            {
                var precision = Precision(e);
                if (right.Type.IsCqlInterval(out var rightPointType))
                {
                    return _operatorsBinder.BindToMethod(CqlOperator.IntervalProperlyIncludesInterval, left, right, precision);
                }

                return _operatorsBinder.BindToMethod(CqlOperator.IntervalProperlyIncludesElement, left, right, precision);
            }

            if (_typeResolver.IsListType(left.Type))
            {
                // var leftElementType = _typeResolver.GetListElementType(left.Type);
                if (_typeResolver.IsListType(right.Type))
                {
                    // var rightElementType = _typeResolver.GetListElementType(right.Type);
                    return _operatorsBinder.BindToMethod(CqlOperator.ListProperlyIncludesList, left, right);
                }

                return _operatorsBinder.BindToMethod(CqlOperator.ListProperlyIncludesElement, left, right);
            }
            throw new NotImplementedException().WithContext(this);
        }


        protected Expression? ProperIncludedIn(Elm.ProperIncludedIn e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (left.Type.IsCqlInterval(out var leftPointType))
            {
                if (right.Type.IsCqlInterval(out var rightPointType))
                {
                    var precision = Precision(e);
                    return _operatorsBinder.BindToMethod(CqlOperator.IntervalProperlyIncludesInterval, right, left, precision);
                }
            }
            else if (_typeResolver.IsListType(left.Type))
            {
                var leftElementType = _typeResolver.GetListElementType(left.Type);
                if (_typeResolver.IsListType(right.Type))
                {
                    var rightElementType = _typeResolver.GetListElementType(right.Type);
                    if (leftElementType != rightElementType)
                        throw this.NewExpressionBuildingException();
                    return _operatorsBinder.BindToMethod(CqlOperator.ListProperlyIncludesList, right, left);
                }
            }
            else if (right.Type.IsCqlInterval(out var rightPointType))
            {
                var precision = Precision(e);
                return _operatorsBinder.BindToMethod(CqlOperator.IntervalProperlyIncludesElement, right, left, precision);
            }
            throw new NotImplementedException().WithContext(this);
        }

        private Expression? ProperIn(Elm.ProperIn e)
        {
            var element = TranslateExpression(e.operand![0]);
            var intervalOrList = TranslateExpression(e.operand![1]);
            if (intervalOrList.Type.IsCqlInterval(out var pointType))
            {
                var precision = Precision(e);
                return _operatorsBinder.BindToMethod(CqlOperator.IntervalProperlyIncludesElement, intervalOrList, element, precision);
            }

            if (_typeResolver.IsListType(intervalOrList.Type))
            {
                return _operatorsBinder.BindToMethod(CqlOperator.ListProperlyIncludesElement, intervalOrList, element);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression? ProperContains(Elm.ProperContains e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (_typeResolver.IsListType(left.Type))
            {
                var leftElementType = _typeResolver.GetListElementType(left.Type);
                if (_typeResolver.IsListType(right.Type))
                {
                    var rightElementType = _typeResolver.GetListElementType(right.Type);
                    if (leftElementType != rightElementType)
                        throw this.NewExpressionBuildingException();
                    return _operatorsBinder.BindToMethod(CqlOperator.ListProperlyIncludesList, left, right);
                }

                if (leftElementType != right.Type)
                    throw this.NewExpressionBuildingException();
                return _operatorsBinder.BindToMethod(CqlOperator.ListProperlyIncludesElement, left, right);
            }

            if (left.Type.IsCqlInterval(out var leftPointType))
            {
                if (leftPointType != right.Type)
                    throw this.NewExpressionBuildingException();
                var precision = Precision(e);
                return _operatorsBinder.BindToMethod(CqlOperator.IntervalProperlyIncludesElement, left, right, precision);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression? Starts(Elm.Starts e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (left.Type.IsCqlInterval(out var leftPointType))
            {
                if (right.Type.IsCqlInterval(out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    var precision = Precision(e);
                    return _operatorsBinder.BindToMethod(CqlOperator.Starts, left, right, precision);

                }
            }
            throw new NotImplementedException().WithContext(this);
        }


        protected Expression Union(Elm.Union e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (_typeResolver.IsListType(left.Type))
            {
                var leftElementType = _typeResolver.GetListElementType(left.Type)!;
                if (_typeResolver.IsListType(right.Type))
                {
                    var rightElementType = _typeResolver.GetListElementType(right.Type)!;
                    if (leftElementType != rightElementType)
                        throw this.NewExpressionBuildingException($"Union requires both operands to be of the same type, " +
                                                                  $"but left is {leftElementType.Name} and right is {rightElementType.Name}.");
                    return _operatorsBinder.BindToMethod(CqlOperator.ListUnion, left, right);
                }
            }
            else if (left.Type.IsCqlInterval(out var leftPointType))
            {
                if (right.Type.IsCqlInterval(out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    return _operatorsBinder.BindToMethod(CqlOperator.IntervalUnion, left, right);
                }
            }
            throw new NotImplementedException().WithContext(this);
        }
    }
}
