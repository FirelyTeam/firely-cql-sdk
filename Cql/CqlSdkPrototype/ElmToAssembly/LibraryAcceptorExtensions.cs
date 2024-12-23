using CqlSdkPrototype.CqlToElm;
using CqlSdkPrototype.ElmToAssembly.Advanced;
using CqlSdkPrototype.Internal;
using Hl7.Cql.Elm;
using Microsoft.Extensions.Logging;
#pragma warning disable RS0027

namespace CqlSdkPrototype.ElmToAssembly;

public static class LibraryAcceptorExtensions
{
    public static TLibraryAcceptor LoadCqlTranslation<TLibraryAcceptor>(
        this TLibraryAcceptor self,
        CqlTranslator cqlTranslator)
        where TLibraryAcceptor : IElmLibraryAcceptor<TLibraryAcceptor>
    {
        return self.AcceptLibraries(cqlTranslator.ElmLibraries.Values);
    }

    public static TLibraryAcceptor LoadElmFile<TLibraryAcceptor>(
        this TLibraryAcceptor self,
        DirectoryInfo directory,
        CqlVersionedLibraryIdentifier versionedLibraryIdentifier)
        where TLibraryAcceptor : IElmLibraryAcceptor<TLibraryAcceptor>
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

    public static TLibraryAcceptor LoadElmFiles<TLibraryAcceptor>(
        this TLibraryAcceptor self,
        IEnumerable<FileInfo> files)
        where TLibraryAcceptor : IElmLibraryAcceptor<TLibraryAcceptor>
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

    public static TLibraryAcceptor LoadElmFilesFromDirectory<TLibraryAcceptor>(
        this TLibraryAcceptor self,
        DirectoryInfo directory,
        EnumerationOptions? options = null)
        where TLibraryAcceptor : IElmLibraryAcceptor<TLibraryAcceptor>
    {
        var files = directory.EnumerateFiles("*.json", options ?? InternalConstants.DefaultEnumerationOptions);
        return self.LoadElmFiles(files);
    }

    public static TLibraryAcceptor LoadElmFileWithDependencies<TLibraryAcceptor>(
        this TLibraryAcceptor self,
        FileInfo file,
        EnumerationOptions? options)
        where TLibraryAcceptor : IElmLibraryAcceptor<TLibraryAcceptor>
    {
        // TODO
        return self;
    }

    public static TLibraryAcceptor LoadElmFileWithDependencies<TLibraryAcceptor>(
        this TLibraryAcceptor self,
        DirectoryInfo directory,
        CqlVersionedLibraryIdentifier fileName,
        EnumerationOptions? options)
        where TLibraryAcceptor : IElmLibraryAcceptor<TLibraryAcceptor>
    {
        // TODO
        return self;
    }

    public static TLibraryAcceptor LoadElmFile<TLibraryAcceptor>(
        this TLibraryAcceptor self,
        FileInfo file)
        where TLibraryAcceptor : IElmLibraryAcceptor<TLibraryAcceptor>
    {
        return self.LoadElmFiles([file]);
    }
}