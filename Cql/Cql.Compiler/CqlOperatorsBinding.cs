#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Conversion;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Hl7.Cql.Abstractions.Infrastructure;
using ListSortDirection = System.ComponentModel.ListSortDirection;

namespace Hl7.Cql.Compiler
{
    /// <summary>
    /// Implements <see cref="OperatorBinding"/> by calling methods in <see cref="CqlOperators"/>.
    /// </summary>
    internal partial class CqlOperatorsBinding : OperatorBinding
    {
        internal TypeConverter? TypeConverter { get; }

        internal TypeResolver TypeResolver { get; }


        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="typeResolver">
        /// The type resolver used in this binding.
        /// Note that if you provide a different instance of this class to <see cref="CqlOperators"/>, you will get errors at runtime.
        /// </param>
        /// <param name="typeConverter">
        /// If provided, this binding will use the supplied instance to determine whether
        /// a conversion is possible.  Note that if you provide a different instance of this class to <see cref="CqlOperators"/>,
        /// you may get errors at runtime, because this binding will think a conversion is possible when at runtime it is not.
        /// If not provided, only conversions defined in <see cref="CqlOperators"/> will be used.
        /// </param>
        public CqlOperatorsBinding(
            TypeResolver typeResolver,
            TypeConverter? typeConverter = null)
        {
            TypeConverter = typeConverter;
            TypeResolver = typeResolver;
        }

        /// <summary>
        /// Binds <paramref name="operator"/> to an <see cref="Expression"/>.
        /// </summary>
        /// <param name="operator">The operator to bind.</param>
        /// <param name="parameters">Zero or more parameter <see cref="Expression"/>s.  The number and order of expressions is dependent on <paramref name="operator"/>.</param>
        /// <returns>An expression that implements <paramref name="operator"/>.  In most cases, this will be a <see cref="MethodCallExpression"/>.</returns>
        public override Expression BindToMethod(
            CqlOperator @operator,
            params Expression[] parameters)
        {
            var result = @operator switch
            {
                // @formatter:off

                // Bindings with Argument Conversions
                CqlOperator.IntervalIntersect                => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalIntersect), parameters[..2]),
                CqlOperator.IntervalProperlyIncludesElement when parameters.Length == 2
                                                             => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalProperlyIncludesElement), parameters[..2]),
                CqlOperator.IntervalUnion                    => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalUnion), parameters[..2]),
                CqlOperator.ListContains                     => BindToMethodConvertArgs(nameof(ICqlOperators.ListContains), parameters[..2]),
                CqlOperator.ListElementAt                    => BindToMethodConvertArgs(nameof(ICqlOperators.ListElementAt), parameters[..2]),
                CqlOperator.ListEqual                        => BindToMethodConvertArgs(nameof(ICqlOperators.ListEqual), parameters[..2]),
                CqlOperator.ListEquivalent                   => BindToMethodConvertArgs(nameof(ICqlOperators.ListEquivalent), parameters[..2]),
                CqlOperator.ListExcept                       => BindToMethodConvertArgs(nameof(ICqlOperators.ListExcept), parameters[..2]),
                CqlOperator.ListIncludesElement              => BindToMethodConvertArgs(nameof(ICqlOperators.ListIncludesElement), parameters[..2]),
                CqlOperator.ListIncludesList                 => BindToMethodConvertArgs(nameof(ICqlOperators.ListIncludesList), parameters[..2]),
                CqlOperator.ListIndexOf                      => BindToMethodConvertArgs(nameof(ICqlOperators.ListIndexOf), parameters[..2]),
                CqlOperator.ListIntersect                    => BindToMethodConvertArgs(nameof(ICqlOperators.ListIntersect), parameters[..2]),
                CqlOperator.ListProperlyIncludesElement      => BindToMethodConvertArgs(nameof(ICqlOperators.ListProperlyIncludesElement), parameters[..2]),
                CqlOperator.ListProperlyIncludesList         => BindToMethodConvertArgs(nameof(ICqlOperators.ListProperlyIncludesList), parameters[..2]),
                CqlOperator.ListSort                         => BindToMethodConvertArgs(nameof(ICqlOperators.ListSort), parameters[..2]),
                CqlOperator.Add                              => BindToMethodConvertArgs(nameof(ICqlOperators.Add), parameters[..2]),
                CqlOperator.And                              => BindToMethodConvertArgs(nameof(ICqlOperators.And), parameters[..2]),
                CqlOperator.CodeInValueSet                   => BindToMethodConvertArgs(nameof(ICqlOperators.CodeInValueSet), parameters[..2]),
                CqlOperator.CodesInValueSet                  => BindToMethodConvertArgs(nameof(ICqlOperators.CodesInValueSet), parameters[..2]),
                CqlOperator.Collapse                         => BindToMethodConvertArgs(nameof(ICqlOperators.Collapse), parameters[..2]),
                CqlOperator.Combine                          => BindToMethodConvertArgs(nameof(ICqlOperators.Combine), parameters[..2]),
                CqlOperator.DateTimeComponent                => BindToMethodConvertArgs(nameof(ICqlOperators.ComponentFrom), parameters[..2]),
                CqlOperator.Concatenate                      => BindToMethodConvertArgs(nameof(ICqlOperators.Concatenate), parameters[..2]),
                CqlOperator.ConceptInValueSet                => BindToMethodConvertArgs(nameof(ICqlOperators.ConceptInValueSet), parameters[..2]),
                CqlOperator.ConceptsInValueSet               => BindToMethodConvertArgs(nameof(ICqlOperators.ConceptsInValueSet), parameters[..2]),
                CqlOperator.ConvertQuantity                  => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertQuantity), parameters[..2]),
                CqlOperator.Divide                           => BindToMethodConvertArgs(nameof(ICqlOperators.Divide), parameters[..2]),
                CqlOperator.EndsWith                         => BindToMethodConvertArgs(nameof(ICqlOperators.EndsWith), parameters[..2]),
                CqlOperator.EnumEqualsString                 => BindToMethodConvertArgs(nameof(ICqlOperators.EnumEqualsString), parameters[..2]),
                CqlOperator.Equal                            => BindToMethodConvertArgs(nameof(ICqlOperators.Equal), parameters[..2]),
                CqlOperator.Equivalent                       => BindToMethodConvertArgs(nameof(ICqlOperators.Equivalent), parameters[..2]),
                CqlOperator.Greater                          => BindToMethodConvertArgs(nameof(ICqlOperators.Greater), parameters[..2]),
                CqlOperator.GreaterOrEqual                   => BindToMethodConvertArgs(nameof(ICqlOperators.GreaterOrEqual), parameters[..2]),
                CqlOperator.HighBoundary                     => BindToMethodConvertArgs(nameof(ICqlOperators.HighBoundary), parameters[..2]),
                CqlOperator.Implies                          => BindToMethodConvertArgs(nameof(ICqlOperators.Implies), parameters[..2]),
                CqlOperator.IntervalExcept                   => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalExcept), parameters[..2]),
                CqlOperator.LastPositionOf                   => BindToMethodConvertArgs(nameof(ICqlOperators.LastPositionOf), parameters[..2]),
                CqlOperator.Less                             => BindToMethodConvertArgs(nameof(ICqlOperators.Less), parameters[..2]),
                CqlOperator.LessOrEqual                      => BindToMethodConvertArgs(nameof(ICqlOperators.LessOrEqual), parameters[..2]),
                CqlOperator.Log                              => BindToMethodConvertArgs(nameof(ICqlOperators.Log), parameters[..2]),
                CqlOperator.LowBoundary                      => BindToMethodConvertArgs(nameof(ICqlOperators.LowBoundary), parameters[..2]),
                CqlOperator.Matches                          => BindToMethodConvertArgs(nameof(ICqlOperators.Matches), parameters[..2]),
                CqlOperator.Modulo                           => BindToMethodConvertArgs(nameof(ICqlOperators.Modulo), parameters[..2]),
                CqlOperator.Multiply                         => BindToMethodConvertArgs(nameof(ICqlOperators.Multiply), parameters[..2]),
                CqlOperator.Or                               => BindToMethodConvertArgs(nameof(ICqlOperators.Or), parameters[..2]),
                CqlOperator.PositionOf                       => BindToMethodConvertArgs(nameof(ICqlOperators.PositionOf), parameters[..2]),
                CqlOperator.Pow                              => BindToMethodConvertArgs(nameof(ICqlOperators.Power), parameters[..2]),
                CqlOperator.Round                            => BindToMethodConvertArgs(nameof(ICqlOperators.Round), parameters[..2]),
                CqlOperator.Split                            => BindToMethodConvertArgs(nameof(ICqlOperators.Split), parameters[..2]),
                CqlOperator.StartsWith                       => BindToMethodConvertArgs(nameof(ICqlOperators.StartsWith), parameters[..2]),
                CqlOperator.CharAt                           => BindToMethodConvertArgs(nameof(ICqlOperators.StringIndexer), parameters[..2]),
                CqlOperator.StringInValueSet                 => BindToMethodConvertArgs(nameof(ICqlOperators.StringInValueSet), parameters[..2]),
                CqlOperator.StringsInValueSet                => BindToMethodConvertArgs(nameof(ICqlOperators.StringsInValueSet), parameters[..2]),
                CqlOperator.Subtract                         => BindToMethodConvertArgs(nameof(ICqlOperators.Subtract), parameters[..2]),
                CqlOperator.TruncatedDivide                  => BindToMethodConvertArgs(nameof(ICqlOperators.TruncateDivide), parameters[..2]),
                CqlOperator.Xor                              => BindToMethodConvertArgs(nameof(ICqlOperators.Xor), parameters[..2]),
                CqlOperator.After                            => BindToMethodConvertArgs(nameof(ICqlOperators.After), parameters[..3]),
                CqlOperator.Before                           => BindToMethodConvertArgs(nameof(ICqlOperators.Before), parameters[..3]),
                CqlOperator.DifferenceBetween                => BindToMethodConvertArgs(nameof(ICqlOperators.DifferenceBetween), parameters[..3]),
                CqlOperator.DurationBetween                  => BindToMethodConvertArgs(nameof(ICqlOperators.DurationBetween), parameters[..3]),
                CqlOperator.IntervalAfterInterval            => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalAfterInterval), parameters[..3]),
                CqlOperator.IntervalBeforeInterval           => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalBeforeInterval), parameters[..3]),
                CqlOperator.IntervalProperlyIncludesElement  => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalProperlyIncludesElement), parameters[..3]),
                CqlOperator.Meets                            => BindToMethodConvertArgs(nameof(ICqlOperators.Meets), parameters[..3]),
                CqlOperator.MeetsAfter                       => BindToMethodConvertArgs(nameof(ICqlOperators.MeetsAfter), parameters[..3]),
                CqlOperator.MeetsBefore                      => BindToMethodConvertArgs(nameof(ICqlOperators.MeetsBefore), parameters[..3]),
                CqlOperator.ReplaceMatches                   => BindToMethodConvertArgs(nameof(ICqlOperators.ReplaceMatches), parameters[..3]),
                CqlOperator.SameAs                           => BindToMethodConvertArgs(nameof(ICqlOperators.SameAs), parameters[..3]),
                CqlOperator.SameOrAfter                      => BindToMethodConvertArgs(nameof(ICqlOperators.SameOrAfter), parameters[..3]),
                CqlOperator.SameOrBefore                     => BindToMethodConvertArgs(nameof(ICqlOperators.SameOrBefore), parameters[..3]),
                CqlOperator.Substring                        => BindToMethodConvertArgs(nameof(ICqlOperators.Substring), parameters[..3]),
                CqlOperator.Abs                              => BindToMethodConvertArgs(nameof(ICqlOperators.Abs), parameters[..1]),
                CqlOperator.AllTrue                          => BindToMethodConvertArgs(nameof(ICqlOperators.AllTrue), parameters[..1]),
                CqlOperator.AnyTrue                          => BindToMethodConvertArgs(nameof(ICqlOperators.AnyTrue), parameters[..1]),
                CqlOperator.Avg                              => BindToMethodConvertArgs(nameof(ICqlOperators.Avg), parameters[..1]),
                CqlOperator.Ceiling                          => BindToMethodConvertArgs(nameof(ICqlOperators.Ceiling), parameters[..1]),
                CqlOperator.ConvertsToDate                   => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToDate), parameters[..1]),
                CqlOperator.ConvertsToDateTime               => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToDateTime), parameters[..1]),
                CqlOperator.ConvertsToDecimal                => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToDecimal), parameters[..1]),
                CqlOperator.ConvertsToInteger                => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToInteger), parameters[..1]),
                CqlOperator.ConvertsToLong                   => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToLong), parameters[..1]),
                CqlOperator.ConvertsToQuantity               => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToQuantity), parameters[..1]),
                CqlOperator.ConvertsToString                 => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToString), parameters[..1]),
                CqlOperator.ConvertsToTime                   => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToTime), parameters[..1]),
                CqlOperator.DateComponent                    => BindToMethodConvertArgs(nameof(ICqlOperators.DateFrom), parameters[..1]),
                CqlOperator.Descendents                      => BindToMethodConvertArgs(nameof(ICqlOperators.Descendents), parameters[..1]),
                CqlOperator.IntervalEnd                      => BindToMethodConvertArgs(nameof(ICqlOperators.End), parameters[..1]),
                CqlOperator.Exp                              => BindToMethodConvertArgs(nameof(ICqlOperators.Exp), parameters[..1]),
                CqlOperator.Floor                            => BindToMethodConvertArgs(nameof(ICqlOperators.Floor), parameters[..1]),
                CqlOperator.GeometricMean                    => BindToMethodConvertArgs(nameof(ICqlOperators.GeometricMean), parameters[..1]),
                CqlOperator.IsFalse                          => BindToMethodConvertArgs(nameof(ICqlOperators.IsFalse), parameters[..1]),
                CqlOperator.IsTrue                           => BindToMethodConvertArgs(nameof(ICqlOperators.IsTrue), parameters[..1]),
                CqlOperator.Ln                               => BindToMethodConvertArgs(nameof(ICqlOperators.Ln), parameters[..1]),
                CqlOperator.Lower                            => BindToMethodConvertArgs(nameof(ICqlOperators.Lower), parameters[..1]),
                CqlOperator.Median                           => BindToMethodConvertArgs(nameof(ICqlOperators.Median), parameters[..1]),
                CqlOperator.Negate                           => BindToMethodConvertArgs(nameof(ICqlOperators.Negate), parameters[..1]),
                CqlOperator.Not                              => BindToMethodConvertArgs(nameof(ICqlOperators.Not), parameters[..1]),
                CqlOperator.PopulationStdDev                 => BindToMethodConvertArgs(nameof(ICqlOperators.PopulationStdDev), parameters[..1]),
                CqlOperator.PopulationVariance               => BindToMethodConvertArgs(nameof(ICqlOperators.PopulationVariance), parameters[..1]),
                CqlOperator.Precision                        => BindToMethodConvertArgs(nameof(ICqlOperators.Precision), parameters[..1]),
                CqlOperator.Predecessor                      => BindToMethodConvertArgs(nameof(ICqlOperators.Predecessor), parameters[..1]),
                CqlOperator.Product                          => BindToMethodConvertArgs(nameof(ICqlOperators.Product), parameters[..1]),
                CqlOperator.IntervalStart                    => BindToMethodConvertArgs(nameof(ICqlOperators.Start), parameters[..1]),
                CqlOperator.StdDev                           => BindToMethodConvertArgs(nameof(ICqlOperators.StdDev), parameters[..1]),
                CqlOperator.StringLength                     => BindToMethodConvertArgs(nameof(ICqlOperators.StringLength), parameters[..1]),
                CqlOperator.Successor                        => BindToMethodConvertArgs(nameof(ICqlOperators.Successor), parameters[..1]),
                CqlOperator.Sum                              => BindToMethodConvertArgs(nameof(ICqlOperators.Sum), parameters[..1]),
                CqlOperator.TimeComponent                    => BindToMethodConvertArgs(nameof(ICqlOperators.TimeFrom), parameters[..1]),
                CqlOperator.TimeZoneComponent                => BindToMethodConvertArgs(nameof(ICqlOperators.TimezoneOffsetFrom), parameters[..1]),
                CqlOperator.Truncate                         => BindToMethodConvertArgs(nameof(ICqlOperators.Truncate), parameters[..1]),
                CqlOperator.Upper                            => BindToMethodConvertArgs(nameof(ICqlOperators.Upper), parameters[..1]),
                CqlOperator.Variance                         => BindToMethodConvertArgs(nameof(ICqlOperators.Variance), parameters[..1]),
                CqlOperator.CalculateAge                     => BindToMethodConvertArgs(nameof(ICqlOperators.CalculateAge), parameters[..2]),
                CqlOperator.CalculateAgeAt                   => BindToMethodConvertArgs(nameof(ICqlOperators.CalculateAgeAt), parameters[..3]),
                CqlOperator.ElementAfterInterval             => BindToMethodConvertArgs(nameof(ICqlOperators.ElementAfterInterval), parameters[..3]),
                CqlOperator.ElementBeforeInterval            => BindToMethodConvertArgs(nameof(ICqlOperators.ElementBeforeInterval), parameters[..3]),
                CqlOperator.IntervalAfterElement             => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalAfterElement), parameters[..3]),
                CqlOperator.IntervalBeforeElement            => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalBeforeElement), parameters[..3]),
                CqlOperator.IntervalContains                 => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalContains), parameters[..3]),
                CqlOperator.IntervalSameOrAfter              => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalSameOrAfter), parameters[..3]),
                CqlOperator.IntervalSameOrBefore             => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalSameOrBefore), parameters[..3]),
                CqlOperator.Overlaps                         => BindToMethodConvertArgs(nameof(ICqlOperators.Overlaps), parameters[..3]),
                CqlOperator.OverlapsAfter                    => BindToMethodConvertArgs(nameof(ICqlOperators.OverlapsAfter), parameters[..3]),
                CqlOperator.OverlapsBefore                   => BindToMethodConvertArgs(nameof(ICqlOperators.OverlapsBefore), parameters[..3]),
                CqlOperator.InInterval                       => BindToMethodConvertArgs(nameof(ICqlOperators.ElementInInterval), parameters[..3]),
                CqlOperator.Ends                             => BindToMethodConvertArgs(nameof(ICqlOperators.Ends), parameters[..3]),
                CqlOperator.IntervalIncludesElement          => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalIncludesElement), parameters[..3]),
                CqlOperator.IntervalIncludesInterval         => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalIncludesInterval), parameters[..3]),
                CqlOperator.IntervalProperlyIncludesInterval => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalProperlyIncludesInterval), parameters[..3]),
                CqlOperator.IntervalSameAs                   => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalSameAs), parameters[..3]),
                CqlOperator.Slice                            => BindToMethodConvertArgs(nameof(ICqlOperators.Slice), parameters[..3]),
                CqlOperator.Starts                           => BindToMethodConvertArgs(nameof(ICqlOperators.Starts), parameters[..3]),
                CqlOperator.Count                            => BindToMethodConvertArgs(nameof(ICqlOperators.CountOrNull), parameters[..1]),
                CqlOperator.Exists                           => BindToMethodConvertArgs(nameof(ICqlOperators.ExistsInList), parameters[..1]),
                CqlOperator.First                            => BindToMethodConvertArgs(nameof(ICqlOperators.FirstOfList), parameters[..1]),
                CqlOperator.Last                             => BindToMethodConvertArgs(nameof(ICqlOperators.LastOfList), parameters[..1]),
                CqlOperator.Distinct                         => BindToMethodConvertArgs(nameof(ICqlOperators.ListDistinct), parameters[..1]),
                CqlOperator.ListLength                       => BindToMethodConvertArgs(nameof(ICqlOperators.ListLength), parameters[..1]),
                CqlOperator.Tail                             => BindToMethodConvertArgs(nameof(ICqlOperators.ListTail), parameters[..1]),
                CqlOperator.MaxElementInList                 => BindToMethodConvertArgs(nameof(ICqlOperators.MaxOrNull), parameters[..1]),
                CqlOperator.MinElementInList                 => BindToMethodConvertArgs(nameof(ICqlOperators.MinOrNull), parameters[..1]),
                CqlOperator.Mode                             => BindToMethodConvertArgs(nameof(ICqlOperators.Mode), parameters[..1]),
                CqlOperator.PointFrom                        => BindToMethodConvertArgs(nameof(ICqlOperators.PointFrom), parameters[..1]),
                CqlOperator.Single                           => BindToMethodConvertArgs(nameof(ICqlOperators.SingleOrNull), parameters[..1]),

                // Direct Bindings
                CqlOperator.Aggregate                        => BindToMethod(methodName:nameof(ICqlOperators.AggregateOrNull),
                                                                    typeArguments:[TypeResolver.GetListElementType(parameters[0].Type, true)!, parameters[2].Type],
                                                                    parameters[0], parameters[2], parameters[1]), // NOTE: the order here is 0, 2, 1, maybe change the Aggregate method arguments as well?
                CqlOperator.CrossJoin                        => BindToMethod(methodName:nameof(ICqlOperators.CrossJoin),
                                                                    typeArguments:parameters.SelectToArray(s => TypeResolver.GetListElementType(s.Type, true)!),
                                                                    parameters),
                CqlOperator.Date                             => BindToMethod(nameof(ICqlOperators.Date), parameters),
                CqlOperator.DateTime                         => BindToMethod(nameof(ICqlOperators.DateTime)!, parameters),
                CqlOperator.Now                              => BindToMethod(nameof(ICqlOperators.Now)),
                CqlOperator.Quantity                         => BindToMethod(nameof(ICqlOperators.Quantity), parameters[..2]), // Discard the 3rd parameter!!
                CqlOperator.Time                             => BindToMethod(nameof(ICqlOperators.Time), parameters),
                CqlOperator.TimeOfDay                        => BindToMethod(nameof(ICqlOperators.TimeOfDay)),
                CqlOperator.Today                            => BindToMethod(nameof(ICqlOperators.Today)),
                CqlOperator.Message                          => BindToMethod(nameof(ICqlOperators.Message), typeArguments:[parameters[0].Type], parameters),
                CqlOperator.ToList                           => BindToMethod(nameof(ICqlOperators.ToList), typeArguments:[parameters[0].Type], parameters),

                // Special cases
                CqlOperator.Convert                          => BindConvert(parameters[0], parameters[1]),
                CqlOperator.Coalesce                         => Coalesce(parameters[0]),
                CqlOperator.Expand                           => Expand(parameters[0], parameters[1]),
                CqlOperator.Flatten                          => Flatten(parameters[0]),
                CqlOperator.InList                           => InList(parameters[0], parameters[1]),
                CqlOperator.Interval                         => Interval(parameters[0], parameters[1], parameters[2], parameters[3]),
                CqlOperator.LateBoundProperty                => LateBoundProperty(parameters[0], parameters[1], parameters[2]),
                CqlOperator.ListUnion                        => ListUnion(parameters[0], parameters[1]),
                CqlOperator.MaximumValue                     => Maximum(parameters[0]),
                CqlOperator.MinimumValue                     => Minimum(parameters[0]),
                CqlOperator.ResolveValueSet                  => ResolveValueSet(parameters[0]),
                CqlOperator.Retrieve                         => Retrieve(parameters[0], parameters[1], parameters[2]),
                CqlOperator.Select                           => Select(parameters[0], parameters[1]),
                CqlOperator.SelectMany                       => SelectMany(source: parameters[0], collectionSelectorLambda: parameters[1]),
                CqlOperator.SelectManyResults                => SelectManyResults(source: parameters[0], collectionSelectorLambda: parameters[1], resultSelectorLambda: parameters[2]),
                CqlOperator.SortBy                           => SortBy(parameters[0], parameters[1], parameters[2]),
                CqlOperator.Where                            => Where(parameters[0], parameters[1]),
                CqlOperator.Width                            => Width(parameters[0]),
                CqlOperator.Ratio
                    or CqlOperator.PropertyOrDefault
                    or _                                     => throw new NotSupportedException($"Operator {Enum.GetName(typeof(CqlOperator), @operator)} is not supported by this binding.")
                // @formatter:on
            };
            return result;
        }

        private Expression Expand(
            Expression argument,
            Expression perQuantity)
        {
            if (perQuantity is ConstantExpression { Value: null })
                perQuantity = Expression.Constant(null, typeof(CqlQuantity));
            if (TypeResolver.ImplementsGenericIEnumerable(argument.Type))
            {

                var elementType = TypeResolver.GetListElementType(argument.Type)!;
                if (elementType == null)
                    throw new ArgumentException($"Unable to determine element type for Expand argument.", nameof(argument));

                if (IsInterval(elementType))
                {
                    //return BindToMethod(nameof(ICqlOperators.ExpandList), BindOptions.ConvertArguments, argument, perQuantity);

                    var methods = ICqlOperators_MethodInfos_By_Name[nameof(ICqlOperators.ExpandList)];
                    foreach (var method in methods)
                    {
                        var methodParameters = method.GetParameters();
                        if (methodParameters.Length == 2)
                        {
                            var operandConversion = CanConvert(argument.Type, methodParameters[0].ParameterType);
                            if (operandConversion == ConversionType.Incompatible)
                                continue;
                            var call = BindToMethod(method, argument, perQuantity);
                            return call;
                        }
                    }
                    throw new ArgumentException($"No suitable unary method {nameof(ICqlOperators.ExpandList)}({argument.Type}) could be found.", nameof(ICqlOperators.ExpandList));
                }
                else throw new ArgumentException($"Expand expects a list element type to be an interval.", nameof(argument));
            }
            else if (IsInterval(argument.Type))
            {
                //return BindToMethod(nameof(ICqlOperators.ExpandInterval), BindOptions.ConvertArguments, argument, perQuantity);

                var methods = ICqlOperators_MethodInfos_By_Name[nameof(ICqlOperators.ExpandInterval)];
                foreach (var method in methods)
                {
                    var methodParameters = method.GetParameters();
                    if (methodParameters.Length == 2)
                    {
                        var operandConversion = CanConvert(argument.Type, methodParameters[0].ParameterType);
                        if (operandConversion == ConversionType.Incompatible)
                            continue;
                        var call = BindToMethod(method, argument, perQuantity);
                        return call;
                    }
                }
                throw new ArgumentException($"No suitable unary method {nameof(ICqlOperators.ExpandInterval)}({argument.Type}) could be found.", nameof(ICqlOperators.ExpandInterval));
            }
            else throw new ArgumentException($"Expand allows only a List<Interval<T>> or an Interval<T> as a parameter.", nameof(argument));
        }

        private Expression SortBy(
            Expression source,
            Expression by,
            Expression order)
        {
            if (by is LambdaExpression lambda && order is ConstantExpression orderConstant && orderConstant.Type == typeof(ListSortDirection))
            {
                var elementType = TypeResolver.GetListElementType(source.Type) ?? throw new InvalidOperationException($"'{source.Type}' was expected to be a list type.");
                var call = BindToMethod(nameof(ICqlOperators.ListSortBy), [elementType], source, lambda, orderConstant);
                return call;

            }
            else throw new ArgumentException("SortBy expects 3 parameters: source, lambda, and SortOrder constant", nameof(by));
        }

        private Expression InList(
            Expression left,
            Expression right)
        {
            if (left.Type == typeof(CqlCode))
            {
                var rightElementType = TypeResolver.GetListElementType(right.Type);
                if (rightElementType == typeof(CqlCode))
                {
                    return BindToMethodConvertArgs(nameof(ICqlOperators.CodeInList), left, right);
                }
            }
            return (Expression?)BindToMethodConvertArgsOrNull(nameof(ICqlOperators.InList), left, right) ?? NullObject_ConstantExpression;
        }

        private Expression ListUnion(
            Expression left,
            Expression right)
        {
            if (left.Type == typeof(IValueSetFacade) && right.Type == typeof(IValueSetFacade))
            {
                return BindToMethodConvertArgs(nameof(ICqlOperators.ValueSetUnion), Expression.TypeAs(left, typeof(IEnumerable<CqlCode>)), Expression.TypeAs(right, typeof(IEnumerable<CqlCode>)));
            }
            var leftElementType = TypeResolver.GetListElementType(left.Type);
            if (leftElementType == typeof(CqlCode))
            {
                var rightElementType = TypeResolver.GetListElementType(right.Type);
                if (rightElementType == typeof(CqlCode))
                {
                    return BindToMethodConvertArgs(nameof(ICqlOperators.ValueSetUnion), left, right);
                }
            }

            return BindToMethodConvertArgs(nameof(ICqlOperators.ListUnion), left, right);
        }

        private Expression ResolveValueSet(Expression expression)
        {
            if (expression is NewExpression @new && @new.Type == typeof(CqlValueSet))
            {
                var call = BindToMethod(nameof(ICqlOperators.ResolveValueSet), @new);
                return call;
            }
            else throw new ArgumentException("Expression should be a constant CqlValueSet");
        }

        private Expression Minimum(Expression typeConstant)
        {
            if (typeConstant is ConstantExpression { Value: Type t })
            {
                var call = BindToMethod(nameof(ICqlOperators.Minimum), [t]);
                return call;
            }
            else throw new ArgumentException("Expression should be a constant expression whose type is Type", nameof(typeConstant));
        }

        private Expression Maximum(Expression typeConstant)
        {
            if (typeConstant is ConstantExpression { Value: Type t })
            {
                var call = BindToMethod(nameof(ICqlOperators.Maximum), [t]);
                return call;
            }
            else throw new ArgumentException("Expression should be a constant expression whose type is Type", nameof(typeConstant));
        }

        private Expression Coalesce(Expression operand)
        {
            if (operand.Type.IsGenericType)
            {
                var genericArgumentType = operand.Type.GetGenericArguments()[0];
                if (genericArgumentType.IsValueType)
                {

                    if (genericArgumentType.IsGenericType && genericArgumentType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    {
                        var underlying = Nullable.GetUnderlyingType(genericArgumentType)!;
                        var call = BindToMethod(nameof(ICqlOperators.CoalesceValueTypes), [underlying], operand);
                        return call;
                    }
                    else
                    {
                        var call = BindToMethod(nameof(ICqlOperators.CoalesceValueTypes), [genericArgumentType], operand);
                        return call;
                    }
                }
                else
                {
                    var call = BindToMethod(nameof(ICqlOperators.Coalesce), [genericArgumentType], operand);
                    return call;
                }
            }
            throw new ArgumentException("Operands to this method must be generic with a single generic type parameter, e.g. IEnumerable<T>", nameof(operand));

        }

        private Expression Flatten(Expression operand)
        {
            var elementType = TypeResolver.GetListElementType(operand.Type, throwError: true)!;
            if (TypeResolver.ImplementsGenericIEnumerable(elementType))
            {
                var nestedElementType = TypeResolver.GetListElementType(elementType) ?? throw new InvalidOperationException($"'{elementType}' was expected to be a list type.");
                var call = BindToMethod(nameof(ICqlOperators.FlattenList), [nestedElementType], operand);
                return call;
            }
            else if (elementType == typeof(object))
            {
                // This scenario can happen in late-bound property chains
                var call = BindToMethod(nameof(ICqlOperators.FlattenLateBoundList), operand);
                return call;
            }
            else return operand; // flatten is being called on a list that is already flat.
        }

        private Expression Width(Expression operand)
        {
            // This should be disallowed but isn't, so handle it:
            if (operand.Type == typeof(CqlInterval<object>))
                return Expression.Constant(null, typeof(int?));

            return BindToMethodConvertArgs(nameof(ICqlOperators.Width), operand);
        }

        private MethodCallExpression LateBoundProperty(
            Expression source,
            Expression propertyName,
            Expression typeExpression)
        {
            if (typeExpression is ConstantExpression { Value: Type type })
            {
                if (source.Type != typeof(object))
                    source = Expression.TypeAs(source, typeof(object));

                var call = BindToMethod(nameof(ICqlOperators.LateBoundProperty), [type!], source, propertyName);
                return call;
            }
            else throw new ArgumentException("Expected constant type expression", nameof(typeExpression));
        }

        private Expression Interval(
            Expression low,
            Expression high,
            Expression lowClosed,
            Expression highClosed)
        {
            if (low is ConstantExpression { Value: null } && high is ConstantExpression { Value: null })
            {
                if (low.Type == high.Type)
                {
                    return Expression.Constant(null, typeof(CqlInterval<>).MakeGenericType(low.Type));
                }
                else return Expression.Constant(null, typeof(CqlInterval<object>));

            }

            var exactMethod = ICqlOperators_MethodInfos_By_Name[nameof(ICqlOperators.Interval)]
                .FirstOrDefault(m =>
                    m.GetParameters()
                        .Select(p => p.ParameterType)
                        .SequenceEqual([low.Type, high.Type, typeof(bool?), typeof(bool?)]));
            if (exactMethod != null)
            {
                var call = BindToMethod(exactMethod, low, high, lowClosed, highClosed);
                return call;
            }
            else
            {
                var methods =
                    ICqlOperators_MethodInfos_By_Name[nameof(ICqlOperators.Interval)];
                foreach (var method in methods)
                {
                    var methodParameters = method.GetParameters();
                    if (methodParameters.Length == 4)
                    {
                        var lowConversion = CanConvert(low.Type, methodParameters[0].ParameterType);
                        var highConversion = CanConvert(high.Type, methodParameters[1].ParameterType);

                        if (lowConversion == ConversionType.Incompatible
                            || highConversion == ConversionType.Incompatible)
                            continue;
                        low = Convert(low, methodParameters[0].ParameterType, lowConversion);
                        high = Convert(high, methodParameters[1].ParameterType, highConversion);
                        var call = BindToMethod(method, low, high, lowClosed, highClosed);
                        return call;
                    }
                }
            }
            throw new ArgumentException($"No suitable Interval method could be found for {low.Type}", nameof(low));
        }

        /// <summary>
        /// Handles explicit conversions, i.e., the Convert operator
        /// </summary>
        private Expression BindConvert(
            Expression source,
            Expression typeExpression)
        {
            if (typeExpression is ConstantExpression { Value: Type toType })
            {
                var methodName = CqlOperators.ConversionFunctionName(source.Type, toType);
                if (methodName != null)
                {
                    var call = BindToMethod(methodName, source);
                    return call;
                }
                else
                {
                    var conversion = CanConvert(source.Type, toType);
                    if (conversion != ConversionType.Incompatible)
                    {
                        var convert = Convert(source, toType, conversion);
                        return convert;
                    }
                    else throw new ArgumentException($"Cannot convert {source.Type} to {toType}", nameof(source));
                }
            }
            else throw new ArgumentException("Expected constant type expression", nameof(typeExpression));
        }


        private MethodCallExpression Retrieve(
            Expression typeExpression,
            Expression valueSetOrCodes,
            Expression codePropertyExpression)
        {
            if (typeExpression is ConstantExpression ce && ce.Type == typeof(Type))
            {
                if (ce.Value is Type type
                    && codePropertyExpression is ConstantExpression cpe
                    && cpe.Type == typeof(PropertyInfo))
                {
                    if (cpe.Value is PropertyInfo pi)
                    {
                        var declaringType = pi!.DeclaringType;
                        var propName = pi.Name;
                        var method = typeof(Type).GetMethod(nameof(Type.GetProperty), [typeof(string)])!;
                        var typeOf = Expression.Constant(declaringType);
                        codePropertyExpression = Expression.Call(typeOf, method, Expression.Constant(propName));
                    }

                    return Retrieve(type, valueSetOrCodes, codePropertyExpression);
                }
                else throw new ArgumentException("Second parameter to Retrieve is expected to be a constant PropertyInfo", nameof(codePropertyExpression));
            }
            else throw new ArgumentException("First parameter to Retrieve is expected to be a constant Type", nameof(typeExpression));
        }

        protected MethodCallExpression Retrieve(
            Type resourceType,
            Expression codes,
            Expression codeProperty)
        {
            MethodInfo? forType = null;
            if (codes.Type == typeof(CqlValueSet))
            {
                var method = typeof(ICqlOperators).GetMethod(nameof(ICqlOperators.RetrieveByValueSet))!;
                forType = method.MakeGenericMethod(resourceType);
            }
            else if (TypeResolver.ImplementsGenericIEnumerable(codes.Type))
            {
                var elementType = TypeResolver.GetListElementType(codes.Type, true)!;
                if (elementType == typeof(CqlCode))
                {
                    var method = typeof(ICqlOperators).GetMethod(nameof(ICqlOperators.RetrieveByCodes))!;
                    forType = method.MakeGenericMethod(resourceType);
                }
                // cql-to-elm blindly calls ToList when an expression ref is used
                // for expressions like:
                // [Source : "Definition returning List<Code>"]
                // this ends up turning the codes expression into a List<List<Code>>
                else if (TypeResolver.ImplementsGenericIEnumerable(elementType) && TypeResolver.GetListElementType(elementType) == typeof(CqlCode))
                {
                    // call Flatten.
                    codes = Flatten(codes);
                    var method = typeof(ICqlOperators).GetMethod(nameof(ICqlOperators.RetrieveByCodes))!;
                    forType = method.MakeGenericMethod(resourceType);
                }
                else throw new ArgumentException($"Retrieve statements with an ExpressionRef in the terminology position must be list of {nameof(CqlCode)} or a list of lists of {nameof(CqlCode)}.  Instead, the list's element type is {elementType.Name}.", nameof(codes));
            }
            else
                throw new ArgumentException($"Retrieve statements can only accept terminology expressions whose type is {nameof(CqlValueSet)} or {nameof(IEnumerable<CqlCode>)}.  The expression provided has a type of {codes.Type.FullName}", nameof(codes));

            var call = BindToMethod(forType, codes, codeProperty);
            return call;
        }

        private MethodCallExpression Select(
            Expression source,
            Expression lambda)
        {
            if (lambda is LambdaExpression lambdaExpr)
            {
                var sourceType = TypeResolver.GetListElementType(source.Type) ?? throw new InvalidOperationException($"'{source.Type}' was expected to be a list type.");
                var resultType = lambdaExpr.ReturnType;
                var call = BindToMethod(nameof(ICqlOperators.SelectOrNull), [sourceType, resultType], source, lambda);
                return call;
            }
            else throw new ArgumentException("Source is not generic", nameof(source));
        }
        private MethodCallExpression Where(
            Expression source,
            Expression lambda)
        {
            if (lambda is LambdaExpression lamdaExpr)
            {
                var sourceType = TypeResolver.GetListElementType(source.Type) ?? throw new InvalidOperationException($"'{source.Type}' was expected to be a list type.");
                var call = BindToMethod(nameof(ICqlOperators.WhereOrNull), [sourceType], source, lambda);
                return call;
            }
            else throw new ArgumentException("Source is not generic", nameof(source));
        }

        private MethodCallExpression SelectMany(
            Expression source,
            Expression collectionSelectorLambda)
        {
            if (collectionSelectorLambda is LambdaExpression collectionSelector)
            {
                var firstGenericArgument = TypeResolver.GetListElementType(source.Type) ?? throw new InvalidOperationException($"{source.Type} was expected to be a list type.");
                if (TypeResolver.ImplementsGenericIEnumerable(collectionSelector.ReturnType))
                {
                    var secondGenericArgument = TypeResolver.GetListElementType(collectionSelector.ReturnType) ?? throw new InvalidOperationException($"{collectionSelector.Type} was expected to be a list type.");
                    var call = BindToMethod(nameof(ICqlOperators.SelectManyOrNull), [firstGenericArgument, secondGenericArgument], source, collectionSelector);
                    return call;
                }
                else throw new ArgumentException("Collection selector does not return an IEnumerable", nameof(collectionSelectorLambda));
            }
            else throw new ArgumentException("Source is not generic", nameof(source));
        }

        private MethodCallExpression SelectManyResults(
            Expression source,
            Expression collectionSelectorLambda,
            Expression resultSelectorLambda)
        {
            if (collectionSelectorLambda is not LambdaExpression collectionSelector)
                throw new ArgumentException("Source is not generic", nameof(source));

            var firstGenericArgument = TypeResolver.GetListElementType(source.Type) ??
                                       throw new InvalidOperationException(
                                           $"{source.Type} was expected to be a list type.");
            if (!TypeResolver.ImplementsGenericIEnumerable(collectionSelector.ReturnType))
                throw new ArgumentException("Collection lambda does not return an IEnumerable",
                    nameof(collectionSelectorLambda));

            var secondGenericArgument = TypeResolver.GetListElementType(collectionSelector.ReturnType) ??
                                        throw new InvalidOperationException(
                                            $"{collectionSelector.Type} was expected to be a list type.");
            if (resultSelectorLambda is not LambdaExpression resultSelector)
                throw new ArgumentException("Result expression is not a lambda", nameof(resultSelectorLambda));

            var call = BindToMethod(
                nameof(ICqlOperators.SelectManyResultsOrNull),
                [firstGenericArgument, secondGenericArgument, resultSelector.ReturnType], source,
                collectionSelector, resultSelector);
            return call;
        }

        private bool TryConvert(
            Type from, Type to,
            Expression fromExpr, [NotNullWhen(true)]out Expression? toExpr)
        {
            if (from == to)
            {
                toExpr = fromExpr;
                return true;
            }

            if (to.IsAssignableFrom(from))
            {
                toExpr = Expression.TypeAs(fromExpr, to);
                return true;
            }

            if (TypeConverter?.CanConvert(from, to) == true)
            {
                toExpr = BindToMethod(nameof(ICqlOperators.Convert), [to], Expression.TypeAs(fromExpr, typeof(object)));
                return true;
            }

            toExpr = null;
            return false;
        }

        private ConversionType CanConvert(
            Type from,
            Type to)
        {
            if (from == to)
                return ConversionType.SameType;
            else if (to.IsAssignableFrom(from))
                return ConversionType.Assignable;
            else if (TypeConverter != null)
            {
                if (TypeConverter.CanConvert(from, to))
                    return ConversionType.Convertible;
            }
            return ConversionType.Incompatible;
        }

        private Expression Convert(
            Expression source,
            Type destinationType,
            ConversionType conversion)
        {
            return conversion switch
            {
                ConversionType.SameType => source,
                ConversionType.Assignable => Expression.TypeAs(source, destinationType),
                ConversionType.Convertible => BindToMethod(nameof(ICqlOperators.Convert), [destinationType], Expression.TypeAs(source, typeof(object))),
                _ => throw new ArgumentException($"Cannot convert source to {destinationType}", nameof(source)),
            };
        }

        protected static bool IsInterval(Type type)
        {
            if (type.IsGenericType)
            {
                var gtd = type.GetGenericTypeDefinition();
                if (gtd == typeof(CqlInterval<>))
                    return true;
            }
            return false;
        }

        private enum ConversionType
        {
            SameType,
            Assignable,
            Convertible,
            Incompatible
        }
    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member