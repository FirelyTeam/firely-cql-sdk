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
    internal class CqlOperatorsBinding : OperatorBinding
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
        public override Expression Bind(
            CqlOperator @operator,
            params Expression[] parameters)
        {
            return @operator switch
            {
                // @formatter:off
                CqlOperator.Aggregate                        => Aggregate(parameters[0], parameters[1], parameters[2]),

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

                CqlOperator.Add                              => BindBinaryOperator(nameof(ICqlOperators.Add), parameters[0], parameters[1]),
                CqlOperator.And                              => BindBinaryOperator(nameof(ICqlOperators.And), parameters[0], parameters[1]),
                CqlOperator.CodeInValueSet                   => BindBinaryOperator(nameof(ICqlOperators.CodeInValueSet), parameters[0], parameters[1]),
                CqlOperator.CodesInValueSet                  => BindBinaryOperator(nameof(ICqlOperators.CodesInValueSet), parameters[0], parameters[1]),
                CqlOperator.Collapse                         => BindBinaryOperator(nameof(ICqlOperators.Collapse), parameters[0], parameters[1]),
                CqlOperator.Combine                          => BindBinaryOperator(nameof(ICqlOperators.Combine), parameters[0], parameters[1]),
                CqlOperator.DateTimeComponent                => BindBinaryOperator(nameof(ICqlOperators.ComponentFrom), parameters[0], parameters[1]),
                CqlOperator.Concatenate                      => BindBinaryOperator(nameof(ICqlOperators.Concatenate), parameters[0], parameters[1]),
                CqlOperator.ConceptInValueSet                => BindBinaryOperator(nameof(ICqlOperators.ConceptInValueSet), parameters[0], parameters[1]),
                CqlOperator.ConceptsInValueSet               => BindBinaryOperator(nameof(ICqlOperators.ConceptsInValueSet), parameters[0], parameters[1]),
                CqlOperator.ConvertQuantity                  => BindBinaryOperator(nameof(ICqlOperators.ConvertQuantity), parameters[0], parameters[1]),
                CqlOperator.Divide                           => BindBinaryOperator(nameof(ICqlOperators.Divide), parameters[0], parameters[1]),
                CqlOperator.EndsWith                         => BindBinaryOperator(nameof(ICqlOperators.EndsWith), parameters[0], parameters[1]),
                CqlOperator.EnumEqualsString                 => BindBinaryOperator(nameof(ICqlOperators.EnumEqualsString), parameters[0], parameters[1]),
                CqlOperator.Equal                            => BindBinaryOperator(nameof(ICqlOperators.Equal), parameters[0], parameters[1]),
                CqlOperator.Equivalent                       => BindBinaryOperator(nameof(ICqlOperators.Equivalent), parameters[0], parameters[1]),
                CqlOperator.Greater                          => BindBinaryOperator(nameof(ICqlOperators.Greater), parameters[0], parameters[1]),
                CqlOperator.GreaterOrEqual                   => BindBinaryOperator(nameof(ICqlOperators.GreaterOrEqual), parameters[0], parameters[1]),
                CqlOperator.HighBoundary                     => BindBinaryOperator(nameof(ICqlOperators.HighBoundary), parameters[0], parameters[1]),
                CqlOperator.Implies                          => BindBinaryOperator(nameof(ICqlOperators.Implies), parameters[0], parameters[1]),
                CqlOperator.IntervalExcept                   => BindBinaryOperator(nameof(ICqlOperators.IntervalExcept), parameters[0], parameters[1]),
                CqlOperator.LastPositionOf                   => BindBinaryOperator(nameof(ICqlOperators.LastPositionOf), parameters[0], parameters[1]),
                CqlOperator.Less                             => BindBinaryOperator(nameof(ICqlOperators.Less), parameters[0], parameters[1]),
                CqlOperator.LessOrEqual                      => BindBinaryOperator(nameof(ICqlOperators.LessOrEqual), parameters[0], parameters[1]),
                CqlOperator.Log                              => BindBinaryOperator(nameof(ICqlOperators.Log), parameters[0], parameters[1]),
                CqlOperator.LowBoundary                      => BindBinaryOperator(nameof(ICqlOperators.LowBoundary), parameters[0], parameters[1]),
                CqlOperator.Matches                          => BindBinaryOperator(nameof(ICqlOperators.Matches), parameters[0], parameters[1]),
                CqlOperator.Modulo                           => BindBinaryOperator(nameof(ICqlOperators.Modulo), parameters[0], parameters[1]),
                CqlOperator.Multiply                         => BindBinaryOperator(nameof(ICqlOperators.Multiply), parameters[0], parameters[1]),
                CqlOperator.Or                               => BindBinaryOperator(nameof(ICqlOperators.Or), parameters[0], parameters[1]),
                CqlOperator.PositionOf                       => BindBinaryOperator(nameof(ICqlOperators.PositionOf), parameters[0], parameters[1]),
                CqlOperator.Pow                              => BindBinaryOperator(nameof(ICqlOperators.Power), parameters[0], parameters[1]),
                CqlOperator.Round                            => BindBinaryOperator(nameof(ICqlOperators.Round), parameters[0], parameters[1]),
                CqlOperator.Split                            => BindBinaryOperator(nameof(ICqlOperators.Split), parameters[0], parameters[1]),
                CqlOperator.StartsWith                       => BindBinaryOperator(nameof(ICqlOperators.StartsWith), parameters[0], parameters[1]),
                CqlOperator.CharAt                           => BindBinaryOperator(nameof(ICqlOperators.StringIndexer), parameters[0], parameters[1]),
                CqlOperator.StringInValueSet                 => BindBinaryOperator(nameof(ICqlOperators.StringInValueSet), parameters[0], parameters[1]),
                CqlOperator.StringsInValueSet                => BindBinaryOperator(nameof(ICqlOperators.StringsInValueSet), parameters[0], parameters[1]),
                CqlOperator.Subtract                         => BindBinaryOperator(nameof(ICqlOperators.Subtract), parameters[0], parameters[1]),
                CqlOperator.TruncatedDivide                  => BindBinaryOperator(nameof(ICqlOperators.TruncateDivide), parameters[0], parameters[1]),
                CqlOperator.Xor                              => BindBinaryOperator(nameof(ICqlOperators.Xor), parameters[0], parameters[1]),
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

                CqlOperator.After                            => BindTernaryOperator(nameof(ICqlOperators.After), parameters[0], parameters[1], parameters[2]),
                CqlOperator.Before                           => BindTernaryOperator(nameof(ICqlOperators.Before), parameters[0], parameters[1], parameters[2]),
                CqlOperator.DifferenceBetween                => BindTernaryOperator(nameof(ICqlOperators.DifferenceBetween), parameters[0], parameters[1], parameters[2]),
                CqlOperator.DurationBetween                  => BindTernaryOperator(nameof(ICqlOperators.DurationBetween), parameters[0], parameters[1], parameters[2]),
                CqlOperator.IntervalAfterInterval            => BindTernaryOperator(nameof(ICqlOperators.IntervalAfterInterval), parameters[0], parameters[1], parameters[2]),
                CqlOperator.IntervalBeforeInterval           => BindTernaryOperator(nameof(ICqlOperators.IntervalBeforeInterval), parameters[0], parameters[1], parameters[2]),
                CqlOperator.IntervalProperlyIncludesElement  => BindTernaryOperator(nameof(ICqlOperators.IntervalProperlyIncludesElement), parameters[0], parameters[1], parameters[2]),
                CqlOperator.Meets                            => BindTernaryOperator(nameof(ICqlOperators.Meets), parameters[0], parameters[1], parameters[2]),
                CqlOperator.MeetsAfter                       => BindTernaryOperator(nameof(ICqlOperators.MeetsAfter), parameters[0], parameters[1], parameters[2]),
                CqlOperator.MeetsBefore                      => BindTernaryOperator(nameof(ICqlOperators.MeetsBefore), parameters[0], parameters[1], parameters[2]),
                CqlOperator.ReplaceMatches                   => BindTernaryOperator(nameof(ICqlOperators.ReplaceMatches), parameters[0], parameters[1], parameters[2]),
                CqlOperator.SameAs                           => BindTernaryOperator(nameof(ICqlOperators.SameAs), parameters[0], parameters[1], parameters[2]),
                CqlOperator.SameOrAfter                      => BindTernaryOperator(nameof(ICqlOperators.SameOrAfter), parameters[0], parameters[1], parameters[2]),
                CqlOperator.SameOrBefore                     => BindTernaryOperator(nameof(ICqlOperators.SameOrBefore), parameters[0], parameters[1], parameters[2]),
                CqlOperator.Substring                        => BindTernaryOperator(nameof(ICqlOperators.Substring), parameters[0], parameters[1], parameters[2]),

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

                CqlOperator.Abs                              => BindUnaryOperator(nameof(ICqlOperators.Abs), parameters[0]),
                CqlOperator.AllTrue                          => BindUnaryOperator(nameof(ICqlOperators.AllTrue), parameters[0]),
                CqlOperator.AnyTrue                          => BindUnaryOperator(nameof(ICqlOperators.AnyTrue), parameters[0]),
                CqlOperator.Avg                              => BindUnaryOperator(nameof(ICqlOperators.Avg), parameters[0]),
                CqlOperator.Ceiling                          => BindUnaryOperator(nameof(ICqlOperators.Ceiling), parameters[0]),
                CqlOperator.ConvertsToDate                   => BindUnaryOperator(nameof(ICqlOperators.ConvertsToDate), parameters[0]),
                CqlOperator.ConvertsToDateTime               => BindUnaryOperator(nameof(ICqlOperators.ConvertsToDateTime), parameters[0]),
                CqlOperator.ConvertsToDecimal                => BindUnaryOperator(nameof(ICqlOperators.ConvertsToDecimal), parameters[0]),
                CqlOperator.ConvertsToInteger                => BindUnaryOperator(nameof(ICqlOperators.ConvertsToInteger), parameters[0]),
                CqlOperator.ConvertsToLong                   => BindUnaryOperator(nameof(ICqlOperators.ConvertsToLong), parameters[0]),
                CqlOperator.ConvertsToQuantity               => BindUnaryOperator(nameof(ICqlOperators.ConvertsToQuantity), parameters[0]),
                CqlOperator.ConvertsToString                 => BindUnaryOperator(nameof(ICqlOperators.ConvertsToString), parameters[0]),
                CqlOperator.ConvertsToTime                   => BindUnaryOperator(nameof(ICqlOperators.ConvertsToTime), parameters[0]),
                CqlOperator.DateComponent                    => BindUnaryOperator(nameof(ICqlOperators.DateFrom), parameters[0]),
                CqlOperator.Descendents                      => BindUnaryOperator(nameof(ICqlOperators.Descendents), parameters[0]),
                CqlOperator.IntervalEnd                      => BindUnaryOperator(nameof(ICqlOperators.End), parameters[0]),
                CqlOperator.Exp                              => BindUnaryOperator(nameof(ICqlOperators.Exp), parameters[0]),
                CqlOperator.Floor                            => BindUnaryOperator(nameof(ICqlOperators.Floor), parameters[0]),
                CqlOperator.GeometricMean                    => BindUnaryOperator(nameof(ICqlOperators.GeometricMean), parameters[0]),
                CqlOperator.IsFalse                          => BindUnaryOperator(nameof(ICqlOperators.IsFalse), parameters[0]),
                CqlOperator.IsTrue                           => BindUnaryOperator(nameof(ICqlOperators.IsTrue), parameters[0]),
                CqlOperator.Ln                               => BindUnaryOperator(nameof(ICqlOperators.Ln), parameters[0]),
                CqlOperator.Lower                            => BindUnaryOperator(nameof(ICqlOperators.Lower), parameters[0]),
                CqlOperator.Median                           => BindUnaryOperator(nameof(ICqlOperators.Median), parameters[0]),
                CqlOperator.Negate                           => BindUnaryOperator(nameof(ICqlOperators.Negate), parameters[0]),
                CqlOperator.Not                              => BindUnaryOperator(nameof(ICqlOperators.Not), parameters[0]),
                CqlOperator.PopulationStdDev                 => BindUnaryOperator(nameof(ICqlOperators.PopulationStdDev), parameters[0]),
                CqlOperator.PopulationVariance               => BindUnaryOperator(nameof(ICqlOperators.PopulationVariance), parameters[0]),
                CqlOperator.Precision                        => BindUnaryOperator(nameof(ICqlOperators.Precision), parameters[0]),
                CqlOperator.Predecessor                      => BindUnaryOperator(nameof(ICqlOperators.Predecessor), parameters[0]),
                CqlOperator.Product                          => BindUnaryOperator(nameof(ICqlOperators.Product), parameters[0]),
                CqlOperator.IntervalStart                    => BindUnaryOperator(nameof(ICqlOperators.Start), parameters[0]),
                CqlOperator.StdDev                           => BindUnaryOperator(nameof(ICqlOperators.StdDev), parameters[0]),
                CqlOperator.StringLength                     => BindUnaryOperator(nameof(ICqlOperators.StringLength), parameters[0]),
                CqlOperator.Successor                        => BindUnaryOperator(nameof(ICqlOperators.Successor), parameters[0]),
                CqlOperator.Sum                              => BindUnaryOperator(nameof(ICqlOperators.Sum), parameters[0]),
                CqlOperator.TimeComponent                    => BindUnaryOperator(nameof(ICqlOperators.TimeFrom), parameters[0]),
                CqlOperator.TimeZoneComponent                => BindUnaryOperator(nameof(ICqlOperators.TimezoneOffsetFrom), parameters[0]),
                CqlOperator.Truncate                         => BindUnaryOperator(nameof(ICqlOperators.Truncate), parameters[0]),
                CqlOperator.Upper                            => BindUnaryOperator(nameof(ICqlOperators.Upper), parameters[0]),
                CqlOperator.Variance                         => BindUnaryOperator(nameof(ICqlOperators.Variance), parameters[0]),

                CqlOperator.CalculateAge                     => BindUnaryOperatorWithPrecision(nameof(ICqlOperators.CalculateAge), parameters[0], parameters[1]),
                CqlOperator.Coalesce                         => Coalesce(parameters[0]),
                CqlOperator.CrossJoin                        => CrossJoin(parameters),
                CqlOperator.Expand                           => Expand(parameters[0], parameters[1]),

                CqlOperator.Date                             => CqlContextExpressions.Call_CqlContext_Operators(CqlContextExpressions.CqlContext_Operators_Type.GetMethod(nameof(ICqlOperators.Date))!, parameters[0], parameters[1], parameters[2]),
                CqlOperator.DateTime                         => CqlContextExpressions.Call_CqlContext_Operators(CqlContextExpressions.CqlContext_Operators_Type.GetMethod(nameof(ICqlOperators.DateTime))!, parameters[0], parameters[1], parameters[2], parameters[3], parameters[4], parameters[5], parameters[6], parameters[7]),
                CqlOperator.Now                              => CqlContextExpressions.Call_CqlContext_Operators(CqlContextExpressions.CqlContext_Operators_Type.GetMethod(nameof(ICqlOperators.Now))!),
                CqlOperator.Quantity                         => CqlContextExpressions.Call_CqlContext_Operators(CqlContextExpressions.CqlContext_Operators_Type.GetMethod(nameof(ICqlOperators.Quantity))!, parameters[0], parameters[1]),
                CqlOperator.Time                             => CqlContextExpressions.Call_CqlContext_Operators(CqlContextExpressions.CqlContext_Operators_Type.GetMethod(nameof(ICqlOperators.Time))!, parameters[0], parameters[1], parameters[2], parameters[3]),
                CqlOperator.TimeOfDay                        => CqlContextExpressions.Call_CqlContext_Operators(CqlContextExpressions.CqlContext_Operators_Type.GetMethod(nameof(ICqlOperators.TimeOfDay))!),
                CqlOperator.Today                            => CqlContextExpressions.Call_CqlContext_Operators(CqlContextExpressions.CqlContext_Operators_Type.GetMethod(nameof(ICqlOperators.Today))!),
                CqlOperator.Flatten                          => Flatten(parameters[0]),
                CqlOperator.InList                           => InList(parameters[0], parameters[1]),
                CqlOperator.Interval                         => Interval(parameters[0], parameters[1], parameters[2], parameters[3]),
                CqlOperator.LateBoundProperty                => LateBoundProperty(parameters[0], parameters[1], parameters[2]),
                CqlOperator.ListUnion                        => ListUnion(parameters[0], parameters[1]),
                CqlOperator.MaximumValue                     => Maximum(parameters[0]),
                CqlOperator.Message                          => Message(parameters),
                CqlOperator.MinimumValue                     => Minimum(parameters[0]),
                CqlOperator.ResolveValueSet                  => ResolveValueSet(parameters[0]),
                CqlOperator.Retrieve                         => Retrieve(parameters[0], parameters[1], parameters[2]),
                CqlOperator.Select                           => Select(parameters[0], parameters[1]),
                CqlOperator.SelectMany                       => SelectMany(source: parameters[0], collectionSelectorLambda: parameters[1]),
                CqlOperator.SelectManyResults                => SelectManyResults(source: parameters[0], collectionSelectorLambda: parameters[1], resultSelectorLambda: parameters[2]),
                CqlOperator.SortBy                           => SortBy(parameters[0], parameters[1], parameters[2]),
                CqlOperator.ToList                           => ToList(parameters),
                CqlOperator.Where                            => Where(parameters[0], parameters[1]),
                CqlOperator.Width                            => Width(parameters[0]),
                CqlOperator.Ratio
                or CqlOperator.PropertyOrDefault
                or _                                         => throw new NotSupportedException($"Operator {Enum.GetName(typeof(CqlOperator), @operator)} is not supported by this binding.")
                // @formatter:on
            };
        }

        private Expression CrossJoin(Expression[] sources)
        {
            var genericDefinitionMethodCrossJoin = CqlContextExpressions.CqlContext_Operators_Type
                    .GetMethods(BindingFlags.Public | BindingFlags.Instance)
                    .SingleOrDefault(mi =>
                        mi.Name == nameof(ICqlOperators.CrossJoin)
                        && mi.GetGenericArguments().Length == sources.Length)
                ?? throw new NotSupportedException($"No CrossJoin support for '{sources.Length}' source(s).");

            Type[] sourceListElementTypes =
                sources.SelectToArray(s => TypeResolver.GetListElementType(s.Type, true)!);

            var methodCrossJoin = genericDefinitionMethodCrossJoin.MakeGenericMethod(sourceListElementTypes);

            return CqlContextExpressions.Call_CqlContext_Operators(methodCrossJoin, sources);
        }

        private Expression ToList(Expression[] parameters)
        {
            var method = CqlContextExpressions.CqlContext_Operators_Type
                .GetMethod(nameof(ICqlOperators.ToList))!
                .MakeGenericMethod(parameters[0].Type);
            var call = CqlContextExpressions.Call_CqlContext_Operators(method, parameters[0]);
            return call;
        }

        private Expression Expand(
            Expression argument,
            Expression perQuantity)
        {
            if (perQuantity is ConstantExpression ce && ce.Value == null)
                perQuantity = Expression.Constant(null, typeof(CqlQuantity));
            if (IsOrImplementsIEnumerableOfT(argument.Type))
            {

                var elementType = TypeResolver.GetListElementType(argument.Type)!;
                if (elementType == null)
                    throw new ArgumentException($"Unable to determine element type for Expand argument.", nameof(argument));
                if (IsInterval(elementType))
                {
                    var methods = CqlContextExpressions.CqlContext_Operators_Type
                        .GetMethods(BindingFlags.Public | BindingFlags.Instance)
                        .Where(m => m.Name == nameof(ICqlOperators.ExpandList)).ToList();
                    foreach (var method in methods)
                    {
                        var methodParameters = method.GetParameters();
                        if (methodParameters.Length == 2)
                        {
                            var operandConversion = CanConvert(argument.Type, methodParameters[0].ParameterType);
                            if (operandConversion == ConversionType.Incompatible)
                                continue;
                            var call = CqlContextExpressions.Call_CqlContext_Operators(method, argument, perQuantity);
                            return call;
                        }
                    }
                    throw new ArgumentException($"No suitable unary method {nameof(ICqlOperators.ExpandList)}({argument.Type}) could be found.", nameof(ICqlOperators.ExpandList));
                }
                else throw new ArgumentException($"Expand expects a list element type to be an interval.", nameof(argument));
            }
            else if (IsInterval(argument.Type))
            {
                var methods = CqlContextExpressions.CqlContext_Operators_Type
                        .GetMethods(BindingFlags.Public | BindingFlags.Instance)
                        .Where(m => m.Name == nameof(ICqlOperators.ExpandInterval)).ToList();
                foreach (var method in methods)
                {
                    var methodParameters = method.GetParameters();
                    if (methodParameters.Length == 2)
                    {
                        var operandConversion = CanConvert(argument.Type, methodParameters[0].ParameterType);
                        if (operandConversion == ConversionType.Incompatible)
                            continue;
                        var call = CqlContextExpressions.Call_CqlContext_Operators(method, argument, perQuantity);
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
                var method = CqlContextExpressions.CqlContext_Operators_Type
                    .GetMethod(nameof(ICqlOperators.ListSortBy))!
                    .MakeGenericMethod(elementType);
                var call = CqlContextExpressions.Call_CqlContext_Operators(method, source, lambda, orderConstant);
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
                    return BindBinaryOperator(nameof(ICqlOperators.CodeInList), left, right);
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
                return BindBinaryOperator(nameof(ICqlOperators.ValueSetUnion),
                    Expression.TypeAs(left, typeof(IEnumerable<CqlCode>)),
                    Expression.TypeAs(right, typeof(IEnumerable<CqlCode>)));
            }
            var leftElementType = TypeResolver.GetListElementType(left.Type);
            if (leftElementType == typeof(CqlCode))
            {
                var rightElementType = TypeResolver.GetListElementType(right.Type);
                if (rightElementType == typeof(CqlCode))
                {
                    return BindBinaryOperator(nameof(ICqlOperators.ValueSetUnion), left, right);
                }
            }

            return BindBinaryGenericOperator(nameof(ICqlOperators.ListUnion), left, right);
        }

        private Expression ResolveValueSet(Expression expression)
        {
            if (expression is NewExpression @new && @new.Type == typeof(CqlValueSet))
            {
                var method = CqlContextExpressions.CqlContext_Operators_Type.GetMethod(nameof(ICqlOperators.ResolveValueSet))!;
                var call = CqlContextExpressions.Call_CqlContext_Operators(method, @new);
                return call;
            }
            else throw new ArgumentException("Expression should be a constant CqlValueSet");
        }

        private Expression Minimum(Expression typeConstant)
        {
            if (typeConstant is ConstantExpression constant && constant.Value is Type t)
            {
                var method = CqlContextExpressions.CqlContext_Operators_Type.GetMethod(nameof(ICqlOperators.Minimum))!
                    .MakeGenericMethod(t);
                var call = CqlContextExpressions.Call_CqlContext_Operators(method);
                return call;
            }
            else throw new ArgumentException("Expression should be a constant expression whose type is Type", nameof(typeConstant));
        }

        private Expression Maximum(Expression typeConstant)
        {
            if (typeConstant is ConstantExpression constant && constant.Value is Type t)
            {
                var method = CqlContextExpressions.CqlContext_Operators_Type.GetMethod(nameof(ICqlOperators.Maximum))!
                    .MakeGenericMethod(t);
                var call = CqlContextExpressions.Call_CqlContext_Operators(method);
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
                        var method = CqlContextExpressions.CqlContext_Operators_Type.GetMethod(nameof(ICqlOperators.CoalesceValueTypes))!
                            .MakeGenericMethod(underlying);
                        var call = CqlContextExpressions.Call_CqlContext_Operators(method, operand);
                        return call;
                    }
                    else
                    {
                        var method = CqlContextExpressions.CqlContext_Operators_Type.GetMethod(nameof(ICqlOperators.CoalesceValueTypes))!
                            .MakeGenericMethod(genericArgumentType);
                        var call = CqlContextExpressions.Call_CqlContext_Operators(method, operand);
                        return call;
                    }
                }
                else
                {
                    var method = CqlContextExpressions.CqlContext_Operators_Type.GetMethod(nameof(ICqlOperators.Coalesce))!
                        .MakeGenericMethod(genericArgumentType);
                    var call = CqlContextExpressions.Call_CqlContext_Operators(method, operand);
                    return call;
                }
            }
            throw new ArgumentException("Operands to this method must be generic with a single generic type parameter, e.g. IEnumerable<T>", nameof(operand));

        }

        private Expression Flatten(Expression operand)
        {
            var elementType = TypeResolver.GetListElementType(operand.Type, throwError: true)!;
            if (IsOrImplementsIEnumerableOfT(elementType))
            {
                var nestedElementType = TypeResolver.GetListElementType(elementType) ?? throw new InvalidOperationException($"'{elementType}' was expected to be a list type.");
                var method = CqlContextExpressions.CqlContext_Operators_Type
                        .GetMethod(nameof(ICqlOperators.FlattenList))!
                        .MakeGenericMethod(nestedElementType);
                var call = CqlContextExpressions.Call_CqlContext_Operators(method, operand);
                return call;
            }
            else if (elementType == typeof(object))
            {
                // This scenario can happen in late-bound property chains
                var method = CqlContextExpressions.CqlContext_Operators_Type
                    .GetMethod(nameof(ICqlOperators.FlattenLateBoundList))!;
                var call = CqlContextExpressions.Call_CqlContext_Operators(method, operand);
                return call;
            }
            else return operand; // flatten is being called on a list that is already flat.
        }

        private Expression Width(Expression operand)
        {
            // This should be disallowed but isn't, so handle it:
            if (operand.Type == typeof(CqlInterval<object>))
                return Expression.Constant(null, typeof(int?));
            else return BindUnaryOperator(nameof(ICqlOperators.Width), operand);
        }

        private MethodCallExpression LateBoundProperty(
            Expression source,
            Expression propertyName,
            Expression typeExpression)
        {
            if (typeExpression is ConstantExpression constExpression)
            {
                var type = constExpression.Value as Type;
                var method = CqlContextExpressions.CqlContext_Operators_Type.GetMethod(nameof(ICqlOperators.LateBoundProperty))!
                    .MakeGenericMethod(type!);
                if (source.Type != typeof(object))
                    source = Expression.TypeAs(source, typeof(object));
                var call = CqlContextExpressions.Call_CqlContext_Operators(method, source, propertyName);
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

            var exactMethod = CqlContextExpressions.CqlContext_Operators_Type.GetMethod(nameof(ICqlOperators.Interval),
                new[] { low.Type, high.Type, typeof(bool?), typeof(bool?) });
            if (exactMethod != null)
            {
                var call = CqlContextExpressions.Call_CqlContext_Operators(exactMethod, low, high, lowClosed, highClosed);
                return call;
            }
            else
            {
                var methods = CqlContextExpressions.CqlContext_Operators_Type
                    .GetMethods(BindingFlags.Public | BindingFlags.Instance)
                    .Where(m => m.Name == nameof(ICqlOperators.Interval));
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
                        var call = CqlContextExpressions.Call_CqlContext_Operators(method, low, high, lowClosed, highClosed);
                        return call;
                    }
                }
            }
            throw new ArgumentException($"No suitable Interval method could be found for {low.Type}", nameof(low));
        }

        private MethodCallExpression Message(Expression[] parameters)
        {
            var messageMethod = CqlContextExpressions.CqlContext_Operators_Type.GetMethod(nameof(ICqlOperators.Message))!
                .MakeGenericMethod(parameters[0].Type);
            return CqlContextExpressions.Call_CqlContext_Operators(messageMethod, parameters[0], parameters[1], parameters[2], parameters[3]);
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
                    var method = CqlContextExpressions.CqlContext_Operators_Type.GetMethod(methodName);
                    if (method == null)
                        throw new ArgumentException($"No conversion method implemented; expecting {methodName}", nameof(typeExpression));
                    var call = CqlContextExpressions.Call_CqlContext_Operators(method, source);
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

        protected MethodCallExpression BindBinaryOperator(
            string methodName,
            Expression left,
            Expression right)
        {
            var methods = CqlContextExpressions.CqlContext_Operators_Type
                .GetMethods(BindingFlags.Public | BindingFlags.Instance)
                .Where(m => m.Name == methodName && !m.IsGenericMethod);
            foreach (var method in methods)
            {
                var methodParameters = method.GetParameters();
                if (methodParameters.Length == 2)
                {
                    var leftConversion = CanConvert(left.Type, methodParameters[0].ParameterType);
                    var rightConversion = CanConvert(right.Type, methodParameters[1].ParameterType);
                    if (leftConversion == ConversionType.Incompatible || rightConversion == ConversionType.Incompatible)
                        continue;
                    left = Convert(left, methodParameters[0].ParameterType, leftConversion);
                    right = Convert(right, methodParameters[1].ParameterType, rightConversion);

                    var call = CqlContextExpressions.Call_CqlContext_Operators(method, left, right);
                    return call;
                }
            }
            throw new ArgumentException($"No suitable binary method {methodName}({left.Type}, {right.Type}) could be found.", nameof(methodName));
        }

        protected MethodCallExpression BindTernaryOperator(
            string methodName,
            Expression first,
            Expression second,
            Expression third)
        {
            var methods = CqlContextExpressions.CqlContext_Operators_Type
                .GetMethods(BindingFlags.Public | BindingFlags.Instance)
                .Where(m => m.Name == methodName);
            foreach (var method in methods)
            {
                var methodParameters = method.GetParameters();
                if (methodParameters.Length == 3)
                {
                    var firstConversion = CanConvert(first.Type, methodParameters[0].ParameterType);
                    var secondConversion = CanConvert(second.Type, methodParameters[1].ParameterType);
                    var thirdConversion = CanConvert(third.Type, methodParameters[2].ParameterType);

                    if (firstConversion == ConversionType.Incompatible
                        || secondConversion == ConversionType.Incompatible
                        || thirdConversion == ConversionType.Incompatible)
                        continue;
                    first = Convert(first, methodParameters[0].ParameterType, firstConversion);
                    second = Convert(second, methodParameters[1].ParameterType, secondConversion);
                    third = Convert(third, methodParameters[2].ParameterType, thirdConversion);
                    var call = CqlContextExpressions.Call_CqlContext_Operators(method, first, second, third);
                    return call;
                }
            }

            throw new ArgumentException($"No suitable binary method {methodName}({first.Type}, {second.Type}) could be found.", nameof(methodName));
        }

        protected MethodCallExpression BindBinaryOperatorWithPrecision(
            string methodName,
            Expression left,
            Expression right,
            Expression precision)
        {
            var methods = CqlContextExpressions.CqlContext_Operators_Type
                .GetMethods(BindingFlags.Public | BindingFlags.Instance)
                .Where(m => m.Name == methodName);
            foreach (var method in methods)
            {
                var methodParameters = method.GetParameters();
                if (methodParameters.Length > 1)
                {
                    var leftConversion = CanConvert(left.Type, methodParameters[0].ParameterType);
                    var rightConversion = CanConvert(right.Type, methodParameters[1].ParameterType);
                    if (leftConversion == ConversionType.Incompatible
                        || rightConversion == ConversionType.Incompatible)
                    {
                        continue;
                    }
                    else
                    {
                        left = Convert(left, methodParameters[0].ParameterType, leftConversion);
                        right = Convert(right, methodParameters[1].ParameterType, rightConversion);
                        if (methodParameters.Length > 2)
                        {
                            var precisionConversion = CanConvert(precision.Type, methodParameters[2].ParameterType);
                            if (precisionConversion == ConversionType.Incompatible)
                                continue;
                            precision = Convert(precision, methodParameters[2].ParameterType, precisionConversion);
                            return CqlContextExpressions.Call_CqlContext_Operators(method, left, right, precision);

                        }
                        else
                            return CqlContextExpressions.Call_CqlContext_Operators(method, left, right);
                    }
                }
            }
            throw new ArgumentException($"No suitable binary method {methodName}({left.Type}, {right.Type}) could be found.", nameof(methodName));
        }

        protected MethodCallExpression BindUnaryOperator(
            string methodName,
            Expression operand)
        {
            var methods = CqlContextExpressions.CqlContext_Operators_Type
                .GetMethods(BindingFlags.Public | BindingFlags.Instance)
                .Where(m => m.Name == methodName);
            foreach (var method in methods)
            {
                var methodParameters = method.GetParameters();
                if (methodParameters.Length == 1)
                {
                    var operandConversion = CanConvert(operand.Type, methodParameters[0].ParameterType);
                    if (operandConversion == ConversionType.Incompatible)
                        continue;
                    var operandParameter = operand;
                    if (operandConversion == ConversionType.Convertible)
                        operandParameter = Convert(operandParameter, methodParameters[0].ParameterType, operandConversion);
                    else if (operandConversion == ConversionType.Assignable)
                        operandParameter = Expression.TypeAs(operandParameter, methodParameters[0].ParameterType);
                    var call = CqlContextExpressions.Call_CqlContext_Operators(method, operandParameter);
                    return call;
                }
            }
            throw new ArgumentException($"No suitable unary method {methodName}({operand.Type}) could be found.", nameof(methodName));
        }

        protected MethodCallExpression BindUnaryOperatorWithPrecision(
            string methodName,
            Expression operand,
            Expression precision)
        {
            var methods = CqlContextExpressions.CqlContext_Operators_Type
                .GetMethods(BindingFlags.Public | BindingFlags.Instance)
                .Where(m => m.Name == methodName);
            foreach (var method in methods)
            {
                var methodParameters = method.GetParameters();
                if (methodParameters.Length == 2)
                {
                    var operandConversion = CanConvert(operand.Type, methodParameters[0].ParameterType);
                    if (operandConversion == ConversionType.Incompatible)
                        continue;
                    var operandParameter = operand;
                    if (operandConversion == ConversionType.Convertible)
                        operandParameter = Convert(operandParameter, methodParameters[0].ParameterType, operandConversion);
                    else if (operandConversion == ConversionType.Assignable)
                        operandParameter = Expression.TypeAs(operandParameter, methodParameters[0].ParameterType);
                    var call = CqlContextExpressions.Call_CqlContext_Operators(method, operandParameter, precision);
                    return call;
                }
            }
            throw new ArgumentException($"No suitable unary method {methodName}({operand.Type}) could be found.", nameof(methodName));
        }


        /// <summary>
        /// Calls methods with a signature of Method%lt;T&gt;(Argument%lt;T&gt;)
        /// </summary>
        protected MethodCallExpression BindUnaryGenericOperator(
            string methodName,
            Expression operand)
        {
            Type? elementType = null;
            if (operand.Type.IsGenericType)
            {
                var operandGenericArguments = operand.Type.GetGenericArguments();
                elementType = operandGenericArguments[0];
            }
            else if (IsOrImplementsIEnumerableOfT(operand.Type))
                elementType = TypeResolver.GetListElementType(operand.Type);

            if (elementType != null)
            {
                var methods = CqlContextExpressions.CqlContext_Operators_Type
                    .GetMethods(BindingFlags.Public | BindingFlags.Instance)
                    .Where(m => m.Name == methodName && m.IsGenericMethod && m.GetGenericArguments().Length == 1);
                foreach (var method in methods)
                {
                    var genericMethod = method.MakeGenericMethod(elementType);
                    var methodParameters = genericMethod.GetParameters();
                    if (methodParameters.Length == 1)
                    {
                        var operandConversion = CanConvert(operand.Type, methodParameters[0].ParameterType);
                        if (operandConversion == ConversionType.Incompatible)
                            continue;
                        var operandParameter = operand;
                        if (operandConversion == ConversionType.Convertible)
                            operandParameter = Convert(operandParameter, methodParameters[0].ParameterType, operandConversion);

                        var call = CqlContextExpressions.Call_CqlContext_Operators(genericMethod, operandParameter);
                        return call;
                    }
                }
                throw new ArgumentException($"No suitable unary method {methodName}({operand.Type}) could be found.", nameof(methodName));
            }
            throw new ArgumentException("Operands to this method must be generic with a single generic type parameter, e.g. IEnumerable<T>", nameof(operand));
        }

        protected MethodCallExpression BindBinaryGenericOperator(
            string methodName,
            Expression left,
            Expression right,
            bool genericArgumentFromRight = false)
        {
            var methods = CqlContextExpressions.CqlContext_Operators_Type
                .GetMethods(BindingFlags.Public | BindingFlags.Instance)
                .Where(m => m.Name == methodName && m.IsGenericMethod);
            foreach (var method in methods)
            {
                var methodParameters = method.GetParameters();
                if (methodParameters.Length == 2)
                {
                    Type? genericType;
                    if (genericArgumentFromRight)
                        genericType = right.Type.GetGenericArguments()[0];
                    else
                        genericType = left.Type.GetGenericArguments()[0];
                    var genericMethod = method.MakeGenericMethod(genericType);
                    methodParameters = genericMethod.GetParameters();
                    var leftConversion = CanConvert(left.Type, methodParameters[0].ParameterType);
                    var rightConversion = CanConvert(right.Type, methodParameters[1].ParameterType);
                    if (leftConversion == ConversionType.Incompatible || rightConversion == ConversionType.Incompatible)
                        continue;
                    left = Convert(left, methodParameters[0].ParameterType, leftConversion);
                    right = Convert(right, methodParameters[1].ParameterType, rightConversion);
                    var call = CqlContextExpressions.Call_CqlContext_Operators(genericMethod, left, right);
                    return call;
                }
            }
            throw new ArgumentException($"No suitable binary method {methodName}({left.Type}, {right.Type}) could be found.", nameof(methodName));
        }

        protected Expression BindBinaryGenericOperatorOrNull(
            string methodName,
            Expression left,
            Expression right,
            bool genericArgumentFromRight = false)
        {
            var methods = CqlContextExpressions.CqlContext_Operators_Type
                .GetMethods(BindingFlags.Public | BindingFlags.Instance)
                .Where(m => m.Name == methodName && m.IsGenericMethod);
            foreach (var method in methods)
            {
                var methodParameters = method.GetParameters();
                if (methodParameters.Length == 2)
                {
                    Type? genericType;
                    if (genericArgumentFromRight)
                        genericType = right.Type.GetGenericArguments()[0];
                    else
                        genericType = left.Type.GetGenericArguments()[0];
                    var genericMethod = method.MakeGenericMethod(genericType);
                    methodParameters = genericMethod.GetParameters();
                    var leftConversion = CanConvert(left.Type, methodParameters[0].ParameterType);
                    var rightConversion = CanConvert(right.Type, methodParameters[1].ParameterType);
                    if (leftConversion == ConversionType.Incompatible || rightConversion == ConversionType.Incompatible)
                        continue;
                    left = Convert(left, methodParameters[0].ParameterType, leftConversion);
                    right = Convert(right, methodParameters[1].ParameterType, rightConversion);
                    var call = CqlContextExpressions.Call_CqlContext_Operators(genericMethod, left, right);
                    return call;
                }
            }
            return Expression.Constant(null, typeof(object));
        }

        protected MethodCallExpression BindTernaryGenericOperator(
            string methodName,
            Expression left,
            Expression right,
            Expression precision,
            bool genericParameterFromRight = false)
        {
            var methods = CqlContextExpressions.CqlContext_Operators_Type
                .GetMethods(BindingFlags.Public | BindingFlags.Instance)
                .Where(m => m.Name == methodName && m.IsGenericMethod);
            foreach (var method in methods)
            {
                var methodParameters = method.GetParameters();
                if (methodParameters.Length == 3)
                {
                    Type? genericType = null;
                    if (genericParameterFromRight)
                    {
                        genericType = right.Type.GetGenericArguments()[0];
                    }
                    else
                    {
                        genericType = left.Type.GetGenericArguments()[0];
                    }
                    var genericMethod = method.MakeGenericMethod(genericType);
                    methodParameters = genericMethod.GetParameters();
                    var leftConversion = CanConvert(left.Type, methodParameters[0].ParameterType);
                    var rightConversion = CanConvert(right.Type, methodParameters[1].ParameterType);
                    var precisionConversion = CanConvert(precision.Type, methodParameters[2].ParameterType);
                    if (leftConversion == ConversionType.Incompatible
                        || rightConversion == ConversionType.Incompatible
                        || precisionConversion == ConversionType.Incompatible)
                        continue;
                    left = Convert(left, methodParameters[0].ParameterType, leftConversion);
                    right = Convert(right, methodParameters[1].ParameterType, rightConversion);
                    precision = Convert(precision, methodParameters[2].ParameterType, precisionConversion);
                    var call = CqlContextExpressions.Call_CqlContext_Operators(genericMethod, left, right, precision);
                    return call;
                }
            }
            throw new ArgumentException($"No suitable binary method {methodName}({left.Type}, {right.Type}) could be found.", nameof(methodName));
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
            else if (IsOrImplementsIEnumerableOfT(codes.Type))
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
                else if (IsOrImplementsIEnumerableOfT(elementType) && TypeResolver.GetListElementType(elementType) == typeof(CqlCode))
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

            var call = CqlContextExpressions.Call_CqlContext_Operators(forType, codes, codeProperty);
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
                var method = CqlContextExpressions.CqlContext_Operators_Type.GetMethod(nameof(ICqlOperators.SelectOrNull))!;
                var genericMethod = method.MakeGenericMethod(sourceType, resultType);
                var call = CqlContextExpressions.Call_CqlContext_Operators(genericMethod, source, lambda);
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
                var method = CqlContextExpressions.CqlContext_Operators_Type.GetMethod(nameof(ICqlOperators.WhereOrNull))!;
                var genericMethod = method.MakeGenericMethod(sourceType);
                var call = CqlContextExpressions.Call_CqlContext_Operators(genericMethod, source, lambda);
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
                if (IsOrImplementsIEnumerableOfT(collectionSelector.ReturnType))
                {
                    var secondGenericArgument = TypeResolver.GetListElementType(collectionSelector.ReturnType) ?? throw new InvalidOperationException($"{collectionSelector.Type} was expected to be a list type.");
                    var method = CqlContextExpressions.CqlContext_Operators_Type.GetMethod(nameof(ICqlOperators.SelectManyOrNull))!;
                    var genericMethod = method.MakeGenericMethod(
                        firstGenericArgument,
                        secondGenericArgument);
                    var call = CqlContextExpressions.Call_CqlContext_Operators(genericMethod, source, collectionSelector);
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
            if (collectionSelectorLambda is LambdaExpression collectionSelector)
            {
                var firstGenericArgument = TypeResolver.GetListElementType(source.Type) ?? throw new InvalidOperationException($"{source.Type} was expected to be a list type.");
                if (IsOrImplementsIEnumerableOfT(collectionSelector.ReturnType))
                {
                    var secondGenericArgument = TypeResolver.GetListElementType(collectionSelector.ReturnType) ?? throw new InvalidOperationException($"{collectionSelector.Type} was expected to be a list type.");
                    if (resultSelectorLambda is LambdaExpression resultSelector)
                    {
                        var method = CqlContextExpressions.CqlContext_Operators_Type.GetMethod(nameof(ICqlOperators.SelectManyResultsOrNull))!;
                        var genericMethod = method.MakeGenericMethod(
                            firstGenericArgument,
                            secondGenericArgument,
                            resultSelector.ReturnType);
                        var call = CqlContextExpressions.Call_CqlContext_Operators(genericMethod, source, collectionSelector, resultSelector);
                        return call;
                    }
                    else throw new ArgumentException("Result expression is not a lambda", nameof(resultSelectorLambda));

                }
                else throw new ArgumentException("Collection lambda does not return an IEnumerable", nameof(collectionSelectorLambda));
            }
            else throw new ArgumentException("Source is not generic", nameof(source));
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
                ConversionType.Convertible => buildConvertCall(),
                _ => throw new ArgumentException($"Cannot convert source to {destinationType}", nameof(source)),
            };

            Expression buildConvertCall()
            {
                var method = typeof(ICqlOperators).GetMethod(nameof(ICqlOperators.Convert))!
                    .MakeGenericMethod(destinationType);
                source = Expression.TypeAs(source, typeof(object));
                var call = CqlContextExpressions.Call_CqlContext_Operators(method, source);
                return call;
            }
        }

        private MethodCallExpression Aggregate(
            Expression source,
            Expression lambda,
            Expression seed)
        {
            var sourceType = TypeResolver.GetListElementType(source.Type, false) ??
                throw new ArgumentException($"Cannot resolve element type for {source.Type.Name}", nameof(source));
            var accumulateType = seed.Type;
            var method = CqlContextExpressions.CqlContext_Operators_Type.GetMethod(nameof(ICqlOperators.AggregateOrNull))!;
            var genericMethod = method.MakeGenericMethod(sourceType, accumulateType);
            var call = CqlContextExpressions.Call_CqlContext_Operators(genericMethod, source, seed, lambda);
            return call;
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

        protected bool IsOrImplementsIEnumerableOfT(Type type) => TypeResolver.ImplementsGenericInterface(type, typeof(IEnumerable<>));

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