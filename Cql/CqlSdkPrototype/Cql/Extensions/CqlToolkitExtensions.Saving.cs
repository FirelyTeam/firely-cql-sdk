using CqlSdkPrototype.Cql.Extensibility;

namespace CqlSdkPrototype.Cql.Extensions;

public static partial class CqlToolkitExtensions
{
    public static ICqlToolkit SaveElmFileToDirectory(
        this ICqlToolkit cqlToolkit,
        DirectoryInfo directory,
        bool writeIndented = true) =>
        cqlToolkit.Return((cqlToolkit, loggerFn) =>
        {
            if (!directory.Exists)
                directory.Create();

            var logger = loggerFn();

            foreach (var (libraryName, (_, elmLibrary)) in cqlToolkit.ProcessItems)
            {
                if (elmLibrary == null)
                    continue;

                var fileName = Path.Combine(directory.FullName, $"{libraryName}.json");
                File.WriteAllText(fileName, elmLibrary.SerializeToJson(writeIndented));
                logger.LogInformation("Saved ELM to file: {file}", fileName);
            }
        });
}