/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Runtime.Graphs;
using Hl7.Cql.Runtime.Internal;

namespace Hl7.Cql.Runtime;

/// <summary>
/// Represents a set of CQL libraries with initialized cache indices.
/// </summary>
/// <remarks>
/// This class traverses a set of libraries and their dependencies to initialize cache index fields
/// by assigning sequential indices for array-based caching. Once initialized, this set can be used
/// to create invocation caches with the appropriate size.
/// </remarks>
public sealed class CqlLibraryInvocationSet
{
    private readonly ILibrary[] _libraries;

    /// <summary>
    /// Gets the total count of cache entries across all libraries in this set.
    /// </summary>
    public int CacheEntriesCount { get; }

    /// <summary>
    /// Initializes a new instance of the CqlLibraryInvocationSet class using the specified libraries as roots.
    /// </summary>
    /// <param name="libraries">An array of root libraries to initialize. Each library and its dependencies will be
    /// processed in dependency-first order. Must not be null or empty.</param>
    /// <remarks>
    /// The initialization processes each library and its dependencies only once, in dependency-first order using
    /// a topological sort. Libraries can be re-initialized with a different set instance, allowing the same library
    /// instance to be used with multiple caches (e.g., for testing scenarios or cache isolation).
    /// </remarks>
    public CqlLibraryInvocationSet(params ILibrary[] libraries)
    {
        _libraries = libraries ?? throw new ArgumentNullException(nameof(libraries));
        CacheEntriesCount = InitializeLibraryCacheIndices();
    }

    private int InitializeLibraryCacheIndices()
    {
        var allLibs =
            _libraries
                .TopologicalSort(l => l.Dependencies)
                .Cast<ILibraryInternals>()
                .ToArray();

        if (allLibs is not { Length: not 0 })
            return 0;

        int count = 0;
        foreach (var library in allLibs)
            count += library.InitializeCacheIndices(this, count);

        return count;
    }
    
    /// <summary>
    /// Sets the cache instance on all libraries in this set.
    /// </summary>
    /// <param name="cache">The cache instance to set on all libraries.</param>
    internal void SetCacheInstanceOnLibraries(CqlLibraryInvocationCache cache)
    {
        var allLibs =
            _libraries
                .TopologicalSort(l => l.Dependencies)
                .Cast<ILibraryInternals>()
                .ToArray();

        foreach (var library in allLibs)
            library.SetCacheInstance(cache);
    }
}
