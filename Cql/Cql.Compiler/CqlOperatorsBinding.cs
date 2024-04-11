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
using ListSortDirection = System.ComponentModel.ListSortDirection;

namespace Hl7.Cql.Compiler
{
    /// <summary>
    /// Implements <see cref="OperatorBinding"/> by calling methods in <see cref="CqlOperators"/>.
    /// </summary>
    internal class CqlOperatorsBinding : OperatorBinding
    {
        internal TypeConverter? TypeConverter { get; private set; }
        internal TypeResolver TypeResolver { get; private set; }

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
        public CqlOperatorsBinding(TypeResolver typeResolver, TypeConverter? typeConverter = null)
        {
            TypeConverter = typeConverter;
            TypeResolver = typeResolver;
        }

        protected virtual PropertyInfo OperatorsProperty => typeof(CqlContext).GetProperty(nameof(CqlContext.Operators))!;

        protected virtual Type OperatorsType => OperatorsProperty.PropertyType;

        /// <summary>
        /// Binds <paramref name="operator"/> to an <see cref="Expression"/>.
        /// </summary>
        /// <param name="operator">The operator to bind.</param>
        /// <param name="runtimeContext">The <see cref="Expression"/> that provides access to the <see cref="CqlContext"/>.</param>
        /// <param name="parameters">Zero or more parameter <see cref="Expression"/>s.  The number and order of expressions is dependent on <paramref name="operator"/>.</param>
        /// <returns>An expression that implements <paramref name="operator"/>.  In most cases, this will be a <see cref="MethodCallExpression"/>.</returns>
        public override Expression Bind(CqlOperator @operator, Expression runtimeContext, params Expression[] parameters)
        {
            if (!typeof(CqlContext).IsAssignableFrom(runtimeContext.Type))
                throw new ArgumentException($"The second parameter to {nameof(Bind)} must be a {nameof(CqlContext)} expression", nameof(runtimeContext));
            var operators = Expression.Property(runtimeContext, OperatorsProperty);
            switch (@operator)
            {
                case CqlOperator.And:
                    return BindBinaryOperator(nameof(ICqlOperators.And), operators, parameters[0], parameters[1]);
                case CqlOperator.Or:
                    return BindBinaryOperator(nameof(ICqlOperators.Or), operators, parameters[0], parameters[1]);
                case CqlOperator.Xor:
                    return BindBinaryOperator(nameof(ICqlOperators.Xor), operators, parameters[0], parameters[1]);
                case CqlOperator.Select:
                    return Select(operators, parameters[0], parameters[1]);
                case CqlOperator.Convert:
                    return BindConvert(operators, parameters[0], parameters[1]);
                case CqlOperator.Coalesce:
                    return Coalesce(operators, parameters[0]);
                case CqlOperator.IsFalse:
                    return BindUnaryOperator(nameof(ICqlOperators.IsFalse), operators, parameters[0]);
                case CqlOperator.IsTrue:
                    return BindUnaryOperator(nameof(ICqlOperators.IsTrue), operators, parameters[0]);
                case CqlOperator.ListEqual:
                    return BindBinaryGenericOperator(nameof(ICqlOperators.ListEqual), operators, parameters[0], parameters[1]);
                case CqlOperator.ListEquivalent:
                    return BindBinaryGenericOperator(nameof(ICqlOperators.ListEquivalent), operators, parameters[0], parameters[1]);
                case CqlOperator.EnumEqualsString:
                    return BindBinaryOperator(nameof(ICqlOperators.EnumEqualsString), operators, parameters[0], parameters[1]);
                case CqlOperator.Equivalent:
                    return BindBinaryOperator(nameof(ICqlOperators.Equivalent), operators, parameters[0], parameters[1]);
                case CqlOperator.Greater:
                    return BindBinaryOperator(nameof(ICqlOperators.Greater), operators, parameters[0], parameters[1]);
                case CqlOperator.GreaterOrEqual:
                    return BindBinaryOperator(nameof(ICqlOperators.GreaterOrEqual), operators, parameters[0], parameters[1]);
                case CqlOperator.Less:
                    return BindBinaryOperator(nameof(ICqlOperators.Less), operators, parameters[0], parameters[1]);
                case CqlOperator.LessOrEqual:
                    return BindBinaryOperator(nameof(ICqlOperators.LessOrEqual), operators, parameters[0], parameters[1]);
                case CqlOperator.Negate:
                    return BindUnaryOperator(nameof(ICqlOperators.Negate), operators, parameters[0]);
                case CqlOperator.Abs:
                    return BindUnaryOperator(nameof(ICqlOperators.Abs), operators, parameters[0]);
                case CqlOperator.Add:
                    return BindBinaryOperator(nameof(ICqlOperators.Add), operators, parameters[0], parameters[1]);
                case CqlOperator.Ceiling:
                    return BindUnaryOperator(nameof(ICqlOperators.Ceiling), operators, parameters[0]);
                case CqlOperator.Divide:
                    return BindBinaryOperator(nameof(ICqlOperators.Divide), operators, parameters[0], parameters[1]);
                case CqlOperator.Floor:
                    return BindUnaryOperator(nameof(ICqlOperators.Floor), operators, parameters[0]);
                case CqlOperator.Exp:
                    return BindUnaryOperator(nameof(ICqlOperators.Exp), operators, parameters[0]);
                case CqlOperator.HighBoundary:
                    return BindBinaryOperator(nameof(ICqlOperators.HighBoundary), operators, parameters[0], parameters[1]);
                case CqlOperator.Log:
                    return BindBinaryOperator(nameof(ICqlOperators.Log), operators, parameters[0], parameters[1]);
                case CqlOperator.LowBoundary:
                    return BindBinaryOperator(nameof(ICqlOperators.LowBoundary), operators, parameters[0], parameters[1]);
                case CqlOperator.Ln:
                    return BindUnaryOperator(nameof(ICqlOperators.Ln), operators, parameters[0]);
                case CqlOperator.Modulo:
                    return BindBinaryOperator(nameof(ICqlOperators.Modulo), operators, parameters[0], parameters[1]);
                case CqlOperator.Multiply:
                    return BindBinaryOperator(nameof(ICqlOperators.Multiply), operators, parameters[0], parameters[1]);
                case CqlOperator.Not:
                    return BindUnaryOperator(nameof(ICqlOperators.Not), operators, parameters[0]);
                case CqlOperator.Precision:
                    return BindUnaryOperator(nameof(ICqlOperators.Precision), operators, parameters[0]);
                case CqlOperator.Predecessor:
                    return BindUnaryOperator(nameof(ICqlOperators.Predecessor), operators, parameters[0]);
                case CqlOperator.Pow:
                    return BindBinaryOperator(nameof(ICqlOperators.Power), operators, parameters[0], parameters[1]);
                case CqlOperator.Round:
                    return BindBinaryOperator(nameof(ICqlOperators.Round), operators, parameters[0], parameters[1]);
                case CqlOperator.Subtract:
                    return BindBinaryOperator(nameof(ICqlOperators.Subtract), operators, parameters[0], parameters[1]);
                case CqlOperator.Successor:
                    return BindUnaryOperator(nameof(ICqlOperators.Successor), operators, parameters[0]);
                case CqlOperator.Truncate:
                    return BindUnaryOperator(nameof(ICqlOperators.Truncate), operators, parameters[0]);
                case CqlOperator.TruncatedDivide:
                    return BindBinaryOperator(nameof(ICqlOperators.TruncateDivide), operators, parameters[0], parameters[1]);
                case CqlOperator.Concatenate:
                    return BindBinaryOperator(nameof(ICqlOperators.Concatenate), operators, parameters[0], parameters[1]);
                case CqlOperator.Combine:
                    return BindBinaryOperator(nameof(ICqlOperators.Combine), operators, parameters[0], parameters[1]);
                case CqlOperator.EndsWith:
                    return BindBinaryOperator(nameof(ICqlOperators.EndsWith), operators, parameters[0], parameters[1]);
                case CqlOperator.CharAt:
                    return BindBinaryOperator(nameof(ICqlOperators.StringIndexer), operators, parameters[0], parameters[1]);
                case CqlOperator.ElementAt:
                    return BindBinaryGenericOperator(nameof(ICqlOperators.ListElementAt), operators, parameters[0], parameters[1]);
                case CqlOperator.LastPositionOf:
                    return BindBinaryOperator(nameof(ICqlOperators.LastPositionOf), operators, parameters[0], parameters[1]);
                case CqlOperator.ListLength:
                    return BindUnaryGenericOperator(nameof(ICqlOperators.ListLength), operators, parameters[0]);
                case CqlOperator.StringLength:
                    return BindUnaryOperator(nameof(ICqlOperators.StringLength), operators, parameters[0]);
                case CqlOperator.Lower:
                    return BindUnaryOperator(nameof(ICqlOperators.Lower), operators, parameters[0]);
                case CqlOperator.Matches:
                    return BindBinaryOperator(nameof(ICqlOperators.Matches), operators, parameters[0], parameters[1]);
                case CqlOperator.PositionOf:
                    return BindBinaryOperator(nameof(ICqlOperators.PositionOf), operators, parameters[0], parameters[1]);
                case CqlOperator.ReplaceMatches:
                    return BindTernaryOperator(nameof(ICqlOperators.ReplaceMatches), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.Split:
                    return BindBinaryOperator(nameof(ICqlOperators.Split), operators, parameters[0], parameters[1]);
                case CqlOperator.StartsWith:
                    return BindBinaryOperator(nameof(ICqlOperators.StartsWith), operators, parameters[0], parameters[1]);
                case CqlOperator.Substring:
                    return BindTernaryOperator(nameof(ICqlOperators.Substring), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.Upper:
                    return BindUnaryOperator(nameof(ICqlOperators.Upper), operators, parameters[0]);
                case CqlOperator.IntervalAfterInterval:
                    return BindTernaryOperator(nameof(ICqlOperators.IntervalAfterInterval), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.IntervalAfterElement:
                    return BindBinaryOperatorWithPrecision(nameof(ICqlOperators.IntervalAfterElement), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.ElementAfterInterval:
                    return BindBinaryOperatorWithPrecision(nameof(ICqlOperators.ElementAfterInterval), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.After:
                    return BindTernaryOperator(nameof(ICqlOperators.After), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.IntervalBeforeInterval:
                    return BindTernaryOperator(nameof(ICqlOperators.IntervalBeforeInterval), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.IntervalBeforeElement:
                    return BindBinaryOperatorWithPrecision(nameof(ICqlOperators.IntervalBeforeElement), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.ElementBeforeInterval:
                    return BindBinaryOperatorWithPrecision(nameof(ICqlOperators.ElementBeforeInterval), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.Before:
                    return BindTernaryOperator(nameof(ICqlOperators.Before), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.Date:
                    return Expression.Call(operators,
                        OperatorsType.GetMethod(nameof(ICqlOperators.Date))!,
                        parameters[0],
                        parameters[1],
                        parameters[2]);
                case CqlOperator.DateTime:
                    return Expression.Call(operators,
                        OperatorsType.GetMethod(nameof(ICqlOperators.DateTime))!,
                        parameters[0],
                        parameters[1],
                        parameters[2],
                        parameters[3],
                        parameters[4],
                        parameters[5],
                        parameters[6],
                        parameters[7]);
                case CqlOperator.DateComponent:
                    return BindUnaryOperator(nameof(ICqlOperators.DateFrom), operators, parameters[0]);
                case CqlOperator.TimeComponent:
                    return BindUnaryOperator(nameof(ICqlOperators.TimeFrom), operators, parameters[0]);
                case CqlOperator.TimeZoneComponent:
                    return BindUnaryOperator(nameof(ICqlOperators.TimezoneOffsetFrom), operators, parameters[0]);
                case CqlOperator.DateTimeComponent:
                    return BindBinaryOperator(nameof(ICqlOperators.ComponentFrom), operators, parameters[0], parameters[1]);
                case CqlOperator.DifferenceBetween:
                    return BindTernaryOperator(nameof(ICqlOperators.DifferenceBetween), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.DurationBetween:
                    return BindTernaryOperator(nameof(ICqlOperators.DurationBetween), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.Now:
                    return Expression.Call(operators,
                        OperatorsType.GetMethod(nameof(ICqlOperators.Now))!);
                case CqlOperator.IntervalSameAs:
                    return BindTernaryGenericOperator(nameof(ICqlOperators.IntervalSameAs), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.SameAs:
                    return BindTernaryOperator(nameof(ICqlOperators.SameAs), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.IntervalSameOrAfter:
                    return BindBinaryOperatorWithPrecision(nameof(ICqlOperators.IntervalSameOrAfter), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.SameOrAfter:
                    return BindTernaryOperator(nameof(ICqlOperators.SameOrAfter), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.IntervalSameOrBefore:
                    return BindBinaryOperatorWithPrecision(nameof(ICqlOperators.IntervalSameOrBefore), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.SameOrBefore:
                    return BindTernaryOperator(nameof(ICqlOperators.SameOrBefore), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.Time:
                    return Expression.Call(operators,
                        OperatorsType.GetMethod(nameof(ICqlOperators.Time))!,
                        parameters[0],
                        parameters[1],
                        parameters[2],
                        parameters[3]);
                case CqlOperator.TimeOfDay:
                    return Expression.Call(operators,
                        OperatorsType.GetMethod(nameof(ICqlOperators.TimeOfDay))!);
                case CqlOperator.Today:
                    return Expression.Call(operators,
                        OperatorsType.GetMethod(nameof(ICqlOperators.Today))!);
                case CqlOperator.Collapse:
                    return BindBinaryOperator(nameof(ICqlOperators.Collapse), operators, parameters[0], parameters[1]);
                case CqlOperator.ListContains:
                    return BindBinaryGenericOperator(nameof(ICqlOperators.ListContains), operators, parameters[0], parameters[1]);
                case CqlOperator.IntervalContains:
                    return BindBinaryOperatorWithPrecision(nameof(ICqlOperators.IntervalContains), operators, parameters[0], parameters[1], parameters[2]);
                //return BindTernaryGenericOperator(nameof(ICqlOperators.IntervalContains), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.IntervalEnd:
                    return BindUnaryOperator(nameof(ICqlOperators.End), operators, parameters[0]);
                case CqlOperator.IntervalStart:
                    return BindUnaryOperator(nameof(ICqlOperators.Start), operators, parameters[0]);
                case CqlOperator.Ends:
                    return BindTernaryGenericOperator(nameof(ICqlOperators.Ends), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.ListExcept:
                    return BindBinaryGenericOperator(nameof(ICqlOperators.ListExcept), operators, parameters[0], parameters[1]);
                case CqlOperator.IntervalExcept:
                    return BindBinaryOperator(nameof(ICqlOperators.IntervalExcept), operators, parameters[0], parameters[1]);
                case CqlOperator.Expand:
                    return Expand(operators, parameters[0], parameters[1]);
                case CqlOperator.InList:
                    return InList(operators, parameters[0], parameters[1]);
                case CqlOperator.InInterval:
                    return BindTernaryGenericOperator(nameof(ICqlOperators.ElementInInterval), operators, parameters[0], parameters[1], parameters[2], true);
                case CqlOperator.ListIncludesList:
                    return BindBinaryGenericOperator(nameof(ICqlOperators.ListIncludesList), operators, parameters[0], parameters[1]);
                case CqlOperator.ListIncludesElement:
                    return BindBinaryGenericOperator(nameof(ICqlOperators.ListIncludesElement), operators, parameters[0], parameters[1]);
                case CqlOperator.IntervalIncludesInterval:
                    return BindTernaryGenericOperator(nameof(ICqlOperators.IntervalIncludesInterval), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.IntervalIncludesElement:
                    return BindTernaryGenericOperator(nameof(ICqlOperators.IntervalIncludesElement), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.ListIntersect:
                    return BindBinaryGenericOperator(nameof(ICqlOperators.ListIntersect), operators, parameters[0], parameters[1]);
                case CqlOperator.IntervalIntersect:
                    return BindBinaryGenericOperator(nameof(ICqlOperators.IntervalIntersectsInterval), operators, parameters[0], parameters[1]);
                case CqlOperator.Meets:
                    return BindTernaryOperator(nameof(ICqlOperators.Meets), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.MeetsAfter:
                    return BindTernaryOperator(nameof(ICqlOperators.MeetsAfter), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.MeetsBefore:
                    return BindTernaryOperator(nameof(ICqlOperators.MeetsBefore), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.Overlaps:
                    return BindBinaryOperatorWithPrecision(nameof(ICqlOperators.Overlaps), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.OverlapsBefore:
                    return BindBinaryOperatorWithPrecision(nameof(ICqlOperators.OverlapsBefore), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.OverlapsAfter:
                    return BindBinaryOperatorWithPrecision(nameof(ICqlOperators.OverlapsAfter), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.PointFrom:
                    return BindUnaryGenericOperator(nameof(ICqlOperators.PointFrom), operators, parameters[0]);
                case CqlOperator.IntervalProperlyIncludesInterval:
                    return BindTernaryGenericOperator(nameof(ICqlOperators.IntervalProperlyIncludesInterval), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.ListProperlyIncludesList:
                    return BindBinaryGenericOperator(nameof(ICqlOperators.ListProperlyIncludesList), operators, parameters[0], parameters[1]);
                case CqlOperator.ListProperlyIncludesElement:
                    return BindBinaryGenericOperator(nameof(ICqlOperators.ListProperlyIncludesElement), operators, parameters[0], parameters[1]);
                case CqlOperator.IntervalProperlyIncludesElement:
                    if (parameters.Length == 2)
                        return BindBinaryGenericOperator(nameof(ICqlOperators.IntervalProperlyIncludesElement), operators, parameters[0], parameters[1]);
                    else
                        return BindTernaryOperator(nameof(ICqlOperators.IntervalProperlyIncludesElement), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.Starts:
                    return BindTernaryGenericOperator(nameof(ICqlOperators.Starts), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.ListUnion:
                    return ListUnion(operators, parameters[0], parameters[1]);
                case CqlOperator.IntervalUnion:
                    return BindBinaryGenericOperator(nameof(ICqlOperators.IntervalUnion), operators, parameters[0], parameters[1]);
                case CqlOperator.Width:
                    return Width(operators, parameters[0]);
                case CqlOperator.Distinct:
                    return BindUnaryGenericOperator(nameof(ICqlOperators.ListDistinct), operators, parameters[0]);
                case CqlOperator.Exists:
                    return BindUnaryGenericOperator(nameof(ICqlOperators.ExistsInList), operators, parameters[0]);
                case CqlOperator.Flatten:
                    return Flatten(operators, parameters[0]);
                case CqlOperator.IndexOf:
                    return BindBinaryGenericOperator(nameof(ICqlOperators.ListIndex), operators, parameters[0], parameters[1]);
                case CqlOperator.First:
                    return BindUnaryGenericOperator(nameof(ICqlOperators.FirstOfList), operators, parameters[0]);
                case CqlOperator.Last:
                    return BindUnaryGenericOperator(nameof(ICqlOperators.LastOfList), operators, parameters[0]);
                case CqlOperator.Tail:
                    return BindUnaryGenericOperator(nameof(ICqlOperators.ListTail), operators, parameters[0]);
                case CqlOperator.AllTrue:
                    return BindUnaryOperator(nameof(ICqlOperators.AllTrue), operators, parameters[0]);
                case CqlOperator.AnyTrue:
                    return BindUnaryOperator(nameof(ICqlOperators.AnyTrue), operators, parameters[0]);
                case CqlOperator.Avg:
                    return BindUnaryOperator(nameof(ICqlOperators.Avg), operators, parameters[0]);
                case CqlOperator.Count:
                    return BindUnaryGenericOperator(nameof(ICqlOperators.CountOrNull), operators, parameters[0]);
                case CqlOperator.MaxElementInList:
                    return BindUnaryGenericOperator(nameof(ICqlOperators.MaxOrNull), operators, parameters[0]);
                case CqlOperator.MinElementInList:
                    return BindUnaryGenericOperator(nameof(ICqlOperators.MinOrNull), operators, parameters[0]);
                case CqlOperator.Median:
                    return BindUnaryOperator(nameof(ICqlOperators.Median), operators, parameters[0]);
                case CqlOperator.GeometricMean:
                    return BindUnaryOperator(nameof(ICqlOperators.GeometricMean), operators, parameters[0]);
                case CqlOperator.Mode:
                    return BindUnaryGenericOperator(nameof(ICqlOperators.Mode), operators, parameters[0]);
                case CqlOperator.PopulationStdDev:
                    return BindUnaryOperator(nameof(ICqlOperators.PopulationStdDev), operators, parameters[0]);
                case CqlOperator.PopulationVariance:
                    return BindUnaryOperator(nameof(ICqlOperators.PopulationVariance), operators, parameters[0]);
                case CqlOperator.StdDev:
                    return BindUnaryOperator(nameof(ICqlOperators.StdDev), operators, parameters[0]);
                case CqlOperator.Sum:
                    return BindUnaryOperator(nameof(ICqlOperators.Sum), operators, parameters[0]);
                case CqlOperator.Product:
                    return BindUnaryOperator(nameof(ICqlOperators.Product), operators, parameters[0]);
                case CqlOperator.Variance:
                    return BindUnaryOperator(nameof(ICqlOperators.Variance), operators, parameters[0]);
                case CqlOperator.Slice:
                    return BindTernaryGenericOperator(nameof(ICqlOperators.Slice), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.Message:
                    return Message(operators, parameters);
                case CqlOperator.SelectMany:
                    return SelectMany(operators, parameters[0], parameters[1]);
                case CqlOperator.SelectManyResults:
                    return SelectManyResults(operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.Where:
                    return Where(operators, parameters[0], parameters[1]);
                case CqlOperator.Sort:
                    return BindBinaryGenericOperator(nameof(ICqlOperators.ListSort), operators, parameters[0], parameters[1]);
                case CqlOperator.Single:
                    return BindUnaryGenericOperator(nameof(ICqlOperators.SingleOrNull), operators, parameters[0]);
                case CqlOperator.Quantity:
                    return Expression.Call(operators,
                        OperatorsType.GetMethod(nameof(ICqlOperators.Quantity))!,
                        parameters[0],
                        parameters[1]);
                case CqlOperator.Interval:
                    return Interval(operators, parameters[0], parameters[1], parameters[2], parameters[3]);
                case CqlOperator.Retrieve:
                    return Retrieve(operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.LateBoundProperty:
                    return LateBoundProperty(operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.Equal:
                    return BindBinaryOperator(nameof(ICqlOperators.Equal), operators, parameters[0], parameters[1]);
                case CqlOperator.CodeInValueSet:
                    return BindBinaryOperator(nameof(ICqlOperators.CodeInValueSet), operators, parameters[0], parameters[1]);
                case CqlOperator.CalculateAge:
                    return BindUnaryOperatorWithPrecision(nameof(ICqlOperators.CalculateAge), operators, parameters[0], parameters[1]);
                case CqlOperator.CalculateAgeAt:
                    return BindBinaryOperatorWithPrecision(nameof(ICqlOperators.CalculateAgeAt), operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.MinimumValue:
                    return Minimum(operators, parameters[0]);
                case CqlOperator.MaximumValue:
                    return Maximum(operators, parameters[0]);
                case CqlOperator.ResolveValueSet:
                    return ResolveValueSet(operators, parameters[0]);
                case CqlOperator.Ratio:
                    break;
                case CqlOperator.ToList:
                    {
                        var method = OperatorsType
                                .GetMethod(nameof(ICqlOperators.ToList))!
                                .MakeGenericMethod(parameters[0].Type);
                        var call = Expression.Call(operators, method, parameters[0]);
                        return call;
                    }
                case CqlOperator.CodesInValueSet:
                    return BindBinaryOperator(nameof(ICqlOperators.CodesInValueSet), operators, parameters[0], parameters[1]);
                case CqlOperator.ConceptsInValueSet:
                    return BindBinaryOperator(nameof(ICqlOperators.ConceptsInValueSet), operators, parameters[0], parameters[1]);
                case CqlOperator.StringsInValueSet:
                    return BindBinaryOperator(nameof(ICqlOperators.StringsInValueSet), operators, parameters[0], parameters[1]);
                case CqlOperator.ConceptInValueSet:
                    return BindBinaryOperator(nameof(ICqlOperators.ConceptInValueSet), operators, parameters[0], parameters[1]);
                case CqlOperator.StringInValueSet:
                    return BindBinaryOperator(nameof(ICqlOperators.StringInValueSet), operators, parameters[0], parameters[1]);
                case CqlOperator.ConvertsToInteger:
                    return BindUnaryOperator(nameof(ICqlOperators.ConvertsToInteger), operators, parameters[0]);
                case CqlOperator.ConvertsToLong:
                    return BindUnaryOperator(nameof(ICqlOperators.ConvertsToLong), operators, parameters[0]);
                case CqlOperator.ConvertsToDecimal:
                    return BindUnaryOperator(nameof(ICqlOperators.ConvertsToDecimal), operators, parameters[0]);
                case CqlOperator.ConvertsToDateTime:
                    return BindUnaryOperator(nameof(ICqlOperators.ConvertsToDateTime), operators, parameters[0]);
                case CqlOperator.ConvertsToDate:
                    return BindUnaryOperator(nameof(ICqlOperators.ConvertsToDate), operators, parameters[0]);
                case CqlOperator.ConvertsToTime:
                    return BindUnaryOperator(nameof(ICqlOperators.ConvertsToTime), operators, parameters[0]);
                case CqlOperator.ConvertsToString:
                    return BindUnaryOperator(nameof(ICqlOperators.ConvertsToString), operators, parameters[0]);
                case CqlOperator.ConvertsToQuantity:
                    return BindUnaryOperator(nameof(ICqlOperators.ConvertsToQuantity), operators, parameters[0]);
                case CqlOperator.ConvertQuantity:
                    return BindBinaryOperator(nameof(ICqlOperators.ConvertQuantity), operators, parameters[0], parameters[1]);
                case CqlOperator.Descendents:
                    return BindUnaryOperator(nameof(ICqlOperators.Descendents), operators, parameters[0]);
                case CqlOperator.SortBy:
                    return SortBy(operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.Aggregate:
                    return Aggregate(operators, parameters[0], parameters[1], parameters[2]);
                case CqlOperator.Implies:
                    return BindBinaryOperator(nameof(ICqlOperators.Implies), operators, parameters[0], parameters[1]);
                default:
                    break;
            }
            throw new NotSupportedException($"Operator {Enum.GetName(typeof(CqlOperator), @operator)} is not supported by this binding.");

        }

        private Expression Expand(MemberExpression operators, Expression argument, Expression perQuantity)
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
                    var methods = OperatorsType
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
                            var call = Expression.Call(operators, method, argument, perQuantity);
                            return call;
                        }
                    }
                    throw new ArgumentException($"No suitable unary method {nameof(ICqlOperators.ExpandList)}({argument.Type}) could be found.", nameof(ICqlOperators.ExpandList));
                }
                else throw new ArgumentException($"Expand expects a list element type to be an interval.", nameof(argument));
            }
            else if (IsInterval(argument.Type))
            {
                var methods = OperatorsType
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
                        var call = Expression.Call(operators, method, argument, perQuantity);
                        return call;
                    }
                }
                throw new ArgumentException($"No suitable unary method {nameof(ICqlOperators.ExpandInterval)}({argument.Type}) could be found.", nameof(ICqlOperators.ExpandInterval));
            }
            else throw new ArgumentException($"Expand allows only a List<Interval<T>> or an Interval<T> as a parameter.", nameof(argument));
        }

        private Expression SortBy(MemberExpression operators, Expression source, Expression by, Expression order)
        {
            if (by is LambdaExpression lambda && order is ConstantExpression orderConstant && orderConstant.Type == typeof(ListSortDirection))
            {
                var elementType = TypeResolver.GetListElementType(source.Type) ?? throw new InvalidOperationException($"{source.Type} was expected to be a list type.");
                var method = OperatorsType
                    .GetMethod(nameof(ICqlOperators.ListSortBy))!
                    .MakeGenericMethod(elementType);
                var call = Expression.Call(operators, method, source, lambda, orderConstant);
                return call;

            }
            else throw new ArgumentException("SortBy expects 3 parameters: source, lambda, and SortOrder constant", nameof(by));
        }

        private Expression InList(MemberExpression operators, Expression left, Expression right)
        {
            if (left.Type == typeof(CqlCode))
            {
                var rightElementType = TypeResolver.GetListElementType(right.Type);
                if (rightElementType == typeof(CqlCode))
                {
                    return BindBinaryOperator(nameof(ICqlOperators.CodeInList), operators, left, right);
                }
            }
            return BindBinaryGenericOperatorOrNull(nameof(ICqlOperators.InList), operators, left, right, true);
        }

        private Expression ListUnion(MemberExpression operators, Expression left, Expression right)
        {
            if (left.Type == typeof(IValueSetFacade) && right.Type == typeof(IValueSetFacade))
            {
                return BindBinaryOperator(nameof(ICqlOperators.ValueSetUnion), operators,
                    Expression.TypeAs(left, typeof(IEnumerable<CqlCode>)),
                    Expression.TypeAs(right, typeof(IEnumerable<CqlCode>)));
            }
            var leftElementType = TypeResolver.GetListElementType(left.Type);
            if (leftElementType == typeof(CqlCode))
            {
                var rightElementType = TypeResolver.GetListElementType(right.Type);
                if (rightElementType == typeof(CqlCode))
                {
                    return BindBinaryOperator(nameof(ICqlOperators.ValueSetUnion), operators, left, right);
                }
            }

            return BindBinaryGenericOperator(nameof(ICqlOperators.ListUnion), operators, left, right);
        }

        private Expression ResolveValueSet(MemberExpression operators, Expression expression)
        {
            if (expression is NewExpression @new && @new.Type == typeof(CqlValueSet))
            {
                var method = OperatorsType.GetMethod(nameof(ICqlOperators.ResolveValueSet))!;
                var call = Expression.Call(operators, method, @new);
                return call;
            }
            else throw new ArgumentException("Expression should be a constant CqlValueSet");
        }

        private Expression Minimum(MemberExpression operators, Expression typeConstant)
        {
            if (typeConstant is ConstantExpression constant && constant.Value is Type t)
            {
                var method = OperatorsType.GetMethod(nameof(ICqlOperators.Minimum))!
                    .MakeGenericMethod(t);
                var call = Expression.Call(operators, method);
                return call;
            }
            else throw new ArgumentException("Expression should be a constant expression whose type is Type", nameof(typeConstant));
        }

        private Expression Maximum(MemberExpression operators, Expression typeConstant)
        {
            if (typeConstant is ConstantExpression constant && constant.Value is Type t)
            {
                var method = OperatorsType.GetMethod(nameof(ICqlOperators.Maximum))!
                    .MakeGenericMethod(t);
                var call = Expression.Call(operators, method);
                return call;
            }
            else throw new ArgumentException("Expression should be a constant expression whose type is Type", nameof(typeConstant));
        }

        private Expression Coalesce(MemberExpression operators, Expression operand)
        {
            if (operand.Type.IsGenericType)
            {
                var genericArgumentType = operand.Type.GetGenericArguments()[0];
                if (genericArgumentType.IsValueType)
                {

                    if (genericArgumentType.IsGenericType && genericArgumentType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    {
                        var underlying = Nullable.GetUnderlyingType(genericArgumentType)!;
                        var method = OperatorsType.GetMethod(nameof(ICqlOperators.CoalesceValueTypes))!
                            .MakeGenericMethod(underlying);
                        var call = Expression.Call(operators, method, operand);
                        return call;
                    }
                    else
                    {
                        var method = OperatorsType.GetMethod(nameof(ICqlOperators.CoalesceValueTypes))!
                            .MakeGenericMethod(genericArgumentType);
                        var call = Expression.Call(operators, method, operand);
                        return call;
                    }
                }
                else
                {
                    var method = OperatorsType.GetMethod(nameof(ICqlOperators.Coalesce))!
                        .MakeGenericMethod(genericArgumentType);
                    var call = Expression.Call(operators, method, operand);
                    return call;
                }
            }
            throw new ArgumentException("Operands to this method must be generic with a single generic type parameter, e.g. IEnumerable<T>", nameof(operand));

        }

        private Expression Flatten(MemberExpression operators, Expression operand)
        {
            var elementType = TypeResolver.GetListElementType(operand.Type, @throw: true)!;
            if (IsOrImplementsIEnumerableOfT(elementType))
            {
                var nestedElementType = TypeResolver.GetListElementType(elementType) ?? throw new InvalidOperationException($"{elementType} was expected to be a list type.");
                var method = OperatorsType
                        .GetMethod(nameof(ICqlOperators.FlattenList))!
                        .MakeGenericMethod(nestedElementType);
                var call = Expression.Call(operators, method, operand);
                return call;
            }
            else if (elementType == typeof(object))
            {
                // This scenario can happen in late-bound property chains
                var method = OperatorsType
                    .GetMethod(nameof(ICqlOperators.FlattenLateBoundList))!;
                var call = Expression.Call(operators, method, operand);
                return call;
            }
            else return operand; // flatten is being called on a list that is already flat.
            throw new ArgumentException("Operands to this method must be an enumeration of enumerations, e.g. IEnumerable<IEnumerable<object>>", nameof(operand));
        }

        private Expression Width(MemberExpression operators, Expression operand)
        {
            // This should be disallowed but isn't, so handle it:
            if (operand.Type == typeof(Primitives.CqlInterval<object>))
                return Expression.Constant(null, typeof(int?));
            else return BindUnaryOperator(nameof(ICqlOperators.Width), operators, operand);
        }

        private MethodCallExpression LateBoundProperty(MemberExpression operators, Expression source, Expression propertyName, Expression typeExpression)
        {
            if (typeExpression is ConstantExpression constExpression)
            {
                var type = constExpression.Value as Type;
                var method = OperatorsType.GetMethod(nameof(ICqlOperators.LateBoundProperty))!
                    .MakeGenericMethod(type!);
                if (source.Type != typeof(object))
                    source = Expression.TypeAs(source, typeof(object));
                var call = Expression.Call(operators, method, source, propertyName);
                return call;
            }
            else throw new ArgumentException("Expected constant type expression", nameof(typeExpression));
        }

        private Expression Interval(MemberExpression operators, Expression low, Expression high, Expression lowClosed, Expression highClosed)
        {
            if ((low is ConstantExpression lce && lce.Value == null)
                && (high is ConstantExpression hce && hce.Value == null))
            {
                if (low.Type == high.Type)
                {
                    return Expression.Constant(null, typeof(Primitives.CqlInterval<>).MakeGenericType(low.Type));
                }
                else return Expression.Constant(null, typeof(Primitives.CqlInterval<object>));

            }

            var exactMethod = OperatorsType.GetMethod(nameof(ICqlOperators.Interval),
                new[] { low.Type, high.Type, typeof(bool?), typeof(bool?) });
            if (exactMethod != null)
            {
                var call = Expression.Call(operators, exactMethod, low, high, lowClosed, highClosed);
                return call;
            }
            else
            {
                var methods = OperatorsType
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
                        low = Convert(low, methodParameters[0].ParameterType, operators, lowConversion);
                        high = Convert(high, methodParameters[1].ParameterType, operators, highConversion);
                        var call = Expression.Call(operators, method, low, high, lowClosed, highClosed);
                        return call;
                    }
                }
            }
            throw new ArgumentException($"No suitable Interval method could be found for {low.Type}", nameof(low));
        }

        private MethodCallExpression Message(MemberExpression operators, Expression[] parameters)
        {
            var messageMethod = OperatorsType.GetMethod(nameof(ICqlOperators.Message))!
                .MakeGenericMethod(parameters[0].Type);
            return Expression.Call(operators, messageMethod, parameters[0], parameters[1], parameters[2], parameters[3]);
        }

        /// <summary>
        /// Handles explicit conversions, i.e., the Convert operator
        /// </summary>
        private Expression BindConvert(MemberExpression operators, Expression source, Expression typeExpression)
        {
            if (typeExpression is ConstantExpression constExpression && constExpression.Value is Type to)
            {
                var methodName = CqlOperators.ConversionFunctionName(source.Type, to);
                if (methodName != null)
                {
                    var method = OperatorsType.GetMethod(methodName);
                    if (method == null)
                        throw new ArgumentException($"No conversion method implemented; expecting {methodName}", nameof(typeExpression));
                    var call = Expression.Call(operators, method, source);
                    return call;
                }
                else
                {
                    var conversion = CanConvert(source.Type, to);
                    if (conversion != ConversionType.Incompatible)
                    {
                        var convert = Convert(source, to, operators, conversion);
                        return convert;
                    }
                    else throw new ArgumentException($"Cannot convert {source.Type} to {to}", nameof(source));
                }
            }
            else throw new ArgumentException("Expected constant type expression", nameof(typeExpression));
        }

        protected MethodCallExpression BindBinaryOperator(string methodName, Expression operators, Expression left, Expression right)
        {
            var methods = OperatorsType
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
                    left = Convert(left, methodParameters[0].ParameterType, operators, leftConversion);
                    right = Convert(right, methodParameters[1].ParameterType, operators, rightConversion);

                    var call = Expression.Call(operators, method, left, right);
                    return call;
                }
            }
            throw new ArgumentException($"No suitable binary method {methodName}({left.Type}, {right.Type}) could be found.", nameof(methodName));
        }
        protected MethodCallExpression BindTernaryOperator(string methodName, Expression operators, Expression first, Expression second, Expression third)
        {
            var methods = OperatorsType
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
                    first = Convert(first, methodParameters[0].ParameterType, operators, firstConversion);
                    second = Convert(second, methodParameters[1].ParameterType, operators, secondConversion);
                    third = Convert(third, methodParameters[2].ParameterType, operators, thirdConversion);
                    var call = Expression.Call(operators, method, first, second, third);
                    return call;
                }
            }

            throw new ArgumentException($"No suitable binary method {methodName}({first.Type}, {second.Type}) could be found.", nameof(methodName));
        }

        protected MethodCallExpression BindBinaryOperatorWithPrecision(string methodName, Expression operators, Expression left, Expression right, Expression precision)
        {
            var methods = OperatorsType
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
                        left = Convert(left, methodParameters[0].ParameterType, operators, leftConversion);
                        right = Convert(right, methodParameters[1].ParameterType, operators, rightConversion);
                        if (methodParameters.Length > 2)
                        {
                            var precisionConversion = CanConvert(precision.Type, methodParameters[2].ParameterType);
                            if (precisionConversion == ConversionType.Incompatible)
                                continue;
                            precision = Convert(precision, methodParameters[2].ParameterType, operators, precisionConversion);
                            return Expression.Call(operators, method, left, right, precision);

                        }
                        else
                            return Expression.Call(operators, method, left, right);
                    }
                }
            }
            throw new ArgumentException($"No suitable binary method {methodName}({left.Type}, {right.Type}) could be found.", nameof(methodName));
        }

        protected MethodCallExpression BindUnaryOperator(string methodName, Expression operators, Expression operand)
        {
            var methods = OperatorsType
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
                        operandParameter = Convert(operandParameter, methodParameters[0].ParameterType, operators, operandConversion);
                    else if (operandConversion == ConversionType.Assignable)
                        operandParameter = Expression.TypeAs(operandParameter, methodParameters[0].ParameterType);
                    var call = Expression.Call(operators, method, operandParameter);
                    return call;
                }
            }
            throw new ArgumentException($"No suitable unary method {methodName}({operand.Type}) could be found.", nameof(methodName));
        }

        protected MethodCallExpression BindUnaryOperatorWithPrecision(string methodName, Expression operators, Expression operand, Expression precision)
        {
            var methods = OperatorsType
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
                        operandParameter = Convert(operandParameter, methodParameters[0].ParameterType, operators, operandConversion);
                    else if (operandConversion == ConversionType.Assignable)
                        operandParameter = Expression.TypeAs(operandParameter, methodParameters[0].ParameterType);
                    var call = Expression.Call(operators, method, operandParameter, precision);
                    return call;
                }
            }
            throw new ArgumentException($"No suitable unary method {methodName}({operand.Type}) could be found.", nameof(methodName));
        }


        /// <summary>
        /// Calls methods with a signature of Method%lt;T&gt;(Argument%lt;T&gt;)
        /// </summary>
        protected MethodCallExpression BindUnaryGenericOperator(string methodName, Expression operators, Expression operand)
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
                var methods = OperatorsType
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
                            operandParameter = Convert(operandParameter, methodParameters[0].ParameterType, operators, operandConversion);

                        var call = Expression.Call(operators, genericMethod, operandParameter);
                        return call;
                    }
                }
                throw new ArgumentException($"No suitable unary method {methodName}({operand.Type}) could be found.", nameof(methodName));
            }
            throw new ArgumentException("Operands to this method must be generic with a single generic type parameter, e.g. IEnumerable<T>", nameof(operand));
        }

        protected MethodCallExpression BindBinaryGenericOperator(string methodName, Expression operators, Expression left, Expression right,
            bool genericArgumentFromRight = false)
        {
            var methods = OperatorsType
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
                    left = Convert(left, methodParameters[0].ParameterType, operators, leftConversion);
                    right = Convert(right, methodParameters[1].ParameterType, operators, rightConversion);
                    var call = Expression.Call(operators, genericMethod, left, right);
                    return call;
                }
            }
            throw new ArgumentException($"No suitable binary method {methodName}({left.Type}, {right.Type}) could be found.", nameof(methodName));
        }

        protected Expression BindBinaryGenericOperatorOrNull(string methodName, Expression operators, Expression left, Expression right,
            bool genericArgumentFromRight = false)
        {
            var methods = OperatorsType
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
                    left = Convert(left, methodParameters[0].ParameterType, operators, leftConversion);
                    right = Convert(right, methodParameters[1].ParameterType, operators, rightConversion);
                    var call = Expression.Call(operators, genericMethod, left, right);
                    return call;
                }
            }
            return Expression.Constant(null, typeof(object));
        }

        protected MethodCallExpression BindTernaryGenericOperator(string methodName, Expression operators,
            Expression left, Expression right, Expression precision, bool genericParameterFromRight = false)
        {
            var methods = OperatorsType
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
                    left = Convert(left, methodParameters[0].ParameterType, operators, leftConversion);
                    right = Convert(right, methodParameters[1].ParameterType, operators, rightConversion);
                    precision = Convert(precision, methodParameters[2].ParameterType, operators, precisionConversion);
                    var call = Expression.Call(operators, genericMethod, left, right, precision);
                    return call;
                }
            }
            throw new ArgumentException($"No suitable binary method {methodName}({left.Type}, {right.Type}) could be found.", nameof(methodName));
        }
        private MethodCallExpression Retrieve(MemberExpression operators,
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

                    return Retrieve(operators, type, valueSetOrCodes, codePropertyExpression);
                }
                else throw new ArgumentException("Second parameter to Retrieve is expected to be a constant PropertyInfo", nameof(codePropertyExpression));
            }
            else throw new ArgumentException("First parameter to Retrieve is expected to be a constant Type", nameof(typeExpression));
        }

        protected MethodCallExpression Retrieve(MemberExpression operators,
            Type resourceType, Expression codes, Expression codeProperty)
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
                    codes = Flatten(operators, codes);
                    var method = typeof(ICqlOperators).GetMethod(nameof(ICqlOperators.RetrieveByCodes))!;
                    forType = method.MakeGenericMethod(resourceType);
                }
                else throw new ArgumentException($"Retrieve statements with an ExpressionRef in the terminology position must be list of {nameof(CqlCode)} or a list of lists of {nameof(CqlCode)}.  Instead, the list's element type is {elementType.Name}.", nameof(codes));
            }
            else
                throw new ArgumentException($"Retrieve statements can only accept terminology expressions whose type is {nameof(CqlValueSet)} or {nameof(IEnumerable<CqlCode>)}.  The expression provided has a type of {codes.Type.FullName}", nameof(codes));

            var call = Expression.Call(operators, forType, codes, codeProperty);
            return call;
        }

        private MethodCallExpression Select(Expression operators,
            Expression source, Expression lambda)
        {
            if (lambda is LambdaExpression lamdaExpr)
            {
                var sourceType = TypeResolver.GetListElementType(source.Type) ?? throw new InvalidOperationException($"{source.Type} was expected to be a list type.");
                var resultType = lamdaExpr.ReturnType;
                var method = OperatorsType.GetMethod(nameof(ICqlOperators.SelectOrNull))!;
                var genericMethod = method.MakeGenericMethod(sourceType, resultType);
                var call = Expression.Call(operators, genericMethod, source, lambda);
                return call;
            }
            else throw new ArgumentException("Source is not generic", nameof(source));
        }
        private MethodCallExpression Where(Expression operators,
            Expression source, Expression lambda)
        {
            if (lambda is LambdaExpression lamdaExpr)
            {
                var sourceType = TypeResolver.GetListElementType(source.Type) ?? throw new InvalidOperationException($"{source.Type} was expected to be a list type.");
                var method = OperatorsType.GetMethod(nameof(ICqlOperators.WhereOrNull))!;
                var genericMethod = method.MakeGenericMethod(sourceType);
                var call = Expression.Call(operators, genericMethod, source, lambda);
                return call;
            }
            else throw new ArgumentException("Source is not generic", nameof(source));
        }

        private MethodCallExpression SelectMany(Expression operators,
            Expression source, Expression collectionSelectorLambda)
        {
            if (collectionSelectorLambda is LambdaExpression collectionSelector)
            {
                var firstGenericArgument = TypeResolver.GetListElementType(source.Type) ?? throw new InvalidOperationException($"{source.Type} was expected to be a list type.");
                if (IsOrImplementsIEnumerableOfT(collectionSelector.ReturnType))
                {
                    var secondGenericArgument = TypeResolver.GetListElementType(collectionSelector.ReturnType) ?? throw new InvalidOperationException($"{collectionSelector.Type} was expected to be a list type.");
                    var method = OperatorsType.GetMethod(nameof(ICqlOperators.SelectManyOrNull))!;
                    var genericMethod = method.MakeGenericMethod(
                        firstGenericArgument,
                        secondGenericArgument);
                    var call = Expression.Call(operators, genericMethod, source, collectionSelector);
                    return call;
                }
                else throw new ArgumentException("Collection selector does not return an IEnumerable", nameof(collectionSelectorLambda));
            }
            else throw new ArgumentException("Source is not generic", nameof(source));
        }

        private MethodCallExpression SelectManyResults(Expression operators,
            Expression source, Expression collectionSelectorLambda, Expression resultSelectorLambda)
        {
            if (collectionSelectorLambda is LambdaExpression collectionSelector)
            {
                var firstGenericArgument = TypeResolver.GetListElementType(source.Type) ?? throw new InvalidOperationException($"{source.Type} was expected to be a list type.");
                if (IsOrImplementsIEnumerableOfT(collectionSelector.ReturnType))
                {
                    var secondGenericArgument = TypeResolver.GetListElementType(collectionSelector.ReturnType) ?? throw new InvalidOperationException($"{collectionSelector.Type} was expected to be a list type.");
                    if (resultSelectorLambda is LambdaExpression resultSelector)
                    {
                        var method = OperatorsType.GetMethod(nameof(ICqlOperators.SelectManyResultsOrNull))!;
                        var genericMethod = method.MakeGenericMethod(
                            firstGenericArgument,
                            secondGenericArgument,
                            resultSelector.ReturnType);
                        var call = Expression.Call(operators, genericMethod, source, collectionSelector, resultSelector);
                        return call;
                    }
                    else throw new ArgumentException("Result expression is not a lambda", nameof(resultSelectorLambda));

                }
                else throw new ArgumentException("Collection lambda does not return an IEnumerable", nameof(collectionSelectorLambda));
            }
            else throw new ArgumentException("Source is not generic", nameof(source));
        }

        private ConversionType CanConvert(Type from, Type to)
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

        private Expression Convert(Expression source, Type destinationType,
            Expression operators, ConversionType conversion)
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
                var call = Expression.Call(operators, method, source);
                return call;
            }
        }

        private MethodCallExpression Aggregate(Expression operators, Expression source,
            Expression lambda, Expression seed)
        {
            var sourceType = TypeResolver.GetListElementType(source.Type, false) ??
                throw new ArgumentException($"Cannot resolve element type for {source.Type.Name}", nameof(source));
            var accumulateType = seed.Type;
            var method = OperatorsType.GetMethod(nameof(ICqlOperators.AggregateOrNull))!;
            var genericMethod = method.MakeGenericMethod(sourceType, accumulateType);
            var call = Expression.Call(operators, genericMethod, source, seed, lambda);
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