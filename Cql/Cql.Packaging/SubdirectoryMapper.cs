/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;

namespace Hl7.Cql.Packaging;

/// <summary>
/// Tracks the relative paths of source files to preserve subdirectory structure in outputs.
/// </summary>
public class SubdirectoryMapper
{
    private readonly Dictionary<CqlVersionedLibraryIdentifier, string> _relativePathsByLibraryId = new();
    private readonly string _baseDirectory;

    /// <summary>
    /// Initializes a new instance of the <see cref="SubdirectoryMapper"/> class.
    /// </summary>
    /// <param name="baseDirectory">The base directory to calculate relative paths from.</param>
    public SubdirectoryMapper(DirectoryInfo baseDirectory)
    {
        _baseDirectory = baseDirectory.FullName;
    }

    /// <summary>
    /// Records the relative path for a library based on its source file location.
    /// </summary>
    /// <param name="file">The source file.</param>
    /// <param name="libraryId">The library identifier.</param>
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
    /// <param name="outputDirectory">The output directory.</param>
    /// <param name="libraryId">The library identifier.</param>
    /// <param name="fileName">The file name.</param>
    /// <returns>The full output path with subdirectory structure preserved.</returns>
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
    /// <param name="libraryId">The library identifier.</param>
    /// <returns>The relative path for the library.</returns>
    public string GetRelativePath(CqlVersionedLibraryIdentifier libraryId)
    {
        return _relativePathsByLibraryId.TryGetValue(libraryId, out var path) ? path : string.Empty;
    }
}
