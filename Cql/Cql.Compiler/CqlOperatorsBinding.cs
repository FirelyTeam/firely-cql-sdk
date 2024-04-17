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

namespace Hl7.Cql.Compiler
{
    /// <summary>
    /// Implements <see cref="OperatorsBinder"/> by calling methods in <see cref="CqlOperators"/>.
    /// </summary>
    internal partial class CqlOperatorsBinder : OperatorsBinder
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
        public CqlOperatorsBinder(
            TypeResolver typeResolver,
            TypeConverter? typeConverter = null)
        {
            _typeConverter = typeConverter;
            _typeResolver = typeResolver;
        }

        /// <inheritdoc />
        public override Expression BindToMethod(
            CqlOperator @operator,
            params Expression[] args)
        {
            var result = @operator switch
            {
                // @formatter:off

                // Bindings with Argument Conversions
                CqlOperator.IntervalIntersect                => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalIntersect), args),
                CqlOperator.IntervalProperlyIncludesElement when args.Length == 2
                                                             => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalProperlyIncludesElement), args),
                CqlOperator.IntervalUnion                    => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalUnion), args),
                CqlOperator.ListContains                     => BindToMethodConvertArgs(nameof(ICqlOperators.ListContains), args),
                CqlOperator.ListElementAt                    => BindToMethodConvertArgs(nameof(ICqlOperators.ListElementAt), args),
                CqlOperator.ListEqual                        => BindToMethodConvertArgs(nameof(ICqlOperators.ListEqual), args),
                CqlOperator.ListEquivalent                   => BindToMethodConvertArgs(nameof(ICqlOperators.ListEquivalent), args),
                CqlOperator.ListExcept                       => BindToMethodConvertArgs(nameof(ICqlOperators.ListExcept), args),
                CqlOperator.ListIncludesElement              => BindToMethodConvertArgs(nameof(ICqlOperators.ListIncludesElement), args),
                CqlOperator.ListIncludesList                 => BindToMethodConvertArgs(nameof(ICqlOperators.ListIncludesList), args),
                CqlOperator.ListIndexOf                      => BindToMethodConvertArgs(nameof(ICqlOperators.ListIndexOf), args),
                CqlOperator.ListIntersect                    => BindToMethodConvertArgs(nameof(ICqlOperators.ListIntersect), args),
                CqlOperator.ListProperlyIncludesElement      => BindToMethodConvertArgs(nameof(ICqlOperators.ListProperlyIncludesElement), args),
                CqlOperator.ListProperlyIncludesList         => BindToMethodConvertArgs(nameof(ICqlOperators.ListProperlyIncludesList), args),
                CqlOperator.ListSort                         => BindToMethodConvertArgs(nameof(ICqlOperators.ListSort), args),
                CqlOperator.Add                              => BindToMethodConvertArgs(nameof(ICqlOperators.Add), args),
                CqlOperator.And                              => BindToMethodConvertArgs(nameof(ICqlOperators.And), args),
                CqlOperator.CodeInValueSet                   => BindToMethodConvertArgs(nameof(ICqlOperators.CodeInValueSet), args),
                CqlOperator.CodesInValueSet                  => BindToMethodConvertArgs(nameof(ICqlOperators.CodesInValueSet), args),
                CqlOperator.Collapse                         => BindToMethodConvertArgs(nameof(ICqlOperators.Collapse), args),
                CqlOperator.Combine                          => BindToMethodConvertArgs(nameof(ICqlOperators.Combine), args),
                CqlOperator.DateTimeComponent                => BindToMethodConvertArgs(nameof(ICqlOperators.ComponentFrom), args),
                CqlOperator.Concatenate                      => BindToMethodConvertArgs(nameof(ICqlOperators.Concatenate), args),
                CqlOperator.ConceptInValueSet                => BindToMethodConvertArgs(nameof(ICqlOperators.ConceptInValueSet), args),
                CqlOperator.ConceptsInValueSet               => BindToMethodConvertArgs(nameof(ICqlOperators.ConceptsInValueSet), args),
                CqlOperator.ConvertQuantity                  => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertQuantity), args),
                CqlOperator.Divide                           => BindToMethodConvertArgs(nameof(ICqlOperators.Divide), args),
                CqlOperator.EndsWith                         => BindToMethodConvertArgs(nameof(ICqlOperators.EndsWith), args),
                CqlOperator.EnumEqualsString                 => BindToMethodConvertArgs(nameof(ICqlOperators.EnumEqualsString), args),
                CqlOperator.Equivalent                       => BindToMethodConvertArgs(nameof(ICqlOperators.Equivalent), args),
                CqlOperator.Greater                          => BindToMethodConvertArgs(nameof(ICqlOperators.Greater), args),
                CqlOperator.GreaterOrEqual                   => BindToMethodConvertArgs(nameof(ICqlOperators.GreaterOrEqual), args),
                CqlOperator.HighBoundary                     => BindToMethodConvertArgs(nameof(ICqlOperators.HighBoundary), args),
                CqlOperator.Implies                          => BindToMethodConvertArgs(nameof(ICqlOperators.Implies), args),
                CqlOperator.IntervalExcept                   => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalExcept), args),
                CqlOperator.LastPositionOf                   => BindToMethodConvertArgs(nameof(ICqlOperators.LastPositionOf), args),
                CqlOperator.Less                             => BindToMethodConvertArgs(nameof(ICqlOperators.Less), args),
                CqlOperator.LessOrEqual                      => BindToMethodConvertArgs(nameof(ICqlOperators.LessOrEqual), args),
                CqlOperator.Log                              => BindToMethodConvertArgs(nameof(ICqlOperators.Log), args),
                CqlOperator.LowBoundary                      => BindToMethodConvertArgs(nameof(ICqlOperators.LowBoundary), args),
                CqlOperator.Matches                          => BindToMethodConvertArgs(nameof(ICqlOperators.Matches), args),
                CqlOperator.Modulo                           => BindToMethodConvertArgs(nameof(ICqlOperators.Modulo), args),
                CqlOperator.Multiply                         => BindToMethodConvertArgs(nameof(ICqlOperators.Multiply), args),
                CqlOperator.Or                               => BindToMethodConvertArgs(nameof(ICqlOperators.Or), args),
                CqlOperator.PositionOf                       => BindToMethodConvertArgs(nameof(ICqlOperators.PositionOf), args),
                CqlOperator.Pow                              => BindToMethodConvertArgs(nameof(ICqlOperators.Power), args),
                CqlOperator.Round                            => BindToMethodConvertArgs(nameof(ICqlOperators.Round), args),
                CqlOperator.Split                            => BindToMethodConvertArgs(nameof(ICqlOperators.Split), args),
                CqlOperator.StartsWith                       => BindToMethodConvertArgs(nameof(ICqlOperators.StartsWith), args),
                CqlOperator.CharAt                           => BindToMethodConvertArgs(nameof(ICqlOperators.StringIndexer), args),
                CqlOperator.StringInValueSet                 => BindToMethodConvertArgs(nameof(ICqlOperators.StringInValueSet), args),
                CqlOperator.StringsInValueSet                => BindToMethodConvertArgs(nameof(ICqlOperators.StringsInValueSet), args),
                CqlOperator.Subtract                         => BindToMethodConvertArgs(nameof(ICqlOperators.Subtract), args),
                CqlOperator.TruncatedDivide                  => BindToMethodConvertArgs(nameof(ICqlOperators.TruncateDivide), args),
                CqlOperator.Xor                              => BindToMethodConvertArgs(nameof(ICqlOperators.Xor), args),
                CqlOperator.After                            => BindToMethodConvertArgs(nameof(ICqlOperators.After), args),
                CqlOperator.Before                           => BindToMethodConvertArgs(nameof(ICqlOperators.Before), args),
                CqlOperator.DifferenceBetween                => BindToMethodConvertArgs(nameof(ICqlOperators.DifferenceBetween), args),
                CqlOperator.DurationBetween                  => BindToMethodConvertArgs(nameof(ICqlOperators.DurationBetween), args),
                //CqlOperator.IntervalAfterInterval            => BindToMethodConvertArgs(nameof(ICqlOperators.After), args),
                // CqlOperator.IntervalBeforeInterval           => BindToMethodConvertArgs(nameof(ICqlOperators.Before), args),
                CqlOperator.IntervalProperlyIncludesElement  => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalProperlyIncludesElement), args),
                CqlOperator.Meets                            => BindToMethodConvertArgs(nameof(ICqlOperators.Meets), args),
                CqlOperator.MeetsAfter                       => BindToMethodConvertArgs(nameof(ICqlOperators.MeetsAfter), args),
                CqlOperator.MeetsBefore                      => BindToMethodConvertArgs(nameof(ICqlOperators.MeetsBefore), args),
                CqlOperator.ReplaceMatches                   => BindToMethodConvertArgs(nameof(ICqlOperators.ReplaceMatches), args),
                CqlOperator.SameAs                           => BindToMethodConvertArgs(nameof(ICqlOperators.SameAs), args),
                CqlOperator.SameOrAfter                      => BindToMethodConvertArgs(nameof(ICqlOperators.SameOrAfter), args),
                CqlOperator.SameOrBefore                     => BindToMethodConvertArgs(nameof(ICqlOperators.SameOrBefore), args),
                CqlOperator.Substring                        => BindToMethodConvertArgs(nameof(ICqlOperators.Substring), args),
                CqlOperator.Abs                              => BindToMethodConvertArgs(nameof(ICqlOperators.Abs), args),
                CqlOperator.AllTrue                          => BindToMethodConvertArgs(nameof(ICqlOperators.AllTrue), args),
                CqlOperator.AnyTrue                          => BindToMethodConvertArgs(nameof(ICqlOperators.AnyTrue), args),
                CqlOperator.Avg                              => BindToMethodConvertArgs(nameof(ICqlOperators.Avg), args),
                CqlOperator.Ceiling                          => BindToMethodConvertArgs(nameof(ICqlOperators.Ceiling), args),
                CqlOperator.ConvertsToDate                   => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToDate), args),
                CqlOperator.ConvertsToDateTime               => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToDateTime), args),
                CqlOperator.ConvertsToDecimal                => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToDecimal), args),
                CqlOperator.ConvertsToInteger                => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToInteger), args),
                CqlOperator.ConvertsToLong                   => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToLong), args),
                CqlOperator.ConvertsToQuantity               => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToQuantity), args),
                CqlOperator.ConvertsToString                 => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToString), args),
                CqlOperator.ConvertsToTime                   => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToTime), args),
                CqlOperator.DateComponent                    => BindToMethodConvertArgs(nameof(ICqlOperators.DateFrom), args),
                CqlOperator.Descendents                      => BindToMethodConvertArgs(nameof(ICqlOperators.Descendents), args),
                CqlOperator.IntervalEnd                      => BindToMethodConvertArgs(nameof(ICqlOperators.End), args),
                CqlOperator.Exp                              => BindToMethodConvertArgs(nameof(ICqlOperators.Exp), args),
                CqlOperator.Floor                            => BindToMethodConvertArgs(nameof(ICqlOperators.Floor), args),
                CqlOperator.GeometricMean                    => BindToMethodConvertArgs(nameof(ICqlOperators.GeometricMean), args),
                CqlOperator.IsFalse                          => BindToMethodConvertArgs(nameof(ICqlOperators.IsFalse), args),
                CqlOperator.IsTrue                           => BindToMethodConvertArgs(nameof(ICqlOperators.IsTrue), args),
                CqlOperator.Ln                               => BindToMethodConvertArgs(nameof(ICqlOperators.Ln), args),
                CqlOperator.Lower                            => BindToMethodConvertArgs(nameof(ICqlOperators.Lower), args),
                CqlOperator.Median                           => BindToMethodConvertArgs(nameof(ICqlOperators.Median), args),
                CqlOperator.Negate                           => BindToMethodConvertArgs(nameof(ICqlOperators.Negate), args),
                CqlOperator.Not                              => BindToMethodConvertArgs(nameof(ICqlOperators.Not), args),
                CqlOperator.PopulationStdDev                 => BindToMethodConvertArgs(nameof(ICqlOperators.PopulationStdDev), args),
                CqlOperator.PopulationVariance               => BindToMethodConvertArgs(nameof(ICqlOperators.PopulationVariance), args),
                CqlOperator.Precision                        => BindToMethodConvertArgs(nameof(ICqlOperators.Precision), args),
                CqlOperator.Predecessor                      => BindToMethodConvertArgs(nameof(ICqlOperators.Predecessor), args),
                CqlOperator.Product                          => BindToMethodConvertArgs(nameof(ICqlOperators.Product), args),
                CqlOperator.IntervalStart                    => BindToMethodConvertArgs(nameof(ICqlOperators.Start), args),
                CqlOperator.StdDev                           => BindToMethodConvertArgs(nameof(ICqlOperators.StdDev), args),
                CqlOperator.StringLength                     => BindToMethodConvertArgs(nameof(ICqlOperators.StringLength), args),
                CqlOperator.Successor                        => BindToMethodConvertArgs(nameof(ICqlOperators.Successor), args),
                CqlOperator.Sum                              => BindToMethodConvertArgs(nameof(ICqlOperators.Sum), args),
                CqlOperator.TimeComponent                    => BindToMethodConvertArgs(nameof(ICqlOperators.TimeFrom), args),
                CqlOperator.TimeZoneComponent                => BindToMethodConvertArgs(nameof(ICqlOperators.TimezoneOffsetFrom), args),
                CqlOperator.Truncate                         => BindToMethodConvertArgs(nameof(ICqlOperators.Truncate), args),
                CqlOperator.Upper                            => BindToMethodConvertArgs(nameof(ICqlOperators.Upper), args),
                CqlOperator.Variance                         => BindToMethodConvertArgs(nameof(ICqlOperators.Variance), args),
                CqlOperator.CalculateAge                     => BindToMethodConvertArgs(nameof(ICqlOperators.CalculateAge), args),
                CqlOperator.CalculateAgeAt                   => BindToMethodConvertArgs(nameof(ICqlOperators.CalculateAgeAt), args),
                //CqlOperator.ElementAfterInterval             => BindToMethodConvertArgs(nameof(ICqlOperators.After), args),
                // CqlOperator.ElementBeforeInterval            => BindToMethodConvertArgs(nameof(ICqlOperators.Before), args),
                //CqlOperator.IntervalAfterElement             => BindToMethodConvertArgs(nameof(ICqlOperators.After), args),
                // CqlOperator.IntervalBeforeElement            => BindToMethodConvertArgs(nameof(ICqlOperators.Before), args),
                CqlOperator.IntervalContains                 => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalContains), args),
                CqlOperator.IntervalSameOrAfter              => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalSameOrAfter), args),
                CqlOperator.IntervalSameOrBefore             => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalSameOrBefore), args),
                CqlOperator.Overlaps                         => BindToMethodConvertArgs(nameof(ICqlOperators.Overlaps), args),
                CqlOperator.OverlapsAfter                    => BindToMethodConvertArgs(nameof(ICqlOperators.OverlapsAfter), args),
                CqlOperator.OverlapsBefore                   => BindToMethodConvertArgs(nameof(ICqlOperators.OverlapsBefore), args),
                CqlOperator.InInterval                       => BindToMethodConvertArgs(nameof(ICqlOperators.ElementInInterval), args),
                CqlOperator.Ends                             => BindToMethodConvertArgs(nameof(ICqlOperators.Ends), args),
                CqlOperator.IntervalIncludesElement          => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalIncludesElement), args),
                CqlOperator.IntervalIncludesInterval         => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalIncludesInterval), args),
                CqlOperator.IntervalProperlyIncludesInterval => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalProperlyIncludesInterval), args),
                CqlOperator.IntervalSameAs                   => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalSameAs), args),
                CqlOperator.Slice                            => BindToMethodConvertArgs(nameof(ICqlOperators.Slice), args),
                CqlOperator.Starts                           => BindToMethodConvertArgs(nameof(ICqlOperators.Starts), args),
                CqlOperator.Count                            => BindToMethodConvertArgs(nameof(ICqlOperators.CountOrNull), args),
                CqlOperator.Exists                           => BindToMethodConvertArgs(nameof(ICqlOperators.ExistsInList), args),
                CqlOperator.First                            => BindToMethodConvertArgs(nameof(ICqlOperators.FirstOfList), args),
                CqlOperator.Last                             => BindToMethodConvertArgs(nameof(ICqlOperators.LastOfList), args),
                CqlOperator.Distinct                         => BindToMethodConvertArgs(nameof(ICqlOperators.ListDistinct), args),
                CqlOperator.ListLength                       => BindToMethodConvertArgs(nameof(ICqlOperators.ListLength), args),
                CqlOperator.Tail                             => BindToMethodConvertArgs(nameof(ICqlOperators.ListTail), args),
                CqlOperator.MaxElementInList                 => BindToMethodConvertArgs(nameof(ICqlOperators.MaxOrNull), args),
                CqlOperator.MinElementInList                 => BindToMethodConvertArgs(nameof(ICqlOperators.MinOrNull), args),
                CqlOperator.Mode                             => BindToMethodConvertArgs(nameof(ICqlOperators.Mode), args),
                CqlOperator.PointFrom                        => BindToMethodConvertArgs(nameof(ICqlOperators.PointFrom), args),
                CqlOperator.Single                           => BindToMethodConvertArgs(nameof(ICqlOperators.SingleOrNull), args),

                // Direct Bindings
                CqlOperator.Aggregate                        => BindToGenericMethod(methodName:nameof(ICqlOperators.AggregateOrNull),
                                                                    genericTypeArguments:[_typeResolver.GetListElementType(args[0].Type, true)!, args[2].Type],
                                                                    args[0], args[2], args[1]), // NOTE: the order here is 0, 2, 1, maybe change the Aggregate method arguments as well?
                CqlOperator.CrossJoin                        => BindToGenericMethod(methodName:nameof(ICqlOperators.CrossJoin),
                                                                    genericTypeArguments:args.SelectToArray(s => _typeResolver.GetListElementType(s.Type, true)!),
                                                                    args),
                CqlOperator.Date                             => BindToMethodConvertArgs(nameof(ICqlOperators.Date), args),
                CqlOperator.DateTime                         => BindToMethodConvertArgs(nameof(ICqlOperators.DateTime)!, args),
                CqlOperator.Now                              => BindToMethodConvertArgs(nameof(ICqlOperators.Now)),
                CqlOperator.Quantity                         => BindToMethodConvertArgs(nameof(ICqlOperators.Quantity), args[..2]), // Discard the 3rd parameter!!
                CqlOperator.Time                             => BindToMethodConvertArgs(nameof(ICqlOperators.Time), args),
                CqlOperator.TimeOfDay                        => BindToMethodConvertArgs(nameof(ICqlOperators.TimeOfDay)),
                CqlOperator.Today                            => BindToMethodConvertArgs(nameof(ICqlOperators.Today)),
                CqlOperator.Message                          => BindToGenericMethod(nameof(ICqlOperators.Message), genericTypeArguments:[args[0].Type], args),
                CqlOperator.ToList                           => BindToGenericMethod(nameof(ICqlOperators.ToList), genericTypeArguments:[args[0].Type], args),

                // Special cases
                CqlOperator.Equal                            => Equal(args[0], args[1]),
                CqlOperator.Convert                          => BindConvert(args[0], args[1]),
                CqlOperator.Coalesce                         => Coalesce(args[0]),
                CqlOperator.Expand                           => Expand(args[0], args[1]),
                CqlOperator.Flatten                          => Flatten(args[0]),
                CqlOperator.InList                           => InList(args[0], args[1]),
                CqlOperator.Interval                         => Interval(args[0], args[1], args[2], args[3]),
                CqlOperator.LateBoundProperty                => LateBoundProperty(args[0], args[1], args[2]),
                CqlOperator.ListUnion                        => ListUnion(args[0], args[1]),
                CqlOperator.MaximumValue                     => Maximum(args[0]),
                CqlOperator.MinimumValue                     => Minimum(args[0]),
                CqlOperator.ResolveValueSet                  => ResolveValueSet(args[0]),
                CqlOperator.Retrieve                         => Retrieve(args[0], args[1], args[2]),
                CqlOperator.Select                           => Select(args[0], args[1]),
                CqlOperator.SelectMany                       => SelectMany(source: args[0], collectionSelectorLambda: args[1]),
                CqlOperator.SelectManyResults                => SelectManyResults(source: args[0], collectionSelectorLambda: args[1], resultSelectorLambda: args[2]),
                CqlOperator.SortBy                           => SortBy(args[0], args[1], args[2]),
                CqlOperator.Where                            => Where(args[0], args[1]),
                CqlOperator.Width                            => Width(args[0]),
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
                : throw new InvalidOperationException($"Cannot convert '{expression.Type.FullName}' to '{type.FullName}'");

        ///// <inheritdoc />
        public override Expression CastToType(Expression expression, Type type)
        {
            if (expression.Type != typeof(object))
                throw new ArgumentException("Cast only allowed on Object typed expressions.", nameof(expression));

            return expression.ExprConvert(type);
        }
    }
}