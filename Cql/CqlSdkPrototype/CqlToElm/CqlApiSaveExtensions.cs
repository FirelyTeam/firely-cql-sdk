using CqlSdkPrototype.Advanced;
using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype.CqlToElm;

public static class CqlApiSaveExtensions
{

    public static CqlApi SaveElmFileToDirectory(
        this CqlApi cqlApi,
        DirectoryInfo directory)
    {
        if (!directory.Exists)
            directory.Create();

        var logger = ((ILogAccessor<CqlApi>)cqlApi).Logger;
        foreach (var (libraryName, sourceCode) in cqlApi.GetElmJsonStrings())
        {
            var fileName = Path.Combine(directory.FullName, $"{libraryName}.json");
            File.WriteAllText(fileName, sourceCode);
            logger.LogInformation("Saved ELM to file: {file}", fileName);
        }

        return cqlApi;
    }

}