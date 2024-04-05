using System.Collections.Generic;

namespace Hl7.Cql.Runtime;

partial class CqlOperators
{
    public IEnumerable<(T1, T2)> CrossJoin<T1, T2>(
        IEnumerable<T1> source1,
        IEnumerable<T2> source2)
    {
        foreach (var s1 in source1)
        foreach (var s2 in source2)
            yield return (s1, s2);
    }

    public IEnumerable<(T1, T2, T3)> CrossJoin<T1, T2, T3>(
        IEnumerable<T1> source1,
        IEnumerable<T2> source2,
        IEnumerable<T3> source3)
    {
        foreach (var s1 in source1)
        foreach (var s2 in source2)
        foreach (var s3 in source3)
            yield return (s1, s2, s3);
    }

    public IEnumerable<(T1, T2, T3, T4)> CrossJoin<T1, T2, T3, T4>(
        IEnumerable<T1> source1,
        IEnumerable<T2> source2,
        IEnumerable<T3> source3,
        IEnumerable<T4> source4)
    {
        foreach (var s1 in source1)
        foreach (var s2 in source2)
        foreach (var s3 in source3)
        foreach (var s4 in source4)
            yield return (s1, s2, s3, s4);
    }
}