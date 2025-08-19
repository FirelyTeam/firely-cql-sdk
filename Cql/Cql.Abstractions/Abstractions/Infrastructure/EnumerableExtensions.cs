/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Abstractions.Infrastructure;

internal static class EnumerableExtensions
{
    /// <summary>
    /// Performs the specified action on each element of the collection.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    /// <param name="source">The source collection of elements to add.</param>
    /// <param name="action">The action to perform on each element.</param>
    public static void ForEach<T>(
        this IEnumerable<T> source,
        Action<T>? action = null)
    {
        if (action is null)
            foreach (var _ in source) { }
        else
            foreach (var item in source) action(item);
    }

    /// <summary>
    /// Performs the specified action on each element of the collection while returning the source collection.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    /// <param name="source">The source collection of elements to add.</param>
    /// <param name="action">The action to perform on each element.</param>
    public static IEnumerable<T> WithEach<T>(
        this IEnumerable<T> source,
        Action<T>? action = null)
    {
        foreach (var item in source)
        {
            action?.Invoke(item);
            yield return item;
        }
    }

    /// <summary>
    /// Adds a range of elements to the target collection.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    /// <param name="target">The target collection to add elements to.</param>
    /// <param name="source">The source collection of elements to add.</param>
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

    /// <summary>
    /// Projects each element of a read-only collection into a new array.
    /// </summary>
    /// <typeparam name="TIn">The type of elements in the source collection.</typeparam>
    /// <typeparam name="T">The type of elements in the resulting array.</typeparam>
    /// <param name="source">The source read-only collection.</param>
    /// <param name="select">A transform function to apply to each element.</param>
    /// <returns>An array that contains the transformed elements.</returns>
    public static T[] SelectToArray<TIn, T>(
        this IReadOnlyCollection<TIn> source,
        Func<TIn, int, T> select) =>
        source is TIn[] sourceArray
            ? SelectArrayToArray(sourceArray, source.Count, ConvertFuncExcludeOrdinal(select))
            : SelectEnumerableToArray(source, source.Count, select);

    /// <summary>
    /// Projects each element of a read-only collection into a new array.
    /// </summary>
    /// <typeparam name="TIn">The type of elements in the source collection.</typeparam>
    /// <typeparam name="T">The type of elements in the resulting array.</typeparam>
    /// <param name="source">The source read-only collection.</param>
    /// <param name="select">A transform function to apply to each element.</param>
    /// <returns>An array that contains the transformed elements.</returns>
    [DebuggerStepThrough]
    public static T[] SelectToArray<TIn, T>(
        this IReadOnlyCollection<TIn> source,
        Func<TIn, T> select) =>
        source is TIn[] sourceArray
            ? SelectArrayToArray(sourceArray, source.Count, select)
            : SelectEnumerableToArray(source, source.Count, ConvertFuncIncludeOrdinal(select));

    /// <summary>
    /// Projects each element of a collection into a new array.
    /// </summary>
    /// <typeparam name="TIn">The type of elements in the source collection.</typeparam>
    /// <typeparam name="T">The type of elements in the resulting array.</typeparam>
    /// <param name="source">The source collection.</param>
    /// <param name="sourceLength">The expected length of the source collection.</param>
    /// <param name="select">A transform function to apply to each element.</param>
    /// <returns>An array that contains the transformed elements.</returns>
    [DebuggerStepThrough]
    public static T[] SelectToArray<TIn, T>(
        this IEnumerable<TIn> source,
        int sourceLength,
        Func<TIn, T> select) =>
        source is TIn[] sourceArray
            ? SelectArrayToArray(sourceArray, sourceLength, select)
            : SelectEnumerableToArray(source, sourceLength, ConvertFuncIncludeOrdinal(select));

    /// <summary>
    /// Converts a function that includes an ordinal parameter to one that excludes it.
    /// </summary>
    /// <typeparam name="TIn">The type of elements in the source collection.</typeparam>
    /// <typeparam name="T">The type of elements in the resulting array.</typeparam>
    /// <param name="select">A transform function to apply to each element.</param>
    /// <returns>A function that applies the transform without the ordinal parameter.</returns>
    private static Func<TIn, int, T> ConvertFuncIncludeOrdinal<TIn, T>(Func<TIn, T> select) => (item, _) => select(item);

    /// <summary>
    /// Converts a function that excludes an ordinal parameter to one that includes it.
    /// </summary>
    /// <typeparam name="TIn">The type of elements in the source collection.</typeparam>
    /// <typeparam name="T">The type of elements in the resulting array.</typeparam>
    /// <param name="select">A transform function to apply to each element.</param>
    /// <returns>A function that applies the transform with the ordinal parameter.</returns>
    private static Func<TIn, T> ConvertFuncExcludeOrdinal<TIn, T>(Func<TIn, int, T> select)
    {
        int i = 0;
        return (item) => select(item, i++);
    }

    /// <summary>
    /// Projects each element of a collection into a new array.
    /// </summary>
    /// <typeparam name="TIn">The type of elements in the source collection.</typeparam>
    /// <typeparam name="T">The type of elements in the resulting array.</typeparam>
    /// <param name="source">The source collection.</param>
    /// <param name="sourceLength">The expected length of the source collection.</param>
    /// <param name="select">A transform function to apply to each element.</param>
    /// <returns>An array that contains the transformed elements.</returns>
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

    /// <summary>
    /// Projects each element of an array into a new array.
    /// </summary>
    /// <typeparam name="TIn">The type of elements in the source array.</typeparam>
    /// <typeparam name="T">The type of elements in the resulting array.</typeparam>
    /// <param name="sourceArray">The source array.</param>
    /// <param name="expectedSourceLength">The expected length of the source array.</param>
    /// <param name="select">A transform function to apply to each element.</param>
    /// <returns>An array that contains the transformed elements.</returns>
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

    /// <summary>
    /// Attempts to return the object at the top of the immutable stack without removing it.
    /// </summary>
    /// <typeparam name="T">The type of elements in the stack.</typeparam>
    /// <param name="stack">The immutable stack.</param>
    /// <param name="value">When this method returns, contains the object at the top of the stack, if the stack is not empty; otherwise, the default value for the type of the value parameter.</param>
    /// <returns>true if the stack is not empty; otherwise, false.</returns>
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

    /// <summary>
    /// Projects each element of a collection into a new form based on a selector function, and filters out elements based on a condition.
    /// </summary>
    /// <typeparam name="T">The type of elements in the source collection.</typeparam>
    /// <typeparam name="TR">The type of elements in the resulting collection.</typeparam>
    /// <param name="source">The source collection.</param>
    /// <param name="selector">A function to test each element for a condition and project the element into a new form.</param>
    /// <returns>An enumerable collection that contains the transformed elements that satisfy the condition.</returns>
    public static IEnumerable<TR> SelectWhere<T, TR>(
        this IEnumerable<T> source,
        Func<T, (bool include, TR resultOrDefault)> selector)
    {
        foreach (var item in source)
            if (selector(item) is (include: true, { } resultOrDefault))
                yield return resultOrDefault;
    }

    public static IEnumerable<TR> SelectWhereNotNull<T, TR>(
        this IEnumerable<T> enumerable,
        Func<T, TR?> selectNullable)
        where TR : notnull =>
        enumerable.SelectWhere(o => selectNullable(o) is { } r ? (true, r) : default);
}
