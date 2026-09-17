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
        CqlComparer<CqlInterval<T>>(CqlComparerEqualsImplementation.Compare, equivalentImplementation:CqlComparerEquivalentImplementation.Compare)
    {
        private ICqlComparer<object> PointComparer { get; } = pointComparer ?? throw new ArgumentNullException(nameof(pointComparer));

        private Func<T, T> Predecessor { get; } = predecessor ?? throw new ArgumentNullException(nameof(predecessor));

        private Func<T, T> Successor { get; } = successor ?? throw new ArgumentNullException(nameof(successor));

        protected override int? CompareValues(
            CqlInterval<T> x,
            CqlInterval<T> y,
            string? precision)
        {
            var xLow = x.lowClosed ?? false ? x.low : Successor(x.low);
            var yLow = y.lowClosed ?? false ? y.low : Successor(y.low);
            var xHigh = x.highClosed ?? false ? x.high : Predecessor(x.high);
            var yHigh = y.highClosed ?? false ? y.high : Predecessor(y.high);

            // A boundary that is null and not closed is unknown - as is an open boundary whose
            // closed equivalent cannot be represented - so the intervals cannot be ordered. The
            // null boundaries left below are closed, and stand for the extremes of the point type.
            if (IsUnknown(xLow, x.lowClosed) || IsUnknown(xHigh, x.highClosed)
                || IsUnknown(yLow, y.lowClosed) || IsUnknown(yHigh, y.highClosed))
                return null;

            if (xLow == null)
            {
                if (yLow == null)
                {
                    if (xHigh == null)
                    {
                        if (yHigh == null)
                            return 0;
                        else return -1;
                    }
                    else if (yHigh == null)
                        return 1;
                    else return PointComparer.Compare(xHigh, yHigh, precision);
                }
                else return -1;
            }
            else if (yLow == null)
                return 1;
            else
            {
                var low = PointComparer.Compare(xLow, yLow, precision);
                if (low == 0)
                {
                    if (xHigh == null)
                    {
                        if (yHigh == null)
                            return 0;
                        else return -1;
                    }
                    else if (yHigh == null)
                        return 1;
                    else return PointComparer.Compare(xHigh, yHigh, precision);
                }
                else return low;
            }
        }

        private static bool IsUnknown(T? boundary, bool? closed) =>
            boundary is null && !(closed ?? false);

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
