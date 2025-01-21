using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Cql.Extensibility;
using CqlSdkPrototype.Elm.Extensibility;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Internal;
using Hl7.Cql.Elm;

#pragma warning disable RS0027

namespace CqlSdkPrototype.Elm.Extensions;

public static partial class ElmApiExtensions
{
    public static ElmApi AddElmFromCqlApi(
        this ElmApi elmApi,
        CqlApi cqlApi)
    {
        return elmApi.AddElmLibraries(
            from entry in cqlApi.Entries
            let elmLibrary = entry.Value.ElmLibrary
            where elmLibrary is not null
            select elmLibrary);
    }

    public static ElmApi AddElmFile(
        this ElmApi elmApi,
        DirectoryInfo directory,
        CqlVersionedLibraryIdentifier versionedLibraryIdentifier)
    {
        FileInfo file = new(Path.Combine(directory.FullName, $"{versionedLibraryIdentifier}.json"));
        if (file.Exists)
            return elmApi.AddElmFile(file);

        if (versionedLibraryIdentifier.Version is null)
            throw new FileNotFoundException($"Could not find file '{file.FullName}'.");

        var logger = elmApi.LoggerFactory.CreateLogger(typeof(ElmApiExtensions));
        logger.LogWarning("Could not load library from file with name and version, trying without version: {file}", file.FullName);
        file = new FileInfo(Path.Combine(directory.FullName, $"{versionedLibraryIdentifier with { Version = null }}.json"));
        return elmApi.AddElmFile(file);
    }

    public static ElmApi AddElmFiles(
        this ElmApi elmApi,
        IEnumerable<FileInfo> files)
    {
        var logger = elmApi.LoggerFactory.CreateLogger(typeof(ElmApiExtensions));
        var libraries = files
            .Select(f =>
            {
                logger.LogInformation("Loading library from file: {file}", f);
                var library = Library.LoadFromJson(f);
                return library;
            }); // Log errors
        return elmApi.AddElmLibraries(libraries);
    }

    public static ElmApi AddElmFilesFromDirectory(
        this ElmApi elmApi,
        DirectoryInfo directory,
        EnumerationOptions? options = null,
        Func<FileInfo, bool>? filePredicate = null)
    {
        var files = directory.EnumerateFiles("*.json", options ?? InternalConstants.DefaultEnumerationOptions);
        if (filePredicate is not null) files = files.Where(filePredicate);
        return elmApi.AddElmFiles(files);
    }

    public static ElmApi AddElmFileWithDependencies(
        this ElmApi elmApi,
        FileInfo file,
        EnumerationOptions? options)
    {
        // TODO
        return elmApi;
    }

    public static ElmApi AddElmFileWithDependencies(
        this ElmApi elmApi,
        DirectoryInfo directory,
        CqlVersionedLibraryIdentifier fileName,
        EnumerationOptions? options)
    {
        // TODO
        return elmApi;
    }

    public static ElmApi AddElmFile(
        this ElmApi elmApi,
        FileInfo file)
    {
        return elmApi.AddElmFiles([file]);
    }
}