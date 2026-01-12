#nullable enable

using System.Collections.Concurrent;

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
}

partial class CqlContext : ICqlContextInternals
{
    private ConcurrentDictionary<long, object?>? _cache;

    /// <summary>
    /// Invalidates the current cache, forcing subsequent operations to use fresh data.
    /// </summary>
    /// <remarks>Call this method to clear any cached data and ensure that future operations do not use stale
    /// information. This is useful when the underlying data source has changed and the cache needs to be
    /// refreshed.</remarks>
    public void UseNewCache()
    {
        _cache = new ConcurrentDictionary<long, object?>();
    }

    /// <summary>
    /// Disables caching for subsequent operations by resetting the cache state.
    /// </summary>
    /// <remarks>Call this method to ensure that future operations do not use any previously cached data. This
    /// may impact performance if caching is typically used to improve efficiency.</remarks>
    public void DontUseCaching()
    {
        _cache = null;
    }

    T ICqlContextInternals.GetOrCompute<T>(long cacheKey, Func<T> factory)
    {
        var cache = _cache;
        if (cache is null)
        {
            // Caching disabled
            return factory();
        }

        // Use GetOrAdd for lock-free read and atomic add
        var cachedValue = cache.GetOrAdd(cacheKey, _ => factory());
        
        // Handle null values properly
        return cachedValue is null ? default! : (T)cachedValue;
    }
}