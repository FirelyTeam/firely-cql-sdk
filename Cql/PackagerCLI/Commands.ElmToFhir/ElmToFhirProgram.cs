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

namespace Hl7.Cql.Packager.Commands.ElmToFhir;

internal sealed class ElmToFhirProgram
(
    ILoggerFactory loggerFactory,
    ILogger<ElmToFhirProgram> logger,
    IOptions<CqlOptions> cqlOptions,
    IOptions<ElmOptions> elmOptions,
    IOptions<PackagingOptions> packagingOptions,
    IOptions<ElmToFhirOptions> elmToFhirOptions,
    PdbOptionsValidator pdbOptionsValidator) : IProgram
{
    public int Run()
    {
        StringBuilder sbSummary = new StringBuilder();
        var tracker = new LibraryProcessingTracker();
        try
        {
            var opt = elmToFhirOptions.Value;
            var cqlOpt = cqlOptions.Value;
            var elmOpt = elmOptions.Value;
            var packOpt = packagingOptions.Value;

            switch (opt.CSharpOutDir, opt.DllOutDir, opt.FhirOutDir)
            {
                case (null, null, null):
                    logger.LogInformation("Exiting. No output directories specified.");
                    return ExitCode.NoOutputDirs;

                case (_, _, not null) when opt.CqlInDir is not { Exists: true }:
                    logger.LogInformation("Exiting. CQL input directory required when outputting FHIR.");
                    return ExitCode.NoCqlDirRequiredForFhir;
            }

            if (pdbOptionsValidator.GetExitCodeForInvalidPdbConfiguration(elmOpt.DebugSymbolsFormat, opt.PdbOutDir, opt.DllOutDir, opt.FhirOutDir) is var exitCode and not ExitCode.Normal)
            {
                return exitCode;
            }

            ElmToolkit elmToolkit = new ElmToolkit(loggerFactory, elmOpt);

            if (!packOpt.ExitOnError)
                elmToolkit = elmToolkit.SetIgnoreEnumerationExceptions();

            // Create path mapper if subdirectory preservation is requested
            SubdirectoryPathMapper? pathMapper = opt.MaintainSubdirs switch
            {
                MaintainSubdirsSource.Elm => new SubdirectoryPathMapper(opt.ElmInDir),
                MaintainSubdirsSource.Cql when opt.CqlInDir is not null => new SubdirectoryPathMapper(opt.CqlInDir),
                _ => null
            };

            // Load ELM files with optional path tracking
            if (pathMapper is not null && opt.MaintainSubdirs == MaintainSubdirsSource.Elm)
            {
                elmToolkit = elmToolkit.AddElmFilesFromDirectoryWithTracking(
                    opt.ElmInDir,
                    pathMapper,
                    filePredicate: file => !elmOpt.SkipFiles.Contains(file.Name));
            }
            else
            {
                elmToolkit = elmToolkit.AddElmFilesFromDirectory(
                    opt.ElmInDir,
                    filePredicate: file => !elmOpt.SkipFiles.Contains(file.Name));
            }

            if (elmToolkit.ArtifactsById.Count == 0)
            {
                logger.LogInformation($"Exiting. No ELM libraries found in directory {opt.ElmInDir}.");
                return ExitCode.NoElmLibsInDir;
            }

            // Track loaded ELM libraries
            foreach (var (libraryId, artifacts) in elmToolkit.ArtifactsById)
            {
                tracker.RecordStatus(libraryId, LibraryProcessingStage.Elm, LibraryStageStatus.Loaded(".json"));
            }

            sbSummary.AppendLine(Invariant($"* Loaded {elmToolkit.ArtifactsById.Count} ELM libraries from directory {opt.ElmInDir}."));

            var elmToolkitResults = elmToolkit
                                    .CompileToAssemblies()
                                    .GetElmToAssemblyResults()
                                    .ToList();
            if (elmToolkitResults.Count == 0)
            {
                logger.LogInformation("Exiting. No ELM libraries compiled.");
                return ExitCode.NoElmLibsCompiled;
            }

            // Track C# and .NET results - check which libraries have successful results
            var successfulLibraries = new HashSet<Runtime.CqlVersionedLibraryIdentifier>(elmToolkitResults.Select(r => r.libraryIdentifier));
            foreach (var (libraryId, artifacts) in elmToolkit.ArtifactsById)
            {
                if (successfulLibraries.Contains(libraryId))
                {
                    // Successfully compiled to C# and assemblies
                    tracker.RecordStatus(libraryId, LibraryProcessingStage.CSharp, LibraryStageStatus.Ok());
                    tracker.RecordStatus(libraryId, LibraryProcessingStage.DotNet, LibraryStageStatus.Ok());
                }
                else
                {
                    // Failed to compile
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
                foreach (var libraryId in successfulLibraries)
                {
                    tracker.RecordStatus(libraryId, LibraryProcessingStage.CSharp, LibraryStageStatus.Saved(".g.cs"));
                }

                sbSummary.AppendLine(Invariant($"* Saved {elmToolkitResults.Count} C# files (*.g.cs) to directory {opt.CSharpOutDir}."));
            }

            if (opt.DllOutDir is not null)
            {
                elmToolkit
                    .SaveAssemblyBinariesToDirectoryWithSubdirs(
                        opt.DllOutDir,
                        opt.PdbOutDir ?? opt.DllOutDir,
                        pathMapper,
                        DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.dll"),
                        DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.pdb"));

                // Update status to "saved" for .NET
                var extensions = opt.PdbOutDir is not null ? new[] { ".dll", ".pdb" } : new[] { ".dll" };
                foreach (var libraryId in successfulLibraries)
                {
                    tracker.RecordStatus(libraryId, LibraryProcessingStage.DotNet, LibraryStageStatus.Saved(extensions));
                }

                sbSummary.AppendLine(Invariant($"* Saved {elmToolkitResults.Count} .NET Assembly files (*.dll) to directory {opt.DllOutDir}."));
                if (opt.PdbOutDir is not null)
                    sbSummary.AppendLine(Invariant($"* Saved {elmToolkitResults.Count} Debug Symbol files (*.pdb) to directory {opt.PdbOutDir}."));
            }

            if ((opt.CqlInDir, opt.FhirOutDir) is (not null, not null))
            {
                // Load CQL files with optional path tracking if MaintainSubdirs is Cql
                CqlToolkit cqlToolkit = new CqlToolkit(loggerFactory, cqlOpt)
                    .SetIgnoreEnumerationExceptions();

                if (pathMapper is not null && opt.MaintainSubdirs == MaintainSubdirsSource.Cql)
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

    internal static int CommandHandler(
        IConsole console,
        LoggingCommand loggingCommand,
        GlobalCommand globalCommand,
        ElmToFhirCommand elmToFhirCommand) =>
        RunProgram<ElmToFhirProgram>(
            console,
            loggingCommand,
            globalCommand,
            elmToFhirCommand.GetConfigMapping,
            (_, services) =>
                services.AddAndBindOptions<ElmToFhirOptions>());
}