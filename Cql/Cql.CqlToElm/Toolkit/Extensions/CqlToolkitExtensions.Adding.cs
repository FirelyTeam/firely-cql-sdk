/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;

namespace Hl7.Cql.CqlToElm.Toolkit.Extensions;

/// <summary>
/// Provides extension methods for adding CQL libraries to a <see cref="CqlToolkit"/>.
/// </summary>
public static partial class CqlToolkitExtensions
{
    /// <summary>
    /// Adds the specified CQL libraries to the <see cref="CqlToolkit"/>.
    /// </summary>
    /// <param name="cqlToolkit">The CQL toolkit to add the libraries to.</param>
    /// <param name="cqlLibraries">The CQL libraries to add.</param>
    /// <returns>The updated <see cref="CqlToolkit"/>.</returns>
    public static CqlToolkit AddCqlLibraries(
        this CqlToolkit cqlToolkit,
        params CqlLibraryString[] cqlLibraries)
    {
        return cqlToolkit.AddCqlLibraries(cqlLibraries);
    }

    /// <summary>
    /// Adds CQL libraries from the specified directory to the <see cref="CqlToolkit"/>.
    /// </summary>
    /// <param name="cqlToolkit">The CQL toolkit to add the libraries to.</param>
    /// <param name="directory">The directory to search for CQL files.</param>
    /// <param name="options">The enumeration options to use when searching for files.</param>
    /// <param name="filePredicate">An optional predicate to filter the files.</param>
    /// <returns>The updated <see cref="CqlToolkit"/>.</returns>
    public static CqlToolkit AddCqlLibrariesFromDirectory(
        this CqlToolkit cqlToolkit,
        DirectoryInfo directory,
        EnumerationOptions? options = null,
        Func<FileInfo, bool>? filePredicate = null)
    {
        var files = directory.EnumerateFiles("*.cql", options ?? Defaults.EnumerationOptions);
        if (filePredicate is not null) files = files.Where(filePredicate);
        return cqlToolkit.AddCqlLibraryFiles(files);
    }

    /// <summary>
    /// Adds CQL libraries from the specified files to the <see cref="CqlToolkit"/>.
    /// </summary>
    /// <param name="cqlToolkit">The CQL toolkit to add the libraries to.</param>
    /// <param name="files">The files to load the CQL libraries from.</param>
    /// <returns>The updated <see cref="CqlToolkit"/>.</returns>
    public static CqlToolkit AddCqlLibraryFiles(
        this CqlToolkit cqlToolkit,
        IEnumerable<FileInfo> files)
    {
        var logger = cqlToolkit.CreateLogger();
        var cqlLibraries = files
            .Select(f =>
            {
                logger.LogInformation("Loading CQL from file: {file}", f);
                var cqlContent = File.ReadAllText(f.FullName);
                var cqlLibrary = CqlLibraryString.Parse(cqlContent);
                return cqlLibrary;
            }); // Log errors

        return cqlToolkit.AddCqlLibraries(cqlLibraries);
    }
}
