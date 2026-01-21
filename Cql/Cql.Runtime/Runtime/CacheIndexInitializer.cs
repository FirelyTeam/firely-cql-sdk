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
    private int _nextIndex = 0; // Start at 0 for efficient array indexing

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
    /// dependency-first order. Libraries can be re-initialized with a new CacheIndexInitializer instance even
    /// if they were previously initialized by a different instance, allowing for scenarios like unit testing
    /// where libraries need to be reset between tests.</remarks>
    /// <param name="libraries">An array of root libraries to use for initializing cache indices. Each library and its dependencies will be
    /// processed in dependency-first order. Must not be null or empty.</param>
    /// <exception cref="InvalidOperationException">
    /// Thrown if any cache index field is already initialized (non-negative), indicating that initialization
    /// has already been performed on these libraries by THIS CacheIndexInitializer instance.
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
                // Check if the library has already been initialized by THIS initializer
                if (internals.CacheIndexInitializerInstance == this)
                    continue; // Already initialized by this initializer instance

                totalIndexCount += internals.InitializeCacheIndices(this);
            }
        }
        CacheIndexCount = totalIndexCount;
    }

    /// <summary>
    /// Marks a library as processed for cache index initialization.
    /// </summary>
    /// <param name="library">The library to mark as processed.</param>
    /// <returns>True if the library was marked as processed (was not previously processed by this initializer);
    /// false if the library was already processed by this initializer.</returns>
    public bool MarkAsProcessed(ILibrary library)
    {
        if (library is not ILibraryInternals internals)
            return false;

        // Check if already processed by this specific initializer instance
        if (internals.CacheIndexInitializerInstance == this)
            return false;

        internals.CacheIndicesInitialized = true;
        internals.CacheIndexInitializerInstance = this;
        return true;
    }

    /// <summary>
    /// Gets the next sequential cache index value.
    /// </summary>
    /// <returns>The next cache index value (starting from 0).</returns>
    public int GetNextIndex()
    {
        return _nextIndex++;
    }
}
