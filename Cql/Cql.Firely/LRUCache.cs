/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Runtime;

namespace Hl7.Cql.Fhir
{
    /// <summary>
    /// A bounded cache of parsed values keyed by their source string, approximately least-recently-used.
    /// </summary>
    /// <remarks>
    /// Backed by <see cref="TwoGenerationCache{TKey,TValue}"/> so that reads never take a lock. The previous
    /// implementation guarded a linked-list LRU with one lock around every read and write; the default instance
    /// is process-wide and sits on the <c>FhirDateTime</c> → <c>CqlDateTime</c> conversion, which runs per value
    /// during an evaluation, so that lock was acquired for every date an evaluation touched — across all
    /// concurrently evaluating threads.
    /// </remarks>
    internal class LRUCache<T>
    {
        // Read by tests through reflection as the cache's configured capacity - keep the name and type.
        private readonly int Capacity;

        private readonly TwoGenerationCache<string, T> _cache;

        public LRUCache(int capacity)
        {
            Capacity = capacity;
            _cache = new TwoGenerationCache<string, T>(Math.Max(capacity, 2), StringComparer.Ordinal);
        }

        public void Insert(string key, T item)
        {
            if (item == null) return;

            _cache.Set(key, item);
        }

        public bool TryGetValue(string key, [MaybeNullWhen(false)] out T value)
        {
            if (key != null)
                return _cache.TryGetValue(key, out value);

            value = default;
            return false;
        }
    }
}
