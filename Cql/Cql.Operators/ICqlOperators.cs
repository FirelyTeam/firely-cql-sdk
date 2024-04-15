﻿#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
using Hl7.Cql.Abstractions;
using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSets;
using System;
using System.Collections.Generic;
using System.Reflection;
using ListSortDirection = System.ComponentModel.ListSortDirection;

namespace Hl7.Cql.Operators
{
    /// <summary>
    /// Defines the operators in the CQL specification.
    /// </summary>
    /// <seealso gref="https://cql.hl7.org/09-b-cqlreference.html"/>
    public interface ICqlOperators
    {
        ICqlComparer Comparer { get; }

        IValueSetFacade CreateValueSetFacade(CqlValueSet valueSet);

        T? Convert<T>(object? from);

        IEnumerable<T> RetrieveByValueSet<T>(CqlValueSet? valueSet = null, PropertyInfo? codeProperty = null) where T : class;
        IEnumerable<T> RetrieveByCodes<T>(IEnumerable<CqlCode?>? codes = null, PropertyInfo? codeProperty = null) where T : class;

        #region Operators

        CqlQuantity? Abs(CqlQuantity? argument);
        decimal? Abs(decimal? argument);
        int? Abs(int? argument);
        long? Abs(long? argument);
        CqlDate? Add(CqlDate? left, CqlQuantity? right);
        CqlDateTime? Add(CqlDateTime? left, CqlQuantity? right);
        CqlQuantity? Add(CqlQuantity? left, CqlQuantity? right);
        CqlTime? Add(CqlTime? left, CqlQuantity? right);
        decimal? Add(decimal? left, decimal? right);
        int? Add(int? left, int? right);
        long? Add(long? left, long? right);
        bool? After(object? left, object? right, string? precision);
        int? Age(string precision);
        int? AgeAt(CqlDate? asOf, string precision);
        TAccumulate? AggregateOrNull<TSource, TAccumulate>(IEnumerable<TSource?>? source, TAccumulate? seed, Func<TAccumulate?, TSource?, TAccumulate?> lambda);
        bool? AllTrue(IEnumerable<bool?> argument);
        bool? AllTrue(IEnumerable<Lazy<bool?>> argument);
        bool? And(bool? left, bool? right);
        bool? And(Lazy<bool?> left, Lazy<bool?> right);
        bool? And(bool? left, Lazy<bool?> right);
        bool? And(Lazy<bool?> left, bool? right);
        bool? AnyTrue(IEnumerable<bool?> argument);
        bool? AnyTrue(IEnumerable<Lazy<bool?>> argument);
        decimal? Avg(IEnumerable<decimal?>? argument);
        bool? Before(object? left, object? right, string? precision);
        bool? Between(CqlDate? argument, CqlDate? low, CqlDate? high);
        bool? Between(CqlDateTime? argument, CqlDateTime? low, CqlDateTime? high);
        bool? Between(CqlQuantity? argument, CqlQuantity? low, CqlQuantity? high);
        bool? Between(CqlTime? argument, CqlTime? low, CqlTime? high);
        bool? Between(decimal? argument, decimal? low, decimal? high);
        bool? Between(int? argument, int? low, int? high);
        bool? Between(long? argument, long? low, long? high);
        bool? Between(string? argument, string? low, string? high);
        int? CalculateAge(CqlDate? birthDate, string precision);
        int? CalculateAge(CqlDateTime? birthDate, string precision);
        int? CalculateAgeAt(CqlDate? birthDate, CqlDate? asOf, string precision);
        int? CalculateAgeAt(CqlDateTime? birthDate, CqlDateTime? asOf, string precision);
        bool? CanConvertQuantity(CqlQuantity? argument, string? unit);
        int? Ceiling(decimal? argument);
        int? Ceiling(int? argument);
        long? Ceiling(long? argument);
        IEnumerable<object> Children(object o);
        T? Coalesce<T>(IEnumerable<T>? source) where T : class;
        T? CoalesceValueTypes<T>(IEnumerable<T?>? source) where T : struct;
        bool? CodeInCodeSystem(CqlCode? code, CqlCodeSystem? codesystem);
        bool? CodeInCodeSystem(CqlConcept? code, CqlCodeSystem? codesystem);
        bool? CodeInCodeSystem(IEnumerable<CqlCode?>? code, CqlCodeSystem? codesystem);
        bool? CodeInCodeSystem(IEnumerable<CqlConcept?>? code, CqlCodeSystem? codesystem);
        bool? CodeInCodeSystem(IEnumerable<string?>? code, CqlCodeSystem? codesystem);
        bool? CodeInCodeSystem(string? code, CqlCodeSystem? codesystem);
        bool? CodeInList(CqlCode? element, IEnumerable<CqlCode>? argument);
        bool? CodeInValueSet(CqlCode? code, CqlValueSet? valueSet);
        bool? CodesInValueSet(IEnumerable<CqlCode?>? codes, CqlValueSet? valueSet);
        IEnumerable<CqlInterval<CqlDate?>?>? Collapse(IEnumerable<CqlInterval<CqlDate?>?>? intervals, string? precision);
        IEnumerable<CqlInterval<CqlDateTime?>?>? Collapse(IEnumerable<CqlInterval<CqlDateTime?>?>? intervals, string? precision);
        IEnumerable<CqlInterval<CqlQuantity?>?>? Collapse(IEnumerable<CqlInterval<CqlQuantity?>?>? intervals, string? precision);
        IEnumerable<CqlInterval<CqlTime?>?>? Collapse(IEnumerable<CqlInterval<CqlTime?>?>? intervals, string? precision);
        IEnumerable<CqlInterval<decimal?>?>? Collapse(IEnumerable<CqlInterval<decimal?>?>? intervals, string? precision);
        IEnumerable<CqlInterval<int?>?>? Collapse(IEnumerable<CqlInterval<int?>?>? intervals, string? precision);
        IEnumerable<CqlInterval<long?>?>? Collapse(IEnumerable<CqlInterval<long?>?>? intervals, string? precision);
        string? Combine(IEnumerable<string> source, string? separator);
        int? ComponentFrom(CqlDate? argument, string? precision);
        int? ComponentFrom(CqlDateTime? argument, string? precision);
        int? ComponentFrom(CqlTime? argument, string? precision);
        string? Concatenate(string? left, string? right);
        bool? ConceptInValueSet(CqlConcept? concept, CqlValueSet? valueSet);
        bool? ConceptsInValueSet(IEnumerable<CqlConcept?>? concept, CqlValueSet? valueSet);
        decimal? ConvertBooleanToDecimal(bool? b);
        int? ConvertBooleanToInteger(bool? b);
        long? ConvertBooleanToLong(bool? b);
        string? ConvertBooleanToString(bool? b);
        CqlConcept? ConvertCodeToConcept(CqlCode? c);
        IEnumerable<CqlCode>? ConvertConceptToListOfCodes(CqlConcept? c);
        CqlConcept? ConvertConceptToListOfCodes(IEnumerable<CqlCode>? c);
        CqlDate? ConvertDateTimeToDate(CqlDateTime? d);
        string? ConvertDateTimeToString(CqlDateTime? d);
        CqlDateTime? ConvertDateToDateTime(CqlDate? d);
        string? ConvertDateToString(CqlDate? d);
        bool? ConvertDecimalToBoolean(decimal? d);
        CqlQuantity? ConvertDecimalToQuantity(decimal? d);
        string? ConvertDecimalToString(decimal? d);
        bool? ConvertIntegerToBoolean(int? i);
        decimal? ConvertIntegerToDecimal(int? i);
        long? ConvertIntegerToLong(int? i);
        CqlQuantity? ConvertIntegerToQuantity(int? i);
        string? ConvertIntegerToString(int? i);
        bool? ConvertLongToBoolean(long? i);
        decimal? ConvertLongToDecimal(long? i);
        int? ConvertLongToInteger(long? i);
        CqlQuantity? ConvertLongToQuantity(long? i);
        string? ConvertLongToString(long? i);
        CqlQuantity? ConvertQuantity(CqlQuantity? argument, string? unit);
        string? ConvertQuantityToString(CqlQuantity? q);
        string? ConvertRatioToString(CqlRatio? r);
        bool? ConvertsToBoolean(object? o);
        bool? ConvertsToDate(object? o);
        bool? ConvertsToDateTime(object? o);
        bool? ConvertsToDecimal(object? o);
        bool? ConvertsToInteger(object? o);
        bool? ConvertsToLong(object? o);
        bool? ConvertsToQuantity(object? o);
        bool? ConvertsToString(object? o);
        bool? ConvertsToTime(object? o);
        bool? ConvertStringToBoolean(string? s);
        CqlDate? ConvertStringToDate(string? s);
        CqlDateTime? ConvertStringToDateTime(string? s);
        decimal? ConvertStringToDecimal(string? s);
        int? ConvertStringToInteger(string? s);
        long? ConvertStringToLong(string? s);
        CqlQuantity? ConvertStringToQuantity(string? s);
        CqlTime? ConvertStringToTime(string? s);
        string? ConvertTimeToString(CqlTime? t);
        int? CountOrNull<T>(IEnumerable<T>? source);
        CqlDate? Date(int? year, int? month, int? day);
        CqlDate? DateFrom(CqlDateTime? argument);
        CqlDateTime? DateTime(int? year, int? month, int? day, int? hour, int? minute, int? second, int? millisecond, decimal? offset);
        IEnumerable<object?>? Descendents(object? argument);
        int? DifferenceBetween(CqlDate? low, CqlDate? high, string? precision);
        int? DifferenceBetween(CqlDateTime? low, CqlDateTime? high, string? precision);
        int? DifferenceBetween(CqlTime? low, CqlTime? high, string? precision);
        CqlQuantity? Divide(CqlQuantity? left, CqlQuantity? right);
        decimal? Divide(decimal? left, decimal? right);
        int? DurationBetween(CqlDate? low, CqlDate? high, string? precision);
        int? DurationBetween(CqlDateTime? low, CqlDateTime? high, string? precision);
        int? DurationBetween(CqlTime? low, CqlTime? high, string? precision);
        bool? ElementIncludedInList<T>(T left, IEnumerable<T> right);
        bool? ElementInInterval<T>(T t, CqlInterval<T>? interval, string? precision);
        bool? ElementProperlyIncludedInInterval(CqlDate left, CqlInterval<CqlDate>? right, string precision);
        bool? ElementProperlyIncludedInInterval(CqlDateTime left, CqlInterval<CqlDateTime>? right, string precision);
        bool? ElementProperlyIncludedInInterval(CqlTime left, CqlInterval<CqlTime>? right, string precision);
        bool? ElementProperlyIncludedInInterval<T>(T left, CqlInterval<T>? right);
        bool? ElementProperlyIncludedInList<T>(T left, IEnumerable<T> right);
        CqlDate? End(CqlInterval<CqlDate?>? argument);
        CqlDateTime? End(CqlInterval<CqlDateTime?>? argument);
        CqlQuantity? End(CqlInterval<CqlQuantity?>? argument);
        CqlTime? End(CqlInterval<CqlTime?>? argument);
        decimal? End(CqlInterval<decimal?>? argument);
        int? End(CqlInterval<int?>? argument);
        long? End(CqlInterval<long?>? argument);
        bool? Ends<T>(CqlInterval<T> left, CqlInterval<T> right, string? precision);
        bool? EndsWith(string argument, string suffix);
        bool? EnumEqualsString(object? @enum, string? value);
        bool? Equal(object? x, object? y);
        bool? Equivalent(object? x, object? y);
        bool? ExistsInList<T>(IEnumerable<T> list);
        decimal? Exp(decimal? argument);
        IEnumerable<CqlInterval<CqlDate?>>? ExpandList(IEnumerable<CqlInterval<CqlDate?>?>? argument, CqlQuantity? per);
        IEnumerable<CqlInterval<CqlDateTime?>>? ExpandList(IEnumerable<CqlInterval<CqlDateTime?>?>? argument, CqlQuantity? per);
        IEnumerable<CqlInterval<CqlTime?>>? ExpandList(IEnumerable<CqlInterval<CqlTime?>?>? argument, CqlQuantity? per);
        IEnumerable<CqlInterval<decimal?>>? ExpandList(IEnumerable<CqlInterval<decimal?>?>? argument, CqlQuantity? per);
        IEnumerable<CqlInterval<int?>>? ExpandList(IEnumerable<CqlInterval<int?>?>? argument, CqlQuantity? per);
        IEnumerable<CqlInterval<long?>>? ExpandList(IEnumerable<CqlInterval<long?>?>? argument, CqlQuantity? per);
        IEnumerable<CqlDate>? ExpandInterval(CqlInterval<CqlDate>? argument, CqlQuantity? per);
        IEnumerable<CqlDateTime>? ExpandInterval(CqlInterval<CqlDateTime>? argument, CqlQuantity? per);
        IEnumerable<CqlTime>? ExpandInterval(CqlInterval<CqlTime>? argument, CqlQuantity? per);
        IEnumerable<decimal?>? ExpandInterval(CqlInterval<decimal?>? argument, CqlQuantity? per);
        IEnumerable<int?>? ExpandInterval(CqlInterval<int?>? argument, CqlQuantity? per);
        IEnumerable<long?>? ExpandInterval(CqlInterval<long?>? argument, CqlQuantity? per);
        T? FirstOfList<T>(IEnumerable<T> enumerable);
        IEnumerable<object>? FlattenLateBoundList(IEnumerable<object> argument);
        IEnumerable<T>? FlattenList<T>(IEnumerable<IEnumerable<T>> argument);
        int? Floor(decimal? argument);
        int? Floor(int? argument);
        long? Floor(long? argument);
        decimal? GeometricMean(IEnumerable<decimal?> argument);
        bool? Greater(object? left, object? right);
        bool? GreaterOrEqual(object? left, object? right);
        bool? GreaterOrSamePrecision(CqlDate? left, string? precision);
        bool? GreaterOrSamePrecision(CqlDateTime? left, string? precision);
        bool? GreaterOrSamePrecision(CqlTime? left, string? precision);
        CqlDate? HighBoundary(CqlDate? input, int? precision);
        CqlDateTime? HighBoundary(CqlDateTime? input, int? precision);
        CqlTime? HighBoundary(CqlTime? input, int? precision);
        decimal? HighBoundary(decimal? input, int? precision);
        bool? Implies(bool? left, bool? right);
        bool? Implies(Lazy<bool?> left, Lazy<bool?> right);
        bool? InList<T>(T element, IEnumerable<T> argument);
        CqlInterval<CqlDate?>? Interval(CqlDate? low, CqlDate? high, bool? lowClosed, bool? highClosed);
        CqlInterval<CqlDateTime?>? Interval(CqlDateTime? low, CqlDateTime? high, bool? lowClosed, bool? highClosed);
        CqlInterval<CqlQuantity?>? Interval(CqlQuantity? low, CqlQuantity? high, bool? lowClosed, bool? highClosed);
        CqlInterval<CqlTime?>? Interval(CqlTime? low, CqlTime? high, bool? lowClosed, bool? highClosed);
        CqlInterval<decimal?>? Interval(decimal? low, decimal? high, bool? lowClosed, bool? highClosed);
        CqlInterval<int?>? Interval(int? low, int? high, bool? lowClosed, bool? highClosed);
        CqlInterval<long?>? Interval(long? low, long? high, bool? lowClosed, bool? highClosed);
        bool? ElementAfterInterval(CqlDate? right, CqlInterval<CqlDate?>? left, string? precision);
        bool? ElementAfterInterval(CqlDateTime? right, CqlInterval<CqlDateTime?>? left, string? precision);
        bool? ElementAfterInterval(CqlQuantity? right, CqlInterval<CqlQuantity?>? left, string? precision);
        bool? ElementAfterInterval(CqlTime? right, CqlInterval<CqlTime?>? left, string? precision);
        bool? ElementAfterInterval(int? right, CqlInterval<int?>? left, string? precision);
        bool? ElementAfterInterval(decimal? right, CqlInterval<decimal?>? left, string? precision);
        bool? ElementAfterInterval(long? right, CqlInterval<long?>? left, string? precision);
        bool? IntervalAfterElement(CqlInterval<CqlDate?>? left, CqlDate? right, string? precision);
        bool? IntervalAfterElement(CqlInterval<CqlDateTime?>? left, CqlDateTime? right, string? precision);
        bool? IntervalAfterElement(CqlInterval<CqlQuantity?>? left, CqlQuantity? right, string? precision);
        bool? IntervalAfterElement(CqlInterval<CqlTime?>? left, CqlTime? right, string? precision);
        bool? IntervalAfterElement(CqlInterval<decimal?>? left, decimal? right, string? precision);
        bool? IntervalAfterElement(CqlInterval<int?>? left, int? right, string? precision);
        bool? IntervalAfterElement(CqlInterval<long?>? left, long? right, string? precision);
        bool? IntervalAfterInterval(CqlInterval<CqlDate?>? left, CqlInterval<CqlDate?>? right, string? precision);
        bool? IntervalAfterInterval(CqlInterval<CqlDateTime?>? left, CqlInterval<CqlDateTime?>? right, string? precision);
        bool? IntervalAfterInterval(CqlInterval<CqlQuantity?>? left, CqlInterval<CqlQuantity?>? right, string? precision);
        bool? IntervalAfterInterval(CqlInterval<CqlTime?>? left, CqlInterval<CqlTime?>? right, string? precision);
        bool? IntervalAfterInterval(CqlInterval<decimal?>? left, CqlInterval<decimal?>? right, string? precision);
        bool? IntervalAfterInterval(CqlInterval<int?>? left, CqlInterval<int?>? right, string? precision);
        bool? IntervalAfterInterval(CqlInterval<long?>? left, CqlInterval<long?>? right, string? precision);
        bool? ElementBeforeInterval(CqlDate? right, CqlInterval<CqlDate?>? left, string? precision);
        bool? ElementBeforeInterval(CqlDateTime? right, CqlInterval<CqlDateTime?>? left, string? precision);
        bool? ElementBeforeInterval(CqlQuantity? right, CqlInterval<CqlQuantity?>? left, string? precision);
        bool? ElementBeforeInterval(CqlTime? right, CqlInterval<CqlTime?>? left, string? precision);
        bool? ElementBeforeInterval(int? right, CqlInterval<int?>? left, string? precision);
        bool? ElementBeforeInterval(decimal? right, CqlInterval<decimal?>? left, string? precision);
        bool? ElementBeforeInterval(long? right, CqlInterval<long?>? left, string? precision);
        bool? IntervalBeforeElement(CqlInterval<CqlDate?>? left, CqlDate? right, string? precision);
        bool? IntervalBeforeElement(CqlInterval<CqlDateTime?>? left, CqlDateTime? right, string? precision);
        bool? IntervalBeforeElement(CqlInterval<CqlQuantity?>? left, CqlQuantity? right, string? precision);
        bool? IntervalBeforeElement(CqlInterval<CqlTime?>? left, CqlTime? right, string? precision);
        bool? IntervalBeforeElement(CqlInterval<decimal?>? left, decimal? right, string? precision);
        bool? IntervalBeforeElement(CqlInterval<int?>? left, int? right, string? precision);
        bool? IntervalBeforeElement(CqlInterval<long?>? left, long? right, string? precision);
        bool? IntervalBeforeInterval(CqlInterval<CqlDate?>? left, CqlInterval<CqlDate?>? right, string? precision);
        bool? IntervalBeforeInterval(CqlInterval<CqlDateTime?>? left, CqlInterval<CqlDateTime?>? right, string? precision);
        bool? IntervalBeforeInterval(CqlInterval<CqlQuantity?>? left, CqlInterval<CqlQuantity?>? right, string? precision);
        bool? IntervalBeforeInterval(CqlInterval<CqlTime?>? left, CqlInterval<CqlTime?>? right, string? precision);
        bool? IntervalBeforeInterval(CqlInterval<decimal?>? left, CqlInterval<decimal?>? right, string? precision);
        bool? IntervalBeforeInterval(CqlInterval<int?>? left, CqlInterval<int?>? right, string? precision);
        bool? IntervalBeforeInterval(CqlInterval<long?>? left, CqlInterval<long?>? right, string? precision);
        bool? IntervalContains(CqlInterval<CqlDate?>? left, CqlDate? right, string? precision);
        bool? IntervalContains(CqlInterval<CqlDateTime?>? left, CqlDateTime? right, string? precision);
        bool? IntervalContains(CqlInterval<CqlQuantity?>? left, CqlQuantity? right, string? precision);
        bool? IntervalContains(CqlInterval<CqlTime?>? left, CqlTime? right, string? precision);
        bool? IntervalContains(CqlInterval<decimal?>? left, decimal? right, string? precision);
        bool? IntervalContains(CqlInterval<int?>? left, int? right, string? precision);
        bool? IntervalContains(CqlInterval<long?>? left, long? right, string? precision);
        CqlInterval<CqlDate?>? IntervalExcept(CqlInterval<CqlDate?>? left, CqlInterval<CqlDate?>? right);
        CqlInterval<CqlDateTime?>? IntervalExcept(CqlInterval<CqlDateTime?>? left, CqlInterval<CqlDateTime?>? right);
        CqlInterval<CqlQuantity?>? IntervalExcept(CqlInterval<CqlQuantity?>? left, CqlInterval<CqlQuantity?>? right);
        CqlInterval<CqlTime?>? IntervalExcept(CqlInterval<CqlTime?>? left, CqlInterval<CqlTime?>? right);
        CqlInterval<decimal?>? IntervalExcept(CqlInterval<decimal?>? left, CqlInterval<decimal?>? right);
        CqlInterval<int?>? IntervalExcept(CqlInterval<int?>? left, CqlInterval<int?>? right);
        CqlInterval<long?>? IntervalExcept(CqlInterval<long?>? left, CqlInterval<long?>? right);
        bool? IntervalIncludedIn<T>(CqlInterval<T>? smaller, CqlInterval<T>? larger, string precision);
        bool? IntervalIncludesElement<T>(CqlInterval<T>? interval, T t, string? precision);
        bool? IntervalIncludesInterval<T>(CqlInterval<T>? larger, CqlInterval<T>? smaller, string precision);
        CqlInterval<T>? IntervalIntersect<T>(CqlInterval<T>? left, CqlInterval<T>? right);
        bool? IntervalProperlyIncludedInInterval<T>(CqlInterval<T>? left, CqlInterval<T>? right, string precision);
        bool? IntervalProperlyIncludesElement(CqlInterval<CqlDate>? left, CqlDate right, string precision);
        bool? IntervalProperlyIncludesElement(CqlInterval<CqlDateTime>? left, CqlDateTime right, string precision);
        bool? IntervalProperlyIncludesElement(CqlInterval<CqlTime>? left, CqlTime right, string precision);
        bool? IntervalProperlyIncludesElement<T>(CqlInterval<T>? left, T right);
        bool? IntervalProperlyIncludesInterval<T>(CqlInterval<T>? left, CqlInterval<T>? right, string precision);
        bool? IntervalSameAs<T>(CqlInterval<T> @this, CqlInterval<T> other, string? precision);
        bool? IntervalSameOrAfter(CqlInterval<CqlDate?>? @this, CqlInterval<CqlDate?>? other, string? precision);
        bool? IntervalSameOrAfter(CqlInterval<CqlDateTime?>? @this, CqlInterval<CqlDateTime?>? other, string? precision);
        bool? IntervalSameOrAfter(CqlInterval<CqlQuantity?> @this, CqlInterval<CqlQuantity?> other);
        bool? IntervalSameOrAfter(CqlInterval<CqlTime?>? @this, CqlInterval<CqlTime?>? other, string? precision);
        bool? IntervalSameOrAfter(CqlInterval<decimal?> @this, CqlInterval<decimal?> other);
        bool? IntervalSameOrAfter(CqlInterval<int?> @this, CqlInterval<int?> other);
        bool? IntervalSameOrAfter(CqlInterval<long?> @this, CqlInterval<long?> other);
        bool? IntervalSameOrBefore(CqlInterval<CqlDate?>? @this, CqlInterval<CqlDate?>? other, string? precision);
        bool? IntervalSameOrBefore(CqlInterval<CqlDateTime?>? @this, CqlInterval<CqlDateTime?>? other, string? precision);
        bool? IntervalSameOrBefore(CqlInterval<CqlQuantity?> @this, CqlInterval<CqlQuantity?> other);
        bool? IntervalSameOrBefore(CqlInterval<CqlTime?>? @this, CqlInterval<CqlTime?>? other, string? precision);
        bool? IntervalSameOrBefore(CqlInterval<decimal?> @this, CqlInterval<decimal?> other);
        bool? IntervalSameOrBefore(CqlInterval<int?> @this, CqlInterval<int?> other);
        bool? IntervalSameOrBefore(CqlInterval<long?> @this, CqlInterval<long?> other);
        decimal? IntervalSize(CqlInterval<decimal?>? argument);
        int? IntervalSize(CqlInterval<int?>? argument);
        long? IntervalSize(CqlInterval<long?>? argument);
        CqlInterval<T>? IntervalUnion<T>(CqlInterval<T>? left, CqlInterval<T>? right);
        bool? IsFalse(bool? b);
        bool? IsNull<T>(T value) where T : class;
        bool? IsNullValue<T>(T? value) where T : struct;
        bool? IsTrue(bool? b);
        T? LastOfList<T>(IEnumerable<T> enumerable);
        int? LastPositionOf(string? argument, string? pattern);
        T LateBoundProperty<T>(object? source, string propertyName);
        bool? Less(object? left, object? right);
        bool? LessOrEqual(object? left, object? right);
        bool? ListContains<T>(IEnumerable<T> list, T item);
        IEnumerable<T>? ListDistinct<T>(IEnumerable<T> source);
        T ListElementAt<T>(IEnumerable<T>? source, int? index);
        bool? ListEqual<T>(IEnumerable<T>? left, IEnumerable<T>? right);
        bool? ListEquivalent<T>(IEnumerable<T>? left, IEnumerable<T>? right);
        IEnumerable<T>? ListExcept<T>(IEnumerable<T>? left, IEnumerable<T>? right);
        bool? ListIncludedInList<T>(IEnumerable<T>? left, IEnumerable<T> right);
        bool? ListIncludesElement<T>(IEnumerable<T>? left, T right);
        bool? ListIncludesList<T>(IEnumerable<T>? left, IEnumerable<T> right);
        int? ListIndexOf<T>(IEnumerable<T>? list, T element);
        IEnumerable<T>? ListIntersect<T>(IEnumerable<T>? left, IEnumerable<T>? right);
        int? ListLength<T>(IEnumerable<T> list);
        bool? ListNotEqual<T>(IEnumerable<T>? left, IEnumerable<T>? right);
        bool? ListNotEquivalent<T>(IEnumerable<T>? left, IEnumerable<T>? right);
        bool? ListProperlyIncludedInList<T>(IEnumerable<T>? left, IEnumerable<T> right);
        bool? ListProperlyIncludesElement<T>(IEnumerable<T>? left, T right);
        bool? ListProperlyIncludesList<T>(IEnumerable<T>? left, IEnumerable<T> right);
        IEnumerable<T>? ListSkip<T>(IEnumerable<T> argument, int? number);
        IEnumerable<T>? ListSort<T>(IEnumerable<T>? source, ListSortDirection order);
        IEnumerable<T>? ListSortBy<T>(IEnumerable<T>? source, Func<T, object> sortByExpr, ListSortDirection order);
        IEnumerable<T>? ListTail<T>(IEnumerable<T> argument);
        IEnumerable<T>? ListTake<T>(IEnumerable<T> argument, int? number);
        IEnumerable<T>? ListUnion<T>(IEnumerable<T>? left, IEnumerable<T>? right);
        decimal? Ln(decimal? argument);
        decimal? Log(decimal? argument, decimal? @base);
        CqlDate? LowBoundary(CqlDate? input, int? precision);
        CqlDateTime? LowBoundary(CqlDateTime? input, int? precision);
        CqlTime? LowBoundary(CqlTime? input, int? precision);
        decimal? LowBoundary(decimal? input, int? precision);
        string? Lower(string argument);
        bool? Matches(string source, string pattern);
        T Maximum<T>();
        T MaxOrNull<T>(IEnumerable<T>? items);
        decimal? Median(IEnumerable<decimal?> source);
        int? Median(IEnumerable<int?> source);
        long? Median(IEnumerable<long?> source);
        bool? Meets(CqlInterval<CqlDate?>? left, CqlInterval<CqlDate?>? right, string? precision);
        bool? Meets(CqlInterval<CqlDateTime?>? left, CqlInterval<CqlDateTime?>? right, string? precision);
        bool? Meets(CqlInterval<CqlQuantity?>? left, CqlInterval<CqlQuantity?>? right, string? precision);
        bool? Meets(CqlInterval<CqlTime?>? left, CqlInterval<CqlTime?>? right, string? precision);
        bool? Meets(CqlInterval<decimal?>? left, CqlInterval<decimal?>? right, string? precision);
        bool? Meets(CqlInterval<int?>? left, CqlInterval<int?>? right, string? precision);
        bool? Meets(CqlInterval<long?>? left, CqlInterval<long?>? right, string? precision);
        bool? MeetsAfter(CqlInterval<CqlDate?>? left, CqlInterval<CqlDate?> right, string? precision);
        bool? MeetsAfter(CqlInterval<CqlDateTime?>? left, CqlInterval<CqlDateTime?> right, string? precision);
        bool? MeetsAfter(CqlInterval<CqlQuantity?>? left, CqlInterval<CqlQuantity?> right, string? precision);
        bool? MeetsAfter(CqlInterval<CqlTime?>? left, CqlInterval<CqlTime?> right, string? precision);
        bool? MeetsAfter(CqlInterval<decimal?>? left, CqlInterval<decimal?> right, string? precision);
        bool? MeetsAfter(CqlInterval<int?>? left, CqlInterval<int?> right, string? precision);
        bool? MeetsAfter(CqlInterval<long?>? left, CqlInterval<long?> right, string? precision);
        bool? MeetsBefore(CqlInterval<CqlDate?> left, CqlInterval<CqlDate?> right, string? precision);
        bool? MeetsBefore(CqlInterval<CqlDateTime?> left, CqlInterval<CqlDateTime?> right, string? precision);
        bool? MeetsBefore(CqlInterval<CqlQuantity?> left, CqlInterval<CqlQuantity?> right, string? precision);
        bool? MeetsBefore(CqlInterval<CqlTime?> left, CqlInterval<CqlTime?> right, string? precision);
        bool? MeetsBefore(CqlInterval<decimal?> left, CqlInterval<decimal?> right, string? precision);
        bool? MeetsBefore(CqlInterval<int?> left, CqlInterval<int?> right, string? precision);
        bool? MeetsBefore(CqlInterval<long?> left, CqlInterval<long?> right, string? precision);
        T Message<T>(T source, string code, string severity, string message);

        event EventHandler<MessageEventArgs>? MessageReceived;

        T Minimum<T>();
        T MinOrNull<T>(IEnumerable<T>? items);
        T Mode<T>(IEnumerable<T>? typedSource);
        CqlQuantity? Modulo(CqlQuantity left, CqlQuantity right);
        decimal? Modulo(decimal? left, decimal? right);
        int? Modulo(int? left, int? right);
        long? Modulo(long? left, long? right);
        CqlQuantity? Multiply(CqlQuantity? left, CqlQuantity? right);
        decimal? Multiply(decimal? left, decimal? right);
        int? Multiply(int? left, int? right);
        long? Multiply(long? left, long? right);
        CqlQuantity? Negate(CqlQuantity? argument);
        decimal? Negate(decimal? argument);
        int? Negate(int? argument);
        long? Negate(long? argument);
        bool? Not(bool? @this);
        bool? NotEqual(object? left, object? right);
        bool? NotEquivalent(object? left, object? right);
        object NotSupported();
        CqlDateTime Now();
        bool? Or(bool? left, bool? right);
        bool? Or(Lazy<bool?> left, Lazy<bool?> right);

        bool? Overlaps(CqlInterval<CqlDate?> left, CqlInterval<CqlDate?> right, string? precision);
        bool? Overlaps(CqlInterval<CqlDateTime?> left, CqlInterval<CqlDateTime?> right, string? precision);
        bool? Overlaps(CqlInterval<CqlQuantity?> left, CqlInterval<CqlQuantity?> right);
        bool? Overlaps(CqlInterval<CqlTime?> left, CqlInterval<CqlTime?> right, string? precision);
        bool? Overlaps(CqlInterval<decimal?> left, CqlInterval<decimal?> right);
        bool? Overlaps(CqlInterval<int?> left, CqlInterval<int?> right);
        bool? Overlaps(CqlInterval<long?> left, CqlInterval<long?> right);
        bool? OverlapsAfter(CqlInterval<CqlDate?>? left, CqlInterval<CqlDate?>? right, string? precision);
        bool? OverlapsAfter(CqlInterval<CqlDateTime?>? left, CqlInterval<CqlDateTime?>? right, string? precision);
        bool? OverlapsAfter(CqlInterval<CqlQuantity?> left, CqlInterval<CqlQuantity?> right);
        bool? OverlapsAfter(CqlInterval<CqlTime?>? left, CqlInterval<CqlTime?>? right, string? precision);
        bool? OverlapsAfter(CqlInterval<decimal?>? left, CqlInterval<decimal?>? right);
        bool? OverlapsAfter(CqlInterval<int?>? left, CqlInterval<int?>? right);
        bool? OverlapsAfter(CqlInterval<long?>? left, CqlInterval<long?>? right);
        bool? OverlapsBefore(CqlInterval<CqlDate?>? left, CqlInterval<CqlDate?>? right, string? precision);
        bool? OverlapsBefore(CqlInterval<CqlDateTime?>? left, CqlInterval<CqlDateTime?>? right, string? precision);
        bool? OverlapsBefore(CqlInterval<CqlQuantity?>? left, CqlInterval<CqlQuantity?>? right);
        bool? OverlapsBefore(CqlInterval<CqlTime?>? left, CqlInterval<CqlTime?>? right, string? precision);
        bool? OverlapsBefore(CqlInterval<decimal?>? left, CqlInterval<decimal?>? right);
        bool? OverlapsBefore(CqlInterval<int?>? left, CqlInterval<int?>? right);
        bool? OverlapsBefore(CqlInterval<long?>? left, CqlInterval<long?>? right);
        T? PointFrom<T>(CqlInterval<T?>? argument);
        CqlQuantity? PopulationStdDev(IEnumerable<CqlQuantity?>? source);
        decimal? PopulationStdDev(IEnumerable<decimal?>? source);
        CqlQuantity? PopulationVariance(IEnumerable<CqlQuantity?>? source);
        decimal? PopulationVariance(IEnumerable<decimal?>? source);
        int? PositionOf(string pattern, string argument);
        decimal? Power(decimal? argument, decimal? exponent);
        int? Power(int? argument, int? exponent);
        long? Power(long? argument, long? exponent);
        int? Precision(CqlDate? argument);
        int? Precision(CqlDateTime? argument);
        int? Precision(CqlTime? argument);
        int? Precision(decimal? argument);
        CqlDate? Predecessor(CqlDate? argument);
        CqlDateTime? Predecessor(CqlDateTime? argument);
        CqlQuantity? Predecessor(CqlQuantity? argument);
        CqlTime? Predecessor(CqlTime? argument);
        decimal? Predecessor(decimal? argument);
        int? Predecessor(int? argument);
        long? Predecessor(long? argument);
        CqlQuantity? Product(IEnumerable<CqlQuantity?>? argument);
        decimal? Product(IEnumerable<decimal?>? argument);
        int? Product(IEnumerable<int?>? argument);
        long? Product(IEnumerable<long?>? argument);
        CqlQuantity? Quantity(decimal? value, string? unit);
        string? ReplaceMatches(string source, string pattern, string substitution);
        IEnumerable<CqlCode> ResolveValueSet(CqlValueSet valueSet);
        decimal? Round(decimal? argument, int? precision);
        bool? SameAs(CqlDate? left, CqlDate? right, string? precision);
        bool? SameAs(CqlDateTime? left, CqlDateTime? right, string? precision);
        bool? SameAs(CqlTime? left, CqlTime? right, string? precision);
        bool? SameOrAfter(CqlDate? left, CqlDate? right, string? precision);
        bool? SameOrAfter(CqlDateTime? left, CqlDateTime? right, string? precision);
        bool? SameOrAfter(CqlTime? left, CqlTime? right, string? precision);
        bool? SameOrBefore(CqlDate? left, CqlDate? right, string? precision);
        bool? SameOrBefore(CqlDateTime? left, CqlDateTime? right, string? precision);
        bool? SameOrBefore(CqlTime? left, CqlTime? right, string? precision);
        bool? SamePrecision(CqlDate? left, CqlDate? right);
        bool? SamePrecision(CqlDateTime? left, CqlDateTime? right);
        bool? SamePrecision(CqlTime? left, CqlTime? right);
        IEnumerable<TResult>? SelectManyOrNull<TSource, TResult>(IEnumerable<TSource>? source, Func<TSource, IEnumerable<TResult>> collectionSelector);
        IEnumerable<TResult>? SelectManyResultsOrNull<TSource, TCollection, TResult>(IEnumerable<TSource>? source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector);

        IEnumerable<(T1, T2)> CrossJoin<T1, T2>(
            IEnumerable<T1>? source1,
            IEnumerable<T2>? source2);

        IEnumerable<(T1, T2, T3)> CrossJoin<T1, T2, T3>(
            IEnumerable<T1>? source1,
            IEnumerable<T2>? source2,
            IEnumerable<T3>? source3);

        IEnumerable<(T1, T2, T3, T4)> CrossJoin<T1, T2, T3, T4>(
            IEnumerable<T1>? source1,
            IEnumerable<T2>? source2,
            IEnumerable<T3>? source3,
            IEnumerable<T4>? source4);

        IEnumerable<(T1, T2, T3, T4, T5)> CrossJoin<T1, T2, T3, T4, T5>(
            IEnumerable<T1>? source1,
            IEnumerable<T2>? source2,
            IEnumerable<T3>? source3,
            IEnumerable<T4>? source4,
            IEnumerable<T5>? source5);

        IEnumerable<(T1, T2, T3, T4, T5, T6)> CrossJoin<T1, T2, T3, T4, T5, T6>(
            IEnumerable<T1>? source1,
            IEnumerable<T2>? source2,
            IEnumerable<T3>? source3,
            IEnumerable<T4>? source4,
            IEnumerable<T5>? source5,
            IEnumerable<T6>? source6);

        IEnumerable<(T1, T2, T3, T4, T5, T6, T7)> CrossJoin<T1, T2, T3, T4, T5, T6, T7>(
            IEnumerable<T1>? source1,
            IEnumerable<T2>? source2,
            IEnumerable<T3>? source3,
            IEnumerable<T4>? source4,
            IEnumerable<T5>? source5,
            IEnumerable<T6>? source6,
            IEnumerable<T7>? source7);

        IEnumerable<(T1, T2, T3, T4, T5, T6, T7, T8)> CrossJoin<T1, T2, T3, T4, T5, T6, T7, T8>(
            IEnumerable<T1>? source1,
            IEnumerable<T2>? source2,
            IEnumerable<T3>? source3,
            IEnumerable<T4>? source4,
            IEnumerable<T5>? source5,
            IEnumerable<T6>? source6,
            IEnumerable<T7>? source7,
            IEnumerable<T8>? source8);

        IEnumerable<R>? SelectOrNull<T, R>(IEnumerable<T?>? source, Func<T?, R> select);
        T? SingleOrNull<T>(IEnumerable<T>? source);
        IEnumerable<T>? Slice<T>(IEnumerable<T>? source, int? startIndex, int? endIndex);
        IEnumerable<string>? Split(string stringToSplit, string separator);
        IEnumerable<string>? SplitOnMatches(string stringToSplit, string separatorPattern);
        CqlDate? Start(CqlInterval<CqlDate?>? argument);
        CqlDateTime? Start(CqlInterval<CqlDateTime?>? argument);
        CqlQuantity? Start(CqlInterval<CqlQuantity?>? argument);
        CqlTime? Start(CqlInterval<CqlTime?>? argument);
        decimal? Start(CqlInterval<decimal?>? argument);
        int? Start(CqlInterval<int?>? argument);
        long? Start(CqlInterval<long?>? argument);
        bool? Starts<T>(CqlInterval<T>? starts, CqlInterval<T>? other, string? precision);
        bool? StartsWith(string argument, string prefix);
        CqlQuantity? StdDev(IEnumerable<CqlQuantity?>? argument);
        decimal? StdDev(IEnumerable<decimal?>? argument);
        string? StringIndexer(string? argument, int? index);
        bool? StringInValueSet(string? code, CqlValueSet? valueSet);
        int? StringLength(string argument);
        bool? StringsInValueSet(IEnumerable<string?>? strings, CqlValueSet? valueSet);
        string? Substring(string source, int? startIndex, int? length = null);
        CqlDate? Subtract(CqlDate? left, CqlQuantity? right);
        CqlDateTime? Subtract(CqlDateTime? left, CqlQuantity? right);
        CqlQuantity? Subtract(CqlQuantity? left, CqlQuantity? right);
        CqlTime? Subtract(CqlTime? left, CqlQuantity? right);
        decimal? Subtract(decimal? left, decimal? right);
        int? Subtract(int? left, int? right);
        long? Subtract(long? left, long? right);
        CqlDate? Successor(CqlDate? argument);
        CqlDateTime? Successor(CqlDateTime? argument);
        CqlQuantity? Successor(CqlQuantity? argument);
        CqlTime? Successor(CqlTime? argument);
        decimal? Successor(decimal? argument);
        int? Successor(int? argument);
        long? Successor(long? argument);
        CqlQuantity? Sum(IEnumerable<CqlQuantity?>? argument);
        decimal? Sum(IEnumerable<decimal?> values);
        int? Sum(IEnumerable<int?> values);
        long? Sum(IEnumerable<long?> values);
        CqlTime? Time(int? hour, int? minute, int? second, int? millisecond);
        CqlTime? TimeFrom(CqlDateTime? argument);
        CqlTime? TimeOfDay();
        decimal? TimezoneOffsetFrom(CqlDateTime? argument);
        CqlInterval<CqlDate?>? ToClosed(CqlInterval<CqlDate?>? interval);
        CqlInterval<CqlDateTime?>? ToClosed(CqlInterval<CqlDateTime?>? interval);
        CqlInterval<CqlQuantity?>? ToClosed(CqlInterval<CqlQuantity?>? interval);
        CqlInterval<CqlTime?>? ToClosed(CqlInterval<CqlTime?>? interval);
        CqlInterval<decimal?>? ToClosed(CqlInterval<decimal?>? interval);
        CqlInterval<int?>? ToClosed(CqlInterval<int?>? interval);
        CqlInterval<long?>? ToClosed(CqlInterval<long?>? interval);
        CqlDate Today();
        IEnumerable<T> ToList<T>(T item);
        int? Truncate(decimal? argument);
        int? Truncate(int? argument);
        long? Truncate(long? argument);
        CqlQuantity? TruncateDivide(CqlQuantity? left, CqlQuantity? right);
        decimal? TruncateDivide(decimal? left, decimal? right);
        int? TruncateDivide(int? left, int? right);
        long? TruncateDivide(long? left, long? right);
        string? Upper(string argument);
        IEnumerable<CqlCode>? ValueSetUnion(IEnumerable<CqlCode>? left, IEnumerable<CqlCode>? right);
        CqlQuantity? Variance(IEnumerable<CqlQuantity?>? argument);
        decimal? Variance(IEnumerable<decimal?>? argument);
        IEnumerable<T>? WhereOrNull<T>(IEnumerable<T>? source, Func<T, bool?> lambda);
        CqlQuantity? Width(CqlInterval<CqlQuantity?>? @this);
        decimal? Width(CqlInterval<decimal?>? @this);
        int? Width(CqlInterval<int?>? @this);
        long? Width(CqlInterval<long?>? @this);
        bool? Xor(bool? left, bool? right);
        bool? Xor(Lazy<bool?> left, Lazy<bool?> right);

        #endregion
    }
}