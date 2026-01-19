/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;

namespace Hl7.Cql.Runtime;

/// <summary>
/// Initializes cache index fields in CQL libraries and their dependencies.
/// This must be called once before using the libraries to enable efficient array-based caching.
/// </summary>
public static class CacheIndexInitializer
{
    /// <summary>
    /// Initializes cache index fields for the specified libraries and their dependencies.
    /// Cache indices are assigned sequentially starting from 1 across all libraries in the dependency graph.
    /// </summary>
    /// <param name="libraries">The root libraries to initialize. Dependencies will be processed recursively.</param>
    /// <exception cref="InvalidOperationException">
    /// Thrown if any cache index field is already initialized (non-zero), indicating that initialization
    /// has already been performed on these libraries.
    /// </exception>
    public static void Initialize(params ILibrary[] libraries)
    {
        if (libraries is not { Length: not 0 })
            return;

        // Use a HashSet to track processed libraries and avoid processing the same library multiple times
        var processed = new HashSet<ILibrary>();
        var nextIndex = 1;

        // Process each root library and its dependencies in dependency-first order
        foreach (var library in libraries)
        {
            InitializeLibrary(library, processed, ref nextIndex);
        }
    }

    private static void InitializeLibrary(ILibrary library, HashSet<ILibrary> processed, ref int nextIndex)
    {
        // Skip if already processed
        if (!processed.Add(library))
            return;

        // Process dependencies first (depth-first traversal)
        if (library.Dependencies is { Length:>0 })
        {
            foreach (var dependency in library.Dependencies)
            {
                InitializeLibrary(dependency, processed, ref nextIndex);
            }
        }

        // Get the library type
        var libraryType = library.GetType();

        // Find all cache index fields (_cacheIndex_*)
        var cacheIndexFields = libraryType
            .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
            .Where(f => f.Name.StartsWith("_cacheIndex_") && f.FieldType == typeof(int))
            .ToArray();

        // Initialize each cache index field
        foreach (var field in cacheIndexFields)
        {
            var currentValue = (int)field.GetValue(library)!;

            if (currentValue != 0)
            {
                throw new InvalidOperationException(
                    $"Cache index field '{field.Name}' in library '{library.Name}' version '{library.Version}' " +
                    $"is already initialized to {currentValue}. Cache indices can only be initialized once. " +
                    $"This typically indicates that Initialize has been called multiple times on the same library set.");
            }

            field.SetValue(library, nextIndex);
            nextIndex++;
        }
    }
}
