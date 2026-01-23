/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Runtime.Graphs;
using Hl7.Cql.Runtime.Internal;

namespace Hl7.Cql.Runtime;

/// <summary>
/// Manages invocation cache for CQL libraries, providing cached execution results for library expressions.
/// </summary>
/// <remarks>
/// This class provides a thread-safe invocation cache that stores computed expression values and
/// returns cached results on subsequent calls. The cache size is determined by a CqlLibraryInvocationSet
/// which handles cache index initialization.
/// </remarks>
public sealed class CqlLibraryInvocationCache
{
    private CacheWriteStrategy _cacheWriteStrategy;
    private CacheEntry[]? _cache;
    private long _cacheCallCount;
    private long _cacheFactoryInvocations;

    /// <summary>
    /// Gets the total count of cache entries in this cache.
    /// </summary>
    public int CacheEntriesCount => _cache?.Length ?? 0;

    /// <summary>
    /// Gets the total number of calls to GetOrCompute.
    /// </summary>
    public long CacheCallCount => Interlocked.Read(ref _cacheCallCount);

    /// <summary>
    /// Gets the number of times the factory function was invoked (cache misses).
    /// </summary>
    public long CacheMisses => Interlocked.Read(ref _cacheFactoryInvocations);

    /// <summary>
    /// Gets the number of cache hits (calls where a cached value was returned).
    /// </summary>
    /// <remarks>
    /// Cache hits = Total calls to GetOrCompute - Factory invocations (cache misses).
    /// </remarks>
    public long CacheHits => CacheCallCount - CacheMisses;

    /// <summary>
    /// Gets or computes a cached value for the specified cache index.
    /// </summary>
    /// <typeparam name="T">The type of the cached value.</typeparam>
    /// <param name="cacheIndex">The index identifying the cached value.</param>
    /// <param name="factory">A function to compute the value if it's not in the cache.</param>
    /// <param name="context">The CQL context to pass to the factory function.</param>
    /// <returns>The cached or newly computed value.</returns>
    /// <remarks>
    /// This method is thread-safe and can be called concurrently from multiple threads.
    /// If caching is disabled (cache is null) or the cache index is invalid, the factory function is called without caching the result.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public T GetOrCompute<T>(
        int cacheIndex,
        Func<CqlContext, T> factory,
        CqlContext context)
    {
        Interlocked.Increment(ref _cacheCallCount);

        var cache = _cache;

        if (cache is null || cacheIndex < 0 || cacheIndex >= cache.Length)
        {
            Interlocked.Increment(ref _cacheFactoryInvocations);
            return factory(context);
        }

        var entry = cache[cacheIndex];
        if (entry.IsCached)
        {
            return (T)entry.Value!;
        }

        if (_cacheWriteStrategy == CacheWriteStrategy.ExecutionAndPublication)
        {
            lock (entry)
            {
                if (entry.IsCached)
                {
                    return (T)entry.Value!;
                }

                Interlocked.Increment(ref _cacheFactoryInvocations);
                var value = factory(context);

                entry.Value = value;
                entry.IsCached = true;

                return value;
            }
        }
        else
        {
            Interlocked.Increment(ref _cacheFactoryInvocations);
            var value = factory(context);

            entry.Value = value;
            entry.IsCached = true;

            return value;
        }
    }

    /// <summary>
    /// Gets a value indicating whether caching is enabled for this instance.
    /// </summary>
    public bool CacheEnabled => _cache is not null;

    /// <summary>
    /// Stops the cache and resets cache statistics.
    /// </summary>
    public void StopCache()
    {
        _cache = null;
        ResetStats();
    }

    private void ResetStats()
    {
        _cacheCallCount = 0;
        _cacheFactoryInvocations = 0;
    }

    /// <summary>
    /// Initializes a new cache using the specified library invocation set and cache write strategy, replacing any existing cache and resetting
    /// related statistics.
    /// </summary>
    /// <param name="librarySet">The library invocation set that defines the cache size and initialized libraries.</param>
    /// <param name="cacheWriteStrategy">The strategy to use when writing to the cache. The default is CacheWriteStrategy.ExecutionAndPublication.</param>
    /// <remarks>Call this method to reset the cache and its statistics. Any previously cached entries will be
    /// discarded. Use the cacheWriteStrategy parameter to control how cache writes are handled after
    /// initialization.</remarks>
    public void StartNewCache(
        CqlLibraryInvocationSet librarySet,
        CacheWriteStrategy cacheWriteStrategy = CacheWriteStrategy.ExecutionAndPublication)
    {
        if (librarySet is null)
            throw new ArgumentNullException(nameof(librarySet));

        _cacheWriteStrategy = cacheWriteStrategy;

        var cacheLength = librarySet.CacheEntriesCount;
        if (cacheLength <= 0)
        {
            _cache = null;
            ResetStats();
            return;
        }

        var cache = new CacheEntry[cacheLength];
        for (int i = 0; i < cache.Length; i++)
            cache[i] = new CacheEntry();

        _cache = cache;
        ResetStats();
        
        // Set this cache instance on all libraries in the set
        librarySet.SetCacheInstanceOnLibraries(this);
    }
}