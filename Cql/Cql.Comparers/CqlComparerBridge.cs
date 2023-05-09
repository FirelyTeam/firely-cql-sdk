using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Comparers
{
    public class CqlComparerBridge<T>: IComparer<T>, IEqualityComparer<T>
    {
        public CqlComparerBridge(ICqlComparer<T> cqlComparer, int coalesceCompareTo = -1, bool coalesceBoolTo = false)
        {
            CqlComparer = cqlComparer;
            CoalesceCompareTo = coalesceCompareTo;
            CoalesceEqualTo = coalesceBoolTo;
        }

        public ICqlComparer<T> CqlComparer { get; }
        public int CoalesceCompareTo { get; }
        public bool CoalesceEqualTo { get; }

        public int Compare(T x, T y) => CqlComparer.Compare(x, y, null) ?? CoalesceCompareTo;

        public bool Equals(T x, T y) => CqlComparer.Equals(x, y, null) ?? CoalesceEqualTo;

        public int GetHashCode(T obj) => CqlComparer.GetHashCode(obj);
    }
}
