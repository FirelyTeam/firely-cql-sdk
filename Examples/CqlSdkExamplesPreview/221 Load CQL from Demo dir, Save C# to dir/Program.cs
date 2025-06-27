using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.Toolkit;

partial class Program
{
    void LoadCqlFromDemoDirSaveCSharpToDir()
    {
        SetCurrentDirectory(Path.Combine(InitialCurrentDirectory, "221 Load CQL from Demo dir, Save C# to dir"));

        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

        // Add CQL libraries from directory
        var cqlDirectory = new DirectoryInfo(Path.Combine(LibrarySetsDirectory, "Demo/Cql"));
        var cqlToolkitCallbacks = new CqlToolkitCallbacks(
            TranslateError: (
                identifier,
                libraryString,
                exception) =>
            {
                ;
            });
        var cqlToolkit = new CqlToolkit(loggerFactory, null, null, cqlToolkitCallbacks);
        //cqlToolkit.SetIgnoreEnumerationExceptions();
        cqlToolkit.AddCqlLibrariesFromDirectory(
            cqlDirectory,
            filePredicate: f => f.Name is "CumulativeMedicationDurationFHIR4.cql" or "FHIRHelpers.cql");
        cqlToolkit.TranslateToElm();

        // Save ELM to directory
        var outputDirectory = new DirectoryInfo("output/elm");
        cqlToolkit.SaveElmFilesToDirectory(outputDirectory, writeIndented: true);


        // Generate binaries from the ELM libraries
        var allowInvalidCSharp = true;
        var elmToolkitCallbacks = new ElmToolkitCallbacks(
            BuildDefinitionsError: (
                identifier,
                library,
                exception) =>
            {
                ;
            },
            GenerateCSharpBefore: (
                identifier,
                library) =>
            {
                if (identifier.ToString() == "CumulativeMedicationDurationFHIR4-1.0.000")
                {
                    ;
                }
            },
            GenerateCSharpError: (
                identifier,
                library,
                exception) =>
            {
                ;
            }
        );
        var elmToolkitConfig = new ElmToolkitConfig(AllowInvalidCSharp: allowInvalidCSharp);
        var elmToolkit = cqlToolkit.CreateElmToolkit2(elmToolkitConfig, elmToolkitCallbacks)
                                   .SetIgnoreEnumerationExceptions();
        // elmToolkit.SetThrowEnumerationExceptions();
        elmToolkit.CompileToAssemblies();

        // Save the generated C# code and binaries to directory
        outputDirectory = new DirectoryInfo("output/cs");
        elmToolkit.SaveCSharpFilesToDirectory(outputDirectory);

        // Open Explorer to the output directory
        _ = Process.Start("explorer.exe", "output");
    }
}