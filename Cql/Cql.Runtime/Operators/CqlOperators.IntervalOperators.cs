#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Exceptions;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Operators
{
    internal partial class CqlOperators
    {
        #region Interval

        public CqlInterval<int?>? Interval(int? low, int? high, bool? lowClosed, bool? highClosed) =>
            ToClosed(new CqlInterval<int?>(low, high, lowClosed, highClosed));
        public CqlInterval<decimal?>? Interval(decimal? low, decimal? high, bool? lowClosed, bool? highClosed) =>
            ToClosed(new CqlInterval<decimal?>(low, high, lowClosed, highClosed));
        public CqlInterval<long?>? Interval(long? low, long? high, bool? lowClosed, bool? highClosed) =>
            ToClosed(new CqlInterval<long?>(low, high, lowClosed, highClosed));
        public CqlInterval<CqlQuantity?>? Interval(CqlQuantity? low, CqlQuantity? high, bool? lowClosed, bool? highClosed) =>
            ToClosed(new CqlInterval<CqlQuantity?>(low, high, lowClosed, highClosed));

        // Boundary exclusivity is preserved, not normalized with ToClosed() - see the CqlDateTime
        // overload for why.
        public CqlInterval<CqlDate?>? Interval(CqlDate? low, CqlDate? high, bool? lowClosed, bool? highClosed) =>
            new(low, high, lowClosed, highClosed);

        // Boundary exclusivity is deliberately preserved rather than normalized away with
        // ToClosed(): closing an exclusive date/time boundary shifts it by one unit of the
        // boundary value's own precision, which is lossy for any operator that compares at a
        // coarser precision. In: "For open interval boundaries, exclusive comparison operators
        // are used. [...] If precision is specified and the point type is a date/time type,
        // comparisons used in the operation are performed at the specified precision."
        // (CQL 1.5.3 Errata 2, Appendix B - CQL Reference, 5.3 in). Pre-closing an exclusive
        // high of @2026-06-30T08:00 to @2026-06-30T07:59:59.999 turns 'in ... day' from an
        // exclusive same-day comparison into an inclusive one.
        public CqlInterval<CqlDateTime?>? Interval(CqlDateTime? low, CqlDateTime? high, bool? lowClosed, bool? highClosed) =>
            new(low, high, lowClosed, highClosed);

        // Boundary exclusivity is preserved, not normalized with ToClosed() - see the CqlDateTime
        // overload above for why.
        public CqlInterval<CqlTime?>? Interval(CqlTime? low, CqlTime? high, bool? lowClosed, bool? highClosed) =>
            new(low, high, lowClosed, highClosed);
        #endregion

        #region After

        public bool? After(CqlInterval<int?>? left, CqlInterval<int?>? right, string? precision) =>
            IntervalAfterIntervalHelper(left, right, precision, ToClosed);
        public bool? After(CqlInterval<long?>? left, CqlInterval<long?>? right, string? precision) =>
            IntervalAfterIntervalHelper(left, right, precision, ToClosed);
        public bool? After(CqlInterval<decimal?>? left, CqlInterval<decimal?>? right, string? precision) =>
            IntervalAfterIntervalHelper(left, right, precision, ToClosed);
        public bool? After(CqlInterval<CqlQuantity?>? left, CqlInterval<CqlQuantity?>? right, string? precision) =>
            IntervalAfterIntervalHelper(left, right, precision, ToClosed);

        public bool? After(CqlInterval<CqlDate?>? left, CqlInterval<CqlDate?>? right, string? precision) =>
            IntervalAfterIntervalHelper(left, right, precision, ToClosed);
        public bool? After(CqlInterval<CqlDateTime?>? left, CqlInterval<CqlDateTime?>? right, string? precision) =>
            IntervalAfterIntervalHelper(left, right, precision, ToClosed);
        public bool? After(CqlInterval<CqlTime?>? left, CqlInterval<CqlTime?>? right, string? precision) =>
            IntervalAfterIntervalHelper(left, right, precision, ToClosed);

        private bool? IntervalAfterIntervalHelper<T>(CqlInterval<T?>? left, CqlInterval<T?>? right, string? precision,
            Func<CqlInterval<T?>?, CqlInterval<T?>?> toClosed)
        {
            if (left == null || right == null)
                return null;

            var leftClosed = toClosed(left)!;
            var rightClosed = toClosed(right)!;

            // The first interval starts after the second one ends, under Start/End semantics.
            return IsAfter(Boundary<T?>.LowOf(leftClosed), Boundary<T?>.HighOf(rightClosed), precision);
        }

        public bool? After(CqlInterval<int?>? left, int? right, string? precision) =>
            IntervalAfterElementHelper(left, right, precision, ToClosed);
        public bool? After(CqlInterval<long?>? left, long? right, string? precision) =>
            IntervalAfterElementHelper(left, right, precision, ToClosed);
        public bool? After(CqlInterval<decimal?>? left, decimal? right, string? precision) =>
            IntervalAfterElementHelper(left, right, precision, ToClosed);
        public bool? After(CqlInterval<CqlQuantity?>? left, CqlQuantity? right, string? precision) =>
            IntervalAfterElementHelper(left, right, precision, ToClosed);
        public bool? After(CqlInterval<CqlDate?>? left, CqlDate? right, string? precision) =>
            IntervalAfterElementHelper(left, right, precision, ToClosed);
        public bool? After(CqlInterval<CqlDateTime?>? left, CqlDateTime? right, string? precision) =>
            IntervalAfterElementHelper(left, right, precision, ToClosed);
        public bool? After(CqlInterval<CqlTime?>? left, CqlTime? right, string? precision) =>
            IntervalAfterElementHelper(left, right, precision, ToClosed);
        public bool? IntervalAfterElementHelper<T>(CqlInterval<T>? left, T right, string? precision,
            Func<CqlInterval<T?>?, CqlInterval<T?>?> toClosed)
        {
            if (left == null || right == null)
                return null;

            // The interval starts after the point, under Start/End semantics.
            var closed = toClosed(left!)!;
            return IsAfter(Boundary<T?>.LowOf(closed), Boundary<T?>.Of(right), precision);
        }

        public bool? After(int? left, CqlInterval<int?>? right, string? precision) =>
            ElementAfterIntervalHelper(left, right, precision, ToClosed);
        public bool? After(long? left, CqlInterval<long?>? right, string? precision) =>
            ElementAfterIntervalHelper(left, right, precision, ToClosed);
        public bool? After(decimal? left, CqlInterval<decimal?>? right, string? precision) =>
            ElementAfterIntervalHelper(left, right, precision, ToClosed);
        public bool? After(CqlQuantity? left, CqlInterval<CqlQuantity?>? right, string? precision) =>
            ElementAfterIntervalHelper(left, right, precision, ToClosed);
        public bool? After(CqlDate? left, CqlInterval<CqlDate?>? right, string? precision) =>
            ElementAfterIntervalHelper(left, right, precision, ToClosed);
        public bool? After(CqlDateTime? left, CqlInterval<CqlDateTime?>? right, string? precision) =>
            ElementAfterIntervalHelper(left, right, precision, ToClosed);
        public bool? After(CqlTime? left, CqlInterval<CqlTime?>? right, string? precision) =>
            ElementAfterIntervalHelper(left, right, precision, ToClosed);
        public bool? ElementAfterIntervalHelper<T>(T left, CqlInterval<T>? right, string? precision,
            Func<CqlInterval<T?>?, CqlInterval<T?>?> toClosed)
        {
            if (left == null || right == null)
                return null;

            // The point is after the interval's end, under Start/End semantics.
            var closed = toClosed(right!)!;
            return IsAfter(Boundary<T?>.Of(left), Boundary<T?>.HighOf(closed), precision);
        }

        #endregion

        #region Before

        public bool? Before(CqlInterval<int?>? left, CqlInterval<int?>? right, string? precision) =>
            IntervalBeforeIntervalHelper(left, right, precision, ToClosed);
        public bool? Before(CqlInterval<long?>? left, CqlInterval<long?>? right, string? precision) =>
            IntervalBeforeIntervalHelper(left, right, precision, ToClosed);
        public bool? Before(CqlInterval<decimal?>? left, CqlInterval<decimal?>? right, string? precision) =>
            IntervalBeforeIntervalHelper(left, right, precision, ToClosed);
        public bool? Before(CqlInterval<CqlQuantity?>? left, CqlInterval<CqlQuantity?>? right, string? precision) =>
            IntervalBeforeIntervalHelper(left, right, precision, ToClosed);
        public bool? Before(CqlInterval<CqlDate?>? left, CqlInterval<CqlDate?>? right, string? precision) =>
            IntervalBeforeIntervalHelper(left, right, precision, ToClosed);
        public bool? Before(CqlInterval<CqlDateTime?>? left, CqlInterval<CqlDateTime?>? right, string? precision) =>
            IntervalBeforeIntervalHelper(left, right, precision, ToClosed);
        public bool? Before(CqlInterval<CqlTime?>? left, CqlInterval<CqlTime?>? right, string? precision) =>
            IntervalBeforeIntervalHelper(left, right, precision, ToClosed);

        private bool? IntervalBeforeIntervalHelper<T>(CqlInterval<T?>? left, CqlInterval<T?>? right, string? precision,
            Func<CqlInterval<T?>?, CqlInterval<T?>?> toClosed)
        {
            if (left == null || right == null)
                return null;

            var leftClosed = toClosed(left)!;
            var rightClosed = toClosed(right)!;

            // The first interval ends before the second one starts, under Start/End semantics.
            return IsBefore(Boundary<T?>.HighOf(leftClosed), Boundary<T?>.LowOf(rightClosed), precision);
        }

        public bool? Before(CqlInterval<int?>? left, int? right, string? precision) =>
            IntervalBeforeElementHelper(left, right, precision, ToClosed);
        public bool? Before(CqlInterval<long?>? left, long? right, string? precision) =>
            IntervalBeforeElementHelper(left, right, precision, ToClosed);
        public bool? Before(CqlInterval<decimal?>? left, decimal? right, string? precision) =>
            IntervalBeforeElementHelper(left, right, precision, ToClosed);
        public bool? Before(CqlInterval<CqlQuantity?>? left, CqlQuantity? right, string? precision) =>
            IntervalBeforeElementHelper(left, right, precision, ToClosed);
        public bool? Before(CqlInterval<CqlDate?>? left, CqlDate? right, string? precision) =>
            IntervalBeforeElementHelper(left, right, precision, ToClosed);
        public bool? Before(CqlInterval<CqlDateTime?>? left, CqlDateTime? right, string? precision) =>
            IntervalBeforeElementHelper(left, right, precision, ToClosed);
        public bool? Before(CqlInterval<CqlTime?>? left, CqlTime? right, string? precision) =>
            IntervalBeforeElementHelper(left, right, precision, ToClosed);

        public bool? IntervalBeforeElementHelper<T>(CqlInterval<T>? left, T right, string? precision,
            Func<CqlInterval<T?>?, CqlInterval<T?>?> toClosed)
        {
            if (left == null || right == null)
                return null;

            // The interval ends before the point, under Start/End semantics.
            var closed = toClosed(left!)!;
            return IsBefore(Boundary<T?>.HighOf(closed), Boundary<T?>.Of(right), precision);
        }

        public bool? Before(int? left, CqlInterval<int?>? right, string? precision) =>
            ElementBeforeIntervalHelper(left, right, precision, ToClosed);
        public bool? Before(long? left, CqlInterval<long?>? right, string? precision) =>
            ElementBeforeIntervalHelper(left, right, precision, ToClosed);
        public bool? Before(decimal? left, CqlInterval<decimal?>? right, string? precision) =>
            ElementBeforeIntervalHelper(left, right, precision, ToClosed);
        public bool? Before(CqlQuantity? left, CqlInterval<CqlQuantity?>? right, string? precision) =>
            ElementBeforeIntervalHelper(left, right, precision, ToClosed);
        public bool? Before(CqlDate? left, CqlInterval<CqlDate?>? right, string? precision) =>
            ElementBeforeIntervalHelper(left, right, precision, ToClosed);
        public bool? Before(CqlDateTime? left, CqlInterval<CqlDateTime?>? right, string? precision) =>
            ElementBeforeIntervalHelper(left, right, precision, ToClosed);
        public bool? Before(CqlTime? left, CqlInterval<CqlTime?>? right, string? precision) =>
            ElementBeforeIntervalHelper(left, right, precision, ToClosed);
        public bool? ElementBeforeIntervalHelper<T>(T left, CqlInterval<T>? right, string? precision,
            Func<CqlInterval<T?>?, CqlInterval<T?>?> toClosed)
        {
            if (left == null || right == null)
                return null;

            // The point is before the interval's start, under Start/End semantics.
            var closed = toClosed(right!)!;
            return IsBefore(Boundary<T?>.Of(left), Boundary<T?>.LowOf(closed), precision);
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
            // The type tests this replaced asked about IList<T>/T[] - the point type, not the CqlInterval<T?>
            // element type the sequence actually holds - so they could never match and were dead code. Count()
            // already short-circuits on ICollection<T>, so this is a readability fix, not a faster path.
            if (!intervals.TryGetNonEnumeratedCount(out var count))
                count = intervals.Count();
            if (count == 0)
                return new CqlInterval<T?>[0];

            // Sorted on the effective low boundary, because TryCombine below assumes the interval it merges
            // into starts no later than the one it merges in. An exclusive low is effectively one unit of
            // its own precision later than the raw value, so two raw lows can tie - or compare equal - where
            // the effective ones do not, which would otherwise hand TryCombine its operands the wrong way
            // round and drop the earlier part of the range.
            // need null check on i because i!.low! causes HL7 unit test TestCollapseNull_Test to fail since i is null
            var sorted = SortBy(intervals, i => i == null ? null! : toClosed(i)!.low!, ListSortDirection.Ascending)?.ToList();
            if (sorted is null || sorted.Count == 0) return null;

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

            // Walk the sorted intervals front to back, merging into the interval most recently added to the
            // result. Taking them off the front of the list instead shifts every remaining element down one slot
            // per interval, which costs a quadratic amount of copying for no gain - the visit order is the same.
            var result = new List<CqlInterval<T?>?>(sorted.Count);
            foreach (var next in sorted)
            {
                if (result.Count == 0)
                {
                    result.Add(next);
                    continue;
                }

                var combined = TryCombine(result[^1], next);
                if (combined == null)
                    result.Add(next);
                else
                    result[^1] = combined;
            }
            return result;

        }

        #endregion

        #region Contains

        // Contains is In with its operands the other way round, and the specification states both in the
        // same words: "returns true if the given point is equal to the starting or ending point of the
        // interval, or greater than the starting point and less than the ending point. For open interval
        // boundaries, exclusive comparison operators are used." (CQL 1.5.3 Errata 2, Appendix B - CQL
        // Reference, sections "Contains" and "In"). The two therefore share one implementation, which also
        // keeps contains in step with includes - "For the point-interval overload, this operator is a
        // synonym for the contains operator" (same appendix, section "Includes"). Normalizing the interval
        // to closed boundaries first would not do: that steps an exclusive boundary by one unit of the
        // boundary's own precision, which turns the exclusive comparison into an inclusive one whenever
        // the comparison itself runs at a coarser precision.
        public bool? Contains(CqlInterval<int?>? left, int? right, string? precision) =>
            In(right, left, precision);
        public bool? Contains(CqlInterval<long?>? left, long? right, string? precision) =>
            In(right, left, precision);
        public bool? Contains(CqlInterval<decimal?>? left, decimal? right, string? precision) =>
            In(right, left, precision);
        public bool? Contains(CqlInterval<CqlQuantity?>? left, CqlQuantity? right, string? precision) =>
            In(right, left, precision);

        public bool? Contains(CqlInterval<CqlDate?>? left, CqlDate? right, string? precision) =>
            In(right, left, precision);
        public bool? Contains(CqlInterval<CqlDateTime?>? left, CqlDateTime? right, string? precision) =>
            In(right, left, precision);
        public bool? Contains(CqlInterval<CqlTime?>? left, CqlTime? right, string? precision) =>
            In(right, left, precision);

        #endregion

        #region End

        // End is implemented in terms of the predecessor operator, and therefore is only defined for interval types
        // that implement the predecessor operator.

        public int? End(CqlInterval<int?>? argument)
        {
            if (argument == null)
                return null!;

            var highClosed = argument.highClosed ?? false;
            if (argument.high == null && !highClosed)
                return null;

            if (highClosed)
                return argument.high ?? MaxValue<int?>();
            else return Predecessor(argument.high);
        }

        public long? End(CqlInterval<long?>? argument)
        {
            if (argument == null)
                return null!;

            var highClosed = argument.highClosed ?? false;
            if (argument.high == null && !highClosed)
                return null;

            if (highClosed)
                return argument.high ?? MaxValue<long?>();
            else return Predecessor(argument.high);
        }
        public decimal? End(CqlInterval<decimal?>? argument)
        {
            if (argument == null)
                return null!;

            var highClosed = argument.highClosed ?? false;
            if (argument.high == null && !highClosed)
                return null;

            if (highClosed)
                return argument.high ?? MaxValue<decimal?>();
            else return Predecessor(argument.high);
        }
        public CqlQuantity? End(CqlInterval<CqlQuantity?>? argument)
        {
            if (argument == null)
                return null!;

            var highClosed = argument.highClosed ?? false;
            if (argument.high == null && !highClosed)
                return null;

            if (highClosed)
                return argument.high ?? MaxValue<CqlQuantity?>();
            else return Predecessor(argument.high);
        }

        public CqlDate? End(CqlInterval<CqlDate?>? argument)
        {
            if (argument == null)
                return null!;

            var highClosed = argument.highClosed ?? false;
            if (argument.high == null && !highClosed)
                return null;

            if (highClosed)
                return argument.high ?? MaxValue<CqlDate?>();
            else return Predecessor(argument.high);
        }
        public CqlDateTime? End(CqlInterval<CqlDateTime?>? argument)
        {
            if (argument == null)
                return null!;

            var highClosed = argument.highClosed ?? false;
            if (argument.high == null && !highClosed)
                return null;

            if (highClosed)
                return argument.high ?? MaxValue<CqlDateTime?>();
            else return Predecessor(argument.high);
        }
        public CqlTime? End(CqlInterval<CqlTime?>? argument)
        {
            if (argument == null)
                return null!;

            var highClosed = argument.highClosed ?? false;
            if (argument.high == null && !highClosed)
                return null;

            if (highClosed)
                return argument.high ?? MaxValue<CqlTime?>();
            else return Predecessor(argument.high);
        }

        #endregion

        #region Ends

        public bool? Ends<T>(CqlInterval<T> left, CqlInterval<T> right, string? precision)
        {
            if (left == null) return null;
            else if (right == null) return null;

            // "This operator uses the semantics described in the start and end operators to determine
            // interval boundaries." (CQL 1.5.3 Errata 2, Appendix B - CQL Reference, section "Ends"), so
            // an exclusive boundary is compared as the effective one - a step inward at the boundary's own
            // precision - not as the raw endpoint. Interval[@2026-01-01, @2026-01-03) ends
            // Interval[@2026-01-01, @2026-01-03] would otherwise be true on the equal raw high boundaries,
            // even though the first interval effectively ends a day earlier, on @2026-01-02.
            left = ToClosedBoundaries(left)!;
            right = ToClosedBoundaries(right)!;

            var startsNoEarlier = IsAtOrAfter(Boundary<T>.LowOf(left), Boundary<T>.LowOf(right), precision);
            var sameEnd = IsSame(Boundary<T>.HighOf(left), Boundary<T>.HighOf(right), precision);

            return AndAllowingUnknown(startsNoEarlier, sameEnd);
        }
        #endregion

        #region Except
        public CqlInterval<int?>? Except(CqlInterval<int?>? left, CqlInterval<int?>? right) =>
            IntervalExceptHelper(left, right, ToClosed);
        public CqlInterval<long?>? Except(CqlInterval<long?>? left, CqlInterval<long?>? right) =>
            IntervalExceptHelper(left, right, ToClosed);
        public CqlInterval<decimal?>? Except(CqlInterval<decimal?>? left, CqlInterval<decimal?>? right) =>
            IntervalExceptHelper(left, right, ToClosed);
        public CqlInterval<CqlQuantity?>? Except(CqlInterval<CqlQuantity?>? left, CqlInterval<CqlQuantity?>? right) =>
            IntervalExceptHelper(left, right, ToClosed);
        public CqlInterval<CqlDate?>? Except(CqlInterval<CqlDate?>? left, CqlInterval<CqlDate?>? right) =>
            IntervalExceptHelper(left, right, ToClosed);
        public CqlInterval<CqlDateTime?>? Except(CqlInterval<CqlDateTime?>? left, CqlInterval<CqlDateTime?>? right) =>
            IntervalExceptHelper(left, right, ToClosed);
        public CqlInterval<CqlTime?>? Except(CqlInterval<CqlTime?>? left, CqlInterval<CqlTime?>? right) =>
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
                    return toClosed(new CqlInterval<T?>(left.low, right.low, left.lowClosed, !right.lowClosed));
                }
                if (overlapsAfter == true && overlapsBefore == false)
                {
                    return toClosed(new CqlInterval<T?>(right.high, left.high, !right.highClosed, left.highClosed));
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

        public IEnumerable<CqlDate>? Expand(CqlInterval<CqlDate>? argument, CqlQuantity? per)
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

            // A per of zero or less never advances towards the high boundary, so no expansion can be computed.
            if (per?.value is <= 0)
                return null;

            var interval = ToClosed(argument!)!;

            // A boundary whose closed equivalent cannot be represented is unknown, so the interval contributes nothing.
            if (interval.low == null || interval.high == null)
                return null;
            var expanded = new List<CqlDate>();

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
                    return expanded;

                // Adding a per finer than the lower boundary's precision is null, so the interval contributes nothing.
                if (interval.low!.Precision < precision)
                    return expanded;

                listItem = TruncateToPrecision(interval.low!, precision);
                highInterval = TruncateToPrecision(interval.high!, precision);
            }

            while (true)
            {
                Units.DatePrecisionToCqlUnits.TryGetValue(listItem!.Precision.ToString(), out var cqlunits);

                // The starting point is only returned for intervals of size per that end on or before the upper boundary.
                var onePrior = new CqlQuantity(1, cqlunits);
                var next = listItem.Add(per);

                // The partition ends one step before the next start. When that start cannot be represented, the end is
                // reached directly as start + (per - one step), so a partition ending at the type's maximum is still found.
                var high = next is not null ? next.Subtract(onePrior) : listItem.Add(PerLessOneStep(per, cqlunits));
                var endsOnOrBeforeHigh = high is not null && Comparer.Compare(high, highInterval!, null) <= 0;
                if (!endsOnOrBeforeHigh)
                    break;

                expanded.Add(listItem);
                if (next is null)
                    break;
                listItem = next;
            }

            return expanded;
        }
        public IEnumerable<CqlDateTime>? Expand(CqlInterval<CqlDateTime>? argument, CqlQuantity? per)
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

            // A per of zero or less never advances towards the high boundary, so no expansion can be computed.
            if (per?.value is <= 0)
                return null;

            var interval = ToClosed(argument!)!;

            // A boundary whose closed equivalent cannot be represented is unknown, so the interval contributes nothing.
            if (interval.low == null || interval.high == null)
                return null;
            var expanded = new List<CqlDateTime>();

            // If the per argument is null, a per value will be constructed based on the coarsest precision of the boundaries of the intervals in the input set.
            if (per?.unit == null)
                per = CoarsestPer(interval.low!.Precision, interval.high!.Precision);

            var listItem = interval.low;
            var highInterval = interval.high;
            var perPrecision = PerUnitPrecision(per.unit);

            if (perPrecision is { } precision)
            {
                // Adding a per finer than the lower boundary's precision is null, so the interval contributes nothing.
                if (interval.low!.Precision < precision)
                    return expanded;

                listItem = TruncateToPrecision(interval.low!, precision);
                highInterval = TruncateToPrecision(interval.high!, precision);
            }

            while (true)
            {
                Units.DatePrecisionToCqlUnits.TryGetValue(listItem!.Precision.ToString(), out var cqlunits);

                // The starting point is only returned for intervals of size per that end on or before the upper boundary.
                var onePrior = new CqlQuantity(1, cqlunits);
                var next = listItem.Add(per);

                // The partition ends one step before the next start. When that start cannot be represented, the end is
                // reached directly as start + (per - one step), so a partition ending at the type's maximum is still found.
                var high = next is not null ? next.Subtract(onePrior) : listItem.Add(PerLessOneStep(per, cqlunits));
                var endsOnOrBeforeHigh = high is not null && Comparer.Compare(high, highInterval!, null) <= 0;
                if (!endsOnOrBeforeHigh)
                    break;

                expanded.Add(listItem);
                if (next is null)
                    break;
                listItem = next;
            }

            return expanded;
        }
        public IEnumerable<CqlTime>? Expand(CqlInterval<CqlTime>? argument, CqlQuantity? per)
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

            // A per of zero or less never advances towards the high boundary, so no expansion can be computed.
            if (per?.value is <= 0)
                return null;

            var interval = ToClosed(argument!)!;

            // A boundary whose closed equivalent cannot be represented is unknown, so the interval contributes nothing.
            if (interval.low == null || interval.high == null)
                return null;
            var expanded = new List<CqlTime>();

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
                    return expanded;

                // Adding a per finer than the lower boundary's precision is null, so the interval contributes nothing.
                if (interval.low!.Precision < precision)
                    return expanded;

                listItem = TruncateToPrecision(interval.low!, precision);
                highInterval = TruncateToPrecision(interval.high!, precision);
            }

            while (true)
            {
                Units.DatePrecisionToCqlUnits.TryGetValue(listItem!.Precision.ToString(), out var cqlunits);

                // The starting point is only returned for intervals of size per that end on or before the upper boundary.
                var onePrior = new CqlQuantity(1, cqlunits);
                var next = listItem.Add(per);

                // The partition ends one step before the next start. When that start cannot be represented, the end is
                // reached directly as start + (per - one step), so a partition ending at the type's maximum is still found.
                var high = next is not null ? next.Subtract(onePrior) : listItem.Add(PerLessOneStep(per, cqlunits));
                var endsOnOrBeforeHigh = high is not null && Comparer.Compare(high, highInterval!, null) <= 0;
                if (!endsOnOrBeforeHigh)
                    break;

                expanded.Add(listItem);
                if (next is null)
                    break;
                listItem = next;
            }

            return expanded;
        }
        public IEnumerable<decimal?>? Expand(CqlInterval<decimal?>? argument, CqlQuantity? per)
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

            // A per of zero or less never advances towards the high boundary, so no expansion can be computed.
            if (per?.value is <= 0)
                return null;

            var interval = ToClosed(argument!)!;

            // A boundary whose closed equivalent cannot be represented is unknown, so the interval contributes nothing.
            if (interval.low == null || interval.high == null)
                return null;
            var expanded = new List<decimal?>();

            // If the per argument is null, a per value will be constructed based on the coarsest precision of the boundaries of the intervals in the input set.
            if (per == null)
                per = new CqlQuantity(1, "1");
            else
            {
                // If the per quantity is a datetime, bypass the expansion of input interval of type decimal
                if (per.unit is not null && Units.DatePrecisionToCqlUnits.Values.Contains(per.unit))
                    return expanded;
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

                // The starting point is only returned for intervals of size per that end on or before the upper boundary.
                // Truncation expands at per's scale, so the interval ends one unit of that scale below the next start.
                var high = needsTruncation ? decimal.Subtract(next, UnitAtScale(perScale)) : Predecessor(next);
                var endsOnOrBeforeHigh = high is not null && Comparer.Compare(high, highBoundary, null) <= 0;
                if (!endsOnOrBeforeHigh)
                    break;

                expanded.Add(listItem);
                listItem = next;
            }

            return expanded;
        }
        public IEnumerable<int?>? Expand(CqlInterval<int?>? argument, CqlQuantity? per)
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

            // A per of zero or less never advances towards the high boundary, so no expansion can be computed.
            if (per?.value is <= 0)
                return null;

            var interval = ToClosed(argument!)!;

            // A boundary whose closed equivalent cannot be represented is unknown, so the interval contributes nothing.
            if (interval.low == null || interval.high == null)
                return null;
            var expanded = new List<int?>();

            // If the per argument is null, a per value will be constructed based on the coarsest precision of the boundaries of the intervals in the input set.
            if (per == null)
                per = new CqlQuantity(1, "1");
            else
            {
                // If the per quantity is a datetime, bypass the expansion of input interval of type integer
                if (per.unit is not null && Units.DatePrecisionToCqlUnits.Values.Contains(per.unit))
                    return expanded;
            }

            var perValue = per.value ?? 1;

            // A fractional per makes the spec produce Decimal points, which this Integer overload cannot represent.
            if (decimal.Truncate(perValue) != perValue)
                throw new NotSupportedException($"Expand of an interval of Integer with the fractional per '{perValue}' is not supported: the CQL specification requires the result to be a list of Decimal.");

            var intQuantity = decimal.ToInt32(perValue);
            var listItem = interval.low!.Value;
            while (true)
            {
                // The starting point is only returned for a partition of size per that ends on or before the
                // upper boundary. The end is computed in a wider type so a partition reaching the type's
                // maximum is still emitted, after which there is no next start.
                var end = (long)listItem + intQuantity - 1;
                if (end > interval.high!.Value)
                    break;

                expanded.Add(listItem);
                if (end == int.MaxValue)
                    break;
                listItem = (int)(end + 1);
            }

            return expanded;
        }
        public IEnumerable<long?>? Expand(CqlInterval<long?>? argument, CqlQuantity? per)
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

            // A per of zero or less never advances towards the high boundary, so no expansion can be computed.
            if (per?.value is <= 0)
                return null;

            var interval = ToClosed(argument!)!;

            // A boundary whose closed equivalent cannot be represented is unknown, so the interval contributes nothing.
            if (interval.low == null || interval.high == null)
                return null;
            var expanded = new List<long?>();

            // If the per argument is null, a per value will be constructed based on the coarsest precision of the boundaries of the intervals in the input set.
            if (per == null)
                per = new CqlQuantity(1, "1");
            else
            {
                // If the per quantity is a datetime, bypass the expansion of input interval of type long
                if (per.unit is not null && Units.DatePrecisionToCqlUnits.Values.Contains(per.unit))
                    return expanded;
            }

            var perValue = per.value ?? 1;

            // A fractional per makes the spec produce Decimal points, which this Long overload cannot represent.
            if (decimal.Truncate(perValue) != perValue)
                throw new NotSupportedException($"Expand of an interval of Long with the fractional per '{perValue}' is not supported: the CQL specification requires the result to be a list of Decimal.");

            var intQuantity = decimal.ToInt64(perValue);
            var listItem = interval.low!.Value;
            while (true)
            {
                // The starting point is only returned for a partition of size per that ends on or before the
                // upper boundary. The end is computed in a wider type so a partition reaching the type's
                // maximum is still emitted, after which there is no next start.
                var end = (decimal)listItem + intQuantity - 1;
                if (end > interval.high!.Value)
                    break;

                expanded.Add(listItem);
                if (end == long.MaxValue)
                    break;
                listItem = (long)(end + 1);
            }

            return expanded;
        }

        #endregion

        #region In
        public bool? In<T>(T? t, CqlInterval<T>? interval, string? precision)
        {
            if (t == null) return null;
            if (interval == null) return false;

            // "For open interval boundaries, exclusive comparison operators are used. For closed interval boundaries,
            // if the interval boundary is null, the result of the boundary comparison is considered true." (CQL 1.5.3
            // Errata 2, Appendix B - CQL Reference, section "In"). An open boundary without a value is unknown, and so
            // is the result. The boundaries are compared as given, not as the effective ones: stepping an open boundary
            // inward by one unit of its own precision would turn the exclusive comparison into an inclusive one whenever
            // the comparison runs at a coarser precision. A point that compares as unknown against a boundary (such as
            // one less precise than the boundary that matches it at the point's precision, or quantities with
            // incommensurable units) leaves that boundary's predicate unknown.
            if (IsUnknownBoundary(interval.low, interval.lowClosed) || IsUnknownBoundary(interval.high, interval.highClosed))
                return null;

            var point = Boundary<T>.Of(t);
            var low = interval.low is { } lowValue
                ? interval.lowClosed ?? false
                    ? IsAtOrBefore(Boundary<T>.Of(lowValue), point, precision)
                    : IsBefore(Boundary<T>.Of(lowValue), point, precision)
                : true;
            if (low == false)
                return false;

            var high = interval.high is { } highValue
                ? interval.highClosed ?? false
                    ? IsAtOrAfter(Boundary<T>.Of(highValue), point, precision)
                    : IsAfter(Boundary<T>.Of(highValue), point, precision)
                : true;

            return AndAllowingUnknown(low, high);
        }
        #endregion

        #region Includes
        public bool? IntervalIncludesElement<T>(CqlInterval<T>? interval, T t, string? precision) =>
            In(t, interval, precision);

        public bool? IntervalIncludesInterval<T>(CqlInterval<T>? larger, CqlInterval<T>? smaller, string? precision)
        {
            if (larger == null || smaller == null)
                return null;

            // "This operator uses the semantics described in the Start and End operators to determine
            // interval boundaries." (CQL 1.5.3 Errata 2, Appendix B - CQL Reference, section "Includes"),
            // so an exclusive boundary is compared as the effective one - a step inward at the boundary's
            // own precision. Without that, Interval[@2026-01-01, @2026-01-03] includes
            // Interval(@2026-01-01, @2026-01-03] would compare the equal raw low boundaries and never see
            // that the smaller interval starts a day later.
            larger = ToClosedForPointType(larger)!;
            smaller = ToClosedForPointType(smaller)!;

            var lowIncluded = IsAtOrBefore(Boundary<T>.LowOf(larger), Boundary<T>.LowOf(smaller), precision);
            var highIncluded = IsAtOrAfter(Boundary<T>.HighOf(larger), Boundary<T>.HighOf(smaller), precision);
            // Preserve the existing combination: an indeterminate comparison makes the
            // whole result null, matching the previous null-compare behavior.
            return (lowIncluded, highIncluded) switch
            {
                (null, _) or (_, null) => null,
                (true, true)           => true,
                _                      => false,
            };
        }

        #endregion

        #region Included In

        public bool? IntervalIncludedIn<T>(CqlInterval<T>? smaller, CqlInterval<T>? larger, string? precision) =>
            IntervalIncludesInterval(larger, smaller, precision);

        #endregion

        #region Intersect

        public CqlInterval<T>? Intersect<T>(CqlInterval<T>? left, CqlInterval<T>? right)
        {
            if (left == null || right == null)
                return null;

            // The overlapping portion is determined from the effective boundaries. Read raw,
            // Interval[@2026-01-01, @2026-01-05) intersect Interval[@2026-01-05, @2026-01-08] yields the
            // empty Interval[@2026-01-05, @2026-01-05), where the two intervals in fact do not overlap at
            // all - "If the arguments do not overlap, this operator returns null." (CQL 1.5.3 Errata 2,
            // Appendix B - CQL Reference, section "Intersect").
            left = ToClosedForPointType(left)!;
            right = ToClosedForPointType(right)!;

            // "Note that open null boundaries of intervals are treaterd [sic] as uncertainties for the purposes
            // of interval computation." For Interval[1, 10] intersect Interval[5, null): "This results in an
            // interval that begins at 5, and ends at some value between 5 and 10." (CQL 1.5.3 Errata 2,
            // Language Semantics, section "Interval Operators"). A null closed boundary is the minimum or
            // maximum value of the point type; a null open boundary is unknown and ranges over the values its
            // own interval permits. Whether the intervals overlap, and which argument supplies each boundary
            // of the result, are decided over those ranges. When the overlap cannot be decided the result is
            // null; when the boundary cannot be decided it is emitted as a null open (unknown) boundary.
            var startsBeforeEnd = IsUnknownBoundary(right.low, right.lowClosed) || IsUnknownBoundary(left.high, left.highClosed)
                ? RangeGreaterOrEqual(HighBoundaryRange(left), LowBoundaryRange(right), null)
                : !(Comparer.Compare(right.low ?? MinValue<T>()!, left.high ?? MaxValue<T>()!, null) > 0);
            var endsAfterStart = IsUnknownBoundary(left.low, left.lowClosed) || IsUnknownBoundary(right.high, right.highClosed)
                ? RangeLessOrEqual(LowBoundaryRange(left), HighBoundaryRange(right), null)
                : !(Comparer.Compare(left.low ?? MinValue<T>()!, right.high ?? MaxValue<T>()!, null) > 0);
            if (AndAllowingUnknown(startsBeforeEnd, endsAfterStart) != true)
                return null;

            var (lowValue, lowClosed) = IsUnknownBoundary(left.low, left.lowClosed) || IsUnknownBoundary(right.low, right.lowClosed)
                ? LaterUncertainLowBoundary(left, right)
                : LaterLowBoundary(left, right);
            var (highValue, highClosed) = IsUnknownBoundary(left.high, left.highClosed) || IsUnknownBoundary(right.high, right.highClosed)
                ? EarlierUncertainHighBoundary(left, right)
                : EarlierHighBoundary(left, right);

            return new CqlInterval<T>(lowValue, highValue, lowClosed, highClosed);
        }

        // The later of two known low boundaries; a null (closed) low boundary is the minimum value.
        private (T? value, bool closed) LaterLowBoundary<T>(CqlInterval<T> left, CqlInterval<T> right) =>
            Comparer.Compare(left.low ?? MinValue<T>()!, right.low ?? MinValue<T>()!, null) switch
            {
                > 0 => (left.low, left.lowClosed ?? false),
                0   => (left.low, (left.lowClosed ?? false) && (right.lowClosed ?? false)),
                _   => (right.low, right.lowClosed ?? false),
            };

        // The earlier of two known high boundaries; a null (closed) high boundary is the maximum value.
        private (T? value, bool closed) EarlierHighBoundary<T>(CqlInterval<T> left, CqlInterval<T> right) =>
            Comparer.Compare(left.high ?? MaxValue<T>()!, right.high ?? MaxValue<T>()!, null) switch
            {
                < 0 => (left.high, left.highClosed ?? false),
                0   => (left.high, (left.highClosed ?? false) && (right.highClosed ?? false)),
                _   => (right.high, right.highClosed ?? false),
            };

        // The later of two low boundaries at least one of which is unknown: the boundary that is not earlier
        // than any value the other can take, or an unknown (null open) boundary when that depends on the
        // unknown value. When neither can be earlier than the other (the unknown boundary's range collapses
        // to the known boundary's value) the known boundary is taken, so the result does not depend on the
        // order of the arguments.
        private (T? value, bool closed) LaterUncertainLowBoundary<T>(CqlInterval<T> left, CqlInterval<T> right)
        {
            var leftRange = LowBoundaryRange(left);
            var rightRange = LowBoundaryRange(right);
            var leftIsLater = RangeGreaterOrEqual(leftRange, rightRange, null) == true;
            var rightIsLater = RangeLessOrEqual(leftRange, rightRange, null) == true;
            if (leftIsLater && rightIsLater)
                return !IsUnknownBoundary(left.low, left.lowClosed) ? (left.low, left.lowClosed ?? false) : (right.low, right.lowClosed ?? false);
            if (leftIsLater)
                return (left.low, left.lowClosed ?? false);
            if (rightIsLater)
                return (right.low, right.lowClosed ?? false);
            return (default, false);
        }

        // The earlier of two high boundaries at least one of which is unknown: the boundary that is not later
        // than any value the other can take, or an unknown (null open) boundary when that depends on the
        // unknown value. When neither can be later than the other (the unknown boundary's range collapses
        // to the known boundary's value) the known boundary is taken, so the result does not depend on the
        // order of the arguments.
        private (T? value, bool closed) EarlierUncertainHighBoundary<T>(CqlInterval<T> left, CqlInterval<T> right)
        {
            var leftRange = HighBoundaryRange(left);
            var rightRange = HighBoundaryRange(right);
            var leftIsEarlier = RangeLessOrEqual(leftRange, rightRange, null) == true;
            var rightIsEarlier = RangeGreaterOrEqual(leftRange, rightRange, null) == true;
            if (leftIsEarlier && rightIsEarlier)
                return !IsUnknownBoundary(left.high, left.highClosed) ? (left.high, left.highClosed ?? false) : (right.high, right.highClosed ?? false);
            if (leftIsEarlier)
                return (left.high, left.highClosed ?? false);
            if (rightIsEarlier)
                return (right.high, right.highClosed ?? false);
            return (default, false);
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

            // A definite adjacency on either side decides true; otherwise an uncertain candidate leaves the
            // result unknown.
            var meetsBefore = MeetsAt(Boundary<T>.HighOf(left), Boundary<T>.LowOf(right), precision, predecessor);
            if (meetsBefore == true)
                return true;

            return OrAllowingUnknown(meetsBefore, MeetsAt(Boundary<T>.HighOf(right), Boundary<T>.LowOf(left), precision, predecessor));
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

            // The first interval starts where the second one ends.
            return MeetsAt(Boundary<T>.HighOf(right), Boundary<T>.LowOf(left), precision, predecessor);
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

        private bool? MeetsBeforeHelper<T>(CqlInterval<T> left, CqlInterval<T> right, string? precision, Func<T, T> predecessor)
        {
            if (left == null || right == null)
                return null;

            // The first interval ends where the second one starts.
            return MeetsAt(Boundary<T>.HighOf(left), Boundary<T>.LowOf(right), precision, predecessor);
        }

        /// <summary>
        /// Whether an interval ending at <paramref name="end"/> meets one starting at <paramref name="start"/>: the end
        /// is the start itself or its predecessor. The predecessor is only computed when the direct comparison does not
        /// already decide it. Nothing precedes the minimum, and the predecessor of an unknown start ranges over the
        /// predecessors of the values the start can take.
        /// </summary>
        private bool? MeetsAt<T>(Boundary<T> end, Boundary<T> start, string? precision, Func<T, T> predecessor)
        {
            var same = IsSame(end, start, precision);
            if (same == true)
                return true;

            bool? precedes = start.Kind switch
            {
                BoundaryKind.Value   => predecessor(start.Value!) is { } value ? IsSame(end, Boundary<T>.Of(value), precision) : false,
                BoundaryKind.Unknown => IsSame(end, Boundary<T>.UnknownBetween(PredecessorOrExtreme(start.RangeLow, predecessor), PredecessorOrExtreme(start.RangeHigh, predecessor)), precision),
                _                    => false,
            };
            return OrAllowingUnknown(same, precedes);
        }

        /// <summary>The predecessor of a range bound; a bound at an extreme (<c>null</c>) or without a predecessor stays at the extreme.</summary>
        private static T? PredecessorOrExtreme<T>(T? bound, Func<T, T> predecessor) =>
            bound is { } value ? predecessor(value) : default;

        #endregion

        #region Same As

        public bool? SameAs<T>(CqlInterval<T> @this, CqlInterval<T> other, string? precision)
        {
            if (@this == null || other == null)
                return null;

            // An indeterminate comparison, such as between intervals sharing an unknown boundary, stays unknown.
            return Comparer.Compare(@this, other, precision) switch
            {
                null => null,
                0    => true,
                _    => false,
            };
        }

        #endregion

        #region On/Same Or After

        public bool? SameOrAfter(CqlInterval<int?> @this, CqlInterval<int?> other)
            => IntervalSameOrAfterHelper(@this, other, null, ToClosed);
        public bool? SameOrAfter(CqlInterval<long?> @this, CqlInterval<long?> other)
            => IntervalSameOrAfterHelper(@this, other, null, ToClosed);
        public bool? SameOrAfter(CqlInterval<decimal?> @this, CqlInterval<decimal?> other)
            => IntervalSameOrAfterHelper(@this, other, null, ToClosed);
        public bool? SameOrAfter(CqlInterval<CqlQuantity?> @this, CqlInterval<CqlQuantity?> other)
            => IntervalSameOrAfterHelper(@this, other, null, ToClosed);

        public bool? SameOrAfter(CqlInterval<CqlDate?>? @this, CqlInterval<CqlDate?>? other, string? precision)
        {
            if (@this == null || other == null)
                return null;

            // Only the compared boundaries take part: the first interval's start and the second one's end.
            if (precision != null
                && (GreaterOrSamePrecision(@this.low!, precision) == false
                    || GreaterOrSamePrecision(other.high!, precision) == false))
                return null;

            return IntervalSameOrAfterHelper(@this, other, precision, ToClosed);
        }

        public bool? SameOrAfter(CqlInterval<CqlDateTime?>? @this, CqlInterval<CqlDateTime?>? other, string? precision)
        {
            if (@this == null || other == null)
                return null;

            // Only the compared boundaries take part: the first interval's start and the second one's end.
            if (precision != null
                && (GreaterOrSamePrecision(@this.low!, precision) == false
                    || GreaterOrSamePrecision(other.high!, precision) == false))
                return null;

            return IntervalSameOrAfterHelper(@this, other, precision, ToClosed);
        }

        public bool? SameOrAfter(CqlInterval<CqlTime?>? @this, CqlInterval<CqlTime?>? other, string? precision)
        {
            if (@this == null || other == null)
                return null;

            // Only the compared boundaries take part: the first interval's start and the second one's end.
            if (precision != null
                && (GreaterOrSamePrecision(@this.low!, precision) == false
                    || GreaterOrSamePrecision(other.high!, precision) == false))
                return null;

            return IntervalSameOrAfterHelper(@this, other, precision, ToClosed);
        }

        private bool? IntervalSameOrAfterHelper<T>(CqlInterval<T?>? @this,
            CqlInterval<T?>? other,
            string? precision,
            Func<CqlInterval<T?>?, CqlInterval<T?>?> toClosed)
        {
            if (@this == null || other == null)
                return null;

            var thisClosed = toClosed(@this)!;
            var otherClosed = toClosed(other)!;

            // The first interval starts on or after the second one ends, under Start/End semantics.
            return IsAtOrAfter(Boundary<T?>.LowOf(thisClosed), Boundary<T?>.HighOf(otherClosed), precision);
        }

        #endregion

        #region On/Same Or Before

        public bool? SameOrBefore(CqlInterval<int?> @this, CqlInterval<int?> other)
            => IntervalSameOrBeforeHelper(@this, other, null, ToClosed);
        public bool? SameOrBefore(CqlInterval<long?> @this, CqlInterval<long?> other)
            => IntervalSameOrBeforeHelper(@this, other, null, ToClosed);
        public bool? SameOrBefore(CqlInterval<decimal?> @this, CqlInterval<decimal?> other)
            => IntervalSameOrBeforeHelper(@this, other, null, ToClosed);
        public bool? SameOrBefore(CqlInterval<CqlQuantity?> @this, CqlInterval<CqlQuantity?> other)
            => IntervalSameOrBeforeHelper(@this, other, null, ToClosed);
        public bool? SameOrBefore(CqlInterval<CqlDate?>? @this, CqlInterval<CqlDate?>? other, string? precision)
        {
            if (@this is null || other is null)
                return null;

            // Only the compared boundaries take part: the first interval's end and the second one's start.
            if (precision != null
                && (GreaterOrSamePrecision(@this.high!, precision) == false
                    || GreaterOrSamePrecision(other.low!, precision) == false))
                return null;

            return IntervalSameOrBeforeHelper(@this, other, precision, ToClosed);
        }

        public bool? SameOrBefore(CqlInterval<CqlDateTime?>? @this, CqlInterval<CqlDateTime?>? other, string? precision)
        {
            if (@this == null || other == null)
                return null;

            // Only the compared boundaries take part: the first interval's end and the second one's start.
            if (precision != null
                && (GreaterOrSamePrecision(@this.high!, precision) == false
                    || GreaterOrSamePrecision(other.low!, precision) == false))
                return null;

            return IntervalSameOrBeforeHelper(@this, other, precision, ToClosed);
        }

        public bool? SameOrBefore(CqlInterval<CqlTime?>? @this, CqlInterval<CqlTime?>? other, string? precision)
        {
            if (@this == null || other == null)
                return null;

            // Only the compared boundaries take part: the first interval's end and the second one's start.
            if (precision != null
                && (GreaterOrSamePrecision(@this.high!, precision) == false
                    || GreaterOrSamePrecision(other.low!, precision) == false))
                return null;

            return IntervalSameOrBeforeHelper(@this, other, precision, ToClosed);
        }


        private bool? IntervalSameOrBeforeHelper<T>(CqlInterval<T?>? @this,
            CqlInterval<T?>? other,
            string? precision,
            Func<CqlInterval<T?>?, CqlInterval<T?>?> toClosed)
        {
            if (@this == null || other == null)
                return null;

            var thisClosed = toClosed(@this)!;
            var otherClosed = toClosed(other)!;

            // The first interval ends on or before the second one starts, under Start/End semantics.
            return IsAtOrBefore(Boundary<T?>.HighOf(thisClosed), Boundary<T?>.LowOf(otherClosed), precision);
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

            // "if the ending point of the first interval is greater than or equal to the starting point of the
            // second interval, and the starting point of the first interval is less than or equal to the ending
            // point of the second interval" (CQL 1.5.3 Errata 2, Appendix B - CQL Reference, section "Overlaps").
            var startsBeforeEnd = IsAtOrAfter(Boundary<T?>.HighOf(left), Boundary<T?>.LowOf(right), precision);
            var endsAfterStart = IsAtOrBefore(Boundary<T?>.LowOf(left), Boundary<T?>.HighOf(right), precision);

            return AndAllowingUnknown(startsBeforeEnd, endsAfterStart);
        }

        /// <summary>
        /// Returns whether the interval boundary is unknown: a null boundary that is not
        /// closed cannot be interpreted as the minimum or maximum value of the type.
        /// </summary>
        private static bool IsUnknownBoundary<T>(T? value, bool? closed) =>
            value is null && !(closed ?? false);

        /// <summary>
        /// The possible values of an interval's low boundary: a single value when known
        /// (a null closed boundary being the minimum), or - when unknown - anything from
        /// the minimum up to the interval's high boundary.
        /// </summary>
        private (T min, T max) LowBoundaryRange<T>(CqlInterval<T> interval)
        {
            if (IsUnknownBoundary(interval.low, interval.lowClosed))
                return (MinValue<T>(), interval.high is { } high ? high : MaxValue<T>());

            var low = interval.low is { } value ? value : MinValue<T>();
            return (low, low);
        }

        /// <summary>
        /// The possible values of an interval's high boundary: a single value when known
        /// (a null closed boundary being the maximum), or - when unknown - anything from
        /// the interval's low boundary up to the maximum.
        /// </summary>
        private (T min, T max) HighBoundaryRange<T>(CqlInterval<T> interval)
        {
            if (IsUnknownBoundary(interval.high, interval.highClosed))
                return (interval.low is { } low ? low : MinValue<T>(), MaxValue<T>());

            var high = interval.high is { } value ? value : MaxValue<T>();
            return (high, high);
        }

        // Three-valued comparisons over boundary ranges: true when every possible value
        // satisfies the comparison, false when none does, null otherwise.
        private bool? RangeGreaterOrEqual<T>((T min, T max) x, (T min, T max) y, string? precision)
        {
            if (Comparer.Compare(x.min!, y.max!, precision) >= 0) return true;
            if (Comparer.Compare(x.max!, y.min!, precision) < 0) return false;
            return null;
        }

        private bool? RangeLessOrEqual<T>((T min, T max) x, (T min, T max) y, string? precision)
        {
            if (Comparer.Compare(x.max!, y.min!, precision) <= 0) return true;
            if (Comparer.Compare(x.min!, y.max!, precision) > 0) return false;
            return null;
        }

        private bool? RangeEqual<T>((T min, T max) x, (T min, T max) y, string? precision) =>
            AndAllowingUnknown(RangeLessOrEqual(x, y, precision), RangeGreaterOrEqual(x, y, precision));

        private bool? RangeGreaterThan<T>((T min, T max) x, (T min, T max) y, string? precision)
        {
            if (Comparer.Compare(x.min!, y.max!, precision) > 0) return true;
            if (Comparer.Compare(x.max!, y.min!, precision) <= 0) return false;
            return null;
        }

        private bool? RangeLessThan<T>((T min, T max) x, (T min, T max) y, string? precision)
        {
            if (Comparer.Compare(x.max!, y.min!, precision) < 0) return true;
            if (Comparer.Compare(x.min!, y.max!, precision) >= 0) return false;
            return null;
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

            // A null closed low boundary is the minimum value and a null closed high boundary
            // the maximum (see #1356: these substitutions used to be inverted, so intervals
            // with an unbounded end never overlapped after anything).
            var startsBeforeEnd = IsAtOrBefore(Boundary<T?>.LowOf(left), Boundary<T?>.HighOf(right), precision);
            var endsAfterEnd = IsAfter(Boundary<T?>.HighOf(left), Boundary<T?>.HighOf(right), precision);

            return AndAllowingUnknown(startsBeforeEnd, endsAfterEnd);
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

            var endsAfterStart = IsAtOrAfter(Boundary<T?>.HighOf(left!), Boundary<T?>.LowOf(right!), precision);
            var startsBeforeStart = IsBefore(Boundary<T?>.LowOf(left!), Boundary<T?>.LowOf(right!), precision);

            return AndAllowingUnknown(endsAfterStart, startsBeforeStart);
        }

        #endregion

        #region Point from

        // A unit interval is one whose effective start and end are the same point, so both the unit test
        // and the extracted point use the effective boundaries: "define \"PointFromExclusive\":
        // point from Interval[4, 5) // 4" (CQL 1.5.3 Errata 2, Appendix B - CQL Reference, section
        // "Point From").
        public T? PointFrom<T>(CqlInterval<T?>? argument)
        {
            if (argument == null)
                return default;

            var closed = ToClosedBoundaries(argument)!;

            // A null open boundary is unknown, so the interval has no known point.
            if (IsUnknownBoundary(closed.low, closed.lowClosed) || IsUnknownBoundary(closed.high, closed.highClosed))
                return default;

            // A null closed boundary is the minimum or maximum value of the point type, so an
            // interval with two of them spans the whole domain and is never a unit interval.
            if (closed.low is not null || closed.high is not null)
            {
                var start = closed.low ?? MinValue<T?>();
                var end = closed.high ?? MaxValue<T?>();
                if (Comparer.Compare(start!, end!, null) == 0)
                    return start;
            }

            throw new CqlException<CqlPointFromNonUnitIntervalError>(
                new(argument.low, argument.high, argument.lowClosed ?? false, argument.highClosed ?? false));
        }

        #endregion

        #region Properly Includes/Included In

        public bool? IntervalProperlyIncludedInInterval<T>(CqlInterval<T>? left, CqlInterval<T>? right, string? precision)
        {
            if (left == null || right == null)
                return null;

            // Only the nullable point forms can carry an unknown boundary, which the normalisation
            // below may produce, so a non-nullable numeric interval is evaluated in its nullable form.
            switch (left, right)
            {
                case (CqlInterval<int> l, CqlInterval<int> r):
                    return IntervalProperlyIncludedInInterval(ToNullablePoints(l), ToNullablePoints(r), precision);
                case (CqlInterval<long> l, CqlInterval<long> r):
                    return IntervalProperlyIncludedInInterval(ToNullablePoints(l), ToNullablePoints(r), precision);
                case (CqlInterval<decimal> l, CqlInterval<decimal> r):
                    return IntervalProperlyIncludedInInterval(ToNullablePoints(l), ToNullablePoints(r), precision);
            }

            // An open boundary with a value is the successor or predecessor of that value under
            // Start/End semantics, so both operands are normalised to closed boundaries first;
            // [1, 10] and (0, 11) then compare as the same interval.
            left = ToClosedBoundaries(left)!;
            right = ToClosedBoundaries(right)!;

            var lowIncluded = IsAtOrBefore(Boundary<T>.LowOf(right), Boundary<T>.LowOf(left), precision);
            var highIncluded = IsAtOrAfter(Boundary<T>.HighOf(right), Boundary<T>.HighOf(left), precision);

            // Complete inclusion is only proper inclusion when the two are not the same interval.
            return AndAllowingUnknown(lowIncluded, highIncluded) switch
            {
                true => SameInterval(left, right, precision) switch
                {
                    true  => false,
                    false => true,
                    null  => null,
                },
                var included => included,
            };
        }

        public bool? IntervalProperlyIncludesInterval<T>(CqlInterval<T>? left, CqlInterval<T>? right, string? precision) =>
            IntervalProperlyIncludedInInterval(right, left, precision);

        /// <summary>
        /// Whether both intervals cover the same range under Start/End semantics: equal boundary
        /// values - a null closed boundary being the minimum or maximum value of the point type -
        /// and equal closedness on both ends. An unknown boundary leaves the answer indeterminate.
        /// </summary>
        private bool? SameInterval<T>(CqlInterval<T> left, CqlInterval<T> right, string? precision)
        {
            // Each end is compared on its own, so a definite difference on one end decides the answer
            // even when the other end is unknown.
            var sameLow = IsSame(Boundary<T>.LowOf(left), Boundary<T>.LowOf(right), precision);
            var sameHigh = IsSame(Boundary<T>.HighOf(left), Boundary<T>.HighOf(right), precision);
            return AndAllowingUnknown(sameLow, sameHigh);
        }

        /// <summary>
        /// Whether both boundaries of the interval are known once it is normalised to closed
        /// boundaries, so that it covers a representable range rather than an unknown or
        /// unbounded one.
        /// </summary>
        private bool HasKnownBoundaries<T>(CqlInterval<T>? interval) =>
            ToClosedBoundaries(interval) is { low: not null, high: not null };

        /// <summary>
        /// Normalises an interval's open boundaries with a value to their closed equivalent
        /// (successor for the low boundary, predecessor for the high boundary) for every point
        /// type that has a successor and predecessor. A null open boundary stays open, since it is
        /// unknown; an interval over any other point type is returned as is.
        /// </summary>
        private CqlInterval<T>? ToClosedBoundaries<T>(CqlInterval<T>? interval) =>
            interval switch
            {
                null                          => null,
                CqlInterval<int?> i           => (CqlInterval<T>?)(object?)ToClosed(i),
                CqlInterval<long?> i          => (CqlInterval<T>?)(object?)ToClosed(i),
                CqlInterval<decimal?> i       => (CqlInterval<T>?)(object?)ToClosed(i),
                CqlInterval<CqlQuantity?> i   => (CqlInterval<T>?)(object?)ToClosed(i),
                CqlInterval<CqlDate?> i       => (CqlInterval<T>?)(object?)ToClosed(i),
                CqlInterval<CqlDateTime?> i   => (CqlInterval<T>?)(object?)ToClosed(i),
                CqlInterval<CqlTime?> i       => (CqlInterval<T>?)(object?)ToClosed(i),
                _                             => interval,
            };

        private static CqlInterval<T?> ToNullablePoints<T>(CqlInterval<T> interval) where T : struct =>
            new(interval.low, interval.high, interval.lowClosed, interval.highClosed);

        public bool? ElementProperlyIncludedInInterval<T>(T left, CqlInterval<T>? right)
        {
            if (left == null || right == null || right.low == null || right.high == null)
                return null;

            // The interval's boundaries are its effective ones - see the interval-interval overload above.
            right = ToClosedForPointType(right)!;

            var low = Comparer.Compare(left, right.low, null);
            var high = Comparer.Compare(left, right.high, null);
            if (low < 0)
                return false;
            if (high > 0)
                return false;
            // an element is only properly contained if it is not equal to either endpoint
            if (low == 0 || high == 0)
                return false;
            return true;
        }

        public bool? ElementProperlyIncludedInInterval(CqlDate left, CqlInterval<CqlDate>? right, string? precision)
        {
            if (left == null || right == null || right.low == null || right.high == null)
                return null;

            if (precision == null && (SamePrecision(left, right.high) == false || SamePrecision(left, right.low) == false))
                return null;
            else if (GreaterOrSamePrecision(left, precision) == false
                    || GreaterOrSamePrecision(right.low, precision) == false
                    || GreaterOrSamePrecision(right.high, precision) == false)
                return null;

            // The interval's boundaries are its effective ones - see the interval-interval overload above.
            // The precision guards above are applied to the operand as given: closing a date/time boundary
            // steps it by one unit of its own precision and so preserves that precision either way.
            right = ToClosedForPointType(right)!;

            var low = Comparer.Compare(left, right.low, precision);
            var high = Comparer.Compare(left, right.high, precision);
            if (low < 0)
                return false;
            if (high > 0)
                return false;
            // interval is a unit interval containing only the point
            if (low == 0 && high == 0)
                return false;
            return true;
        }


        public bool? ElementProperlyIncludedInInterval(CqlDateTime left, CqlInterval<CqlDateTime>? right, string? precision)
        {
            if (left == null || right == null || right.low == null || right.high == null)
                return null;

            if (precision == null && (SamePrecision(left, right.high) == false || SamePrecision(left, right.low) == false))
                return null;
            else if (GreaterOrSamePrecision(left, precision) == false
                    || GreaterOrSamePrecision(right.low, precision) == false
                    || GreaterOrSamePrecision(right.high, precision) == false)
                return null;

            // The interval's boundaries are its effective ones - see the interval-interval overload above.
            // The precision guards above are applied to the operand as given: closing a date/time boundary
            // steps it by one unit of its own precision and so preserves that precision either way.
            right = ToClosedForPointType(right)!;

            var low = Comparer.Compare(left, right.low, precision);
            var high = Comparer.Compare(left, right.high, precision);
            if (low < 0)
                return false;
            if (high > 0)
                return false;
            // interval is a unit interval containing only the point
            if (low == 0 && high == 0)
                return false;
            return true;
        }

        public bool? ElementProperlyIncludedInInterval(CqlTime left, CqlInterval<CqlTime>? right, string? precision)
        {
            if (left == null || right == null || right.low == null || right.high == null)
                return null;

            if (precision == null && (SamePrecision(left, right.high) == false || SamePrecision(left, right.low) == false))
                return null;

            else if (GreaterOrSamePrecision(left, precision) == false
                     || GreaterOrSamePrecision(right.low, precision) == false
                     || GreaterOrSamePrecision(right.high, precision) == false)
                return null;

            // The interval's boundaries are its effective ones - see the interval-interval overload above.
            // The precision guards above are applied to the operand as given: closing a date/time boundary
            // steps it by one unit of its own precision and so preserves that precision either way.
            right = ToClosedForPointType(right)!;

            var low = Comparer.Compare(left, right.low, precision);
            var high = Comparer.Compare(left, right.high, precision);
            if (low < 0)
                return false;
            if (high > 0)
                return false;
            // properly contains requires the element not equal either endpoint
            if (low == 0 || high == 0)
                return false;
            return true;
        }


        public bool? IntervalProperlyIncludesElement<T>(CqlInterval<T>? left, T right) =>
            ElementProperlyIncludedInInterval(right, left);

        public bool? IntervalProperlyIncludesElement(CqlInterval<CqlDate>? left, CqlDate right, string? precision) =>
            ElementProperlyIncludedInInterval(right, left, precision);

        public bool? IntervalProperlyIncludesElement(CqlInterval<CqlDateTime>? left, CqlDateTime right, string? precision) =>
            ElementProperlyIncludedInInterval(right, left, precision);

        public bool? IntervalProperlyIncludesElement(CqlInterval<CqlTime>? left, CqlTime right, string? precision) =>
            ElementProperlyIncludedInInterval(right, left, precision);


        #endregion

        #region Size

        public int? IntervalSize(CqlInterval<int?>? argument)
        {
            var minimum = MinValue<int>();
            var pointSize = Subtract(Successor(minimum), minimum);
            var closed = ToClosed(argument);
            if (closed == null) return default(int);
            return Add(Subtract(closed.high ?? MaxValue<int>(), closed.low ?? MinValue<int>()), pointSize);
        }

        public decimal? IntervalSize(CqlInterval<decimal?>? argument)
        {
            var minimum = MinValue<decimal>();
            var pointSize = Subtract(Successor(minimum), minimum);
            var closed = ToClosed(argument);
            if (closed == null)
                return default(decimal);
            return Add(Subtract(closed.high ?? MaxValue<decimal>(), closed.low ?? MinValue<decimal>()), pointSize);
        }
        public long? IntervalSize(CqlInterval<long?>? argument)
        {
            var minimum = MinValue<long>();
            var pointSize = Subtract(Successor(minimum), minimum);
            var closed = ToClosed(argument);
            if (closed == null)
                return default(long);
            return Add(Subtract(closed.high ?? MaxValue<long>(), closed.low ?? MinValue<long>()), pointSize);
        }

        #endregion

        #region Start

        public int? Start(CqlInterval<int?>? argument)
        {
            if (argument == null)
                return null;

            var isLowClosed = argument.lowClosed ?? false;
            if (argument.low == null && !isLowClosed)
                return null;

            if (isLowClosed)
                return argument.low ?? MinValue<int?>();
            else return Successor(argument.low);
        }
        public long? Start(CqlInterval<long?>? argument)
        {
            if (argument == null)
                return null;

            var isLowClosed = argument.lowClosed ?? false;
            if (argument.low == null && !isLowClosed)
                return null;

            if (isLowClosed)
                return argument.low ?? MinValue<long?>();
            else return Successor(argument.low);
        }
        public decimal? Start(CqlInterval<decimal?>? argument)
        {
            if (argument == null)
                return null;

            var isLowClosed = argument.lowClosed ?? false;
            if (argument.low == null && !isLowClosed)
                return null;

            if (isLowClosed)
                return argument.low ?? MinValue<decimal?>();
            else return Successor(argument.low);
        }
        public CqlQuantity? Start(CqlInterval<CqlQuantity?>? argument)
        {
            if (argument == null)
                return null;

            var isLowClosed = argument.lowClosed ?? false;
            if (argument.low == null && !isLowClosed)
                return null;

            if (isLowClosed)
                return argument.low ?? MinValue<CqlQuantity?>();
            else return Successor(argument.low);
        }

        public CqlDate? Start(CqlInterval<CqlDate?>? argument)
        {
            if (argument == null)
                return null;

            var isLowClosed = argument.lowClosed ?? false;
            if (argument.low == null && !isLowClosed)
                return null;

            if (isLowClosed)
                return argument.low ?? MinValue<CqlDate?>();
            else return Successor(argument.low);
        }
        public CqlDateTime? Start(CqlInterval<CqlDateTime?>? argument)
        {
            if (argument == null)
                return null;

            var isLowClosed = argument.lowClosed ?? false;
            if (argument.low == null && !isLowClosed)
                return null;

            if (isLowClosed)
                return argument.low ?? MinValue<CqlDateTime?>();
            else return Successor(argument.low);
        }
        public CqlTime? Start(CqlInterval<CqlTime?>? argument)
        {
            if (argument == null)
                return null;

            var isLowClosed = argument.lowClosed ?? false;
            if (argument.low == null && !isLowClosed)
                return null;

            if (isLowClosed)
                return argument.low ?? MinValue<CqlTime?>();
            else return Successor(argument.low);
        }

        #endregion

        #region Starts

        public bool? Starts<T>(CqlInterval<T>? starts, CqlInterval<T>? other, string? precision)
        {
            if (starts == null || other == null)
                return null;

            // "This operator uses the semantics described in the start and end operators to determine
            // interval boundaries." (CQL 1.5.3 Errata 2, Appendix B - CQL Reference, section "Starts"), so
            // an exclusive boundary is compared as the effective one - a step inward at the boundary's own
            // precision - not as the raw endpoint. Interval(@2026-01-01, @2026-01-02] starts
            // Interval[@2026-01-01, @2026-01-03] would otherwise be true on its raw low boundary, even
            // though its effective start is @2026-01-02.
            starts = ToClosedBoundaries(starts)!;
            other = ToClosedBoundaries(other)!;

            var sameStart = IsSame(Boundary<T>.LowOf(starts), Boundary<T>.LowOf(other), precision);
            var endsNoLater = IsAtOrBefore(Boundary<T>.HighOf(starts), Boundary<T>.HighOf(other), precision);

            return AndAllowingUnknown(sameStart, endsNoLater);
        }

        #endregion

        #region Union

        public CqlInterval<T>? Union<T>(CqlInterval<T>? left, CqlInterval<T>? right)
        {
            if (left == null || right == null) return null;

            // Detecting intervals that meet (see #1359) requires the point-type specific
            // ToClosed and Successor overloads; dispatch on the runtime point type.
            object? unioned = (left, right) switch
            {
                (CqlInterval<int?> l, CqlInterval<int?> r) => (object?)IntervalUnionHelper(l, r, ToClosed, Successor),
                (CqlInterval<long?> l, CqlInterval<long?> r) => IntervalUnionHelper(l, r, ToClosed, Successor),
                (CqlInterval<decimal?> l, CqlInterval<decimal?> r) => IntervalUnionHelper(l, r, ToClosed, Successor),
                (CqlInterval<CqlQuantity?> l, CqlInterval<CqlQuantity?> r) => IntervalUnionHelper(l, r, ToClosed, Successor),
                (CqlInterval<CqlDate?> l, CqlInterval<CqlDate?> r) => IntervalUnionHelper(l, r, ToClosed, Successor),
                (CqlInterval<CqlDateTime?> l, CqlInterval<CqlDateTime?> r) => IntervalUnionHelper(l, r, ToClosed, Successor),
                (CqlInterval<CqlTime?> l, CqlInterval<CqlTime?> r) => IntervalUnionHelper(l, r, ToClosed, Successor),
                _ => IntervalUnionHelper(left, right, static interval => interval, successor: null),
            };
            return (CqlInterval<T>?)unioned;
        }

        private CqlInterval<T>? IntervalUnionHelper<T>(
            CqlInterval<T>? left,
            CqlInterval<T>? right,
            Func<CqlInterval<T>?, CqlInterval<T>?> toClosed,
            Func<T, T>? successor)
        {
            if (left == null || right == null) return null;
            left = toClosed(left)!;
            right = toClosed(right)!;

            // A null open boundary is unknown, so where the union starts or ends has no answer.
            if (IsUnknownBoundary(left.low, left.lowClosed) || IsUnknownBoundary(left.high, left.highClosed)
                || IsUnknownBoundary(right.low, right.lowClosed) || IsUnknownBoundary(right.high, right.highClosed))
                return null;

            // Order the intervals so that 'first' starts on or before 'second';
            // a null low boundary is the minimum value.
            var (first, second) =
                Comparer.Compare(left.low ?? MinValue<T>()!, right.low ?? MinValue<T>()!, null) <= 0
                    ? (left, right)
                    : (right, left);

            // The union exists when the intervals overlap or meet. A null high boundary is
            // the maximum value, which trivially overlaps; otherwise the intervals meet when
            // the successor of the first interval's high boundary reaches the second
            // interval's low boundary. The successor is only computed when the overlap check
            // fails, so it can never be asked for the successor of the maximum value.
            var secondLow = second.low ?? MinValue<T>()!;
            bool overlapsOrMeets =
                first.high is not { } firstHigh
                || Comparer.Compare(firstHigh, secondLow, null) >= 0
                || (successor is not null && Comparer.Compare(successor(firstHigh)!, secondLow, null) == 0);

            if (!overlapsOrMeets)
                return null;

            // The result runs from the first interval's low boundary to the later of the
            // two high boundaries; a null high boundary is the maximum value.
            var highSide = first.high is { } high
                ? second.high is { } otherHigh && Comparer.Compare(high, otherHigh, null) >= 0 ? first : second
                : first;

            return new CqlInterval<T>(first.low, highSide.high, first.lowClosed, highSide.highClosed);
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

        /// <summary>
        /// Normalizes an interval to its effective boundaries - the ones the Start and End operators
        /// return - by dispatching to the <see cref="ToClosed(CqlInterval{int?}?)"/> overload for the
        /// runtime point type. An operator over an unconstrained point type cannot call ToClosed
        /// directly, because closing a boundary needs that point type's predecessor and successor.
        /// An interval over a point type that has neither - for which Start and End are not defined
        /// either - is returned unchanged.
        /// </summary>
        private CqlInterval<T>? ToClosedForPointType<T>(CqlInterval<T>? interval)
        {
            object? closed = interval switch
            {
                null                        => null,
                CqlInterval<int?> i         => (object?)ToClosed(i),
                CqlInterval<long?> i        => ToClosed(i),
                CqlInterval<decimal?> i     => ToClosed(i),
                CqlInterval<CqlQuantity?> i => ToClosed(i),
                CqlInterval<CqlDate?> i     => ToClosed(i),
                CqlInterval<CqlDateTime?> i => ToClosed(i),
                CqlInterval<CqlTime?> i     => ToClosed(i),
                _                           => interval,
            };
            return (CqlInterval<T>?)closed;
        }

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

            // An open boundary whose successor or predecessor cannot be represented (the value is
            // already the maximum or minimum of the type) has no known closed equivalent and stays
            // open and null, so it is treated as unknown rather than as the opposite extreme.
            T newLow, newHigh;
            if (!(interval.lowClosed ?? false))
            {
                if (interval.low != null)
                {
                    newLow = successor(interval.low);
                    if (newLow is null)
                        lowClosed = false;
                }
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
                {
                    newHigh = predecessor(interval.high);
                    if (newHigh is null)
                        highClosed = false;
                }
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
