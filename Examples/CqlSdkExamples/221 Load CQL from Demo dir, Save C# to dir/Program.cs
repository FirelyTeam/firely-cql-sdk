using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Toolkit;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Hl7.Cql.CodeGeneration.NET.Toolkit;

partial class Program
{
    void LoadCqlFromDemoDirSaveCSharpToDir()
    {
        SetCurrentDirectory(Path.Combine(InitialCurrentDirectory, "221 Load CQL from Demo dir, Save C# to dir"));

        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

        // Add CQL libraries from directory
        var cqlDirectory = new DirectoryInfo(Path.Combine(LibrarySetsDirectory, "Demo/Cql"));
        var cqlToolkit = new CqlToolkit(loggerFactory);
        cqlToolkit.SetIgnoreEnumerationExceptions();
        cqlToolkit.AddCqlLibrariesFromDirectory(
            cqlDirectory,
            filePredicate: f => f.Name is "CumulativeMedicationDurationFHIR4.cql" or "FHIRHelpers.cql");
        cqlToolkit.TranslateToElm();

        // Save ELM to directory
        var outputDirectory = new DirectoryInfo("output/elm");
        cqlToolkit.SaveElmFilesToDirectory(outputDirectory, writeIndented:true);


        // Generate binaries from the ELM libraries
        var allowInvalidCSharp = true;
        var elmToolkitConfig = new ElmToolkitConfig(AllowInvalidCSharp: allowInvalidCSharp);
        var elmToolkit = cqlToolkit.CreateElmToolkit(elmToolkitConfig);
        // elmToolkit.SetThrowEnumerationExceptions();
        elmToolkit.CompileToAssemblies();

        // Save the generated C# code and binaries to directory
        outputDirectory = new DirectoryInfo("output/cs");
        elmToolkit.SaveCSharpFilesToDirectory(outputDirectory);

        // Open Explorer to the output directory
        _ = Process.Start("explorer.exe", "output");
    }
}