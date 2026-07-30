#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2023, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSets;

namespace Hl7.Cql.Operators
{
    internal partial class CqlOperators
    {
        #region Contains
        public bool? Contains<T>(IEnumerable<T?>? list, T? item)
        {
            if (list == null)
                return false;

            if (item is null)
            {
                foreach (var i in list)
                    if (i is null)
                        return true;
                return false;
            }

            foreach (var i in list.Cast<object?>())
                if (Comparer.Compare(item, i, null) == 0)
                    return true;
            return false;
        }
        #endregion

        #region Distinct

        public IEnumerable<T>? Distinct<T>(IEnumerable<T> source)
        {
            if (source == null)
                return null;
            var result = new List<object?>();
            var seen = new HashSet<object>(EqualityComparer);
            var nullAdded = false;
            foreach (object? item in source)
            {
                if (item == null)
                {
                    if (!nullAdded)
                    {
                        result.Add(null);
                        nullAdded = true;
                    }
                }
                else if (seen.Add(item))
                {
                    result.Add(item);
                }
            }
            return result.CastToArray<object?, T>();
        }

        #endregion

        #region Equal

        // bool? ListEqual<T>(IEnumerable<T>? left, IEnumerable<T>? right) is located in CqlOperators.EqualityAndEquivalence.cs

        #endregion

        #region Equivalent

        // bool? Equivalent<T>(IEnumerable<T>? left, IEnumerable<T>? right) is located in CqlOperators.EqualityAndEquivalence.cs

        #endregion

        #region Except
        public IEnumerable<T>? Except<T>(IEnumerable<T>? left, IEnumerable<T>? right)
        {
            if (left == null)
                return right;
            else if (right == null)
                return left;
            else
            {
                var except = left
                    .Cast<object>()
                    .Except(right.Cast<object>(), EqualityComparer)
                    .Cast<T>()
                    .ToList();
                return except;
            }
        }

        #endregion

        #region Exists


        /// <summary>
        ///  The exists operator returns true if the list contains any non-null elements.
        ///  If the argument is null, the result is false.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public bool? Exists<T>(IEnumerable<T> list)
        {
            if (list == null) return false;

            foreach (var elem in list)
            {
                if (elem != null)
                    return true;
            }

            return false;
        }


        #endregion

        #region Expand

        public IEnumerable<CqlInterval<CqlDate?>>? Expand(IEnumerable<CqlInterval<CqlDate?>?>? argument, CqlQuantity? per)
        {
            if (argument == null)
                return null;

            // A per of zero or less never advances towards the high boundary, so no expansion can be computed.
            if (per?.value is <= 0)
                return null;

            var collapsed = Collapse(argument!, null)!;

            var expanded = new List<CqlInterval<CqlDate?>>();
            foreach (var item in collapsed)
            {
                if (item != null)
                {
                    // low is null and not closed or high is null and not closed
                    // For intervals with null boundaries (intervals with an undefined start or end date), if the boundary is open (e.g., Interval[0, null)),
                    // the interval will not contribute any results to the output. If the boundary is closed (e.g., Interval[0, null]), in theory the interval
                    // would contribute all intervals to the beginning or ending of the domain. In practice, because such an expansion is potentially too
                    // expensive to compute, and implementations are allowed to not return results for such an interval.
                    if ((item.low == null && !(item.lowClosed ?? false)) || (item.high == null && !(item.highClosed ?? false)))
                        continue;

                    var interval = ToClosed(item)!;

                    // If the per argument is null, a per value will be constructed based on the coarsest precision of the boundaries of the intervals in the input set.
                    if (per?.unit == null)
                        per = CoarsestPer(interval.low!.Precision, interval.high!.Precision);

                    var listItem = interval.low;
                    var highInterval = interval.high;
                    var perPrecision = PerUnitPrecision(per.unit);

                    if (perPrecision is { } precision)
                    {
                        // A Date has no time-of-day component, so a time-based per contributes nothing.
                        // ex: Interval[@2023-01-01, @2023-12-31] per minute
                        if (precision > Iso8601.DateTimePrecision.Day)
                            continue;

                        // Adding a per finer than the lower boundary's precision is null, so the interval contributes nothing.
                        if (interval.low!.Precision < precision)
                            continue;

                        listItem = TruncateToPrecision(interval.low!, precision);
                        highInterval = TruncateToPrecision(interval.high!, precision);
                    }

                    while (true)
                    {
                        Units.DatePrecisionToCqlUnits.TryGetValue(listItem!.Precision.ToString(), out var cqlunits);

                        // high is one less than next grouping using the smallest precision of the interval
                        // expand { Interval[@2022-01-01, @2024-03-01] } per 2 years returns { [2022-01-01, 2023-12-31] }
                        var onePrior = new CqlQuantity(1, cqlunits);
                        var next = listItem.Add(per);

                        var high = next?.Subtract(onePrior);

                        // Only intervals of size per that end on or before the upper boundary are contributed.
                        var endsOnOrBeforeHigh = high is not null && Comparer.Compare(high, highInterval!, null) <= 0;
                        if (!endsOnOrBeforeHigh)
                            break;

                        var listInterval = new CqlInterval<CqlDate?>(listItem, high, true, true);
                        expanded.Add(listInterval);
                        listItem = next;
                    }
                }
            }
            return expanded;
        }
        public IEnumerable<CqlInterval<CqlDateTime?>>? Expand(IEnumerable<CqlInterval<CqlDateTime?>?>? argument, CqlQuantity? per)
        {
            if (argument == null)
                return null;

            // A per of zero or less never advances towards the high boundary, so no expansion can be computed.
            if (per?.value is <= 0)
                return null;

            var collapsed = Collapse(argument, null)!;

            var expanded = new List<CqlInterval<CqlDateTime?>>();
            foreach (var item in collapsed)
            {
                if (item != null)
                {
                    // low is null and not closed or high is null and not closed
                    // For intervals with null boundaries (intervals with an undefined start or end date), if the boundary is open (e.g., Interval[0, null)),
                    // the interval will not contribute any results to the output. If the boundary is closed (e.g., Interval[0, null]), in theory the interval
                    // would contribute all intervals to the beginning or ending of the domain. In practice, because such an expansion is potentially too
                    // expensive to compute, and implementations are allowed to not return results for such an interval.
                    if ((item.low == null && !(item.lowClosed ?? false)) || (item.high == null && !(item.highClosed ?? false)))
                        continue;

                    var interval = ToClosed(item)!;

                    // If the per argument is null, a per value will be constructed based on the coarsest precision of the boundaries of the intervals in the input set.
                    if (per?.unit == null)
                        per = CoarsestPer(interval.low!.Precision, interval.high!.Precision);

                    var listItem = interval.low!;
                    var highInterval = interval.high!;
                    var perPrecision = PerUnitPrecision(per.unit);

                    if (perPrecision is { } precision)
                    {
                        // Adding a per finer than the lower boundary's precision is null, so the interval contributes nothing.
                        if (interval.low!.Precision < precision)
                            continue;

                        listItem = TruncateToPrecision(interval.low!, precision);
                        highInterval = TruncateToPrecision(interval.high!, precision);
                    }

                    while (true)
                    {
                        Units.DatePrecisionToCqlUnits.TryGetValue(listItem!.Precision.ToString(), out var cqlunits);

                        // high is one less than next grouping using the smallest precision of the interval
                        var onePrior = new CqlQuantity(1, cqlunits);
                        var next = listItem.Add(per);

                        var high = next?.Subtract(onePrior);

                        // Only intervals of size per that end on or before the upper boundary are contributed.
                        var endsOnOrBeforeHigh = high is not null && Comparer.Compare(high, highInterval, null) <= 0;
                        if (!endsOnOrBeforeHigh)
                            break;

                        var listInterval = new CqlInterval<CqlDateTime?>(listItem, high, true, true);
                        expanded.Add(listInterval);
                        listItem = next!;
                    }
                }
            }

            return expanded;
        }
        public IEnumerable<CqlInterval<CqlTime?>>? Expand(IEnumerable<CqlInterval<CqlTime?>?>? argument, CqlQuantity? per)
        {
            if (argument == null)
                return null;

            // A per of zero or less never advances towards the high boundary, so no expansion can be computed.
            if (per?.value is <= 0)
                return null;

            var collapsed = Collapse(argument!, null)!;

            var expanded = new List<CqlInterval<CqlTime?>>();
            foreach (var item in collapsed)
            {
                if (item != null)
                {
                    // low is null and not closed or high is null and not closed
                    // For intervals with null boundaries (intervals with an undefined start or end date), if the boundary is open (e.g., Interval[0, null)),
                    // the interval will not contribute any results to the output. If the boundary is closed (e.g., Interval[0, null]), in theory the interval
                    // would contribute all intervals to the beginning or ending of the domain. In practice, because such an expansion is potentially too
                    // expensive to compute, and implementations are allowed to not return results for such an interval.
                    if ((item.low == null && !(item.lowClosed ?? false)) || (item.high == null && !(item.highClosed ?? false)))
                        continue;

                    var interval = ToClosed(item)!;

                    // If the per argument is null, a per value will be constructed based on the coarsest precision of the boundaries of the intervals in the input set.
                    if (per?.unit == null)
                        per = CoarsestPer(interval.low!.Precision, interval.high!.Precision);

                    var listItem = interval.low;
                    var highInterval = interval.high;
                    var perPrecision = PerUnitPrecision(per.unit);

                    if (perPrecision is { } precision)
                    {
                        // A Time has no date component, so a date-based per contributes nothing.
                        // ex: Interval[@T10, @T10] per month
                        if (precision < Iso8601.DateTimePrecision.Hour)
                            continue;

                        // Adding a per finer than the lower boundary's precision is null, so the interval contributes nothing.
                        if (interval.low!.Precision < precision)
                            continue;

                        listItem = TruncateToPrecision(interval.low!, precision);
                        highInterval = TruncateToPrecision(interval.high!, precision);
                    }

                    while (true)
                    {
                        Units.DatePrecisionToCqlUnits.TryGetValue(listItem!.Precision.ToString(), out var cqlunits);

                        // high is one less than next grouping using the smallest precision of the interval
                        var onePrior = new CqlQuantity(1, cqlunits);
                        var next = listItem.Add(per);

                        var high = next?.Subtract(onePrior);

                        // Only intervals of size per that end on or before the upper boundary are contributed.
                        var endsOnOrBeforeHigh = high is not null && Comparer.Compare(high, highInterval!, null) <= 0;
                        if (!endsOnOrBeforeHigh)
                            break;

                        var listInterval = new CqlInterval<CqlTime?>(listItem, high, true, true);
                        expanded.Add(listInterval);
                        listItem = next;
                    }
                }
            }

            return expanded;
        }
        public IEnumerable<CqlInterval<decimal?>>? Expand(IEnumerable<CqlInterval<decimal?>?>? argument, CqlQuantity? per)
        {
            if (argument == null)
                return null;

            // A per of zero or less never advances towards the high boundary, so no expansion can be computed.
            if (per?.value is <= 0)
                return null;

            var collapsed = Collapse(argument, null)!;

            var expanded = new List<CqlInterval<decimal?>>();
            foreach (var item in collapsed)
            {
                if (item != null)
                {
                    // low is null and not closed or high is null and not closed
                    // For intervals with null boundaries (intervals with an undefined start or end date), if the boundary is open (e.g., Interval[0, null)),
                    // the interval will not contribute any results to the output. If the boundary is closed (e.g., Interval[0, null]), in theory the interval
                    // would contribute all intervals to the beginning or ending of the domain. In practice, because such an expansion is potentially too
                    // expensive to compute, and implementations are allowed to not return results for such an interval.
                    if ((item.low == null && !(item.lowClosed ?? false)) || (item.high == null && !(item.highClosed ?? false)))
                        continue;

                    var interval = ToClosed(item)!;

                    // If the per argument is null, a per value will be constructed based on the coarsest precision of the boundaries of the intervals in the input set.
                    if (per == null)
                        per = new CqlQuantity(1, "1");
                    else
                    {
                        // If the per quantity is a datetime, bypass the expansion of input interval of type decimal
                        if (per.unit is not null && Units.DatePrecisionToCqlUnits.Values.Contains(per.unit))
                            continue;
                    }

                    var listItem = interval.low!.Value;
                    var highBoundary = interval.high!.Value;
                    var perValue = per.value ?? 1m;
                    var usesDefaultDecimalUnit = string.IsNullOrEmpty(per.unit) || per.unit == UCUMUnits.Unary;
                    var perScale = perValue.Scale;

                    // Boundaries more precise than per are truncated to per's scale, which may broaden the input range.
                    var needsTruncation = usesDefaultDecimalUnit
                        && (listItem.Scale > perScale || highBoundary.Scale > perScale);

                    if (needsTruncation)
                    {
                        listItem = TruncateToScale(listItem, perScale);
                        highBoundary = TruncateToScale(highBoundary, perScale);
                    }

                    while (true)
                    {
                        var next = decimal.Add(listItem, perValue);
                        // Truncation expands at per's scale, so the interval ends one unit of that scale below the next
                        // start (N -> N-1 for an integer per), not at the decimal epsilon predecessor.
                        var high = needsTruncation ? decimal.Subtract(next, UnitAtScale(perScale)) : Predecessor(next);

                        // Only intervals of size per that end on or before the upper boundary are contributed.
                        var endsOnOrBeforeHigh = high is not null && Comparer.Compare(high, highBoundary, null) <= 0;
                        if (!endsOnOrBeforeHigh)
                            break;

                        var listInterval = new CqlInterval<decimal?>(listItem, high, true, true);
                        expanded.Add(listInterval);
                        listItem = next;
                    }
                }
            }

            return expanded;
        }
        public IEnumerable<CqlInterval<int?>>? Expand(IEnumerable<CqlInterval<int?>?>? argument, CqlQuantity? per)
        {
            if (argument == null)
                return null;

            // A per of zero or less never advances towards the high boundary, so no expansion can be computed.
            if (per?.value is <= 0)
                return null;

            var collapsed = Collapse(argument, null)!;

            var expanded = new List<CqlInterval<int?>>();
            foreach (var item in collapsed)
            {
                if (item != null)
                {
                    // low is null and not closed or high is null and not closed
                    // For intervals with null boundaries (intervals with an undefined start or end date), if the boundary is open (e.g., Interval[0, null)),
                    // the interval will not contribute any results to the output. If the boundary is closed (e.g., Interval[0, null]), in theory the interval
                    // would contribute all intervals to the beginning or ending of the domain. In practice, because such an expansion is potentially too
                    // expensive to compute, and implementations are allowed to not return results for such an interval.
                    if ((item.low == null && !(item.lowClosed ?? false)) || (item.high == null && !(item.highClosed ?? false)))
                        continue;

                    var interval = ToClosed(item)!;

                    // If the per argument is null, a per value will be constructed based on the coarsest precision of the boundaries of the intervals in the input set.
                    if (per == null)
                        per = new CqlQuantity(1, "1");
                    else
                    {
                        // If the per quantity is a datetime, bypass the expansion of input interval of type integer
                        if (per.unit is not null && Units.DatePrecisionToCqlUnits.Values.Contains(per.unit))
                            continue;
                    }

                    var perValue = per.value ?? 1;

                    // A fractional per makes the spec produce intervals of Decimal, which this Integer overload cannot represent.
                    if (decimal.Truncate(perValue) != perValue)
                        throw new NotSupportedException($"Expand of an interval of Integer with the fractional per '{perValue}' is not supported: the CQL specification requires the result to be a list of intervals of Decimal.");

                    var intQuantity = decimal.ToInt32(perValue);
                    var listItem = interval.low!.Value;
                    while (true)
                    {
                        var next = listItem + intQuantity;
                        var high = Predecessor(next);

                        // Only intervals of size per that end on or before the upper boundary are contributed.
                        var endsOnOrBeforeHigh = high is not null && Comparer.Compare(high, interval.high!, null) <= 0;
                        if (!endsOnOrBeforeHigh)
                            break;

                        var listInterval = new CqlInterval<int?>(listItem, high, true, true);
                        expanded.Add(listInterval);

                        listItem = next;
                    }
                }
            }

            return expanded;
        }
        public IEnumerable<CqlInterval<long?>>? Expand(IEnumerable<CqlInterval<long?>?>? argument, CqlQuantity? per)
        {
            if (argument == null)
                return null;

            // A per of zero or less never advances towards the high boundary, so no expansion can be computed.
            if (per?.value is <= 0)
                return null;

            var collapsed = Collapse(argument, null)!;

            var expanded = new List<CqlInterval<long?>>();
            foreach (var item in collapsed)
            {
                if (item != null)
                {
                    // low is null and not closed or high is null and not closed
                    // For intervals with null boundaries (intervals with an undefined start or end date), if the boundary is open (e.g., Interval[0, null)),
                    // the interval will not contribute any results to the output. If the boundary is closed (e.g., Interval[0, null]), in theory the interval
                    // would contribute all intervals to the beginning or ending of the domain. In practice, because such an expansion is potentially too
                    // expensive to compute, and implementations are allowed to not return results for such an interval.
                    if ((item.low == null && !(item.lowClosed ?? false)) || (item.high == null && !(item.highClosed ?? false)))
                        continue;

                    var interval = ToClosed(item)!;

                    // If the per argument is null, a per value will be constructed based on the coarsest precision of the boundaries of the intervals in the input set.
                    if (per == null)
                        per = new CqlQuantity(1, "1");
                    else
                    {
                        // If the per quantity is a datetime, bypass the expansion of input interval of type long
                        if (per.unit is not null && Units.DatePrecisionToCqlUnits.Values.Contains(per.unit))
                            continue;
                    }

                    var perValue = per.value ?? 1;

                    // A fractional per makes the spec produce intervals of Decimal, which this Long overload cannot represent.
                    if (decimal.Truncate(perValue) != perValue)
                        throw new NotSupportedException($"Expand of an interval of Long with the fractional per '{perValue}' is not supported: the CQL specification requires the result to be a list of intervals of Decimal.");

                    var intQuantity = decimal.ToInt64(perValue);
                    var listItem = interval.low!.Value;
                    while (true)
                    {
                        var next = listItem + intQuantity;
                        var high = Predecessor(next);

                        // Only intervals of size per that end on or before the upper boundary are contributed.
                        var endsOnOrBeforeHigh = high is not null && Comparer.Compare(high, interval.high!, null) <= 0;
                        if (!endsOnOrBeforeHigh)
                            break;

                        var listInterval = new CqlInterval<long?>(listItem, high, true, true);
                        expanded.Add(listInterval);

                        listItem = next;
                    }
                }
            }

            return expanded;
        }

        // Expand helpers, shared with the single interval overloads in CqlOperators.IntervalOperators.cs.

        /// <summary>
        /// A per of one unit of the coarser of the two boundary precisions, used when no per is supplied.
        /// </summary>
        private static CqlQuantity CoarsestPer(Iso8601.DateTimePrecision low, Iso8601.DateTimePrecision high)
        {
            var coarsest = low < high ? low : high;
            Units.DatePrecisionToCqlUnits.TryGetValue(coarsest.ToString(), out var cqlUnits);
            return new CqlQuantity(1, cqlUnits);
        }

        /// <summary>
        /// The precision an expansion of the given per unit aligns to, or <see langword="null" /> when the unit is not
        /// a temporal one. A per of weeks aligns to days, because there is no week precision.
        /// </summary>
        private static Iso8601.DateTimePrecision? PerUnitPrecision(string? unit) =>
            unit switch
            {
                "year" or "years" or UCUMUnits.Year => Iso8601.DateTimePrecision.Year,
                "month" or "months" or UCUMUnits.Month => Iso8601.DateTimePrecision.Month,
                "week" or "weeks" or UCUMUnits.Week
                    or "day" or "days" or UCUMUnits.Day => Iso8601.DateTimePrecision.Day,
                "hour" or "hours" or UCUMUnits.Hour => Iso8601.DateTimePrecision.Hour,
                "minute" or "minutes" or UCUMUnits.Minute => Iso8601.DateTimePrecision.Minute,
                "second" or "seconds" or UCUMUnits.Second => Iso8601.DateTimePrecision.Second,
                "millisecond" or "milliseconds" or UCUMUnits.Millisecond => Iso8601.DateTimePrecision.Millisecond,
                _ => null
            };

        // The CQL specification (§9.B, expand) truncates boundaries more precise than per to per's precision before
        // laying down the per-sized intervals, which is why the result may be broader than the input range. Boundaries
        // less precise than per are left alone: broadening them is uncertain, not truncation.

        private static CqlDate TruncateToPrecision(CqlDate value, Iso8601.DateTimePrecision precision)
        {
            if (value.Precision <= precision)
                return value;

            var date = value.Value;
            return precision switch
            {
                Iso8601.DateTimePrecision.Year => new CqlDate(date.Year, null, null),
                Iso8601.DateTimePrecision.Month => new CqlDate(date.Year, date.Month, null),
                _ => new CqlDate(date.Year, date.Month, date.Day)
            };
        }

        private static CqlDateTime TruncateToPrecision(CqlDateTime value, Iso8601.DateTimePrecision precision)
        {
            if (value.Precision <= precision)
                return value;

            var dateTime = value.Value;
            var offsetHour = dateTime.OffsetHour;
            var offsetMinute = dateTime.OffsetMinute;

            // An offset only has meaning from the hour precision onwards, and Iso8601 rejects a coarser value carrying one.
            return precision switch
            {
                Iso8601.DateTimePrecision.Year =>
                    new CqlDateTime(dateTime.Year, null, null, null, null, null, null, null, null),
                Iso8601.DateTimePrecision.Month =>
                    new CqlDateTime(dateTime.Year, dateTime.Month, null, null, null, null, null, null, null),
                Iso8601.DateTimePrecision.Day =>
                    new CqlDateTime(dateTime.Year, dateTime.Month, dateTime.Day, null, null, null, null, null, null),
                Iso8601.DateTimePrecision.Hour =>
                    new CqlDateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, null, null, null, offsetHour, offsetMinute),
                Iso8601.DateTimePrecision.Minute =>
                    new CqlDateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, null, null, offsetHour, offsetMinute),
                _ =>
                    new CqlDateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second, null, offsetHour, offsetMinute)
            };
        }

        private static CqlTime TruncateToPrecision(CqlTime value, Iso8601.DateTimePrecision precision)
        {
            if (value.Precision <= precision)
                return value;

            var time = value.Value;
            return precision switch
            {
                Iso8601.DateTimePrecision.Hour =>
                    new CqlTime(time.Hour, null, null, null, time.OffsetHour, time.OffsetMinute),
                Iso8601.DateTimePrecision.Minute =>
                    new CqlTime(time.Hour, time.Minute, null, null, time.OffsetHour, time.OffsetMinute),
                _ =>
                    new CqlTime(time.Hour, time.Minute, time.Second, null, time.OffsetHour, time.OffsetMinute)
            };
        }

        /// <summary>
        /// One unit at the given scale, e.g. a scale of 2 yields 0.01.
        /// </summary>
        private static decimal UnitAtScale(int scale) =>
            new(1, 0, 0, false, (byte)scale);

        private static decimal TruncateToScale(decimal value, int scale) =>
            Math.Round(value, scale, MidpointRounding.ToZero);

        #endregion

        #region Flatten


        /// <summary>
        /// The flatten operator flattens a list of lists into a single list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="argument"></param>
        /// <returns></returns>
        public IEnumerable<T>? Flatten<T>(IEnumerable<IEnumerable<T>> argument)
        {
            if (argument == null) return null;
            else
            {
                var flat = argument
                    .Where(i => i != null)
                    .SelectMany(i => i)
                    .ToList();
                return flat;
            }
        }

        public IEnumerable<object>? FlattenLateBoundList(IEnumerable<object> argument)
        {
            if (argument == null) return null;
            else
            {
                var flat = argument
                    .Select(i => i as IEnumerable<object>)
                    .Where(i => i != null)
                    .SelectMany(i => i!)
                    .ToList();
                return flat;

            }
        }

        #endregion

        #region First

        public T? First<T>(IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                return (T?)(object?)null;
            }
            else if (enumerable is IList<T> list)
            {
                if (list.Count == 0)
                {
                    return (T)(object)null!;
                }
                return list[0];
            }
            else
            {
                return enumerable.FirstOrDefault();
            }
        }

        #endregion

        #region In
        public bool? In<T>(T? element, IEnumerable<T?>? argument) => Contains(argument, element);

        public bool? CodeInList(CqlCode? element, IEnumerable<CqlCode>? argument)
        {
            if (element is null)
            {
                if (argument is null or IValueSetFacade)
                    return false;
                return argument.Any(t => t is null);
            }

            return argument switch
            {
                null => false,
                IValueSetFacade facade => facade.IsCodeInValueSet(element),
                _ => argument.Any(t => Comparer.Compare(element, t, null) == 0)
            };
        }

        #endregion

        #region Includes

        public bool? ListIncludesList<T>(IEnumerable<T>? left, IEnumerable<T>? right)
        {
            if (left == null || right == null) return null;

            foreach (var element in right)
            {
                var found = false;
                foreach (var t in left)
                {
                    if (EqualityComparer.Equals(element!, t!))
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                    return false;
            }
            return true;
        }

        public bool? ListIncludesElement<T>(IEnumerable<T>? left, T right) => Contains(left, right);


        #endregion

        #region Included In

        public bool? ListIncludedInList<T>(IEnumerable<T>? left, IEnumerable<T>? right) => ListIncludesList(right, left);

        public bool? ElementIncludedInList<T>(T left, IEnumerable<T>? right) =>
            ListIncludesElement(right, left);


        #endregion

        #region AtIndex

        public T? Indexer<T>(IEnumerable<T>? source, int? index)
        {
            if (source == null || index == null)
                return default;

            if (index.Value < 0)
                return default;

            if (source is IList<T> list)
            {
                if (index >= list.Count)
                    return default;

                return list[index.Value];
            }

            return source.ElementAtOrDefault(index.Value);
        }


        #endregion

        #region IndexOf

        public int? IndexOf<T>(IEnumerable<T>? list, T element)
        {
            if (list == null || element == null)
                return null;

            int i = 0;
            foreach (T t in list)
            {
                if (EqualityComparer.Equals(t!, element))
                    return i;
                i++;
            }
            return -1;
        }

        #endregion

        #region Intersect
        public IEnumerable<T>? Intersect<T>(IEnumerable<T>? left, IEnumerable<T>? right)
        {
            if (left == null || right == null)
                return null;
            else
            {
                var result = left
                    .Cast<object>()
                    .Intersect(right.Cast<object>())
                    .Cast<T>()
                    .ToList();
                return result;
            }
        }
        #endregion

        #region Last

        public T? Last<T>(IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                return (T?)(object?)null;
            }
            if (enumerable is IList<T> list)
            {
                if (list.Count == 0)
                    return (T)(object)null!;
                return list[list.Count - 1];
            }
            else
            {
                return enumerable.LastOrDefault();
            }
        }

        #endregion

        #region Length

        public int? Length(string argument)
        {
            var length = argument switch
            {
                null => default(int?), // tested by LengthNullString
                _    => argument.Length
            };
            return length;
        }

        public int? Length<T>(IEnumerable<T>? list)
        {
            int? length = list switch
            {
                null                                                 => 0, // tested by LengthNullList
                string s                                             => Length(s),
                { } l when l.TryGetNonEnumeratedCount(out var count) => count,
                _                                                    => list.Count()
            };
            return length;
        }

        #endregion

        #region Not Equal

        // public bool? ListNotEqual<T>(IEnumerable<T>? left, IEnumerable<T>? right) moved to CqlOperators.ListOperators.cs

        #endregion

        #region Not Equivalent

        // public bool? ListNotEquivalent<T>(IEnumerable<T>? left, IEnumerable<T>? right) moved to CqlOperators.ListOperators.cs

        #endregion

        #region Properly Includes

        public bool? ListProperlyIncludesElement<T>(IEnumerable<T>? left, T right) => ListProperlyIncludesList(left, new T[] { right });

        public bool? ListProperlyIncludesList<T>(IEnumerable<T>? left, IEnumerable<T>? right)
        {
            if (left is null || right is null) return null;

            var includes = ListIncludedInList(right, left);
            if (includes != true) return includes;

            return left.Count() > right.Count();
        }

        #endregion

        #region Properly Included In

        public bool? ListProperlyIncludedInList<T>(IEnumerable<T>? left, IEnumerable<T>? right) => ListProperlyIncludesList(right, left);


        public bool? ElementProperlyIncludedInList<T>(T left, IEnumerable<T> right) =>
            ListProperlyIncludesElement(right, left);


        #endregion

        #region Singleton From

        public T? SingletonFrom<T>(IEnumerable<T>? source)
        {
            if (source == null)
                return (T?)(object?)null;
            else
                return source.SingleOrDefault();
        }


        #endregion

        #region Slice, skip, take, tail

        public IEnumerable<T>? Slice<T>(IEnumerable<T>? source, int? startIndex, int? endIndex)
        {
            if (source == null)
                return null;

            if (startIndex == null && endIndex == null)
                return source;

            if (startIndex < 0 || endIndex <= 0)
                return Enumerable.Empty<T>();

            if (endIndex == null)
            {
                return source.Skip(startIndex ?? 0).ToList();
            }
            else
            {
                return source.Skip(startIndex ?? 0).Take(endIndex.Value - (startIndex ?? 0)).ToList();
            }
        }

        public IEnumerable<T>? ListSkip<T>(IEnumerable<T> argument, int? number)
        {
            if (number == null) return argument;

            if (argument == null) return null;
            else return argument
                    .Skip(number.Value)
                    .ToList();
        }

        public IEnumerable<T>? Tail<T>(IEnumerable<T> argument)
        {
            if (argument == null)
                return null;
            else if (argument.Count() == 0)
                return new List<T>();
            else
                return ListSkip(argument, 1);
        }

        public IEnumerable<T>? ListTake<T>(IEnumerable<T> argument, int? number)
        {
            if (number == null) return new List<T>();

            if (argument == null) return null;
            else return argument
                    .Take(number.Value)
                    .ToList();
        }

        #endregion

        #region Union

        public IEnumerable<T>? Union<T>(IEnumerable<T>? left, IEnumerable<T>? right)
        {
            if (left == null)
                return right;
            else if (right == null)
                return left;
            else
            {
                var union = left
                    .Cast<object>()
                    .Union(right.Cast<object>(), EqualityComparer)
                    .Cast<T>()
                    .ToList();
                return union;
            }
        }

		public IEnumerable<CqlCode>? ValueSetUnion(IEnumerable<CqlCode>? left, IEnumerable<CqlCode>? right)
        {
            if (left == null || right == null)
                return null;
            else
                return left.Union(right);
        }

        #endregion

        #region Sort


        public IEnumerable<T>? ListSort<T>(IEnumerable<T>? source, ListSortDirection order)
        {
            if (source == null)
                return null;

            var nullRecords = source.Where(w => w == null);
            var nonNullRecords = source.Where(w => w != null);

            if (order == ListSortDirection.Ascending)
            {
                var ordered = nonNullRecords
                    .Cast<object>()
                    .OrderBy(t => t, DataComparer)
                    .Cast<T>()
                    .ToList();
                return nullRecords.Concat(ordered);
            }
            else if (order == ListSortDirection.Descending)
            {
                var ordered = nonNullRecords
                    .Cast<object>()
                    .OrderBy(t => t, DataComparer)
                    .Reverse()
                    .Cast<T>()
                    .ToList();
                return ordered.Concat(nullRecords);
            }
            else throw new NotSupportedException($"Unknown sort order {order}");
        }

        public IEnumerable<T>? SortBy<T>(IEnumerable<T>? source, Func<T, object> sortByExpr, ListSortDirection order)
        {
            if (source == null)
                return null;
            if (order == ListSortDirection.Ascending)
            {
                var nullRecords = source.Where(s => sortByExpr(s) == null);
                var nonNullRecords = source.Where(s => sortByExpr(s) != null);
                var ordered = nonNullRecords.OrderBy(source => sortByExpr(source), DataComparer);
                var result = nullRecords.Concat(ordered);
                return result;
            }
            else if (order == ListSortDirection.Descending)
            {
                var nullRecords = source.Where(s => sortByExpr(s) == null);
                var nonNullRecords = source.Where(s => sortByExpr(s) != null);
                var ordered = nonNullRecords.OrderByDescending(source => sortByExpr(source), DataComparer);
                var result = ordered.Concat(nullRecords);
                return result;
            }
            else throw new NotSupportedException($"Unknown sort order {order}");
        }

        #endregion

    }
}
