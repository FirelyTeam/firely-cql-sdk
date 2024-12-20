using CqlSdkPrototype.Advanced;
using CqlSdkPrototype.CqlToElm;
using Hl7.Cql.Elm;
using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype.ElmToAssembly;

public static class LibraryAcceptorExtensions
{
    public static TLibraryAcceptor LoadCqlTranslation<TLibraryAcceptor>(
        this TLibraryAcceptor self,
        CqlTranslation cqlTranslation)
        where TLibraryAcceptor : ILibraryAcceptor<TLibraryAcceptor>
    {
        return self.AcceptLibraries(cqlTranslation.ElmLibraries.Values);
    }

    public static TLibraryAcceptor LoadElmFilesFromDirectory<TLibraryAcceptor>(
        this TLibraryAcceptor self,
        DirectoryInfo directory,
        EnumerationOptions options)
        where TLibraryAcceptor : ILibraryAcceptor<TLibraryAcceptor>
    {
        var files = directory.EnumerateFiles("*.json", options);
        return self.LoadElmFiles(files);
    }

    public static TLibraryAcceptor LoadElmFiles<TLibraryAcceptor>(
        this TLibraryAcceptor self,
        IEnumerable<FileInfo> files)
        where TLibraryAcceptor : ILibraryAcceptor<TLibraryAcceptor>
    {
        var libraries =
            files
                .Select(f =>
                {
                    self.Logger.LogInformation("Loading library from file: {file}", f);
                    var library = Library.LoadFromJson(f);
                    return library;
                }); // Log errors
        return self.AcceptLibraries(libraries);
    }

    public static TLibraryAcceptor LoadElmFileWithDependencies<TLibraryAcceptor>(
        this TLibraryAcceptor self,
        FileInfo file,
        EnumerationOptions options)
        where TLibraryAcceptor : ILibraryAcceptor<TLibraryAcceptor>
    {
        // TODO
        return self;
    }

    public static TLibraryAcceptor LoadElmFileWithDependencies<TLibraryAcceptor>(
        this TLibraryAcceptor self,
        DirectoryInfo directory,
        ElmVersionedLibraryIdentifier fileName,
        EnumerationOptions options)
        where TLibraryAcceptor : ILibraryAcceptor<TLibraryAcceptor>
    {
        // TODO
        return self;
    }

    public static TLibraryAcceptor LoadElmFile<TLibraryAcceptor>(
        this TLibraryAcceptor self,
        FileInfo file)
        where TLibraryAcceptor : ILibraryAcceptor<TLibraryAcceptor>
    {
        return self.LoadElmFiles([file]);
    }

    public static TLibraryAcceptor LoadElmFile<TLibraryAcceptor>(
        this TLibraryAcceptor self,
        DirectoryInfo directory,
        ElmVersionedLibraryIdentifier libraryName)
        where TLibraryAcceptor : ILibraryAcceptor<TLibraryAcceptor>
    {
        FileInfo file = new(Path.Combine(directory.FullName, $"{libraryName}.json"));
        if (file.Exists)
            return self.LoadElmFile(file);

        if (libraryName.Version is null)
            throw new FileNotFoundException($"Could not find file '{file.FullName}'.");

        self.Logger.LogWarning("Could not load library from file with name and version, trying without version: {file}", file.FullName);
        file = new FileInfo(Path.Combine(directory.FullName, $"{libraryName with { Version = null }}.json"));
        return self.LoadElmFile(file);
    }
}