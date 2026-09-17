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
        Func<T, T> successor) :
        CqlComparer<CqlInterval<T>>(CqlComparerEqualsImplementation.Compare, equivalentImplementation: CqlComparerEquivalentImplementation.Equivalent)
    {
        private ICqlComparer<object> PointComparer { get; } = pointComparer ?? throw new ArgumentNullException(nameof(pointComparer));

        private Func<T, T> Predecessor { get; } = predecessor ?? throw new ArgumentNullException(nameof(predecessor));

        private Func<T, T> Successor { get; } = successor ?? throw new ArgumentNullException(nameof(successor));

        /// <summary>
        /// Two intervals with the same representation are not equal when a boundary is unknown,
        /// since two unknown starts (or ends) cannot be known to be the same value.
        /// </summary>
        protected override bool DefaultEqualityImpliesEquality => false;

        /// <summary>
        /// Orders intervals by their Start, then by their End. A null closed boundary is the minimum
        /// or maximum value of the point type; a null open boundary (or an open boundary whose closed
        /// equivalent cannot be represented) is unknown, so a comparison against it is indeterminate.
        /// A boundary that is known to differ decides the comparison even when the other boundary is
        /// unknown, so that equality derived from this comparison is false rather than unknown.
        /// </summary>
        protected override int? CompareValues(
            CqlInterval<T> x,
            CqlInterval<T> y,
            string? precision)
        {
            var (xLow, xHigh) = Normalise(x);
            var (yLow, yHigh) = Normalise(y);

            var low = CompareBoundaries(xLow, yLow, precision, nullIsMinimum: true);
            var high = CompareBoundaries(xHigh, yHigh, precision, nullIsMinimum: false);

            return low switch
            {
                null => high is not null and not 0 ? high : null,
                0    => high,
                _    => low,
            };
        }

        /// <summary>
        /// Intervals are equivalent when both boundaries are equivalent: unknown to unknown, closed
        /// null to closed null (the same extreme of the point type), or value to equivalent value.
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

        private (Boundary low, Boundary high) Normalise(CqlInterval<T> interval)
        {
            var low = (interval.lowClosed ?? false) ? interval.low : Successor(interval.low);
            var high = (interval.highClosed ?? false) ? interval.high : Predecessor(interval.high);
            return (
                new Boundary(low, Unknown: low is null && !(interval.lowClosed ?? false)),
                new Boundary(high, Unknown: high is null && !(interval.highClosed ?? false)));
        }

        private int? CompareBoundaries(Boundary x, Boundary y, string? precision, bool nullIsMinimum)
        {
            if (x.Unknown || y.Unknown)
                return null;

            return (x.Value, y.Value) switch
            {
                (null, null) => 0,
                (null, _)    => nullIsMinimum ? -1 : 1,
                (_, null)    => nullIsMinimum ? 1 : -1,
                var (xv, yv) => PointComparer.Compare(xv, yv, precision),
            };
        }

        private bool EquivalentBoundaries(Boundary x, Boundary y, string? precision) =>
            (x.Unknown, y.Unknown, x.Value, y.Value) switch
            {
                (true, true, _, _)        => true,
                (true, _, _, _)           => false,
                (_, true, _, _)           => false,
                (_, _, null, null)        => true,
                (_, _, null, _)           => false,
                (_, _, _, null)           => false,
                var (_, _, xv, yv)        => PointComparer.Equivalent(xv, yv, precision),
            };

        /// <summary>
        /// A normalised interval boundary: its closed value, or unknown.
        /// </summary>
        private readonly record struct Boundary(T? Value, bool Unknown);

        protected override int GetHashCodeValue(CqlInterval<T> value)
        {
            // Hashes align with CompareValues at default precision by hashing the same normalized
            // boundaries. Precision-specific comparisons (e.g. date/day precision) cannot be
            // represented here because GetHashCode has no precision parameter.
            var low = (value.lowClosed ?? false) ? value.low : Successor(value.low);
            var high = (value.highClosed ?? false) ? value.high : Predecessor(value.high);

            return HashCode.Combine(
                low is null ? GetHashCodeForNull() : PointComparer.GetHashCode(low),
                high is null ? GetHashCodeForNull() : PointComparer.GetHashCode(high));
        }
    }
}
