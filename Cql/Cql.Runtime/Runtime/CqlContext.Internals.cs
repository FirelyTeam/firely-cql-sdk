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

    T ICqlContextInternals.GetOrCompute<T>(long cacheKey, Func<T> factory) =>
        GetOrComputeCore(cacheKey, factory, static f => f());

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
    public T GetOrCompute<T>(long cacheKey, Func<CqlContext, T> factory) =>
        GetOrComputeCore(cacheKey, (factory, this), static s => s.Item1(s.Item2));

    /// <summary>
    /// Core implementation for <see cref="GetOrCompute{T}"/> overloads.
    /// Uses a state-threading pattern so callers can pass context without heap closures.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private T GetOrComputeCore<TState, T>(long cacheKey, TState state, Func<TState, T> factoryInvoker)
    {
        Interlocked.Increment(ref _cacheCallCount);

        var cache = _cache;
        if (cache is null)
        {
            // Caching disabled
            Interlocked.Increment(ref _cacheFactoryInvocations);
            return factoryInvoker(state);
        }

        // Fast path: cache hit — zero allocation.
        if (cache.TryGetValue(cacheKey, out var existing))
            return (T)existing!;

        // Slow path: compute and cache without a lambda allocation.
        // Two threads may both miss TryGetValue and both call the factory; the value
        // that loses the GetOrAdd race is discarded. This is safe because CQL
        // expression bodies are pure and side-effect free, and slightly over-counting
        // _cacheFactoryInvocations in that edge case is acceptable for statistics.
        Interlocked.Increment(ref _cacheFactoryInvocations);
        var value = (object?)factoryInvoker(state);
        return (T)cache.GetOrAdd(cacheKey, value)!;
    }
}