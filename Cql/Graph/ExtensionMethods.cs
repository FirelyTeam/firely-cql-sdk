using System.Collections.Generic;

namespace Hl7.Cql.Graph
{
    internal static class ExtensionMethods
    {
        public static HashSet<T> ToHashSet<T>(this IEnumerable<T> hashSet) => new HashSet<T>(hashSet);
    }
}
