using CqlSdkPrototype.Infrastructure;

namespace CqlSdkPrototype.Cql.Fluent.Extensions;

public static partial class CqlToolkitExtensions
{
    public static CqlToolkit SaveElmFilesToDirectory(
        this CqlToolkit cqlToolkit,
        DirectoryInfo directory,
        bool writeIndented = true,
        DirectoryInfoHandler? directoryPreparationStrategy = null)
    {
        (directoryPreparationStrategy ?? DirectoryPreparationStrategy.CreateIfNotExists)(directory);

        var logger = cqlToolkit.CreateLogger();

        foreach (var (versionedLibraryIdentifier, _, elmLibrary) in cqlToolkit.GetCompletedCqlToElmTranslations())
        {
            var fileName = Path.Combine(directory.FullName, $"{versionedLibraryIdentifier}.json");
            File.WriteAllText(fileName, elmLibrary.SerializeToJson(writeIndented));
            logger.LogInformation("Saved ELM to file: {file}", fileName);
        }

        return cqlToolkit;
    }
}