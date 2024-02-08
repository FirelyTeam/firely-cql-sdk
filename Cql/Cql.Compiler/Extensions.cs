using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.Compiler
{
    internal static class Extensions
    {
        public static T[] OrEmptyArray<T>(this T[]? array) 
            => array ?? Array.Empty<T>();

        public static IReadOnlyCollection<T> OrEmptyCollection<T>(this IReadOnlyCollection<T>? collection) 
            => collection ?? Array.Empty<T>();

        public static IEnumerable<T> OrEmptyEnumerable<T>(this IEnumerable<T>? enumerable) 
            => enumerable ?? Enumerable.Empty<T>();
    }


}
