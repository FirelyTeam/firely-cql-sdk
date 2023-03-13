using System.Collections;
using System.Collections.Generic;

namespace Ncqa.Cql.Runtime.Comparers
{
    public interface ICqlComparer: IEquivalenceComparer
    {
        bool? Equals(object x, object y, string? precision);
        int? Compare(object x, object y, string? precision);
        int GetHashCode(object x);
    }
    public interface ICqlComparer<T> : IEquivalenceComparer<T>
    {
        bool? Equals(T x, T y, string? precision);
        int? Compare(T x, T y, string? precision);
        int GetHashCode(T x);

    }
}
