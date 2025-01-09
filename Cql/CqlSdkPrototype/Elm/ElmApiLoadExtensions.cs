using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Cql.Extensibility;
using CqlSdkPrototype.Elm.Extensibility;
using CqlSdkPrototype.Internal;
using Hl7.Cql.Elm;
using Microsoft.Extensions.Logging;

#pragma warning disable RS0027

namespace CqlSdkPrototype.Elm;

public static class ElmApiLoadExtensions
{
    public static TElmApi LoadElmFromCqlApi<TElmApi, TCqlApi>(
        this TElmApi self,
        TCqlApi cqlApi)
        where TElmApi : IElmApiExtensible<TElmApi>
        where TCqlApi : ICqlApiExtensible<TCqlApi>
    {
        return self.AddElmLibraries(
            from entry in cqlApi.Entries
            let elmLibrary = entry.Value.ElmLibrary
            where elmLibrary is not null
            select elmLibrary);
    }

    public static TElmApi LoadElmFile<TElmApi>(
        this TElmApi self,
        DirectoryInfo directory,
        CqlVersionedLibraryIdentifier versionedLibraryIdentifier)
        where TElmApi : IElmApiExtensible<TElmApi>
    {
        FileInfo file = new(Path.Combine(directory.FullName, $"{versionedLibraryIdentifier}.json"));
        if (file.Exists)
            return self.LoadElmFile(file);

        if (versionedLibraryIdentifier.Version is null)
            throw new FileNotFoundException($"Could not find file '{file.FullName}'.");

        self.Logger.LogWarning("Could not load library from file with name and version, trying without version: {file}", file.FullName);
        file = new FileInfo(Path.Combine(directory.FullName, $"{versionedLibraryIdentifier with { Version = null }}.json"));
        return self.LoadElmFile(file);
    }

    public static TElmApi LoadElmFiles<TElmApi>(
        this TElmApi self,
        IEnumerable<FileInfo> files)
        where TElmApi : IElmApiExtensible<TElmApi>
    {
        var libraries =
            files
                .Select(f =>
                {
                    self.Logger.LogInformation("Loading library from file: {file}", f);
                    var library = Library.LoadFromJson(f);
                    return library;
                }); // Log errors
        return self.AddElmLibraries(libraries);
    }

    public static TElmApi LoadElmFilesFromDirectory<TElmApi>(
        this TElmApi self,
        DirectoryInfo directory,
        EnumerationOptions? options = null)
        where TElmApi : IElmApiExtensible<TElmApi>
    {
        var files = directory.EnumerateFiles("*.json", options ?? InternalConstants.DefaultEnumerationOptions);
        return self.LoadElmFiles(files);
    }

    public static TElmApi LoadElmFileWithDependencies<TElmApi>(
        this TElmApi self,
        FileInfo file,
        EnumerationOptions? options)
        where TElmApi : IElmApiExtensible<TElmApi>
    {
        // TODO
        return self;
    }

    public static TElmApi LoadElmFileWithDependencies<TElmApi>(
        this TElmApi self,
        DirectoryInfo directory,
        CqlVersionedLibraryIdentifier fileName,
        EnumerationOptions? options)
        where TElmApi : IElmApiExtensible<TElmApi>
    {
        // TODO
        return self;
    }

    public static TElmApi LoadElmFile<TElmApi>(
        this TElmApi self,
        FileInfo file)
        where TElmApi : IElmApiExtensible<TElmApi>
    {
        return self.LoadElmFiles([file]);
    }
}