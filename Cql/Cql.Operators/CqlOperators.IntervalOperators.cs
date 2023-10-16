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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Hl7.Cql.Runtime
{
    internal partial class CqlOperators
    {
        #region Interval

        public CqlInterval<int?>? Interval(int? low, int? high, bool? lowClosed, bool? highClosed)
        {
            if (low is null && high is null)
                return null;
            else
            {
                var interval = new CqlInterval<int?>(low, high, lowClosed, highClosed);
                var closed = ToClosed(interval);
                return closed;
            }
        }
        public CqlInterval<decimal?>? Interval(decimal? low, decimal? high, bool? lowClosed, bool? highClosed)
        {
            if (low is null && high is null)
                return null;
            else
            {
                var interval = new CqlInterval<decimal?>(low, high, lowClosed, highClosed);
                var closed = ToClosed(interval);
                return closed;
            }
        }
        public CqlInterval<long?>? Interval(long? low, long? high, bool? lowClosed, bool? highClosed)
        {
            if (low is null && high is null)
                return null;
            else
            {
                var interval = new CqlInterval<long?>(low, high, lowClosed, highClosed);
                var closed = ToClosed(interval);
                return closed;
            }
        }
        public CqlInterval<CqlQuantity?>? Interval(CqlQuantity? low, CqlQuantity? high, bool? lowClosed, bool? highClosed)
        {
            if (low is null && high is null)
                return null;
            else
            {
                var interval = new CqlInterval<CqlQuantity?>(low, high, lowClosed, highClosed);
                var closed = ToClosed(interval);
                return closed;
            }
        }
        public CqlInterval<CqlDate?>? Interval(CqlDate? low, CqlDate? high, bool? lowClosed, bool? highClosed)
        {
            if (low is null && high is null)
                return null;
            else
            {
                var interval = new CqlInterval<CqlDate?>(low, high, lowClosed, highClosed);
                var closed = ToClosed(interval);
                return closed;
            }
        }

        public CqlInterval<CqlDateTime?>? Interval(CqlDateTime? low, CqlDateTime? high, bool? lowClosed, bool? highClosed)
        {
            if (low is null && high is null)
                return null;
            else
            {
                var interval = new CqlInterval<CqlDateTime?>(low, high, lowClosed, highClosed);
                var closed = ToClosed(interval);
                return closed;
            }
        }
        public CqlInterval<CqlTime?>? Interval(CqlTime? low, CqlTime? high, bool? lowClosed, bool? highClosed)
        {
            if (low is null && high is null)
                return null;
            else
            {
                var interval = new CqlInterval<CqlTime?>(low, high, lowClosed, highClosed);
                var closed = ToClosed(interval);
                return closed;
            }
        }
        #endregion

        #region After

        public bool? IntervalAfterInterval(CqlInterval<int?>? left, CqlInterval<int?>? right, string? precision) =>
            IntervalAfterIntervalHelper(left, right, precision, ToClosed);
        public bool? IntervalAfterInterval(CqlInterval<long?>? left, CqlInterval<long?>? right, string? precision) =>
            IntervalAfterIntervalHelper(left, right, precision, ToClosed);
        public bool? IntervalAfterInterval(CqlInterval<decimal?>? left, CqlInterval<decimal?>? right, string? precision) =>
            IntervalAfterIntervalHelper(left, right, precision, ToClosed);
        public bool? IntervalAfterInterval(CqlInterval<CqlQuantity?>? left, CqlInterval<CqlQuantity?>? right, string? precision) =>
            IntervalAfterIntervalHelper(left, right, precision, ToClosed);

        public bool? IntervalAfterInterval(CqlInterval<CqlDate?>? left, CqlInterval<CqlDate?>? right, string? precision) =>
            IntervalAfterIntervalHelper(left, right, precision, ToClosed);
        public bool? IntervalAfterInterval(CqlInterval<CqlDateTime?>? left, CqlInterval<CqlDateTime?>? right, string? precision) =>
            IntervalAfterIntervalHelper(left, right, precision, ToClosed);
        public bool? IntervalAfterInterval(CqlInterval<CqlTime?>? left, CqlInterval<CqlTime?>? right, string? precision) =>
            IntervalAfterIntervalHelper(left, right, precision, ToClosed);

        private bool? IntervalAfterIntervalHelper<T>(CqlInterval<T?>? left, CqlInterval<T?>? right, string? precision,
            Func<CqlInterval<T?>?, CqlInterval<T?>?> toClosed)
        {
            if (left == null || right == null)
                return null;

            var leftClosed = toClosed(left);
            var rightClosed = toClosed(right);

            var after = Compare(leftClosed!.low!, rightClosed!.high!, precision);
            return after > 0;
        }

        public bool? IntervalAfterElement(CqlInterval<int?>? left, int? right, string? precision) =>
            IntervalAfterElementHelper(left, right, precision, ToClosed);
        public bool? IntervalAfterElement(CqlInterval<long?>? left, long? right, string? precision) =>
            IntervalAfterElementHelper(left, right, precision, ToClosed);
        public bool? IntervalAfterElement(CqlInterval<decimal?>? left, decimal? right, string? precision) =>
            IntervalAfterElementHelper(left, right, precision, ToClosed);
        public bool? IntervalAfterElement(CqlInterval<CqlQuantity?>? left, CqlQuantity? right, string? precision) =>
            IntervalAfterElementHelper(left, right, precision, ToClosed);
        public bool? IntervalAfterElement(CqlInterval<CqlDate?>? left, CqlDate? right, string? precision) =>
            IntervalAfterElementHelper(left, right, precision, ToClosed);
        public bool? IntervalAfterElement(CqlInterval<CqlDateTime?>? left, CqlDateTime? right, string? precision) =>
            IntervalAfterElementHelper(left, right, precision, ToClosed);
        public bool? IntervalAfterElement(CqlInterval<CqlTime?>? left, CqlTime? right, string? precision) =>
            IntervalAfterElementHelper(left, right, precision, ToClosed);
        public bool? IntervalAfterElementHelper<T>(CqlInterval<T>? left, T right, string? precision,
            Func<CqlInterval<T?>?, CqlInterval<T?>?> toClosed)
        {
            if (left == null || right == null)
                return null;

            var low = left.low;
            var high = left.high;

            if (low == null)
            {
                if (left.lowClosed ?? false)
                    low = Minimum<T>();
                else
                    return null;
            }

            var interval = new CqlInterval<T>(low, high, left.lowClosed, left.highClosed);
            var closed = toClosed(interval!);

            var after = Compare(closed!.low!, right, precision);
            return after > 0;
        }

        public bool? ElementAfterInterval(int? left, CqlInterval<int?>? right, string? precision) =>
            ElementAfterIntervalHelper(left, right, precision, ToClosed);
        public bool? ElementAfterInterval(long? left, CqlInterval<long?>? right, string? precision) =>
            ElementAfterIntervalHelper(left, right, precision, ToClosed);
        public bool? ElementAfterInterval(decimal? left, CqlInterval<decimal?>? right, string? precision) =>
            ElementAfterIntervalHelper(left, right, precision, ToClosed);
        public bool? ElementAfterInterval(CqlQuantity? left, CqlInterval<CqlQuantity?>? right, string? precision) =>
            ElementAfterIntervalHelper(left, right, precision, ToClosed);
        public bool? ElementAfterInterval(CqlDate? left, CqlInterval<CqlDate?>? right, string? precision) =>
            ElementAfterIntervalHelper(left, right, precision, ToClosed);
        public bool? ElementAfterInterval(CqlDateTime? left, CqlInterval<CqlDateTime?>? right, string? precision) =>
            ElementAfterIntervalHelper(left, right, precision, ToClosed);
        public bool? ElementAfterInterval(CqlTime? left, CqlInterval<CqlTime?>? right, string? precision) =>
            ElementAfterIntervalHelper(left, right, precision, ToClosed);
        public bool? ElementAfterIntervalHelper<T>(T left, CqlInterval<T>? right, string? precision,
            Func<CqlInterval<T?>?, CqlInterval<T?>?> toClosed)
        {
            if (left == null || right == null)
                return null;

            var low = right.low;
            var high = right.high;

            if (high == null)
            {
                if (right.highClosed ?? false)
                    high = Maximum<T>();
                else
                    return null;
            }

            var interval = new CqlInterval<T>(low, high, right.lowClosed, right.highClosed);
            var closed = toClosed(interval!);

            var after = Compare(left, closed!.high!, precision);
            return after > 0;
        }

        #endregion

        #region Before

        public bool? IntervalBeforeInterval(CqlInterval<int?>? left, CqlInterval<int?>? right, string? precision) =>
            IntervalBeforeIntervalHelper(left, right, precision, ToClosed);
        public bool? IntervalBeforeInterval(CqlInterval<long?>? left, CqlInterval<long?>? right, string? precision) =>
            IntervalBeforeIntervalHelper(left, right, precision, ToClosed);
        public bool? IntervalBeforeInterval(CqlInterval<decimal?>? left, CqlInterval<decimal?>? right, string? precision) =>
            IntervalBeforeIntervalHelper(left, right, precision, ToClosed);
        public bool? IntervalBeforeInterval(CqlInterval<CqlQuantity?>? left, CqlInterval<CqlQuantity?>? right, string? precision) =>
            IntervalBeforeIntervalHelper(left, right, precision, ToClosed);
        public bool? IntervalBeforeInterval(CqlInterval<CqlDate?>? left, CqlInterval<CqlDate?>? right, string? precision) =>
            IntervalBeforeIntervalHelper(left, right, precision, ToClosed);
        public bool? IntervalBeforeInterval(CqlInterval<CqlDateTime?>? left, CqlInterval<CqlDateTime?>? right, string? precision) =>
            IntervalBeforeIntervalHelper(left, right, precision, ToClosed);
        public bool? IntervalBeforeInterval(CqlInterval<CqlTime?>? left, CqlInterval<CqlTime?>? right, string? precision) =>
            IntervalBeforeIntervalHelper(left, right, precision, ToClosed);

        private bool? IntervalBeforeIntervalHelper<T>(CqlInterval<T?>? left, CqlInterval<T?>? right, string? precision,
            Func<CqlInterval<T?>?, CqlInterval<T?>?> toClosed)
        {
            if (left == null || right == null)
                return null;

            var leftClosed = toClosed(left);
            var rightClosed = toClosed(right);

            var before = Compare(leftClosed!.high!, rightClosed!.low!, precision);

            return before < 0;
        }

        public bool? IntervalBeforeElement(CqlInterval<int?>? left, int? right, string? precision) =>
            IntervalBeforeElementHelper(left, right, precision, ToClosed);
        public bool? IntervalBeforeElement(CqlInterval<long?>? left, long? right, string? precision) =>
            IntervalBeforeElementHelper(left, right, precision, ToClosed);
        public bool? IntervalBeforeElement(CqlInterval<decimal?>? left, decimal? right, string? precision) =>
            IntervalBeforeElementHelper(left, right, precision, ToClosed);
        public bool? IntervalBeforeElement(CqlInterval<CqlQuantity?>? left, CqlQuantity? right, string? precision) =>
            IntervalBeforeElementHelper(left, right, precision, ToClosed);
        public bool? IntervalBeforeElement(CqlInterval<CqlDate?>? left, CqlDate? right, string? precision) =>
            IntervalBeforeElementHelper(left, right, precision, ToClosed);
        public bool? IntervalBeforeElement(CqlInterval<CqlDateTime?>? left, CqlDateTime? right, string? precision) =>
            IntervalBeforeElementHelper(left, right, precision, ToClosed);
        public bool? IntervalBeforeElement(CqlInterval<CqlTime?>? left, CqlTime? right, string? precision) =>
            IntervalBeforeElementHelper(left, right, precision, ToClosed);

        public bool? IntervalBeforeElementHelper<T>(CqlInterval<T>? left, T right, string? precision,
            Func<CqlInterval<T?>?, CqlInterval<T?>?> toClosed)
        {
            if (left == null || right == null)
                return null;

            var low = left.low;
            var high = left.high;

            if (high == null)
            {
                if (left.highClosed ?? false)
                    high = Maximum<T>();
                else
                    return null;
            }

            var interval = new CqlInterval<T>(low, high, left.lowClosed, left.highClosed);
            var closed = toClosed(interval!);

            var before = Compare(closed!.high!, right, precision);
            return before < 0;
        }

        public bool? ElementBeforeInterval(int? left, CqlInterval<int?>? right, string? precision) =>
            ElementBeforeIntervalHelper(left, right, precision, ToClosed);
        public bool? ElementBeforeInterval(long? left, CqlInterval<long?>? right, string? precision) =>
            ElementBeforeIntervalHelper(left, right, precision, ToClosed);
        public bool? ElementBeforeInterval(decimal? left, CqlInterval<decimal?>? right, string? precision) =>
            ElementBeforeIntervalHelper(left, right, precision, ToClosed);
        public bool? ElementBeforeInterval(CqlQuantity? left, CqlInterval<CqlQuantity?>? right, string? precision) =>
            ElementBeforeIntervalHelper(left, right, precision, ToClosed);
        public bool? ElementBeforeInterval(CqlDate? left, CqlInterval<CqlDate?>? right, string? precision) =>
            ElementBeforeIntervalHelper(left, right, precision, ToClosed);
        public bool? ElementBeforeInterval(CqlDateTime? left, CqlInterval<CqlDateTime?>? right, string? precision) =>
            ElementBeforeIntervalHelper(left, right, precision, ToClosed);
        public bool? ElementBeforeInterval(CqlTime? left, CqlInterval<CqlTime?>? right, string? precision) =>
            ElementBeforeIntervalHelper(left, right, precision, ToClosed);
        public bool? ElementBeforeIntervalHelper<T>(T left, CqlInterval<T>? right, string? precision,
            Func<CqlInterval<T?>?, CqlInterval<T?>?> toClosed)
        {
            if (left == null || right == null)
                return null;

            var low = right.low;
            var high = right.high;

            if (low == null)
            {
                if (right.lowClosed ?? false)
                    low = Minimum<T>();
                else
                    return null;
            }

            var interval = new CqlInterval<T>(low, high, right.lowClosed, right.highClosed);
            var closed = toClosed(interval!);

            var before = Compare(left, closed!.low!, precision);
            return before < 0;
        }

        #endregion

        #region Collapse

        public IEnumerable<CqlInterval<int?>?>? Collapse(IEnumerable<CqlInterval<int?>?>? intervals, string? precision) =>
            CollapseHelper(intervals, precision, Meets, ToClosed);

        public IEnumerable<CqlInterval<long?>?>? Collapse(IEnumerable<CqlInterval<long?>?>? intervals, string? precision) =>
            CollapseHelper(intervals, precision, Meets, ToClosed);
        public IEnumerable<CqlInterval<decimal?>?>? Collapse(IEnumerable<CqlInterval<decimal?>?>? intervals, string? precision) =>
            CollapseHelper(intervals, precision, Meets, ToClosed);

        public IEnumerable<CqlInterval<CqlQuantity?>?>? Collapse(IEnumerable<CqlInterval<CqlQuantity?>?>? intervals, string? precision) =>
            CollapseHelper(intervals, precision, Meets, ToClosed);

        public IEnumerable<CqlInterval<CqlDate?>?>? Collapse(IEnumerable<CqlInterval<CqlDate?>?>? intervals, string? precision) =>
            CollapseHelper(intervals, precision, Meets, ToClosed);
        public IEnumerable<CqlInterval<CqlDateTime?>?>? Collapse(IEnumerable<CqlInterval<CqlDateTime?>?>? intervals, string? precision) =>
            CollapseHelper(intervals, precision, Meets, ToClosed);
        public IEnumerable<CqlInterval<CqlTime?>?>? Collapse(IEnumerable<CqlInterval<CqlTime?>?>? intervals, string? precision) =>
            CollapseHelper(intervals, precision, Meets, ToClosed);

        private IEnumerable<CqlInterval<T?>?>? CollapseHelper<T>(IEnumerable<CqlInterval<T?>?>? intervals, string? precision,
            Func<CqlInterval<T?>?, CqlInterval<T?>?, string?, bool?> meets, Func<CqlInterval<T?>?, CqlInterval<T?>?> toClosed)
        {
            if (intervals == null) return null;
            var count = 0;
            if (intervals is IList<T> list)
                count = list.Count;
            else if (intervals is T[] array)
                count = array.Length;
            else count = intervals.Count();
            if (count == 0)
                return new CqlInterval<T?>[0];

            // need null check on i because i!.low! causes HL7 unit test TestCollapseNull_Test to fail since i is null
            var queue = ListSortBy(intervals, i => i == null ? null! : i.low!, ListSortDirection.Ascending)?.ToList();
            if (queue is null || queue.Count == 0) return null;

            CqlInterval<T?>? TryCombine(CqlInterval<T?>? x, CqlInterval<T?>? y)
            {
                if (x == null || y == null) return null;

                // From spec language:
                // In other words, adjacent intervals within a sorted list are merged if they either overlap or meet.
                if ((meets(x, y, precision) ?? false) || (OverlapsHelper(x, y, precision, toClosed) ?? false))
                {
                    if  (IntervalIncludesInterval(x, y, precision!) ?? false)
                    {
                        return x;
                    }
                    else
                    {
                        return new CqlInterval<T?>(x.low, y.high, x.lowClosed, y.highClosed);
                    }
                }
                else return null;
            };

            var result = new List<CqlInterval<T?>?>();
            while (queue.Count > 0)
            {
                var firstInQueue = queue[0];
                queue.RemoveAt(0);
                if (result.Count > 0)
                {
                    var lastResult = result[result.Count -1];
                    var combined = TryCombine(lastResult, firstInQueue);
                    if (combined == null)
                    {
                        result.Add(firstInQueue);
                    }
                    else
                    {
                        result[result.Count - 1] = combined;
                    }
                }
                else
                {
                    result.Add(firstInQueue);
                }
            }
            return result;

        }

        #endregion

        #region Contains

        public bool? IntervalContains(CqlInterval<int?>? left, int? right, string? precision) =>
            IntervalContainsHelper(left, right, precision, ToClosed);
        public bool? IntervalContains(CqlInterval<long?>? left, long? right, string? precision) =>
            IntervalContainsHelper(left, right, precision, ToClosed);
        public bool? IntervalContains(CqlInterval<decimal?>? left, decimal? right, string? precision) =>
            IntervalContainsHelper(left, right, precision, ToClosed);
        public bool? IntervalContains(CqlInterval<CqlQuantity?>? left, CqlQuantity? right, string? precision) =>
            IntervalContainsHelper(left, right, precision, ToClosed);

        public bool? IntervalContains(CqlInterval<CqlDate?>? left, CqlDate? right, string? precision) =>
            IntervalContainsHelper(left, right, precision, ToClosed);
        public bool? IntervalContains(CqlInterval<CqlDateTime?>? left, CqlDateTime? right, string? precision) =>
            IntervalContainsHelper(left, right, precision, ToClosed);
        public bool? IntervalContains(CqlInterval<CqlTime?>? left, CqlTime? right, string? precision) =>
            IntervalContainsHelper(left, right, precision, ToClosed);

        public bool? IntervalContainsHelper<T>(CqlInterval<T?>? argument, T point, string? precision,
            Func<CqlInterval<T?>?, CqlInterval<T?>?> toClosed)
        {
            if (argument == null) return false;
            else if (point == null) return null;

            var low = argument.low;
            var high = argument.high;

            // handles scenarios of Interval[3,null) contains 5 or Interval(null, 3] constains 5
            // If a boundary point is null and the boundary is exclusive, the boundary is considered
            // unknown and operations involving that point will return null
            if (low == null)
            {
                if (argument.lowClosed ?? false)
                    low = Minimum<T>();
                else
                    return null;
            }
            if (high == null)
            {
                if (argument.highClosed ?? false)
                    high = Maximum<T>();
                else
                    return null;
            }

            var interval = new CqlInterval<T>(low, high, argument.lowClosed, argument.highClosed);
            var closed = toClosed(interval!);

            var lowCompare = Compare(point, closed!.low!, precision);
            var highCompare = Compare(point, closed!.high!, precision);
            if (lowCompare == 0 || highCompare == 0)
                return true;
            else if (lowCompare > 0 && highCompare < 0)
                return true;
            else return false;
        }

        #endregion

        #region End

        // End is implemented in terms of the predecessor operator, and therefore is only defined for interval types
        // that implement the predecessor operator.

        public int? End(CqlInterval<int?>? argument)
        {
            if (argument == null)
                return null!;

            if (argument.low == null && argument.high == null)
                return null;

            var highClosed = argument.highClosed ?? false;
            if (argument.high == null && !highClosed)
                return null;

            if (highClosed)
                return argument.high ?? Maximum<int?>();
            else return Predecessor(argument.high);
        }

        public long? End(CqlInterval<long?>? argument)
        {
            if (argument == null)
                return null!;

            if (argument.low == null && argument.high == null)
                return null;

            var highClosed = argument.highClosed ?? false;
            if (argument.high == null && !highClosed)
                return null;

            if (highClosed)
                return argument.high ?? Maximum<long?>();
            else return Predecessor(argument.high);
        }
        public decimal? End(CqlInterval<decimal?>? argument)
        {
            if (argument == null)
                return null!;

            if (argument.low == null && argument.high == null)
                return null;

            var highClosed = argument.highClosed ?? false;
            if (argument.high == null && !highClosed)
                return null;

            if (highClosed)
                return argument.high ?? Maximum<decimal?>();
            else return Predecessor(argument.high);
        }
        public CqlQuantity? End(CqlInterval<CqlQuantity?>? argument)
        {
            if (argument == null)
                return null!;

            if (argument.low == null && argument.high == null)
                return null;

            var highClosed = argument.highClosed ?? false;
            if (argument.high == null && !highClosed)
                return null;

            if (highClosed)
                return argument.high ?? Maximum<CqlQuantity?>();
            else return Predecessor(argument.high);
        }

        public CqlDate? End(CqlInterval<CqlDate?>? argument)
        {
            if (argument == null)
                return null!;

            if (argument.low == null && argument.high == null)
                return null;

            var highClosed = argument.highClosed ?? false;
            if (argument.high == null && !highClosed)
                return null;

            if (highClosed)
                return argument.high ?? Maximum<CqlDate?>();
            else return Predecessor(argument.high);
        }
        public CqlDateTime? End(CqlInterval<CqlDateTime?>? argument)
        {
            if (argument == null)
                return null!;

            if (argument.low == null && argument.high == null)
                return null;

            var highClosed = argument.highClosed ?? false;
            if (argument.high == null && !highClosed)
                return null;

            if (highClosed)
                return argument.high ?? Maximum<CqlDateTime?>();
            else return Predecessor(argument.high);
        }
        public CqlTime? End(CqlInterval<CqlTime?>? argument)
        {
            if (argument == null)
                return null!;

            if (argument.low == null && argument.high == null)
                return null;

            var highClosed = argument.highClosed ?? false;
            if (argument.high == null && !highClosed)
                return null;

            if (highClosed)
                return argument.high ?? Maximum<CqlTime?>();
            else return Predecessor(argument.high);
        }

        #endregion

        #region Ends

        public bool? Ends<T>(CqlInterval<T> left, CqlInterval<T> right, string? precision)
        {
            if (left == null) return null;
            else if (right == null) return null;

            if (Compare(left!.low!, right!.low!, precision) >= 0 && Compare(left.high!, right.high!, precision) == 0)
                return true;
            else
                return false;
        }
        #endregion

        #region Except
        public CqlInterval<int?>? IntervalExcept(CqlInterval<int?>? left, CqlInterval<int?>? right) =>
            IntervalExceptHelper(left, right, ToClosed);
        public CqlInterval<long?>? IntervalExcept(CqlInterval<long?>? left, CqlInterval<long?>? right) =>
            IntervalExceptHelper(left, right, ToClosed);
        public CqlInterval<decimal?>? IntervalExcept(CqlInterval<decimal?>? left, CqlInterval<decimal?>? right) =>
            IntervalExceptHelper(left, right, ToClosed);
        public CqlInterval<CqlQuantity?>? IntervalExcept(CqlInterval<CqlQuantity?>? left, CqlInterval<CqlQuantity?>? right) =>
            IntervalExceptHelper(left, right, ToClosed);
        public CqlInterval<CqlDate?>? IntervalExcept(CqlInterval<CqlDate?>? left, CqlInterval<CqlDate?>? right) =>
            IntervalExceptHelper(left, right, ToClosed);
        public CqlInterval<CqlDateTime?>? IntervalExcept(CqlInterval<CqlDateTime?>? left, CqlInterval<CqlDateTime?>? right) =>
            IntervalExceptHelper(left, right, ToClosed);
        public CqlInterval<CqlTime?>? IntervalExcept(CqlInterval<CqlTime?>? left, CqlInterval<CqlTime?>? right) =>
            IntervalExceptHelper(left, right, ToClosed);
        public CqlInterval<T?>? IntervalExceptHelper<T>(CqlInterval<T?>? left, CqlInterval<T?>? right,
            Func<CqlInterval<T?>?, CqlInterval<T?>?> toClosed)
        {
            if (left == null || right == null)
                return null;
            var overlaps = OverlapsHelper(left, right, null, toClosed);

            if (overlaps == true)
            {
                var overlapsBefore = OverlapsBeforeHelper(left, right, null, toClosed);
                var overlapsAfter = OverlapsAfterHelper(left, right, null, toClosed);
                if (overlapsBefore == true && overlapsAfter == false)
                {
                    return new CqlInterval<T?>(left.low, right.low, left.lowClosed, !right.lowClosed);
                }
                if (overlapsAfter == true && overlapsBefore == false)
                {
                    return new CqlInterval<T?>(right.high, left.high, !right.highClosed, left.highClosed);
                }
                return null;
            }
            else if (overlaps == false)
            {
                return left;
            }
            return null;
        }

        #endregion

        #region Expand

        public IEnumerable<CqlDate>? ExpandInterval(CqlInterval<CqlDate>? argument, CqlQuantity? per)
        {
            if (argument == null)
                return null;

            // low is null and not closed or high is null and not closed
            // For intervals with null boundaries (intervals with an undefined start or end date), if the boundary is open (e.g., Interval[0, null)),
            // the interval will not contribute any results to the output. If the boundary is closed (e.g., Interval[0, null]), in theory the interval
            // would contribute all intervals to the beginning or ending of the domain. In practice, because such an expansion is potentially too
            // expensive to compute, and implementations are allowed to not return results for such an interval.
            if ((argument.low == null && !(argument.lowClosed ?? false)) || (argument.high == null && !(argument.highClosed ?? false)))
                return null;

            var interval = ToClosed(argument!)!;
            var expanded = new List<CqlDate>();

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
                        return expanded;
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
                expanded.Add(listItem!);
                listItem = listItem!.Add(per);
            }
            while (Compare(listItem!, highInterval!, null) <= 0);

            return expanded;
        }
        public IEnumerable<CqlDateTime>? ExpandInterval(CqlInterval<CqlDateTime>? argument, CqlQuantity? per)
        {
            if (argument == null)
                return null;

            // low is null and not closed or high is null and not closed
            // For intervals with null boundaries (intervals with an undefined start or end date), if the boundary is open (e.g., Interval[0, null)),
            // the interval will not contribute any results to the output. If the boundary is closed (e.g., Interval[0, null]), in theory the interval
            // would contribute all intervals to the beginning or ending of the domain. In practice, because such an expansion is potentially too
            // expensive to compute, and implementations are allowed to not return results for such an interval.
            if ((argument.low == null && !(argument.lowClosed ?? false)) || (argument.high == null && !(argument.highClosed ?? false)))
                return null;

            var interval = ToClosed(argument!)!;
            var expanded = new List<CqlDateTime>();

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

            var listItem = interval.low;
            var highInterval = interval.high;

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
                expanded.Add(listItem!);
                listItem = listItem!.Add(per);
            }
            while (Compare(listItem!, highInterval!, null) <= 0);

            return expanded;
        }
        public IEnumerable<CqlTime>? ExpandInterval(CqlInterval<CqlTime>? argument, CqlQuantity? per)
        {
            if (argument == null)
                return null;

            // low is null and not closed or high is null and not closed
            // For intervals with null boundaries (intervals with an undefined start or end date), if the boundary is open (e.g., Interval[0, null)),
            // the interval will not contribute any results to the output. If the boundary is closed (e.g., Interval[0, null]), in theory the interval
            // would contribute all intervals to the beginning or ending of the domain. In practice, because such an expansion is potentially too
            // expensive to compute, and implementations are allowed to not return results for such an interval.
            if ((argument.low == null && !(argument.lowClosed ?? false)) || (argument.high == null && !(argument.highClosed ?? false)))
                return null;

            var interval = ToClosed(argument!)!;
            var expanded = new List<CqlTime>();

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
                        if (interval.low!.Precision > Iso8601.DateTimePrecision.Second
                            && interval.high!.Precision > Iso8601.DateTimePrecision.Second)
                            return expanded;

                        if (interval.low.Precision > Iso8601.DateTimePrecision.Second)
                            setLowPrecisionToPer = true;
                        else if (interval.high!.Precision > Iso8601.DateTimePrecision.Second)
                            setHighPrecisionToPer = true;

                        break;
                    // parsed as a date unit when it's a time so return empty list
                    // ex: Interval[@T10, @T10] per month
                    case "a":
                    case "mo":
                    case "d":
                    case "wk":
                        return expanded;
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
                expanded.Add(listItem!);
                listItem = listItem!.Add(per);
            }
            while (Compare(listItem!, highInterval!, null) <= 0);

            return expanded;
        }
        public IEnumerable<decimal?>? ExpandInterval(CqlInterval<decimal?>? argument, CqlQuantity? per)
        {
            if (argument == null)
                return null;

            // low is null and not closed or high is null and not closed
            // For intervals with null boundaries (intervals with an undefined start or end date), if the boundary is open (e.g., Interval[0, null)),
            // the interval will not contribute any results to the output. If the boundary is closed (e.g., Interval[0, null]), in theory the interval
            // would contribute all intervals to the beginning or ending of the domain. In practice, because such an expansion is potentially too
            // expensive to compute, and implementations are allowed to not return results for such an interval.
            if ((argument.low == null && !(argument.lowClosed ?? false)) || (argument.high == null && !(argument.highClosed ?? false)))
                return null;

            var interval = ToClosed(argument!)!;
            var expanded = new List<decimal?>();

            // If the per argument is null, a per value will be constructed based on the coarsest precision of the boundaries of the intervals in the input set.
            if (per == null)
                per = new CqlQuantity(1, "1");
            else
            {
                Units.UCUMUnitsToCql.TryGetValue(per.unit ?? "", out var ucumUnits);
                if (ucumUnits != null)
                    return expanded;
            }

            var listItem = interval.low!.Value;
            do
            {
                expanded.Add(listItem);
                listItem = decimal.Add(listItem, per.value ?? 1);
            }
            while (Compare(listItem, interval.high!, null) <= 0);

            return expanded;
        }
        public IEnumerable<int?>? ExpandInterval(CqlInterval<int?>? argument, CqlQuantity? per)
        {
            if (argument == null)
                return null;

            // low is null and not closed or high is null and not closed
            // For intervals with null boundaries (intervals with an undefined start or end date), if the boundary is open (e.g., Interval[0, null)),
            // the interval will not contribute any results to the output. If the boundary is closed (e.g., Interval[0, null]), in theory the interval
            // would contribute all intervals to the beginning or ending of the domain. In practice, because such an expansion is potentially too
            // expensive to compute, and implementations are allowed to not return results for such an interval.
            if ((argument.low == null && !(argument.lowClosed ?? false)) || (argument.high == null && !(argument.highClosed ?? false)))
                return null;

            var interval = ToClosed(argument!)!;
            var expanded = new List<int?>();

            // If the per argument is null, a per value will be constructed based on the coarsest precision of the boundaries of the intervals in the input set.
            if (per == null)
                per = new CqlQuantity(1, "1");
            else
            {
                Units.UCUMUnitsToCql.TryGetValue(per.unit ?? "", out var ucumUnits);
                if (ucumUnits != null)
                    return expanded;
            }

            var listItem = interval.low!.Value;
            do
            {
                expanded.Add(listItem);
                var intQuantity = decimal.ToInt32(per.value ?? 1);
                listItem += intQuantity;

            }
            while (Compare(listItem, interval.high!, null) <= 0);

            return expanded;
        }
        public IEnumerable<long?>? ExpandInterval(CqlInterval<long?>? argument, CqlQuantity? per)
        {
            if (argument == null)
                return null;

            // low is null and not closed or high is null and not closed
            // For intervals with null boundaries (intervals with an undefined start or end date), if the boundary is open (e.g., Interval[0, null)),
            // the interval will not contribute any results to the output. If the boundary is closed (e.g., Interval[0, null]), in theory the interval
            // would contribute all intervals to the beginning or ending of the domain. In practice, because such an expansion is potentially too
            // expensive to compute, and implementations are allowed to not return results for such an interval.
            if ((argument.low == null && !(argument.lowClosed ?? false)) || (argument.high == null && !(argument.highClosed ?? false)))
                return null;

            var interval = ToClosed(argument!)!;
            var expanded = new List<long?>();

            // If the per argument is null, a per value will be constructed based on the coarsest precision of the boundaries of the intervals in the input set.
            if (per == null)
                per = new CqlQuantity(1, "1");
            else
            {
                Units.UCUMUnitsToCql.TryGetValue(per.unit ?? "", out var ucumUnits);
                if (ucumUnits != null)
                    return expanded;
            }

            var listItem = interval.low!.Value;
            do
            {
                expanded.Add(listItem);
                var intQuantity = decimal.ToInt64(per.value ?? 1);
                listItem += intQuantity;
            }
            while (Compare(listItem, interval.high!, null) <= 0);

            return expanded;
        }

        #endregion

        #region In
        public bool? ElementInInterval<T>(T t, CqlInterval<T>? interval, string? precision)
        {
            if (t == null) return null;
            if (interval == null) return false;

            if (interval.low == null && (interval.lowClosed ?? false) == false)
                return null;
            else if (interval.high == null && (interval.highClosed ?? false) == false)
                return null;

            // https://cql.hl7.org/09-b-cqlreference.html#in
            // For closed interval boundaries, if the interval boundary is null, the result of the boundary comparison is considered true.
            var lowClosed = interval.lowClosed ?? false;
            var highClosed = interval.highClosed ?? false;
            var lowCompare = Compare(t, interval.low ?? Minimum<T>()!, precision) ?? (lowClosed ? 0 : null);
            var highCompare = Compare(t, interval.high ?? Maximum<T>()!, precision) ?? (highClosed ? 0 : null);

            var low = lowClosed ? lowCompare >= 0 : lowCompare > 0;
            var high = highClosed ? highCompare <= 0 : highCompare < 0;

            return low && high;
        }
        #endregion

        #region Includes
        public bool? IntervalIncludesElement<T>(CqlInterval<T>? interval, T t, string? precision) =>
            ElementInInterval(t, interval, precision);

        public bool? IntervalIncludesInterval<T>(CqlInterval<T>? larger, CqlInterval<T>? smaller, string precision)
        {
            if (larger == null || smaller == null)
                return null;

            var lowCompare = Compare(larger.low ?? Minimum<T>()!, smaller.low ?? Minimum<T>()!, precision);
            var highCompare = Compare(larger.high ?? Maximum<T>()!, smaller.high ?? Maximum<T>()!, precision);
            //var smallerSelfCompare = rtx.Compare(smaller.Low ?? Minimum<T>(), smaller.High ?? Maximum<T>(), precision);

            // From docs: If smaller is point interval, and exactly on the boundary of either side of larger, null
            //if (smallerSelfCompare == 0 && (lowCompare == 0 || highCompare == 0)) return null;

            if (lowCompare <= 0 && highCompare >= 0)
                return true;
            else
                return false;
        }

        #endregion

        #region Included In

        public bool? IntervalIncludedIn<T>(CqlInterval<T>? smaller, CqlInterval<T>? larger, string precision) =>
            IntervalIncludesInterval(larger, smaller, precision);

        #endregion

        #region Intersect

        public CqlInterval<T>? IntervalIntersectsInterval<T>(CqlInterval<T>? left, CqlInterval<T>? right)
        {
            if (left == null || right == null) return null;

            var leftLow = left.low ?? Minimum<T>();
            var leftHigh = left.high ?? Maximum<T>();
            var rightLow = right.low ?? Minimum<T>();
            var rightHigh = right.high ?? Maximum<T>();
            if (Compare(leftLow!, rightHigh!, null) > 0 || Compare(rightLow!, leftHigh!, null) > 0) return null;
            else
            {
                T LowValue;
                bool LowValueClosed;
                T HighValue;
                bool HighValueClosed;

                var leftCompare = Compare(leftLow!, rightLow!, null);
                if (leftCompare > 0)
                {
                    LowValue = left.low;
                    LowValueClosed = left.lowClosed ?? false;
                }
                else if (leftCompare == 0)
                {
                    LowValue = left.low;
                    LowValueClosed = (left.lowClosed ?? false) && (right.lowClosed ?? false);
                }
                else
                {
                    LowValue = right.low;
                    LowValueClosed = right.lowClosed ?? false;
                }

                var rightCompare = Compare(leftHigh!, rightHigh!, null);
                if (rightCompare < 0)
                {
                    HighValue = left.high;
                    HighValueClosed = left.highClosed ?? false;
                }
                else if (rightCompare == 0)
                {
                    HighValue = left.high;
                    HighValueClosed = (left.highClosed ?? false) && (right.highClosed ?? false);
                }
                else
                {
                    HighValue = right.high;
                    HighValueClosed = right.highClosed ?? false;
                }

                return new CqlInterval<T>(LowValue, HighValue, LowValueClosed, HighValueClosed);
            }
        }

        #endregion

        #region Meets

        public bool? Meets(CqlInterval<int?>? left, CqlInterval<int?>? right, string? precision)
        {
            if (left == null || right == null)
                return null;
            if ((left.high == null && right.high == null) || (left.low == null && right.low == null))
                return null;

            return MeetsHelper(ToClosed(left)!, ToClosed(right)!, precision, Predecessor);
        }
        public bool? Meets(CqlInterval<long?>? left, CqlInterval<long?>? right, string? precision)
        {
            if (left == null || right == null)
                return null;
            if ((left.high == null && right.high == null) || (left.low == null && right.low == null))
                return null;

            return MeetsHelper(ToClosed(left)!, ToClosed(right)!, precision, Predecessor);
        }
        public bool? Meets(CqlInterval<decimal?>? left, CqlInterval<decimal?>? right, string? precision)
        {
            if (left == null || right == null)
                return null;
            if ((left.high == null && right.high == null) || (left.low == null && right.low == null))
                return null;

            return MeetsHelper(ToClosed(left)!, ToClosed(right)!, precision, Predecessor);
        }

        public bool? Meets(CqlInterval<CqlQuantity?>? left, CqlInterval<CqlQuantity?>? right, string? precision)
        {
            if (left == null || right == null)
                return null;
            if ((left.high == null && right.high == null) || (left.low == null && right.low == null))
                return null;

            return MeetsHelper(ToClosed(left)!, ToClosed(right)!, precision, Predecessor);
        }

        public bool? Meets(CqlInterval<CqlDate?>? left, CqlInterval<CqlDate?>? right, string? precision)
        {
            if (left == null || right == null)
                return null;
            if ((left.high == null && right.high == null) || (left.low == null && right.low == null))
                return null;

            return MeetsHelper(ToClosed(left)!, ToClosed(right)!, precision, Predecessor);
        }
        public bool? Meets(CqlInterval<CqlDateTime?>? left, CqlInterval<CqlDateTime?>? right, string? precision)
        {
            if (left == null || right == null)
                return null;
            if ((left.high == null && right.high == null) || (left.low == null && right.low == null))
                return null;

            return MeetsHelper(ToClosed(left)!, ToClosed(right)!, precision, Predecessor);
        }
        public bool? Meets(CqlInterval<CqlTime?>? left, CqlInterval<CqlTime?>? right, string? precision)
        {
            if (left == null || right == null)
                return null;
            if ((left.high == null && right.high == null) || (left.low == null && right.low == null))
                return null;

            return MeetsHelper(ToClosed(left)!, ToClosed(right)!, precision, Predecessor);
        }
        private bool? MeetsHelper<T>(CqlInterval<T> left, CqlInterval<T> right, string? precision, Func<T, T> predecessor)
        {
            if (left == null || right == null)
                return null;

            // updates to fix returning true because the left.low and right.high are null
            if (left.high != null || right.low != null)
            {
                if (Compare(left.high!, right.low!, precision) == 0
                    || Compare(left.high!, predecessor(right.low)!, precision) == 0)
                    return true;
            }
            if (left.low != null || right.high != null)
            {
                if (Compare(left.low!, right.high!, precision) == 0
                    || Compare(predecessor(left.low)!, right.high!, precision) == 0)
                    return true;
            }

            return false;
        }

        #endregion

        #region Meets after

        public bool? MeetsAfter(CqlInterval<int?>? left, CqlInterval<int?> right, string? precision)
        {
            if (left == null || right == null)
                return null;
            if (left.high == null && right.high == null)
                return null;

            return MeetsAfterHelper(ToClosed(left), ToClosed(right), precision, Predecessor);
        }

        public bool? MeetsAfter(CqlInterval<long?>? left, CqlInterval<long?> right, string? precision)
        {
            if (left == null || right == null)
                return null;
            if (left.high == null && right.high == null)
                return null;

            return MeetsAfterHelper(ToClosed(left), ToClosed(right), precision, Predecessor);
        }

        public bool? MeetsAfter(CqlInterval<decimal?>? left, CqlInterval<decimal?> right, string? precision)
        {
            if (left == null || right == null)
                return null;
            if (left.high == null && right.high == null)
                return null;

            return MeetsAfterHelper(ToClosed(left), ToClosed(right), precision, Predecessor);
        }


        public bool? MeetsAfter(CqlInterval<CqlQuantity?>? left, CqlInterval<CqlQuantity?> right, string? precision)
        {
            if (left == null || right == null)
                return null;
            if (left.high == null && right.high == null)
                return null;

            return MeetsAfterHelper(ToClosed(left), ToClosed(right), precision, Predecessor);
        }

        public bool? MeetsAfter(CqlInterval<CqlDate?>? left, CqlInterval<CqlDate?> right, string? precision)
        {
            if (left == null || right == null) return null;
            if (left.high == null && right.high == null) return null;

            return MeetsAfterHelper(ToClosed(left), ToClosed(right), precision, Predecessor);
        }

        public bool? MeetsAfter(CqlInterval<CqlDateTime?>? left, CqlInterval<CqlDateTime?> right, string? precision)
        {
            if (left == null || right == null) return null;
            if (left.high == null && right.high == null) return null;

            return MeetsAfterHelper(ToClosed(left), ToClosed(right), precision, Predecessor);
        }
        public bool? MeetsAfter(CqlInterval<CqlTime?>? left, CqlInterval<CqlTime?> right, string? precision)
        {
            if (left == null || right == null)
                return null;
            if (left.high == null && right.high == null)
                return null;

            return MeetsAfterHelper(ToClosed(left), ToClosed(right), precision, Predecessor);
        }

        private bool? MeetsAfterHelper<T>(CqlInterval<T>? left, CqlInterval<T>? right, string? precision, Func<T, T> predecessor)
        {
            if (left == null || right == null)
                return null;
            if (Compare(left.low!, right.high!, precision) == 0)
                return true;

            if ((left.lowClosed ?? false) && (right.highClosed ?? false) && Compare(predecessor(left.low)!, right.high!, precision) == 0)
                return true;

            return false;
        }

        private bool? MeetsAfterIgnoringClosed<T>(CqlInterval<T> left, CqlInterval<T> right, string? precision, Func<T, T> predecessor)
        {
            if (left == null || right == null)
                return null;
            if (Compare(left.low!, right.high!, precision) == 0)
                return true;

            if (Compare(predecessor(left.low)!, right.high!, precision) == 0)
                return true;

            return false;
        }

        #endregion

        #region Meets before

        public bool? MeetsBefore(CqlInterval<int?> left, CqlInterval<int?> right, string? precision)
        {
            if (left == null || right == null)
                return null;
            if (left.low == null && right.low == null)
                return null;

            return MeetsBeforeHelper(ToClosed(left)!, ToClosed(right)!, precision, Predecessor);
        }
        public bool? MeetsBefore(CqlInterval<long?> left, CqlInterval<long?> right, string? precision)
        {
            if (left == null || right == null)
                return null;
            if (left.low == null && right.low == null)
                return null;

            return MeetsBeforeHelper(ToClosed(left)!, ToClosed(right)!, precision, Predecessor);
        }
        public bool? MeetsBefore(CqlInterval<decimal?> left, CqlInterval<decimal?> right, string? precision)
        {
            if (left == null || right == null)
                return null;
            if (left.low == null && right.low == null)
                return null;

            return MeetsBeforeHelper(ToClosed(left)!, ToClosed(right)!, precision, Predecessor);
        }
        public bool? MeetsBefore(CqlInterval<CqlQuantity?> left, CqlInterval<CqlQuantity?> right, string? precision)
        {
            if (left == null || right == null)
                return null;
            if (left.low == null && right.low == null)
                return null;

            return MeetsBeforeHelper(ToClosed(left)!, ToClosed(right)!, precision, Predecessor);
        }
        public bool? MeetsBefore(CqlInterval<CqlDate?> left, CqlInterval<CqlDate?> right, string? precision)
        {
            if (left == null || right == null)
                return null;
            if (left.low == null && right.low == null)
                return null;

            return MeetsBeforeHelper(ToClosed(left)!, ToClosed(right)!, precision, Predecessor);
        }
        public bool? MeetsBefore(CqlInterval<CqlDateTime?> left, CqlInterval<CqlDateTime?> right, string? precision)
        {
            if (left == null || right == null)
                return null;
            if (left.low == null && right.low == null)
                return null;

            return MeetsBeforeHelper(ToClosed(left)!, ToClosed(right)!, precision, Predecessor);
        }
        public bool? MeetsBefore(CqlInterval<CqlTime?> left, CqlInterval<CqlTime?> right, string? precision)
        {
            if (left == null || right == null)
                return null;
            if (left.low == null && right.low == null)
                return null;

            return MeetsBeforeHelper(ToClosed(left)!, ToClosed(right)!, precision, Predecessor);
        }

        private bool? MeetsBeforeIgnoringClosed<T>(CqlInterval<T> left, CqlInterval<T> right, string? precision, Func<T, T> predecessor)
        {
            if (left == null || right == null)
                return null;
            if (Compare(left.high!, right.low!, precision) == 0)
                return true;

            if (Compare(left.high!, predecessor(right.low)!, precision) == 0)
                return true;

            return false;
        }
        private bool? MeetsBeforeHelper<T>(CqlInterval<T> left, CqlInterval<T> right, string? precision, Func<T, T> predecessor)
        {
            if (left == null || right == null)
                return null;
            if (Compare(left.high!, right.low!, precision) == 0)
                return true;

            if ((right.lowClosed ?? false) && (left.highClosed ?? false) && Compare(left.high!, predecessor(right.low)!, precision) == 0)
                return true;

            return false;
        }

        #endregion

        #region Same As

        public bool? IntervalSameAs<T>(CqlInterval<T> @this, CqlInterval<T> other, string? precision)
        {
            if (@this == null || other == null)
                return null;
            else
                return Compare(@this, other, precision) == 0;
        }

        #endregion

        #region On/Same Or After

        public bool? IntervalSameOrAfter(CqlInterval<int?> @this, CqlInterval<int?> other)
            => IntervalSameOrAfterHelper(@this, other, null, ToClosed);
        public bool? IntervalSameOrAfter(CqlInterval<long?> @this, CqlInterval<long?> other)
            => IntervalSameOrAfterHelper(@this, other, null, ToClosed);
        public bool? IntervalSameOrAfter(CqlInterval<decimal?> @this, CqlInterval<decimal?> other)
            => IntervalSameOrAfterHelper(@this, other, null, ToClosed);
        public bool? IntervalSameOrAfter(CqlInterval<CqlQuantity?> @this, CqlInterval<CqlQuantity?> other)
            => IntervalSameOrAfterHelper(@this, other, null, ToClosed);

        public bool? IntervalSameOrAfter(CqlInterval<CqlDate?>? @this, CqlInterval<CqlDate?>? other, string? precision)
        {
            if (@this == null || other == null)
                return null;


            if (SamePrecision(@this.low, other.low) == false || SamePrecision(@this.high, other.high) == false)
                return null;

            if (precision != null
                && (GreaterOrSamePrecision(@this.low!, precision) == false
                    || GreaterOrSamePrecision(@this.high!, precision) == false
                    || GreaterOrSamePrecision(other.low!, precision) == false
                    || GreaterOrSamePrecision(other.high!, precision) == false))
                return null;

            var thisClosed = ToClosed(@this)!;
            var otherClosed = ToClosed(other)!;

            var isSame = Compare(thisClosed, otherClosed, precision) == 0;
            if (isSame)
                return true;

            var boundaryHit = Compare(thisClosed.low!, otherClosed.high!, precision) == 0;
            if (boundaryHit)
                return true;

            return IntervalAfterInterval(thisClosed, otherClosed, precision);
        }

        public bool? IntervalSameOrAfter(CqlInterval<CqlDateTime?>? @this, CqlInterval<CqlDateTime?>? other, string? precision)
        {
            if (@this == null || other == null)
                return null;


            if (SamePrecision(@this.low, other.low) == false || SamePrecision(@this.high, other.high) == false)
                return null;

            if (precision != null
                && (GreaterOrSamePrecision(@this.low!, precision) == false
                    || GreaterOrSamePrecision(@this.high!, precision) == false
                    || GreaterOrSamePrecision(other.low!, precision) == false
                    || GreaterOrSamePrecision(other.high!, precision) == false))
                return null;

            var thisClosed = ToClosed(@this)!;
            var otherClosed = ToClosed(other)!;

            var isSame = Compare(thisClosed, otherClosed, precision) == 0;
            if (isSame)
                return true;

            var boundaryHit = Compare(thisClosed.low!, otherClosed.high!, precision) == 0;
            if (boundaryHit)
                return true;

            return IntervalAfterInterval(thisClosed, otherClosed, precision);
        }

        public bool? IntervalSameOrAfter(CqlInterval<CqlTime?>? @this, CqlInterval<CqlTime?>? other, string? precision)
        {
            if (@this == null || other == null)
                return null;



            if (SamePrecision(@this.low, other.low) == false || SamePrecision(@this.high, other.high) == false)
                return null;

            if (precision != null
                && (GreaterOrSamePrecision(@this.low!, precision) == false
                    || GreaterOrSamePrecision(@this.high!, precision) == false
                    || GreaterOrSamePrecision(other.low!, precision) == false
                    || GreaterOrSamePrecision(other.high!, precision) == false))
                return null;

            var thisClosed = ToClosed(@this)!;
            var otherClosed = ToClosed(other)!;

            var isSame = Compare(thisClosed, otherClosed, precision) == 0;
            if (isSame)
                return true;

            var boundaryHit = Compare(thisClosed.low!, otherClosed.high!, precision) == 0;
            if (boundaryHit)
                return true;

            return IntervalAfterInterval(thisClosed, otherClosed, precision);
        }

        private bool? IntervalSameOrAfterHelper<T>(CqlInterval<T>? @this,
            CqlInterval<T>? other,
            string? precision,
            Func<CqlInterval<T?>?, CqlInterval<T?>?> toClosed)
        {
            if (@this == null || other == null)
                return null;

            var thisClosed = toClosed(@this!)!;
            var otherClosed = toClosed(other!)!;

            var isSame = Compare(thisClosed, otherClosed, precision) == 0;
            if (isSame)
                return true;

            var boundaryHit = Compare(thisClosed.low!, otherClosed.high!, precision) == 0;
            if (boundaryHit)
                return true;

            return IntervalAfterIntervalHelper(thisClosed, otherClosed, null, toClosed);
        }

        #endregion

        #region On/Same Or Before

        public bool? IntervalSameOrBefore(CqlInterval<int?> @this, CqlInterval<int?> other)
            => IntervalSameOrBeforeHelper(@this, other, null, ToClosed);
        public bool? IntervalSameOrBefore(CqlInterval<long?> @this, CqlInterval<long?> other)
            => IntervalSameOrBeforeHelper(@this, other, null, ToClosed);
        public bool? IntervalSameOrBefore(CqlInterval<decimal?> @this, CqlInterval<decimal?> other)
            => IntervalSameOrBeforeHelper(@this, other, null, ToClosed);
        public bool? IntervalSameOrBefore(CqlInterval<CqlQuantity?> @this, CqlInterval<CqlQuantity?> other)
            => IntervalSameOrBeforeHelper(@this, other, null, ToClosed);
        public bool? IntervalSameOrBefore(CqlInterval<CqlDate?>? @this, CqlInterval<CqlDate?>? other, string? precision)
        {
            if (@this == null || other == null)
                return null;
            var thisClosed = ToClosed(@this!)!;
            var otherClosed = ToClosed(other!)!;

            if (SamePrecision(@this.low, other.low) == false || SamePrecision(@this.high, other.high) == false)
                return null;

            // if one of the dates has a lower precision than what's passed in, return null
            // ex [2017-09-01T00:00:00, 2017-09-01T00:00:00] same of after [2017-09-01T00:00:00.000, 2017-12-30T23:59:59.999]
            // left goes to seconds and right goes to ms, precision passed in is ms so the left doesn't match the precision we're checking
            if (precision != null
                && (GreaterOrSamePrecision(@this.low!, precision) == false
                    || GreaterOrSamePrecision(@this.high!, precision) == false
                    || GreaterOrSamePrecision(other.low!, precision) == false
                    || GreaterOrSamePrecision(other.high!, precision) == false))
                return null;

            var isSame = Compare(thisClosed, otherClosed, precision) == 0;
            if (isSame) return true;

            var boundaryHit = Compare(thisClosed.high!, otherClosed.low!, precision) == 0;
            if (boundaryHit) return true;

            return IntervalBeforeInterval(thisClosed, otherClosed, precision);
        }

        public bool? IntervalSameOrBefore(CqlInterval<CqlDateTime?>? @this, CqlInterval<CqlDateTime?>? other, string? precision)
        {
            if (@this == null || other == null)
                return null;
            var thisClosed = ToClosed(@this)!;
            var otherClosed = ToClosed(other)!;

            if (SamePrecision(@this.low, other.low) == false || SamePrecision(@this.high, other.high) == false)
                return null;

            // if one of the dates has a lower precision than what's passed in, return null
            // ex [2017-09-01T00:00:00, 2017-09-01T00:00:00] same of after [2017-09-01T00:00:00.000, 2017-12-30T23:59:59.999]
            // left goes to seconds and right goes to ms, precision passed in is ms so the left doesn't match the precision we're checking
            if (precision != null
                && (GreaterOrSamePrecision(@this.low!, precision) == false
                    || GreaterOrSamePrecision(@this.high!, precision) == false
                    || GreaterOrSamePrecision(other.low!, precision) == false
                    || GreaterOrSamePrecision(other.high!, precision) == false))
                return null;

            var isSame = Compare(thisClosed!, otherClosed!, precision) == 0;
            if (isSame) return true;

            var boundaryHit = Compare(thisClosed.high!, otherClosed.low!, precision) == 0;
            if (boundaryHit) return true;

            return IntervalBeforeInterval(thisClosed, otherClosed, precision);
        }

        public bool? IntervalSameOrBefore(CqlInterval<CqlTime?>? @this, CqlInterval<CqlTime?>? other, string? precision)
        {
            if (@this == null || other == null)
                return null;
            var thisClosed = ToClosed(@this)!;
            var otherClosed = ToClosed(other)!;

            if (SamePrecision(@this.low, other.low) == false || SamePrecision(@this.high, other.high) == false)
                return null;

            // if one of the dates has a lower precision than what's passed in, return null
            // ex [2017-09-01T00:00:00, 2017-09-01T00:00:00] same of after [2017-09-01T00:00:00.000, 2017-12-30T23:59:59.999]
            // left goes to seconds and right goes to ms, precision passed in is ms so the left doesn't match the precision we're checking
            if (precision != null
                && (GreaterOrSamePrecision(@this.low!, precision) == false
                    || GreaterOrSamePrecision(@this.high!, precision) == false
                    || GreaterOrSamePrecision(other.low!, precision) == false
                    || GreaterOrSamePrecision(other.high!, precision) == false))
                return null;

            var isSame = Compare(thisClosed, otherClosed, precision) == 0;
            if (isSame) return true;

            var boundaryHit = Compare(thisClosed.high!, otherClosed.low!, precision) == 0;
            if (boundaryHit) return true;

            return IntervalBeforeInterval(thisClosed, otherClosed, precision);
        }


        private bool? IntervalSameOrBeforeHelper<T>(CqlInterval<T?>? @this,
           CqlInterval<T?>? other,
            string? precision,
            Func<CqlInterval<T?>?, CqlInterval<T?>?> toClosed)
        {
            if (@this == null || other == null)
                return null;
            var thisClosed = toClosed(@this!)!;
            var otherClosed = toClosed(other!)!;

            var isSame = Compare(thisClosed, otherClosed, precision) == 0;
            if (isSame) return true;

            var boundaryHit = Compare(thisClosed.high!, otherClosed.low!, precision) == 0;
            if (boundaryHit) return true;

            return IntervalBeforeIntervalHelper(thisClosed, otherClosed, null, toClosed);
        }


        #endregion

        #region Overlaps

        public bool? Overlaps(CqlInterval<int?> left, CqlInterval<int?> right) =>
            OverlapsHelper(left, right, null, ToClosed);
        public bool? Overlaps(CqlInterval<long?> left, CqlInterval<long?> right) =>
            OverlapsHelper(left, right, null, ToClosed);
        public bool? Overlaps(CqlInterval<decimal?> left, CqlInterval<decimal?> right) =>
            OverlapsHelper(left, right, null, ToClosed);
        public bool? Overlaps(CqlInterval<CqlQuantity?> left, CqlInterval<CqlQuantity?> right) =>
            OverlapsHelper(left, right, null, ToClosed);
        public bool? Overlaps(CqlInterval<CqlDate?> left, CqlInterval<CqlDate?> right, string? precision) =>
            OverlapsHelper(left, right, precision, ToClosed);
        public bool? Overlaps(CqlInterval<CqlDateTime?> left, CqlInterval<CqlDateTime?> right, string? precision) =>
            OverlapsHelper(left, right, precision, ToClosed);
        public bool? Overlaps(CqlInterval<CqlTime?> left, CqlInterval<CqlTime?> right, string? precision) =>
            OverlapsHelper(left, right, precision, ToClosed);

        private bool? OverlapsHelper<T>(CqlInterval<T?>? left, CqlInterval<T?>? right, string? precision,
            Func<CqlInterval<T?>?, CqlInterval<T?>?>? toClosed)
        {
            if (left == null || right == null)
                return null;
            left = toClosed!(left!)!;
            right = toClosed!(right!)!;
            if (Compare(left.high ?? Maximum<T>()!, right.low ?? Minimum<T>()!, precision) >= 0
                && Compare(left.low ?? Minimum<T>()!, right.high ?? Maximum<T>()!, precision) <= 0)
                return true;
            else
                return false;
        }

        #endregion

        #region Overlaps After

        public bool? OverlapsAfter(CqlInterval<int?>? left, CqlInterval<int?>? right) =>
            OverlapsAfterHelper(left, right, null, ToClosed);
        public bool? OverlapsAfter(CqlInterval<long?>? left, CqlInterval<long?>? right) =>
            OverlapsAfterHelper(left, right, null, ToClosed);
        public bool? OverlapsAfter(CqlInterval<decimal?>? left, CqlInterval<decimal?>? right) =>
            OverlapsAfterHelper(left, right, null, ToClosed);
        public bool? OverlapsAfter(CqlInterval<CqlQuantity?> left, CqlInterval<CqlQuantity?> right) =>
            OverlapsAfterHelper(left, right, null, ToClosed);

        public bool? OverlapsAfter(CqlInterval<CqlDate?>? left, CqlInterval<CqlDate?>? right, string? precision) =>
            OverlapsAfterHelper(left, right, precision, ToClosed);
        public bool? OverlapsAfter(CqlInterval<CqlDateTime?>? left, CqlInterval<CqlDateTime?>? right, string? precision) =>
            OverlapsAfterHelper(left, right, precision, ToClosed);
        public bool? OverlapsAfter(CqlInterval<CqlTime?>? left, CqlInterval<CqlTime?>? right, string? precision) =>
            OverlapsAfterHelper(left, right, precision, ToClosed);

        private bool? OverlapsAfterHelper<T>(CqlInterval<T?>? left, CqlInterval<T?>? right, string? precision,
            Func<CqlInterval<T?>?, CqlInterval<T?>?> toClosed)
        {
            if (left == null || right == null)
                return null;
            left = toClosed(left!)!;
            right = toClosed(right!)!;
            if (Compare(left.low ?? Maximum<T>()!, right.high ?? Minimum<T>()!, precision) <= 0
                && Compare(left.high ?? Minimum<T>()!, right.high ?? Maximum<T>()!, precision) > 0)
                return true;
            else
                return false;
        }

        #endregion

        #region Overlaps before
        public bool? OverlapsBefore(CqlInterval<int?>? left, CqlInterval<int?>? right) =>
            OverlapsBeforeHelper(left, right, null, ToClosed);
        public bool? OverlapsBefore(CqlInterval<long?>? left, CqlInterval<long?>? right) =>
            OverlapsBeforeHelper(left, right, null, ToClosed);
        public bool? OverlapsBefore(CqlInterval<decimal?>? left, CqlInterval<decimal?>? right) =>
            OverlapsBeforeHelper(left, right, null, ToClosed);
        public bool? OverlapsBefore(CqlInterval<CqlQuantity?>? left, CqlInterval<CqlQuantity?>? right) =>
            OverlapsBeforeHelper(left, right, null, ToClosed);
        public bool? OverlapsBefore(CqlInterval<CqlDate?>? left, CqlInterval<CqlDate?>? right, string? precision) =>
            OverlapsBeforeHelper(left, right, precision, ToClosed);
        public bool? OverlapsBefore(CqlInterval<CqlTime?>? left, CqlInterval<CqlTime?>? right, string? precision) =>
            OverlapsBeforeHelper(left, right, precision, ToClosed);
        public bool? OverlapsBefore(CqlInterval<CqlDateTime?>? left, CqlInterval<CqlDateTime?>? right, string? precision) =>
            OverlapsBeforeHelper(left, right, precision, ToClosed);

        public bool? OverlapsBeforeHelper<T>(CqlInterval<T?>? left, CqlInterval<T?>? right, string? precision,
            Func<CqlInterval<T?>?, CqlInterval<T?>?> toClosed)
        {
            if (left == null || right == null)
                return null;
            left = toClosed(left);
            right = toClosed(right);

            if (Compare(left!.high ?? Maximum<T>()!, right!.low ?? Minimum<T>()!, precision) >= 0
                && Compare(left.low ?? Minimum<T>()!, right.low ?? Minimum<T>()!, precision) < 0)
                return true;
            else
                return false;
        }

        #endregion

        #region Point from

        public T? PointFrom<T>(CqlInterval<T?>? argument) =>
           argument == null ? default : (Compare(argument!.low!, argument!.high!, null) == 0 ? argument.low : throw new InvalidOperationException("PointFrom can not be extracted  - interval is too wide"));

        #endregion

        #region Properly Includes/Included In

        public bool? IntervalProperlyIncludedInInterval<T>(CqlInterval<T>? left, CqlInterval<T>? right, string precision)
        {
            if (left == null)
                return null;
            if (right == null)
                return false;

            var min = Minimum<T>()!;

            var low = Compare(left!.low ?? min!, right.low ?? min, precision);
            if (low < 0)
                return false;
            var max = Maximum<T>()!;
            var high = Compare(left.high ?? max, right.high ?? max, precision);
            if (high > 0)
                return false;
            // and they are not the same interval.
            if (low == 0 && high == 0 && left.lowClosed == right.lowClosed && left.highClosed == right.highClosed)
                return false;
            return true;
        }


        public bool? IntervalProperlyIncludesInterval<T>(CqlInterval<T>? left, CqlInterval<T>? right, string precision) =>
            IntervalProperlyIncludedInInterval(right, left, precision);




        public bool? ElementProperlyIncludedInInterval<T>(T left, CqlInterval<T>? right)
        {
            if (left == null || right == null || right.low == null || right.high == null)
                return null;

            var low = Compare(left, right.low, null);
            var high = Compare(left, right.high, null);
            if (low < 0)
                return false;
            if (high > 0)
                return false;
            // interval is a unit interval containing only the point
            if (low == 0 && high == 0)
                return false;
            return true;
        }

        public bool? ElementProperlyIncludedInInterval(CqlDate left, CqlInterval<CqlDate>? right, string precision)
        {
            if (left == null || right == null || right.low == null || right.high == null)
                return null;

            if (precision == null && (SamePrecision(left, right.high) == false || SamePrecision(left, right.low) == false))
                return null;
            else if (GreaterOrSamePrecision(left, precision) == false
                    || GreaterOrSamePrecision(right.low, precision) == false
                    || GreaterOrSamePrecision(right.high, precision) == false)
                return null;

            var low = Compare(left, right.low, precision);
            var high = Compare(left, right.high, precision);
            if (low < 0)
                return false;
            if (high > 0)
                return false;
            // interval is a unit interval containing only the point
            if (low == 0 && high == 0)
                return false;
            return true;
        }


        public bool? ElementProperlyIncludedInInterval(CqlDateTime left, CqlInterval<CqlDateTime>? right, string precision)
        {
            if (left == null || right == null || right.low == null || right.high == null)
                return null;

            if (precision == null && (SamePrecision(left, right.high) == false || SamePrecision(left, right.low) == false))
                return null;
            else if (GreaterOrSamePrecision(left, precision) == false
                    || GreaterOrSamePrecision(right.low, precision) == false
                    || GreaterOrSamePrecision(right.high, precision) == false)
                return null;

            var low = Compare(left, right.low, precision);
            var high = Compare(left, right.high, precision);
            if (low < 0)
                return false;
            if (high > 0)
                return false;
            // interval is a unit interval containing only the point
            if (low == 0 && high == 0)
                return false;
            return true;
        }

        public bool? ElementProperlyIncludedInInterval(CqlTime left, CqlInterval<CqlTime>? right, string precision)
        {
            if (left == null || right == null || right.low == null || right.high == null)
                return null;


            if (precision == null && (SamePrecision(left, right.high) == false || SamePrecision(left, right.low) == false))
                return null;
            else if (GreaterOrSamePrecision(left, precision) == false
                    || GreaterOrSamePrecision(right.low, precision) == false
                    || GreaterOrSamePrecision(right.high, precision) == false)
                return null;

            var low = Compare(left, right.low, precision);
            var high = Compare(left, right.high, precision);
            if (low < 0)
                return false;
            if (high > 0)
                return false;
            // interval is a unit interval containing only the point
            if (low == 0 && high == 0)
                return false;
            return true;
        }


        public bool? IntervalProperlyIncludesElement<T>(CqlInterval<T>? left, T right) =>
            ElementProperlyIncludedInInterval(right, left);

        public bool? IntervalProperlyIncludesElement(CqlInterval<CqlDate>? left, CqlDate right, string precision) =>
            ElementProperlyIncludedInInterval(right, left, precision);

        public bool? IntervalProperlyIncludesElement(CqlInterval<CqlDateTime>? left, CqlDateTime right, string precision) =>
            ElementProperlyIncludedInInterval(right, left, precision);

        public bool? IntervalProperlyIncludesElement(CqlInterval<CqlTime>? left, CqlTime right, string precision) =>
            ElementProperlyIncludedInInterval(right, left, precision);


        #endregion

        #region Size

        public int? IntervalSize(CqlInterval<int?>? argument)
        {
            var minimum = Minimum<int>();
            var pointSize = Subtract(Successor(minimum), minimum);
            var closed = ToClosed(argument);
            if (closed == null) return default(int);
            return Add(Subtract(closed.high ?? Maximum<int>(), closed.low ?? Minimum<int>()), pointSize);
        }

        public decimal? IntervalSize(CqlInterval<decimal?>? argument)
        {
            var minimum = Minimum<decimal>();
            var pointSize = Subtract(Successor(minimum), minimum);
            var closed = ToClosed(argument);
            if (closed == null)
                return default(decimal);
            return Add(Subtract(closed.high ?? Maximum<decimal>(), closed.low ?? Minimum<decimal>()), pointSize);
        }
        public long? IntervalSize(CqlInterval<long?>? argument)
        {
            var minimum = Minimum<long>();
            var pointSize = Subtract(Successor(minimum), minimum);
            var closed = ToClosed(argument);
            if (closed == null)
                return default(long);
            return Add(Subtract(closed.high ?? Maximum<long>(), closed.low ?? Minimum<long>()), pointSize);
        }

        #endregion

        #region Start

        public int? Start(CqlInterval<int?>? argument)
        {
            if (argument == null)
                return null;

            if (argument.low == null && argument.high == null)
                return null;

            var isLowClosed = argument.lowClosed ?? false;
            if (argument.low == null && !isLowClosed)
                return null;

            if (isLowClosed)
                return argument.low ?? Minimum<int?>();
            else return Successor(argument.low);
        }
        public long? Start(CqlInterval<long?>? argument)
        {
            if (argument == null)
                return null;

            if (argument.low == null && argument.high == null)
                return null;

            var isLowClosed = argument.lowClosed ?? false;
            if (argument.low == null && !isLowClosed)
                return null;

            if (isLowClosed)
                return argument.low ?? Minimum<long?>();
            else return Successor(argument.low);
        }
        public decimal? Start(CqlInterval<decimal?>? argument)
        {
            if (argument == null)
                return null;

            if (argument.low == null && argument.high == null)
                return null;

            var isLowClosed = argument.lowClosed ?? false;
            if (argument.low == null && !isLowClosed)
                return null;

            if (isLowClosed)
                return argument.low ?? Minimum<decimal?>();
            else return Successor(argument.low);
        }
        public CqlQuantity? Start(CqlInterval<CqlQuantity?>? argument)
        {
            if (argument == null)
                return null;

            if (argument.low == null && argument.high == null)
                return null;

            var isLowClosed = argument.lowClosed ?? false;
            if (argument.low == null && !isLowClosed)
                return null;

            if (isLowClosed)
                return argument.low ?? Minimum<CqlQuantity?>();
            else return Successor(argument.low);
        }

        public CqlDate? Start(CqlInterval<CqlDate?>? argument)
        {
            if (argument == null)
                return null;

            if (argument.low == null && argument.high == null)
                return null;

            var isLowClosed = argument.lowClosed ?? false;
            if (argument.low == null && !isLowClosed)
                return null;

            if (isLowClosed)
                return argument.low ?? Minimum<CqlDate?>();
            else return Successor(argument.low);
        }
        public CqlDateTime? Start(CqlInterval<CqlDateTime?>? argument)
        {
            if (argument == null)
                return null;

            if (argument.low == null && argument.high == null)
                return null;

            var isLowClosed = argument.lowClosed ?? false;
            if (argument.low == null && !isLowClosed)
                return null;

            if (isLowClosed)
                return argument.low ?? Minimum<CqlDateTime?>();
            else return Successor(argument.low);
        }
        public CqlTime? Start(CqlInterval<CqlTime?>? argument)
        {
            if (argument == null)
                return null;

            if (argument.low == null && argument.high == null)
                return null;

            var isLowClosed = argument.lowClosed ?? false;
            if (argument.low == null && !isLowClosed)
                return null;

            if (isLowClosed)
                return argument.low ?? Minimum<CqlTime?>();
            else return Successor(argument.low);
        }

        #endregion

        #region Starts

        public bool? Starts<T>(CqlInterval<T>? starts, CqlInterval<T>? other, string? precision)
        {
            if (starts == null || other == null)
                return null;
            if (Compare(starts.low!, other.low!, precision) == 0 && Compare(starts.high!, other.high!, precision) <= 0)
                return true;
            return false;
        }

        #endregion

        #region Union

        public CqlInterval<T>? IntervalUnion<T>(CqlInterval<T>? left, CqlInterval<T>? right)
        {
            if (left == null || right == null) return null;
            else
            {
                if (Compare(left.low!, right.low!, null) <= 0)
                {
                    if (Compare(left.high!, right.low!, null) >= 0)
                    {
                        if (Compare(left.high!, right.high!, null) < 0) return new CqlInterval<T>(left.low, right.high, left.lowClosed, right.highClosed);
                        else return left;
                    }
                    else return null;
                }
                else
                {
                    if (Compare(right.high!, left.low!, null) >= 0)
                    {
                        if (Compare(left.high!, left.high!, null) > 0) return new CqlInterval<T>(right.low, left.high, right.lowClosed, left.highClosed);
                        else return right;
                    }
                    else return null;
                }
            }
        }

        #endregion

        #region Width

        public int? Width(CqlInterval<int?>? @this)
        {
            var closedInterval = ToClosed(@this);
            return closedInterval == null || closedInterval.low == null || closedInterval.high == null
                 ? null
                 : Subtract(End(closedInterval), Start(closedInterval));
        }

        public long? Width(CqlInterval<long?>? @this)
        {
            var closedInterval = ToClosed(@this);

            return closedInterval == null || closedInterval.low == null || closedInterval.high == null
                ? null
                 : Subtract(End(closedInterval), Start(closedInterval));
        }
        public decimal? Width(CqlInterval<decimal?>? @this)
        {
            var closedInterval = ToClosed(@this);
            return closedInterval == null || closedInterval.low == null || closedInterval.high == null
                ? null
                 : Subtract(End(closedInterval), Start(closedInterval));
        }

        public CqlQuantity? Width(CqlInterval<CqlQuantity?>? @this)
        {
            var closedInterval = ToClosed(@this!)!;
            return closedInterval == null || closedInterval.low == null || closedInterval.high == null
                ? null
                : Subtract(End(closedInterval), Start(closedInterval));
        }

        #endregion

        public CqlInterval<int?>? ToClosed(CqlInterval<int?>? interval) => ToClosedHelper(interval, Predecessor, Successor);
        public CqlInterval<long?>? ToClosed(CqlInterval<long?>? interval) => ToClosedHelper(interval, Predecessor, Successor);
        public CqlInterval<decimal?>? ToClosed(CqlInterval<decimal?>? interval) => ToClosedHelper(interval, Predecessor, Successor);
        public CqlInterval<CqlQuantity?>? ToClosed(CqlInterval<CqlQuantity?>? interval) => ToClosedHelper(interval, Predecessor, Successor);
        public CqlInterval<CqlDate?>? ToClosed(CqlInterval<CqlDate?>? interval) => ToClosedHelper(interval, Predecessor, Successor);
        public CqlInterval<CqlDateTime?>? ToClosed(CqlInterval<CqlDateTime?>? interval) => ToClosedHelper(interval, Predecessor, Successor);
        public CqlInterval<CqlTime?>? ToClosed(CqlInterval<CqlTime?>? interval) => ToClosedHelper(interval, Predecessor, Successor);

        protected CqlInterval<T>? ToClosedHelper<T>(CqlInterval<T>? interval, Func<T, T> predecessor, Func<T, T> successor)
        {
            if (interval == null) return null;
            var lowClosed = true;
            var highClosed = true;

            if ((interval!.lowClosed ?? false) && (interval.highClosed ?? false)) return interval;

            T newLow, newHigh;
            if (!(interval.lowClosed ?? false))
            {
                if (interval.low != null)
                    newLow = successor(interval.low);
                else
                {
                    lowClosed = false;
                    newLow = interval.low;
                }
            }
            else
            {
                newLow = interval.low;
            }

            if (!(interval.highClosed ?? false))

            {
                if (interval.high != null)
                    newHigh = predecessor(interval.high);
                else
                {
                    highClosed = false;
                    newHigh = interval.high;
                }
            }
            else
            {
                newHigh = interval.high;
            }
            return new CqlInterval<T>(newLow, newHigh, lowClosed, highClosed);
        }
    }
}
