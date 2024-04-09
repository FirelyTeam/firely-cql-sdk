using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.Abstractions.Infrastructure;

internal static class EnumerableExtensions
{
    public static void AddRange<T>(this ICollection<T> target, IEnumerable<T> source)
    {
        switch (target)
        {
            case List<T> list:
                list.AddRange(source);
                break;

            default:
                foreach (var item in source)
                {
                    target.Add(item);
                }
                break;
        }
    }

    public static T[] SelectToArray<TIn, T>(
        this IReadOnlyCollection<TIn> source,
        Func<TIn, T> select) =>
        SelectToArray(source.AsEnumerable(), source.Count, select);

    public static T[] SelectToArray<TIn, T>(
        this IEnumerable<TIn> source,
        int sourceLength,
        Func<TIn, T> select)
    {
        if (source is TIn[] sourceArray)
        {
            if (sourceLength != sourceArray.Length)
                throw new ArgumentException($"Source array must have '{sourceLength}' element(s), but has '{sourceArray.Length}'.");

            return Array.ConvertAll(sourceArray, select.Invoke);
        }

        T[] array = new T[sourceLength];
        int i = -1;
        foreach (var item in source)
        {
            ++i;
            array[i] = select(item);
        }

        return array;
    }
}