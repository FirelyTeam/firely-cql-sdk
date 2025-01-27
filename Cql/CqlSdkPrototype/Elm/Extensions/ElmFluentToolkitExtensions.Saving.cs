namespace CqlSdkPrototype.Elm.Extensions;

public static partial class ElmFluentToolkitExtensions
{
    public static ElmFluentToolkit SaveCSharpFilesToDirectory(
        this ElmFluentToolkit elmApi,
        DirectoryInfo directory)
    {
        if (!directory.Exists)
            directory.Create();

        var logger = elmApi.LoggerFactory.CreateLogger(typeof(ElmFluentToolkitExtensions));

        foreach (var (libraryName, (_, cSharpSourceCode, _, _)) in elmApi.ElmToAssemblyConversions)
        {
            if (cSharpSourceCode is null)
                continue;

            var fileName = Path.Combine(directory.FullName, $"{libraryName}.g.cs");
            File.WriteAllText(fileName, cSharpSourceCode);
            logger.LogInformation("Saved C# source code to file: {file}", fileName);
        }

        return elmApi;
    }

    public static ElmFluentToolkit SaveAssemblyBinariesToDirectory(
        this ElmFluentToolkit elmApi,
        DirectoryInfo directory)
    {
        if (!directory.Exists)
            directory.Create();

        var logger = elmApi.LoggerFactory.CreateLogger(typeof(ElmFluentToolkitExtensions));

        foreach (var (libraryName, (_, _, assemblyBytes, symbolsBytes)) in elmApi.ElmToAssemblyConversions)
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

        return elmApi;
    }

}