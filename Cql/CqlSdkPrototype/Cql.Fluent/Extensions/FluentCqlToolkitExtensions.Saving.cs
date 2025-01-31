using Hl7.Cql.Abstractions.Infrastructure;

namespace CqlSdkPrototype.Cql.Fluent.Extensions;

public static partial class FluentCqlToolkitExtensions
{
    public static FluentCqlToolkit SaveElmFilesToDirectory(
        this FluentCqlToolkit cqlToolkit,
        DirectoryInfo directory,
        bool writeIndented = true,
        bool recreateDirectory = false)
    {
        if (recreateDirectory)
            directory.Recreate();
        else
            directory.Create();

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