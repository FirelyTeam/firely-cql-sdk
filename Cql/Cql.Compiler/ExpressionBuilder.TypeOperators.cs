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
using System.Diagnostics;
using System.Linq.Expressions;
using Microsoft.Extensions.Logging;
using F = Hl7.Fhir.Model;

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
                        if (IsOrImplementsIEnumerableOfT(type))
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
                var call = _operatorBinding.Bind(CqlOperator.Descendants, LibraryDefinitionsBuilder.ContextParameter, source);
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
            var call = _operatorBinding.Bind(CqlOperator.ConvertQuantity, LibraryDefinitionsBuilder.ContextParameter, quantity, unit);
            return call;
        }

        protected Expression? ConvertsToLong(Elm.ConvertsToLong e) =>
            UnaryOperator(CqlOperator.ConvertsToLong, e);

        private Expression? ConvertsToInteger(Elm.ConvertsToInteger e) =>
            UnaryOperator(CqlOperator.ConvertsToInteger, e);

        protected Expression? ConvertsToDecimal(Elm.ConvertsToDecimal e) =>
            UnaryOperator(CqlOperator.ConvertsToDecimal, e);

        protected Expression? ConvertsToDateTime(Elm.ConvertsToDateTime e) =>
            UnaryOperator(CqlOperator.ConvertsToDateTime, e);

        protected Expression? ConvertsToDate(Elm.ConvertsToDate e) =>
            UnaryOperator(CqlOperator.ConvertsToDate, e);

        protected Expression? ConvertsToBoolean(Elm.ConvertsToBoolean e) =>
            UnaryOperator(CqlOperator.ConvertsToDate, e);

        private Expression? ConvertsToQuantity(Elm.ConvertsToQuantity e) =>
            UnaryOperator(CqlOperator.ConvertsToQuantity, e);

        private Expression? ConvertsToString(Elm.ConvertsToString e) =>
            UnaryOperator(CqlOperator.ConvertsToString, e);

        private Expression? ConvertsToTime(Elm.ConvertsToTime e) =>
            UnaryOperator(CqlOperator.ConvertsToTime, e);


        protected Expression? ToBoolean(Elm.ToBoolean e)
        {
            var operand = TranslateExpression(e.operand!);
            return ChangeType(operand, typeof(bool?));
        }

        protected Expression? ToConcept(Elm.ToConcept e)
        {
            var operand = TranslateExpression(e.operand!);
            return ChangeType(operand, _typeManager.Resolver.ConceptType);
        }

        protected Expression? ToDate(Elm.ToDate e)
        {
            var operand = TranslateExpression(e.operand!);
            return ChangeType(operand, _typeManager.Resolver.DateType);
        }

        protected Expression ToDateTime(Elm.ToDateTime e)
        {
            var operand = TranslateExpression(e.operand!);
            return ChangeType(operand, _typeManager.Resolver.DateTimeType);
        }


        protected Expression ToDecimal(Elm.ToDecimal e)
        {
            var operand = TranslateExpression(e.operand!);
            return ChangeType(operand, typeof(decimal?));
        }

        protected Expression ToLong(Elm.ToLong e)
        {
            var operand = TranslateExpression(e.operand!);
            return ChangeType(operand, typeof(long?));
        }

        protected Expression? ToInteger(Elm.ToInteger e)
        {
            var operand = TranslateExpression(e.operand!);
            return ChangeType(operand, typeof(int?));
        }

        protected Expression? ToQuantity(Elm.ToQuantity tq)
        {
            var operand = TranslateExpression(tq.operand!);
            return ChangeType(operand, _typeManager.Resolver.QuantityType);
        }

        protected Expression? ToString(Elm.ToString e)
        {
            var operand = TranslateExpression(e.operand!);
            return ChangeType(operand, typeof(string));
        }
        protected Expression? ToTime(Elm.ToTime e)
        {
            var operand = TranslateExpression(e.operand!);
            return ChangeType(operand, _typeManager.Resolver.TimeType);
        }

        protected Expression ToList(Elm.ToList e)
        {
            var operand = TranslateExpression(e.operand!);
            var call = _operatorBinding.Bind(CqlOperator.ToList, LibraryDefinitionsBuilder.ContextParameter, operand);
            return call;
        }

        private Expression ChangeType(Expression input, Type outputType)
        {
            if (input.Type == outputType)
                return input;

            if (input.Type == typeof(object) || outputType.IsAssignableFrom(input.Type))
                return Expression.TypeAs(input, outputType);

            if (IsOrImplementsIEnumerableOfT(input.Type)
                && IsOrImplementsIEnumerableOfT(outputType))
            {
                var inputElementType = _typeManager.Resolver.GetListElementType(input.Type, true)!;
                var outputElementType = _typeManager.Resolver.GetListElementType(outputType, true)!;
                var lambdaParameter = Expression.Parameter(inputElementType, TypeNameToIdentifier(inputElementType, this));
                var lambdaBody = ChangeType(lambdaParameter, outputElementType);
                var lambda = Expression.Lambda(lambdaBody, lambdaParameter);
                var callSelect = _operatorBinding.Bind(CqlOperator.Select, LibraryDefinitionsBuilder.ContextParameter, input, lambda);
                return callSelect;
            }

            if(TryCorrectQiCoreBindingError(input.Type, outputType, out var correctedTo))
            {
                var call = _operatorBinding.Bind(CqlOperator.Convert, LibraryDefinitionsBuilder.ContextParameter, input, Expression.Constant(correctedTo, typeof(Type)));
                return call;
            }
            else
            {
                var call = _operatorBinding.Bind(CqlOperator.Convert, LibraryDefinitionsBuilder.ContextParameter, input, Expression.Constant(outputType, typeof(Type)));
                return call;
            }
        }

        private static readonly Dictionary<(Type,Type),Type> KnownErrors = new()
        {
            [(typeof(F.ObservationStatus?), typeof(F.Code<F.VerificationResult.StatusCode>))] = typeof(F.ObservationStatus?)
        };

        // At this moment (20240308) the QICore translation by the current tooling (3.8.0.0) of the CQl-to-ELM
        // translator is incorrect. This method is a temporary workaround to correct the incorrectly mapped binding
        // names. This method should be removed once the QICore translation is fixed.
        // See https://github.com/cqframework/cqf-tooling/issues/518.
        private static bool TryCorrectQiCoreBindingError(Type source, Type to, out Type? correctedTo)
        {
            return KnownErrors.TryGetValue((source,to), out correctedTo);
        }
    }
}
