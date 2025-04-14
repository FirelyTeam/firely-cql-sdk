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

        protected override int GetHashCodeValue(CqlInterval<T> value)
        {
            return value.ToString()?.GetHashCode() ?? GetHashCodeForNull();
        }
    }
}
