/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Runtime.InteropServices;

namespace Hl7.Cql.Abstractions.Infrastructure;

internal static class DictionaryExtensions
{
    public static TValue GetOrAdd<TKey, TValue>(
        this Dictionary<TKey, TValue> dictionary,
        TKey key,
        Func<TKey, TValue> valueFactory) where TKey : notnull
    {
        ref var valueRef = ref CollectionsMarshal.GetValueRefOrAddDefault(dictionary, key, out bool exists);
        return exists ? valueRef! : valueRef = valueFactory(key);
    }

    /// <summary>
    /// This method is similar to <see cref="CollectionExtensions.GetValueOrDefault{TKey,TValue}(System.Collections.Generic.IReadOnlyDictionary{TKey,TValue},TKey)"/>
    /// which returns the first element of a sequence of values if it is not empty;
    /// however, for value types this might not be the desired behavior as there isn't
    /// a way to distinguish between the default value and a value in the sequence.
    /// Therefore, this method returns null for value types if the sequence is empty.
    /// </summary>
    public static TValue? GetValueOrNull<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> dictionary, TKey key)
        where TValue : struct =>
        dictionary switch
        {
            IDictionary<TKey, TValue> d         => d.TryGetValue(key, out var value1) ? value1 : null,
            IReadOnlyDictionary<TKey, TValue> d => d.TryGetValue(key, out var value2) ? value2 : null,
            _ => throw new ArgumentException(
                     "Must be a IReadOnlyDictionary<TKey, TValue> or an IDictionary<TKey, TValue>. Enumerating the key values as a fallback not supported for performance reasons.")
        };

    /// <summary>
    /// Transforms a sequence of <see cref="KeyValuePair{TKey, TValue}"/> to a sequence of key-value tuples.
    /// </summary>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <param name="keyValuePairs">The sequence of <see cref="KeyValuePair{TKey, TValue}"/>.</param>
    /// <returns>A sequence of key-value tuples.</returns>
    public static IEnumerable<(TKey Key, TValue Value)> AsValueTuples<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> keyValuePairs) =>
        keyValuePairs.Select(kvp => (kvp.Key, kvp.Value));
}