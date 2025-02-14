using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Elm.Extensions;

public static partial class ElmToolkitExtensions
{
    public static ElmToolkit SaveCSharpFilesToDirectory(
        this ElmToolkit elmToolkit,
        DirectoryInfo directory,
        DirectoryInfoHandler? directoryPreparationStrategy = null)
    {
        (directoryPreparationStrategy ?? DirectoryPreparationStrategy.CreateIfNotExists)(directory);

        var logger = elmToolkit.LoggerFactory.CreateLogger(typeof(ElmToolkitExtensions));

        foreach (var (versionedLibraryIdentifier, _, csharpSourceCode, _, _) in elmToolkit.GetCompletedElmToAssemblyCompilations())
        {
            var fileName = Path.Combine(directory.FullName, $"{versionedLibraryIdentifier}.g.cs");
            File.WriteAllText(fileName, csharpSourceCode);
            logger.LogInformation("Saved C# source code to file: {file}", fileName);
        }

        return elmToolkit;
    }

    public static ElmToolkit SaveAssemblyBinariesToDirectory(
        this ElmToolkit elmToolkit,
        DirectoryInfo directory,
        DirectoryInfoHandler? directoryPreparationStrategy = null)
    {
        (directoryPreparationStrategy ?? DirectoryPreparationStrategy.CreateIfNotExists)(directory);

        var logger = elmToolkit.LoggerFactory.CreateLogger(typeof(ElmToolkitExtensions));

        foreach (var (versionedLibraryIdentifier, _, _, assemblyBytes, debugSymbolsBytes) in elmToolkit.GetCompletedElmToAssemblyCompilations())
        {
            var fileName = Path.Combine(directory.FullName, $"{versionedLibraryIdentifier}.dll");
            File.WriteAllBytes(fileName, assemblyBytes);
            logger.LogInformation("Saved assembly to file: {file}", fileName);

            if (debugSymbolsBytes is { Length: > 0 } dsb)
            {
                fileName = Path.Combine(directory.FullName, $"{versionedLibraryIdentifier}.pdb");
                File.WriteAllBytes(fileName, dsb);
                logger.LogInformation("Saved debug symbols to file: {file}", fileName);
            }
        }

        return elmToolkit;
    }
}