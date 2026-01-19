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
    /// <summary>
    /// Cache entry that stores both the key and value.
    /// </summary>
    private sealed class CacheEntry
    {
        public long Key;
        public object? Value;
        /// <summary>
        /// Indicates whether the value has been computed and stored.
        /// This is necessary to distinguish between a null value that hasn't been computed yet
        /// and a null value that is the actual cached result.
        /// </summary>
        public volatile bool IsReady;
    }

    /// <summary>
    /// Array-based cache with linear probing for collision resolution.
    /// Null indicates caching is disabled.
    /// </summary>
    private CacheEntry[]? _cache;

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

        // Map cache key to array index using modulo
        // Handle negative keys by ensuring the result is always positive
        var index = (int)((cacheKey % cache.Length + cache.Length) % cache.Length);

        // Linear probing: search for the key or an empty slot
        var startIndex = index;
        while (true)
        {
            var entry = Volatile.Read(ref cache[index]);

            if (entry is null)
            {
                // Empty slot found - try to claim it
                var newEntry = new CacheEntry { Key = cacheKey, Value = null, IsReady = false };
                var existingEntry = Interlocked.CompareExchange(ref cache[index], newEntry, null);

                if (existingEntry is null)
                {
                    // We claimed the slot - compute the value
                    Interlocked.Increment(ref _cacheFactoryInvocations);
                    var value = factory();
                    newEntry.Value = value;
                    newEntry.IsReady = true; // Signal that the value is ready
                    return value;
                }

                // Another thread claimed the slot - check if it's our key
                entry = existingEntry;
            }

            if (entry.Key == cacheKey)
            {
                // Found our key - spin until value is ready
                // Use a hybrid approach: spin briefly, then yield to avoid CPU waste
                var spinCount = 0;
                while (!entry.IsReady)
                {
                    if (spinCount < 10)
                    {
                        Thread.SpinWait(1);
                        spinCount++;
                    }
                    else
                    {
                        Thread.Yield();
                    }
                }
                return (T)entry.Value!;
            }

            // Collision - try next slot (linear probing)
            index = (index + 1) % cache.Length;

            // If we've wrapped around completely, fall back to computing without caching
            // This should be extremely rare
            if (index == startIndex)
            {
                Interlocked.Increment(ref _cacheFactoryInvocations);
                return factory();
            }
        }
    }
}