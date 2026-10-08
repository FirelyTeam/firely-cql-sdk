/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

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
}