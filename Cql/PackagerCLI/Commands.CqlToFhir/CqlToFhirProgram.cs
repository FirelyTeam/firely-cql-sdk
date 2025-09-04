/*
 * Copyright(c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Packager.Commands.Global;
using Hl7.Cql.Packager.Commands.Logging;
using Hl7.Cql.Packager.Options;
using Hl7.Cql.Packaging.Toolkit;
using Hl7.Cql.Packaging.Toolkit.Extensions;
using Hl7.Cql.Runtime.IO;
using Hl7.Cql.Toolkit;

namespace Hl7.Cql.Packager.Commands.CqlToFhir;

public class CqlToFhirProgram
(
    ILoggerFactory loggerFactory,
    ILogger<CqlToFhirProgram> logger,
    IOptions<CqlOptions> cqlOptions,
    IOptions<ElmOptions> elmOptions,
    IOptions<PackagingOptions> packagingOptions,
    IOptions<CqlToFhirOptions> cqlToElmOptions,
    PdbOptionsValidator pdbOptionsValidator) : IProgram
{
    public static int CommandHandler(
        IConsole console,
        LoggingCommand loggingCommand,
        GlobalCommand globalCommand,
        CqlToFhirCommand cqlToFhirCommand) =>
        RunProgram<CqlToFhirProgram>(
            console,
            loggingCommand,
            globalCommand,
            cqlToFhirCommand.GetConfigMapping,
            (_, services) =>
                services.AddAndBindOptions<CqlToFhirOptions>());

    public int Run()
    {
        StringBuilder sbSummary = new StringBuilder();
        try
        {
            var opt = cqlToElmOptions.Value;
            var cqlOpt = cqlOptions.Value;
            var elmOpt = elmOptions.Value;
            var packOpt = packagingOptions.Value;

            switch (opt.ElmOutDir, opt.CSharpOutDir, opt.DllOutDir, opt.FhirOutDir)
            {
                case (null, null, null, null):
                    logger.LogInformation("Exiting. No output directories specified.");
                    return ExitCode.NoOutputDirs;
            }

            if (pdbOptionsValidator.GetExitCodeForInvalidPdbConfiguration(elmOpt.DebugSymbolsFormat, opt.PdbOutDir, opt.DllOutDir, opt.FhirOutDir) is var exitCode and not ExitCode.Normal)
            {
                return exitCode;
            }

            CqlToolkit cqlToolkit = new CqlToolkit(loggerFactory, cqlOpt);

            if (!packOpt.ExitOnError)
                cqlToolkit = cqlToolkit.SetIgnoreEnumerationExceptions();

            cqlToolkit = cqlToolkit.AddCqlLibrariesFromDirectory(opt.CqlInDir);

            if (cqlToolkit.ArtifactsById.Count == 0)
            {
                logger.LogInformation($"Exiting. No CQL libraries found in directory {opt.CqlInDir}.");
                return ExitCode.NoCqlLibsInDir;
            }
            sbSummary.AppendLine(Invariant($"Loaded {cqlToolkit.ArtifactsById.Count} CQL libraries from directory {opt.CqlInDir}."));

            var cqlToolkitResults = cqlToolkit.TranslateToElm()
                      .GetCqlToolkitResults()
                      .ToList();

            if (cqlToolkitResults.Count == 0)
            {
                logger.LogInformation("Exiting. No CQL libraries converted to ELM.");
                return ExitCode.NoElmLibsCompiled;
            }

            if (opt.ElmOutDir is not null)
            {
                cqlToolkit.SaveElmFilesToDirectory(
                    opt.ElmOutDir,
                    writeIndented: elmOpt.JsonPretty,
                    DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.json"));
                sbSummary.AppendLine(Invariant($"Saved {cqlToolkitResults.Count} ELM files to directory {opt.ElmOutDir}."));
            }

            switch (opt.CSharpOutDir, opt.DllOutDir, opt.FhirOutDir)
            {
                case (null, null, null):
                    return ExitCode.Normal;
            }

            ElmToolkit elmToolkit = cqlToolkit.CreateElmToolkit(elmOpt);

            var elmToolkitResults = elmToolkit
                                    .CompileToAssemblies()
                                    .GetElmToAssemblyResults()
                                    .ToList();
            if (elmToolkitResults.Count == 0)
            {
                logger.LogInformation("Exiting. No ELM libraries compiled to C#/DLL.");
                return ExitCode.NoElmLibsCompiled;
            }

            if (opt.CSharpOutDir is not null)
            {
                elmToolkit
                    .SaveCSharpFilesToDirectory(
                        opt.CSharpOutDir,
                        DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.g.cs"));
                sbSummary.AppendLine(Invariant($"Saved {elmToolkitResults.Count} C# files (*.g.cs) to directory {opt.CSharpOutDir}."));
            }

            if (opt.DllOutDir is not null)
            {
                elmToolkit
                    .CompileToAssemblies() // This is a no-op if the ElmToolkit has already compiled the ELM to assemblies
                    .SaveAssemblyBinariesToDirectory(
                        opt.DllOutDir,
                        opt.PdbOutDir ?? opt.DllOutDir,
                        DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.dll"),
                        DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.pdb"));

                sbSummary.AppendLine(Invariant($"Saved {elmToolkitResults.Count} .NET Assembly files (*.dll) to directory {opt.DllOutDir}."));
                if (opt.PdbOutDir is not null)
                    sbSummary.AppendLine(Invariant($"Saved {elmToolkitResults.Count} Debug Symbol files (*.pdb) to directory {opt.PdbOutDir}."));
            }

            if (opt.FhirOutDir is not null)
            {
                var packagingToolkit = new PackagingToolkit(loggerFactory, packOpt, elmToolkit.BatchProcessExceptionContinuation)
                    .AddPackagingInputs(cqlToolkit, elmToolkit);

                if (packagingToolkit.ArtifactsById.Count == 0)
                {
                    logger.LogInformation("Exiting. No CQL or ELM libraries matched with each other for packaging.");
                    return ExitCode.CantPackageNoCqlElmMatches;
                }

                packagingToolkit
                    .AddPackagingInputs(cqlToolkit, elmToolkit)
                    .ConvertToFhirResources()
                    .SaveFhirResourcesToDirectory(
                        opt.FhirOutDir,
                        packOpt.JsonPretty,
                        DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.json"));

                var packagingResults = packagingToolkit.GetPackagingResults().ToList();
                var librariesCount = packagingResults.Count;
                var measuresCount = packagingResults.Count(r => r.resultArtifacts.FhirMeasure is { });
                sbSummary.AppendLine(Invariant($"Saved {librariesCount} FHIR libraries (Library-*.json) and {measuresCount} measures (Measure-*.json) to directory {opt.FhirOutDir}."));
            }

            return ExitCode.Normal;
        }
        finally
        {
            if (sbSummary.Length > 0)
            {
                sbSummary.Insert(0, Environment.NewLine);
                sbSummary.Insert(0, "Summary:");
                logger.LogInformation(sbSummary.ToString());
            }
        }
    }
}