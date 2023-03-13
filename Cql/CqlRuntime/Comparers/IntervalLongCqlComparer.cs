using Ncqa.Cql.Runtime.Primitives;
using System;

namespace Ncqa.Cql.Runtime.Comparers
{
    public class IntervalLongCqlComparer : IntervalCqlComparer
    {
        public IntervalLongCqlComparer(CqlComparers comparers, ICqlOperators operators) : base(comparers, operators)
        {
        }

        public override int? Compare(object x, object y, string? precision = null)
        {
            if (x == null || y == null)
                return null;
            var xInt = x as CqlInterval<long?> ?? throw new ArgumentException("Wrong type", nameof(x));
            var yInt = y as CqlInterval<long?> ?? throw new ArgumentException("Wrong type", nameof(y));

            var xLow = xInt.lowClosed ?? false ? xInt.low : Operators.Successor(xInt.low);
            var yLow = yInt.lowClosed ?? false ? yInt.low : Operators.Successor(yInt.low);
            var xHigh = xInt.highClosed ?? false ? xInt.high : Operators.Predecessor(xInt.high);
            var yHigh = yInt.highClosed ?? false ? yInt.high : Operators.Predecessor(yInt.high);

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
                    else return Comparers.Compare(xHigh, yHigh, precision);
                }
                else return -1;
            }
            else if (yLow == null)
                return 1;
            else
            {
                var low = Comparers.Compare(xLow, yLow, precision);
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
                    else return Comparers.Compare(xHigh, yHigh, precision);
                }
                else return low;
            }
        }
    }
}