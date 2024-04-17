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
using Hl7.Cql.Elm;
using Microsoft.Extensions.Logging;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {
        protected Expression As(Elm.As @as) // @TODO: Cast
        {
            if (@as.operand is Elm.List list)
            {
                using (PushElement(list))
                {
                    // create new ListType[0]; instead of new object[0] as IEnumerable<object> as IEnumerable<ListType>;
                    if ((list.element?.Length ?? 0) == 0)
                    {
                        var type = TypeFor(@as.asTypeSpecifier!);
                        if (_typeResolver.IsListType(type))
                        {
                            var listElementType = _typeResolver.GetListElementType(type) ?? throw this.NewExpressionBuildingException($"{type} was expected to be a list type.");
                            var newArray = Expression.NewArrayBounds(listElementType, Expression.Constant(0));
                            var elmAs = new ElmAsExpression(newArray, type);
                            return elmAs;
                        }

                        throw this.NewExpressionBuildingException("Cannot use as operator on a list if the as type is not also a list type.");
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

            {
                if (string.IsNullOrWhiteSpace(@as.asType.Name))
                    throw this.NewExpressionBuildingException("The 'as' operator has no type name.");

                if (@as.operand is null)
                    throw this.NewExpressionBuildingException("Operand cannot be null");

                var type = _typeResolver.ResolveType(@as.asType.Name!)
                           ?? throw this.NewExpressionBuildingException($"Cannot resolve type {@as.asType.Name}");

                var operand = TranslateExpression(@as.operand);
                if (!type.IsAssignableTo(operand.Type))
                {
                    _logger.LogWarning(FormatMessage($"Potentially unsafe cast from {TypeManager.PrettyTypeName(operand.Type)} to type {TypeManager.PrettyTypeName(type)}", @as.operand));
                }

                return new ElmAsExpression(operand, type);
            }
        }

        protected Expression Is(Elm.Is @is) // @TODO: Cast
        {
            var op = TranslateExpression(@is.operand!);
            Type? type = null;
            if (@is.isTypeSpecifier != null)
            {
                if (@is.isTypeSpecifier is Elm.ChoiceTypeSpecifier choice)
                {
                    var firstChoiceType = TypeFor(choice.choice[0]) ?? throw this.NewExpressionBuildingException($"Could not resolve type for Is expression");
                    Expression result = op.ExprTypeIs(firstChoiceType);
                    for (int i = 1; i < choice.choice.Length; i++)
                    {
                        var cti = TypeFor(choice.choice[i]) ?? throw this.NewExpressionBuildingException($"Could not resolve type for Is expression");
                        var ie = op.ExprTypeIs(cti);
                        result = Expression.Or(result, ie);
                    }
                    var ta = result.ExprTypeAs<bool?>();
                    return ta;
                }

                type = TypeFor(@is.isTypeSpecifier) ?? throw this.NewExpressionBuildingException($"Could not resolve type for Is expression");
            }
            else if (!string.IsNullOrWhiteSpace(@is.isType?.Name))
            {
                type = _typeResolver.ResolveType(@is.isType.Name) ?? throw this.NewExpressionBuildingException($"Could not resolve type {@is.isType.Name}");
            }

            if (type == null)
                throw this.NewExpressionBuildingException($"Could not identify Is type specifer via {nameof(@is.isTypeSpecifier)} or {nameof(@is.isType)}.");

            var isExpression = op.ExprTypeIs(type);
            var nullable = isExpression.ExprTypeAs<bool?>();
            return nullable;
        }


        private Expression ChangeType(Element element, Type outputType)
            => ChangeType(TranslateExpression(element), outputType); // @TODO: Cast

        private Expression ChangeType(Expression input, Type outputType) // @TODO: Cast
        {
            if (input.Type == outputType)
                return input;

            if (input.Type == typeof(object) || outputType.IsAssignableFrom(input.Type))
                return input.ExprTypeAs(outputType);

            if (_typeResolver.IsListType(input.Type)
                && _typeResolver.IsListType(outputType))
            {
                var inputElementType = _typeResolver.GetListElementType(input.Type, true)!;
                var outputElementType = _typeResolver.GetListElementType(outputType, true)!;
                var lambdaParameter = Expression.Parameter(inputElementType, TypeNameToIdentifier(inputElementType, this));
                var lambdaBody = ChangeType(lambdaParameter, outputElementType);
                var lambda = Expression.Lambda(lambdaBody, lambdaParameter);
                return BindCqlOperatorsMethod(CqlOperator.Select, input, lambda);
            }

            if(TryCorrectQiCoreBindingError(input.Type, outputType, out var correctedTo))
            {
                return BindCqlOperatorsMethod(CqlOperator.Convert, input, Expression.Constant(correctedTo, typeof(Type)));
            }

            return BindCqlOperatorsMethod(CqlOperator.Convert, input, Expression.Constant(outputType, typeof(Type)));
        }
    }
}
