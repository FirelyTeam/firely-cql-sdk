using Ncqa.Cql.Runtime.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.Comparers
{
    public class CqlQuantityCqlComparer : ICqlComparer<CqlQuantity>, ICqlComparer
    {
        public CqlQuantityCqlComparer(CqlComparers comparers)
        {
            Comparers = comparers;
        }

        public CqlComparers Comparers { get; }

        public int? Compare(CqlQuantity? x, CqlQuantity? y, string? precision = null)
        {
            if (x == null)
            {
                if (y == null)
                    return 0;
                else return -1;
            }
            else if (y == null)
                return 1;

            var unitCompare = Comparers.Compare(x.unit!, y.unit!, precision);
            if (unitCompare == 0 || x.unit == "1" || y.unit == "1")
            {
                var valueComparison = Comparers.Compare(x.value!, y.value!, precision);
                return valueComparison;
            }
            else
                throw new NotSupportedException($"Comparison against unlike units {x.unit} and {y.unit} is not supported.");
        }

        public int? Compare(object x, object y, string? precision = null) => Compare(x as CqlQuantity, y as CqlQuantity, precision);

        public bool? Equals(CqlQuantity? x, CqlQuantity? y, string? precision = null) => Compare(x, y, precision) == 0;

        public bool? Equals(object x, object y, string? precision = null)=> Equals(x as CqlQuantity, y as CqlQuantity, precision); 

        public bool Equivalent(CqlQuantity? x, CqlQuantity? y, string? precision = null)
        {
            if (x == null)
                throw new ArgumentNullException(nameof(x));
            if (y == null)
                throw new ArgumentNullException(nameof(y));

            return x.value == y.value && x.unit == y.unit;
        }

        public bool Equivalent(object x, object y, string? precision = null) => Equivalent(x as CqlQuantity, y as CqlQuantity, precision);

        public int GetHashCode(CqlQuantity? x) =>
            x == null
            ? typeof(CqlQuantity).GetHashCode()
            : x.ToString()!.GetHashCode();

        public int GetHashCode(object x) => GetHashCode(x as CqlQuantity);
    }
}
