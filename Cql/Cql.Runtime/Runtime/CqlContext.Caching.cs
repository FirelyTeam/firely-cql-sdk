/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime.Internal;
using System.Runtime.CompilerServices;

namespace Hl7.Cql.Runtime;

public partial class CqlContext : ICqlContextInternals
{
    private CqlLibraryInvocationCache? _cache;

    /// <summary>
    /// Gets a value indicating whether caching is currently enabled for this context.
    /// </summary>
    public bool CachingEnabled => _cache?.CacheEnabled ?? false;

    /// <summary>
    /// Gets the total number of calls to GetOrCompute on this context's cache.
    /// </summary>
    public long CacheCallCount => _cache?.CacheCallCount ?? 0;

    /// <summary>
    /// Gets the number of times the factory function was invoked (cache misses) on this context's cache.
    /// </summary>
    public long CacheMisses => _cache?.CacheMisses ?? 0;

    /// <summary>
    /// Gets the number of cache hits (calls where a cached value was returned) on this context's cache.
    /// </summary>
    public long CacheHits => _cache?.CacheHits ?? 0;

    /// <summary>
    /// Starts caching for this context using the specified library invocation set.
    /// </summary>
    /// <param name="libraryInvocationSet">The library invocation set that defines the cache size.</param>
    /// <param name="cacheWriteStrategy">The strategy to use when writing to the cache. The default is CacheWriteStrategy.ExecutionAndPublication.</param>
    /// <remarks>
    /// This method creates a new cache and resets all cache statistics. Any previously cached entries will be discarded.
    /// </remarks>
    public void StartCaching(
        CqlLibraryInvocationSet libraryInvocationSet,
        CacheWriteStrategy cacheWriteStrategy = CacheWriteStrategy.ExecutionAndPublication)
    {
        if (libraryInvocationSet is null)
            throw new ArgumentNullException(nameof(libraryInvocationSet));

        _cache = new CqlLibraryInvocationCache();
        _cache.StartNewCache(libraryInvocationSet, cacheWriteStrategy);
    }

    /// <summary>
    /// Stops caching for this context and resets cache statistics.
    /// </summary>
    public void StopCaching()
    {
        if (_cache is not null)
        {
            _cache.StopCache();
            _cache = null;
        }
    }

    /// <summary>
    /// Gets or computes a cached value for the specified cache index.
    /// </summary>
    /// <typeparam name="T">The type of the cached value.</typeparam>
    /// <param name="cacheIndex">The index identifying the cached value.</param>
    /// <param name="factory">A function to compute the value if it's not in the cache.</param>
    /// <returns>The cached or newly computed value.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    T ICqlContextInternals.GetOrCompute<T>(int cacheIndex, Func<CqlContext, T> factory)
    {
        var cache = _cache;
        if (cache is null)
            return factory(this);

        return cache.GetOrCompute(cacheIndex, factory, this);
    }
}
