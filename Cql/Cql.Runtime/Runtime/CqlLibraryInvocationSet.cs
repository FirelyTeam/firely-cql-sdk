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
/// <para>
/// This class traverses a set of libraries and their dependencies to initialize cache index fields
/// by assigning sequential indices for array-based caching. Once initialized, this set can be used
/// to create invocation caches with the appropriate size.
/// </para>
/// <para>
/// <strong>IMPORTANT:</strong> Each library should be included in only ONE CqlLibraryInvocationSet instance at a time.
/// The constructor initializes internal cache index fields within the libraries. Including the same library
/// in multiple active invocation sets will corrupt these indices, leading to incorrect cache behavior.
/// </para>
/// <para>
/// If you need to use the same library instances with different caches (e.g., for unit testing), create
/// a new CqlLibraryInvocationSet for each scenario - the libraries will be re-initialized with new indices.
/// </para>
/// </remarks>
public sealed class CqlLibraryInvocationSet
{
    private readonly ILibraryInternals[] _allLibraries;

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
    /// <para>
    /// The initialization processes each library and its dependencies only once, in dependency-first order using
    /// a topological sort. Libraries can be re-initialized with a different set instance, allowing the same library
    /// instance to be used with multiple caches (e.g., for testing scenarios or cache isolation).
    /// </para>
    /// <para>
    /// <strong>WARNING:</strong> Do not include the same library in multiple CqlLibraryInvocationSet instances
    /// that are active simultaneously. This will overwrite the library's internal cache indices, causing cache
    /// corruption. Create separate invocation sets only when previous sets are no longer in use.
    /// </para>
    /// </remarks>
    public CqlLibraryInvocationSet(params ILibrary[] libraries)
    {
        ArgumentNullException.ThrowIfNull(libraries);
        _allLibraries = GetAllLibrariesSorted(libraries);
        CacheEntriesCount = InitializeLibraryCacheIndices();
    }

    private ILibraryInternals[] GetAllLibrariesSorted(ILibrary[] libraries) =>
        libraries
            .TopologicalSort(l => l.Dependencies)
            .Cast<ILibraryInternals>()
            .ToArray();

    private int InitializeLibraryCacheIndices()
    {
        if (_allLibraries is not { Length: not 0 })
            return 0;

        int count = 0;
        foreach (var library in _allLibraries)
            count += library.InitializeCacheIndices(this, count);

        return count;
    }
}
