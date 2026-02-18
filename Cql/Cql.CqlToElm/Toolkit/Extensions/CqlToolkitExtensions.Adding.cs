/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;
using Hl7.Cql.Toolkit;

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
    /// <param name="subdirectoryPreserver">An optional subdirectory preserver to track relative paths.</param>
    /// <returns>The updated <see cref="CqlToolkit"/>.</returns>
    public static CqlToolkit AddCqlLibrariesFromDirectory(
        this CqlToolkit cqlToolkit,
        DirectoryInfo directory,
        EnumerationOptions? options = null,
        Func<FileInfo, bool>? filePredicate = null,
        SubdirectoryPreserver? subdirectoryPreserver = null) =>
        AddCqlLibrariesFromDirectory(
            cqlToolkit,
            new AddCqlLibrariesFromDirectoryOptions(
                directory,
                options,
                filePredicate,
                subdirectoryPreserver));

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
        var files = opt.GetFilesToAdd();
        var logger = cqlToolkit.CreateLogger();
        var baseDirectory = opt.Directory.FullName;

        var cqlLibraries = files
            .TrySelect(f =>
                       {
                           logger.LogInformation("Loading CQL from file: {file}", f);
                           var cqlContent = File.ReadAllText(f.FullName);
                           var cqlLibrary = CqlLibraryString.Parse(cqlContent);
                           
                           // Track relative path if subdirectory preserver is provided
                           if (opt.SubdirectoryPreserver is not null)
                           {
                               var relativePath = Path.GetRelativePath(baseDirectory, Path.GetDirectoryName(f.FullName) ?? baseDirectory);
                               if (relativePath == ".")
                                   relativePath = string.Empty;
                               opt.SubdirectoryPreserver.AddRelativePath(relativePath, cqlLibrary.LibraryIdentifier);
                           }

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

/// <summary>
/// Represents options for adding CQL libraries from a directory, including directory selection, file enumeration
/// behavior, and file filtering.
/// </summary>
/// <remarks>Use this record to configure which CQL files are discovered and added from a directory. The options
/// allow customization of file search patterns and filtering logic.</remarks>
/// <param name="Directory">The directory from which to search for CQL library files. Must not be null.</param>
/// <param name="EnumerationOptions">The options that control how the directory is enumerated. If null, default enumeration options are used.</param>
/// <param name="FilePredicate">A predicate used to filter files within the directory. Only files for which this function returns true will be
/// included. If null, all matching files are included.</param>
/// <param name="SubdirectoryPreserver">An optional subdirectory preserver to track relative paths of loaded libraries.</param>
public record AddCqlLibrariesFromDirectoryOptions(
    DirectoryInfo Directory,
    EnumerationOptions? EnumerationOptions,
    Func<FileInfo, bool>? FilePredicate,
    SubdirectoryPreserver? SubdirectoryPreserver = null)
{
    /// <summary>
    /// Gets the file name pattern used to match files for processing.
    /// </summary>
    /// <remarks>The pattern should follow standard file system wildcard conventions. For example, "*.cql"
    /// matches all files with the ".cql" extension.</remarks>
    public string FilePattern { get; init; } = "*.cql";

    internal IEnumerable<FileInfo> GetFilesToAdd()
    {
        var directory = Directory;
        var options = EnumerationOptions;
        var filePredicate = FilePredicate;
        var files = directory.EnumerateFiles(FilePattern, options ?? Defaults.EnumerationOptionsRecurseSubdirectories);
        if (filePredicate is not null) files = files.Where(filePredicate);
        return files;
    }
}