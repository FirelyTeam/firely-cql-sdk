using CqlSdkPrototype.Cql.Extensibility;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Internal;

namespace CqlSdkPrototype.Cql.Extensions;

public static partial class CqlToolkitExtensions
{
    public static ICqlToolkit AddCqlLibraryString(
        this ICqlToolkit cqlToolkit,
        CqlLibraryString cqlLibrary)
    {
        return cqlToolkit.AddCqlLibraries([cqlLibrary]);
    }

    public static ICqlToolkit AddCqlLibrariesFromDirectory(
        this ICqlToolkit cqlToolkit,
        DirectoryInfo directory,
        EnumerationOptions? options = null,
        Func<FileInfo, bool>? filePredicate = null) =>
        cqlToolkit.Return(cqlToolkit =>
        {
            var files = directory.EnumerateFiles("*.cql", options ?? InternalConstants.DefaultEnumerationOptions);
            if (filePredicate is not null) files = files.Where(filePredicate);
            cqlToolkit.AddCqlLibraryFiles(files);
        });

    public static ICqlToolkit AddCqlLibraryFiles(
        this ICqlToolkit cqlToolkit,
        IEnumerable<FileInfo> files) =>
        cqlToolkit.Return((cqlToolkit, loggerFn) =>
        {
            var logger = loggerFn();
            var cqlLibraries = files
                .Select(f =>
                {
                    logger.LogInformation("Loading library from file: {file}", f);
                    var cqlContent = File.ReadAllText(f.FullName);
                    var cqlLibrary = CqlLibraryString.Parse(cqlContent);
                    return cqlLibrary;
                }); // Log errors

            cqlToolkit.AddCqlLibraries(cqlLibraries);
        });
}