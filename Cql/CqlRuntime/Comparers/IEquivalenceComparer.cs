namespace Ncqa.Cql.Runtime.Comparers
{
    public interface IEquivalenceComparer
    {
        bool Equivalent(object x, object y, string? precision);
    }
    public interface IEquivalenceComparer<T>
    {
        bool Equivalent(T x, T y, string? precision);
    }
}
