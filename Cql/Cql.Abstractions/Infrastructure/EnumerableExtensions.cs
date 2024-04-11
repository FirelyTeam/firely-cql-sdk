using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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
        Func<TIn, int, T> select) =>
        source is TIn[] sourceArray
            ? SelectArrayToArray(sourceArray, source.Count, ConvertFuncExcludeOrdinal(select))
            : SelectEnumerableToArray(source, source.Count, select);

    public static T[] SelectToArray<TIn, T>(
        this IReadOnlyCollection<TIn> source,
        Func<TIn, T> select) =>
        source is TIn[] sourceArray
            ? SelectArrayToArray(sourceArray, source.Count, select)
            : SelectEnumerableToArray(source, source.Count, ConvertFuncIncludeOrdinal(select));

    public static T[] SelectToArray<TIn, T>(
        this IEnumerable<TIn> source,
        int sourceLength,
        Func<TIn, T> select) =>
        source is TIn[] sourceArray
            ? SelectArrayToArray(sourceArray, sourceLength, select)
            : SelectEnumerableToArray(source, sourceLength, ConvertFuncIncludeOrdinal(select));

    private static Func<TIn, int, T> ConvertFuncIncludeOrdinal<TIn, T>(Func<TIn, T> select) => (item, _) => select(item);

    private static Func<TIn, T> ConvertFuncExcludeOrdinal<TIn, T>(Func<TIn, int, T> select)
    {
        int i = 0;
        return (item) => select(item, i++);
    }

    private static T[] SelectEnumerableToArray<TIn, T>(
        IEnumerable<TIn> source,
        int sourceLength,
        Func<TIn, int, T> select)
    {
        T[] array = new T[sourceLength];
        int i = 0;
        foreach (var item in source)
        {
            array[i] = select(item, i);
            ++i;
        }

        if (sourceLength != i)
            throw new ArgumentException($"Source array must have '{sourceLength}' element(s), but has '{i}'.");

        return array;
    }

    private static T[] SelectArrayToArray<TIn, T>(
        TIn[] sourceArray,
        int expectedSourceLength,
        Func<TIn, T> select)
    {
        if (expectedSourceLength != sourceArray.Length)
            throw new ArgumentException($"Source array must have '{expectedSourceLength}' element(s), but has '{sourceArray.Length}'.");

        return Array.ConvertAll(sourceArray, select.Invoke);
    }

    public static bool TryPeek<T>(
        this IImmutableStack<T> stack,
        out T value)
    {
        if (stack.IsEmpty)
        {
            value = default;
            return false;
        }

        value = stack.Peek();
        return true;
    }
}