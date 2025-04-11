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
using Hl7.Cql.Packager.Options;
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
    IOptions<FhirOptions> fhirOptions,
    IOptions<ElmToFhirOptions> elmToFhirOptions) : IProgram
{
    public int Run()
    {
        var opt = elmToFhirOptions.Value;
        var cqlOpt = cqlOptions.Value;
        var elmOpt = elmOptions.Value;
        var fhirOpt = fhirOptions.Value;

        switch (opt.CSharpOutDir, opt.DllOutDir, opt.FhirOutDir)
        {
            case (null, null, null):
                logger.LogInformation("Exiting. No output directories specified.");
                return ExitCode.NoOutputDirs;

            case (_, _, not null) when opt.CqlInDir is not { Exists:true }:
                logger.LogInformation("Exiting. CQL input directory required when outputting FHIR.");
                return ExitCode.NoCqlDirRequiredForFhir;
        }

        ElmToolkit elmToolkit = new ElmToolkit(loggerFactory, elmOpt)
                                .SetIgnoreEnumerationExceptions()
                                .AddElmFilesFromDirectory(
                                    opt.ElmInDir,
                                    filePredicate: file => !elmOpt.SkipFiles.Contains(file.Name));
        if (elmToolkit.Conversions.Count == 0)
        {
            logger.LogInformation($"Exiting. No ELM libraries found in directory {opt.ElmInDir}.");
            return ExitCode.NoElmLibsInDir;
        }

        var elmToolkitResultRecords = elmToolkit
                                      .ConvertElmToAssemblies()
                                      .GetElmToAssemblyResults()
                                      .ToList();
        if (elmToolkitResultRecords.Count == 0)
        {
            logger.LogInformation("Exiting. No ELM libraries compiled.");
            return ExitCode.NoElmLibsCompiled;
        }

        if (opt.CSharpOutDir is not null)
            elmToolkit
                .SaveCSharpFilesToDirectory(
                    opt.CSharpOutDir,
                    DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.g.cs"));

        if (opt.DllOutDir is not null)
            elmToolkit
                .SaveAssemblyBinariesToDirectory(opt.DllOutDir, DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.dll"));

        if ((Cql: opt.CqlInDir, Fhir: opt.FhirOutDir) is (not null, not null))
        {
            CqlToolkit cqlToolkit = new CqlToolkit(loggerFactory, cqlOpt)
                                    .SetIgnoreEnumerationExceptions()
                                    .AddCqlLibrariesFromDirectory(opt.CqlInDir);

            if (cqlToolkit.Conversions.Count == 0)
            {
                logger.LogInformation($"Exiting. No CQL libraries found in directory {opt.CqlInDir}.");
                return ExitCode.NoCqlLibsInDir;
            }

            var packagingToolkit = new PackagingToolkit(loggerFactory)
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
                .ConvertToFhirResources(fhirOpt.CanonicalRootUrl, fhirOpt.OverrideDate)
                .SaveFhirResourcesToDirectory(
                    opt.FhirOutDir,
                    DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.json"),
                    configureJsonSerializerOptions);
        }

        return ExitCode.Normal;
    }

    internal static int CommandHandler(
        IConsole console,
        LoggingCommand loggingCommand,
        ElmToFhirCommand elmToFhirCommand) =>
        RunProgram<ElmToFhirProgram>(
            console,
            loggingCommand,
            elmToFhirCommand.GetConfigMapping,
            (_, services) =>
                services.AddAndBindOptions<ElmToFhirOptions>());
}