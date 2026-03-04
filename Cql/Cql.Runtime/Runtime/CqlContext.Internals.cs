// We consider the content here as internal thus it won't be documented in the public API docs.
#pragma warning disable RS0016 // Symbol 'x' is not part of the declared public API

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
    /// This counter is reset when <see cref="CqlContext.UseNewCache"/> or <see cref="CqlContext.DontUseCaching"/> is called.
    /// </remarks>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    long CacheCallCount { get; }

    /// <summary>
    /// Gets the number of times the factory function was invoked (cache misses).
    /// </summary>
    /// <remarks>
    /// This counter is reset when <see cref="CqlContext.UseNewCache"/> or <see cref="CqlContext.DontUseCaching"/> is called.
    /// </remarks>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    long CacheMisses { get; }

    /// <summary>
    /// Gets the number of cache hits (calls where a cached value was returned).
    /// </summary>
    /// <remarks>
    /// Cache hits = Total calls to GetOrCompute - Factory invocations (cache misses).
    /// This counter is reset when <see cref="CqlContext.UseNewCache"/> or <see cref="CqlContext.DontUseCaching"/> is called.
    /// </remarks>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
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

    /// <summary>
    /// Gets or computes a cached value for the specified cache key using a context-aware factory function.
    /// </summary>
    /// <typeparam name="T">The type of the cached value.</typeparam>
    /// <param name="cacheKey">The unique key identifying the cached value.</param>
    /// <param name="factory">A function that accepts the <see cref="CqlContext"/> and computes the value if it's not in the cache.</param>
    /// <returns>The cached or newly computed value.</returns>
    /// <remarks>
    /// This overload avoids capturing the context in a closure by passing it as an explicit parameter
    /// to the factory function, reducing heap allocations on every definition call.
    /// This method is thread-safe and can be called concurrently from multiple threads.
    /// If caching is disabled (cache is null), the factory function is called without caching the result.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public T GetOrCompute<T>(long cacheKey, Func<CqlContext, T> factory)
    {
        Interlocked.Increment(ref _cacheCallCount);

        var cache = _cache;
        if (cache is null)
        {
            // Caching disabled
            Interlocked.Increment(ref _cacheFactoryInvocations);
            return factory(this);
        }

        // Use GetOrAdd for lock-free read and atomic add
        // Note: We box the result, so null values are preserved correctly
        var cachedValue = cache.GetOrAdd(cacheKey, _ =>
        {
            Interlocked.Increment(ref _cacheFactoryInvocations);
            return factory(this)!;
        });

        return (T)cachedValue!;
    }
}