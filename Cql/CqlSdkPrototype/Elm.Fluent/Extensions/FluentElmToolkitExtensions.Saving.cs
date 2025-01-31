using CqlSdkPrototype.Infrastructure;

namespace CqlSdkPrototype.Elm.Fluent.Extensions;

public static partial class FluentElmToolkitExtensions
{
    public static FluentElmToolkit SaveCSharpFilesToDirectory(
        this FluentElmToolkit elmToolkit,
        DirectoryInfo directory,
        DirectoryPreparationStrategy? directoryPreparationStrategy = null)
    {
        (directoryPreparationStrategy ?? DirectoryPreparationStrategy.CreateIfNotExists).PrepareDirectory(directory);

        var logger = elmToolkit.LoggerFactory.CreateLogger(typeof(FluentElmToolkitExtensions));

        foreach (var (versionedLibraryIdentifier, _, csharpSourceCode, _, _) in elmToolkit.GetCompletedElmToAssemblyCompilations())
        {
            var fileName = Path.Combine(directory.FullName, $"{versionedLibraryIdentifier}.g.cs");
            File.WriteAllText(fileName, csharpSourceCode);
            logger.LogInformation("Saved C# source code to file: {file}", fileName);
        }

        return elmToolkit;
    }

    public static FluentElmToolkit SaveAssemblyBinariesToDirectory(
        this FluentElmToolkit elmToolkit,
        DirectoryInfo directory,
        DirectoryPreparationStrategy? directoryPreparationStrategy = null)
    {
        (directoryPreparationStrategy ?? DirectoryPreparationStrategy.CreateIfNotExists).PrepareDirectory(directory);

        var logger = elmToolkit.LoggerFactory.CreateLogger(typeof(FluentElmToolkitExtensions));

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