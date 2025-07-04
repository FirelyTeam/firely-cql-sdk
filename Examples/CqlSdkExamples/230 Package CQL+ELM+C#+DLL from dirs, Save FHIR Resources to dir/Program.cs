using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.Elm;
using Hl7.Cql.Packaging.Toolkit;
using Hl7.Cql.Packaging.Toolkit.Extensions;
using Hl7.Cql.Runtime;

partial class Program
{
    void PackageCqlElmCSharpAndDllFromDirsSaveFhirResourcesToDir()
    {
        SetCurrentDirectory(Path.Combine(InitialCurrentDirectory, "230 Package CQL+ELM+C#+DLL from dirs, Save FHIR Resources to dir"));

        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
        var packagingToolkit = new PackagingToolkit(loggerFactory);

        // Add artefacts from directories
        var cqlDirectory = new DirectoryInfo("input/cql");
        var elmDirectory = new DirectoryInfo("input/elm");
        var csDirectory = new DirectoryInfo("input/cs");
        var dllDirectory = new DirectoryInfo("input/dll");
        var pdbDirectory = new DirectoryInfo("input/pdb");
        var fhirDirectory = new DirectoryInfo("output/fhir");

        var inputs =
            new[]
            {
                (
                    cql:(CqlLibraryString)cqlDirectory.ReadTextFromFile("FHIRHelpers.cql"),
                    elm:Library.ParseFromJson(elmDirectory.ReadTextFromFile("FHIRHelpers-4.0.001.json")),
                    cs:csDirectory.ReadTextFromFile("FHIRHelpers-4.0.001.g.cs"),
                    dll:dllDirectory.ReadBytesFromFile("FHIRHelpers-4.0.001.dll"),
                    pdb:pdbDirectory.ReadBytesFromFile("FHIRHelpers-4.0.001.pdb")
                ),
                (
                    cql:(CqlLibraryString)cqlDirectory.ReadTextFromFile("DevDays-2025.0.0.cql"),
                    elm:Library.ParseFromJson(elmDirectory.ReadTextFromFile("DevDays-2025.0.0.json")),
                    cs:csDirectory.ReadTextFromFile("DevDays-2025.0.0.g.cs"),
                    dll:dllDirectory.ReadBytesFromFile("DevDays-2025.0.0.dll"),
                    pdb:pdbDirectory.ReadBytesFromFile("DevDays-2025.0.0.pdb")
                )
            }
            .Select(t => new PackagingToolkitInputArtifacts(t.cql, t.elm, t.cs, t.dll, t.pdb));

        packagingToolkit.AddPackagingInputs(inputs);

        // Package into FHIR Resources
        packagingToolkit.ConvertToFhirResources();

        // Save packaged resources
        packagingToolkit.SaveFhirResourcesToDirectory(fhirDirectory);

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