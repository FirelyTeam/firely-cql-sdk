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
        Func<FileInfo, bool>? filePredicate = null)
    {
        var files = directory.EnumerateFiles("*.json", options ?? Defaults.EnumerationOptions);
        if (filePredicate is not null) files = files.Where(filePredicate);
        return elmToolkit.AddElmFiles(files);
    }

    /// <summary>
    /// Adds an ELM file with its dependencies to the ELM toolkit.
    /// </summary>
    /// <param name="elmToolkit">The ELM toolkit to add the file to.</param>
    /// <param name="file">The ELM file to add.</param>
    /// <returns>The updated ELM toolkit.</returns>
    /// <exception cref="FileNotFoundException">Thrown when the specified file or its dependencies are not found.</exception>
    public static ElmToolkit AddElmFileWithDependencies(
        this ElmToolkit elmToolkit,
        FileInfo file)
    {
        if (!file.Exists)
            throw new FileNotFoundException($"File '{file.FullName}' does not exist.", file.FullName);

        var logger = elmToolkit.CreateLogger();
        logger.LogInformation("Loading ELM library with dependencies from file: {file}", file.FullName);

        var rootLibrary = ElmLibrary.LoadFromJson(file);
        var libraryName = rootLibrary.identifier?.id ?? throw new InvalidOperationException($"Library in file '{file.FullName}' has no identifier.");
        var version = rootLibrary.identifier?.version ?? string.Empty;

        var directory = file.Directory ?? throw new InvalidOperationException($"Could not determine directory for file '{file.FullName}'.");

        return elmToolkit.AddElmFileWithDependenciesFromDirectory(directory, libraryName, version);
    }

    /// <summary>
    /// Adds an ELM file with its dependencies from a specified directory to the ELM toolkit.
    /// </summary>
    /// <param name="elmToolkit">The ELM toolkit to add the file to.</param>
    /// <param name="directory">The directory containing the ELM file and its dependencies.</param>
    /// <param name="libraryName">The name of the library file.</param>
    /// <param name="version">The version of the library file.</param>
    /// <returns>The updated ELM toolkit.</returns>
    /// <exception cref="FileNotFoundException">Thrown when the specified file or its dependencies are not found.</exception>
    public static ElmToolkit AddElmFileWithDependenciesFromDirectory(
        this ElmToolkit elmToolkit,
        DirectoryInfo directory,
        string libraryName,
        string version = "")
    {
        if (Path.GetExtension(libraryName).Equals(".cql", StringComparison.InvariantCultureIgnoreCase))
            libraryName = Path.GetFileNameWithoutExtension(libraryName);

        var logger = elmToolkit.CreateLogger();
        var librariesToLoad = new Queue<(string lib, string version)>();
        var loadedLibraries = new HashSet<string>();
        var libraries = new List<ElmLibrary>();

        // Check which libraries are already loaded in the toolkit
        var alreadyLoadedIds = elmToolkit.ArtifactsById.Keys
            .Select(k => string.IsNullOrEmpty(k.Version) ? k.Identifier.ToString() : $"{k.Identifier}-{k.Version}")
            .ToHashSet();

        librariesToLoad.Enqueue((libraryName, version));

        while (librariesToLoad.Count > 0)
        {
            var (lib, ver) = librariesToLoad.Dequeue();
            var versionedId = string.IsNullOrEmpty(ver) ? lib : $"{lib}-{ver}";

            if (!loadedLibraries.Add(versionedId))
                continue;

            // Skip if already loaded in the toolkit
            if (alreadyLoadedIds.Contains(versionedId))
            {
                logger.LogDebug("Skipping already loaded library: {lib}-{version}", lib, ver);
                continue;
            }

            logger.LogInformation("Loading ELM library from directory: {lib}-{version}", lib, ver);

            var library = ElmLibrary.LoadFromJson(directory, lib, ver);
            libraries.Add(library);

            if (library.includes is { Length: > 0 } includeDefs)
            {
                foreach (var includeDef in includeDefs)
                {
                    var includeVersionedId = $"{includeDef.path}-{includeDef.version}";
                    if (!loadedLibraries.Contains(includeVersionedId))
                    {
                        librariesToLoad.Enqueue((includeDef.path, includeDef.version));
                    }
                }
            }
        }

        return libraries.Count > 0 ? elmToolkit.AddElmLibraries(libraries) : elmToolkit;
    }

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
