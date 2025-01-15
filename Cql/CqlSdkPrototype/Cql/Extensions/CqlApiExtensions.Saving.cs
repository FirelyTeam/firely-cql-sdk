using CqlSdkPrototype.Cql.Extensibility;

namespace CqlSdkPrototype.Cql.Extensions;

public static partial class CqlApiExtensions
{
    public static TCqlApi SaveElmFileToDirectory<TCqlApi>(
        this TCqlApi cqlApi,
        DirectoryInfo directory,
        bool writeIndented = true)
        where TCqlApi : ICqlApiExtensible<TCqlApi>
    {
        if (!directory.Exists)
            directory.Create();

        var logger = cqlApi.LoggerFactory.CreateLogger(typeof(CqlApiExtensions));

        foreach (var (libraryName, (_, elmLibrary)) in cqlApi.Entries)
        {
            if (elmLibrary == null)
                continue;

            var fileName = Path.Combine(directory.FullName, $"{libraryName}.json");
            File.WriteAllText(fileName, elmLibrary.SerializeToJson(writeIndented));
            logger.LogInformation("Saved ELM to file: {file}", fileName);
        }

        return cqlApi;
    }
}