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
using Hl7.Cql.Packager.Commands.ElmToFhir;
using Hl7.Cql.Packager.Options;
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
        var opt = cqlToElmOptions.Value;
        var cqlOpt = cqlOptions.Value;
        var elmOpt = elmOptions.Value;
        var fhirOpt = fhirOptions.Value;

        if ((opt.Elm, opt.Cs, opt.Dll, opt.Fhir) == (null, null, null, null))
        {
            logger.LogInformation("Exiting. No output directories specified.");
            return ExitCode.NoOutputDirs;
        }

        CqlToolkit cqlToolkit = new CqlToolkit(loggerFactory, cqlOpt)
                                .SetIgnoreEnumerationExceptions()
                                .AddCqlLibrariesFromDirectory(opt.Cql);

        if (cqlToolkit.Conversions.Count == 0)
        {
            logger.LogInformation($"Exiting. No CQL libraries found in directory {opt.Cql}.");
            return ExitCode.NoCqlLibsInDir;
        }

        var cqlToolkitResultRecords =
            cqlToolkit.ConvertCqlToElm()
                      .GetCqlToolkitResults()
                      .ToList();

        if (cqlToolkitResultRecords.Count == 0)
        {
            logger.LogInformation("Exiting. No CQL libraries converted.");
            return ExitCode.NoElmLibsCompiled;
        }

        if (opt.Elm is not null)
            cqlToolkit.SaveElmFilesToDirectory(
                opt.Elm,
                writeIndented: opt.JsonPretty,
                DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.json"));

        if ((opt.Cs, opt.Dll, opt.Fhir) == (null, null, null))
            return ExitCode.Normal;

        ElmToolkit elmToolkit = cqlToolkit.CreateElmToolkit(elmOpt);
        if (elmToolkit.Conversions.Count == 0)
        {
            logger.LogInformation($"Exiting. No ELM libraries.");
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

        if (opt.Cs is not null)
            elmToolkit
                .SaveCSharpFilesToDirectory(
                    opt.Cs,
                    DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.g.cs"));

        if (opt.Dll is not null)
            elmToolkit
                .ConvertElmToAssemblies() // This is a no-op if the ElmToolkit has already compiled the ELM to assemblies
                .SaveAssemblyBinariesToDirectory(opt.Dll, DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.dll"));

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

        if (opt.Fhir is not null)
            packagingToolkit
                .AddPackagingInputsFromCqlAndElmToolkits(cqlToolkit, elmToolkit)
                .ConvertToFhirResources(fhirOpt.CanonicalRootUrl, fhirOpt.OverrideDate)
                .SaveFhirResourcesToDirectory(
                    opt.Fhir,
                    DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.json"),
                    configureJsonSerializerOptions);

        return ExitCode.Normal;
    }
}