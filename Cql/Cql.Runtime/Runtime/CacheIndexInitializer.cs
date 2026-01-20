/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Runtime.Internal;

namespace Hl7.Cql.Runtime;

/// <summary>
/// Initializes cache index fields in CQL libraries and their dependencies.
/// Create an instance with the root libraries to initialize, which will traverse dependencies
/// and assign sequential cache indices for efficient array-based caching.
/// </summary>
public sealed class CacheIndexInitializer
{
    private int _nextIndex = 1; // Start at 1 (0 is reserved for uninitialized)

    /// <summary>
    /// Gets the total count of cache index fields initialized across all libraries.
    /// </summary>
    public int CacheIndexCount { get; private set; }

    /// <summary>
    /// Initializes a new instance of the CacheIndexInitializer class using the specified libraries as roots for cache
    /// index initialization.
    /// </summary>
    /// <remarks>If the libraries array is null or empty, no cache indices will be initialized and the total
    /// index count will be zero. The initialization processes each library and its dependencies only once, in
    /// dependency-first order.</remarks>
    /// <param name="libraries">An array of root libraries to use for initializing cache indices. Each library and its dependencies will be
    /// processed in dependency-first order. Must not be null or empty.</param>
    /// <exception cref="InvalidOperationException">
    /// Thrown if any cache index field is already initialized (non-zero), indicating that initialization
    /// has already been performed on these libraries.
    /// </exception>
    public CacheIndexInitializer(params ILibrary[] libraries)
    {
        if (libraries is not { Length: not 0 })
            return;

        int totalIndexCount = 0;
        foreach (var library in libraries)
        {
            // Process each root library and its dependencies in dependency-first order
            if (library is ILibraryInternals internals)
            {
                totalIndexCount += internals.InitializeCacheIndices(this);
            }
        }
        CacheIndexCount = totalIndexCount;
    }

    /// <summary>
    /// Marks a library as processed for cache index initialization.
    /// </summary>
    /// <param name="library">The library to mark as processed.</param>
    /// <returns>True if the library was marked as processed (was not previously processed);
    /// false if the library was already processed.</returns>
    public bool MarkAsProcessed(ILibrary library)
    {
        if (library is not ILibraryInternals internals)
            return false;

        if (internals.CacheIndicesInitialized)
            return false;

        internals.CacheIndicesInitialized = true;
        return true;
    }

    /// <summary>
    /// Gets the next sequential cache index value.
    /// </summary>
    /// <returns>The next cache index value (starting from 1).</returns>
    public int GetNextIndex()
    {
        return _nextIndex++;
    }
}
