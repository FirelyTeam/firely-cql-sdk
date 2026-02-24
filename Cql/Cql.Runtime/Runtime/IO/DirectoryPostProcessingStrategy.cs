/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Runtime.IO;

/// <summary>
/// A static class that provides directory post-processing strategies as delegates of <see cref="DirectoryInfoHandler"/>.
/// </summary>
public static class DirectoryPostProcessingStrategy
{
    /// <summary>
    /// Gets a <see cref="DirectoryInfoHandler"/> that deletes all empty subdirectories within the specified directory.
    /// </summary>
    /// <remarks>
    /// This strategy recursively removes empty subdirectories, processing from deepest to shallowest levels.
    /// A subdirectory is considered empty if it contains no files or other subdirectories.
    /// </remarks>
    public static DirectoryInfoHandler DeleteEmptySubdirectories { get; } = d =>
    {
        var allSubDirs = d.GetDirectories("*", SearchOption.AllDirectories)
            .OrderByDescending(subDir => subDir.FullName.Length)
            .ToList();

        foreach (var subDir in allSubDirs)
        {
            if (subDir.Exists && !subDir.EnumerateFileSystemInfos().Any())
                subDir.Delete();
        }
    };
}
