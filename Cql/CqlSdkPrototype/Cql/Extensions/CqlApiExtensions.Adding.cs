using CqlSdkPrototype.Cql.Extensibility;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Internal;

namespace CqlSdkPrototype.Cql.Extensions;

public static partial class CqlApiExtensions
{
    public static TCqlApi AddCqlLibraryString<TCqlApi>(
        this TCqlApi cqlApi,
        CqlLibraryString cqlLibrary)
        where TCqlApi : ICqlApiExtendable<TCqlApi>
    {
        return cqlApi.AddCqlLibraries([cqlLibrary]);
    }

    public static TCqlApi AddCqlLibrariesFromDirectory<TCqlApi>(
        this TCqlApi cqlApi,
        DirectoryInfo directory,
        EnumerationOptions? options = null,
        Func<FileInfo, bool>? filePredicate = null)
        where TCqlApi : ICqlApiExtendable<TCqlApi>
    {
        var files = directory.EnumerateFiles("*.cql", options ?? InternalConstants.DefaultEnumerationOptions);
        if (filePredicate is not null) files = files.Where(filePredicate);
        return cqlApi.AddCqlLibraryFiles(files);
    }

    public static TCqlApi AddCqlLibraryFiles<TCqlApi>(
        this TCqlApi cqlApi,
        IEnumerable<FileInfo> files)
        where TCqlApi : ICqlApiExtendable<TCqlApi>
    {
        var logger = cqlApi.LoggerFactory.CreateLogger(typeof(CqlApiExtensions));
        var cqlLibraries = files
            .Select(f =>
            {
                logger.LogInformation("Loading library from file: {file}", f);
                        var versionedLibraryIdentifier = CqlVersionedLibraryIdentifier.Parse(f.Name.TrimFileExtension(".cql"));
                        var cqlContent = File.ReadAllText(f.FullName);
                        var cqlLibrary = CqlLibraryString.FromIdentifierAndString(versionedLibraryIdentifier, cqlContent);
                        return cqlLibrary;
                    }); // Log errors

        return cqlApi.AddCqlLibraries(cqlLibraries);
    }
}