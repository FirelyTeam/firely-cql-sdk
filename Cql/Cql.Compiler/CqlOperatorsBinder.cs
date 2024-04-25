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
        public override Expression BindToMethod(
            CqlOperatorsMethod method,
            Type? resultTypeHint,
            params Expression[] args)
        {
            var result =
                method.Match(
                    methodName => BindToMethodConvertArgs(methodName, resultTypeHint, args),
                    cqlOperator => BindCqlOperator(cqlOperator, resultTypeHint, args))
                ;
            return result;
        }

        private Expression BindCqlOperator(
            CqlOperator @operator,
            Type? resultTypeHint,
            params Expression[] args)
        {
            var result = @operator switch
            {
                // @formatter:off

                // Bindings with Argument Conversions
                CqlOperator.Convert                          => BindConvert(args[0], args[1]),
                CqlOperator.Aggregate                        => BindToGenericMethod(nameof(ICqlOperators.AggregateOrNull), genericTypeArguments:[_typeResolver.GetListElementType(args[0].Type, true)!, args[2].Type], args[0], args[2], args[1]), // NOTE: the order here is 0, 2, 1, maybe change the Aggregate method arguments as well?
                CqlOperator.CrossJoin                        => BindToGenericMethod(nameof(ICqlOperators.CrossJoin), genericTypeArguments: args.SelectToArray(s => _typeResolver.GetListElementType(s.Type, true)!), args),
                CqlOperator.Message                          => BindToGenericMethod(nameof(ICqlOperators.Message), genericTypeArguments:[args[0].Type], args),
                CqlOperator.ToList                           => BindToGenericMethod(nameof(ICqlOperators.ToList), genericTypeArguments:[args[0].Type], args),
                CqlOperator.Abs                              or // => BindToMethodConvertArgs(nameof(ICqlOperators.Abs), resultTypeHint, args),
                CqlOperator.Add                              or // => BindToMethodConvertArgs(nameof(ICqlOperators.Add), resultTypeHint, args),
                CqlOperator.After                            or // => BindToMethodConvertArgs(nameof(ICqlOperators.After), resultTypeHint, args),
                CqlOperator.AllTrue                          or // => BindToMethodConvertArgs(nameof(ICqlOperators.AllTrue), resultTypeHint, args),
                CqlOperator.And                              or // => BindToMethodConvertArgs(nameof(ICqlOperators.And), resultTypeHint, args),
                CqlOperator.AnyTrue                          or // => BindToMethodConvertArgs(nameof(ICqlOperators.AnyTrue), resultTypeHint, args),
                CqlOperator.Avg                              or // => BindToMethodConvertArgs(nameof(ICqlOperators.Avg), resultTypeHint, args),
                CqlOperator.Before                           or // => BindToMethodConvertArgs(nameof(ICqlOperators.Before), resultTypeHint, args),
                CqlOperator.CalculateAge                     or // => BindToMethodConvertArgs(nameof(ICqlOperators.CalculateAge), resultTypeHint, args),
                CqlOperator.CalculateAgeAt                   or // => BindToMethodConvertArgs(nameof(ICqlOperators.CalculateAgeAt), resultTypeHint, args),
                CqlOperator.Ceiling                          or // => BindToMethodConvertArgs(nameof(ICqlOperators.Ceiling), resultTypeHint, args),
                CqlOperator.CodeInValueSet                   or // => BindToMethodConvertArgs(nameof(ICqlOperators.CodeInValueSet), resultTypeHint, args),
                CqlOperator.CodesInValueSet                  or // => BindToMethodConvertArgs(nameof(ICqlOperators.CodesInValueSet), resultTypeHint, args),
                CqlOperator.Collapse                         or // => BindToMethodConvertArgs(nameof(ICqlOperators.Collapse), resultTypeHint, args),
                CqlOperator.Combine                          or // => BindToMethodConvertArgs(nameof(ICqlOperators.Combine), resultTypeHint, args),
                CqlOperator.DateTimeComponentFrom            or // => BindToMethodConvertArgs(nameof(ICqlOperators.DateTimeComponentFrom), resultTypeHint, args),
                CqlOperator.Concatenate                      or // => BindToMethodConvertArgs(nameof(ICqlOperators.Concatenate), resultTypeHint, args),
                CqlOperator.ConceptInValueSet                or // => BindToMethodConvertArgs(nameof(ICqlOperators.ConceptInValueSet), resultTypeHint, args),
                CqlOperator.ConceptsInValueSet               or // => BindToMethodConvertArgs(nameof(ICqlOperators.ConceptsInValueSet), resultTypeHint, args),
                CqlOperator.ConvertQuantity                  or // => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertQuantity), resultTypeHint, args),
                CqlOperator.ConvertsToDate                   or // => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToDate), resultTypeHint, args),
                CqlOperator.ConvertsToDateTime               or // => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToDateTime), resultTypeHint, args),
                CqlOperator.ConvertsToDecimal                or // => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToDecimal), resultTypeHint, args),
                CqlOperator.ConvertsToInteger                or // => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToInteger), resultTypeHint, args),
                CqlOperator.ConvertsToLong                   or // => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToLong), resultTypeHint, args),
                CqlOperator.ConvertsToQuantity               or // => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToQuantity), resultTypeHint, args),
                CqlOperator.ConvertsToString                 or // => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToString), resultTypeHint, args),
                CqlOperator.ConvertsToTime                   or // => BindToMethodConvertArgs(nameof(ICqlOperators.ConvertsToTime), resultTypeHint, args),
                CqlOperator.Count                            or // => BindToMethodConvertArgs(nameof(ICqlOperators.Count), resultTypeHint, args),
                CqlOperator.Date                             or // => BindToMethodConvertArgs(nameof(ICqlOperators.Date), resultTypeHint, args),
                CqlOperator.DateFrom                         or // => BindToMethodConvertArgs(nameof(ICqlOperators.DateFrom), resultTypeHint, args),
                CqlOperator.DateTime                         or // => BindToMethodConvertArgs(nameof(ICqlOperators.DateTime)!, resultTypeHint, args),
                CqlOperator.Descendents                      or // => BindToMethodConvertArgs(nameof(ICqlOperators.Descendents), resultTypeHint, args),
                CqlOperator.DifferenceBetween                or // => BindToMethodConvertArgs(nameof(ICqlOperators.DifferenceBetween), resultTypeHint, args),
                CqlOperator.Divide                           or // => BindToMethodConvertArgs(nameof(ICqlOperators.Divide), resultTypeHint, args),
                CqlOperator.DurationBetween                  or // => BindToMethodConvertArgs(nameof(ICqlOperators.DurationBetween), resultTypeHint, args),
                CqlOperator.InInterval                       or // => BindToMethodConvertArgs(nameof(ICqlOperators.InInterval), resultTypeHint, args),
                CqlOperator.End                              or // => BindToMethodConvertArgs(nameof(ICqlOperators.End), resultTypeHint, args),
                CqlOperator.Ends                             or // => BindToMethodConvertArgs(nameof(ICqlOperators.Ends), resultTypeHint, args),
                CqlOperator.EndsWith                         or // => BindToMethodConvertArgs(nameof(ICqlOperators.EndsWith), resultTypeHint, args),
                CqlOperator.EnumEqualsString                 or // => BindToMethodConvertArgs(nameof(ICqlOperators.EnumEqualsString), resultTypeHint, args),
                CqlOperator.Equal                            or // => BindToMethodConvertArgs(nameof(ICqlOperators.Equal), resultTypeHint, args),
                CqlOperator.Equivalent                       or // => BindToMethodConvertArgs(nameof(ICqlOperators.Equivalent), resultTypeHint, args),
                CqlOperator.Exists                           or // => BindToMethodConvertArgs(nameof(ICqlOperators.Exists), resultTypeHint, args),
                CqlOperator.Exp                              or // => BindToMethodConvertArgs(nameof(ICqlOperators.Exp), resultTypeHint, args),
                CqlOperator.First                            or // => BindToMethodConvertArgs(nameof(ICqlOperators.First), resultTypeHint, args),
                CqlOperator.Floor                            or // => BindToMethodConvertArgs(nameof(ICqlOperators.Floor), resultTypeHint, args),
                CqlOperator.GeometricMean                    or // => BindToMethodConvertArgs(nameof(ICqlOperators.GeometricMean), resultTypeHint, args),
                CqlOperator.Greater                          or // => BindToMethodConvertArgs(nameof(ICqlOperators.Greater), resultTypeHint, args),
                CqlOperator.GreaterOrEqual                   or // => BindToMethodConvertArgs(nameof(ICqlOperators.GreaterOrEqual), resultTypeHint, args),
                CqlOperator.HighBoundary                     or // => BindToMethodConvertArgs(nameof(ICqlOperators.HighBoundary), resultTypeHint, args),
                CqlOperator.Implies                          or // => BindToMethodConvertArgs(nameof(ICqlOperators.Implies), resultTypeHint, args),
                CqlOperator.Interval                         or // => BindToMethodConvertArgs(nameof(ICqlOperators.Interval), resultTypeHint, args),
                CqlOperator.IntervalContains                 or // => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalContains), resultTypeHint, args),
                CqlOperator.IntervalExcept                   or // => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalExcept), resultTypeHint, args),
                CqlOperator.IntervalIncludesElement          or // => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalIncludesElement), resultTypeHint, args),
                CqlOperator.IntervalIncludesInterval         or // => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalIncludesInterval), resultTypeHint, args),
                CqlOperator.IntervalIntersect                or // => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalIntersect), resultTypeHint, args),
                CqlOperator.IntervalProperlyIncludesElement  or // => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalProperlyIncludesElement), resultTypeHint, args),
                CqlOperator.IntervalProperlyIncludesInterval or // => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalProperlyIncludesInterval), resultTypeHint, args),
                CqlOperator.IntervalSameAs                   or // => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalSameAs), resultTypeHint, args),
                CqlOperator.IntervalSameOrAfter              or // => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalSameOrAfter), resultTypeHint, args),
                CqlOperator.IntervalSameOrBefore             or // => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalSameOrBefore), resultTypeHint, args),
                CqlOperator.IntervalUnion                    or // => BindToMethodConvertArgs(nameof(ICqlOperators.IntervalUnion), resultTypeHint, args),
                CqlOperator.IsFalse                          or // => BindToMethodConvertArgs(nameof(ICqlOperators.IsFalse), resultTypeHint, args),
                CqlOperator.IsTrue                           or // => BindToMethodConvertArgs(nameof(ICqlOperators.IsTrue), resultTypeHint, args),
                CqlOperator.Last                             or // => BindToMethodConvertArgs(nameof(ICqlOperators.Last), resultTypeHint, args),
                CqlOperator.LastPositionOf                   or // => BindToMethodConvertArgs(nameof(ICqlOperators.LastPositionOf), resultTypeHint, args),
                CqlOperator.Length                           or // => BindToMethodConvertArgs(nameof(ICqlOperators.Length), resultTypeHint, args),
                CqlOperator.Less                             or // => BindToMethodConvertArgs(nameof(ICqlOperators.Less), resultTypeHint, args),
                CqlOperator.LessOrEqual                      or // => BindToMethodConvertArgs(nameof(ICqlOperators.LessOrEqual), resultTypeHint, args),
                CqlOperator.ListContains                     or // => BindToMethodConvertArgs(nameof(ICqlOperators.ListContains), resultTypeHint, args),
                CqlOperator.Distinct                         or // => BindToMethodConvertArgs(nameof(ICqlOperators.Distinct), resultTypeHint, args),
                CqlOperator.ListEqual                        or // => BindToMethodConvertArgs(nameof(ICqlOperators.ListEqual), resultTypeHint, args),
                CqlOperator.ListEquivalent                   or // => BindToMethodConvertArgs(nameof(ICqlOperators.ListEquivalent), resultTypeHint, args),
                CqlOperator.ListExcept                       or // => BindToMethodConvertArgs(nameof(ICqlOperators.ListExcept), resultTypeHint, args),
                CqlOperator.ListIncludesElement              or // => BindToMethodConvertArgs(nameof(ICqlOperators.ListIncludesElement), resultTypeHint, args),
                CqlOperator.ListIncludesList                 or // => BindToMethodConvertArgs(nameof(ICqlOperators.ListIncludesList), resultTypeHint, args),
                CqlOperator.ListIntersect                    or // => BindToMethodConvertArgs(nameof(ICqlOperators.ListIntersect), resultTypeHint, args),
                CqlOperator.ListProperlyIncludesElement      or // => BindToMethodConvertArgs(nameof(ICqlOperators.ListProperlyIncludesElement), resultTypeHint, args),
                CqlOperator.ListProperlyIncludesList         or // => BindToMethodConvertArgs(nameof(ICqlOperators.ListProperlyIncludesList), resultTypeHint, args),
                CqlOperator.ListSort                         or // => BindToMethodConvertArgs(nameof(ICqlOperators.ListSort), resultTypeHint, args),
                CqlOperator.Tail                             or // => BindToMethodConvertArgs(nameof(ICqlOperators.Tail), resultTypeHint, args),
                CqlOperator.Ln                               or // => BindToMethodConvertArgs(nameof(ICqlOperators.Ln), resultTypeHint, args),
                CqlOperator.Log                              or // => BindToMethodConvertArgs(nameof(ICqlOperators.Log), resultTypeHint, args),
                CqlOperator.LowBoundary                      or // => BindToMethodConvertArgs(nameof(ICqlOperators.LowBoundary), resultTypeHint, args),
                CqlOperator.Lower                            or // => BindToMethodConvertArgs(nameof(ICqlOperators.Lower), resultTypeHint, args),
                CqlOperator.Matches                          or // => BindToMethodConvertArgs(nameof(ICqlOperators.Matches), resultTypeHint, args),
                CqlOperator.Max                              or // => BindToMethodConvertArgs(nameof(ICqlOperators.Max), resultTypeHint, args),
                CqlOperator.Median                           or // => BindToMethodConvertArgs(nameof(ICqlOperators.Median), resultTypeHint, args),
                CqlOperator.Meets                            or // => BindToMethodConvertArgs(nameof(ICqlOperators.Meets), resultTypeHint, args),
                CqlOperator.MeetsAfter                       or // => BindToMethodConvertArgs(nameof(ICqlOperators.MeetsAfter), resultTypeHint, args),
                CqlOperator.MeetsBefore                      or // => BindToMethodConvertArgs(nameof(ICqlOperators.MeetsBefore), resultTypeHint, args),
                CqlOperator.Min                              or // => BindToMethodConvertArgs(nameof(ICqlOperators.Min), resultTypeHint, args),
                CqlOperator.Mode                             or // => BindToMethodConvertArgs(nameof(ICqlOperators.Mode), resultTypeHint, args),
                CqlOperator.Modulo                           or // => BindToMethodConvertArgs(nameof(ICqlOperators.Modulo), resultTypeHint, args),
                CqlOperator.Multiply                         or // => BindToMethodConvertArgs(nameof(ICqlOperators.Multiply), resultTypeHint, args),
                CqlOperator.Negate                           or // => BindToMethodConvertArgs(nameof(ICqlOperators.Negate), resultTypeHint, args),
                CqlOperator.Not                              or // => BindToMethodConvertArgs(nameof(ICqlOperators.Not), resultTypeHint, args),
                CqlOperator.Now                              or // => BindToMethodConvertArgs(nameof(ICqlOperators.Now), resultTypeHint),
                CqlOperator.Or                               or // => BindToMethodConvertArgs(nameof(ICqlOperators.Or), resultTypeHint, args),
                CqlOperator.Overlaps                         or // => BindToMethodConvertArgs(nameof(ICqlOperators.Overlaps), resultTypeHint, args),
                CqlOperator.OverlapsAfter                    or // => BindToMethodConvertArgs(nameof(ICqlOperators.OverlapsAfter), resultTypeHint, args),
                CqlOperator.OverlapsBefore                   or // => BindToMethodConvertArgs(nameof(ICqlOperators.OverlapsBefore), resultTypeHint, args),
                CqlOperator.PointFrom                        or // => BindToMethodConvertArgs(nameof(ICqlOperators.PointFrom), resultTypeHint, args),
                CqlOperator.PopulationStdDev                 or // => BindToMethodConvertArgs(nameof(ICqlOperators.PopulationStdDev), resultTypeHint, args),
                CqlOperator.PopulationVariance               or // => BindToMethodConvertArgs(nameof(ICqlOperators.PopulationVariance), resultTypeHint, args),
                CqlOperator.PositionOf                       or // => BindToMethodConvertArgs(nameof(ICqlOperators.IndexOf), resultTypeHint, args),
                CqlOperator.Power                            or // => BindToMethodConvertArgs(nameof(ICqlOperators.Power), resultTypeHint, args),
                CqlOperator.Precision                        or // => BindToMethodConvertArgs(nameof(ICqlOperators.Precision), resultTypeHint, args),
                CqlOperator.Predecessor                      or // => BindToMethodConvertArgs(nameof(ICqlOperators.Predecessor), resultTypeHint, args),
                CqlOperator.Product                          or // => BindToMethodConvertArgs(nameof(ICqlOperators.Product), resultTypeHint, args),
                CqlOperator.Quantity                         or // => BindToMethodConvertArgs(nameof(ICqlOperators.Quantity), resultTypeHint, args),
                CqlOperator.ReplaceMatches                   or // => BindToMethodConvertArgs(nameof(ICqlOperators.ReplaceMatches), resultTypeHint, args),
                CqlOperator.Round                            or // => BindToMethodConvertArgs(nameof(ICqlOperators.Round), resultTypeHint, args),
                CqlOperator.SameAs                           or // => BindToMethodConvertArgs(nameof(ICqlOperators.SameAs), resultTypeHint, args),
                CqlOperator.SameOrAfter                      or // => BindToMethodConvertArgs(nameof(ICqlOperators.SameOrAfter), resultTypeHint, args),
                CqlOperator.SameOrBefore                     or // => BindToMethodConvertArgs(nameof(ICqlOperators.SameOrBefore), resultTypeHint, args),
                CqlOperator.SingletonFrom                    or // => BindToMethodConvertArgs(nameof(ICqlOperators.SingletonFrom), resultTypeHint, args),
                CqlOperator.Slice                            or // => BindToMethodConvertArgs(nameof(ICqlOperators.Slice), resultTypeHint, args),
                CqlOperator.Split                            or // => BindToMethodConvertArgs(nameof(ICqlOperators.Split), resultTypeHint, args),
                CqlOperator.Start                            or // => BindToMethodConvertArgs(nameof(ICqlOperators.Start), resultTypeHint, args),
                CqlOperator.Starts                           or // => BindToMethodConvertArgs(nameof(ICqlOperators.Starts), resultTypeHint, args),
                CqlOperator.StartsWith                       or // => BindToMethodConvertArgs(nameof(ICqlOperators.StartsWith), resultTypeHint, args),
                CqlOperator.StdDev                           or // => BindToMethodConvertArgs(nameof(ICqlOperators.StdDev), resultTypeHint, args),
                CqlOperator.Indexer                          or // => BindToMethodConvertArgs(nameof(ICqlOperators.Indexer), resultTypeHint, args),
                CqlOperator.IndexOf                          or // => BindToMethodConvertArgs(nameof(ICqlOperators.IndexOf), resultTypeHint, args),
                CqlOperator.StringInValueSet                 or // => BindToMethodConvertArgs(nameof(ICqlOperators.StringInValueSet), resultTypeHint, args),
                CqlOperator.StringsInValueSet                or // => BindToMethodConvertArgs(nameof(ICqlOperators.StringsInValueSet), resultTypeHint, args),
                CqlOperator.Substring                        or // => BindToMethodConvertArgs(nameof(ICqlOperators.Substring), resultTypeHint, args),
                CqlOperator.Subtract                         or // => BindToMethodConvertArgs(nameof(ICqlOperators.Subtract), resultTypeHint, args),
                CqlOperator.Successor                        or // => BindToMethodConvertArgs(nameof(ICqlOperators.Successor), resultTypeHint, args),
                CqlOperator.Sum                              or // => BindToMethodConvertArgs(nameof(ICqlOperators.Sum), resultTypeHint, args),
                CqlOperator.Time                             or // => BindToMethodConvertArgs(nameof(ICqlOperators.Time), resultTypeHint, args),
                CqlOperator.TimeComponent                    or // => BindToMethodConvertArgs(nameof(ICqlOperators.TimeComponent), resultTypeHint, args),
                CqlOperator.TimeOfDay                        or // => BindToMethodConvertArgs(nameof(ICqlOperators.TimeOfDay), resultTypeHint),
                CqlOperator.TimezoneOffsetFrom               or // => BindToMethodConvertArgs(nameof(ICqlOperators.TimezoneOffsetFrom), resultTypeHint, args),
                CqlOperator.Today                            or // => BindToMethodConvertArgs(nameof(ICqlOperators.Today), resultTypeHint),
                CqlOperator.Truncate                         or // => BindToMethodConvertArgs(nameof(ICqlOperators.Truncate), resultTypeHint, args),
                CqlOperator.TruncatedDivide                  or // => BindToMethodConvertArgs(nameof(ICqlOperators.TruncatedDivide), resultTypeHint, args),
                CqlOperator.Upper                            or // => BindToMethodConvertArgs(nameof(ICqlOperators.Upper), resultTypeHint, args),
                CqlOperator.Variance                         or // => BindToMethodConvertArgs(nameof(ICqlOperators.Variance), resultTypeHint, args),
                CqlOperator.Xor                              => BindToMethodConvertArgs(@operator.ToString(), resultTypeHint, args),
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