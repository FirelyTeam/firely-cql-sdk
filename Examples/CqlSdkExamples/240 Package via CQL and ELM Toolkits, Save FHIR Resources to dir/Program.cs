using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Packaging.Toolkit.Extensions;

partial class Program
{
    void PackageViaCqlAndElmToolkitsSaveFhirResourcesToDir()
    {
        Environment.CurrentDirectory = Path.Combine(InitialCurrentDirectory, "240 Package via CQL and ELM Toolkits, Save FHIR Resources to dir");

        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

        // Add CQL libraries from directory
        var cqlDirectory = new DirectoryInfo("input/cql");
        var cqlToolkit = new CqlToolkit(loggerFactory);
        cqlToolkit.AddCqlLibrariesFromDirectory(cqlDirectory);

        // Add ELM libraries from directory
        var elmDirectory = new DirectoryInfo("input/elm");
        var elmToolkit = cqlToolkit.CreateElmToolkit();
        elmToolkit.AddElmFilesFromDirectory(elmDirectory);

        // Package into FHIR Resources (Use CQL as-is, compile ELM to C# and DLLs)
        var packagingToolkit = elmToolkit.PackageToFhirResources(cqlToolkit);

        // Save packaged resources
        packagingToolkit.SaveFhirResourcesToDirectory(new DirectoryInfo("output/fhir"));

        // Open Explorer to the output directory
        _ = Process.Start("explorer.exe", "output");
    }
}