using System;
using System.Collections.Generic;

namespace Ncqa.Cql.Runtime.Comparers
{
    public class DefaultCqlComparer<T> : ICqlComparer, ICqlComparer<T>
    {
        public int? Compare(object x, object y, string? precision = null)
        {
            if (x is T tx)
            {
                if (y is T ty)
                    return Compare(tx, ty, precision);
            }
            return -1;
        }

        public int? Compare(T x, T y, string? precision = null) => Comparer<T>.Default.Compare(x, y);

        public bool? Equals(object x, object y, string? precision = null) => 
            Compare(x, y, precision) == 0;

        public bool? Equals(T x, T y, string? precision = null) => Comparer<T>.Default.Compare(x, y) == 0;

        public bool Equivalent(object x, object y, string? precision = null) => 
            Compare(x, y, precision) == 0;

        public bool Equivalent(T x, T y, string? precision = null) => Compare(x, y, precision) == 0;

        public int GetHashCode(T x) => EqualityComparer<T>.Default.GetHashCode(x);

        public int GetHashCode(object x) => 
            x is T t 
            ? GetHashCode(t) 
            : throw new InvalidCastException();
    }
}
