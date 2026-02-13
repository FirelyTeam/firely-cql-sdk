/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Packager;

/// <summary>
/// Extension methods for loading files with path tracking for subdirectory preservation.
/// </summary>
internal static class FileLoadingExtensions
{
    /// <summary>
    /// Adds CQL libraries from a directory and tracks their relative paths.
    /// </summary>
    public static CqlToolkit AddCqlLibrariesFromDirectoryWithTracking(
        this CqlToolkit cqlToolkit,
        DirectoryInfo directory,
        SubdirectoryPathMapper subDirMapper,
        EnumerationOptions? options = null,
        Func<FileInfo, bool>? filePredicate = null)
    {
        var logger = cqlToolkit.LoggerFactory.CreateLogger(typeof(FileLoadingExtensions));
        var files = directory.EnumerateFiles("*.cql", options ?? new EnumerationOptions { RecurseSubdirectories = true });
        if (filePredicate is not null) files = files.Where(filePredicate);

        foreach (var file in files)
        {
            try
            {
                logger.LogInformation("Loading CQL from file: {file}", file);
                var cqlContent = File.ReadAllText(file.FullName);
                var cqlLibrary = CqlLibraryString.Parse(cqlContent);

                // Track the file's path
                subDirMapper.RecordFilePath(file, cqlLibrary.LibraryIdentifier);

                // Add to toolkit
                cqlToolkit = cqlToolkit.AddCqlLibraries(cqlLibrary);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Could not load CQL from file: {file}", file.FullName);
                if (cqlToolkit.BatchProcessExceptionContinuation == Runtime.BatchProcessExceptionContinuation.Throw)
                    throw;
            }
        }

        return cqlToolkit;
    }

    /// <summary>
    /// Adds ELM libraries from a directory and tracks their relative paths.
    /// </summary>
    public static ElmToolkit AddElmFilesFromDirectoryWithTracking(
        this ElmToolkit elmToolkit,
        DirectoryInfo directory,
        SubdirectoryPathMapper subDirMapper,
        EnumerationOptions? options = null,
        Func<FileInfo, bool>? filePredicate = null)
    {
        var logger = elmToolkit.LoggerFactory.CreateLogger(typeof(FileLoadingExtensions));
        var files = directory.EnumerateFiles("*.json", options ?? new EnumerationOptions { RecurseSubdirectories = true });
        if (filePredicate is not null) files = files.Where(filePredicate);

        foreach (var file in files)
        {
            try
            {
                logger.LogInformation("Loading ELM library from file: {file}", file);
                var library = ElmLibrary.LoadFromJson(file);

                // Track the file's path
                subDirMapper.RecordFilePath(file, library.VersionedLibraryIdentifier);

                // Add to toolkit
                elmToolkit = elmToolkit.AddElmLibraries(library);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Could not load ELM library from file: {file}", file.FullName);
                if (elmToolkit.BatchProcessExceptionContinuation == Runtime.BatchProcessExceptionContinuation.Throw)
                    throw;
            }
        }

        return elmToolkit;
    }
}
