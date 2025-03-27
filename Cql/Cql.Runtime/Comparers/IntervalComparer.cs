/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Comparers
{
    internal class IntervalComparer<T>(
        ICqlComparer<object> pointComparer,
        Func<T, T> predecessor,
        Func<T, T> successor) : 
        CqlComparer<CqlInterval<T>>(CqlComparerEqualsMethod.Compare)
    {
        private ICqlComparer<object> PointComparer { get; } = pointComparer ?? throw new ArgumentNullException(nameof(pointComparer));
        private Func<T, T> Predecessor { get; } = predecessor ?? throw new ArgumentNullException(nameof(predecessor));
        private Func<T, T> Successor { get; } = successor ?? throw new ArgumentNullException(nameof(successor));

        protected internal override int? CompareValues(
            CqlInterval<T> left,
            CqlInterval<T> right,
            string? precision)
        {
            var xLow = left.lowClosed ?? false ? left.low : Successor(left.low);
            var yLow = right.lowClosed ?? false ? right.low : Successor(right.low);
            var xHigh = left.highClosed ?? false ? left.high : Predecessor(left.high);
            var yHigh = right.highClosed ?? false ? right.high : Predecessor(right.high);

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

        public override int? Compare(CqlInterval<T>? left, CqlInterval<T>? right, string? precision)
        {
            if (left == null || right == null)
                return null;

            var xLow = left.lowClosed ?? false ? left.low : Successor(left.low);
            var yLow = right.lowClosed ?? false ? right.low : Successor(right.low);
            var xHigh = left.highClosed ?? false ? left.high : Predecessor(left.high);
            var yHigh = right.highClosed ?? false ? right.high : Predecessor(right.high);

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

        protected internal override bool EquivalentValues(CqlInterval<T> x, CqlInterval<T> y, string? precision) =>
            Compare(x, y, precision) == 0;

        public override int GetHashCode(CqlInterval<T>? value) =>
            value == null
            ? typeof(object).GetHashCode()
            : value.ToString()!.GetHashCode();
    }
}
