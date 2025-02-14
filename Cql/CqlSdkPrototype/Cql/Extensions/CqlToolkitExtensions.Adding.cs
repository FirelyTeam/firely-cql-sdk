using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Internal;

namespace CqlSdkPrototype.Cql.Extensions;

public static partial class CqlToolkitExtensions
{
    public static CqlToolkit AddCqlLibraryString(
        this CqlToolkit cqlToolkit,
        CqlLibraryString cqlLibrary)
    {
        return cqlToolkit.AddCqlLibraries([cqlLibrary]);
    }

    public static CqlToolkit AddCqlLibrariesFromDirectory(
        this CqlToolkit cqlToolkit,
        DirectoryInfo directory,
        EnumerationOptions? options = null,
        Func<FileInfo, bool>? filePredicate = null)
    {
        var files = directory.EnumerateFiles("*.cql", options ?? InternalConstants.DefaultEnumerationOptions);
        if (filePredicate is not null) files = files.Where(filePredicate);
        return cqlToolkit.AddCqlLibraryFiles(files);
    }

    public static CqlToolkit AddCqlLibraryFiles(
        this CqlToolkit cqlToolkit,
        IEnumerable<FileInfo> files)
    {
        var logger = cqlToolkit.CreateLogger();
        var cqlLibraries = files
            .Select(f =>
            {
                logger.LogInformation("Loading CQL from file: {file}", f);
                var cqlContent = File.ReadAllText(f.FullName);
                var cqlLibrary = CqlLibraryString.Parse(cqlContent);
                return cqlLibrary;
            }); // Log errors

        return cqlToolkit.AddCqlLibraries(cqlLibraries);
    }
}