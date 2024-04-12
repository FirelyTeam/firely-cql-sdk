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
                CqlOperator.IntervalIntersect                => BindToMethod(nameof(ICqlOperators.IntervalIntersect), BindOptions.ConvertArgumentsGeneric, parameters[..2]),
                CqlOperator.IntervalProperlyIncludesElement when parameters.Length == 2
                                                             => BindToMethod(nameof(ICqlOperators.IntervalProperlyIncludesElement), BindOptions.ConvertArgumentsGeneric, parameters[..2]),
                CqlOperator.IntervalUnion                    => BindToMethod(nameof(ICqlOperators.IntervalUnion), BindOptions.ConvertArgumentsGeneric, parameters[..2]),
                CqlOperator.ListContains                     => BindToMethod(nameof(ICqlOperators.ListContains), BindOptions.ConvertArgumentsGeneric, parameters[..2]),
                CqlOperator.ListElementAt                    => BindToMethod(nameof(ICqlOperators.ListElementAt), BindOptions.ConvertArgumentsGeneric, parameters[..2]),
                CqlOperator.ListEqual                        => BindToMethod(nameof(ICqlOperators.ListEqual), BindOptions.ConvertArgumentsGeneric, parameters[..2]),
                CqlOperator.ListEquivalent                   => BindToMethod(nameof(ICqlOperators.ListEquivalent), BindOptions.ConvertArgumentsGeneric, parameters[..2]),
                CqlOperator.ListExcept                       => BindToMethod(nameof(ICqlOperators.ListExcept), BindOptions.ConvertArgumentsGeneric, parameters[..2]),
                CqlOperator.ListIncludesElement              => BindToMethod(nameof(ICqlOperators.ListIncludesElement), BindOptions.ConvertArgumentsGeneric, parameters[..2]),
                CqlOperator.ListIncludesList                 => BindToMethod(nameof(ICqlOperators.ListIncludesList), BindOptions.ConvertArgumentsGeneric, parameters[..2]),
                CqlOperator.ListIndexOf                      => BindToMethod(nameof(ICqlOperators.ListIndexOf), BindOptions.ConvertArgumentsGeneric, parameters[..2]),
                CqlOperator.ListIntersect                    => BindToMethod(nameof(ICqlOperators.ListIntersect), BindOptions.ConvertArgumentsGeneric, parameters[..2]),
                CqlOperator.ListProperlyIncludesElement      => BindToMethod(nameof(ICqlOperators.ListProperlyIncludesElement), BindOptions.ConvertArgumentsGeneric, parameters[..2]),
                CqlOperator.ListProperlyIncludesList         => BindToMethod(nameof(ICqlOperators.ListProperlyIncludesList), BindOptions.ConvertArgumentsGeneric, parameters[..2]),
                CqlOperator.ListSort                         => BindToMethod(nameof(ICqlOperators.ListSort), BindOptions.ConvertArgumentsGeneric, parameters[..2]),

                CqlOperator.Add                              => BindToMethod(nameof(ICqlOperators.Add), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.And                              => BindToMethod(nameof(ICqlOperators.And), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.CodeInValueSet                   => BindToMethod(nameof(ICqlOperators.CodeInValueSet), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.CodesInValueSet                  => BindToMethod(nameof(ICqlOperators.CodesInValueSet), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.Collapse                         => BindToMethod(nameof(ICqlOperators.Collapse), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.Combine                          => BindToMethod(nameof(ICqlOperators.Combine), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.DateTimeComponent                => BindToMethod(nameof(ICqlOperators.ComponentFrom), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.Concatenate                      => BindToMethod(nameof(ICqlOperators.Concatenate), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.ConceptInValueSet                => BindToMethod(nameof(ICqlOperators.ConceptInValueSet), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.ConceptsInValueSet               => BindToMethod(nameof(ICqlOperators.ConceptsInValueSet), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.ConvertQuantity                  => BindToMethod(nameof(ICqlOperators.ConvertQuantity), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.Divide                           => BindToMethod(nameof(ICqlOperators.Divide), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.EndsWith                         => BindToMethod(nameof(ICqlOperators.EndsWith), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.EnumEqualsString                 => BindToMethod(nameof(ICqlOperators.EnumEqualsString), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.Equal                            => BindToMethod(nameof(ICqlOperators.Equal), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.Equivalent                       => BindToMethod(nameof(ICqlOperators.Equivalent), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.Greater                          => BindToMethod(nameof(ICqlOperators.Greater), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.GreaterOrEqual                   => BindToMethod(nameof(ICqlOperators.GreaterOrEqual), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.HighBoundary                     => BindToMethod(nameof(ICqlOperators.HighBoundary), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.Implies                          => BindToMethod(nameof(ICqlOperators.Implies), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.IntervalExcept                   => BindToMethod(nameof(ICqlOperators.IntervalExcept), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.LastPositionOf                   => BindToMethod(nameof(ICqlOperators.LastPositionOf), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.Less                             => BindToMethod(nameof(ICqlOperators.Less), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.LessOrEqual                      => BindToMethod(nameof(ICqlOperators.LessOrEqual), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.Log                              => BindToMethod(nameof(ICqlOperators.Log), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.LowBoundary                      => BindToMethod(nameof(ICqlOperators.LowBoundary), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.Matches                          => BindToMethod(nameof(ICqlOperators.Matches), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.Modulo                           => BindToMethod(nameof(ICqlOperators.Modulo), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.Multiply                         => BindToMethod(nameof(ICqlOperators.Multiply), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.Or                               => BindToMethod(nameof(ICqlOperators.Or), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.PositionOf                       => BindToMethod(nameof(ICqlOperators.PositionOf), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.Pow                              => BindToMethod(nameof(ICqlOperators.Power), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.Round                            => BindToMethod(nameof(ICqlOperators.Round), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.Split                            => BindToMethod(nameof(ICqlOperators.Split), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.StartsWith                       => BindToMethod(nameof(ICqlOperators.StartsWith), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.CharAt                           => BindToMethod(nameof(ICqlOperators.StringIndexer), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.StringInValueSet                 => BindToMethod(nameof(ICqlOperators.StringInValueSet), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.StringsInValueSet                => BindToMethod(nameof(ICqlOperators.StringsInValueSet), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.Subtract                         => BindToMethod(nameof(ICqlOperators.Subtract), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.TruncatedDivide                  => BindToMethod(nameof(ICqlOperators.TruncateDivide), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.Xor                              => BindToMethod(nameof(ICqlOperators.Xor), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.After                            => BindToMethod(nameof(ICqlOperators.After), BindOptions.ConvertArguments, parameters[..3]),
                CqlOperator.Before                           => BindToMethod(nameof(ICqlOperators.Before), BindOptions.ConvertArguments, parameters[..3]),
                CqlOperator.DifferenceBetween                => BindToMethod(nameof(ICqlOperators.DifferenceBetween), BindOptions.ConvertArguments, parameters[..3]),
                CqlOperator.DurationBetween                  => BindToMethod(nameof(ICqlOperators.DurationBetween), BindOptions.ConvertArguments, parameters[..3]),
                CqlOperator.IntervalAfterInterval            => BindToMethod(nameof(ICqlOperators.IntervalAfterInterval), BindOptions.ConvertArguments, parameters[..3]),
                CqlOperator.IntervalBeforeInterval           => BindToMethod(nameof(ICqlOperators.IntervalBeforeInterval), BindOptions.ConvertArguments, parameters[..3]),
                CqlOperator.IntervalProperlyIncludesElement  => BindToMethod(nameof(ICqlOperators.IntervalProperlyIncludesElement), BindOptions.ConvertArguments, parameters[..3]),
                CqlOperator.Meets                            => BindToMethod(nameof(ICqlOperators.Meets), BindOptions.ConvertArguments, parameters[..3]),
                CqlOperator.MeetsAfter                       => BindToMethod(nameof(ICqlOperators.MeetsAfter), BindOptions.ConvertArguments, parameters[..3]),
                CqlOperator.MeetsBefore                      => BindToMethod(nameof(ICqlOperators.MeetsBefore), BindOptions.ConvertArguments, parameters[..3]),
                CqlOperator.ReplaceMatches                   => BindToMethod(nameof(ICqlOperators.ReplaceMatches), BindOptions.ConvertArguments, parameters[..3]),
                CqlOperator.SameAs                           => BindToMethod(nameof(ICqlOperators.SameAs), BindOptions.ConvertArguments, parameters[..3]),
                CqlOperator.SameOrAfter                      => BindToMethod(nameof(ICqlOperators.SameOrAfter), BindOptions.ConvertArguments, parameters[..3]),
                CqlOperator.SameOrBefore                     => BindToMethod(nameof(ICqlOperators.SameOrBefore), BindOptions.ConvertArguments, parameters[..3]),
                CqlOperator.Substring                        => BindToMethod(nameof(ICqlOperators.Substring), BindOptions.ConvertArguments, parameters[..3]),
                CqlOperator.Abs                              => BindToMethod(nameof(ICqlOperators.Abs), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.AllTrue                          => BindToMethod(nameof(ICqlOperators.AllTrue), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.AnyTrue                          => BindToMethod(nameof(ICqlOperators.AnyTrue), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.Avg                              => BindToMethod(nameof(ICqlOperators.Avg), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.Ceiling                          => BindToMethod(nameof(ICqlOperators.Ceiling), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.ConvertsToDate                   => BindToMethod(nameof(ICqlOperators.ConvertsToDate), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.ConvertsToDateTime               => BindToMethod(nameof(ICqlOperators.ConvertsToDateTime), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.ConvertsToDecimal                => BindToMethod(nameof(ICqlOperators.ConvertsToDecimal), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.ConvertsToInteger                => BindToMethod(nameof(ICqlOperators.ConvertsToInteger), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.ConvertsToLong                   => BindToMethod(nameof(ICqlOperators.ConvertsToLong), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.ConvertsToQuantity               => BindToMethod(nameof(ICqlOperators.ConvertsToQuantity), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.ConvertsToString                 => BindToMethod(nameof(ICqlOperators.ConvertsToString), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.ConvertsToTime                   => BindToMethod(nameof(ICqlOperators.ConvertsToTime), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.DateComponent                    => BindToMethod(nameof(ICqlOperators.DateFrom), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.Descendents                      => BindToMethod(nameof(ICqlOperators.Descendents), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.IntervalEnd                      => BindToMethod(nameof(ICqlOperators.End), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.Exp                              => BindToMethod(nameof(ICqlOperators.Exp), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.Floor                            => BindToMethod(nameof(ICqlOperators.Floor), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.GeometricMean                    => BindToMethod(nameof(ICqlOperators.GeometricMean), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.IsFalse                          => BindToMethod(nameof(ICqlOperators.IsFalse), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.IsTrue                           => BindToMethod(nameof(ICqlOperators.IsTrue), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.Ln                               => BindToMethod(nameof(ICqlOperators.Ln), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.Lower                            => BindToMethod(nameof(ICqlOperators.Lower), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.Median                           => BindToMethod(nameof(ICqlOperators.Median), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.Negate                           => BindToMethod(nameof(ICqlOperators.Negate), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.Not                              => BindToMethod(nameof(ICqlOperators.Not), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.PopulationStdDev                 => BindToMethod(nameof(ICqlOperators.PopulationStdDev), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.PopulationVariance               => BindToMethod(nameof(ICqlOperators.PopulationVariance), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.Precision                        => BindToMethod(nameof(ICqlOperators.Precision), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.Predecessor                      => BindToMethod(nameof(ICqlOperators.Predecessor), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.Product                          => BindToMethod(nameof(ICqlOperators.Product), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.IntervalStart                    => BindToMethod(nameof(ICqlOperators.Start), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.StdDev                           => BindToMethod(nameof(ICqlOperators.StdDev), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.StringLength                     => BindToMethod(nameof(ICqlOperators.StringLength), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.Successor                        => BindToMethod(nameof(ICqlOperators.Successor), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.Sum                              => BindToMethod(nameof(ICqlOperators.Sum), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.TimeComponent                    => BindToMethod(nameof(ICqlOperators.TimeFrom), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.TimeZoneComponent                => BindToMethod(nameof(ICqlOperators.TimezoneOffsetFrom), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.Truncate                         => BindToMethod(nameof(ICqlOperators.Truncate), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.Upper                            => BindToMethod(nameof(ICqlOperators.Upper), BindOptions.ConvertArguments, parameters[..1]),
                CqlOperator.Variance                         => BindToMethod(nameof(ICqlOperators.Variance), BindOptions.ConvertArguments, parameters[..1]),

                CqlOperator.CalculateAge                     => BindToMethod(nameof(ICqlOperators.CalculateAge), BindOptions.ConvertArguments, parameters[..2]),
                CqlOperator.CalculateAgeAt                   => BindToMethod(nameof(ICqlOperators.CalculateAgeAt), BindOptions.ConvertArguments, parameters[..3]),
                CqlOperator.ElementAfterInterval             => BindToMethod(nameof(ICqlOperators.ElementAfterInterval), BindOptions.ConvertArguments, parameters[..3]),
                CqlOperator.ElementBeforeInterval            => BindToMethod(nameof(ICqlOperators.ElementBeforeInterval), BindOptions.ConvertArguments, parameters[..3]),
                CqlOperator.IntervalAfterElement             => BindToMethod(nameof(ICqlOperators.IntervalAfterElement), BindOptions.ConvertArguments, parameters[..3]),
                CqlOperator.IntervalBeforeElement            => BindToMethod(nameof(ICqlOperators.IntervalBeforeElement), BindOptions.ConvertArguments, parameters[..3]),
                CqlOperator.IntervalContains                 => BindToMethod(nameof(ICqlOperators.IntervalContains), BindOptions.ConvertArguments, parameters[..3]),
                CqlOperator.IntervalSameOrAfter              => BindToMethod(nameof(ICqlOperators.IntervalSameOrAfter), BindOptions.ConvertArguments, parameters[..3]),
                CqlOperator.IntervalSameOrBefore             => BindToMethod(nameof(ICqlOperators.IntervalSameOrBefore), BindOptions.ConvertArguments, parameters[..3]),
                CqlOperator.Overlaps                         => BindToMethod(nameof(ICqlOperators.Overlaps), BindOptions.ConvertArguments, parameters[..3]),
                CqlOperator.OverlapsAfter                    => BindToMethod(nameof(ICqlOperators.OverlapsAfter), BindOptions.ConvertArguments, parameters[..3]),
                CqlOperator.OverlapsBefore                   => BindToMethod(nameof(ICqlOperators.OverlapsBefore), BindOptions.ConvertArguments, parameters[..3]),

                CqlOperator.Convert                          => BindConvert(parameters[0], parameters[1]),

                CqlOperator.InInterval                       => BindToMethod(nameof(ICqlOperators.ElementInInterval), BindOptions.ConvertArgumentsGeneric2ndArg, parameters[..3]),
                CqlOperator.Ends                             => BindToMethod(nameof(ICqlOperators.Ends), BindOptions.ConvertArgumentsGeneric, parameters[..3]),
                CqlOperator.IntervalIncludesElement          => BindToMethod(nameof(ICqlOperators.IntervalIncludesElement), BindOptions.ConvertArgumentsGeneric, parameters[..3]),
                CqlOperator.IntervalIncludesInterval         => BindToMethod(nameof(ICqlOperators.IntervalIncludesInterval), BindOptions.ConvertArgumentsGeneric, parameters[..3]),
                CqlOperator.IntervalProperlyIncludesInterval => BindToMethod(nameof(ICqlOperators.IntervalProperlyIncludesInterval), BindOptions.ConvertArgumentsGeneric, parameters[..3]),
                CqlOperator.IntervalSameAs                   => BindToMethod(nameof(ICqlOperators.IntervalSameAs), BindOptions.ConvertArgumentsGeneric, parameters[..3]),
                CqlOperator.Slice                            => BindToMethod(nameof(ICqlOperators.Slice), BindOptions.ConvertArgumentsGeneric, parameters[..3]),
                CqlOperator.Starts                           => BindToMethod(nameof(ICqlOperators.Starts), BindOptions.ConvertArgumentsGeneric, parameters[..3]),

                CqlOperator.Count                            => BindToMethod(nameof(ICqlOperators.CountOrNull), BindOptions.ConvertArgumentsGeneric, parameters[..1]),
                CqlOperator.Exists                           => BindToMethod(nameof(ICqlOperators.ExistsInList), BindOptions.ConvertArgumentsGeneric, parameters[..1]),
                CqlOperator.First                            => BindToMethod(nameof(ICqlOperators.FirstOfList), BindOptions.ConvertArgumentsGeneric, parameters[..1]),
                CqlOperator.Last                             => BindToMethod(nameof(ICqlOperators.LastOfList), BindOptions.ConvertArgumentsGeneric, parameters[..1]),
                CqlOperator.Distinct                         => BindToMethod(nameof(ICqlOperators.ListDistinct), BindOptions.ConvertArgumentsGeneric, parameters[..1]),
                CqlOperator.ListLength                       => BindToMethod(nameof(ICqlOperators.ListLength), BindOptions.ConvertArgumentsGeneric, parameters[..1]),
                CqlOperator.Tail                             => BindToMethod(nameof(ICqlOperators.ListTail), BindOptions.ConvertArgumentsGeneric, parameters[..1]),
                CqlOperator.MaxElementInList                 => BindToMethod(nameof(ICqlOperators.MaxOrNull), BindOptions.ConvertArgumentsGeneric, parameters[..1]),
                CqlOperator.MinElementInList                 => BindToMethod(nameof(ICqlOperators.MinOrNull), BindOptions.ConvertArgumentsGeneric, parameters[..1]),
                CqlOperator.Mode                             => BindToMethod(nameof(ICqlOperators.Mode), BindOptions.ConvertArgumentsGeneric, parameters[..1]),
                CqlOperator.PointFrom                        => BindToMethod(nameof(ICqlOperators.PointFrom), BindOptions.ConvertArgumentsGeneric, parameters[..1]),
                CqlOperator.Single                           => BindToMethod(nameof(ICqlOperators.SingleOrNull), BindOptions.ConvertArgumentsGeneric, parameters[..1]),

                CqlOperator.Coalesce                         => Coalesce(parameters[0]),
                CqlOperator.Expand                           => Expand(parameters[0], parameters[1]),

                CqlOperator.Aggregate                        => BindToGenericMethod(nameof(ICqlOperators.AggregateOrNull),[TypeResolver.GetListElementType(parameters[0].Type, true)!, parameters[2].Type],parameters[0], parameters[2], parameters[1]), // NOTE: the order here is 0, 2, 1, maybe change the Aggregate method arguments as well?
                CqlOperator.CrossJoin                        => BindToGenericMethod(nameof(ICqlOperators.CrossJoin),parameters.SelectToArray(s => TypeResolver.GetListElementType(s.Type, true)!), parameters),
                CqlOperator.Date                             => BindToMethod(nameof(ICqlOperators.Date), BindOptions.None, parameters),
                CqlOperator.DateTime                         => BindToMethod(nameof(ICqlOperators.DateTime)!, BindOptions.None, parameters),
                CqlOperator.Now                              => BindToMethod(nameof(ICqlOperators.Now), BindOptions.None),
                CqlOperator.Quantity                         => BindToMethod(nameof(ICqlOperators.Quantity), BindOptions.None, parameters[..2]), // Discard the 3rd parameter
                CqlOperator.Time                             => BindToMethod(nameof(ICqlOperators.Time), BindOptions.None, parameters),
                CqlOperator.TimeOfDay                        => BindToMethod(nameof(ICqlOperators.TimeOfDay), BindOptions.None),
                CqlOperator.Today                            => BindToMethod(nameof(ICqlOperators.Today), BindOptions.None),
                CqlOperator.Message                          => BindToGenericMethod(nameof(ICqlOperators.Message), [parameters[0].Type], parameters),
                CqlOperator.ToList                           => BindToGenericMethod(nameof(ICqlOperators.ToList), [parameters[0].Type], parameters),

                // Special cases
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
                var call = BindToGenericMethod(nameof(ICqlOperators.ListSortBy), [elementType], source, lambda, orderConstant);
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
                    return BindToMethod(nameof(ICqlOperators.CodeInList), BindOptions.ConvertArguments, left, right);
                }
            }
            return BindToMethod(nameof(ICqlOperators.InList), BindOptions.ReturnNullOverError | BindOptions.ConvertArgumentsGeneric2ndArg, left, right);
        }

        private Expression ListUnion(
            Expression left,
            Expression right)
        {
            if (left.Type == typeof(IValueSetFacade) && right.Type == typeof(IValueSetFacade))
            {
                return BindToMethod(nameof(ICqlOperators.ValueSetUnion), BindOptions.ConvertArguments, Expression.TypeAs(left, typeof(IEnumerable<CqlCode>)), Expression.TypeAs(right, typeof(IEnumerable<CqlCode>)));
            }
            var leftElementType = TypeResolver.GetListElementType(left.Type);
            if (leftElementType == typeof(CqlCode))
            {
                var rightElementType = TypeResolver.GetListElementType(right.Type);
                if (rightElementType == typeof(CqlCode))
                {
                    return BindToMethod(nameof(ICqlOperators.ValueSetUnion), BindOptions.ConvertArguments, left, right);
                }
            }

            return BindToMethod(nameof(ICqlOperators.ListUnion), BindOptions.ConvertArgumentsGeneric, left, right);
        }

        private Expression ResolveValueSet(Expression expression)
        {
            if (expression is NewExpression @new && @new.Type == typeof(CqlValueSet))
            {
                var call = BindToMethod(nameof(ICqlOperators.ResolveValueSet), BindOptions.None, @new);
                return call;
            }
            else throw new ArgumentException("Expression should be a constant CqlValueSet");
        }

        private Expression Minimum(Expression typeConstant)
        {
            if (typeConstant is ConstantExpression { Value: Type t })
            {
                var call = BindToGenericMethod(nameof(ICqlOperators.Minimum), [t]);
                return call;
            }
            else throw new ArgumentException("Expression should be a constant expression whose type is Type", nameof(typeConstant));
        }

        private Expression Maximum(Expression typeConstant)
        {
            if (typeConstant is ConstantExpression { Value: Type t })
            {
                var call = BindToGenericMethod(nameof(ICqlOperators.Maximum), [t]);
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
                        var call = BindToGenericMethod(nameof(ICqlOperators.CoalesceValueTypes), [underlying], operand);
                        return call;
                    }
                    else
                    {
                        var call = BindToGenericMethod(nameof(ICqlOperators.CoalesceValueTypes), [genericArgumentType], operand);
                        return call;
                    }
                }
                else
                {
                    var call = BindToGenericMethod(nameof(ICqlOperators.Coalesce), [genericArgumentType], operand);
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
                var call = BindToGenericMethod(nameof(ICqlOperators.FlattenList), [nestedElementType], operand);
                return call;
            }
            else if (elementType == typeof(object))
            {
                // This scenario can happen in late-bound property chains
                var call = BindToMethod(nameof(ICqlOperators.FlattenLateBoundList), BindOptions.None, operand);
                return call;
            }
            else return operand; // flatten is being called on a list that is already flat.
        }

        private Expression Width(Expression operand)
        {
            // This should be disallowed but isn't, so handle it:
            if (operand.Type == typeof(CqlInterval<object>))
                return Expression.Constant(null, typeof(int?));

            return BindToMethod(nameof(ICqlOperators.Width), BindOptions.ConvertArguments, operand);
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

                var call = BindToGenericMethod(nameof(ICqlOperators.LateBoundProperty), [type!], source, propertyName);
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
                    var call = BindToMethod(methodName, BindOptions.None, source);
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
                var call = BindToGenericMethod(nameof(ICqlOperators.SelectOrNull), [sourceType, resultType], source, lambda);
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
                var call = BindToGenericMethod(nameof(ICqlOperators.WhereOrNull), [sourceType], source, lambda);
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
                    var call = BindToGenericMethod(nameof(ICqlOperators.SelectManyOrNull), [firstGenericArgument, secondGenericArgument], source, collectionSelector);
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

            var call = BindToGenericMethod(
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
                ConversionType.Convertible => BindToGenericMethod(nameof(ICqlOperators.Convert), [destinationType], Expression.TypeAs(source, typeof(object))),
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