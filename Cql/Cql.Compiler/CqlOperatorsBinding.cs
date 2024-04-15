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
using Hl7.Cql.Runtime;
using System;
using System.Linq.Expressions;
using Hl7.Cql.Abstractions.Infrastructure;
using System.Xml.XPath;

namespace Hl7.Cql.Compiler
{
    /// <summary>
    /// Implements <see cref="OperatorBinding"/> by calling methods in <see cref="CqlOperators"/>.
    /// </summary>
    internal partial class CqlOperatorsBinding : OperatorBinding
    {
        private readonly TypeConverter? _typeConverter;

        private readonly TypeResolver _typeResolver;


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
            _typeConverter = typeConverter;
            _typeResolver = typeResolver;
        }

        /// <inheritdoc />
        public override Expression BindToMethod(
            CqlOperator @operator,
            params Expression[] parameters)
        {
            var result = @operator switch
            {
                // @formatter:off

                // Bindings with Argument Conversions
                CqlOperator.IntervalIntersect                => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalIntersect), parameters),
                CqlOperator.IntervalProperlyIncludesElement when parameters.Length == 2
                                                             => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalProperlyIncludesElement), parameters),
                CqlOperator.IntervalUnion                    => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalUnion), parameters),
                CqlOperator.ListContains                     => BindToMethodConvertArgs(nameof(ICqlOperators.ListContains), parameters),
                CqlOperator.ListElementAt                    => BindToMethodConvertArgs(nameof(ICqlOperators.ListElementAt), parameters),
                CqlOperator.ListEqual                        => BindToMethodConvertArgs(nameof(ICqlOperators.ListEqual), parameters),
                CqlOperator.ListEquivalent                   => BindToMethodConvertArgs(nameof(ICqlOperators.ListEquivalent), parameters),
                CqlOperator.ListExcept                       => BindToMethodConvertArgs(nameof(ICqlOperators.ListExcept), parameters),
                CqlOperator.ListIncludesElement              => BindToMethodConvertArgs(nameof(ICqlOperators.ListIncludesElement), parameters),
                CqlOperator.ListIncludesList                 => BindToMethodConvertArgs(nameof(ICqlOperators.ListIncludesList), parameters),
                CqlOperator.ListIndexOf                      => BindToMethodConvertArgs(nameof(ICqlOperators.ListIndexOf), parameters),
                CqlOperator.ListIntersect                    => BindToMethodConvertArgs(nameof(ICqlOperators.ListIntersect), parameters),
                CqlOperator.ListProperlyIncludesElement      => BindToMethodConvertArgs(nameof(ICqlOperators.ListProperlyIncludesElement), parameters),
                CqlOperator.ListProperlyIncludesList         => BindToMethodConvertArgs(nameof(ICqlOperators.ListProperlyIncludesList), parameters),
                CqlOperator.ListSort                         => BindToMethodConvertArgs(nameof(ICqlOperators.ListSort), parameters),
                CqlOperator.Add                              => BindToMethodConvertArgs(nameof(ICqlOperators.Add), parameters),
                CqlOperator.And                              => BindToMethodConvertArgs(nameof(ICqlOperators.And), parameters),
                CqlOperator.CodeInValueSet                   => BindToMethodConvertArgs(nameof(ICqlOperators.CodeInValueSet), parameters),
                CqlOperator.CodesInValueSet                  => BindToMethodConvertArgs(nameof(ICqlOperators.CodesInValueSet), parameters),
                CqlOperator.Collapse                         => BindToMethodConvertArgs(nameof(ICqlOperators.Collapse), parameters),
                CqlOperator.Combine                          => BindToMethodConvertArgs(nameof(ICqlOperators.Combine), parameters),
                CqlOperator.DateTimeComponent                => BindToMethodConvertArgs(nameof(ICqlOperators.ComponentFrom), parameters),
                CqlOperator.Concatenate                      => BindToMethodConvertArgs(nameof(ICqlOperators.Concatenate), parameters),
                CqlOperator.ConceptInValueSet                => BindToMethodConvertArgs(nameof(ICqlOperators.ConceptInValueSet), parameters),
                CqlOperator.ConceptsInValueSet               => BindToMethodConvertArgs(nameof(ICqlOperators.ConceptsInValueSet), parameters),
                CqlOperator.ConvertQuantity                  => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertQuantity), parameters),
                CqlOperator.Divide                           => BindToMethodConvertArgs(nameof(ICqlOperators.Divide), parameters),
                CqlOperator.EndsWith                         => BindToMethodConvertArgs(nameof(ICqlOperators.EndsWith), parameters),
                CqlOperator.EnumEqualsString                 => BindToMethodConvertArgs(nameof(ICqlOperators.EnumEqualsString), parameters),
                CqlOperator.Equivalent                       => BindToMethodConvertArgs(nameof(ICqlOperators.Equivalent), parameters),
                CqlOperator.Greater                          => BindToMethodConvertArgs(nameof(ICqlOperators.Greater), parameters),
                CqlOperator.GreaterOrEqual                   => BindToMethodConvertArgs(nameof(ICqlOperators.GreaterOrEqual), parameters),
                CqlOperator.HighBoundary                     => BindToMethodConvertArgs(nameof(ICqlOperators.HighBoundary), parameters),
                CqlOperator.Implies                          => BindToMethodConvertArgs(nameof(ICqlOperators.Implies), parameters),
                CqlOperator.IntervalExcept                   => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalExcept), parameters),
                CqlOperator.LastPositionOf                   => BindToMethodConvertArgs(nameof(ICqlOperators.LastPositionOf), parameters),
                CqlOperator.Less                             => BindToMethodConvertArgs(nameof(ICqlOperators.Less), parameters),
                CqlOperator.LessOrEqual                      => BindToMethodConvertArgs(nameof(ICqlOperators.LessOrEqual), parameters),
                CqlOperator.Log                              => BindToMethodConvertArgs(nameof(ICqlOperators.Log), parameters),
                CqlOperator.LowBoundary                      => BindToMethodConvertArgs(nameof(ICqlOperators.LowBoundary), parameters),
                CqlOperator.Matches                          => BindToMethodConvertArgs(nameof(ICqlOperators.Matches), parameters),
                CqlOperator.Modulo                           => BindToMethodConvertArgs(nameof(ICqlOperators.Modulo), parameters),
                CqlOperator.Multiply                         => BindToMethodConvertArgs(nameof(ICqlOperators.Multiply), parameters),
                CqlOperator.Or                               => BindToMethodConvertArgs(nameof(ICqlOperators.Or), parameters),
                CqlOperator.PositionOf                       => BindToMethodConvertArgs(nameof(ICqlOperators.PositionOf), parameters),
                CqlOperator.Pow                              => BindToMethodConvertArgs(nameof(ICqlOperators.Power), parameters),
                CqlOperator.Round                            => BindToMethodConvertArgs(nameof(ICqlOperators.Round), parameters),
                CqlOperator.Split                            => BindToMethodConvertArgs(nameof(ICqlOperators.Split), parameters),
                CqlOperator.StartsWith                       => BindToMethodConvertArgs(nameof(ICqlOperators.StartsWith), parameters),
                CqlOperator.CharAt                           => BindToMethodConvertArgs(nameof(ICqlOperators.StringIndexer), parameters),
                CqlOperator.StringInValueSet                 => BindToMethodConvertArgs(nameof(ICqlOperators.StringInValueSet), parameters),
                CqlOperator.StringsInValueSet                => BindToMethodConvertArgs(nameof(ICqlOperators.StringsInValueSet), parameters),
                CqlOperator.Subtract                         => BindToMethodConvertArgs(nameof(ICqlOperators.Subtract), parameters),
                CqlOperator.TruncatedDivide                  => BindToMethodConvertArgs(nameof(ICqlOperators.TruncateDivide), parameters),
                CqlOperator.Xor                              => BindToMethodConvertArgs(nameof(ICqlOperators.Xor), parameters),
                CqlOperator.After                            => BindToMethodConvertArgs(nameof(ICqlOperators.After), parameters),
                CqlOperator.Before                           => BindToMethodConvertArgs(nameof(ICqlOperators.Before), parameters),
                CqlOperator.DifferenceBetween                => BindToMethodConvertArgs(nameof(ICqlOperators.DifferenceBetween), parameters),
                CqlOperator.DurationBetween                  => BindToMethodConvertArgs(nameof(ICqlOperators.DurationBetween), parameters),
                CqlOperator.IntervalAfterInterval            => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalAfterInterval), parameters),
                CqlOperator.IntervalBeforeInterval           => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalBeforeInterval), parameters),
                CqlOperator.IntervalProperlyIncludesElement  => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalProperlyIncludesElement), parameters),
                CqlOperator.Meets                            => BindToMethodConvertArgs(nameof(ICqlOperators.Meets), parameters),
                CqlOperator.MeetsAfter                       => BindToMethodConvertArgs(nameof(ICqlOperators.MeetsAfter), parameters),
                CqlOperator.MeetsBefore                      => BindToMethodConvertArgs(nameof(ICqlOperators.MeetsBefore), parameters),
                CqlOperator.ReplaceMatches                   => BindToMethodConvertArgs(nameof(ICqlOperators.ReplaceMatches), parameters),
                CqlOperator.SameAs                           => BindToMethodConvertArgs(nameof(ICqlOperators.SameAs), parameters),
                CqlOperator.SameOrAfter                      => BindToMethodConvertArgs(nameof(ICqlOperators.SameOrAfter), parameters),
                CqlOperator.SameOrBefore                     => BindToMethodConvertArgs(nameof(ICqlOperators.SameOrBefore), parameters),
                CqlOperator.Substring                        => BindToMethodConvertArgs(nameof(ICqlOperators.Substring), parameters),
                CqlOperator.Abs                              => BindToMethodConvertArgs(nameof(ICqlOperators.Abs), parameters),
                CqlOperator.AllTrue                          => BindToMethodConvertArgs(nameof(ICqlOperators.AllTrue), parameters),
                CqlOperator.AnyTrue                          => BindToMethodConvertArgs(nameof(ICqlOperators.AnyTrue), parameters),
                CqlOperator.Avg                              => BindToMethodConvertArgs(nameof(ICqlOperators.Avg), parameters),
                CqlOperator.Ceiling                          => BindToMethodConvertArgs(nameof(ICqlOperators.Ceiling), parameters),
                CqlOperator.ConvertsToDate                   => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToDate), parameters),
                CqlOperator.ConvertsToDateTime               => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToDateTime), parameters),
                CqlOperator.ConvertsToDecimal                => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToDecimal), parameters),
                CqlOperator.ConvertsToInteger                => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToInteger), parameters),
                CqlOperator.ConvertsToLong                   => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToLong), parameters),
                CqlOperator.ConvertsToQuantity               => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToQuantity), parameters),
                CqlOperator.ConvertsToString                 => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToString), parameters),
                CqlOperator.ConvertsToTime                   => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToTime), parameters),
                CqlOperator.DateComponent                    => BindToMethodConvertArgs(nameof(ICqlOperators.DateFrom), parameters),
                CqlOperator.Descendents                      => BindToMethodConvertArgs(nameof(ICqlOperators.Descendents), parameters),
                CqlOperator.IntervalEnd                      => BindToMethodConvertArgs(nameof(ICqlOperators.End), parameters),
                CqlOperator.Exp                              => BindToMethodConvertArgs(nameof(ICqlOperators.Exp), parameters),
                CqlOperator.Floor                            => BindToMethodConvertArgs(nameof(ICqlOperators.Floor), parameters),
                CqlOperator.GeometricMean                    => BindToMethodConvertArgs(nameof(ICqlOperators.GeometricMean), parameters),
                CqlOperator.IsFalse                          => BindToMethodConvertArgs(nameof(ICqlOperators.IsFalse), parameters),
                CqlOperator.IsTrue                           => BindToMethodConvertArgs(nameof(ICqlOperators.IsTrue), parameters),
                CqlOperator.Ln                               => BindToMethodConvertArgs(nameof(ICqlOperators.Ln), parameters),
                CqlOperator.Lower                            => BindToMethodConvertArgs(nameof(ICqlOperators.Lower), parameters),
                CqlOperator.Median                           => BindToMethodConvertArgs(nameof(ICqlOperators.Median), parameters),
                CqlOperator.Negate                           => BindToMethodConvertArgs(nameof(ICqlOperators.Negate), parameters),
                CqlOperator.Not                              => BindToMethodConvertArgs(nameof(ICqlOperators.Not), parameters),
                CqlOperator.PopulationStdDev                 => BindToMethodConvertArgs(nameof(ICqlOperators.PopulationStdDev), parameters),
                CqlOperator.PopulationVariance               => BindToMethodConvertArgs(nameof(ICqlOperators.PopulationVariance), parameters),
                CqlOperator.Precision                        => BindToMethodConvertArgs(nameof(ICqlOperators.Precision), parameters),
                CqlOperator.Predecessor                      => BindToMethodConvertArgs(nameof(ICqlOperators.Predecessor), parameters),
                CqlOperator.Product                          => BindToMethodConvertArgs(nameof(ICqlOperators.Product), parameters),
                CqlOperator.IntervalStart                    => BindToMethodConvertArgs(nameof(ICqlOperators.Start), parameters),
                CqlOperator.StdDev                           => BindToMethodConvertArgs(nameof(ICqlOperators.StdDev), parameters),
                CqlOperator.StringLength                     => BindToMethodConvertArgs(nameof(ICqlOperators.StringLength), parameters),
                CqlOperator.Successor                        => BindToMethodConvertArgs(nameof(ICqlOperators.Successor), parameters),
                CqlOperator.Sum                              => BindToMethodConvertArgs(nameof(ICqlOperators.Sum), parameters),
                CqlOperator.TimeComponent                    => BindToMethodConvertArgs(nameof(ICqlOperators.TimeFrom), parameters),
                CqlOperator.TimeZoneComponent                => BindToMethodConvertArgs(nameof(ICqlOperators.TimezoneOffsetFrom), parameters),
                CqlOperator.Truncate                         => BindToMethodConvertArgs(nameof(ICqlOperators.Truncate), parameters),
                CqlOperator.Upper                            => BindToMethodConvertArgs(nameof(ICqlOperators.Upper), parameters),
                CqlOperator.Variance                         => BindToMethodConvertArgs(nameof(ICqlOperators.Variance), parameters),
                CqlOperator.CalculateAge                     => BindToMethodConvertArgs(nameof(ICqlOperators.CalculateAge), parameters),
                CqlOperator.CalculateAgeAt                   => BindToMethodConvertArgs(nameof(ICqlOperators.CalculateAgeAt), parameters),
                CqlOperator.ElementAfterInterval             => BindToMethodConvertArgs(nameof(ICqlOperators.ElementAfterInterval), parameters),
                CqlOperator.ElementBeforeInterval            => BindToMethodConvertArgs(nameof(ICqlOperators.ElementBeforeInterval), parameters),
                CqlOperator.IntervalAfterElement             => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalAfterElement), parameters),
                CqlOperator.IntervalBeforeElement            => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalBeforeElement), parameters),
                CqlOperator.IntervalContains                 => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalContains), parameters),
                CqlOperator.IntervalSameOrAfter              => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalSameOrAfter), parameters),
                CqlOperator.IntervalSameOrBefore             => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalSameOrBefore), parameters),
                CqlOperator.Overlaps                         => BindToMethodConvertArgs(nameof(ICqlOperators.Overlaps), parameters),
                CqlOperator.OverlapsAfter                    => BindToMethodConvertArgs(nameof(ICqlOperators.OverlapsAfter), parameters),
                CqlOperator.OverlapsBefore                   => BindToMethodConvertArgs(nameof(ICqlOperators.OverlapsBefore), parameters),
                CqlOperator.InInterval                       => BindToMethodConvertArgs(nameof(ICqlOperators.ElementInInterval), parameters),
                CqlOperator.Ends                             => BindToMethodConvertArgs(nameof(ICqlOperators.Ends), parameters),
                CqlOperator.IntervalIncludesElement          => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalIncludesElement), parameters),
                CqlOperator.IntervalIncludesInterval         => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalIncludesInterval), parameters),
                CqlOperator.IntervalProperlyIncludesInterval => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalProperlyIncludesInterval), parameters),
                CqlOperator.IntervalSameAs                   => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalSameAs), parameters),
                CqlOperator.Slice                            => BindToMethodConvertArgs(nameof(ICqlOperators.Slice), parameters),
                CqlOperator.Starts                           => BindToMethodConvertArgs(nameof(ICqlOperators.Starts), parameters),
                CqlOperator.Count                            => BindToMethodConvertArgs(nameof(ICqlOperators.CountOrNull), parameters),
                CqlOperator.Exists                           => BindToMethodConvertArgs(nameof(ICqlOperators.ExistsInList), parameters),
                CqlOperator.First                            => BindToMethodConvertArgs(nameof(ICqlOperators.FirstOfList), parameters),
                CqlOperator.Last                             => BindToMethodConvertArgs(nameof(ICqlOperators.LastOfList), parameters),
                CqlOperator.Distinct                         => BindToMethodConvertArgs(nameof(ICqlOperators.ListDistinct), parameters),
                CqlOperator.ListLength                       => BindToMethodConvertArgs(nameof(ICqlOperators.ListLength), parameters),
                CqlOperator.Tail                             => BindToMethodConvertArgs(nameof(ICqlOperators.ListTail), parameters),
                CqlOperator.MaxElementInList                 => BindToMethodConvertArgs(nameof(ICqlOperators.MaxOrNull), parameters),
                CqlOperator.MinElementInList                 => BindToMethodConvertArgs(nameof(ICqlOperators.MinOrNull), parameters),
                CqlOperator.Mode                             => BindToMethodConvertArgs(nameof(ICqlOperators.Mode), parameters),
                CqlOperator.PointFrom                        => BindToMethodConvertArgs(nameof(ICqlOperators.PointFrom), parameters),
                CqlOperator.Single                           => BindToMethodConvertArgs(nameof(ICqlOperators.SingleOrNull), parameters),

                // Direct Bindings
                CqlOperator.Aggregate                        => BindToGenericMethod(methodName:nameof(ICqlOperators.AggregateOrNull),
                                                                    genericTypeArguments:[_typeResolver.GetListElementType(parameters[0].Type, true)!, parameters[2].Type],
                                                                    parameters[0], parameters[2], parameters[1]), // NOTE: the order here is 0, 2, 1, maybe change the Aggregate method arguments as well?
                CqlOperator.CrossJoin                        => BindToGenericMethod(methodName:nameof(ICqlOperators.CrossJoin),
                                                                    genericTypeArguments:parameters.SelectToArray(s => _typeResolver.GetListElementType(s.Type, true)!),
                                                                    parameters),
                CqlOperator.Date                             => BindToMethod(nameof(ICqlOperators.Date), parameters),
                CqlOperator.DateTime                         => BindToMethod(nameof(ICqlOperators.DateTime)!, parameters),
                CqlOperator.Now                              => BindToMethod(nameof(ICqlOperators.Now)),
                CqlOperator.Quantity                         => BindToMethod(nameof(ICqlOperators.Quantity), parameters[..2]), // Discard the 3rd parameter!!
                CqlOperator.Time                             => BindToMethod(nameof(ICqlOperators.Time), parameters),
                CqlOperator.TimeOfDay                        => BindToMethod(nameof(ICqlOperators.TimeOfDay)),
                CqlOperator.Today                            => BindToMethod(nameof(ICqlOperators.Today)),
                CqlOperator.Message                          => BindToGenericMethod(nameof(ICqlOperators.Message), genericTypeArguments:[parameters[0].Type], parameters),
                CqlOperator.ToList                           => BindToGenericMethod(nameof(ICqlOperators.ToList), genericTypeArguments:[parameters[0].Type], parameters),

                // Special cases
                CqlOperator.Equal                            => Equal(parameters[0], parameters[1]),
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

        /// <inheritdoc />
        public override Expression ConvertToType(Expression expression, Type type) =>
            TryConvert(expression, type, out var convertedExpression)
                ? convertedExpression
                : expression;
    }
}
