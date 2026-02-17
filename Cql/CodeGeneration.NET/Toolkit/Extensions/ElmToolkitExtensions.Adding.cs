/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;

public static partial class ElmToolkitExtensions
{
    /// <summary>
    /// Adds ELM libraries to the compiler.
    /// </summary>
    /// <param name="elmToolkit">The ELM toolkit to add libraries to.</param>
    /// <param name="elmLibraries">The libraries to add.</param>
    public static ElmToolkit AddElmLibraries(
        this ElmToolkit elmToolkit,
        params ElmLibrary[] elmLibraries)
        => elmToolkit.AddElmLibraries(elmLibraries.AsEnumerable());

    /// <summary>
    /// Adds ELM libraries from a CQL toolkit to the specified ELM toolkit.
    /// </summary>
    /// <param name="elmToolkit">The ELM toolkit to add libraries to.</param>
    /// <param name="cqlToolkit">The CQL toolkit containing the libraries to add.</param>
    /// <param name="libraryPredicate">The optional handler which libraries to add.</param>
    /// <returns>The updated ELM toolkit.</returns>
    public static ElmToolkit AddElmFromCqlToolkit(
        this ElmToolkit elmToolkit,
        CqlToolkit cqlToolkit,
        Func<CqlVersionedLibraryIdentifier, bool>? libraryPredicate = null)
    {
        var cqlToolkitResults = cqlToolkit.GetCqlToolkitResults();

        if (libraryPredicate is {} fn)
            cqlToolkitResults = cqlToolkitResults
                .Where(t => fn(t.libraryIdentifier));

        var elmLibraries = cqlToolkitResults
            .Select(t => t.elmLibrary);

        return elmToolkit.AddElmLibraries(elmLibraries);
    }

    /// <summary>
    /// Adds an ELM file from a specified directory to the ELM toolkit.
    /// </summary>
    /// <param name="elmToolkit">The ELM toolkit to add the file to.</param>
    /// <param name="directory">The directory containing the ELM file.</param>
    /// <param name="versionedLibraryIdentifier">The identifier of the library file.</param>
    /// <returns>The updated ELM toolkit.</returns>
    /// <exception cref="FileNotFoundException">Thrown when the specified file is not found.</exception>
    public static ElmToolkit AddElmFileFromDirectory(
        this ElmToolkit elmToolkit,
        DirectoryInfo directory,
        CqlVersionedLibraryIdentifier versionedLibraryIdentifier)
    {
        FileInfo file = new(Path.Combine(directory.FullName, $"{versionedLibraryIdentifier}.json"));
        if (file.Exists)
        {
            return elmToolkit.AddElmFile(file);
        }

        if (versionedLibraryIdentifier.Version is null)
            throw new FileNotFoundException($"Could not find file '{file.FullName}'.");

        var logger = elmToolkit.LoggerFactory.CreateLogger(typeof(ElmToolkitExtensions));
        logger.LogWarning("Could not load library from file with name and version, trying without version: {file}", file.FullName);
        file = new FileInfo(Path.Combine(directory.FullName, $"{versionedLibraryIdentifier with { Version = null }}.json"));
        return elmToolkit.AddElmFile(file);
    }

    /// <summary>
    /// Adds multiple ELM files to the ELM toolkit.
    /// </summary>
    /// <param name="elmToolkit">The ELM toolkit to add the files to.</param>
    /// <param name="files">The collection of ELM files to add.</param>
    /// <returns>The updated ELM toolkit.</returns>
    public static ElmToolkit AddElmFiles(
        this ElmToolkit elmToolkit,
        IEnumerable<FileInfo> files)
    {
        var logger = elmToolkit.CreateLogger();
        var libraries = files
            .TrySelect(f =>
            {
                logger.LogInformation("Loading ELM library from file: {file}", f);
                var library = ElmLibrary.LoadFromJson(f);
                return library;
            },
            s => s
                 .SetContinuation(elmToolkit.BatchProcessExceptionContinuation)
                 .AddLoggerExceptionHandler(
                     logger,
                     (fileInfo, logMessage) => logMessage("Could not load ELM library from file: {file}", fileInfo.FullName))); // Log errors
        return elmToolkit.AddElmLibraries(libraries);
    }

    /// <summary>
    /// Adds ELM files from a specified directory to the ELM toolkit.
    /// </summary>
    /// <param name="elmToolkit">The ELM toolkit to add the files to.</param>
    /// <param name="directory">The directory containing the ELM files.</param>
    /// <param name="options">Optional enumeration options for file retrieval.</param>
    /// <param name="filePredicate">Optional predicate to filter files.</param>
    /// <returns>The updated ELM toolkit.</returns>
    public static ElmToolkit AddElmFilesFromDirectory(
        this ElmToolkit elmToolkit,
        DirectoryInfo directory,
        EnumerationOptions? options = null,
        Func<FileInfo, bool>? filePredicate = null) =>
        AddElmFilesFromDirectory(
            elmToolkit,
            new AddElmFilesFromDirectoryOptions(
                directory,
                options,
                filePredicate));

    /// <summary>
    /// Adds all ELM library files from the specified directory to the provided ElmToolkit instance.
    /// </summary>
    /// <remarks>Only files with a ".json" extension are considered. An optional file predicate can be provided
    /// to further filter which files are added.</remarks>
    /// <param name="elmToolkit">The ElmToolkit instance to which the discovered ELM libraries will be added.</param>
    /// <param name="opt">An options object that specifies the directory to search, file enumeration options, and an optional predicate to
    /// filter files.</param>
    /// <returns>The ElmToolkit instance with the added ELM libraries from the specified directory.</returns>
    public static ElmToolkit AddElmFilesFromDirectory(
        ElmToolkit elmToolkit,
        AddElmFilesFromDirectoryOptions opt)
    {
        var files = opt.GetFilesToAdd();
        return elmToolkit.AddElmFiles(files);
    }

    /// <summary>
    /// Adds an ELM file with its dependencies to the ELM toolkit.
    /// </summary>
    /// <param name="elmToolkit">The ELM toolkit to add the file to.</param>
    /// <param name="file">The ELM file to add.</param>
    /// <param name="options">Optional enumeration options for dependency retrieval.</param>
    /// <returns>The updated ELM toolkit.</returns>
    /// <exception cref="NotImplementedException">Thrown when the method is not implemented.</exception>
    private static ElmToolkit AddElmFileWithDependencies(
        this ElmToolkit elmToolkit,
        FileInfo file,
        EnumerationOptions? options) =>
        throw new NotImplementedException();

    /// <summary>
    /// Adds an ELM file with its dependencies from a specified directory to the ELM toolkit.
    /// </summary>
    /// <param name="elmToolkit">The ELM toolkit to add the file to.</param>
    /// <param name="directory">The directory containing the ELM file and its dependencies.</param>
    /// <param name="fileName">The identifier of the library file.</param>
    /// <param name="options">Optional enumeration options for dependency retrieval.</param>
    /// <returns>The updated ELM toolkit.</returns>
    /// <exception cref="NotImplementedException">Thrown when the method is not implemented.</exception>
    private static ElmToolkit AddElmFileWithDependencies(
        this ElmToolkit elmToolkit,
        DirectoryInfo directory,
        CqlVersionedLibraryIdentifier fileName,
        EnumerationOptions? options) =>
        throw new NotImplementedException();

    /// <summary>
    /// Adds a single ELM file to the ELM toolkit.
    /// </summary>
    /// <param name="elmToolkit">The ELM toolkit to add the file to.</param>
    /// <param name="file">The ELM file to add.</param>
    /// <returns>The updated ELM toolkit.</returns>
    public static ElmToolkit AddElmFile(
        this ElmToolkit elmToolkit,
        FileInfo file) =>
        elmToolkit.AddElmFiles([file]);
}

/// <summary>
/// Represents options for adding ELM files from a directory, including directory location, file enumeration settings,
/// and file filtering criteria.
/// </summary>
/// <remarks>The default file pattern is "*.json". Use the FilePattern property to specify a different pattern if
/// needed.</remarks>
/// <param name="Directory">The directory from which ELM files will be added. Must not be null.</param>
/// <param name="EnumerationOptions">The options to use when enumerating files in the directory. If null, default enumeration options are used.</param>
/// <param name="FilePredicate">A predicate used to filter files. Only files for which this function returns true will be included. If null, all
/// files matching the pattern are included.</param>
public record AddElmFilesFromDirectoryOptions(
    DirectoryInfo Directory,
    EnumerationOptions? EnumerationOptions,
    Func<FileInfo, bool>? FilePredicate)
{
    /// <summary>
    /// Gets the search pattern used to match file names.
    /// </summary>
    /// <remarks>The pattern can include wildcard characters such as '*' and '?'. The default value is
    /// "*.json".</remarks>
    public string FilePattern { get; init; } = "*.json";

    internal IEnumerable<FileInfo> GetFilesToAdd()
    {
        var directory = Directory;
        var options = EnumerationOptions;
        var filePredicate = FilePredicate;
        var files = directory.EnumerateFiles(FilePattern, options ?? Defaults.EnumerationOptions);
        if (filePredicate is not null) files = files.Where(filePredicate);
        return files;
    }
}
