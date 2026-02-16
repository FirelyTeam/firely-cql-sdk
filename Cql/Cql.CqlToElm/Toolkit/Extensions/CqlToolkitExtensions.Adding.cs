/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;

namespace Hl7.Cql.CqlToElm.Toolkit.Extensions;

public record AddCqlLibrariesFromDirectoryOptions(DirectoryInfo Directory, EnumerationOptions? Options, Func<FileInfo, bool>? FilePredicate);

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
        Func<FileInfo, bool>? filePredicate = null) =>
        AddCqlLibrariesFromDirectory(cqlToolkit, new AddCqlLibrariesFromDirectoryOptions(directory, options, filePredicate));

    /// <summary>
    /// Adds all CQL library files from the specified directory to the provided CqlToolkit instance.
    /// </summary>
    /// <remarks>Only files with a ".cql" extension are considered. An optional file predicate can be provided
    /// to further filter which files are added.</remarks>
    /// <param name="cqlToolkit">The CqlToolkit instance to which the discovered CQL libraries will be added.</param>
    /// <param name="opt">An options object that specifies the directory to search, file enumeration options, and an optional predicate to
    /// filter files.</param>
    /// <returns>The CqlToolkit instance with the added CQL libraries from the specified directory.</returns>
    public static CqlToolkit AddCqlLibrariesFromDirectory(
        CqlToolkit cqlToolkit,
        AddCqlLibrariesFromDirectoryOptions opt)
    {
        var directory = opt.Directory;
        var options = opt.Options;
        var filePredicate = opt.FilePredicate;
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
            .TrySelect(f =>
                       {
                           logger.LogInformation("Loading CQL from file: {file}", f);
                           var cqlContent = File.ReadAllText(f.FullName);
                           var cqlLibrary = CqlLibraryString.Parse(cqlContent);
                           return cqlLibrary;
                       },
                       s => s
                            .SetContinuation(cqlToolkit.BatchProcessExceptionContinuation)
                            .AddLoggerExceptionHandler(
                                logger,
                                (fileInfo, logMessage) =>
                                    logMessage("Could not load CQL from file: {file}", fileInfo.FullName))); // Log errors

        return cqlToolkit.AddCqlLibraries(cqlLibraries);
    }
}