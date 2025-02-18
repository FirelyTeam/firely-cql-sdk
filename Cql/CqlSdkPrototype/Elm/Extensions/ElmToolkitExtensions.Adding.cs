using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Cql.Extensions;
using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.Runtime;

#pragma warning disable RS0027

namespace CqlSdkPrototype.Elm.Extensions;

public static partial class ElmToolkitExtensions
{
    public static ElmToolkit AddElmFromFluentCqlToolkit(
        this ElmToolkit elmToolkit,
        CqlToolkit cqlToolkit) =>
        elmToolkit.AddElmLibraries(cqlToolkit.GetCompletedCqlToElmTranslations(t => t.elmLibrary));

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

    public static ElmToolkit AddElmFileWithDependencies(
        this ElmToolkit elmToolkit,
        FileInfo file,
        EnumerationOptions? options) =>
        throw new NotImplementedException();

    public static ElmToolkit AddElmFileWithDependencies(
        this ElmToolkit elmToolkit,
        DirectoryInfo directory,
        CqlVersionedLibraryIdentifier fileName,
        EnumerationOptions? options) =>
        throw new NotImplementedException();

    public static ElmToolkit AddElmFile(
        this ElmToolkit elmToolkit,
        FileInfo file) =>
        elmToolkit.AddElmFiles([file]);
}