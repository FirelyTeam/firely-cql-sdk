using System;

namespace Hl7.Cql.Compiler
{
    internal static class ArrayExtensions
    {
        public static T[] OrEmpty<T>(this T[]? array) => array ?? Array.Empty<T>();
    }
}
