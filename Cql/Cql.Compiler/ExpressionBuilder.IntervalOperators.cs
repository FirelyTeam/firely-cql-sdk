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
                    var precision = Expression.Constant(null, typeof(string));
                    if (e.operand.Length > 1 && e.operand[1] is Elm.Quantity quant)
                    {
                        precision = Expression.Constant(quant.unit, typeof(string));
                    }

                    Expression[] parameters = new[] { operand, precision };
                    return _operatorBinding.Bind(CqlOperator.Collapse, parameters);
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

                Expression[] parameters = new[] { left, right };
                var call = _operatorBinding.Bind(CqlOperator.ListContains, parameters);
                return call;
            }
            else if (IsInterval(left.Type, out var pointType))
            {
                Expression[] parameters = new[] { left, right, precision };
                var call = _operatorBinding.Bind(CqlOperator.IntervalContains, parameters);
                return call;
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
                    Expression[] parameters = new[] { left, right, precision };
                    return _operatorBinding.Bind(CqlOperator.Ends, parameters);

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
                Expression[] parameters = new[] { left, right };
                return _operatorBinding.Bind(CqlOperator.ListExcept, parameters);
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    Expression[] parameters = new[] { left, right };
                    return _operatorBinding.Bind(CqlOperator.IntervalExcept, parameters);

                }
                else throw new NotImplementedException().WithContext(this);
            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression? Expand(Elm.Expand e)
        {
            var source = this.TranslateExpression(e!.operand![0]!);
            var quantity = this.TranslateExpression(e!.operand![1]!);
            Expression[] parameters = new[] { source, quantity };
            return _operatorBinding.Bind(CqlOperator.Expand, parameters);
        }

        protected Expression In(Elm.In e)
        {
            var left = TranslateExpression(e.operand![0]!);
            var right = TranslateExpression(e.operand![1]!);
            if (_typeResolver.ImplementsGenericIEnumerable(right.Type))
            {
                Expression[] parameters = new[] { left, right };
                return _operatorBinding.Bind(CqlOperator.InList, parameters);
            }
            else if (IsInterval(right.Type, out var rightElementType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);

                Expression[] parameters = new[] { left, right, precision };
                return _operatorBinding.Bind(CqlOperator.InInterval, parameters);

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
                    Expression[] parameters = new[] { left, right };
                    return _operatorBinding.Bind(CqlOperator.ListIncludesList, parameters);
                }
                else
                {
                    if (leftElementType != right.Type)
                        throw this.NewExpressionBuildingException();
                    Expression[] parameters = new[] { left, right };
                    return _operatorBinding.Bind(CqlOperator.ListIncludesElement, parameters);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var pointType))
                {
                    var precision = Precision(e.precision, e.precisionSpecified);
                    Expression[] parameters = new[] { left, right, precision };
                    return _operatorBinding.Bind(CqlOperator.IntervalIncludesInterval, parameters);
                }
                else
                {
                    var precision = Precision(e.precision, e.precisionSpecified);
                    Expression[] parameters = new[] { left, right, precision };
                    return _operatorBinding.Bind(CqlOperator.IntervalIncludesElement, parameters);
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
                    Expression[] parameters = new[] { right, left };
                    return _operatorBinding.Bind(CqlOperator.ListIncludesList, parameters);
                }
                else
                {
                    if (leftElementType != right.Type)
                        throw this.NewExpressionBuildingException();
                    Expression[] parameters = new[] { right, left };
                    return _operatorBinding.Bind(CqlOperator.ListIncludesElement, parameters);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType) && IsInterval(right.Type, out var rightPointType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);
                Expression[] parameters = new[] { right, left, precision };
                return _operatorBinding.Bind(CqlOperator.IntervalIncludesInterval, parameters);
            }
            else if (IsInterval(right.Type, out var pointType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);
                if (left.Type != pointType)
                    throw this.NewExpressionBuildingException();
                Expression[] parameters = new[] { right, left, precision };
                return _operatorBinding.Bind(CqlOperator.IntervalIncludesElement, parameters);

            }
            throw new NotImplementedException().WithContext(this);
        }

        protected Expression Intersect(Elm.Intersect e)
        {
            var left = TranslateExpression(e.operand![0]!);
            var right = TranslateExpression(e.operand![1]!);
            if (_typeResolver.ImplementsGenericIEnumerable(left.Type))
            {
                Expression[] parameters = new[] { left, right };
                return _operatorBinding.Bind(CqlOperator.ListIntersect, parameters);
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    Expression[] parameters = new[] { left, right };
                    return _operatorBinding.Bind(CqlOperator.IntervalIntersect, parameters);
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
                    Expression[] parameters = new[] { left, right, precision };
                    return _operatorBinding.Bind(CqlOperator.Meets, parameters);
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
                    Expression[] parameters = new[] { left, right, precision };
                    return _operatorBinding.Bind(CqlOperator.MeetsAfter, parameters);
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
                    Expression[] parameters = new[] { left, right, precision };
                    return _operatorBinding.Bind(CqlOperator.MeetsBefore, parameters);
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
                    Expression[] parameters = new[] { left, right, precision };
                    return _operatorBinding.Bind(CqlOperator.Overlaps, parameters);
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
                    Expression[] parameters = new[] { left, right, precision };
                    return _operatorBinding.Bind(CqlOperator.OverlapsBefore, parameters);
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
                    Expression[] parameters = new[] { left, right, precision };
                    return _operatorBinding.Bind(CqlOperator.OverlapsAfter, parameters);
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
                    Expression[] parameters = new[] { left, right, precision };
                    return _operatorBinding.Bind(CqlOperator.IntervalProperlyIncludesInterval, parameters);
                }
                else
                {
                    Expression[] parameters = new[] { left, right, precision };
                    return _operatorBinding.Bind(CqlOperator.IntervalProperlyIncludesElement, parameters);
                }
            }
            else if (_typeResolver.ImplementsGenericIEnumerable(left.Type))
            {
                var leftElementType = _typeManager.Resolver.GetListElementType(left.Type);
                if (_typeResolver.ImplementsGenericIEnumerable(right.Type))
                {
                    var rightElementType = _typeManager.Resolver.GetListElementType(right.Type);
                    Expression[] parameters = new[] { left, right };
                    return _operatorBinding.Bind(CqlOperator.ListProperlyIncludesList, parameters);
                }
                else
                {
                    Expression[] parameters = new[] { left, right };
                    return _operatorBinding.Bind(CqlOperator.ListProperlyIncludesElement, parameters);
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
                    Expression[] parameters = new[] { right, left, precision };
                    return _operatorBinding.Bind(CqlOperator.IntervalProperlyIncludesInterval, parameters);
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
                    Expression[] parameters = new[] { right, left };
                    return _operatorBinding.Bind(CqlOperator.ListProperlyIncludesList, parameters);
                }
            }
            else if (IsInterval(right.Type, out var rightPointType))
            {
                var precision = Precision(e.precision, e.precisionSpecified);
                Expression[] parameters = new[] { right, left, precision };
                return _operatorBinding.Bind(CqlOperator.IntervalProperlyIncludesElement, parameters);
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
                Expression[] parameters = new[] { intervalOrList, element, precision };
                return _operatorBinding.Bind(CqlOperator.IntervalProperlyIncludesElement, parameters);
            }
            else if (_typeResolver.ImplementsGenericIEnumerable(intervalOrList.Type))
            {
                Expression[] parameters = new[] { intervalOrList, element };
                return _operatorBinding.Bind(CqlOperator.ListProperlyIncludesElement, parameters);
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
                    Expression[] parameters = new[] { left, right };
                    return _operatorBinding.Bind(CqlOperator.ListProperlyIncludesList, parameters);
                }
                else
                {
                    if (leftElementType != right.Type)
                        throw this.NewExpressionBuildingException();
                    Expression[] parameters = new[] { left, right };
                    return _operatorBinding.Bind(CqlOperator.ListProperlyIncludesElement, parameters);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (leftPointType != right.Type)
                    throw this.NewExpressionBuildingException();
                var precision = Precision(e.precision, e.precisionSpecified);
                Expression[] parameters = new[] { left, right, precision };
                return _operatorBinding.Bind(CqlOperator.IntervalProperlyIncludesElement, parameters);
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
                    Expression[] parameters = new[] { left, right, precision };
                    return _operatorBinding.Bind(CqlOperator.Starts, parameters);

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
                    Expression[] parameters = new[] { left, right };
                    return _operatorBinding.Bind(CqlOperator.ListUnion, parameters);
                }
            }
            else if (IsInterval(left.Type, out var leftPointType))
            {
                if (IsInterval(right.Type, out var rightPointType))
                {
                    if (leftPointType != rightPointType)
                        throw this.NewExpressionBuildingException();
                    Expression[] parameters = new[] { left, right };
                    return _operatorBinding.Bind(CqlOperator.IntervalUnion, parameters);
                }
            }
            throw new NotImplementedException().WithContext(this);
        }
    }
}
