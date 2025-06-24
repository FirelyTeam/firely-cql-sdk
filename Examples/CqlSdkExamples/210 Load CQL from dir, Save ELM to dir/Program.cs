using System.Diagnostics;
using Microsoft.Extensions.Logging;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;

partial class Program
{
    void LoadCqlFromDirSaveElmToDir()
    {
        SetCurrentDirectory(Path.Combine(InitialCurrentDirectory, "210 Load CQL from dir, Save ELM to dir"));
        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

        // Add CQL libraries from a directory
        var cqlToolkit = new CqlToolkit(loggerFactory);
        var cqlDirectory = new DirectoryInfo("input/cql");
        cqlToolkit.AddCqlLibrariesFromDirectory(cqlDirectory);

        // Translate CQL to ELM
        cqlToolkit.TranslateToElm();

        // Save ELM files to a directory
        var elmOutputDirectory = new DirectoryInfo("output/elm");
        cqlToolkit.SaveElmFilesToDirectory(elmOutputDirectory);

        // Open Explorer to the output directory
        _ = Process.Start("explorer.exe", "output");
    }
}