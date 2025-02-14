using CqlSdkPrototype.Internal;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Runtime;

#pragma warning disable RS0027

namespace CqlSdkPrototype.Elm.Extensions;

public static partial class ElmToolkitExtensions
{
    /// <summary>
    /// Adds ELM libraries from a fluent CQL toolkit.
    /// </summary>
    /// <param name="elmToolkit">The ELM toolkit to add libraries to.</param>
    /// <param name="cqlToolkit">The CQL toolkit to get libraries from.</param>
    /// <returns>The updated ELM toolkit.</returns>
    public static ElmToolkit AddElmFromFluentCqlToolkit(
        this ElmToolkit elmToolkit,
        CqlToolkit cqlToolkit) =>
        elmToolkit.AddElmLibraries(cqlToolkit.GetCompletedCqlToElmTranslations(t => t.elmLibrary));

    /// <summary>
    /// Adds an ELM file from a directory based on the versioned library identifier.
    /// </summary>
    /// <param name="elmToolkit">The ELM toolkit to add the file to.</param>
    /// <param name="directory">The directory to search for the file.</param>
    /// <param name="versionedLibraryIdentifier">The versioned library identifier to search for.</param>
    /// <returns>The updated ELM toolkit.</returns>
    /// <exception cref="FileNotFoundException">Thrown when the file is not found.</exception>
    public static ElmToolkit AddElmFileInDirectory(
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
    /// Adds multiple ELM files to the toolkit.
    /// </summary>
    /// <param name="elmToolkit">The ELM toolkit to add the files to.</param>
    /// <param name="files">The collection of files to add.</param>
    /// <returns>The updated ELM toolkit.</returns>
    public static ElmToolkit AddElmFiles(
        this ElmToolkit elmToolkit,
        IEnumerable<FileInfo> files)
    {
        var logger = elmToolkit.LoggerFactory.CreateLogger(typeof(ElmToolkitExtensions));
        var libraries = files
            .Select(f =>
            {
                logger.LogInformation("Loading library from file: {file}", f);
                var library = ElmLibrary.LoadFromJson(f);
                return library;
            }); // Log errors
        return elmToolkit.AddElmLibraries(libraries);
    }

    /// <summary>
    /// Adds ELM files from a directory to the toolkit.
    /// </summary>
    /// <param name="elmToolkit">The ELM toolkit to add the files to.</param>
    /// <param name="directory">The directory to search for files.</param>
    /// <param name="options">The enumeration options to use when searching for files.</param>
    /// <param name="filePredicate">An optional predicate to filter files.</param>
    /// <returns>The updated ELM toolkit.</returns>
    public static ElmToolkit AddElmFilesFromDirectory(
        this ElmToolkit elmToolkit,
        DirectoryInfo directory,
        EnumerationOptions? options = null,
        Func<FileInfo, bool>? filePredicate = null)
    {
        var files = directory.EnumerateFiles("*.json", options ?? InternalConstants.DefaultEnumerationOptions);
        if (filePredicate is not null) files = files.Where(filePredicate);
        return elmToolkit.AddElmFiles(files);
    }

    /// <summary>
    /// Adds an ELM file and its dependencies to the toolkit.
    /// </summary>
    /// <param name="elmToolkit">The ELM toolkit to add the file to.</param>
    /// <param name="file">The file to add.</param>
    /// <param name="options">The enumeration options to use when searching for dependencies.</param>
    /// <returns>The updated ELM toolkit.</returns>
    /// <exception cref="NotImplementedException">Thrown when the method is not implemented.</exception>
    public static ElmToolkit AddElmFileWithDependencies(
        this ElmToolkit elmToolkit,
        FileInfo file,
        EnumerationOptions? options) =>
        throw new NotImplementedException();

    /// <summary>
    /// Adds an ELM file and its dependencies from a directory to the toolkit.
    /// </summary>
    /// <param name="elmToolkit">The ELM toolkit to add the file to.</param>
    /// <param name="directory">The directory to search for the file and its dependencies.</param>
    /// <param name="fileName">The name of the file to add.</param>
    /// <param name="options">The enumeration options to use when searching for dependencies.</param>
    /// <returns>The updated ELM toolkit.</returns>
    /// <exception cref="NotImplementedException">Thrown when the method is not implemented.</exception>
    public static ElmToolkit AddElmFileWithDependencies(
        this ElmToolkit elmToolkit,
        DirectoryInfo directory,
        CqlVersionedLibraryIdentifier fileName,
        EnumerationOptions? options) =>
        throw new NotImplementedException();

    /// <summary>
    /// Adds a single ELM file to the toolkit.
    /// </summary>
    /// <param name="elmToolkit">The ELM toolkit to add the file to.</param>
    /// <param name="file">The file to add.</param>
    /// <returns>The updated ELM toolkit.</returns>
    public static ElmToolkit AddElmFile(
        this ElmToolkit elmToolkit,
        FileInfo file) =>
        elmToolkit.AddElmFiles([file]);
}
