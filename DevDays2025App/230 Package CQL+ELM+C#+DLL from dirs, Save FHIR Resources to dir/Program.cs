using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.Elm;
using Hl7.Cql.Packaging.Toolkit;
using Hl7.Cql.Packaging.Toolkit.Extensions;

partial class Program
{
    void PackageCqlElmCSharpAndDllFromDirsSaveFhirResourcesToDir()
    {
        Environment.CurrentDirectory = Path.Combine(InitialCurrentDirectory, "230 Package CQL+ELM+C#+DLL from dirs, Save FHIR Resources to dir");

        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
        var packagingToolkit = new PackagingToolkit(loggerFactory);

        // Add artefacts from directories
        var cqlDirectory = new DirectoryInfo("input/cql");
        var elmDirectory = new DirectoryInfo("input/elm");
        var csDirectory = new DirectoryInfo("input/cs");
        var dllDirectory = new DirectoryInfo("input/dll");
        packagingToolkit.AddPackagingInputs([
            new PackagingToolkitSourceRecord(
                (CqlLibraryString)cqlDirectory.ReadTextFromFile("FHIRHelpers.cql"),
                Library.ParseFromJson(elmDirectory.ReadTextFromFile("FHIRHelpers-4.0.001.json")),
                csDirectory.ReadTextFromFile("FHIRHelpers-4.0.001.g.cs"),
                dllDirectory.ReadBytesFromFile("FHIRHelpers-4.0.001.dll")
            ),
            new PackagingToolkitSourceRecord(
                (CqlLibraryString)cqlDirectory.ReadTextFromFile("DevDays-2025.0.0.cql"),
                Library.ParseFromJson(elmDirectory.ReadTextFromFile("DevDays-2025.0.0.json")),
                csDirectory.ReadTextFromFile("DevDays-2025.0.0.g.cs"),
                dllDirectory.ReadBytesFromFile("DevDays-2025.0.0.dll")
            ),
        ]);

        // Package into FHIR Resources
        packagingToolkit.ConvertToFhirResources();

        // Save packaged resources
        packagingToolkit.SaveFhirResourcesToDirectory(new DirectoryInfo("output/fhir"));

        // Open Explorer to the output directory
        _ = Process.Start("explorer.exe", "output");
    }
}

file static class Extensions
{
    public static string ReadTextFromFile(this DirectoryInfo dir, string fileName) =>
        File.ReadAllText(Path.Combine(dir.FullName, fileName));

    public static byte[] ReadBytesFromFile(this DirectoryInfo dir, string fileName) =>
        File.ReadAllBytes(Path.Combine(dir.FullName, fileName));
}