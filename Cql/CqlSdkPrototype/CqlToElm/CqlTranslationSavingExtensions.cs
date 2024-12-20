using CqlSdkPrototype.Advanced;
using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype.CqlToElm;

public static class CqlTranslationSavingExtensions
{

    public static CqlTranslation SaveElmFileToDirectory(
        this CqlTranslation cqlTranslation,
        DirectoryInfo directory)
    {
        if (!directory.Exists)
            directory.Create();

        var logger = ((ILogAccessor<CqlTranslation>)cqlTranslation).Logger;
        foreach (var (libraryName, sourceCode) in cqlTranslation.ElmJsonStrings)
        {
            var fileName = Path.Combine(directory.FullName, $"{libraryName}.json");
            File.WriteAllText(fileName, sourceCode);
            logger.LogInformation($"Saved ELM to file: {fileName}");
        }

        return cqlTranslation;
    }

}