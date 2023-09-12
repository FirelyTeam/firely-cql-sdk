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

namespace Hl7.Cql.Comparers
{
    internal class IntervalComparer<T> : CqlComparerBase<CqlInterval<T>>
    {
        public IntervalComparer(ICqlComparer pointComparer, Func<T, T> predecessor, Func<T, T> successor)
        {
            PointComparer = pointComparer ?? throw new ArgumentNullException(nameof(pointComparer));
            Predecessor = predecessor ?? throw new ArgumentNullException(nameof(predecessor));
            Successor = successor ?? throw new ArgumentNullException(nameof(successor));
        }

        public ICqlComparer PointComparer { get; }
        public Func<T, T> Predecessor { get; }
        public Func<T, T> Successor { get; }

        public override int? Compare(CqlInterval<T>? x, CqlInterval<T>? y, string? precision)
        {
            if (x == null || y == null)
                return null;

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

        public override bool Equivalent(CqlInterval<T>? x, CqlInterval<T>? y, string? precision) =>
            Compare(x, y, precision) == 0 ? true : false;

        public override int GetHashCode(CqlInterval<T> x) =>
            x == null
            ? typeof(object).GetHashCode()
            : x.ToString()!.GetHashCode();
    }
}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
