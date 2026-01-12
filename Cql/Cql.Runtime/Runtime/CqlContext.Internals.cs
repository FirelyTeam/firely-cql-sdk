#nullable enable

using System.Threading;

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
    /// Gets an object representing the current cache version.
    /// When caching is disabled, this value is <see langword="null"/>.
    /// When this value changes, it indicates that the cache was invalidated, and cached data should be refreshed on next access.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public long CacheVersion { get; }

    /// <summary>
    /// Gets or computes a cached value for the specified cache key.
    /// </summary>
    /// <typeparam name="T">The type of the cached value.</typeparam>
    /// <param name="cacheKey">The unique key identifying the cached value.</param>
    /// <param name="factory">A function to compute the value if it's not in the cache.</param>
    /// <returns>The cached or newly computed value.</returns>
    /// <remarks>
    /// This method provides thread-safe access to the cache. If caching is disabled (CacheVersion is 0),
    /// the factory function is called without caching the result.
    /// </remarks>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public T GetOrCompute<T>(string cacheKey, Func<T> factory);
}

partial class CqlContext : ICqlContextInternals
{
    private Dictionary<string, object?> _cache = [];

    /// <summary>
    /// Invalidates the current cache, forcing subsequent operations to use fresh data.
    /// </summary>
    /// <remarks>Call this method to clear any cached data and ensure that future operations do not use stale
    /// information. This is useful when the underlying data source has changed and the cache needs to be
    /// refreshed.</remarks>
    public void UseNewCache()
    {
        _cache = [];
    }

    /// <summary>
    /// Disables caching for subsequent operations by resetting the cache state.
    /// </summary>
    /// <remarks>Call this method to ensure that future operations do not use any previously cached data. This
    /// may impact performance if caching is typically used to improve efficiency.</remarks>
    public void DontUseCaching()
    {
        _cache = [];
    }

    long ICqlContextInternals.CacheVersion => _cache.GetHashCode();

    T ICqlContextInternals.GetOrCompute<T>(string cacheKey, Func<T> factory)
    {
        if (_cache.TryGetValue(cacheKey, out var cachedValue))
        {
            // Cache hit
            return (T)cachedValue!;
        }

        // Cache miss, compute and store
        var result = factory();
        _cache[cacheKey] = result;
        return result;
    }
}