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
/// This must be called once before using the libraries to enable efficient array-based caching.
/// </summary>
public sealed class CacheIndexInitializer
{
    private static readonly Lazy<CacheIndexInitializer> _instance = new Lazy<CacheIndexInitializer>(() => new CacheIndexInitializer());

    /// <summary>
    /// Gets the singleton instance of the CacheIndexInitializer.
    /// </summary>
    public static CacheIndexInitializer Instance => _instance.Value;

    private readonly HashSet<ILibrary> _processed = new HashSet<ILibrary>();
    private int _nextIndex = 1;

    private CacheIndexInitializer()
    {
    }

    /// <summary>
    /// Initializes cache index fields for the specified libraries and their dependencies.
    /// Cache indices are assigned sequentially starting from 1 across all libraries in the dependency graph.
    /// </summary>
    /// <param name="libraries">The root libraries to initialize. Dependencies will be processed recursively.</param>
    /// <exception cref="InvalidOperationException">
    /// Thrown if any cache index field is already initialized (non-zero), indicating that initialization
    /// has already been performed on these libraries.
    /// </exception>
    public void Initialize(params ILibrary[] libraries)
    {
        if (libraries is not { Length: not 0 })
            return;

        // Process each root library and its dependencies in dependency-first order
        foreach (var library in libraries)
        {
            if (library is ILibraryInternals internals)
            {
                internals.InitializeCacheIndices(this);
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
