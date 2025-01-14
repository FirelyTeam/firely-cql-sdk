using CqlSdkPrototype.Elm.Extensibility;

namespace CqlSdkPrototype.Elm;

public static partial class ElmApiExtensions
{

    public static TElmApi SaveCSharpFilesToDirectory<TElmApi>(
        this TElmApi elmApi,
        DirectoryInfo directory)
        where TElmApi : IElmApiExtensible<TElmApi>
    {
        if (!directory.Exists)
            directory.Create();

        return elmApi.UseLogger((elmApi, logger) =>
        {
            foreach (var (libraryName, (_, cSharpSourceCode, _, _)) in elmApi.Entries)
            {
                if (cSharpSourceCode is null)
                    continue;

                var fileName = Path.Combine(directory.FullName, $"{libraryName}.g.cs");
                File.WriteAllText(fileName, cSharpSourceCode);
                logger.LogInformation("Saved C# source code to file: {file}", fileName);
            }

            return elmApi;
        });
    }

    public static TElmApi SaveAssemblyBinariesToDirectory<TElmApi>(
        this TElmApi elmApi,
        DirectoryInfo directory)
        where TElmApi : IElmApiExtensible<TElmApi>
    {
        if (!directory.Exists)
            directory.Create();

        return elmApi.UseLogger((elmApi, logger) => {
            foreach (var (libraryName, (_, _, assemblyBytes, symbolsBytes)) in elmApi.Entries)
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
        });
    }

}