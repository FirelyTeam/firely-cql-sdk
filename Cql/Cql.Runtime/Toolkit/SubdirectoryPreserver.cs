/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;

namespace Hl7.Cql.Toolkit;

/// <summary>
/// Preserves the subdirectory structure of libraries by mapping their versioned identifiers 
/// to their relative paths from the input directory.
/// </summary>
public class SubdirectoryPreserver
{
    private readonly Dictionary<CqlVersionedLibraryIdentifier, string> _pathMap = new();

    /// <summary>
    /// Stores the relative path for a library identifier.
    /// </summary>
    /// <param name="relativePath">The relative path of the library file from the input directory.</param>
    /// <param name="libraryIdentifier">The versioned library identifier.</param>
    internal void AddRelativePath(string relativePath, CqlVersionedLibraryIdentifier libraryIdentifier)
    {
        _pathMap[libraryIdentifier] = relativePath;
    }

    /// <summary>
    /// Attempts to retrieve the relative path for a library identifier.
    /// </summary>
    /// <param name="libraryIdentifier">The versioned library identifier to look up.</param>
    /// <returns>A tuple containing the relative path and a boolean indicating if the path was found.</returns>
    internal (string relativePath, bool found) TryGetRelativePath(CqlVersionedLibraryIdentifier libraryIdentifier)
    {
        if (_pathMap.TryGetValue(libraryIdentifier, out var relativePath))
        {
            return (relativePath, true);
        }
        return (string.Empty, false);
    }
}
