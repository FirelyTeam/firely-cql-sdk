namespace CqlSdkPrototype.Cql.Fluent.Extensions;

public static partial class FluentCqlToolkitExtensions
{
    public static FluentCqlToolkit SaveElmFilesToDirectory(
        this FluentCqlToolkit cqlToolkit,
        DirectoryInfo directory,
        bool writeIndented = true)
    {
        if (!directory.Exists)
            directory.Create();

        var logger = cqlToolkit.CreateLogger();

        foreach (var (libraryName, (_, elmLibrary)) in cqlToolkit.CqlToElmConversions)
        {
            if (elmLibrary == null)
                continue;

            var fileName = Path.Combine(directory.FullName, $"{libraryName}.json");
            File.WriteAllText(fileName, elmLibrary.SerializeToJson(writeIndented));
            logger.LogInformation("Saved ELM to file: {file}", fileName);
        }

        return cqlToolkit;
    }
}