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
                CqlOperator.Aggregate                        => BindToMethod(
                                                                  nameof(ICqlOperators.AggregateOrNull),
                                                                  [TypeResolver.GetListElementType(parameters[0].Type, true)!, parameters[2].Type],
                                                                  parameters[0], parameters[2], parameters[1]),

                CqlOperator.IntervalIntersect                => BindBinaryGenericOperator(nameof(ICqlOperators.IntervalIntersect), parameters[0], parameters[1]),
                CqlOperator.IntervalProperlyIncludesElement when parameters.Length == 2
                    => BindBinaryGenericOperator(nameof(ICqlOperators.IntervalProperlyIncludesElement), parameters[0], parameters[1]),
                CqlOperator.IntervalUnion                    => BindBinaryGenericOperator(nameof(ICqlOperators.IntervalUnion), parameters[0], parameters[1]),
                CqlOperator.ListContains                     => BindBinaryGenericOperator(nameof(ICqlOperators.ListContains), parameters[0], parameters[1]),
                CqlOperator.ListElementAt                    => BindBinaryGenericOperator(nameof(ICqlOperators.ListElementAt), parameters[0], parameters[1]),
                CqlOperator.ListEqual                        => BindBinaryGenericOperator(nameof(ICqlOperators.ListEqual), parameters[0], parameters[1]),
                CqlOperator.ListEquivalent                   => BindBinaryGenericOperator(nameof(ICqlOperators.ListEquivalent), parameters[0], parameters[1]),
                CqlOperator.ListExcept                       => BindBinaryGenericOperator(nameof(ICqlOperators.ListExcept), parameters[0], parameters[1]),
                CqlOperator.ListIncludesElement              => BindBinaryGenericOperator(nameof(ICqlOperators.ListIncludesElement), parameters[0], parameters[1]),
                CqlOperator.ListIncludesList                 => BindBinaryGenericOperator(nameof(ICqlOperators.ListIncludesList), parameters[0], parameters[1]),
                CqlOperator.ListIndexOf                      => BindBinaryGenericOperator(nameof(ICqlOperators.ListIndexOf), parameters[0], parameters[1]),
                CqlOperator.ListIntersect                    => BindBinaryGenericOperator(nameof(ICqlOperators.ListIntersect), parameters[0], parameters[1]),
                CqlOperator.ListProperlyIncludesElement      => BindBinaryGenericOperator(nameof(ICqlOperators.ListProperlyIncludesElement), parameters[0], parameters[1]),
                CqlOperator.ListProperlyIncludesList         => BindBinaryGenericOperator(nameof(ICqlOperators.ListProperlyIncludesList), parameters[0], parameters[1]),
                CqlOperator.ListSort                         => BindBinaryGenericOperator(@operator.ToString(), parameters[0], parameters[1]),

                CqlOperator.Add                              => ConvertParametersThenBindMethod(nameof(ICqlOperators.Add), parameters[0], parameters[1]),
                CqlOperator.And                              => ConvertParametersThenBindMethod(nameof(ICqlOperators.And), parameters[0], parameters[1]),
                CqlOperator.CodeInValueSet                   => ConvertParametersThenBindMethod(nameof(ICqlOperators.CodeInValueSet), parameters[0], parameters[1]),
                CqlOperator.CodesInValueSet                  => ConvertParametersThenBindMethod(nameof(ICqlOperators.CodesInValueSet), parameters[0], parameters[1]),
                CqlOperator.Collapse                         => ConvertParametersThenBindMethod(nameof(ICqlOperators.Collapse), parameters[0], parameters[1]),
                CqlOperator.Combine                          => ConvertParametersThenBindMethod(nameof(ICqlOperators.Combine), parameters[0], parameters[1]),
                CqlOperator.DateTimeComponent                => ConvertParametersThenBindMethod(nameof(ICqlOperators.ComponentFrom), parameters[0], parameters[1]),
                CqlOperator.Concatenate                      => ConvertParametersThenBindMethod(nameof(ICqlOperators.Concatenate), parameters[0], parameters[1]),
                CqlOperator.ConceptInValueSet                => ConvertParametersThenBindMethod(nameof(ICqlOperators.ConceptInValueSet), parameters[0], parameters[1]),
                CqlOperator.ConceptsInValueSet               => ConvertParametersThenBindMethod(nameof(ICqlOperators.ConceptsInValueSet), parameters[0], parameters[1]),
                CqlOperator.ConvertQuantity                  => ConvertParametersThenBindMethod(nameof(ICqlOperators.ConvertQuantity), parameters[0], parameters[1]),
                CqlOperator.Divide                           => ConvertParametersThenBindMethod(nameof(ICqlOperators.Divide), parameters[0], parameters[1]),
                CqlOperator.EndsWith                         => ConvertParametersThenBindMethod(nameof(ICqlOperators.EndsWith), parameters[0], parameters[1]),
                CqlOperator.EnumEqualsString                 => ConvertParametersThenBindMethod(nameof(ICqlOperators.EnumEqualsString), parameters[0], parameters[1]),
                CqlOperator.Equal                            => ConvertParametersThenBindMethod(nameof(ICqlOperators.Equal), parameters[0], parameters[1]),
                CqlOperator.Equivalent                       => ConvertParametersThenBindMethod(nameof(ICqlOperators.Equivalent), parameters[0], parameters[1]),
                CqlOperator.Greater                          => ConvertParametersThenBindMethod(nameof(ICqlOperators.Greater), parameters[0], parameters[1]),
                CqlOperator.GreaterOrEqual                   => ConvertParametersThenBindMethod(nameof(ICqlOperators.GreaterOrEqual), parameters[0], parameters[1]),
                CqlOperator.HighBoundary                     => ConvertParametersThenBindMethod(nameof(ICqlOperators.HighBoundary), parameters[0], parameters[1]),
                CqlOperator.Implies                          => ConvertParametersThenBindMethod(nameof(ICqlOperators.Implies), parameters[0], parameters[1]),
                CqlOperator.IntervalExcept                   => ConvertParametersThenBindMethod(nameof(ICqlOperators.IntervalExcept), parameters[0], parameters[1]),
                CqlOperator.LastPositionOf                   => ConvertParametersThenBindMethod(nameof(ICqlOperators.LastPositionOf), parameters[0], parameters[1]),
                CqlOperator.Less                             => ConvertParametersThenBindMethod(nameof(ICqlOperators.Less), parameters[0], parameters[1]),
                CqlOperator.LessOrEqual                      => ConvertParametersThenBindMethod(nameof(ICqlOperators.LessOrEqual), parameters[0], parameters[1]),
                CqlOperator.Log                              => ConvertParametersThenBindMethod(nameof(ICqlOperators.Log), parameters[0], parameters[1]),
                CqlOperator.LowBoundary                      => ConvertParametersThenBindMethod(nameof(ICqlOperators.LowBoundary), parameters[0], parameters[1]),
                CqlOperator.Matches                          => ConvertParametersThenBindMethod(nameof(ICqlOperators.Matches), parameters[0], parameters[1]),
                CqlOperator.Modulo                           => ConvertParametersThenBindMethod(nameof(ICqlOperators.Modulo), parameters[0], parameters[1]),
                CqlOperator.Multiply                         => ConvertParametersThenBindMethod(nameof(ICqlOperators.Multiply), parameters[0], parameters[1]),
                CqlOperator.Or                               => ConvertParametersThenBindMethod(nameof(ICqlOperators.Or), parameters[0], parameters[1]),
                CqlOperator.PositionOf                       => ConvertParametersThenBindMethod(nameof(ICqlOperators.PositionOf), parameters[0], parameters[1]),
                CqlOperator.Pow                              => ConvertParametersThenBindMethod(nameof(ICqlOperators.Power), parameters[0], parameters[1]),
                CqlOperator.Round                            => ConvertParametersThenBindMethod(nameof(ICqlOperators.Round), parameters[0], parameters[1]),
                CqlOperator.Split                            => ConvertParametersThenBindMethod(nameof(ICqlOperators.Split), parameters[0], parameters[1]),
                CqlOperator.StartsWith                       => ConvertParametersThenBindMethod(nameof(ICqlOperators.StartsWith), parameters[0], parameters[1]),
                CqlOperator.CharAt                           => ConvertParametersThenBindMethod(nameof(ICqlOperators.StringIndexer), parameters[0], parameters[1]),
                CqlOperator.StringInValueSet                 => ConvertParametersThenBindMethod(nameof(ICqlOperators.StringInValueSet), parameters[0], parameters[1]),
                CqlOperator.StringsInValueSet                => ConvertParametersThenBindMethod(nameof(ICqlOperators.StringsInValueSet), parameters[0], parameters[1]),
                CqlOperator.Subtract                         => ConvertParametersThenBindMethod(nameof(ICqlOperators.Subtract), parameters[0], parameters[1]),
                CqlOperator.TruncatedDivide                  => ConvertParametersThenBindMethod(nameof(ICqlOperators.TruncateDivide), parameters[0], parameters[1]),
                CqlOperator.Xor                              => ConvertParametersThenBindMethod(nameof(ICqlOperators.Xor), parameters[0], parameters[1]),
                CqlOperator.CalculateAgeAt                   => BindBinaryOperatorWithPrecision(nameof(ICqlOperators.CalculateAgeAt), parameters[0], parameters[1], parameters[2]),
                CqlOperator.ElementAfterInterval             => BindBinaryOperatorWithPrecision(nameof(ICqlOperators.ElementAfterInterval), parameters[0], parameters[1], parameters[2]),
                CqlOperator.ElementBeforeInterval            => BindBinaryOperatorWithPrecision(nameof(ICqlOperators.ElementBeforeInterval), parameters[0], parameters[1], parameters[2]),
                CqlOperator.IntervalAfterElement             => BindBinaryOperatorWithPrecision(nameof(ICqlOperators.IntervalAfterElement), parameters[0], parameters[1], parameters[2]),
                CqlOperator.IntervalBeforeElement            => BindBinaryOperatorWithPrecision(nameof(ICqlOperators.IntervalBeforeElement), parameters[0], parameters[1], parameters[2]),
                CqlOperator.IntervalContains                 => BindBinaryOperatorWithPrecision(nameof(ICqlOperators.IntervalContains), parameters[0], parameters[1], parameters[2]),
                CqlOperator.IntervalSameOrAfter              => BindBinaryOperatorWithPrecision(nameof(ICqlOperators.IntervalSameOrAfter), parameters[0], parameters[1], parameters[2]),
                CqlOperator.IntervalSameOrBefore             => BindBinaryOperatorWithPrecision(nameof(ICqlOperators.IntervalSameOrBefore), parameters[0], parameters[1], parameters[2]),
                CqlOperator.Overlaps                         => BindBinaryOperatorWithPrecision(nameof(ICqlOperators.Overlaps), parameters[0], parameters[1], parameters[2]),
                CqlOperator.OverlapsAfter                    => BindBinaryOperatorWithPrecision(nameof(ICqlOperators.OverlapsAfter), parameters[0], parameters[1], parameters[2]),
                CqlOperator.OverlapsBefore                   => BindBinaryOperatorWithPrecision(nameof(ICqlOperators.OverlapsBefore), parameters[0], parameters[1], parameters[2]),

                CqlOperator.Convert                          => BindConvert(parameters[0], parameters[1]),

                CqlOperator.InInterval                       => BindTernaryGenericOperator(nameof(ICqlOperators.ElementInInterval), parameters[0], parameters[1], parameters[2], true),
                CqlOperator.Ends                             => BindTernaryGenericOperator(nameof(ICqlOperators.Ends), parameters[0], parameters[1], parameters[2]),
                CqlOperator.IntervalIncludesElement          => BindTernaryGenericOperator(nameof(ICqlOperators.IntervalIncludesElement), parameters[0], parameters[1], parameters[2]),
                CqlOperator.IntervalIncludesInterval         => BindTernaryGenericOperator(nameof(ICqlOperators.IntervalIncludesInterval), parameters[0], parameters[1], parameters[2]),
                CqlOperator.IntervalProperlyIncludesInterval => BindTernaryGenericOperator(nameof(ICqlOperators.IntervalProperlyIncludesInterval), parameters[0], parameters[1], parameters[2]),
                CqlOperator.IntervalSameAs                   => BindTernaryGenericOperator(nameof(ICqlOperators.IntervalSameAs), parameters[0], parameters[1], parameters[2]),
                CqlOperator.Slice                            => BindTernaryGenericOperator(nameof(ICqlOperators.Slice), parameters[0], parameters[1], parameters[2]),
                CqlOperator.Starts                           => BindTernaryGenericOperator(nameof(ICqlOperators.Starts), parameters[0], parameters[1], parameters[2]),

                CqlOperator.After                            => ConvertParametersThenBindMethod(nameof(ICqlOperators.After), parameters[0], parameters[1], parameters[2]),
                CqlOperator.Before                           => ConvertParametersThenBindMethod(nameof(ICqlOperators.Before), parameters[0], parameters[1], parameters[2]),
                CqlOperator.DifferenceBetween                => ConvertParametersThenBindMethod(nameof(ICqlOperators.DifferenceBetween), parameters[0], parameters[1], parameters[2]),
                CqlOperator.DurationBetween                  => ConvertParametersThenBindMethod(nameof(ICqlOperators.DurationBetween), parameters[0], parameters[1], parameters[2]),
                CqlOperator.IntervalAfterInterval            => ConvertParametersThenBindMethod(nameof(ICqlOperators.IntervalAfterInterval), parameters[0], parameters[1], parameters[2]),
                CqlOperator.IntervalBeforeInterval           => ConvertParametersThenBindMethod(nameof(ICqlOperators.IntervalBeforeInterval), parameters[0], parameters[1], parameters[2]),
                CqlOperator.IntervalProperlyIncludesElement  => ConvertParametersThenBindMethod(nameof(ICqlOperators.IntervalProperlyIncludesElement), parameters[0], parameters[1], parameters[2]),
                CqlOperator.Meets                            => ConvertParametersThenBindMethod(nameof(ICqlOperators.Meets), parameters[0], parameters[1], parameters[2]),
                CqlOperator.MeetsAfter                       => ConvertParametersThenBindMethod(nameof(ICqlOperators.MeetsAfter), parameters[0], parameters[1], parameters[2]),
                CqlOperator.MeetsBefore                      => ConvertParametersThenBindMethod(nameof(ICqlOperators.MeetsBefore), parameters[0], parameters[1], parameters[2]),
                CqlOperator.ReplaceMatches                   => ConvertParametersThenBindMethod(nameof(ICqlOperators.ReplaceMatches), parameters[0], parameters[1], parameters[2]),
                CqlOperator.SameAs                           => ConvertParametersThenBindMethod(nameof(ICqlOperators.SameAs), parameters[0], parameters[1], parameters[2]),
                CqlOperator.SameOrAfter                      => ConvertParametersThenBindMethod(nameof(ICqlOperators.SameOrAfter), parameters[0], parameters[1], parameters[2]),
                CqlOperator.SameOrBefore                     => ConvertParametersThenBindMethod(nameof(ICqlOperators.SameOrBefore), parameters[0], parameters[1], parameters[2]),
                CqlOperator.Substring                        => ConvertParametersThenBindMethod(nameof(ICqlOperators.Substring), parameters[0], parameters[1], parameters[2]),

                CqlOperator.Count                            => BindUnaryGenericOperator(nameof(ICqlOperators.CountOrNull), parameters[0]),
                CqlOperator.Exists                           => BindUnaryGenericOperator(nameof(ICqlOperators.ExistsInList), parameters[0]),
                CqlOperator.First                            => BindUnaryGenericOperator(nameof(ICqlOperators.FirstOfList), parameters[0]),
                CqlOperator.Last                             => BindUnaryGenericOperator(nameof(ICqlOperators.LastOfList), parameters[0]),
                CqlOperator.Distinct                         => BindUnaryGenericOperator(nameof(ICqlOperators.ListDistinct), parameters[0]),
                CqlOperator.ListLength                       => BindUnaryGenericOperator(nameof(ICqlOperators.ListLength), parameters[0]),
                CqlOperator.Tail                             => BindUnaryGenericOperator(nameof(ICqlOperators.ListTail), parameters[0]),
                CqlOperator.MaxElementInList                 => BindUnaryGenericOperator(nameof(ICqlOperators.MaxOrNull), parameters[0]),
                CqlOperator.MinElementInList                 => BindUnaryGenericOperator(nameof(ICqlOperators.MinOrNull), parameters[0]),
                CqlOperator.Mode                             => BindUnaryGenericOperator(nameof(ICqlOperators.Mode), parameters[0]),
                CqlOperator.PointFrom                        => BindUnaryGenericOperator(nameof(ICqlOperators.PointFrom), parameters[0]),
                CqlOperator.Single                           => BindUnaryGenericOperator(nameof(ICqlOperators.SingleOrNull), parameters[0]),

                CqlOperator.Abs                              => ConvertParametersThenBindMethod(nameof(ICqlOperators.Abs), parameters[0]),
                CqlOperator.AllTrue                          => ConvertParametersThenBindMethod(nameof(ICqlOperators.AllTrue), parameters[0]),
                CqlOperator.AnyTrue                          => ConvertParametersThenBindMethod(nameof(ICqlOperators.AnyTrue), parameters[0]),
                CqlOperator.Avg                              => ConvertParametersThenBindMethod(nameof(ICqlOperators.Avg), parameters[0]),
                CqlOperator.Ceiling                          => ConvertParametersThenBindMethod(nameof(ICqlOperators.Ceiling), parameters[0]),
                CqlOperator.ConvertsToDate                   => ConvertParametersThenBindMethod(nameof(ICqlOperators.ConvertsToDate), parameters[0]),
                CqlOperator.ConvertsToDateTime               => ConvertParametersThenBindMethod(nameof(ICqlOperators.ConvertsToDateTime), parameters[0]),
                CqlOperator.ConvertsToDecimal                => ConvertParametersThenBindMethod(nameof(ICqlOperators.ConvertsToDecimal), parameters[0]),
                CqlOperator.ConvertsToInteger                => ConvertParametersThenBindMethod(nameof(ICqlOperators.ConvertsToInteger), parameters[0]),
                CqlOperator.ConvertsToLong                   => ConvertParametersThenBindMethod(nameof(ICqlOperators.ConvertsToLong), parameters[0]),
                CqlOperator.ConvertsToQuantity               => ConvertParametersThenBindMethod(nameof(ICqlOperators.ConvertsToQuantity), parameters[0]),
                CqlOperator.ConvertsToString                 => ConvertParametersThenBindMethod(nameof(ICqlOperators.ConvertsToString), parameters[0]),
                CqlOperator.ConvertsToTime                   => ConvertParametersThenBindMethod(nameof(ICqlOperators.ConvertsToTime), parameters[0]),
                CqlOperator.DateComponent                    => ConvertParametersThenBindMethod(nameof(ICqlOperators.DateFrom), parameters[0]),
                CqlOperator.Descendents                      => ConvertParametersThenBindMethod(nameof(ICqlOperators.Descendents), parameters[0]),
                CqlOperator.IntervalEnd                      => ConvertParametersThenBindMethod(nameof(ICqlOperators.End), parameters[0]),
                CqlOperator.Exp                              => ConvertParametersThenBindMethod(nameof(ICqlOperators.Exp), parameters[0]),
                CqlOperator.Floor                            => ConvertParametersThenBindMethod(nameof(ICqlOperators.Floor), parameters[0]),
                CqlOperator.GeometricMean                    => ConvertParametersThenBindMethod(nameof(ICqlOperators.GeometricMean), parameters[0]),
                CqlOperator.IsFalse                          => ConvertParametersThenBindMethod(nameof(ICqlOperators.IsFalse), parameters[0]),
                CqlOperator.IsTrue                           => ConvertParametersThenBindMethod(nameof(ICqlOperators.IsTrue), parameters[0]),
                CqlOperator.Ln                               => ConvertParametersThenBindMethod(nameof(ICqlOperators.Ln), parameters[0]),
                CqlOperator.Lower                            => ConvertParametersThenBindMethod(nameof(ICqlOperators.Lower), parameters[0]),
                CqlOperator.Median                           => ConvertParametersThenBindMethod(nameof(ICqlOperators.Median), parameters[0]),
                CqlOperator.Negate                           => ConvertParametersThenBindMethod(nameof(ICqlOperators.Negate), parameters[0]),
                CqlOperator.Not                              => ConvertParametersThenBindMethod(nameof(ICqlOperators.Not), parameters[0]),
                CqlOperator.PopulationStdDev                 => ConvertParametersThenBindMethod(nameof(ICqlOperators.PopulationStdDev), parameters[0]),
                CqlOperator.PopulationVariance               => ConvertParametersThenBindMethod(nameof(ICqlOperators.PopulationVariance), parameters[0]),
                CqlOperator.Precision                        => ConvertParametersThenBindMethod(nameof(ICqlOperators.Precision), parameters[0]),
                CqlOperator.Predecessor                      => ConvertParametersThenBindMethod(nameof(ICqlOperators.Predecessor), parameters[0]),
                CqlOperator.Product                          => ConvertParametersThenBindMethod(nameof(ICqlOperators.Product), parameters[0]),
                CqlOperator.IntervalStart                    => ConvertParametersThenBindMethod(nameof(ICqlOperators.Start), parameters[0]),
                CqlOperator.StdDev                           => ConvertParametersThenBindMethod(nameof(ICqlOperators.StdDev), parameters[0]),
                CqlOperator.StringLength                     => ConvertParametersThenBindMethod(nameof(ICqlOperators.StringLength), parameters[0]),
                CqlOperator.Successor                        => ConvertParametersThenBindMethod(nameof(ICqlOperators.Successor), parameters[0]),
                CqlOperator.Sum                              => ConvertParametersThenBindMethod(nameof(ICqlOperators.Sum), parameters[0]),
                CqlOperator.TimeComponent                    => ConvertParametersThenBindMethod(nameof(ICqlOperators.TimeFrom), parameters[0]),
                CqlOperator.TimeZoneComponent                => ConvertParametersThenBindMethod(nameof(ICqlOperators.TimezoneOffsetFrom), parameters[0]),
                CqlOperator.Truncate                         => ConvertParametersThenBindMethod(nameof(ICqlOperators.Truncate), parameters[0]),
                CqlOperator.Upper                            => ConvertParametersThenBindMethod(nameof(ICqlOperators.Upper), parameters[0]),
                CqlOperator.Variance                         => ConvertParametersThenBindMethod(nameof(ICqlOperators.Variance), parameters[0]),

                CqlOperator.CalculateAge                     => BindUnaryOperatorWithPrecision(nameof(ICqlOperators.CalculateAge), parameters[0], parameters[1]),
                CqlOperator.Coalesce                         => Coalesce(parameters[0]),
                CqlOperator.CrossJoin                        => BindToMethod(
                                                                   nameof(ICqlOperators.CrossJoin),
                                                                   parameters.SelectToArray(s => TypeResolver.GetListElementType(s.Type, true)!),
                                                                   parameters),
                CqlOperator.Expand                           => Expand(parameters[0], parameters[1]),

                CqlOperator.Date                             => BindToMethod(nameof(ICqlOperators.Date), parameters),
                CqlOperator.DateTime                         => BindToMethod(nameof(ICqlOperators.DateTime)!, parameters),
                CqlOperator.Now                              => BindToMethod(nameof(ICqlOperators.Now)),
                CqlOperator.Quantity                         => BindToMethod(nameof(ICqlOperators.Quantity), parameters[..2]), // Dont need the 3rd parameter
                CqlOperator.Time                             => BindToMethod(nameof(ICqlOperators.Time), parameters),
                CqlOperator.TimeOfDay                        => BindToMethod(nameof(ICqlOperators.TimeOfDay)),
                CqlOperator.Today                            => BindToMethod(nameof(ICqlOperators.Today)),
                CqlOperator.Flatten                          => Flatten(parameters[0]),
                CqlOperator.InList                           => InList(parameters[0], parameters[1]),
                CqlOperator.Interval                         => Interval(parameters[0], parameters[1], parameters[2], parameters[3]),
                CqlOperator.LateBoundProperty                => LateBoundProperty(parameters[0], parameters[1], parameters[2]),
                CqlOperator.ListUnion                        => ListUnion(parameters[0], parameters[1]),
                CqlOperator.MaximumValue                     => Maximum(parameters[0]),
                CqlOperator.Message                          => BindToMethod(nameof(ICqlOperators.Message), [parameters[0].Type], parameters),
                CqlOperator.MinimumValue                     => Minimum(parameters[0]),
                CqlOperator.ResolveValueSet                  => ResolveValueSet(parameters[0]),
                CqlOperator.Retrieve                         => Retrieve(parameters[0], parameters[1], parameters[2]),
                CqlOperator.Select                           => Select(parameters[0], parameters[1]),
                CqlOperator.SelectMany                       => SelectMany(source: parameters[0], collectionSelectorLambda: parameters[1]),
                CqlOperator.SelectManyResults                => SelectManyResults(source: parameters[0], collectionSelectorLambda: parameters[1], resultSelectorLambda: parameters[2]),
                CqlOperator.SortBy                           => SortBy(parameters[0], parameters[1], parameters[2]),
                CqlOperator.ToList                           => BindToMethod(nameof(ICqlOperators.ToList), [parameters[0].Type], parameters),
                CqlOperator.Where                            => Where(parameters[0], parameters[1]),
                CqlOperator.Width                            => Width(parameters[0]),
                CqlOperator.Ratio
                    or CqlOperator.PropertyOrDefault
                    or _                                         => throw new NotSupportedException($"Operator {Enum.GetName(typeof(CqlOperator), @operator)} is not supported by this binding.")
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
                    var methods = ICqlOperatorsExpressions.ICqlOperators_MethodInfos_By_Name[nameof(ICqlOperators.ExpandList)];
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
                var methods = ICqlOperatorsExpressions.ICqlOperators_MethodInfos_By_Name[nameof(ICqlOperators.ExpandInterval)];
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
                    return ConvertParametersThenBindMethod(nameof(ICqlOperators.CodeInList), left, right);
                }
            }
            return BindBinaryGenericOperatorOrNull(nameof(ICqlOperators.InList), left, right, true);
        }

        private Expression ListUnion(
            Expression left,
            Expression right)
        {
            if (left.Type == typeof(IValueSetFacade) && right.Type == typeof(IValueSetFacade))
            {
                return ConvertParametersThenBindMethod(nameof(ICqlOperators.ValueSetUnion),
                    Expression.TypeAs(left, typeof(IEnumerable<CqlCode>)),
                    Expression.TypeAs(right, typeof(IEnumerable<CqlCode>)));
            }
            var leftElementType = TypeResolver.GetListElementType(left.Type);
            if (leftElementType == typeof(CqlCode))
            {
                var rightElementType = TypeResolver.GetListElementType(right.Type);
                if (rightElementType == typeof(CqlCode))
                {
                    return ConvertParametersThenBindMethod(nameof(ICqlOperators.ValueSetUnion), left, right);
                }
            }

            return BindBinaryGenericOperator(nameof(ICqlOperators.ListUnion), left, right);
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
            else return ConvertParametersThenBindMethod(nameof(ICqlOperators.Width), operand);
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

            var exactMethod = ICqlOperatorsExpressions.ICqlOperators_MethodInfos_By_Name[nameof(ICqlOperators.Interval)]
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
                    ICqlOperatorsExpressions.ICqlOperators_MethodInfos_By_Name[nameof(ICqlOperators.Interval)];
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
                        var method = typeof(Type).GetMethod(nameof(Type.GetProperty), new[] { typeof(string) })!;
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
                ConversionType.Convertible => BindToConvert(destinationType, source),
                _ => throw new ArgumentException($"Cannot convert source to {destinationType}", nameof(source)),
            };
        }

        protected bool IsInterval(Type type)
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