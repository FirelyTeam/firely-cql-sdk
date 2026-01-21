using System.Threading;
using Hl7.Cql.Runtime.Internal;

namespace Hl7.Cql.Runtime;

partial class CqlContext
{
    private CacheEntry[]? _cache;
    private CacheIndexInitializer? _cacheIndexInitializer;
    private bool _cacheEnabled;
    private CacheWriteStrategy _cacheWriteStrategy;
    private long _cacheCallCount;
    private long _cacheFactoryInvocations;

    /// <summary>
    /// Initializes a new cache using the specified cache index initializer and write strategy.
    /// The cache is sized based on the total number of cache indices in the initializer.
    /// </summary>
    /// <param name="initializer">The cache index initializer that was used to initialize the libraries.
    /// This determines the cache size and is used to validate that libraries match this context.</param>
    /// <param name="writeStrategy">The strategy to use for handling concurrent writes to the cache.
    /// Defaults to <see cref="CacheWriteStrategy.ExecutionAndPublication"/>.</param>
    /// <remarks>
    /// Call this method to enable caching with a specific set of initialized libraries. The cache will be sized
    /// to accommodate all cache indices from the libraries processed by the initializer. Subsequent calls to
    /// GetOrCompute will validate that the calling library was initialized by this same initializer instance.
    /// </remarks>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="initializer"/> is null.</exception>
    public void UseNewCache(CacheIndexInitializer initializer, CacheWriteStrategy writeStrategy = CacheWriteStrategy.ExecutionAndPublication)
    {
        if (initializer is null)
            throw new ArgumentNullException(nameof(initializer));

        _cacheIndexInitializer = initializer;
        _cacheEnabled = true;
        _cacheWriteStrategy = writeStrategy;

        var cacheIndexCount = initializer.CacheIndexCount;
        if (cacheIndexCount == 0)
        {
            _cache = null;
        }
        else
        {
            // Allocate cache array with exactly cacheIndexCount elements for 0-based indexing (indices from 0 to cacheIndexCount - 1)
            _cache = new CacheEntry[cacheIndexCount];

            // Initialize each cache entry (required since CacheEntry is now a class)
            for (int i = 0; i < _cache.Length; i++)
            {
                _cache[i] = new CacheEntry();
            }
        }

        // Use Interlocked.Exchange for thread-safe reset
        Interlocked.Exchange(ref _cacheCallCount, 0);
        Interlocked.Exchange(ref _cacheFactoryInvocations, 0);
    }

    /// <summary>
    /// Disables caching for subsequent operations by resetting the cache state.
    /// </summary>
    /// <remarks>Call this method to ensure that future operations do not use any previously cached data. This
    /// may impact performance if caching is typically used to improve efficiency.</remarks>
    public void DontUseCaching()
    {
        if (!_cacheEnabled)
            return;

        _cacheEnabled = false;
        _cache = null;
        _cacheIndexInitializer = null;
        Interlocked.Exchange(ref _cacheCallCount, 0);
        Interlocked.Exchange(ref _cacheFactoryInvocations, 0);
    }
}