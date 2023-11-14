#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Hl7.Cql.Runtime
{
    internal partial class CqlOperators
    {
        #region Contains
        public bool? ListContains<T>(IEnumerable<T> list, T item)
        {
            if (list == null) return false;
            if (item == null) return null;
            foreach (var i in list.Cast<object>())
                if (Compare(item, i, null) == 0)
                    return true;
            return false;
        }
        #endregion

        #region Distinct

        public IEnumerable<T>? ListDistinct<T>(IEnumerable<T> source)
        {
            if (source == null)
                return null;
            var result = new List<object?>();
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
                else if (!Enumerable.Contains(result!, item!, IEqualityComparer!))
                {
                    result.Add(item!);
                }
            }
            var asT = result
                .Cast<T>()
                .ToArray();
            return asT;
        }

        #endregion

        #region Equal

        public bool? ListEqual<T>(IEnumerable<T>? left, IEnumerable<T>? right)
        {
            if (left == null || right == null)
                return null;

            var onlyNull = true;
            var notEmpty = false;
            var lit = left!.GetEnumerator();
            var rit = right!.GetEnumerator();
            while (lit.MoveNext())
            {
                if (!rit.MoveNext())
                    return false;
                notEmpty = true;
                var lv = lit.Current;
                var rv = rit.Current;
                if (lv == null)
                {
                    if (rv != null) return false;
                }
                else if (rv == null) return false;
                else
                {
                    onlyNull = false;
                    if (Compare(lv!, rv!, null) != 0)
                        return false;
                }
            }
            if (rit.MoveNext()) // the 2nd list is longer than the 1st.
                return false;

            if (notEmpty && onlyNull)
                return null;
            else
                return true;
        }

        #endregion

        #region Equivalent

        public bool? ListEquivalent<T>(IEnumerable<T>? left, IEnumerable<T>? right)
        {
            if (left == null)
            {
                if (right == null)
                    return true;
                else return null;
            }
            else if (right == null)
                return null;

            var lit = left!.GetEnumerator();
            var rit = right!.GetEnumerator();
            while (lit.MoveNext())
            {
                if (!rit.MoveNext())
                    return false;

                var lv = lit.Current;
                var rv = rit.Current;
                if (lv == null)
                {
                    if (rv != null) return false;
                }
                else if (rv == null) return false;
                else if (Equivalent(lv!, rv!, null) == false)
                    return false;
            }
            if (rit.MoveNext()) // the 2nd list is longer than the 1st.
                return false;
            return true;
        }

        #endregion

        #region Except
        public IEnumerable<T>? ListExcept<T>(IEnumerable<T>? left, IEnumerable<T>? right)
        {
            if (left == null)
                return right;
            else if (right == null)
                return left;
            else
            {
                var except = left
                    .Cast<object>()
                    .Except(right.Cast<object>(), IEqualityComparer)
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
        public bool? ExistsInList<T>(IEnumerable<T> list)
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

        public IEnumerable<CqlInterval<CqlDate?>>? ExpandList(IEnumerable<CqlInterval<CqlDate?>?>? argument, CqlQuantity? per)
        {
            if (argument == null)
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
                    var setLowPrecisionToPer = false;
                    var setHighPrecisionToPer = false;

                    // If the per argument is null, a per value will be constructed based on the coarsest precision of the boundaries of the intervals in the input set.
                    if (per?.unit == null)
                    {
                        if (interval.low!.Precision == interval.high!.Precision)
                        {
                            Units.CqlUnitsToUCUM.TryGetValue(interval.low.Precision.ToString(), out var ucmunits);
                            per = new CqlQuantity(1, ucmunits);
                        }
                        else if (interval.low.Precision < interval.high.Precision)
                        {
                            Units.CqlUnitsToUCUM.TryGetValue(interval.low.Precision.ToString(), out var ucmunits);
                            per = new CqlQuantity(1, ucmunits);

                            setHighPrecisionToPer = true;
                        }
                        else
                        {
                            Units.CqlUnitsToUCUM.TryGetValue(interval.high.Precision.ToString(), out var ucmunits);
                            per = new CqlQuantity(1, ucmunits);

                            setLowPrecisionToPer = true;
                        }
                    }
                    else
                    {
                        switch (per.unit)
                        {
                            case "mo":
                                if (interval.low!.Precision < Iso8601.DateTimePrecision.Month
                                    && interval.high!.Precision < Iso8601.DateTimePrecision.Month)
                                    return expanded;

                                if (interval.low.Precision > Iso8601.DateTimePrecision.Month)
                                    setLowPrecisionToPer = true;
                                else if (interval.high!.Precision > Iso8601.DateTimePrecision.Month)
                                    setHighPrecisionToPer = true;


                                break;
                            case "d":
                            case "wk":
                                if (interval.low!.Precision < Iso8601.DateTimePrecision.Day
                                    && interval.high!.Precision < Iso8601.DateTimePrecision.Day)
                                    return expanded;

                                if (interval.low.Precision > Iso8601.DateTimePrecision.Day)
                                    setLowPrecisionToPer = true;
                                else if (interval.high!.Precision > Iso8601.DateTimePrecision.Day)
                                    setHighPrecisionToPer = true;

                                break;
                            // parsed as a time unit when it's a date so default to the coarsest
                            // ex: Interval[2023-01-01, 2023-12-31] per minute
                            case "h":
                            case "min":
                            case "s":
                            case "ms":
                                return expanded!;
                        }
                    }

                    var listItem = interval.low;
                    var highInterval = interval.high;

                    if (setLowPrecisionToPer)
                    {
                        var lowValue = interval.low!.Value;
                        switch (interval.high!.Precision)
                        {
                            case Iso8601.DateTimePrecision.Year:
                                listItem = new CqlDate(lowValue.Year, null, null);
                                break;
                            case Iso8601.DateTimePrecision.Month:
                                listItem = new CqlDate(lowValue.Year, lowValue.Month ?? 1, null);
                                break;
                            case Iso8601.DateTimePrecision.Day:
                                listItem = new CqlDate(lowValue.Year, lowValue.Month, lowValue.Day ?? 1);
                                break;
                        }
                    }

                    if (setHighPrecisionToPer)
                    {
                        var highValue = interval.high!.Value;
                        switch (interval.low!.Precision)
                        {
                            case Iso8601.DateTimePrecision.Year:
                                highInterval = new CqlDate(highValue.Year, null, null);
                                break;
                            case Iso8601.DateTimePrecision.Month:
                                highInterval = new CqlDate(highValue.Year, highValue.Month ?? 1, null);
                                break;
                            case Iso8601.DateTimePrecision.Day:
                                highInterval = new CqlDate(highValue.Year, highValue.Month, highValue.Day ?? 1);
                                break;
                        }
                    }

                    do
                    {
                        var precision = UCUMUnits.FromDateTimePrecision(listItem!.Precision);

                        // high is one less than next grouping using the smallest precision of the interval
                        // expand { Interval[@2022-01-01, @2024-03-01] } per 2 years returns { [2022-01-01, 2023-12-31], [2024-01-01, 2025-12-31] }
                        var onePrior = new CqlQuantity(1, precision);
                        var next = listItem.Add(per);

                        var high = next!.Subtract(onePrior);
                        var listInterval = new CqlInterval<CqlDate?>(listItem, high, true, true);
                        expanded.Add(listInterval);
                        listItem = next;
                    }
                    while (Compare(listItem!, highInterval!, null) <= 0);
                }
            }
            return expanded;
        }
        public IEnumerable<CqlInterval<CqlDateTime?>>? ExpandList(IEnumerable<CqlInterval<CqlDateTime?>?>? argument, CqlQuantity? per)
        {
            if (argument == null)
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
                    var setLowPrecisionToPer = false;
                    var setHighPrecisionToPer = false;

                    // If the per argument is null, a per value will be constructed based on the coarsest precision of the boundaries of the intervals in the input set.
                    if (per?.unit == null)
                    {
                        if (interval.low!.Precision == interval.high!.Precision)
                        {
                            Units.CqlUnitsToUCUM.TryGetValue(interval.low.Precision.ToString(), out var ucmunits);
                            per = new CqlQuantity(1, ucmunits);
                        }
                        else if (interval.low.Precision < interval.high.Precision)
                        {
                            Units.CqlUnitsToUCUM.TryGetValue(interval.low.Precision.ToString(), out var ucmunits);
                            per = new CqlQuantity(1, ucmunits);

                            setHighPrecisionToPer = true;
                        }
                        else
                        {
                            Units.CqlUnitsToUCUM.TryGetValue(interval.high.Precision.ToString(), out var ucmunits);
                            per = new CqlQuantity(1, ucmunits);

                            setLowPrecisionToPer = true;
                        }
                    }
                    else
                    {
                        switch (per.unit)
                        {
                            case "mo":
                                if (interval.low!.Precision < Iso8601.DateTimePrecision.Month
                                    && interval.high!.Precision < Iso8601.DateTimePrecision.Month)
                                    return expanded;

                                if (interval.low.Precision > Iso8601.DateTimePrecision.Month)
                                    setLowPrecisionToPer = true;
                                else if (interval.high!.Precision > Iso8601.DateTimePrecision.Month)
                                    setHighPrecisionToPer = true;

                                break;
                            case "d":
                            case "wk":
                                if (interval.low!.Precision < Iso8601.DateTimePrecision.Day
                                    && interval.high!.Precision < Iso8601.DateTimePrecision.Day)
                                    return expanded;

                                if (interval.low.Precision > Iso8601.DateTimePrecision.Day)
                                    setLowPrecisionToPer = true;
                                else if (interval.high!.Precision > Iso8601.DateTimePrecision.Day)
                                    setHighPrecisionToPer = true;

                                break;
                            // per has a coarser precision than the interval so nothing is added
                            case "h":
                                if (interval.low!.Precision < Iso8601.DateTimePrecision.Hour
                                    && interval.high!.Precision < Iso8601.DateTimePrecision.Hour)
                                    return expanded;

                                if (interval.low.Precision > Iso8601.DateTimePrecision.Hour)
                                    setLowPrecisionToPer = true;
                                else if (interval.high!.Precision > Iso8601.DateTimePrecision.Hour)
                                    setHighPrecisionToPer = true;

                                break;
                            case "min":
                                if (interval.low!.Precision < Iso8601.DateTimePrecision.Minute
                                    && interval.high!.Precision < Iso8601.DateTimePrecision.Minute)
                                    return expanded;

                                if (interval.low.Precision > Iso8601.DateTimePrecision.Minute)
                                    setLowPrecisionToPer = true;
                                else if (interval.high!.Precision > Iso8601.DateTimePrecision.Minute)
                                    setHighPrecisionToPer = true;

                                break;
                            case "s":
                                if (interval.low!.Precision < Iso8601.DateTimePrecision.Second
                                    && interval.high!.Precision < Iso8601.DateTimePrecision.Second)
                                    return expanded;

                                if (interval.low.Precision > Iso8601.DateTimePrecision.Second)
                                    setLowPrecisionToPer = true;
                                else if (interval.high!.Precision > Iso8601.DateTimePrecision.Second)
                                    setHighPrecisionToPer = true;

                                break;
                        }
                    }

                    var listItem = interval.low!;
                    var highInterval = interval.high!;

                    if (setLowPrecisionToPer)
                    {
                        var lowValue = interval.low!.Value;
                        switch (interval.high!.Precision)
                        {
                            case Iso8601.DateTimePrecision.Year:
                                listItem = new CqlDateTime(lowValue.Year, null, null, null, null, null, null, lowValue.OffsetHour, lowValue.OffsetMinute);
                                break;
                            case Iso8601.DateTimePrecision.Month:
                                listItem = new CqlDateTime(lowValue.Year, lowValue.Month ?? 1, null, null, null, null, null, lowValue.OffsetHour, lowValue.OffsetMinute);
                                break;
                            case Iso8601.DateTimePrecision.Day:
                                listItem = new CqlDateTime(lowValue.Year, lowValue.Month, lowValue.Day ?? 1, null, null, null, null, lowValue.OffsetHour, lowValue.OffsetMinute);
                                break;
                            case Iso8601.DateTimePrecision.Hour:
                                listItem = new CqlDateTime(lowValue.Year, lowValue.Month, lowValue.Day, 0, null, null, null, lowValue.OffsetHour, lowValue.OffsetMinute);
                                break;
                            case Iso8601.DateTimePrecision.Minute:
                                listItem = new CqlDateTime(lowValue.Year, lowValue.Month, lowValue.Day, lowValue.Hour, 0, null, null, lowValue.OffsetHour, lowValue.OffsetMinute);
                                break;
                            case Iso8601.DateTimePrecision.Second:
                                listItem = new CqlDateTime(lowValue.Year, lowValue.Month, lowValue.Day, lowValue.Hour, 0, 0, null, lowValue.OffsetHour, lowValue.OffsetMinute);
                                break;
                            case Iso8601.DateTimePrecision.Millisecond:
                                listItem = new CqlDateTime(lowValue.Year, lowValue.Month, lowValue.Day, lowValue.Hour, 0, 0, 0, lowValue.OffsetHour, lowValue.OffsetMinute);
                                break;
                        }
                    }

                    if (setHighPrecisionToPer)
                    {
                        var highValue = interval.high!.Value;
                        switch (interval.low!.Precision)
                        {
                            case Iso8601.DateTimePrecision.Year:
                                highInterval = new CqlDateTime(highValue.Year, null, null, null, null, null, null, highValue.OffsetHour, highValue.OffsetMinute);
                                break;
                            case Iso8601.DateTimePrecision.Month:
                                highInterval = new CqlDateTime(highValue.Year, highValue.Month ?? 1, null, null, null, null, null, highValue.OffsetHour, highValue.OffsetMinute);
                                break;
                            case Iso8601.DateTimePrecision.Day:
                                highInterval = new CqlDateTime(highValue.Year, highValue.Month, highValue.Day ?? 1, null, null, null, null, highValue.OffsetHour, highValue.OffsetMinute);
                                break;
                            case Iso8601.DateTimePrecision.Hour:
                                highInterval = new CqlDateTime(highValue.Year, highValue.Month, highValue.Day, 0, null, null, null, highValue.OffsetHour, highValue.OffsetMinute);
                                break;
                            case Iso8601.DateTimePrecision.Minute:
                                highInterval = new CqlDateTime(highValue.Year, highValue.Month, highValue.Day, highValue.Hour, 0, null, null, highValue.OffsetHour, highValue.OffsetMinute);
                                break;
                            case Iso8601.DateTimePrecision.Second:
                                highInterval = new CqlDateTime(highValue.Year, highValue.Month, highValue.Day, highValue.Hour, 0, 0, null, highValue.OffsetHour, highValue.OffsetMinute);
                                break;
                            case Iso8601.DateTimePrecision.Millisecond:
                                highInterval = new CqlDateTime(highValue.Year, highValue.Month, highValue.Day, highValue.Hour, 0, 0, 0, highValue.OffsetHour, highValue.OffsetMinute);
                                break;
                        }
                    }

                    do
                    {
                        var precision = UCUMUnits.FromDateTimePrecision(listItem!.Precision);

                        // high is one less than next grouping using the smallest precision of the interval
                        var onePrior = new CqlQuantity(1, precision);
                        var next = listItem.Add(per);

                        var high = next!.Subtract(onePrior);
                        var listInterval = new CqlInterval<CqlDateTime?>(listItem, high, true, true);
                        expanded.Add(listInterval);
                        listItem = next;
                    }
                    while (Compare(listItem!, highInterval, null) <= 0);
                }
            }

            return expanded;
        }
        public IEnumerable<CqlInterval<CqlTime?>>? ExpandList(IEnumerable<CqlInterval<CqlTime?>?>? argument, CqlQuantity? per)
        {
            if (argument == null)
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
                    var setLowPrecisionToPer = false;
                    var setHighPrecisionToPer = false;
                    // If the per argument is null, a per value will be constructed based on the coarsest precision of the boundaries of the intervals in the input set.
                    if (per?.unit == null)
                    {
                        if (interval.low!.Precision == interval.high!.Precision)
                        {
                            Units.CqlUnitsToUCUM.TryGetValue(interval.low.Precision.ToString(), out var ucmunits);
                            per = new CqlQuantity(1, ucmunits);
                        }
                        else if (interval.low.Precision < interval.high.Precision)
                        {
                            Units.CqlUnitsToUCUM.TryGetValue(interval.low.Precision.ToString(), out var ucmunits);
                            per = new CqlQuantity(1, ucmunits);

                            setHighPrecisionToPer = true;
                        }
                        else
                        {
                            Units.CqlUnitsToUCUM.TryGetValue(interval.high.Precision.ToString(), out var ucmunits);
                            per = new CqlQuantity(1, ucmunits);

                            setLowPrecisionToPer = true;
                        }
                    }
                    else
                    {
                        switch (per.unit)
                        {
                            // per has a coarser precision than the interval so nothing is added
                            case "h":
                                if (interval.low!.Precision < Iso8601.DateTimePrecision.Hour
                                    && interval.high!.Precision < Iso8601.DateTimePrecision.Hour)
                                    continue;

                                if (interval.low!.Precision > Iso8601.DateTimePrecision.Hour)
                                    setLowPrecisionToPer = true;
                                else if (interval.high!.Precision > Iso8601.DateTimePrecision.Hour)
                                    setHighPrecisionToPer = true;

                                break;
                            case "min":
                                if (interval.low!.Precision < Iso8601.DateTimePrecision.Minute
                                    && interval.high!.Precision < Iso8601.DateTimePrecision.Minute)
                                    continue;

                                if (interval.low.Precision > Iso8601.DateTimePrecision.Minute)
                                    setLowPrecisionToPer = true;
                                else if (interval.high!.Precision > Iso8601.DateTimePrecision.Minute)
                                    setHighPrecisionToPer = true;

                                break;
                            case "s":
                                if (interval.low!.Precision < Iso8601.DateTimePrecision.Second
                                    && interval.high!.Precision < Iso8601.DateTimePrecision.Second)
                                    continue;

                                if (interval.low.Precision > Iso8601.DateTimePrecision.Millisecond)
                                    setLowPrecisionToPer = true;
                                else if (interval.high!.Precision > Iso8601.DateTimePrecision.Millisecond)
                                    setHighPrecisionToPer = true;


                                break;
                            // parsed as a date unit when it's a time so return empty list
                            // ex: Interval[@T10, @T10] per month
                            case "a":
                            case "mo":
                            case "d":
                            case "wk":
                                continue;
                        }
                    }

                    var listItem = interval.low;
                    var highInterval = interval.high;
                    if (setLowPrecisionToPer)
                    {
                        var lowValue = interval.low!.Value;
                        switch (interval.high!.Precision)
                        {
                            case Iso8601.DateTimePrecision.Hour:
                                listItem = new CqlTime(lowValue.Hour, null, null, null, lowValue.OffsetHour, lowValue.OffsetMinute);
                                break;
                            case Iso8601.DateTimePrecision.Minute:
                                listItem = new CqlTime(lowValue.Hour, 0, null, null, lowValue.OffsetHour, lowValue.OffsetMinute);
                                break;
                            case Iso8601.DateTimePrecision.Second:
                                listItem = new CqlTime(lowValue.Hour, 0, 0, null, lowValue.OffsetHour, lowValue.OffsetMinute);
                                break;
                            case Iso8601.DateTimePrecision.Millisecond:
                                listItem = new CqlTime(lowValue.Hour, 0, 0, 0, lowValue.OffsetHour, lowValue.OffsetMinute);
                                break;
                        }
                    }

                    if (setHighPrecisionToPer)
                    {
                        var highValue = interval.high!.Value;
                        switch (interval.low!.Precision)
                        {
                            case Iso8601.DateTimePrecision.Hour:
                                highInterval = new CqlTime(highValue.Hour, null, null, null, highValue.OffsetHour, highValue.OffsetMinute);
                                break;
                            case Iso8601.DateTimePrecision.Minute:
                                highInterval = new CqlTime(highValue.Hour, 0, null, null, highValue.OffsetHour, highValue.OffsetMinute);
                                break;
                            case Iso8601.DateTimePrecision.Second:
                                highInterval = new CqlTime(highValue.Hour, 0, 0, null, highValue.OffsetHour, highValue.OffsetMinute);
                                break;
                            case Iso8601.DateTimePrecision.Millisecond:
                                highInterval = new CqlTime(highValue.Hour, 0, 0, 0, highValue.OffsetHour, highValue.OffsetMinute);
                                break;
                        }
                    }

                    do
                    {
                        var precision = UCUMUnits.FromDateTimePrecision(listItem!.Precision);

                        // high is one less than next grouping using the smallest precision of the interval
                        var onePrior = new CqlQuantity(1, precision);
                        var next = listItem.Add(per);

                        var high = next!.Subtract(onePrior);
                        var listInterval = new CqlInterval<CqlTime?>(listItem, high, true, true);
                        expanded.Add(listInterval);
                        listItem = next;
                    }
                    while (Compare(listItem!, highInterval!, null) <= 0);
                }
            }

            return expanded;
        }
        public IEnumerable<CqlInterval<decimal?>>? ExpandList(IEnumerable<CqlInterval<decimal?>?>? argument, CqlQuantity? per)
        {
            if (argument == null)
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
                        Units.UCUMUnitsToCql.TryGetValue(per.unit ?? "", out var ucumUnits);
                        if (ucumUnits != null)
                            continue;
                    }

                    var listItem = interval.low!.Value;
                    do
                    {


                        var high = decimal.Add(listItem, per.value ?? 1);
                        var listInterval = new CqlInterval<decimal?>(listItem, Predecessor(high), true, true);
                        expanded.Add(listInterval);
                        listItem = high;
                    }
                    while (Compare(listItem, interval.high!, null) <= 0);
                }
            }

            return expanded;
        }
        public IEnumerable<CqlInterval<int?>>? ExpandList(IEnumerable<CqlInterval<int?>?>? argument, CqlQuantity? per)
        {
            if (argument == null)
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
                        Units.UCUMUnitsToCql.TryGetValue(per.unit ?? "", out var ucumUnits);
                        if (ucumUnits != null)
                            continue;
                    }

                    var listItem = interval.low!.Value;
                    do
                    {
                        var intQuantity = decimal.ToInt32(per.value ?? 1);
                        var high = listItem + intQuantity;
                        var listInterval = new CqlInterval<int?>(listItem, Predecessor(high), true, true);
                        expanded.Add(listInterval);

                        listItem = high;
                    }
                    while (Compare(listItem, interval.high!, null) <= 0);
                }
            }

            return expanded;
        }
        public IEnumerable<CqlInterval<long?>>? ExpandList(IEnumerable<CqlInterval<long?>?>? argument, CqlQuantity? per)
        {
            if (argument == null)
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
                        Units.UCUMUnitsToCql.TryGetValue(per.unit ?? "", out var ucumUnits);
                        if (ucumUnits != null)
                            continue;
                    }

                    var listItem = interval.low!.Value;
                    do
                    {
                        var intQuantity = decimal.ToInt64(per.value ?? 1);
                        var high = listItem + intQuantity;
                        var listInterval = new CqlInterval<long?>(listItem, Predecessor(high), true, true);
                        expanded.Add(listInterval);

                        listItem = high;
                    }
                    while (Compare(listItem, interval.high!, null) <= 0);
                }
            }

            return expanded;
        }
        #endregion

        #region Flatten


        /// <summary>
        /// The flatten operator flattens a list of lists into a single list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="argument"></param>
        /// <returns></returns>
        public IEnumerable<T>? FlattenList<T>(IEnumerable<IEnumerable<T>> argument)
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

        public T? FirstOfList<T>(IEnumerable<T> enumerable)
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
        public bool? InList<T>(T element, IEnumerable<T> argument)
        {
            if ((object)element! == null)
                return null;
            if (argument == null)
                return false;
            else
            {
                return argument.Any(t => Compare(element, t!, null) == 0);
            }

        }

        public bool? CodeInList(CqlCode? element, IEnumerable<CqlCode>? argument)
        {
            if (element! == null)
                return null;
            else if (argument == null)
                return false;
            else if (argument is ValueSetFacade facade)
            {
                var result = facade.IsCodeInValueSet(element);
                return result;
            }
            else
            {
                var result = argument.Any(t => Compare(element, t!, null) == 0);
                return result;
            }
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
                    if (IEqualityComparer.Equals(element!, t!))
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

        public bool? ListIncludesElement<T>(IEnumerable<T>? left, T right) => ListIncludesList(left, new T[] { right });


        #endregion

        #region Included In

        public bool? ListIncludedInList<T>(IEnumerable<T>? left, IEnumerable<T>? right) => ListIncludesList(right, left);

        public bool? ElementIncludedInList<T>(T left, IEnumerable<T>? right) =>
            ListIncludesElement(right, left);


        #endregion

        #region Indexer

        public T ListElementAt<T>(IEnumerable<T>? source, int? index)
        {
            if (source == null || index == null)
                return (T)(object)null!;
            if (index.Value < 0)
                return (T)(object)null!;
            else if (source is IList<T> list)
            {
                if (index >= list.Count)
                    return (T)(object)null!;
                return list[index.Value];
            }
            else
            {
                var tList = source
                    .Skip(index.Value)
                    .Take(1)
                    .ToList();
                if (tList.Count == 1)
                    return tList[0];
                else return (T)(object)null!;
            }
        }


        #endregion

        #region IndexOf
        public int? ListIndex<T>(IEnumerable<T>? list, T element)
        {
            if (list == null || element == null)
                return null;
            int i = 0;
            foreach (T t in list)
            {
                if (IEqualityComparer.Equals(t!, element))
                    return i;
                i++;
            }
            return -1;
        }
        #endregion

        #region Intersect
        public IEnumerable<T>? ListIntersect<T>(IEnumerable<T>? left, IEnumerable<T>? right)
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

        public T? LastOfList<T>(IEnumerable<T> enumerable)
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

        public int? ListLength<T>(IEnumerable<T> list)
        {
            if (list == null) return null;
            if (list is IList<T> l)
                return l.Count;
            return list.Count();
        }

        #endregion

        #region Not Equal

        public bool? ListNotEqual<T>(IEnumerable<T>? left, IEnumerable<T>? right) => !ListEqual(left, right);

        #endregion

        #region Not Equivalent

        public bool? ListNotEquivalent<T>(IEnumerable<T>? left, IEnumerable<T>? right) => !ListEquivalent(left, right);

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

        public T? SingleOrNull<T>(IEnumerable<T>? source)
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
            if ((startIndex == null && endIndex == null) || !source.Any())
            {
                return Enumerable.Empty<T>();
            }
            var si = startIndex ?? 0;
            if (source is List<T> list)
            {
                var lcm1 = list.Count - 1;
                var ei = Math.Min(endIndex ?? lcm1, lcm1);
                var count = ei - si + 1;
                var slice = list.GetRange(si, count);
                return slice;
            }
            else
            {
                var skip = source.Skip(si);
                var result = new List<T>();
                foreach (var item in skip.Take(endIndex ?? int.MaxValue))
                    result.Add(item);
                return result;
            }
        }

        public IEnumerable<T>? ListSkip<T>(IEnumerable<T> argument, int? number)
        {
            if (argument == null || number == null) return null;
            else return argument
                    .Skip(number.Value)
                    .ToList();
        }

        public IEnumerable<T>? ListTail<T>(IEnumerable<T> argument)
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
            if (argument == null || number == null) return null;
            else return argument
                    .Take(number.Value)
                    .ToList();
        }

        #endregion

        #region Union

        public IEnumerable<T>? ListUnion<T>(IEnumerable<T>? left, IEnumerable<T>? right)
        {
            if (left == null)
                return right;
            else if (right == null)
                return left;
            else
            {
                var union = left
                    .Cast<object>()
                    .Union(right.Cast<object>(), IEqualityComparer)
                    .Cast<T>()
                    .ToList();
                return union;
            }
        }

        public IEnumerable<CqlCode>? ValueSetUnion(IEnumerable<CqlCode>? left, IEnumerable<CqlCode>? right)
        {
            if (left == null || right == null)
                return null;
            else if (left is ValueSetFacade leftFacade)
            {
                if (right is ValueSetFacade rightFacade)
                {
                    var union = new ValueSetUnion(new[] { leftFacade, rightFacade }, ValueSets, this);
                    return union;
                }
                else if (right is ValueSetUnion rightUnion)
                {
                    var all = rightUnion.Facades
                        .Concat(new[] { leftFacade })
                        .ToArray();
                    var union = new ValueSetUnion(all, ValueSets, this);
                    return union;
                }
            }
            else if (left is ValueSetUnion leftUnion)
            {
                if (right is ValueSetFacade rightFacade)
                {
                    var all = leftUnion.Facades
                        .Concat(new[] { rightFacade })
                        .ToArray();
                    var union = new ValueSetUnion(all, ValueSets, this);
                    return union;
                }
                else if (right is ValueSetUnion rightUnion)
                {
                    var all = leftUnion.Facades
                        .Concat(rightUnion.Facades)
                        .ToArray();
                    var union = new ValueSetUnion(all, ValueSets, this);
                    return union;
                }
            }
            return ListUnion(left, right);
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
                    .OrderBy(t => t, IComparer)
                    .Cast<T>()
                    .ToList();
                return nullRecords.Concat(ordered);
            }
            else if (order == ListSortDirection.Descending)
            {
                var ordered = nonNullRecords
                    .Cast<object>()
                    .OrderBy(t => t, IComparer)
                    .Reverse()
                    .Cast<T>()
                    .ToList();
                return ordered.Concat(nullRecords);
            }
            else throw new NotSupportedException($"Unknown sort order {order}");
        }

        public IEnumerable<T>? ListSortBy<T>(IEnumerable<T>? source, Func<T, object> sortByExpr, ListSortDirection order)
        {
            if (source == null)
                return null;
            if (order == ListSortDirection.Ascending)
            {
                var nullRecords = source.Where(s => sortByExpr(s) == null);
                var nonNullRecords = source.Where(s => sortByExpr(s) != null);
                var ordered = nonNullRecords.OrderBy(source => sortByExpr(source), IComparer);
                var result = nullRecords.Concat(ordered);
                return result;
            }
            else if (order == ListSortDirection.Descending)
            {
                var nullRecords = source.Where(s => sortByExpr(s) == null);
                var nonNullRecords = source.Where(s => sortByExpr(s) != null);
                var ordered = nonNullRecords.OrderByDescending(source => sortByExpr(source), IComparer);
                var result = ordered.Concat(nullRecords);
                return result;
            }
            else throw new NotSupportedException($"Unknown sort order {order}");
        }

        #endregion

    }
}
