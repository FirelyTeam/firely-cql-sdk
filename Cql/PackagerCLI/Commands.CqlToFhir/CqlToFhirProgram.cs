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

            switch (opt.ElmOutDir, opt.CSharpOutDir, opt.DllOutDir, opt.FhirOutDir, opt.LibrariesOutDir, opt.MeasuresOutDir)
            {
                case (null, null, null, null, null, null):
                    logger.LogError(ExitCodes.NoOutputDirs.ExitingMessage);
                    return ExitCodes.NoOutputDirs.Code;

                case (_, _, _, not null, not null, _):
                case (_, _, _, not null, _, not null):
                    logger.LogError(ExitCodes.MixedFhirAndSpecificDirs.ExitingMessage);
                    return ExitCodes.MixedFhirAndSpecificDirs.Code;

                case (_, _, _, null, not null, null):
                case (_, _, _, null, null, not null):
                    logger.LogError(ExitCodes.IncompleteLibrariesMeasuresDirs.ExitingMessage);
                    return ExitCodes.IncompleteLibrariesMeasuresDirs.Code;
            }

            if (pdbOptionsValidator.GetExitCodeForInvalidPdbConfiguration(elmOpt.DebugSymbolsFormat, opt.PdbOutDir, opt.DllOutDir, opt.FhirOutDir, opt.LibrariesOutDir, opt.MeasuresOutDir) is var exitCode and not ExitCodes.Success.Code)
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
                logger.LogError(ExitCodes.NoCqlLibsInDir.ExitingMessageWithPlaceholder, opt.CqlInDir);
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
                logger.LogError(ExitCodes.NoCqlLibsConvertedToElm.ExitingMessage);
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

            elmToolkit.CompileToAssemblies();

            // Libraries that generated C# (includes invalid C# when AllowInvalidCSharp is enabled)
            var elmToCSharpResults = elmToolkit.GetElmToCSharpResults().ToList();
            // Libraries that also compiled into a .NET assembly
            var elmToAssemblyResults = elmToolkit.GetElmToAssemblyResults().ToList();
            if (elmToCSharpResults.Count == 0)
            {
                logger.LogError(ExitCodes.NoElmLibsCompiled.ExitingMessage);
                return ExitCodes.NoElmLibsCompiled.Code;
            }

            // Track C# and .NET results
            var cSharpLibraries = new HashSet<CqlVersionedLibraryIdentifier>(elmToCSharpResults.Select(r => r.libraryIdentifier));
            var successfulCompilations = new HashSet<CqlVersionedLibraryIdentifier>(elmToAssemblyResults.Select(r => r.libraryIdentifier));
            foreach (var libraryId in successfulElmLibraries)
            {
                if (cSharpLibraries.Contains(libraryId))
                {
                    tracker.RecordStatus(libraryId, LibraryProcessingStage.CSharp, LibraryStageStatus.Ok());
                    tracker.RecordStatus(
                        libraryId,
                        LibraryProcessingStage.DotNet,
                        successfulCompilations.Contains(libraryId) ? LibraryStageStatus.Ok() : LibraryStageStatus.Failed());
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
                foreach (var libraryId in cSharpLibraries)
                {
                    tracker.RecordStatus(libraryId, LibraryProcessingStage.CSharp, LibraryStageStatus.Saved(".g.cs"));
                }

                sbSummary.AppendLine(Invariant($"* Saved {elmToCSharpResults.Count} C# files (*.g.cs) to directory {opt.CSharpOutDir}."));
            }

            // Outputs beyond C# require at least one library compiled into a .NET assembly
            if (elmToAssemblyResults.Count == 0)
            {
                if ((opt.DllOutDir, opt.FhirOutDir ?? opt.LibrariesOutDir ?? opt.MeasuresOutDir) is (null, null))
                    return ExitCodes.Success.Code;

                logger.LogError(ExitCodes.NoElmLibsCompiled.ExitingMessage);
                return ExitCodes.NoElmLibsCompiled.Code;
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
                var librariesWithDebugSymbols = elmToAssemblyResults
                    .Where(result => result.debugSymbolsBinary is { Length: > 0 })
                    .Select(result => result.libraryIdentifier)
                    .ToHashSet();
                foreach (var libraryId in successfulCompilations)
                {
                    var extensions = opt.PdbOutDir is not null && librariesWithDebugSymbols.Contains(libraryId)
                        ? new[] { ".dll", ".pdb" }
                        : new[] { ".dll" };
                    tracker.RecordStatus(libraryId, LibraryProcessingStage.DotNet, LibraryStageStatus.Saved(extensions));
                }

                sbSummary.AppendLine(Invariant($"* Saved {elmToAssemblyResults.Count} .NET Assembly files (*.dll) to directory {opt.DllOutDir}."));
                if (opt.PdbOutDir is not null)
                {
                    var debugSymbolsCount = elmToAssemblyResults.Count(result => result.debugSymbolsBinary is { Length: > 0 });
                    sbSummary.AppendLine(Invariant($"* Saved {debugSymbolsCount} Debug Symbol files (*.pdb) to directory {opt.PdbOutDir}."));
                }
            }

            if (opt.FhirOutDir is not null || opt.LibrariesOutDir is not null || opt.MeasuresOutDir is not null)
            {
                var packagingToolkit = new PackagingToolkit(loggerFactory, packOpt, elmToolkit.BatchProcessExceptionContinuation)
                    .AddPackagingInputs(cqlToolkit, elmToolkit);

                if (packagingToolkit.ArtifactsById.Count == 0)
                {
                    logger.LogError(ExitCodes.CantPackageNoCqlElmMatches.ExitingMessage);
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