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
            if (_typeResolver.ImplementsGenericIEnumerable(operand.Type))
            {
                var elementType = _typeManager.Resolver.GetListElementType(operand.Type, throwError: true)!;
                if (IsInterval(elementType, out var pointType))
                {
                    var precision = CqlExpressions.Null_ConstantExpression<string>();
                    if (e.operand.Length > 1 && e.operand[1] is Elm.Quantity quant)
                    {
                        precision = Expression.Constant(quant.unit, typeof(string));
                    }

                    return _operatorBinding.BindToMethod(CqlOperator.Collapse, operand, precision);
                }
            }
            throw new NotImplementedException().WithContext(this);
        }

        private Expression Contains(Elm.Contains e)
        {
            var left = TranslateExpression(e!.operand![0]!);
            var right = TranslateExpression(e.operand[1]!);
            var precision = Precision(e.precision, e.precisionSpecified);
            if (_typeResolver.ImplementsGenericIEnumerable(left.Type))
            {
                var elementType = _typeManager.Resolver.GetListElementType(left.Type, throwError: true)!;
                if (elementType != right.Type)
                {
                    if (elementType.IsAssignableFrom(right.Type))
                    {
                        right = ChangeType(right, elementType);
                    }
                    else throw this.NewExpressionBuildingException($"Cannot convert Contains target {TypeManager.PrettyTypeName(right.Type)} to {TypeManager.PrettyTypeName(elementType)}");
                }

                return _operatorBinding.BindToMethod(CqlOperator.ListContains, left, right);
            }
            else if (IsInterval(left.Type, out var pointType))
            {
                return _operatorBinding.BindToMethod(CqlOperator.IntervalContains, left, right, precision);
            }
            throw new NotImplementedException().WithContext(this);
        }

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
                    return _operatorBinding.BindToMethod(CqlOperator.Ends, left, right, precision);

                }
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression Except(Elm.Except e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (_typeResolver.ImplementsGenericIEnumerable(left.Type) && _typeResolver.ImplementsGenericIEnumerable(right.Type))
            {
                return _operatorBinding.BindToMethod(CqlOperator.ListExcept, left, right);
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    return _operatorBinding.BindToMethod(CqlOperator.IntervalExcept, left, right);

                }
                else throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression In(Elm.In e)
        {
            var left = TranslateExpression(e.operand![0]!);
            var right = TranslateExpression(e.operand![1]!);
            if (_typeResolver.ImplementsGenericIEnumerable(right.Type))
            {
                return _operatorBinding.BindToMethod(CqlOperator.InList, left, right);
            }
            else if (IsInterval(right.Type, out var rightElementType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);

                return _operatorBinding.BindToMethod(CqlOperator.InInterval, left, right, precision);

            }
            else throw new NotImplementedException().WithContext(this);
        }


        protected Expression? Includes(Elm.Includes e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (_typeResolver.ImplementsGenericIEnumerable(left.Type))
            {
                var leftElementType = _typeManager.Resolver.GetListElementType(left.Type);
                if (_typeResolver.ImplementsGenericIEnumerable(right.Type))
                {
                    var rightElementType = _typeManager.Resolver.GetListElementType(left.Type);
                    if (leftElementType != rightElementType)
                        throw this.NewExpressionBuildingException();
                    return _operatorBinding.BindToMethod(CqlOperator.ListIncludesList, left, right);
                }
                else
                {
                    if (leftElementType != right.Type)
                        throw this.NewExpressionBuildingException();
                    return _operatorBinding.BindToMethod(CqlOperator.ListIncludesElement, left, right);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var pointType))
                {
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return _operatorBinding.BindToMethod(CqlOperator.IntervalIncludesInterval, left, right, precision);
                }
                else
                {
                    var precision = Precision(e.precision, e.precisionSpecified);
                    return _operatorBinding.BindToMethod(CqlOperator.IntervalIncludesElement, left, right, precision);
                }
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression IncludedIn(Elm.IncludedIn e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (_typeResolver.ImplementsGenericIEnumerable(left.Type))
            {
                var leftElementType = _typeManager.Resolver.GetListElementType(left.Type);
                if (_typeResolver.ImplementsGenericIEnumerable(right.Type))
                {
                    var rightElementType = _typeManager.Resolver.GetListElementType(left.Type);
                    if (leftElementType != rightElementType)
                        throw this.NewExpressionBuildingException();
                    return _operatorBinding.BindToMethod(CqlOperator.ListIncludesList, right, left);
                }
                else
                {
                    if (leftElementType != right.Type)
                        throw this.NewExpressionBuildingException();
                    return _operatorBinding.BindToMethod(CqlOperator.ListIncludesElement, right, left);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType) && IsInterval(right.Type, out var rightPointType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);
                return _operatorBinding.BindToMethod(CqlOperator.IntervalIncludesInterval, right, left, precision);
            }
            else if (IsInterval(right.Type, out var pointType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);
                if (left.Type != pointType)
                    throw this.NewExpressionBuildingException();
                return _operatorBinding.BindToMethod(CqlOperator.IntervalIncludesElement, right, left, precision);

            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression Intersect(Elm.Intersect e)
        {
            var left = TranslateExpression(e.operand![0]!);
            var right = TranslateExpression(e.operand![1]!);
            if (_typeResolver.ImplementsGenericIEnumerable(left.Type))
            {
                return _operatorBinding.BindToMethod(CqlOperator.ListIntersect, left, right);
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    return _operatorBinding.BindToMethod(CqlOperator.IntervalIntersect, left, right);
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
                    return _operatorBinding.BindToMethod(CqlOperator.Meets, left, right, precision);
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
                    return _operatorBinding.BindToMethod(CqlOperator.MeetsAfter, left, right, precision);
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
                    return _operatorBinding.BindToMethod(CqlOperator.MeetsBefore, left, right, precision);
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
                    return _operatorBinding.BindToMethod(CqlOperator.Overlaps, left, right, precision);
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
                    return _operatorBinding.BindToMethod(CqlOperator.OverlapsBefore, left, right, precision);
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
                    return _operatorBinding.BindToMethod(CqlOperator.OverlapsAfter, left, right, precision);
                }
                else throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression? ProperIncludes(Elm.ProperIncludes e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (IsInterval(left.Type, out var leftPointType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);
                if (IsInterval(right.Type, out var rightPointType))
                {
                    return _operatorBinding.BindToMethod(CqlOperator.IntervalProperlyIncludesInterval, left, right, precision);
                }
                else
                {
                    return _operatorBinding.BindToMethod(CqlOperator.IntervalProperlyIncludesElement, left, right, precision);
                }
            }
            else if (_typeResolver.ImplementsGenericIEnumerable(left.Type))
            {
                // var leftElementType = _typeManager.Resolver.GetListElementType(left.Type);
                if (_typeResolver.ImplementsGenericIEnumerable(right.Type))
                {
                    // var rightElementType = _typeManager.Resolver.GetListElementType(right.Type);
                    return _operatorBinding.BindToMethod(CqlOperator.ListProperlyIncludesList, left, right);
                }
                else
                {
                    return _operatorBinding.BindToMethod(CqlOperator.ListProperlyIncludesElement, left, right);
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
                    return _operatorBinding.BindToMethod(CqlOperator.IntervalProperlyIncludesInterval, right, left, precision);
                }
            }
            else if (_typeResolver.ImplementsGenericIEnumerable(left.Type))
            {
                var leftElementType = _typeManager.Resolver.GetListElementType(left.Type);
                if (_typeResolver.ImplementsGenericIEnumerable(right.Type))
                {
                    var rightElementType = _typeManager.Resolver.GetListElementType(right.Type);
                    if (leftElementType != rightElementType)
                        throw this.NewExpressionBuildingException();
                    return _operatorBinding.BindToMethod(CqlOperator.ListProperlyIncludesList, right, left);
                }
            }
            else if (IsInterval(right.Type, out var rightPointType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);
                return _operatorBinding.BindToMethod(CqlOperator.IntervalProperlyIncludesElement, right, left, precision);
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
                return _operatorBinding.BindToMethod(CqlOperator.IntervalProperlyIncludesElement, intervalOrList, element, precision);
            }
            else if (_typeResolver.ImplementsGenericIEnumerable(intervalOrList.Type))
            {
                return _operatorBinding.BindToMethod(CqlOperator.ListProperlyIncludesElement, intervalOrList, element);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression? ProperContains(Elm.ProperContains e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (_typeResolver.ImplementsGenericIEnumerable(left.Type))
            {
                var leftElementType = _typeManager.Resolver.GetListElementType(left.Type);
                if (_typeResolver.ImplementsGenericIEnumerable(right.Type))
                {
                    var rightElementType = _typeManager.Resolver.GetListElementType(right.Type);
                    if (leftElementType != rightElementType)
                        throw this.NewExpressionBuildingException();
                    return _operatorBinding.BindToMethod(CqlOperator.ListProperlyIncludesList, left, right);
                }
                else
                {
                    if (leftElementType != right.Type)
                        throw this.NewExpressionBuildingException();
                    return _operatorBinding.BindToMethod(CqlOperator.ListProperlyIncludesElement, left, right);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (leftPointType != right.Type)
                    throw this.NewExpressionBuildingException();
                var precision = Precision(e.precision, e.precisionSpecified);
                return _operatorBinding.BindToMethod(CqlOperator.IntervalProperlyIncludesElement, left, right, precision);
            }
            throw new NotImplementedException().WithContext(this);
        }

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
                    return _operatorBinding.BindToMethod(CqlOperator.Starts, left, right, precision);

                }
            }
            throw new NotImplementedException().WithContext(this);
        }


        protected Expression Union(Elm.Union e)
        {
            var left = TranslateExpression(e.operand![0]);
            var right = TranslateExpression(e.operand![1]);
            if (_typeResolver.ImplementsGenericIEnumerable(left.Type))
            {
                var leftElementType = _typeManager.Resolver.GetListElementType(left.Type)!;
                if (_typeResolver.ImplementsGenericIEnumerable(right.Type))
                {
                    var rightElementType = _typeManager.Resolver.GetListElementType(right.Type)!;
                    if (leftElementType != rightElementType)
                        throw this.NewExpressionBuildingException($"Union requires both operands to be of the same type, " +
                                                                  $"but left is {leftElementType.Name} and right is {rightElementType.Name}.");
                    return _operatorBinding.BindToMethod(CqlOperator.ListUnion, left, right);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    return _operatorBinding.BindToMethod(CqlOperator.IntervalUnion, left, right);
                }
            }
            throw new NotImplementedException().WithContext(this);
        }
    }
}
