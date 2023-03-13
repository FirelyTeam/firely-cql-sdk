using System;

namespace Ncqa.Cql.Runtime.Comparers
{
    public interface ICqlComparable<T>
        where T: class
    {
        int? CompareTo(T? other, string? precision = null);

        int GetHashCode();
    }
}
