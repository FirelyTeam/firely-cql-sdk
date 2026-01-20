using Hl7.Cql.Runtime.Internal;

namespace Hl7.Cql.Runtime;

partial class CqlContext
{
    private CacheEntry[]? _cache;
    private int _cacheIndexCount;
    private bool _cacheEnabled;
    private CacheWriteStrategy _cacheWriteStrategy;
    private long _cacheCallCount;
    private long _cacheFactoryInvocations;

    /// <summary>
    /// Invalidates the current cache, forcing subsequent operations to use fresh data.
    /// </summary>
    /// <param name="writeStrategy">The strategy to use for handling concurrent writes to the cache.
    /// Defaults to <see cref="CacheWriteStrategy.ExecutionAndPublication"/>.</param>
    /// <remarks>Call this method to clear any cached data and ensure that future operations do not use stale
    /// information. This is useful when the underlying data source has changed and the cache needs to be
    /// refreshed.</remarks>
    /// <exception cref="InvalidOperationException">Thrown if caching has not been enabled first by calling
    /// <see cref="CqlContextExtensions.WithCacheIndexCount"/>.</exception>
    public void UseNewCache(CacheWriteStrategy writeStrategy = CacheWriteStrategy.ExecutionAndPublication)
    {
        if (_cacheIndexCount is 0)
            return;

        _cacheEnabled = true;
        _cacheWriteStrategy = writeStrategy;
        _cache = new CacheEntry[_cacheIndexCount];
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
        if (!_cacheEnabled)
            return;

        _cacheEnabled = false;
        _cache = null;
        _cacheCallCount = 0;
        _cacheFactoryInvocations = 0;
    }

    internal void SetCacheIndexCount(int count)
    {
        // REVIEW: Should we fail when called multiple times with different counts?
        _cacheIndexCount = count;

        // Reset cache fields
        _cache = null;
        _cacheCallCount = 0;
        _cacheFactoryInvocations = 0;
    }
}



/// <summary>
/// Provides extension methods for configuring and working with instances of the CqlContext class.
/// </summary>
/// <remarks>These extension methods enable fluent configuration of CqlContext instances. Methods in this
/// class are intended to simplify context setup and enhance code readability when working with CQL-based
/// operations.</remarks>
public static class CqlContextExtensions
{
    /// <summary>
    /// Provides extension methods for configuring and working with instances of a CqlContext-derived type.
    /// </summary>
    /// <typeparam name="TCqlContext">The type of the context to extend. Must inherit from CqlContext.</typeparam>
    /// <param name="context">The context instance to configure. Cannot be null.</param>
    extension<TCqlContext>(TCqlContext context) where TCqlContext : CqlContext
    {
        /// <summary>
        /// Configures the number of cache indexes to use in the context and returns the updated context instance.
        /// To enable caching, call the <see cref="CqlContext.UseNewCache"/> method after setting the cache index count.
        /// </summary>
        /// <param name="cacheIndexCount">The number of cache indexes to set. Must be a non-negative integer.</param>
        /// <returns>The updated context instance with the specified cache index count applied.</returns>
        public TCqlContext WithCacheIndexCount(int cacheIndexCount)
        {
            context.SetCacheIndexCount(cacheIndexCount);
            return context;
        }
    }
}