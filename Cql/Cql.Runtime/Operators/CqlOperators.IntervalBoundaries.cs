/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Primitives;

namespace Hl7.Cql.Operators
{
    /// <summary>
    /// What an interval boundary stands for once the interval is normalised to its effective boundaries
    /// (the values the Start and End operators return).
    /// </summary>
    internal enum BoundaryKind
    {
        /// <summary>A boundary with a value.</summary>
        Value,

        /// <summary>A closed low boundary without a value: the minimum value of the point type.</summary>
        Minimum,

        /// <summary>A closed high boundary without a value: the maximum value of the point type.</summary>
        Maximum,

        /// <summary>
        /// An open boundary without a value: unknown, but constrained to the values its own interval permits
        /// (from the interval's low boundary to the maximum for a high, from the minimum to the interval's
        /// high boundary for a low).
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// An effective interval boundary. Comparisons between boundaries are three-valued: <c>null</c> when the
    /// answer depends on an unknown boundary or on a comparison the comparer cannot decide, such as between
    /// values of different precision that agree at the coarser one. An extreme decides a comparison on its own
    /// wherever it can (nothing is before the minimum or after the maximum), so a value is compared against
    /// the extreme's own value only where the answer really depends on whether the two coincide.
    /// </summary>
    internal readonly struct Boundary<T>
    {
        private Boundary(BoundaryKind kind, T? value, T? rangeLow, T? rangeHigh)
        {
            Kind = kind;
            Value = value;
            RangeLow = rangeLow;
            RangeHigh = rangeHigh;
        }

        public BoundaryKind Kind { get; }

        /// <summary>The boundary's value when <see cref="Kind"/> is <see cref="BoundaryKind.Value"/>.</summary>
        public T? Value { get; }

        /// <summary>
        /// For an unknown boundary, the least value it can take; <c>null</c> is the minimum of the point type.
        /// </summary>
        public T? RangeLow { get; }

        /// <summary>
        /// For an unknown boundary, the greatest value it can take; <c>null</c> is the maximum of the point type.
        /// </summary>
        public T? RangeHigh { get; }

        public static Boundary<T> Of(T value) => new(BoundaryKind.Value, value, default, default);

        public static Boundary<T> Minimum { get; } = new(BoundaryKind.Minimum, default, default, default);

        public static Boundary<T> Maximum { get; } = new(BoundaryKind.Maximum, default, default, default);

        public static Boundary<T> UnknownBetween(T? rangeLow, T? rangeHigh) => new(BoundaryKind.Unknown, default, rangeLow, rangeHigh);

        /// <summary>
        /// The effective low boundary of an interval whose open boundaries with a value are already closed.
        /// </summary>
        public static Boundary<T> LowOf(CqlInterval<T> interval) =>
            interval.low is { } value ? Of(value)
            : interval.lowClosed ?? false ? Minimum
            : UnknownBetween(default, interval.high);

        /// <summary>
        /// The effective high boundary of an interval whose open boundaries with a value are already closed.
        /// </summary>
        public static Boundary<T> HighOf(CqlInterval<T> interval) =>
            interval.high is { } value ? Of(value)
            : interval.highClosed ?? false ? Maximum
            : UnknownBetween(interval.low, default);

        /// <summary>The least boundary an unknown boundary can be; the boundary itself when it is known.</summary>
        public Boundary<T> Least => Kind == BoundaryKind.Unknown ? (RangeLow is { } low ? Of(low) : Minimum) : this;

        /// <summary>The greatest boundary an unknown boundary can be; the boundary itself when it is known.</summary>
        public Boundary<T> Greatest => Kind == BoundaryKind.Unknown ? (RangeHigh is { } high ? Of(high) : Maximum) : this;

        public bool IsUnknown => Kind == BoundaryKind.Unknown;
    }

    internal partial class CqlOperators
    {
        // Three-valued comparisons between effective boundaries. For an unknown boundary the comparison holds
        // when it holds for every value the boundary can take, fails when it fails for every one, and is
        // otherwise unknown.

        /// <summary>Whether <paramref name="left"/> is at or before <paramref name="right"/>.</summary>
        private bool? IsAtOrBefore<T>(Boundary<T> left, Boundary<T> right, string? precision)
        {
            if (left.IsUnknown || right.IsUnknown)
            {
                if (IsAtOrBefore(left.Greatest, right.Least, precision) == true) return true;
                if (IsBefore(right.Greatest, left.Least, precision) == true) return false;
                return null;
            }

            return (left.Kind, right.Kind) switch
            {
                (BoundaryKind.Minimum, _) or (_, BoundaryKind.Maximum) => true,
                (BoundaryKind.Maximum, BoundaryKind.Minimum)           => false,
                (BoundaryKind.Maximum, _)                              => Decide(Comparer.Compare(MaxValue<T>()!, right.Value!, precision), static c => c <= 0),
                (_, BoundaryKind.Minimum)                              => Decide(Comparer.Compare(left.Value!, MinValue<T>()!, precision), static c => c <= 0),
                _                                                      => Decide(Comparer.Compare(left.Value!, right.Value!, precision), static c => c <= 0),
            };
        }

        /// <summary>Whether <paramref name="left"/> is strictly before <paramref name="right"/>.</summary>
        private bool? IsBefore<T>(Boundary<T> left, Boundary<T> right, string? precision)
        {
            if (left.IsUnknown || right.IsUnknown)
            {
                if (IsBefore(left.Greatest, right.Least, precision) == true) return true;
                if (IsAtOrBefore(right.Greatest, left.Least, precision) == true) return false;
                return null;
            }

            return (left.Kind, right.Kind) switch
            {
                (BoundaryKind.Maximum, _) or (_, BoundaryKind.Minimum) => false,
                (BoundaryKind.Minimum, BoundaryKind.Maximum)           => true,
                (BoundaryKind.Minimum, _)                              => Decide(Comparer.Compare(MinValue<T>()!, right.Value!, precision), static c => c < 0),
                (_, BoundaryKind.Maximum)                              => Decide(Comparer.Compare(left.Value!, MaxValue<T>()!, precision), static c => c < 0),
                _                                                      => Decide(Comparer.Compare(left.Value!, right.Value!, precision), static c => c < 0),
            };
        }

        /// <summary>Whether <paramref name="left"/> is at or after <paramref name="right"/>.</summary>
        private bool? IsAtOrAfter<T>(Boundary<T> left, Boundary<T> right, string? precision) =>
            IsAtOrBefore(right, left, precision);

        /// <summary>Whether <paramref name="left"/> is strictly after <paramref name="right"/>.</summary>
        private bool? IsAfter<T>(Boundary<T> left, Boundary<T> right, string? precision) =>
            IsBefore(right, left, precision);

        /// <summary>Whether both boundaries are the same point.</summary>
        private bool? IsSame<T>(Boundary<T> left, Boundary<T> right, string? precision)
        {
            if (left.IsUnknown || right.IsUnknown)
                return AndAllowingUnknown(IsAtOrBefore(left, right, precision), IsAtOrBefore(right, left, precision));

            return (left.Kind, right.Kind) switch
            {
                (BoundaryKind.Minimum, BoundaryKind.Minimum) or (BoundaryKind.Maximum, BoundaryKind.Maximum) => true,
                (BoundaryKind.Minimum, BoundaryKind.Maximum) or (BoundaryKind.Maximum, BoundaryKind.Minimum) => false,
                (BoundaryKind.Minimum, _) => Decide(Comparer.Compare(MinValue<T>()!, right.Value!, precision), static c => c == 0),
                (BoundaryKind.Maximum, _) => Decide(Comparer.Compare(MaxValue<T>()!, right.Value!, precision), static c => c == 0),
                (_, BoundaryKind.Minimum) => Decide(Comparer.Compare(left.Value!, MinValue<T>()!, precision), static c => c == 0),
                (_, BoundaryKind.Maximum) => Decide(Comparer.Compare(left.Value!, MaxValue<T>()!, precision), static c => c == 0),
                _                         => Decide(Comparer.Compare(left.Value!, right.Value!, precision), static c => c == 0),
            };
        }

        /// <summary>
        /// Applies a predicate to a comparison result, keeping an unknown comparison (<c>null</c>) unknown.
        /// </summary>
        private static bool? Decide(int? comparison, Func<int, bool> predicate) =>
            comparison is { } known ? predicate(known) : null;

        private static bool? AndAllowingUnknown(bool? left, bool? right) =>
            (left, right) switch
            {
                (false, _) or (_, false) => false,
                (null, _) or (_, null)   => null,
                _                        => true,
            };

        private static bool? OrAllowingUnknown(bool? left, bool? right) =>
            (left, right) switch
            {
                (true, _) or (_, true) => true,
                (null, _) or (_, null) => null,
                _                      => false,
            };

        /// <summary>
        /// Evaluates <paramref name="formula"/> over the effective boundaries of two normalised intervals. A formula
        /// that combines two comparisons on the same unknown boundary cannot be decided from the range answers of
        /// the comparisons alone: for Interval[1, 1] overlaps after Interval[0, null) the end must be at or after 1
        /// and below 1, which no value satisfies, yet each comparison on its own is unknown over the range. So where
        /// a boundary is unknown the formula is evaluated for every representative value the boundary can take:
        /// the ends of its range and every known boundary of either interval, with its successor and predecessor,
        /// that falls inside the range (and, when both intervals have an unknown boundary, the other's representative
        /// values). A formula built from comparisons and adjacency can only change its answer at those values. The
        /// result is true when the formula holds for every completion, false when it holds for none, and unknown
        /// otherwise or when a comparison cannot be decided. A known boundary of coarser precision than the range's
        /// ends is itself uncertain, so it only yields completions that decidedly lie in the range. A point type
        /// without a successor and predecessor is evaluated over the ranges.
        /// </summary>
        private bool? OverCompletions<T>(
            CqlInterval<T> left,
            CqlInterval<T> right,
            string? precision,
            Func<Boundary<T>, Boundary<T>, Boundary<T>, Boundary<T>, string?, bool?> formula)
        {
            var lowLeft = Boundary<T>.LowOf(left);
            var highLeft = Boundary<T>.HighOf(left);
            var lowRight = Boundary<T>.LowOf(right);
            var highRight = Boundary<T>.HighOf(right);
            var unknowns = (lowLeft.IsUnknown ? 1 : 0) + (highLeft.IsUnknown ? 1 : 0) + (lowRight.IsUnknown ? 1 : 0) + (highRight.IsUnknown ? 1 : 0);
            if (unknowns == 0 || StepsFor<T>() is not { } steps)
                return formula(lowLeft, highLeft, lowRight, highRight, precision);

            var anchors = new List<T>();
            foreach (var boundary in new[] { lowLeft, highLeft, lowRight, highRight })
                if (boundary.Kind == BoundaryKind.Value)
                    anchors.Add(boundary.Value!);

            var lowsLeft = Completions(lowLeft, anchors, steps);
            var highsLeft = Completions(highLeft, anchors, steps);
            var lowsRight = Completions(lowRight, anchors, steps);
            var highsRight = Completions(highRight, anchors, steps);
            if (unknowns > 1)
            {
                foreach (var completions in new[] { lowsLeft, highsLeft, lowsRight, highsRight })
                    foreach (var completion in completions)
                        if (completion.Kind == BoundaryKind.Value)
                            anchors.Add(completion.Value!);
                lowsLeft = Completions(lowLeft, anchors, steps);
                highsLeft = Completions(highLeft, anchors, steps);
                lowsRight = Completions(lowRight, anchors, steps);
                highsRight = Completions(highRight, anchors, steps);
            }

            bool anyTrue = false, anyFalse = false;
            foreach (var ll in lowsLeft)
                foreach (var lh in highsLeft)
                {
                    if (IsAtOrBefore(ll, lh, null) == false)
                        continue;
                    foreach (var rl in lowsRight)
                        foreach (var rh in highsRight)
                        {
                            if (IsAtOrBefore(rl, rh, null) == false)
                                continue;
                            switch (formula(ll, lh, rl, rh, precision))
                            {
                                case null: return null;
                                case true: anyTrue = true; break;
                                case false: anyFalse = true; break;
                            }
                            if (anyTrue && anyFalse)
                                return null;
                        }
                }

            return anyTrue ? true : anyFalse ? false : formula(lowLeft, highLeft, lowRight, highRight, precision);
        }

        /// <summary>
        /// The representative values of a boundary: the boundary itself when it is known; for an unknown one, the
        /// ends of its range and each anchor, with its successor and predecessor, that falls inside the range.
        /// </summary>
        private List<Boundary<T>> Completions<T>(Boundary<T> boundary, List<T> anchors, (Func<T, T> Successor, Func<T, T> Predecessor) steps)
        {
            if (!boundary.IsUnknown)
                return new List<Boundary<T>> { boundary };

            var completions = new List<Boundary<T>> { boundary.Least };
            if (IsSame(boundary.Least, boundary.Greatest, null) != true)
                completions.Add(boundary.Greatest);
            foreach (var anchor in anchors)
                foreach (var value in new[] { anchor, steps.Successor(anchor), steps.Predecessor(anchor) })
                {
                    if (value is null || !WithinRange(boundary, value))
                        continue;
                    var candidate = Boundary<T>.Of(value);
                    if (!completions.Exists(c => IsSame(c, candidate, null) == true))
                        completions.Add(candidate);
                }
            return completions;
        }

        /// <summary>
        /// Whether <paramref name="value"/> lies in the range of an unknown boundary. A value whose position against a
        /// range end the comparer cannot decide (a coarser value spanning that end) is not a value the boundary can
        /// take and is left out; the range's ends are completions in their own right.
        /// </summary>
        private bool WithinRange<T>(Boundary<T> unknown, T value) =>
            (unknown.RangeLow is not { } low || Comparer.Compare(value, low, null) >= 0)
            && (unknown.RangeHigh is not { } high || Comparer.Compare(value, high, null) <= 0);

        /// <summary>The successor and predecessor functions of a point type, or <c>null</c> when it has none.</summary>
        private (Func<T, T> Successor, Func<T, T> Predecessor)? StepsFor<T>()
        {
            if (typeof(T) == typeof(int?)) return Steps<int?>(Successor, Predecessor);
            if (typeof(T) == typeof(long?)) return Steps<long?>(Successor, Predecessor);
            if (typeof(T) == typeof(decimal?)) return Steps<decimal?>(Successor, Predecessor);
            if (typeof(T) == typeof(CqlQuantity)) return Steps<CqlQuantity?>(Successor, Predecessor);
            if (typeof(T) == typeof(CqlDate)) return Steps<CqlDate?>(Successor, Predecessor);
            if (typeof(T) == typeof(CqlDateTime)) return Steps<CqlDateTime?>(Successor, Predecessor);
            if (typeof(T) == typeof(CqlTime)) return Steps<CqlTime?>(Successor, Predecessor);
            return null;

            static (Func<T, T>, Func<T, T>) Steps<TPoint>(Func<TPoint, TPoint> successor, Func<TPoint, TPoint> predecessor) =>
                ((Func<T, T>)(object)successor, (Func<T, T>)(object)predecessor);
        }
    }
}
