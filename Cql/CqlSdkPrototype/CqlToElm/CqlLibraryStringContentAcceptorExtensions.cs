using CqlSdkPrototype.CqlToElm.Advanced;
using CqlSdkPrototype.Internal;
using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype.CqlToElm;

public static class CqlLibraryStringContentAcceptorExtensions
{

    public static TCqlLibraryAcceptor LoadCqlFilesFromDirectory<TCqlLibraryAcceptor>(
        this TCqlLibraryAcceptor self,
        DirectoryInfo directory,
        EnumerationOptions? options = null,
        Func<FileInfo, bool>? filePredicate = null)
        where TCqlLibraryAcceptor : ICqlLibraryStringContentAcceptor<TCqlLibraryAcceptor>
    {
        var files = directory.EnumerateFiles("*.cql", options ?? InternalConstants.DefaultEnumerationOptions);
        if (filePredicate is not null) files = files.Where(filePredicate);
        return self.LoadCqlFiles(files);
    }

    public static TCqlLibraryAcceptor LoadCqlFiles<TCqlLibraryAcceptor>(
        this TCqlLibraryAcceptor self,
        IEnumerable<FileInfo> files)
        where TCqlLibraryAcceptor : ICqlLibraryStringContentAcceptor<TCqlLibraryAcceptor>
    {
        var cqlLibraries =
            files
                .Select(f =>
                {
                    self.Logger.LogInformation("Loading library from file: {file}", f);
                    var versionedLibraryIdentifier = CqlVersionedLibraryIdentifier.Parse(f.Name.TrimFileExtension(".cql"));
                    var cqlContent = File.ReadAllText(f.FullName);
                    var cqlLibrary = CqlLibraryStringContent.FromIdentifierAndString(versionedLibraryIdentifier, cqlContent);
                    return cqlLibrary;
                }); // Log errors
        return self.AcceptLibraries(cqlLibraries);
    }

}