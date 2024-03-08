using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.Compiler.Infrastructure;

internal static class EnumerableExtensions
{
    /// <summary>
    /// Pair items in an enumeration with their ordinals starting at 1.
    /// </summary>
    public static IEnumerable<(T Item, int Ordinal)> WithOrdinals<T>(this IEnumerable<T> source) =>
        source.Select((item, ordinal) => (item, ordinal));
}