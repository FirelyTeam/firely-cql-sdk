using System.Collections.Generic;

namespace Hl7.Cql.Compiler.Infrastructure;

internal static class EnumerableExtensions
{
    /// <summary>
    /// Pair items in an enumeration with their ordinals starting at 1.
    /// </summary>
    public static IEnumerable<(T Item, Ordinal Ordinal)> WithOrdinals<T>(this IEnumerable<T> source)
    {
        int i = 0;
        foreach (var item in source)
        {
            ++i;
            yield return (item, new Ordinal(i));
        }
    }
}