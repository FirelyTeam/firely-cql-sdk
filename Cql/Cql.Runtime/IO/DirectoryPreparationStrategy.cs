/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
 
namespace Hl7.Cql.Runtime.IO;

/// <summary>
/// A static class that provides directory preparation strategies as delegates of <see cref="DirectoryInfoHandler"/>.
/// </summary>
public static class DirectoryPreparationStrategy
{
    /// <summary>
    /// Gets a <see cref="DirectoryInfoHandler"/> that creates the directory if it does not exist.
    /// </summary>
    public static DirectoryInfoHandler CreateIfNotExists { get; } = d => d.Create();

    /// <summary>
    /// Gets a <see cref="DirectoryInfoHandler"/> that recreates the directory.
    /// </summary>
    public static DirectoryInfoHandler Recreate { get; } = d => d.Recreate();

    /// <summary>
    /// Creates a <see cref="DirectoryInfoHandler"/> that deletes files in the directory based on the specified search pattern and options.
    /// </summary>
    /// <param name="searchPattern">The search string to match against the names of files in the directory. The default pattern is "*".</param>
    /// <param name="enumerationOptions">The options to use for enumeration. If null, default options are used.</param>
    /// <param name="fileSelector">A function to select which files to delete. If null, all files are selected.</param>
    /// <returns>A <see cref="DirectoryInfoHandler"/> that deletes files in the directory.</returns>
    public static DirectoryInfoHandler CreateFileDeletionDirectoryHandler(
        string searchPattern = "*",
        EnumerationOptions? enumerationOptions = null,
        Func<FileInfo, bool>? fileSelector = null) =>
        d =>
        {
            if (d.Exists)
            {
                enumerationOptions ??= Defaults.EnumerationOptions;
                fileSelector ??= IncludeFile;
                foreach (var file in d.EnumerateFiles(searchPattern, enumerationOptions).Where(fileSelector))
                    file.Delete();
            }
            else d.Create();
            static bool IncludeFile(FileInfo fi) => true;
        };
}
