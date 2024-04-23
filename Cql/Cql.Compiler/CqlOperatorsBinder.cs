/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Linq.Expressions;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Compiler.Expressions;
using Hl7.Cql.Conversion;
using Hl7.Cql.Operators;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler
{
    /// <summary>
    /// Implements <see cref="OperatorsBinder"/> by calling methods in <see cref="CqlOperators"/>.
    /// </summary>
    internal partial class CqlOperatorsBinder : OperatorsBinder
    {
        private readonly ILogger<CqlOperatorsBinder> _logger;
        private readonly TypeConverter? _typeConverter;
        private readonly TypeResolver _typeResolver;


        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="logger">
        /// The logger used in this binding.
        /// </param>
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
            ILogger<CqlOperatorsBinder> logger,
            TypeResolver typeResolver,
            TypeConverter? typeConverter = null)
        {
            _typeConverter = typeConverter;
            _typeResolver = typeResolver;
            _logger = logger;
        }

        /// <inheritdoc />
        public override MethodCallExpression BindToMethod(
            string methodName,
            Type? resultTypeHint,
            params Expression[] args)
        {
            var result = BindToMethodConvertArgs(methodName, resultTypeHint, args);
            return result;
        }

        /// <inheritdoc />
        public override Expression BindToMethod(
            CqlOperator @operator,
            Type? resultTypeHint,
            params Expression[] args)
        {
            var result = @operator switch
            {
                // @formatter:off

                // Bindings with Argument Conversions
                CqlOperator.Convert                          => BindConvert(args[0], args[1]),
                CqlOperator.Aggregate                        => BindToGenericMethod(methodName:nameof(ICqlOperators.AggregateOrNull), genericTypeArguments:[_typeResolver.GetListElementType(args[0].Type, true)!, args[2].Type], args[0], args[2], args[1]), // NOTE: the order here is 0, 2, 1, maybe change the Aggregate method arguments as well?
                CqlOperator.CrossJoin                        => BindToGenericMethod(methodName: nameof(ICqlOperators.CrossJoin), genericTypeArguments: args.SelectToArray(s => _typeResolver.GetListElementType(s.Type, true)!), args),
                CqlOperator.Message                          => BindToGenericMethod(nameof(ICqlOperators.Message), genericTypeArguments:[args[0].Type], args),
                CqlOperator.ToList                           => BindToGenericMethod(nameof(ICqlOperators.ToList), genericTypeArguments:[args[0].Type], args),
                CqlOperator.Abs                              => BindToMethodConvertArgs(nameof(ICqlOperators.Abs), resultTypeHint, args),
                CqlOperator.Add                              => BindToMethodConvertArgs(nameof(ICqlOperators.Add), resultTypeHint, args),
                CqlOperator.After                            => BindToMethodConvertArgs(nameof(ICqlOperators.After), resultTypeHint, args),
                CqlOperator.AllTrue                          => BindToMethodConvertArgs(nameof(ICqlOperators.AllTrue), resultTypeHint, args),
                CqlOperator.And                              => BindToMethodConvertArgs(nameof(ICqlOperators.And), resultTypeHint, args),
                CqlOperator.AnyTrue                          => BindToMethodConvertArgs(nameof(ICqlOperators.AnyTrue), resultTypeHint, args),
                CqlOperator.Avg                              => BindToMethodConvertArgs(nameof(ICqlOperators.Avg), resultTypeHint, args),
                CqlOperator.Before                           => BindToMethodConvertArgs(nameof(ICqlOperators.Before), resultTypeHint, args),
                CqlOperator.CalculateAge                     => BindToMethodConvertArgs(nameof(ICqlOperators.CalculateAge), resultTypeHint, args),
                CqlOperator.CalculateAgeAt                   => BindToMethodConvertArgs(nameof(ICqlOperators.CalculateAgeAt), resultTypeHint, args),
                CqlOperator.Ceiling                          => BindToMethodConvertArgs(nameof(ICqlOperators.Ceiling), resultTypeHint, args),
                CqlOperator.CodeInValueSet                   => BindToMethodConvertArgs(nameof(ICqlOperators.CodeInValueSet), resultTypeHint, args),
                CqlOperator.CodesInValueSet                  => BindToMethodConvertArgs(nameof(ICqlOperators.CodesInValueSet), resultTypeHint, args),
                CqlOperator.Collapse                         => BindToMethodConvertArgs(nameof(ICqlOperators.Collapse), resultTypeHint, args),
                CqlOperator.Combine                          => BindToMethodConvertArgs(nameof(ICqlOperators.Combine), resultTypeHint, args),
                CqlOperator.DateTimeComponentFrom            => BindToMethodConvertArgs(nameof(ICqlOperators.DateTimeComponentFrom), resultTypeHint, args),
                CqlOperator.Concatenate                      => BindToMethodConvertArgs(nameof(ICqlOperators.Concatenate), resultTypeHint, args),
                CqlOperator.ConceptInValueSet                => BindToMethodConvertArgs(nameof(ICqlOperators.ConceptInValueSet), resultTypeHint, args),
                CqlOperator.ConceptsInValueSet               => BindToMethodConvertArgs(nameof(ICqlOperators.ConceptsInValueSet), resultTypeHint, args),
                CqlOperator.ConvertQuantity                  => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertQuantity), resultTypeHint, args),
                CqlOperator.ConvertsToDate                   => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToDate), resultTypeHint, args),
                CqlOperator.ConvertsToDateTime               => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToDateTime), resultTypeHint, args),
                CqlOperator.ConvertsToDecimal                => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToDecimal), resultTypeHint, args),
                CqlOperator.ConvertsToInteger                => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToInteger), resultTypeHint, args),
                CqlOperator.ConvertsToLong                   => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToLong), resultTypeHint, args),
                CqlOperator.ConvertsToQuantity               => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToQuantity), resultTypeHint, args),
                CqlOperator.ConvertsToString                 => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToString), resultTypeHint, args),
                CqlOperator.ConvertsToTime                   => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToTime), resultTypeHint, args),
                CqlOperator.Count                            => BindToMethodConvertArgs(nameof(ICqlOperators.Count), resultTypeHint, args),
                CqlOperator.Date                             => BindToMethodConvertArgs(nameof(ICqlOperators.Date), resultTypeHint, args),
                CqlOperator.DateFrom                         => BindToMethodConvertArgs(nameof(ICqlOperators.DateFrom), resultTypeHint, args),
                CqlOperator.DateTime                         => BindToMethodConvertArgs(nameof(ICqlOperators.DateTime)!, resultTypeHint, args),
                CqlOperator.Descendents                      => BindToMethodConvertArgs(nameof(ICqlOperators.Descendents), resultTypeHint, args),
                CqlOperator.DifferenceBetween                => BindToMethodConvertArgs(nameof(ICqlOperators.DifferenceBetween), resultTypeHint, args),
                CqlOperator.Divide                           => BindToMethodConvertArgs(nameof(ICqlOperators.Divide), resultTypeHint, args),
                CqlOperator.DurationBetween                  => BindToMethodConvertArgs(nameof(ICqlOperators.DurationBetween), resultTypeHint, args),
                CqlOperator.InInterval                       => BindToMethodConvertArgs(nameof(ICqlOperators.InInterval), resultTypeHint, args),
                CqlOperator.End                              => BindToMethodConvertArgs(nameof(ICqlOperators.End), resultTypeHint, args),
                CqlOperator.Ends                             => BindToMethodConvertArgs(nameof(ICqlOperators.Ends), resultTypeHint, args),
                CqlOperator.EndsWith                         => BindToMethodConvertArgs(nameof(ICqlOperators.EndsWith), resultTypeHint, args),
                CqlOperator.EnumEqualsString                 => BindToMethodConvertArgs(nameof(ICqlOperators.EnumEqualsString), resultTypeHint, args),
                CqlOperator.Equal                            => BindToMethodConvertArgs(nameof(ICqlOperators.Equal), resultTypeHint, args),
                CqlOperator.Equivalent                       => BindToMethodConvertArgs(nameof(ICqlOperators.Equivalent), resultTypeHint, args),
                CqlOperator.Exists                           => BindToMethodConvertArgs(nameof(ICqlOperators.Exists), resultTypeHint, args),
                CqlOperator.Exp                              => BindToMethodConvertArgs(nameof(ICqlOperators.Exp), resultTypeHint, args),
                CqlOperator.First                            => BindToMethodConvertArgs(nameof(ICqlOperators.First), resultTypeHint, args),
                CqlOperator.Floor                            => BindToMethodConvertArgs(nameof(ICqlOperators.Floor), resultTypeHint, args),
                CqlOperator.GeometricMean                    => BindToMethodConvertArgs(nameof(ICqlOperators.GeometricMean), resultTypeHint, args),
                CqlOperator.Greater                          => BindToMethodConvertArgs(nameof(ICqlOperators.Greater), resultTypeHint, args),
                CqlOperator.GreaterOrEqual                   => BindToMethodConvertArgs(nameof(ICqlOperators.GreaterOrEqual), resultTypeHint, args),
                CqlOperator.HighBoundary                     => BindToMethodConvertArgs(nameof(ICqlOperators.HighBoundary), resultTypeHint, args),
                CqlOperator.Implies                          => BindToMethodConvertArgs(nameof(ICqlOperators.Implies), resultTypeHint, args),
                CqlOperator.Interval                         => BindToMethodConvertArgs(nameof(ICqlOperators.Interval), resultTypeHint, args),
                CqlOperator.IntervalContains                 => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalContains), resultTypeHint, args),
                CqlOperator.IntervalExcept                   => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalExcept), resultTypeHint, args),
                CqlOperator.IntervalIncludesElement          => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalIncludesElement), resultTypeHint, args),
                CqlOperator.IntervalIncludesInterval         => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalIncludesInterval), resultTypeHint, args),
                CqlOperator.IntervalIntersect                => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalIntersect), resultTypeHint, args),
                CqlOperator.IntervalProperlyIncludesElement  => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalProperlyIncludesElement), resultTypeHint, args),
                CqlOperator.IntervalProperlyIncludesInterval => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalProperlyIncludesInterval), resultTypeHint, args),
                CqlOperator.IntervalSameAs                   => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalSameAs), resultTypeHint, args),
                CqlOperator.IntervalSameOrAfter              => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalSameOrAfter), resultTypeHint, args),
                CqlOperator.IntervalSameOrBefore             => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalSameOrBefore), resultTypeHint, args),
                CqlOperator.IntervalUnion                    => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalUnion), resultTypeHint, args),
                CqlOperator.IsFalse                          => BindToMethodConvertArgs(nameof(ICqlOperators.IsFalse), resultTypeHint, args),
                CqlOperator.IsTrue                           => BindToMethodConvertArgs(nameof(ICqlOperators.IsTrue), resultTypeHint, args),
                CqlOperator.Last                             => BindToMethodConvertArgs(nameof(ICqlOperators.Last), resultTypeHint, args),
                CqlOperator.LastPositionOf                   => BindToMethodConvertArgs(nameof(ICqlOperators.LastPositionOf), resultTypeHint, args),
                CqlOperator.Length                           => BindToMethodConvertArgs(nameof(ICqlOperators.Length), resultTypeHint, args),
                CqlOperator.Less                             => BindToMethodConvertArgs(nameof(ICqlOperators.Less), resultTypeHint, args),
                CqlOperator.LessOrEqual                      => BindToMethodConvertArgs(nameof(ICqlOperators.LessOrEqual), resultTypeHint, args),
                CqlOperator.ListContains                     => BindToMethodConvertArgs(nameof(ICqlOperators.ListContains), resultTypeHint, args),
                CqlOperator.Distinct                         => BindToMethodConvertArgs(nameof(ICqlOperators.Distinct), resultTypeHint, args),
                CqlOperator.ListEqual                        => BindToMethodConvertArgs(nameof(ICqlOperators.ListEqual), resultTypeHint, args),
                CqlOperator.ListEquivalent                   => BindToMethodConvertArgs(nameof(ICqlOperators.ListEquivalent), resultTypeHint, args),
                CqlOperator.ListExcept                       => BindToMethodConvertArgs(nameof(ICqlOperators.ListExcept), resultTypeHint, args),
                CqlOperator.ListIncludesElement              => BindToMethodConvertArgs(nameof(ICqlOperators.ListIncludesElement), resultTypeHint, args),
                CqlOperator.ListIncludesList                 => BindToMethodConvertArgs(nameof(ICqlOperators.ListIncludesList), resultTypeHint, args),
                CqlOperator.ListIntersect                    => BindToMethodConvertArgs(nameof(ICqlOperators.ListIntersect), resultTypeHint, args),
                CqlOperator.ListProperlyIncludesElement      => BindToMethodConvertArgs(nameof(ICqlOperators.ListProperlyIncludesElement), resultTypeHint, args),
                CqlOperator.ListProperlyIncludesList         => BindToMethodConvertArgs(nameof(ICqlOperators.ListProperlyIncludesList), resultTypeHint, args),
                CqlOperator.ListSort                         => BindToMethodConvertArgs(nameof(ICqlOperators.ListSort), resultTypeHint, args),
                CqlOperator.Tail                             => BindToMethodConvertArgs(nameof(ICqlOperators.Tail), resultTypeHint, args),
                CqlOperator.Ln                               => BindToMethodConvertArgs(nameof(ICqlOperators.Ln), resultTypeHint, args),
                CqlOperator.Log                              => BindToMethodConvertArgs(nameof(ICqlOperators.Log), resultTypeHint, args),
                CqlOperator.LowBoundary                      => BindToMethodConvertArgs(nameof(ICqlOperators.LowBoundary), resultTypeHint, args),
                CqlOperator.Lower                            => BindToMethodConvertArgs(nameof(ICqlOperators.Lower), resultTypeHint, args),
                CqlOperator.Matches                          => BindToMethodConvertArgs(nameof(ICqlOperators.Matches), resultTypeHint, args),
                CqlOperator.Max                              => BindToMethodConvertArgs(nameof(ICqlOperators.Max), resultTypeHint, args),
                CqlOperator.Median                           => BindToMethodConvertArgs(nameof(ICqlOperators.Median), resultTypeHint, args),
                CqlOperator.Meets                            => BindToMethodConvertArgs(nameof(ICqlOperators.Meets), resultTypeHint, args),
                CqlOperator.MeetsAfter                       => BindToMethodConvertArgs(nameof(ICqlOperators.MeetsAfter), resultTypeHint, args),
                CqlOperator.MeetsBefore                      => BindToMethodConvertArgs(nameof(ICqlOperators.MeetsBefore), resultTypeHint, args),
                CqlOperator.Min                              => BindToMethodConvertArgs(nameof(ICqlOperators.Min), resultTypeHint, args),
                CqlOperator.Mode                             => BindToMethodConvertArgs(nameof(ICqlOperators.Mode), resultTypeHint, args),
                CqlOperator.Modulo                           => BindToMethodConvertArgs(nameof(ICqlOperators.Modulo), resultTypeHint, args),
                CqlOperator.Multiply                         => BindToMethodConvertArgs(nameof(ICqlOperators.Multiply), resultTypeHint, args),
                CqlOperator.Negate                           => BindToMethodConvertArgs(nameof(ICqlOperators.Negate), resultTypeHint, args),
                CqlOperator.Not                              => BindToMethodConvertArgs(nameof(ICqlOperators.Not), resultTypeHint, args),
                CqlOperator.Now                              => BindToMethodConvertArgs(nameof(ICqlOperators.Now), resultTypeHint),
                CqlOperator.Or                               => BindToMethodConvertArgs(nameof(ICqlOperators.Or), resultTypeHint, args),
                CqlOperator.Overlaps                         => BindToMethodConvertArgs(nameof(ICqlOperators.Overlaps), resultTypeHint, args),
                CqlOperator.OverlapsAfter                    => BindToMethodConvertArgs(nameof(ICqlOperators.OverlapsAfter), resultTypeHint, args),
                CqlOperator.OverlapsBefore                   => BindToMethodConvertArgs(nameof(ICqlOperators.OverlapsBefore), resultTypeHint, args),
                CqlOperator.PointFrom                        => BindToMethodConvertArgs(nameof(ICqlOperators.PointFrom), resultTypeHint, args),
                CqlOperator.PopulationStdDev                 => BindToMethodConvertArgs(nameof(ICqlOperators.PopulationStdDev), resultTypeHint, args),
                CqlOperator.PopulationVariance               => BindToMethodConvertArgs(nameof(ICqlOperators.PopulationVariance), resultTypeHint, args),
                CqlOperator.PositionOf                       => BindToMethodConvertArgs(nameof(ICqlOperators.PositionOf), resultTypeHint, args),
                CqlOperator.Power                            => BindToMethodConvertArgs(nameof(ICqlOperators.Power), resultTypeHint, args),
                CqlOperator.Precision                        => BindToMethodConvertArgs(nameof(ICqlOperators.Precision), resultTypeHint, args),
                CqlOperator.Predecessor                      => BindToMethodConvertArgs(nameof(ICqlOperators.Predecessor), resultTypeHint, args),
                CqlOperator.Product                          => BindToMethodConvertArgs(nameof(ICqlOperators.Product), resultTypeHint, args),
                CqlOperator.Quantity                         => BindToMethodConvertArgs(nameof(ICqlOperators.Quantity), resultTypeHint, args),
                CqlOperator.ReplaceMatches                   => BindToMethodConvertArgs(nameof(ICqlOperators.ReplaceMatches), resultTypeHint, args),
                CqlOperator.Round                            => BindToMethodConvertArgs(nameof(ICqlOperators.Round), resultTypeHint, args),
                CqlOperator.SameAs                           => BindToMethodConvertArgs(nameof(ICqlOperators.SameAs), resultTypeHint, args),
                CqlOperator.SameOrAfter                      => BindToMethodConvertArgs(nameof(ICqlOperators.SameOrAfter), resultTypeHint, args),
                CqlOperator.SameOrBefore                     => BindToMethodConvertArgs(nameof(ICqlOperators.SameOrBefore), resultTypeHint, args),
                CqlOperator.SingletonFrom                    => BindToMethodConvertArgs(nameof(ICqlOperators.SingletonFrom), resultTypeHint, args),
                CqlOperator.Slice                            => BindToMethodConvertArgs(nameof(ICqlOperators.Slice), resultTypeHint, args),
                CqlOperator.Split                            => BindToMethodConvertArgs(nameof(ICqlOperators.Split), resultTypeHint, args),
                CqlOperator.Start                            => BindToMethodConvertArgs(nameof(ICqlOperators.Start), resultTypeHint, args),
                CqlOperator.Starts                           => BindToMethodConvertArgs(nameof(ICqlOperators.Starts), resultTypeHint, args),
                CqlOperator.StartsWith                       => BindToMethodConvertArgs(nameof(ICqlOperators.StartsWith), resultTypeHint, args),
                CqlOperator.StdDev                           => BindToMethodConvertArgs(nameof(ICqlOperators.StdDev), resultTypeHint, args),
                CqlOperator.Indexer                          => BindToMethodConvertArgs(nameof(ICqlOperators.Indexer), resultTypeHint, args),
                CqlOperator.IndexOf                          => BindToMethodConvertArgs(nameof(ICqlOperators.PositionOf), resultTypeHint, args),
                CqlOperator.StringInValueSet                 => BindToMethodConvertArgs(nameof(ICqlOperators.StringInValueSet), resultTypeHint, args),
                CqlOperator.StringsInValueSet                => BindToMethodConvertArgs(nameof(ICqlOperators.StringsInValueSet), resultTypeHint, args),
                CqlOperator.Substring                        => BindToMethodConvertArgs(nameof(ICqlOperators.Substring), resultTypeHint, args),
                CqlOperator.Subtract                         => BindToMethodConvertArgs(nameof(ICqlOperators.Subtract), resultTypeHint, args),
                CqlOperator.Successor                        => BindToMethodConvertArgs(nameof(ICqlOperators.Successor), resultTypeHint, args),
                CqlOperator.Sum                              => BindToMethodConvertArgs(nameof(ICqlOperators.Sum), resultTypeHint, args),
                CqlOperator.Time                             => BindToMethodConvertArgs(nameof(ICqlOperators.Time), resultTypeHint, args),
                CqlOperator.TimeComponent                    => BindToMethodConvertArgs(nameof(ICqlOperators.TimeComponent), resultTypeHint, args),
                CqlOperator.TimeOfDay                        => BindToMethodConvertArgs(nameof(ICqlOperators.TimeOfDay), resultTypeHint),
                CqlOperator.TimezoneOffsetFrom               => BindToMethodConvertArgs(nameof(ICqlOperators.TimezoneOffsetFrom), resultTypeHint, args),
                CqlOperator.Today                            => BindToMethodConvertArgs(nameof(ICqlOperators.Today), resultTypeHint),
                CqlOperator.Truncate                         => BindToMethodConvertArgs(nameof(ICqlOperators.Truncate), resultTypeHint, args),
                CqlOperator.TruncatedDivide                  => BindToMethodConvertArgs(nameof(ICqlOperators.TruncatedDivide), resultTypeHint, args),
                CqlOperator.Upper                            => BindToMethodConvertArgs(nameof(ICqlOperators.Upper), resultTypeHint, args),
                CqlOperator.Variance                         => BindToMethodConvertArgs(nameof(ICqlOperators.Variance), resultTypeHint, args),
                CqlOperator.Xor                              => BindToMethodConvertArgs(nameof(ICqlOperators.Xor), resultTypeHint, args),
                CqlOperator.Coalesce                         => Coalesce(args[0]),
                CqlOperator.Expand                           => Expand(args[0], args[1]),
                CqlOperator.Flatten                          => Flatten(args[0]),
                CqlOperator.InList                           => InList(args[0], args[1]),
                CqlOperator.LateBoundProperty                => LateBoundProperty(args[0], args[1], args[2]),
                CqlOperator.ListUnion                        => ListUnion(args[0], args[1]),
                CqlOperator.MaxValue                         => MaxValue(args[0]),
                CqlOperator.MinValue                         => MinValue(args[0]),
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
            TryConvert(expression, type, out var t)
                ? t.arg!
                : throw new InvalidOperationException($"Cannot convert '{expression.Type.FullName}' to '{type.FullName}'");

        ///// <inheritdoc />
        public override Expression CastToType(Expression expression, Type type)
        {
            if (expression.Type != typeof(object))
                throw new ArgumentException("Cast only allowed on Object typed expressions.", nameof(expression));

            return expression.ConvertExpression(type);
        }
    }
}