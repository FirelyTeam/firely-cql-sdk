using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.Comparers
{
    public abstract class CqlComparerBase<T> : ICqlComparer<T>, ICqlComparer,
        IEquivalenceComparer<T>, IEquivalenceComparer
        where T: class
    {        
        public abstract int? Compare(T x, T y, string? precision);
        public abstract bool Equivalent(T x, T y, string? precision);
        public abstract bool? Equals(T x, T y, string? precision);

        public int? Compare(object x, object y, string? precision) => Compare((x as T)!, (y as T)!, precision);

        public bool? Equals(object x, object y, string? precision) => Equals((x as T)!, (y as T)!, precision);
        
        public bool Equivalent(object x, object y, string? precision) => Equivalent((x as T)!, (y as T)!, precision);
        public abstract int GetHashCode(T x);
        public abstract int GetHashCode(object x);
    }
}
