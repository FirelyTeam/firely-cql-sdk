using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.Runtime;

partial class CqlOperators
{
    private IEnumerable<T1> CrossJoin<T1>(
        IEnumerable<T1>? source1) =>
        source1 ?? Enumerable.Empty<T1>();

    public IEnumerable<(T1, T2)> CrossJoin<T1, T2>(
        IEnumerable<T1>? source1,
        IEnumerable<T2>? source2)
    {
        if (source1 is null
            || source2 is null)
            yield break;

        // REVIEW: What effect has multiple enumeration on the origin of the source? Should a single enumeration be cached into a list first?

        foreach (var s1 in source1)
        foreach (var s2 in source2)
            yield return (s1, s2);
    }

    public IEnumerable<(T1, T2, T3)> CrossJoin<T1, T2, T3>(
        IEnumerable<T1>? source1,
        IEnumerable<T2>? source2,
        IEnumerable<T3>? source3)
    {
        if (source1 is null
            || source2 is null
            || source3 is null)
            yield break;

        foreach (var s1 in source1)
        foreach (var s2 in source2)
        foreach (var s3 in source3)
            yield return (s1, s2, s3);
    }

    public IEnumerable<(T1, T2, T3, T4)> CrossJoin<T1, T2, T3, T4>(
        IEnumerable<T1>? source1,
        IEnumerable<T2>? source2,
        IEnumerable<T3>? source3,
        IEnumerable<T4>? source4)
    {
        if (source1 is null
            || source2 is null
            || source3 is null
            || source4 is null)
            yield break;

        foreach (var s1 in source1)
        foreach (var s2 in source2)
        foreach (var s3 in source3)
        foreach (var s4 in source4)
            yield return (s1, s2, s3, s4);
    }

    public IEnumerable<(T1, T2, T3, T4, T5)> CrossJoin<T1, T2, T3, T4, T5>(
        IEnumerable<T1>? source1,
        IEnumerable<T2>? source2,
        IEnumerable<T3>? source3,
        IEnumerable<T4>? source4,
        IEnumerable<T5>? source5)
    {
        foreach (var (s1, s2, s3, s4) in CrossJoin(source1, source2, source3, source4))
        foreach (var s5 in CrossJoin(source5))
            yield return (s1, s2, s3, s4, s5);
    }

    public IEnumerable<(T1, T2, T3, T4, T5, T6)> CrossJoin<T1, T2, T3, T4, T5, T6>(
        IEnumerable<T1>? source1,
        IEnumerable<T2>? source2,
        IEnumerable<T3>? source3,
        IEnumerable<T4>? source4,
        IEnumerable<T5>? source5,
        IEnumerable<T6>? source6)
    {
        foreach (var (s1, s2, s3, s4) in CrossJoin(source1, source2, source3, source4))
        foreach (var (s5, s6) in CrossJoin(source5, source6))
            yield return (s1, s2, s3, s4, s5, s6);
    }

    public IEnumerable<(T1, T2, T3, T4, T5, T6, T7)> CrossJoin<T1, T2, T3, T4, T5, T6, T7>(
        IEnumerable<T1>? source1,
        IEnumerable<T2>? source2,
        IEnumerable<T3>? source3,
        IEnumerable<T4>? source4,
        IEnumerable<T5>? source5,
        IEnumerable<T6>? source6,
        IEnumerable<T7>? source7)
    {
        foreach (var (s1, s2, s3, s4) in CrossJoin(source1, source2, source3, source4))
        foreach (var (s5, s6, s7) in CrossJoin(source5, source6, source7))
            yield return (s1, s2, s3, s4, s5, s6, s7);
    }

    public IEnumerable<(T1, T2, T3, T4, T5, T6, T7, T8)> CrossJoin<T1, T2, T3, T4, T5, T6, T7, T8>(
        IEnumerable<T1>? source1,
        IEnumerable<T2>? source2,
        IEnumerable<T3>? source3,
        IEnumerable<T4>? source4,
        IEnumerable<T5>? source5,
        IEnumerable<T6>? source6,
        IEnumerable<T7>? source7,
        IEnumerable<T8>? source8)
    {
        foreach (var (s1, s2, s3, s4) in CrossJoin(source1, source2, source3, source4))
        foreach (var (s5, s6, s7, s8) in CrossJoin(source5, source6, source7, source8))
            yield return (s1, s2, s3, s4, s5, s6, s7, s8);
    }
}