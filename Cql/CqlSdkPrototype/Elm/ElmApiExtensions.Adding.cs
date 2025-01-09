using CqlSdkPrototype.Cql.Extensibility;
using CqlSdkPrototype.Elm.Extensibility;
using CqlSdkPrototype.Internal;
using Hl7.Cql.Elm;
using Microsoft.Extensions.Logging;

#pragma warning disable RS0027

namespace CqlSdkPrototype.Elm;

public static partial class ElmApiExtensions
{
    public static TElmApi AddElmFromCqlApi<TElmApi, TCqlApi>(
        this TElmApi elmApi,
        TCqlApi cqlApi)
        where TElmApi : IElmApi<TElmApi>
        where TCqlApi : ICqlApi<TCqlApi>
    {
        return elmApi.AddElmLibraries(
            from entry in cqlApi.Entries
            let elmLibrary = entry.Value.ElmLibrary
            where elmLibrary is not null
            select elmLibrary);
    }

    public static TElmApi AddElmFile<TElmApi>(
        this TElmApi cqlApi,
        DirectoryInfo directory,
        CqlVersionedLibraryIdentifier versionedLibraryIdentifier)
        where TElmApi : IElmApi<TElmApi>
    {
        FileInfo file = new(Path.Combine(directory.FullName, $"{versionedLibraryIdentifier}.json"));
        if (file.Exists)
            return cqlApi.AddElmFile(file);

        if (versionedLibraryIdentifier.Version is null)
            throw new FileNotFoundException($"Could not find file '{file.FullName}'.");

        var logger = cqlApi.GetLogger();
        logger.LogWarning("Could not load library from file with name and version, trying without version: {file}", file.FullName);
        file = new FileInfo(Path.Combine(directory.FullName, $"{versionedLibraryIdentifier with { Version = null }}.json"));
        return cqlApi.AddElmFile(file);
    }

    public static TElmApi AddElmFiles<TElmApi>(
        this TElmApi elmApi,
        IEnumerable<FileInfo> files)
        where TElmApi : IElmApi<TElmApi>
    {
        var logger = elmApi.GetLogger();
        var libraries =
            files
                .Select(f =>
                {
                    logger.LogInformation("Loading library from file: {file}", f);
                    var library = Library.LoadFromJson(f);
                    return library;
                }); // Log errors
        return elmApi.AddElmLibraries(libraries);
    }

    public static TElmApi AddElmFilesFromDirectory<TElmApi>(
        this TElmApi elmApi,
        DirectoryInfo directory,
        EnumerationOptions? options = null,
        Func<FileInfo, bool>? filePredicate = null)
        where TElmApi : IElmApi<TElmApi>
    {
        var files = directory.EnumerateFiles("*.json", options ?? InternalConstants.DefaultEnumerationOptions);
        if (filePredicate is not null) files = files.Where(filePredicate);
        return elmApi.AddElmFiles(files);
    }

    public static TElmApi AddElmFileWithDependencies<TElmApi>(
        this TElmApi elmApi,
        FileInfo file,
        EnumerationOptions? options)
        where TElmApi : IElmApi<TElmApi>
    {
        // TODO
        return elmApi;
    }

    public static TElmApi AddElmFileWithDependencies<TElmApi>(
        this TElmApi elmApi,
        DirectoryInfo directory,
        CqlVersionedLibraryIdentifier fileName,
        EnumerationOptions? options)
        where TElmApi : IElmApi<TElmApi>
    {
        // TODO
        return elmApi;
    }

    public static TElmApi AddElmFile<TElmApi>(
        this TElmApi elmApi,
        FileInfo file)
        where TElmApi : IElmApi<TElmApi>
    {
        return elmApi.AddElmFiles([file]);
    }
}