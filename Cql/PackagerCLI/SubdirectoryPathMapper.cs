/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;

namespace Hl7.Cql.Packager;

/// <summary>
/// Tracks the relative paths of source files to preserve subdirectory structure in outputs.
/// </summary>
internal class SubdirectoryPathMapper
{
    private readonly Dictionary<CqlVersionedLibraryIdentifier, string> _relativePathsByLibraryId = new();
    private readonly string _baseDirectory;

    public SubdirectoryPathMapper(DirectoryInfo baseDirectory)
    {
        _baseDirectory = baseDirectory.FullName;
    }

    /// <summary>
    /// Records the relative path for a library based on its source file location.
    /// </summary>
    public void RecordFilePath(FileInfo file, CqlVersionedLibraryIdentifier libraryId)
    {
        var relativePath = Path.GetRelativePath(_baseDirectory, file.DirectoryName ?? string.Empty);

        // Normalize the path - if it's ".", it means the file is in the base directory
        if (relativePath == ".")
        {
            relativePath = string.Empty;
        }

        _relativePathsByLibraryId[libraryId] = relativePath;
    }

    /// <summary>
    /// Gets the output path for a library, preserving subdirectory structure.
    /// </summary>
    public string GetOutputPath(DirectoryInfo outputDirectory, CqlVersionedLibraryIdentifier libraryId, string fileName)
    {
        if (_relativePathsByLibraryId.TryGetValue(libraryId, out var relativePath) && !string.IsNullOrEmpty(relativePath))
        {
            var targetDirectory = Path.Combine(outputDirectory.FullName, relativePath);
            Directory.CreateDirectory(targetDirectory);
            return Path.Combine(targetDirectory, fileName);
        }

        return Path.Combine(outputDirectory.FullName, fileName);
    }

    /// <summary>
    /// Gets the relative path for a library, or empty string if in root.
    /// </summary>
    public string GetRelativePath(CqlVersionedLibraryIdentifier libraryId)
    {
        return _relativePathsByLibraryId.TryGetValue(libraryId, out var path) ? path : string.Empty;
    }
}
