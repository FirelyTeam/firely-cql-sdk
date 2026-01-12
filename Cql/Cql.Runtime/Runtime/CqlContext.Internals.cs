#nullable enable

namespace Hl7.Cql.Runtime;

/// <summary>
/// Defines members that provide internal context information for internal use by CQL libraries.
/// </summary>
/// <remarks>This interface is intended for internal scenarios where access to internal context details is
/// required. It is not intended for general application use and may be subject to change in future
/// versions.</remarks>
[EditorBrowsable(EditorBrowsableState.Advanced)]
public interface ICqlContextInternals
{
    /// <summary>
    /// Gets or computes a cached value for the specified cache key.
    /// </summary>
    /// <typeparam name="T">The type of the cached value.</typeparam>
    /// <param name="cacheKey">The unique key identifying the cached value.</param>
    /// <param name="factory">A function to compute the value if it's not in the cache.</param>
    /// <returns>The cached or newly computed value.</returns>
    /// <remarks>
    /// This method is thread-safe and can be called concurrently from multiple threads.
    /// If caching is disabled (cache is null), the factory function is called without caching the result.
    /// </remarks>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public T GetOrCompute<T>(long cacheKey, Func<T> factory);

    /// <summary>
    /// Gets the total number of calls to GetOrCompute.
    /// </summary>
    /// <remarks>
    /// This counter is reset when <see cref="UseNewCache"/> or <see cref="DontUseCaching"/> is called.
    /// </remarks>
    long CacheCallCount { get; }

    /// <summary>
    /// Gets the number of times the factory function was invoked (cache misses).
    /// </summary>
    /// <remarks>
    /// This counter is reset when <see cref="UseNewCache"/> or <see cref="DontUseCaching"/> is called.
    /// </remarks>
    long CacheMisses { get; }

    /// <summary>
    /// Gets the number of cache hits (calls where a cached value was returned).
    /// </summary>
    /// <remarks>
    /// Cache hits = Total calls to GetOrCompute - Factory invocations (cache misses).
    /// This counter is reset when <see cref="UseNewCache"/> or <see cref="DontUseCaching"/> is called.
    /// </remarks>
    long CacheHits { get; }
}

partial class CqlContext : ICqlContextInternals
{
    private ConcurrentDictionary<long, object?>? _cache;
    private long _cacheCallCount;
    private long _cacheFactoryInvocations;

    /// <summary>
    /// Gets the total number of calls to GetOrCompute.
    /// </summary>
    /// <remarks>
    /// This counter is reset when <see cref="UseNewCache"/> or <see cref="DontUseCaching"/> is called.
    /// </remarks>
    long ICqlContextInternals.CacheCallCount => _cacheCallCount;

    /// <summary>
    /// Gets the number of times the factory function was invoked (cache misses).
    /// </summary>
    /// <remarks>
    /// This counter is reset when <see cref="UseNewCache"/> or <see cref="DontUseCaching"/> is called.
    /// </remarks>
    long ICqlContextInternals.CacheMisses => _cacheFactoryInvocations;

    /// <summary>
    /// Gets the number of cache hits (calls where a cached value was returned).
    /// </summary>
    /// <remarks>
    /// Cache hits = Total calls to GetOrCompute - Factory invocations (cache misses).
    /// This counter is reset when <see cref="UseNewCache"/> or <see cref="DontUseCaching"/> is called.
    /// </remarks>
    long ICqlContextInternals.CacheHits => _cacheCallCount - _cacheFactoryInvocations;

    /// <summary>
    /// Invalidates the current cache, forcing subsequent operations to use fresh data.
    /// </summary>
    /// <remarks>Call this method to clear any cached data and ensure that future operations do not use stale
    /// information. This is useful when the underlying data source has changed and the cache needs to be
    /// refreshed.</remarks>
    public void UseNewCache()
    {
        _cache = new ConcurrentDictionary<long, object?>();
        _cacheCallCount = 0;
        _cacheFactoryInvocations = 0;
    }

    /// <summary>
    /// Disables caching for subsequent operations by resetting the cache state.
    /// </summary>
    /// <remarks>Call this method to ensure that future operations do not use any previously cached data. This
    /// may impact performance if caching is typically used to improve efficiency.</remarks>
    public void DontUseCaching()
    {
        _cache = null;
        _cacheCallCount = 0;
        _cacheFactoryInvocations = 0;
    }

    T ICqlContextInternals.GetOrCompute<T>(long cacheKey, Func<T> factory)
    {
        Interlocked.Increment(ref _cacheCallCount);

        var cache = _cache;
        if (cache is null)
        {
            // Caching disabled
            Interlocked.Increment(ref _cacheFactoryInvocations);
            return factory();
        }

        // Use GetOrAdd for lock-free read and atomic add
        // Note: We box the result, so null values are preserved correctly
        var cachedValue = cache.GetOrAdd(cacheKey, _ =>
        {
            Interlocked.Increment(ref _cacheFactoryInvocations);
            return factory()!;
        });

        return (T)cachedValue!;
    }
}