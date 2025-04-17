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
    IOptions<FhirOptions> fhirOptions,
    IOptions<CqlToFhirOptions> cqlToElmOptions) : IProgram
{
    public static int CommandHandler(
        IConsole console,
        LoggingCommand loggingCommand,
        CqlToFhirCommand cqlToFhirCommand) =>
        RunProgram<CqlToFhirProgram>(
            console,
            loggingCommand,
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
            var fhirOpt = fhirOptions.Value;

            switch (opt.ElmOutDir, opt.CSharpOutDir, opt.DllOutDir, opt.FhirOutDir)
            {
                case (null, null, null, null):
                    logger.LogInformation("Exiting. No output directories specified.");
                    return ExitCode.NoOutputDirs;
            }

            CqlToolkit cqlToolkit = new CqlToolkit(loggerFactory, cqlOpt)
                                    .SetIgnoreEnumerationExceptions()
                                    .AddCqlLibrariesFromDirectory(opt.CqlInDir);

            if (cqlToolkit.Conversions.Count == 0)
            {
                logger.LogInformation($"Exiting. No CQL libraries found in directory {opt.CqlInDir}.");
                return ExitCode.NoCqlLibsInDir;
            }
            sbSummary.AppendLine(Invariant($"Loaded {cqlToolkit.Conversions.Count} CQL libraries from directory {opt.CqlInDir}."));

            var cqlToolkitResultRecords = cqlToolkit.ConvertCqlToElm()
                      .GetCqlToolkitResults()
                      .ToList();

            if (cqlToolkitResultRecords.Count == 0)
            {
                logger.LogInformation("Exiting. No CQL libraries converted to ELM.");
                return ExitCode.NoElmLibsCompiled;
            }

            if (opt.ElmOutDir is not null)
            {
                cqlToolkit.SaveElmFilesToDirectory(
                    opt.ElmOutDir,
                    writeIndented: opt.JsonPretty,
                    DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.json"));
                sbSummary.AppendLine(Invariant($"Saved {cqlToolkitResultRecords.Count} ELM files to directory {opt.ElmOutDir}."));
            }

            switch (opt.CSharpOutDir, opt.DllOutDir, opt.FhirOutDir)
            {
                case (null, null, null):
                    return ExitCode.Normal;
            }

            ElmToolkit elmToolkit = cqlToolkit.CreateElmToolkit(elmOpt);

            var elmToolkitResultRecords = elmToolkit
                                          .ConvertElmToAssemblies()
                                          .GetElmToAssemblyResults()
                                          .ToList();
            if (elmToolkitResultRecords.Count == 0)
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
                sbSummary.AppendLine(Invariant($"Saved {elmToolkitResultRecords.Count} C# files to directory {opt.CSharpOutDir}."));
            }

            if (opt.DllOutDir is not null)
            {
                elmToolkit
                    .ConvertElmToAssemblies() // This is a no-op if the ElmToolkit has already compiled the ELM to assemblies
                    .SaveAssemblyBinariesToDirectory(opt.DllOutDir, DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.dll"));
                sbSummary.AppendLine(Invariant($"Saved {elmToolkitResultRecords.Count} DLLs files to directory {opt.DllOutDir}."));
            }

            if (opt.FhirOutDir is not null)
            {
                var packagingToolkit = new PackagingToolkit(loggerFactory, fhirOpt, elmToolkit.BatchProcessExceptionContinuation)
                    .AddPackagingInputsFromCqlAndElmToolkits(cqlToolkit, elmToolkit);

                if (packagingToolkit.Conversions.Count == 0)
                {
                    logger.LogInformation("Exiting. No CQL or ELM libraries matched with each other for packaging.");
                    return ExitCode.CantPackageNoCqlElmMatches;
                }

                Mutator<JsonSerializerOptions>? configureJsonSerializerOptions = null;
                if (opt.JsonPretty)
                    configureJsonSerializerOptions = options =>
                    {
                        options.WriteIndented = true;
                        return options;
                    };

                packagingToolkit
                    .AddPackagingInputsFromCqlAndElmToolkits(cqlToolkit, elmToolkit)
                    .ConvertToFhirResources()
                    .SaveFhirResourcesToDirectory(
                        opt.FhirOutDir,
                        DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.json"),
                        configureJsonSerializerOptions);

                var packagingResults = packagingToolkit.GetPackagingResults().ToList();
                var librariesCount = packagingResults.Count;
                var measuresCount = packagingResults.Count(r => r.FhirMeasure is { });
                sbSummary.AppendLine(Invariant($"Saved {librariesCount} FHIR libraries and {measuresCount} measures to directory {opt.FhirOutDir}."));
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