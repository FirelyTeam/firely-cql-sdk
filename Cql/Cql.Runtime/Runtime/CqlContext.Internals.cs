// We consider the content here as internal thus it won't be documented in the public API docs.

using Hl7.Cql.Abstractions.Infrastructure;

#pragma warning disable RS0016 // Symbol 'x' is not part of the declared public API

namespace Hl7.Cql.Runtime.Internal
{
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
        /// Gets or computes a cached value for the specified cache index.
        /// </summary>
        /// <typeparam name="T">The type of the cached value.</typeparam>
        /// <param name="cacheIndex">The index identifying the cached value.</param>
        /// <param name="factory">A function to compute the value if it's not in the cache.</param>
        /// <returns>The cached or newly computed value.</returns>
        /// <remarks>
        /// This method is thread-safe and can be called concurrently from multiple threads.
        /// If caching is disabled (cache is null), the factory function is called without caching the result.
        /// </remarks>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public T GetOrCompute<T>(int cacheIndex, Func<CqlContext, T> factory);

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
}

namespace Hl7.Cql.Runtime
{
    partial class CqlContext : Internal.ICqlContextInternals
    {
        /// <summary>
        /// Gets the total number of calls to GetOrCompute.
        /// </summary>
        /// <remarks>
        /// This counter is reset when <see cref="UseNewCache"/> or <see cref="DontUseCaching"/> is called.
        /// </remarks>
        long Internal.ICqlContextInternals.CacheCallCount => _cacheCallCount;

        /// <summary>
        /// Gets the number of times the factory function was invoked (cache misses).
        /// </summary>
        /// <remarks>
        /// This counter is reset when <see cref="UseNewCache"/> or <see cref="DontUseCaching"/> is called.
        /// </remarks>
        long Internal.ICqlContextInternals.CacheMisses => _cacheFactoryInvocations;

        /// <summary>
        /// Gets the number of cache hits (calls where a cached value was returned).
        /// </summary>
        /// <remarks>
        /// Cache hits = Total calls to GetOrCompute - Factory invocations (cache misses).
        /// This counter is reset when <see cref="UseNewCache"/> or <see cref="DontUseCaching"/> is called.
        /// </remarks>
        long Internal.ICqlContextInternals.CacheHits => _cacheCallCount - _cacheFactoryInvocations;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        T Internal.ICqlContextInternals.GetOrCompute<T>(int cacheIndex, Func<CqlContext, T> factory)
        {
            Interlocked.Increment(ref _cacheCallCount);

            var cache = _cache;

            // If cacheIndex is 0 or cache is disabled, compute directly without caching
            if (!_cacheEnabled || cache is null || cacheIndex <= 0)
            {
                Interlocked.Increment(ref _cacheFactoryInvocations);
                return factory(this);
            }

            // Ensure cache index is within bounds
            if (cacheIndex >= cache.Length)
            {
                // Index out of range - compute without caching
                Interlocked.Increment(ref _cacheFactoryInvocations);
                return factory(this);
            }

            // Try to get from cache - volatile read on the IsCached field ensures thread-safe visibility
            var entry = cache[cacheIndex];
            if (entry.IsCached)
            {
                // Cache hit - return the cached value (which may be null)
                // The value field is guaranteed to be set before IsCached is set to true
                return (T)entry.Value!;
            }

            // Cache miss - use the configured write strategy
            if (_cacheWriteStrategy == CacheWriteStrategy.ExecutionAndPublication)
            {
                // Ensure only one thread computes - use lock on the cache entry for fine-grained locking
                lock (entry)
                {
                    // Double-check after acquiring lock
                    if (entry.IsCached)
                    {
                        return (T)entry.Value!;
                    }

                    // Compute value
                    Interlocked.Increment(ref _cacheFactoryInvocations);
                    var value = factory(this);

                    // Store in cache - set value first, then IsCached
                    entry.Value = value;
                    entry.IsCached = true; // volatile field ensures memory barrier

                    return value;
                }
            }
            else // PublicationOnly - multiple threads can compute, last write wins
            {
                // Compute value without locking
                Interlocked.Increment(ref _cacheFactoryInvocations);
                var value = factory(this);

                // Store in cache - set value first, then IsCached
                // The volatile field ensures proper memory ordering: value is visible before IsCached becomes true
                entry.Value = value;
                entry.IsCached = true; // volatile field ensures memory barrier

                return value;
            }
        }
    }
}
