using CqlSdkPrototype.Advanced;
using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype.CqlToElm;

public static class CqlTranslationSavingExtensions
{

    public static CqlTranslator SaveElmFileToDirectory(
        this CqlTranslator cqlTranslator,
        DirectoryInfo directory)
    {
        if (!directory.Exists)
            directory.Create();

        var logger = ((ILogAccessor<CqlTranslator>)cqlTranslator).Logger;
        foreach (var (libraryName, sourceCode) in cqlTranslator.ElmJsonStrings)
        {
            var fileName = Path.Combine(directory.FullName, $"{libraryName}.json");
            File.WriteAllText(fileName, sourceCode);
            logger.LogInformation("Saved ELM to file: {file}", fileName);
        }

        return cqlTranslator;
    }

}