/*
 * Copyright (c) 2023, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Primitives;

namespace Hl7.Cql.Comparers
{
    internal class IntervalComparer<T>(
        ICqlComparer<object> pointComparer,
        Func<T, T> predecessor,
        Func<T, T> successor,
        Func<T> minValue,
        Func<T> maxValue) :
        CqlComparer<CqlInterval<T>>(CqlComparerEqualsImplementation.Compare, equivalentImplementation: CqlComparerEquivalentImplementation.Equivalent)
    {
        private ICqlComparer<object> PointComparer { get; } = pointComparer ?? throw new ArgumentNullException(nameof(pointComparer));

        private Func<T, T> Predecessor { get; } = predecessor ?? throw new ArgumentNullException(nameof(predecessor));

        private Func<T, T> Successor { get; } = successor ?? throw new ArgumentNullException(nameof(successor));

        private Func<T> MinValue { get; } = minValue ?? throw new ArgumentNullException(nameof(minValue));

        private Func<T> MaxValue { get; } = maxValue ?? throw new ArgumentNullException(nameof(maxValue));

        /// <summary>
        /// Two intervals with the same representation are not equal when a boundary is unknown,
        /// since two unknown starts (or ends) cannot be known to be the same value.
        /// </summary>
        protected override bool DefaultEqualityImpliesEquality => false;

        /// <summary>
        /// Orders intervals by their Start, then by their End. A null closed boundary is the minimum
        /// or maximum value of the point type, and compares equal to that value written out; a null
        /// open boundary (or an open boundary whose closed equivalent cannot be represented) is
        /// unknown, so a comparison against it is indeterminate. A boundary that is known to differ
        /// decides the comparison even when the other boundary is unknown, so that equality derived
        /// from this comparison is false rather than unknown.
        /// </summary>
        protected override int? CompareValues(
            CqlInterval<T> x,
            CqlInterval<T> y,
            string? precision)
        {
            var (xLow, xHigh) = Normalise(x);
            var (yLow, yHigh) = Normalise(y);

            var low = CompareBoundaries(xLow, yLow, precision);
            var high = CompareBoundaries(xHigh, yHigh, precision);

            return low switch
            {
                null => high is not null and not 0 ? high : null,
                0    => high,
                _    => low,
            };
        }

        /// <summary>
        /// Intervals are equivalent when both boundaries are equivalent: unknown to unknown, or
        /// value to equivalent value, a null closed boundary being the extreme of the point type.
        /// </summary>
        protected override bool EquivalentValues(
            CqlInterval<T> x,
            CqlInterval<T> y,
            string? precision)
        {
            var (xLow, xHigh) = Normalise(x);
            var (yLow, yHigh) = Normalise(y);
            return EquivalentBoundaries(xLow, yLow, precision) && EquivalentBoundaries(xHigh, yHigh, precision);
        }

        /// <summary>
        /// The Start and End of the interval: the closed value, the successor or predecessor of an
        /// open value, the extreme of the point type for a null closed boundary, or unknown.
        /// </summary>
        private (Boundary low, Boundary high) Normalise(CqlInterval<T> interval)
        {
            var lowClosed = interval.lowClosed ?? false;
            var highClosed = interval.highClosed ?? false;
            var low = lowClosed ? interval.low : Successor(interval.low);
            var high = highClosed ? interval.high : Predecessor(interval.high);
            return (
                low is null ? (lowClosed ? new Boundary(MinValue(), Unknown: false) : Boundary.UnknownBoundary) : new Boundary(low, Unknown: false),
                high is null ? (highClosed ? new Boundary(MaxValue(), Unknown: false) : Boundary.UnknownBoundary) : new Boundary(high, Unknown: false));
        }

        private int? CompareBoundaries(Boundary x, Boundary y, string? precision) =>
            x.Unknown || y.Unknown ? null : PointComparer.Compare(x.Value, y.Value, precision);

        private bool EquivalentBoundaries(Boundary x, Boundary y, string? precision) =>
            (x.Unknown, y.Unknown) switch
            {
                (true, true) => true,
                (true, _) or (_, true) => false,
                _ => PointComparer.Equivalent(x.Value, y.Value, precision),
            };

        /// <summary>
        /// A normalised interval boundary: its value, or unknown.
        /// </summary>
        private readonly record struct Boundary(T? Value, bool Unknown)
        {
            public static readonly Boundary UnknownBoundary = new(default, Unknown: true);
        }

        protected override int GetHashCodeValue(CqlInterval<T> value)
        {
            // Hashes align with CompareValues at default precision by hashing the same normalised
            // boundaries. Precision-specific comparisons (e.g. date/day precision) cannot be
            // represented here because GetHashCode has no precision parameter.
            var (low, high) = Normalise(value);
            return HashCode.Combine(
                low.Unknown ? GetHashCodeForNull() : PointComparer.GetHashCode(low.Value),
                high.Unknown ? GetHashCodeForNull() : PointComparer.GetHashCode(high.Value));
        }
    }
}
