/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime.Internal;

namespace Hl7.Cql.Runtime;

/// <summary>
/// Manages invocation cache for CQL libraries, providing cached execution results for library expressions.
/// </summary>
/// <remarks>
/// <para>
/// This class provides a thread-safe invocation cache that stores computed expression values and
/// returns cached results on subsequent calls. The cache size is determined by a CqlLibraryInvocationSet
/// which handles cache index initialization.
/// This class is internal and accessed through CqlContext.
/// </para>
/// <para>
/// <strong>Note:</strong> For .NET 9+ (C# 13), this implementation uses System.Threading.Lock 
/// which provides better performance than traditional object-based locking. For earlier framework versions,
/// it falls back to object-based locking.
/// </para>
/// </remarks>
internal sealed class CqlLibraryInvocationCache
{
    private CacheWriteStrategy _cacheWriteStrategy;
    private CacheEntry[]? _entries;
#if NET9_0_OR_GREATER
    private Lock[]? _locks; // Use System.Threading.Lock for .NET 9+ (C# 13) for better performance
#else
    private object[]? _locks; // Fallback to object-based locking for earlier framework versions
#endif
    private int _cacheLength; // Track actual length since pooled array may be larger
    private long _cacheCallCount;
    private long _cacheFactoryInvocations;

    /// <summary>
    /// Initializes a new cache using the specified library invocation set and cache write strategy, replacing any existing cache and resetting
    /// related statistics.
    /// </summary>
    /// <param name="libraryInvocationSet">The library invocation set that defines the cache size.</param>
    /// <param name="cacheWriteStrategy">The strategy to use when writing to the cache. The default is CacheWriteStrategy.ExecutionAndPublication.</param>
    /// <remarks>Call this method to reset the cache and its statistics. Any previously cached entries will be
    /// discarded. Use the cacheWriteStrategy parameter to control how cache writes are handled after
    /// initialization.</remarks>
    internal void StartNewCache(
        CqlLibraryInvocationSet libraryInvocationSet,
        CacheWriteStrategy cacheWriteStrategy = CacheWriteStrategy.ExecutionAndPublication)
    {
        if (libraryInvocationSet is null)
            throw new ArgumentNullException(nameof(libraryInvocationSet));

        // Return previous arrays to pool
        ReturnArraysToPool();

        _cacheWriteStrategy = cacheWriteStrategy;

        var cacheLength = libraryInvocationSet.CacheEntriesCount;
        if (cacheLength <= 0)
        {
            _entries = null;
            _locks = null;
            _cacheLength = 0;
            ResetStats();
            return;
        }

        // Rent arrays from pool - may return larger arrays than requested
        var entries = ArrayPool<CacheEntry>.Shared.Rent(cacheLength);

        // No need to initialize cache entries - default struct values (IsCached=false, Value=null) are correct

        // Only allocate locks if ExecutionAndPublication strategy is used
#if NET9_0_OR_GREATER
        Lock[]? locks = null;
#else
        object[]? locks = null;
#endif
        if (cacheWriteStrategy == CacheWriteStrategy.ExecutionAndPublication)
        {
#if NET9_0_OR_GREATER
            locks = ArrayPool<Lock>.Shared.Rent(cacheLength);

            // Initialize Lock objects (.NET 9+ / C# 13)
            for (int i = 0; i < cacheLength; i++)
                locks[i] = new Lock();
#else
            locks = ArrayPool<object>.Shared.Rent(cacheLength);

            // Initialize lock objects (fallback for earlier frameworks)
            for (int i = 0; i < cacheLength; i++)
                locks[i] = new object();
#endif
        }

        _entries = entries;
        _locks = locks;
        _cacheLength = cacheLength;
        ResetStats();
    }

    /// <summary>
    /// Stops the cache and resets cache statistics.
    /// </summary>
    internal void StopCache()
    {
        ReturnArraysToPool();

        _entries = null;
        _locks = null;
        _cacheLength = 0;
        ResetStats();
    }

    private void ReturnArraysToPool()
    {
        var entries = _entries;
        if (entries is not null)
        {
            // Clear only the portion we used to allow GC
            Array.Clear(entries, 0, _cacheLength);
            ArrayPool<CacheEntry>.Shared.Return(entries, clearArray: false);
        }

        var locks = _locks;
        if (locks is not null)
        {
            Array.Clear(locks, 0, _cacheLength);
#if NET9_0_OR_GREATER
            ArrayPool<Lock>.Shared.Return(locks, clearArray: false);
#else
            ArrayPool<object>.Shared.Return(locks, clearArray: false);
#endif
        }
    }

    private void ResetStats()
    {
        _cacheCallCount = 0;
        _cacheFactoryInvocations = 0;
    }

    /// <summary>
    /// Gets the total count of cache entries in this cache.
    /// </summary>
    internal int CacheEntriesCount => _cacheLength;

    /// <summary>
    /// Gets the total number of calls to GetOrCompute.
    /// </summary>
    internal long CacheCallCount => Interlocked.Read(ref _cacheCallCount);

    /// <summary>
    /// Gets the number of times the factory function was invoked (cache misses).
    /// </summary>
    internal long CacheMisses => Interlocked.Read(ref _cacheFactoryInvocations);

    /// <summary>
    /// Gets the number of cache hits (calls where a cached value was returned).
    /// </summary>
    /// <remarks>
    /// Cache hits = Total calls to GetOrCompute - Factory invocations (cache misses).
    /// </remarks>
    internal long CacheHits => CacheCallCount - CacheMisses;

    /// <summary>
    /// Gets or computes a cached value for the specified cache index.
    /// </summary>
    /// <typeparam name="T">The type of the cached value.</typeparam>
    /// <param name="cacheIndex">The index identifying the cached value.</param>
    /// <param name="factory">A function to compute the value if it's not in the cache.</param>
    /// <param name="context">The CQL context to pass to the factory function.</param>
    /// <returns>The cached or newly computed value.</returns>
    /// <remarks>
    /// This method is thread-safe and can be called concurrently from multiple threads.
    /// If caching is disabled (cache is null) or the cache index is invalid, the factory function is called without caching the result.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal T GetOrCompute<T>(
        int cacheIndex,
        Func<CqlContext, T> factory,
        CqlContext context)
    {
        Interlocked.Increment(ref _cacheCallCount);

        var entries = _entries;

        // If cache is disabled, compute without caching
        if (entries is null)
        {
            Interlocked.Increment(ref _cacheFactoryInvocations);
            return factory(context);
        }

        // Cache index out of bounds indicates a programming error
        if (cacheIndex < 0 || cacheIndex >= _cacheLength)
        {
            throw new ArgumentOutOfRangeException(
                nameof(cacheIndex),
                cacheIndex,
                $"Cache index {cacheIndex} is out of range. Valid range is 0 to {_cacheLength - 1}. This indicates the cache was not properly initialized or the library was not included during cache index initialization.");
        }

        ref var entry = ref entries[cacheIndex]; // Use ref to avoid copying struct
        if (entry.IsCached)
        {
            return (T)entry.Value!;
        }

        switch (_cacheWriteStrategy)
        {
            case CacheWriteStrategy.ExecutionAndPublication:
            {
                var locks = _locks;
                if (locks is null)
                {
                    // Fallback: locks should have been allocated but weren't - compute without caching
                    Interlocked.Increment(ref _cacheFactoryInvocations);
                    return factory(context);
                }

                lock (locks[cacheIndex]) // Lock on corresponding lock object
                {
                    // Re-check after acquiring lock (entry might have been cached by another thread)
                    entry = ref entries[cacheIndex];
                    if (entry.IsCached)
                    {
                        return (T)entry.Value!;
                    }

                    Interlocked.Increment(ref _cacheFactoryInvocations);
                    var value = factory(context);

                    entry.Value = value;
                    entry.IsCached = true;

                    return value;
                }
            }
            default:
            {
                Interlocked.Increment(ref _cacheFactoryInvocations);
                var value = factory(context);

                entry.Value = value;
                entry.IsCached = true;

                return value;
            }
        }
    }

    /// <summary>
    /// Gets a value indicating whether caching is enabled for this instance.
    /// </summary>
    internal bool CacheEnabled => _entries is not null;
}