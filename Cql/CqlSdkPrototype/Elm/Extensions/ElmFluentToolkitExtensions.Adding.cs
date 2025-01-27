using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Internal;
using Hl7.Cql.Elm;

#pragma warning disable RS0027

namespace CqlSdkPrototype.Elm.Extensions;

public static partial class ElmFluentToolkitExtensions
{
    public static ElmFluentToolkit AddElmFrom(
        this ElmFluentToolkit elmToolkit,
        CqlFluentToolkit cqlToolkit) =>
        elmToolkit.AddElmLibraries(
            from entry in cqlToolkit.CqlToElmConversions
            let elmLibrary = entry.Value.ElmLibrary
            where elmLibrary is not null
            select elmLibrary);

    public static ElmFluentToolkit AddElmFile(
        this ElmFluentToolkit elmToolkit,
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

        var logger = elmToolkit.CreateLogger();
        logger.LogWarning("Could not load library from file with name and version, trying without version: {file}", file.FullName);
        file = new FileInfo(Path.Combine(directory.FullName, $"{versionedLibraryIdentifier with { Version = null }}.json"));
        return elmToolkit.AddElmFile(file);
    }

    public static ElmFluentToolkit AddElmFiles(
        this ElmFluentToolkit elmToolkit,
        IEnumerable<FileInfo> files)
    {
        var logger = elmToolkit.CreateLogger();
        var libraries = files
            .Select(f =>
            {
                logger.LogInformation("Loading library from file: {file}", f);
                var library = Library.LoadFromJson(f);
                return library;
            }); // Log errors
        return elmToolkit.AddElmLibraries(libraries);
    }

    public static ElmFluentToolkit AddElmFilesFromDirectory(
        this ElmFluentToolkit elmToolkit,
        DirectoryInfo directory,
        EnumerationOptions? options = null,
        Func<FileInfo, bool>? filePredicate = null)
    {
        var files = directory.EnumerateFiles("*.json", options ?? InternalConstants.DefaultEnumerationOptions);
        if (filePredicate is not null) files = files.Where(filePredicate);
        return elmToolkit.AddElmFiles(files);
    }

    public static ElmFluentToolkit AddElmFileWithDependencies(
        this ElmFluentToolkit elmToolkit,
        FileInfo file,
        EnumerationOptions? options) =>
        throw new NotImplementedException();

    public static ElmFluentToolkit AddElmFileWithDependencies(
        this ElmFluentToolkit elmToolkit,
        DirectoryInfo directory,
        CqlVersionedLibraryIdentifier fileName,
        EnumerationOptions? options) =>
        throw new NotImplementedException();

    public static ElmFluentToolkit AddElmFile(
        this ElmFluentToolkit elmToolkit,
        FileInfo file) =>
        elmToolkit.AddElmFiles([file]);
}