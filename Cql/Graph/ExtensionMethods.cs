using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Graph
{
    internal static class ExtensionMethods
    {
        public static HashSet<T> ToHashSet<T>(this IEnumerable<T> hashSet) => new HashSet<T>(hashSet);
    }
}
