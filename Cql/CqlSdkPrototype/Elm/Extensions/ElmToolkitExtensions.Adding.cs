using System.Runtime.CompilerServices;
using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Internal;
using Hl7.Cql.Elm;

#pragma warning disable RS0027

namespace CqlSdkPrototype.Elm.Extensions;

public static partial class ElmToolkitExtensions
{
    public static IElmFluentToolkit AddElmFrom(
        this IElmFluentToolkit elmToolkit,
        ICqlFluentToolkit cqlToolkit) =>
        elmToolkit.AddElmLibraries(
            from entry in cqlToolkit.CqlToElmConversions
            let elmLibrary = entry.Value.ElmLibrary
            where elmLibrary is not null
            select elmLibrary);

    public static IElmFluentToolkit AddElmFile(
        this IElmFluentToolkit elmToolkit,
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

    public static IElmFluentToolkit AddElmFiles(
        this IElmFluentToolkit elmToolkit,
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

    public static IElmFluentToolkit AddElmFilesFromDirectory(
        this IElmFluentToolkit elmToolkit,
        DirectoryInfo directory,
        EnumerationOptions? options = null,
        Func<FileInfo, bool>? filePredicate = null)
    {
        var files = directory.EnumerateFiles("*.json", options ?? InternalConstants.DefaultEnumerationOptions);
        if (filePredicate is not null) files = files.Where(filePredicate);
        return elmToolkit.AddElmFiles(files);
    }

    public static IElmFluentToolkit AddElmFileWithDependencies(
        this IElmFluentToolkit elmToolkit,
        FileInfo file,
        EnumerationOptions? options) =>
        throw new NotImplementedException();

    public static IElmFluentToolkit AddElmFileWithDependencies(
        this IElmFluentToolkit elmToolkit,
        DirectoryInfo directory,
        CqlVersionedLibraryIdentifier fileName,
        EnumerationOptions? options) =>
        throw new NotImplementedException();

    public static IElmFluentToolkit AddElmFile(
        this IElmFluentToolkit elmToolkit,
        FileInfo file) =>
        elmToolkit.AddElmFiles([file]);
}