#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler.Expressions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {
        protected Expression As(Elm.As @as)
        {
            if (@as.operand is Elm.List list)
            {
                using (PushElement(list))
                {
                    // create new ListType[0]; instead of new object[0] as IEnumerable<object> as IEnumerable<ListType>;
                    if ((list.element?.Length ?? 0) == 0)
                    {
                        var type = TypeFor(@as.asTypeSpecifier!);
                        if (_typeResolver.ImplementsGenericIEnumerable(type))
                        {
                            var listElementType = _typeManager.Resolver.GetListElementType(type) ?? throw this.NewExpressionBuildingException($"{type} was expected to be a list type.");
                            var newArray = Expression.NewArrayBounds(listElementType, Expression.Constant(0));
                            var elmAs = new ElmAsExpression(newArray, type);
                            return elmAs;
                        }
                        else
                        {
                            throw this.NewExpressionBuildingException("Cannot use as operator on a list if the as type is not also a list type.");
                        }
                    }
                }
            }

            // asTypeSpecifier is an expression with its own resulttypespecifier that actually contains the real type
            if (@as.asTypeSpecifier != null)
            {
                using (PushElement(@as.asTypeSpecifier))
                {
                    if (@as.operand is Elm.Null)
                    {
                        var type = TypeFor(@as.asTypeSpecifier!);
                        var defaultExpression = Expression.Default(type);
                        return new ElmAsExpression(defaultExpression, type);
                    }
                    else
                    {
                        var type = TypeFor(@as.asTypeSpecifier!);
                        var operand = TranslateExpression(@as.operand!);
                        return new ElmAsExpression(operand, type);
                    }
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(@as.asType.Name))
                    throw this.NewExpressionBuildingException("The 'as' operator has no type name.");

                if (@as.operand is null)
                    throw this.NewExpressionBuildingException("Operand cannot be null");

                var type = _typeManager.Resolver.ResolveType(@as.asType.Name!)
                    ?? throw this.NewExpressionBuildingException($"Cannot resolve type {@as.asType.Name}");

                var operand = TranslateExpression(@as.operand);
                if (!type.IsAssignableTo(operand.Type))
                {
                    _logger.LogWarning(FormatMessage($"Potentially unsafe cast from {TypeManager.PrettyTypeName(operand.Type)} to type {TypeManager.PrettyTypeName(type)}", @as.operand));
                }

                return new ElmAsExpression(operand, type);
            }
        }

        protected Expression Is(Elm.Is @is)
        {
            var op = TranslateExpression(@is.operand!);
            Type? type = null;
            if (@is.isTypeSpecifier != null)
            {
                if (@is.isTypeSpecifier is Elm.ChoiceTypeSpecifier choice)
                {
                    var firstChoiceType = TypeFor(choice.choice[0]) ?? throw this.NewExpressionBuildingException($"Could not resolve type for Is expression");
                    Expression result = Expression.TypeIs(op, firstChoiceType);
                    for (int i = 1; i < choice.choice.Length; i++)
                    {
                        var cti = TypeFor(choice.choice[i]) ?? throw this.NewExpressionBuildingException($"Could not resolve type for Is expression");
                        var ie = Expression.TypeIs(op, cti);
                        result = Expression.Or(result, ie);
                    }
                    var ta = Expression.TypeAs(result, typeof(bool?));
                    return ta;
                }

                type = TypeFor(@is.isTypeSpecifier) ?? throw this.NewExpressionBuildingException($"Could not resolve type for Is expression");
            }
            else if (!string.IsNullOrWhiteSpace(@is.isType?.Name))
            {
                type = _typeManager.Resolver.ResolveType(@is.isType.Name) ?? throw this.NewExpressionBuildingException($"Could not resolve type {@is.isType.Name}");
            }

            if (type == null)
                throw this.NewExpressionBuildingException($"Could not identify Is type specifer via {nameof(@is.isTypeSpecifier)} or {nameof(@is.isType)}.");

            var isExpression = Expression.TypeIs(op, type);
            var nullable = Expression.TypeAs(isExpression, typeof(bool?));
            return nullable;
        }

        private Expression? Descendents(Elm.Descendents e)
        {
            if (e.source == null)
                return Expression.Constant(null, typeof(IEnumerable<object>));
            else
            {
                var source = TranslateExpression(e.source);
                Expression[] parameters = new[] { source };
                var call = _operatorBinding.BindToMethod(CqlOperator.Descendents, parameters);
                return call;
            }
        }

        /// <summary>
        /// Changes units on a quantity.
        /// e.g.
        /// convert FHIRHelpers.ToQuantity ( First.ConceptionQuantity ) to weeks
        /// </summary>
        /// <param name="cqe"></param>
        /// <returns></returns>
        protected Expression ConvertQuantity(Elm.ConvertQuantity cqe)
        {
            var quantity = TranslateExpression(cqe.operand![0]);
            var unit = TranslateExpression(cqe.operand![1]);
            Expression[] parameters = new[] { quantity, unit };
            var call = _operatorBinding.BindToMethod(CqlOperator.ConvertQuantity, parameters);
            return call;
        }

        protected Expression? ChangeTypeToBoolean(Elm.ToBoolean e)
        {
            var operand = TranslateExpression(e.operand!);
            return ChangeType(operand, typeof(bool?));
        }

        protected Expression? ChangeTypeToConcept(Elm.ToConcept e)
        {
            var operand = TranslateExpression(e.operand!);
            return ChangeType(operand, _typeManager.Resolver.ConceptType);
        }

        protected Expression? ChangeTypeToDate(Elm.ToDate e)
        {
            var operand = TranslateExpression(e.operand!);
            return ChangeType(operand, _typeManager.Resolver.DateType);
        }

        protected Expression ChangeTypeToDateTime(Elm.ToDateTime e)
        {
            var operand = TranslateExpression(e.operand!);
            return ChangeType(operand, _typeManager.Resolver.DateTimeType);
        }


        protected Expression ChangeTypeToDecimal(Elm.ToDecimal e)
        {
            var operand = TranslateExpression(e.operand!);
            return ChangeType(operand, typeof(decimal?));
        }

        protected Expression ChangeTypeToLong(Elm.ToLong e)
        {
            var operand = TranslateExpression(e.operand!);
            return ChangeType(operand, typeof(long?));
        }

        protected Expression? ChangeTypeToInteger(Elm.ToInteger e)
        {
            var operand = TranslateExpression(e.operand!);
            return ChangeType(operand, typeof(int?));
        }

        protected Expression? ChangeTypeToQuantity(Elm.ToQuantity tq)
        {
            var operand = TranslateExpression(tq.operand!);
            return ChangeType(operand, _typeManager.Resolver.QuantityType);
        }

        protected Expression? ChangeTypeToString(Elm.ToString e)
        {
            var operand = TranslateExpression(e.operand!);
            return ChangeType(operand, typeof(string));
        }
        protected Expression? ChangeTypeToTime(Elm.ToTime e)
        {
            var operand = TranslateExpression(e.operand!);
            return ChangeType(operand, _typeManager.Resolver.TimeType);
        }

        protected Expression ChangeTypeToList(Elm.ToList e)
        {
            var operand = TranslateExpression(e.operand!);
            Expression[] parameters = new[] { operand };
            var call = _operatorBinding.BindToMethod(CqlOperator.ToList, parameters);
            return call;
        }

        private Expression ChangeType(Expression input, Type outputType)
        {
            if (input.Type == outputType)
                return input;

            if (input.Type == typeof(object) || outputType.IsAssignableFrom(input.Type))
                return Expression.TypeAs(input, outputType);

            if (_typeResolver.ImplementsGenericIEnumerable(input.Type)
                && _typeResolver.ImplementsGenericIEnumerable(outputType))
            {
                var inputElementType = _typeManager.Resolver.GetListElementType(input.Type, true)!;
                var outputElementType = _typeManager.Resolver.GetListElementType(outputType, true)!;
                var lambdaParameter = Expression.Parameter(inputElementType, TypeNameToIdentifier(inputElementType, this));
                var lambdaBody = ChangeType(lambdaParameter, outputElementType);
                var lambda = Expression.Lambda(lambdaBody, lambdaParameter);
                Expression[] parameters = new[] { input, lambda };
                var callSelect = _operatorBinding.BindToMethod(CqlOperator.Select, parameters);
                return callSelect;
            }

            if(TryCorrectQiCoreBindingError(input.Type, outputType, out var correctedTo))
            {
                Expression[] parameters = new[] { input, Expression.Constant(correctedTo, typeof(Type)) };
                var call = _operatorBinding.BindToMethod(CqlOperator.Convert, parameters);
                return call;
            }
            else
            {
                Expression[] parameters = new[] { input, Expression.Constant(outputType, typeof(Type)) };
                var call = _operatorBinding.BindToMethod(CqlOperator.Convert, parameters);
                return call;
            }
        }
    }
}
