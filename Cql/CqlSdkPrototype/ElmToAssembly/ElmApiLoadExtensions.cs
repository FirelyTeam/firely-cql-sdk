using CqlSdkPrototype.CqlToElm;
using CqlSdkPrototype.ElmToAssembly.Advanced;
using CqlSdkPrototype.Internal;
using Hl7.Cql.Elm;
using Microsoft.Extensions.Logging;
#pragma warning disable RS0027

namespace CqlSdkPrototype.ElmToAssembly;

public static class ElmApiLoadExtensions
{
    public static ElmApi CompileAssemblies(
        this CqlApi cqlApi)
    {
        var elmApiOptions = ElmApiOptions.Create(cqlApi.Options);
        var convertToElm = cqlApi.ConvertToElm();
        return ElmApi.Create(elmApiOptions)
                     .LoadElmFromCqlApi(convertToElm)
                     .CompileAssemblies();
    }

    public static TElmApi LoadElmFromCqlApi<TElmApi>(
        this TElmApi self,
        CqlApi cqlApi)
        where TElmApi : IElmApiBase<TElmApi>
    {
        var libraries = cqlApi.GetElmLibraries().Values.ToArray();
        return self.AddElmLibraries(libraries);
    }

    public static TElmApi LoadElmFile<TElmApi>(
        this TElmApi self,
        DirectoryInfo directory,
        CqlVersionedLibraryIdentifier versionedLibraryIdentifier)
        where TElmApi : IElmApiBase<TElmApi>
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
        where TElmApi : IElmApiBase<TElmApi>
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
        where TElmApi : IElmApiBase<TElmApi>
    {
        var files = directory.EnumerateFiles("*.json", options ?? InternalConstants.DefaultEnumerationOptions);
        return self.LoadElmFiles(files);
    }

    public static TElmApi LoadElmFileWithDependencies<TElmApi>(
        this TElmApi self,
        FileInfo file,
        EnumerationOptions? options)
        where TElmApi : IElmApiBase<TElmApi>
    {
        // TODO
        return self;
    }

    public static TElmApi LoadElmFileWithDependencies<TElmApi>(
        this TElmApi self,
        DirectoryInfo directory,
        CqlVersionedLibraryIdentifier fileName,
        EnumerationOptions? options)
        where TElmApi : IElmApiBase<TElmApi>
    {
        // TODO
        return self;
    }

    public static TElmApi LoadElmFile<TElmApi>(
        this TElmApi self,
        FileInfo file)
        where TElmApi : IElmApiBase<TElmApi>
    {
        return self.LoadElmFiles([file]);
    }
}