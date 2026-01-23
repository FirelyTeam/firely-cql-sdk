/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Threading;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Runtime.Internal;

namespace Hl7.Cql.Runtime;

/// <summary>
/// Manages execution cache for CQL libraries, initializing cache indices and providing
/// cached execution results for library expressions.
/// </summary>
/// <remarks>
/// This class serves two purposes:
/// 1. Initializes cache index fields in CQL libraries and their dependencies by traversing
///    the library dependency graph and assigning sequential indices for array-based caching.
/// 2. Provides a thread-safe execution cache that stores computed expression values and
///    returns cached results on subsequent calls.
///
/// Libraries can be re-initialized with a new instance even if they were previously initialized,
/// allowing for scenarios like unit testing where libraries need to be reset between tests.
/// </remarks>
public sealed class CqlLibrariesExecutionCache
{
    private int _nextIndex = 0;
    private readonly CacheEntry[]? _cache;
    private readonly CacheWriteStrategy _cacheWriteStrategy;
    private long _cacheCallCount;
    private long _cacheFactoryInvocations;

    /// <summary>
    /// Gets the total count of cache index fields initialized across all libraries.
    /// </summary>
    public int CacheIndexCount { get; private set; }

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
    /// Initializes a new instance of the CqlLibrariesExecutionCache class using the specified libraries as roots.
    /// </summary>
    /// <param name="libraries">An array of root libraries to initialize. Each library and its dependencies will be
    /// processed in dependency-first order. Must not be null or empty.</param>
    /// <param name="writeStrategy">The strategy to use for handling concurrent writes to the cache.
    /// Defaults to <see cref="CacheWriteStrategy.ExecutionAndPublication"/>.</param>
    /// <remarks>
    /// If the libraries array is null or empty, no cache indices will be initialized and the cache will be disabled.
    /// The initialization processes each library and its dependencies only once, in dependency-first order.
    /// Libraries can be re-initialized with a different cache instance, allowing the same library instance
    /// to be used with multiple caches (e.g., for testing scenarios or cache isolation).
    /// </remarks>
    public CqlLibrariesExecutionCache(
        CacheWriteStrategy writeStrategy = CacheWriteStrategy.ExecutionAndPublication,
        params ILibrary[] libraries)
    {
        _cacheWriteStrategy = writeStrategy;

        if (libraries is not { Length: not 0 })
            return;

        int totalIndexCount = 0;
        foreach (var library in libraries)
        {
            if (library is ILibraryInternals internals)
            {
                totalIndexCount += internals.InitializeCacheIndices(this);
            }
        }

        CacheIndexCount = totalIndexCount;

        if (CacheIndexCount == 0)
        {
            _cache = null;
        }
        else
        {
            _cache = new CacheEntry[CacheIndexCount];
            for (int i = 0; i < _cache.Length; i++)
            {
                _cache[i] = new CacheEntry();
            }
        }
    }

    /// <summary>
    /// Gets the next sequential cache index value.
    /// </summary>
    /// <returns>The next cache index value (starting from 0).</returns>
    /// <remarks>
    /// This method is called during cache index initialization by generated library code
    /// to assign sequential indices to each cached expression field.
    /// </remarks>
    public int GetNextIndex()
    {
        return _nextIndex++;
    }

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
    public T GetOrCompute<T>(int cacheIndex, Func<CqlContext, T> factory, CqlContext context)
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
}