/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Runtime;

public partial class CqlContext
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
    /// Initializes and starts a new cache for CQL library invocations using the specified invocation set and cache
    /// write strategy.
    /// </summary>
    /// <remarks>This method can only be called once per instance. Subsequent calls will result in an
    /// exception.</remarks>
    /// <param name="libraryInvocationSet">The set of CQL library invocations to be cached. Cannot be null.</param>
    /// <param name="cacheWriteStrategy">The strategy that determines when cache entries are written. The default is ExecutionAndPublication.</param>
    /// <exception cref="ArgumentNullException">Thrown if the libraryInvocationSet parameter is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown if caching has already been started for this instance.</exception>
    public void StartCaching(
        CqlLibraryInvocationSet libraryInvocationSet,
        CacheWriteStrategy cacheWriteStrategy = CacheWriteStrategy.ExecutionAndPublication)
    {
        if (libraryInvocationSet is null)
            throw new ArgumentNullException(nameof(libraryInvocationSet));

        if (_cache is not null)
            throw new InvalidOperationException("Caching has already been called once.");

        _cache = new CqlLibraryInvocationCache();
        _cache.StartNewCache(libraryInvocationSet, cacheWriteStrategy);
    }

    /// <summary>
    /// Stops caching for this context and resets cache statistics.
    /// </summary>
    public void StopCaching()
    {
        if (_cache is null)
            return;

        _cache.StopCache();
        _cache = null;
    }

    /// <summary>
    /// Begins a new caching scope for the specified set of CQL library invocations, using the provided cache write
    /// strategy.
    /// </summary>
    /// <remarks>Use this method to control caching behavior for a group of CQL library invocations. Nested
    /// caching scopes are NOT supported. Ensure the returned CachingScope is properly disposed to finalize caching
    /// operations.</remarks>
    /// <param name="libraryInvocationSet">The set of CQL library invocations to be included in the caching scope. Cannot be null.</param>
    /// <param name="cacheWriteStrategy">The strategy that determines when cache entries are written. The default is ExecutionAndPublication.</param>
    /// <returns>A CachingScope object that manages the lifetime of the caching scope. Disposing the returned object ends the
    /// scope and applies the selected cache write strategy.</returns>
    /// <exception cref="ArgumentNullException">Thrown if the libraryInvocationSet parameter is null.</exception>
    /// <exception cref="InvalidOperationException">Thrown if caching has already been started for this instance.</exception>
    public CachingScope StartCachingScope(
        CqlLibraryInvocationSet libraryInvocationSet,
        CacheWriteStrategy cacheWriteStrategy = CacheWriteStrategy.ExecutionAndPublication)
    {
        StartCaching(libraryInvocationSet, cacheWriteStrategy);
        return new CachingScope(this);
    }

    /// <summary>
    /// Defines a scope for managing caching operations within a CQL context. Disposing the scope stops caching and
    /// releases associated resources.
    /// </summary>
    /// <remarks>Use CachingScope to control the lifetime of caching within a specific context. Disposing the
    /// scope ensures that all caching activity is properly finalized and resources are released. This type should be
    /// used within a using statement to guarantee disposal, especially in scenarios where deterministic cleanup is
    /// required.</remarks>
    /// <param name="cqlContext">The CQL context in which caching operations are managed. Cannot be null.</param>
    public readonly ref struct CachingScope(CqlContext cqlContext) : IDisposable
    {
        /// <summary>
        /// Releases resources used by the current instance and stops any ongoing caching operations.
        /// </summary>
        /// <remarks>Call this method when the instance is no longer needed to ensure that all resources
        /// are properly released. After calling Dispose, the instance should not be used.</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose() => cqlContext.StopCaching();
    }

    /// <summary>
    /// Gets or computes a cached value for the specified cache index.
    /// </summary>
    /// <typeparam name="T">The type of the cached value.</typeparam>
    /// <param name="cacheIndex">The cache index identifying the cached expression.</param>
    /// <param name="factory">A function to compute the value if it's not in the cache.</param>
    /// <returns>The cached or newly computed value.</returns>
    /// <remarks>
    /// <para>
    /// <strong>⚠️ INTERNAL USE ONLY</strong> - This method is intended to be called only by generated CQL libraries.
    /// Do not call this method directly in application code.
    /// </para>
    /// <para>
    /// This method provides direct access to the invocation cache without interface casting overhead,
    /// enabling better JIT inlining and performance for the hot-path expression evaluation in generated libraries.
    /// </para>
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [EditorBrowsable(EditorBrowsableState.Never)] // Hide from IntelliSense
    [Browsable(false)]                            // Hide from property grids and designers
    public T GetOrCompute<T>(int cacheIndex, Func<CqlContext, T> factory)
    {
        var cache = _cache;
        if (cache is null)
            return factory(this);

        return cache.GetOrCompute(cacheIndex, factory, this);
    }
}