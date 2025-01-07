using CqlSdkPrototype.Advanced;
using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype.ElmToAssembly;

public static class ElmApiSaveExtensions
{

    public static ElmApi SaveCSharpFilesToDirectory(
        this ElmApi elmApi,
        DirectoryInfo directory)
    {
        if (!directory.Exists)
            directory.Create();

        var logger = ((ILogAccessor<ElmApi>)elmApi).Logger;
        foreach (var (libraryName, sourceCode) in elmApi.GetCSharpSourceCodes())
        {
            var fileName = Path.Combine(directory.FullName, $"{libraryName}.g.cs");
            File.WriteAllText(fileName, sourceCode);
            logger.LogInformation("Saved C# source code to file: {file}", fileName);
        }

        return elmApi;
    }

    public static ElmApi SaveAssemblyBinariesToDirectory(
        this ElmApi elmApi,
        DirectoryInfo directory)
    {
        if (!directory.Exists)
            directory.Create();

        var logger = ((ILogAccessor<ElmApi>)elmApi).Logger;
        foreach (var (libraryName, (assemblyBytes, symbolsBytes)) in elmApi.GetAssemblyBinaries())
        {
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