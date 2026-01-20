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
    private readonly HashSet<ILibrary> _processed = new HashSet<ILibrary>();
    private int _nextIndex = 1;

    /// <summary>
    /// Gets the total count of cache index fields initialized across all libraries.
    /// </summary>
    public int TotalIndexCount { get; private set; }

    /// <summary>
    /// Initializes a new instance of the CacheIndexInitializer and processes the specified libraries.
    /// Cache indices are assigned sequentially starting from 1 across all libraries in the dependency graph.
    /// </summary>
    /// <param name="libraries">The root libraries to initialize. Dependencies will be processed recursively.</param>
    /// <exception cref="InvalidOperationException">
    /// Thrown if any cache index field is already initialized (non-zero), indicating that initialization
    /// has already been performed on these libraries.
    /// </exception>
    public CacheIndexInitializer(params ILibrary[] libraries)
    {
        if (libraries is not { Length: not 0 })
            return;

        // Process each root library and its dependencies in dependency-first order
        foreach (var library in libraries)
        {
            if (library is ILibraryInternals internals)
            {
                TotalIndexCount += internals.InitializeCacheIndices(this);
            }
        }
    }

    /// <summary>
    /// Gets the next cache index and increments the counter.
    /// This method is called by generated libraries during initialization.
    /// </summary>
    /// <returns>The next available cache index.</returns>
    public int GetNextIndex()
    {
        return _nextIndex++;
    }

    /// <summary>
    /// Marks a library as processed to avoid duplicate initialization.
    /// </summary>
    /// <param name="library">The library to mark as processed.</param>
    /// <returns>True if the library was added (first time processing), false if already processed.</returns>
    public bool MarkAsProcessed(ILibrary library)
    {
        return _processed.Add(library);
    }
}
