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
using Hl7.Cql.Packager.Reporting;
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
        var tracker = new LibraryProcessingTracker();
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

            // Create path mapper if subdirectory preservation is requested
            SubdirectoryPathMapper? pathMapper = opt.MaintainSubdirsFrom == MaintainSubdirsFromSource.Cql
                ? new SubdirectoryPathMapper(opt.CqlInDir)
                : null;

            // Load CQL files with optional path tracking
            if (pathMapper is not null)
            {
                cqlToolkit = cqlToolkit.AddCqlLibrariesFromDirectoryWithTracking(opt.CqlInDir, pathMapper);
            }
            else
            {
                cqlToolkit = cqlToolkit.AddCqlLibrariesFromDirectory(opt.CqlInDir);
            }

            if (cqlToolkit.ArtifactsById.Count == 0)
            {
                logger.LogInformation($"Exiting. No CQL libraries found in directory {opt.CqlInDir}.");
                return ExitCode.NoCqlLibsInDir;
            }

            // Track loaded CQL libraries
            foreach (var (libraryId, artifacts) in cqlToolkit.ArtifactsById)
            {
                tracker.RecordStatus(libraryId, LibraryProcessingStage.Cql, LibraryStageStatus.Loaded(".cql"));
            }

            sbSummary.AppendLine(Invariant($"* Loaded {cqlToolkit.ArtifactsById.Count} CQL libraries from directory {opt.CqlInDir}."));

            var cqlToolkitResults = cqlToolkit.TranslateToElm()
                      .GetCqlToolkitResults()
                      .ToList();

            if (cqlToolkitResults.Count == 0)
            {
                logger.LogInformation("Exiting. No CQL libraries converted to ELM.");
                return ExitCode.NoElmLibsCompiled;
            }

            // Track ELM translation results
            var successfulElmLibraries = new HashSet<Runtime.CqlVersionedLibraryIdentifier>(cqlToolkitResults.Select(r => r.libraryIdentifier));
            foreach (var (libraryId, artifacts) in cqlToolkit.ArtifactsById)
            {
                if (successfulElmLibraries.Contains(libraryId))
                {
                    tracker.RecordStatus(libraryId, LibraryProcessingStage.Elm, LibraryStageStatus.Ok());
                }
                else
                {
                    tracker.RecordStatus(libraryId, LibraryProcessingStage.Elm, LibraryStageStatus.Failed());
                }
            }

            if (opt.ElmOutDir is not null)
            {
                cqlToolkit.SaveElmFilesToDirectoryWithSubdirs(
                    opt.ElmOutDir,
                    pathMapper,
                    writeIndented: packOpt.JsonPretty,
                    DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.json"));

                // Update status to "saved" for ELM
                foreach (var libraryId in successfulElmLibraries)
                {
                    tracker.RecordStatus(libraryId, LibraryProcessingStage.Elm, LibraryStageStatus.Saved(".json"));
                }

                sbSummary.AppendLine(Invariant($"* Saved {cqlToolkitResults.Count} ELM files to directory {opt.ElmOutDir}."));
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

            // Track C# and .NET results
            var successfulCompilations = new HashSet<Runtime.CqlVersionedLibraryIdentifier>(elmToolkitResults.Select(r => r.libraryIdentifier));
            foreach (var libraryId in successfulElmLibraries)
            {
                if (successfulCompilations.Contains(libraryId))
                {
                    tracker.RecordStatus(libraryId, LibraryProcessingStage.CSharp, LibraryStageStatus.Ok());
                    tracker.RecordStatus(libraryId, LibraryProcessingStage.DotNet, LibraryStageStatus.Ok());
                }
                else
                {
                    tracker.RecordStatus(libraryId, LibraryProcessingStage.CSharp, LibraryStageStatus.Failed());
                }
            }

            if (opt.CSharpOutDir is not null)
            {
                elmToolkit
                    .SaveCSharpFilesToDirectoryWithSubdirs(
                        opt.CSharpOutDir,
                        pathMapper,
                        DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.g.cs"));

                // Update status to "saved" for C#
                foreach (var libraryId in successfulCompilations)
                {
                    tracker.RecordStatus(libraryId, LibraryProcessingStage.CSharp, LibraryStageStatus.Saved(".g.cs"));
                }

                sbSummary.AppendLine(Invariant($"* Saved {elmToolkitResults.Count} C# files (*.g.cs) to directory {opt.CSharpOutDir}."));
            }

            if (opt.DllOutDir is not null)
            {
                elmToolkit
                    .CompileToAssemblies() // This is a no-op if the ElmToolkit has already compiled the ELM to assemblies
                    .SaveAssemblyBinariesToDirectoryWithSubdirs(
                        opt.DllOutDir,
                        opt.PdbOutDir ?? opt.DllOutDir,
                        pathMapper,
                        DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.dll"),
                        DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.pdb"));

                // Update status to "saved" for .NET
                var extensions = opt.PdbOutDir is not null ? new[] { ".dll", ".pdb" } : new[] { ".dll" };
                foreach (var libraryId in successfulCompilations)
                {
                    tracker.RecordStatus(libraryId, LibraryProcessingStage.DotNet, LibraryStageStatus.Saved(extensions));
                }

                sbSummary.AppendLine(Invariant($"* Saved {elmToolkitResults.Count} .NET Assembly files (*.dll) to directory {opt.DllOutDir}."));
                if (opt.PdbOutDir is not null)
                    sbSummary.AppendLine(Invariant($"* Saved {elmToolkitResults.Count} Debug Symbol files (*.pdb) to directory {opt.PdbOutDir}."));
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
                    .SaveFhirResourcesToDirectoryWithSubdirs(
                        opt.FhirOutDir,
                        pathMapper,
                        packOpt.JsonPretty,
                        DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.json"));

                var packagingResults = packagingToolkit.GetPackagingResults().ToList();
                var librariesCount = packagingResults.Count;
                var measuresCount = packagingResults.Count(r => r.resultArtifacts.FhirMeasure is { });

                // Track FHIR resource generation
                foreach (var (libraryId, resultArtifacts) in packagingResults)
                {
                    var extensions = new List<string> { "Library-*.json" };
                    if (resultArtifacts.FhirMeasure is not null)
                    {
                        extensions.Add("Measure-*.json");
                    }
                    tracker.RecordStatus(libraryId, LibraryProcessingStage.FhirResource, LibraryStageStatus.Saved([.. extensions]));
                }

                sbSummary.AppendLine(Invariant($"* Saved {librariesCount} FHIR libraries (Library-*.json) and {measuresCount} measures (Measure-*.json) to directory {opt.FhirOutDir}."));
            }

            return ExitCode.Normal;
        }
        finally
        {
            // Build summary text
            string summaryText = sbSummary.ToString();

            // Log detailed report with embedded summary
            var detailedReport = MarkdownReportFormatter.FormatReport(tracker, summaryText);
            if (!string.IsNullOrEmpty(detailedReport))
            {
                logger.LogInformation(detailedReport);
            }
        }
    }
}