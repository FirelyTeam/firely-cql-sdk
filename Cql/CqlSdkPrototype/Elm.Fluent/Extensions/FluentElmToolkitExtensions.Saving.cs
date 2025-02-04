namespace CqlSdkPrototype.Elm.Fluent.Extensions;

public static partial class FluentElmToolkitExtensions
{
    public static FluentElmToolkit SaveCSharpFilesToDirectory(
        this FluentElmToolkit elmToolkit,
        DirectoryInfo directory)
    {
        if (!directory.Exists)
            directory.Create();

        var logger = elmToolkit.LoggerFactory.CreateLogger(typeof(FluentElmToolkitExtensions));

        foreach (var (libraryName, (_, cSharpSourceCode, _, _)) in elmToolkit.ElmToAssemblyCompilations)
        {
            if (cSharpSourceCode is null)
                continue;

            var fileName = Path.Combine(directory.FullName, $"{libraryName}.g.cs");
            File.WriteAllText(fileName, cSharpSourceCode);
            logger.LogInformation("Saved C# source code to file: {file}", fileName);
        }

        return elmToolkit;
    }

    public static FluentElmToolkit SaveAssemblyBinariesToDirectory(
        this FluentElmToolkit elmToolkit,
        DirectoryInfo directory)
    {
        if (!directory.Exists)
            directory.Create();

        var logger = elmToolkit.LoggerFactory.CreateLogger(typeof(FluentElmToolkitExtensions));

        foreach (var (libraryName, (_, _, assemblyBytes, symbolsBytes)) in elmToolkit.ElmToAssemblyCompilations)
        {
            if (assemblyBytes is null)
                continue;

            var fileName = Path.Combine(directory.FullName, $"{libraryName}.dll");
            File.WriteAllBytes(fileName, assemblyBytes);
            logger.LogInformation("Saved assembly to file: {file}", fileName);

            if (symbolsBytes is { Length: > 0 })
            {
                fileName = Path.Combine(directory.FullName, $"{libraryName}.pdb");
                File.WriteAllBytes(fileName, symbolsBytes);
                logger.LogInformation("Saved debug symbols to file: {file}", fileName);
            }
        }

        return elmToolkit;
    }
}