/*
 * Copyright(c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
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
using Hl7.Cql.Runtime;
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
                    return ExitCodes.NoOutputDirs.Code;
            }

            if (pdbOptionsValidator.GetExitCodeForInvalidPdbConfiguration(elmOpt.DebugSymbolsFormat, opt.PdbOutDir, opt.DllOutDir, opt.FhirOutDir) is var exitCode and not ExitCodes.Success.Code)
            {
                return exitCode;
            }

            // Create subdirectory preserver if not flattening hierarchy
            SubdirectoryPreserver? subdirectoryPreserver = opt.FlattenDirHierarchy 
                ? null 
                : new SubdirectoryPreserver();

            CqlToolkit cqlToolkit = new CqlToolkit(loggerFactory, cqlOpt);

            if (!packOpt.ExitOnError)
                cqlToolkit = cqlToolkit.SetIgnoreEnumerationExceptions();

            cqlToolkit = cqlToolkit.AddCqlLibrariesFromDirectory(
                opt.CqlInDir,
                subdirectoryPreserver: subdirectoryPreserver);

            if (cqlToolkit.ArtifactsById.Count == 0)
            {
                logger.LogInformation($"Exiting. No CQL libraries found in directory {opt.CqlInDir}.");
                return ExitCodes.NoCqlLibsInDir.Code;
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
                return ExitCodes.NoCqlLibsConvertedToElm.Code;
            }

            // Track ELM translation results
            var successfulElmLibraries = new HashSet<CqlVersionedLibraryIdentifier>(cqlToolkitResults.Select(r => r.libraryIdentifier));
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
                cqlToolkit.SaveElmFilesToDirectory(
                    opt.ElmOutDir,
                    writeIndented: packOpt.JsonPretty,
                    DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.json"),
                    subdirectoryPreserver: subdirectoryPreserver);

                // Update status to "saved" for ELM
                foreach (var libraryId in successfulElmLibraries)
                {
                    tracker.RecordStatus(libraryId, LibraryProcessingStage.Elm, LibraryStageStatus.Saved(".json"));
                }

                sbSummary.AppendLine(Invariant($"* Saved {cqlToolkitResults.Count} ELM files to directory {opt.ElmOutDir}."));
            }

            switch (opt.CSharpOutDir, opt.DllOutDir, opt.FhirOutDir, opt.LibrariesOutDir, opt.MeasuresOutDir)
            {
                case (null, null, null, null, null):
                    return ExitCodes.Success.Code;
            }

            ElmToolkit elmToolkit = cqlToolkit.CreateElmToolkit(elmOpt);

            var elmToolkitResults = elmToolkit
                                    .CompileToAssemblies()
                                    .GetElmToAssemblyResults()
                                    .ToList();
            if (elmToolkitResults.Count == 0)
            {
                logger.LogInformation("Exiting. No ELM libraries compiled to C#/DLL.");
                return ExitCodes.NoElmLibsCompiled.Code;
            }

            // Track C# and .NET results
            var successfulCompilations = new HashSet<CqlVersionedLibraryIdentifier>(elmToolkitResults.Select(r => r.libraryIdentifier));
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
                    .SaveCSharpFilesToDirectory(
                        opt.CSharpOutDir,
                        DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.g.cs"),
                        subdirectoryPreserver: subdirectoryPreserver);

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
                    .SaveAssemblyBinariesToDirectory(
                        opt.DllOutDir,
                        opt.PdbOutDir ?? opt.DllOutDir,
                        DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.dll"),
                        DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.pdb"),
                        subdirectoryPreserver: subdirectoryPreserver);

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

            if (opt.FhirOutDir is not null || opt.LibrariesOutDir is not null || opt.MeasuresOutDir is not null)
            {
                // Validate mutual exclusivity: either --fhir alone, or both --libraries and --measures
                bool hasFhir = opt.FhirOutDir is not null;
                bool hasLibrariesDir = opt.LibrariesOutDir is not null;
                bool hasMeasuresDir = opt.MeasuresOutDir is not null;

                if (hasFhir && (hasLibrariesDir || hasMeasuresDir))
                {
                    logger.LogError("Cannot mix --fhir with --libraries or --measures. Use either --fhir alone for all resources, or both --libraries and --measures for separate directories.");
                    return ExitCodes.MixedFhirAndSpecificDirs.Code;
                }

                if (hasLibrariesDir != hasMeasuresDir)
                {
                    logger.LogError("Both --libraries and --measures must be specified together. Use --fhir if you want all resources in one directory.");
                    return ExitCodes.IncompleteLibrariesMeasuresDirs.Code;
                }

                var packagingToolkit = new PackagingToolkit(loggerFactory, packOpt, elmToolkit.BatchProcessExceptionContinuation)
                    .AddPackagingInputs(cqlToolkit, elmToolkit);

                if (packagingToolkit.ArtifactsById.Count == 0)
                {
                    logger.LogInformation("Exiting. No CQL or ELM libraries matched with each other for packaging.");
                    return ExitCodes.CantPackageNoCqlElmMatches.Code;
                }

                // Determine the target directories for libraries and measures
                var librariesDir = opt.LibrariesOutDir ?? opt.FhirOutDir!;
                var measuresDir = opt.MeasuresOutDir ?? opt.FhirOutDir!;

                packagingToolkit
                    .AddPackagingInputs(cqlToolkit, elmToolkit)
                    .ConvertToFhirResources()
                    .SaveFhirResourcesToDirectory(
                        new SaveFhirResourcesToDirectoriesOptions(
                            librariesDir,
                            measuresDir,
                            packOpt.JsonPretty,
                            DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.json"),
                            SubdirectoryPreserver: subdirectoryPreserver));

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

                // Build summary message
                sbSummary.AppendLine(Invariant($"* Saved {librariesCount} FHIR libraries (Library-*.json) to directory {librariesDir}."));
                if (measuresCount > 0)
                {
                    sbSummary.AppendLine(Invariant($"* Saved {measuresCount} measures (Measure-*.json) to directory {measuresDir}."));
                }
            }

            return ExitCodes.Success.Code;
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