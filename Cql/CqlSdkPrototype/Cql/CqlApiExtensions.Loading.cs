using CqlSdkPrototype.Cql.Extensibility;
using CqlSdkPrototype.Internal;
using Hl7.Cql.Runtime.Hosting;
using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype.Cql;

public static partial class CqlApiExtensions
{
    public static TCqlApi AddCqlLibraryString<TCqlApi>(
        this TCqlApi self,
        CqlLibraryString cqlLibrary)
        where TCqlApi : ICqlApi<TCqlApi>
    {
        return self.AddCqlLibraries([cqlLibrary]);
    }

    public static TCqlApi AddCqlLibrariesFromDirectory<TCqlApi>(
        this TCqlApi self,
        DirectoryInfo directory,
        EnumerationOptions? options = null,
        Func<FileInfo, bool>? filePredicate = null)
        where TCqlApi : ICqlApi<TCqlApi>
    {
        var files = directory.EnumerateFiles("*.cql", options ?? InternalConstants.DefaultEnumerationOptions);
        if (filePredicate is not null) files = files.Where(filePredicate);
        return self.AddCqlLibraryFiles(files);
    }

    public static TCqlApi AddCqlLibraryFiles<TCqlApi>(
        this TCqlApi self,
        IEnumerable<FileInfo> files)
        where TCqlApi : ICqlApi<TCqlApi>
    {
        var logger = self.Options.ServiceProvider.GetLogger<CqlApi>();
        var cqlLibraries =
            files
                .Select(f =>
                {
                    logger.LogInformation("Loading library from file: {file}", f);
                    var versionedLibraryIdentifier = CqlVersionedLibraryIdentifier.Parse(f.Name.TrimFileExtension(".cql"));
                    var cqlContent = File.ReadAllText(f.FullName);
                    var cqlLibrary = CqlLibraryString.FromIdentifierAndString(versionedLibraryIdentifier, cqlContent);
                    return cqlLibrary;
                }); // Log errors
        return self.AddCqlLibraries(cqlLibraries);
    }
}