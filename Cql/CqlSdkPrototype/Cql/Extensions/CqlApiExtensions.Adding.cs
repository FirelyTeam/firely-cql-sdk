using CqlSdkPrototype.Cql.Extensibility;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Internal;

namespace CqlSdkPrototype.Cql.Extensions;

public static partial class CqlApiExtensions
{
    public static CqlApi AddCqlLibraryString(
        this CqlApi cqlApi,
        CqlLibraryString cqlLibrary)
    {
        return cqlApi.AddCqlLibraries([cqlLibrary]);
    }

    public static CqlApi AddCqlLibrariesFromDirectory(
        this CqlApi cqlApi,
        DirectoryInfo directory,
        EnumerationOptions? options = null,
        Func<FileInfo, bool>? filePredicate = null)
    {
        var files = directory.EnumerateFiles("*.cql", options ?? InternalConstants.DefaultEnumerationOptions);
        if (filePredicate is not null) files = files.Where(filePredicate);
        return cqlApi.AddCqlLibraryFiles(files);
    }

    public static CqlApi AddCqlLibraryFiles(
        this CqlApi cqlApi,
        IEnumerable<FileInfo> files)
    {
        var logger = cqlApi.LoggerFactory.CreateLogger(typeof(CqlApiExtensions));
        var cqlLibraries = files
            .Select(f =>
            {
                logger.LogInformation("Loading library from file: {file}", f);
                        var cqlContent = File.ReadAllText(f.FullName);
                        var cqlLibrary = CqlLibraryString.Parse(cqlContent);
                        return cqlLibrary;
                    }); // Log errors

        return cqlApi.AddCqlLibraries(cqlLibraries);
    }
}