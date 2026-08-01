/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

namespace Hl7.Cql.Runtime;

/// <summary>
/// A bounded, thread-safe cache whose reads never take a lock.
/// </summary>
/// <remarks>
/// <para>
/// Entries live in two generations. A lookup consults the current generation first and falls back to the
/// previous one, promoting a hit there back into the current generation. When the current generation reaches
/// half the capacity, it becomes the previous generation and the entries that were not used recently — the old
/// previous generation — are dropped wholesale. Total size therefore stays under <c>capacity</c>, and an entry
/// survives rotation exactly when it was read or written since the last rotation: an approximation of
/// least-recently-used eviction that needs no per-read bookkeeping.
/// </para>
/// <para>
/// This replaces designs that guard a linked-list LRU with one global lock, where every read is a lock
/// acquisition and a list splice. Reads here are plain <see cref="ConcurrentDictionary{TKey,TValue}"/> lookups;
/// only the rare rotation takes the instance lock.
/// </para>
/// </remarks>
internal sealed class TwoGenerationCache<TKey, TValue>
    where TKey : notnull
{
    private readonly int _generationCapacity;
    private readonly IEqualityComparer<TKey>? _comparer;
    private volatile ConcurrentDictionary<TKey, TValue> _current;
    private volatile ConcurrentDictionary<TKey, TValue> _previous;

    public TwoGenerationCache(int capacity, IEqualityComparer<TKey>? comparer = null)
    {
        if (capacity < 2)
            throw new ArgumentOutOfRangeException(nameof(capacity), capacity, "Capacity must be at least 2.");

        _generationCapacity = capacity / 2;
        _comparer = comparer;
        _current = NewGeneration();
        _previous = NewGeneration();
    }

    private ConcurrentDictionary<TKey, TValue> NewGeneration() =>
        _comparer is null ? new() : new(_comparer);

    public bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value)
    {
        var current = _current;
        if (current.TryGetValue(key, out value!))
            return true;

        if (_previous.TryGetValue(key, out value!))
        {
            // Promote, so the entry survives the next rotation. Racing promotions of the same key store the
            // same value, and a rotation racing this promotion at worst loses one promotion — a cache miss
            // later, not an error.
            Set(key, value);
            return true;
        }

        return false;
    }

    public void Set(TKey key, TValue value)
    {
        var current = _current;
        current[key] = value;

        if (current.Count < _generationCapacity)
            return;

        lock (this)
        {
            // Another thread may have rotated while this one waited on the lock; rotating again would
            // needlessly drop the entries that just survived.
            if (ReferenceEquals(current, _current))
            {
                _previous = _current;
                _current = NewGeneration();
            }
        }
    }

    public TValue GetOrAdd(TKey key, Func<TKey, TValue> factory)
    {
        if (TryGetValue(key, out var existing))
            return existing;

        // Two threads that miss concurrently may both run the factory; the results are equal for a pure
        // factory, and last-write-wins keeps the cache consistent either way.
        var value = factory(key);
        Set(key, value);
        return value;
    }
}
