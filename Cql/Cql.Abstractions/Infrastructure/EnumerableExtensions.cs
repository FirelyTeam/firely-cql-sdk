/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Hl7.Cql.Abstractions.Infrastructure;

internal static class EnumerableExtensions
{
    public static void AddRange<T>(
        this ICollection<T> target,
        IEnumerable<T> source)
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

    [DebuggerStepThrough]
    public static T[] SelectToArray<TIn, T>(
        this IReadOnlyCollection<TIn> source,
        Func<TIn, T> select) =>
        source is TIn[] sourceArray
            ? SelectArrayToArray(sourceArray, source.Count, select)
            : SelectEnumerableToArray(source, source.Count, ConvertFuncIncludeOrdinal(select));

    [DebuggerStepThrough]
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

    [DebuggerStepThrough]
    private static T[] SelectArrayToArray<TIn, T>(
        TIn[] sourceArray,
        int expectedSourceLength,
        Func<TIn, T> select)
    {
        if (expectedSourceLength != sourceArray.Length)
            throw new ArgumentException($"Source array must have '{expectedSourceLength}' element(s), but has '{sourceArray.Length}'.");

        return Array.ConvertAll(sourceArray, select.Invoke);
    }

    [DebuggerStepThrough]
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

internal static class DictionaryExtensions
{
    public static TValue GetOrAdd<TKey, TValue>(
        this IDictionary<TKey, TValue> dictionary,
        TKey key,
        Func<TKey, TValue> valueFactory)
    {
        if (dictionary.TryGetValue(key, out var value))
            return value;

        value = valueFactory(key);
        dictionary.Add(key, value);
        return value;
    }
}