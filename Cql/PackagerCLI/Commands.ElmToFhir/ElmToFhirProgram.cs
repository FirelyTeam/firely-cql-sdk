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
    IOptions<PackagingOptions> packagingOptions,
    IOptions<ElmToFhirOptions> elmToFhirOptions) : IProgram
{
    public int Run()
    {
        var opt = elmToFhirOptions.Value;
        var cqlOpt = cqlOptions.Value;
        var elmOpt = elmOptions.Value;
        var packOpt = packagingOptions.Value;

        if ((opt.Cs, opt.Dll, opt.Fhir) == (null, null, null))
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

        ElmToolkit elmToolkit = new ElmToolkit(loggerFactory, elmOpt)
                                .SetIgnoreEnumerationExceptions()
                                .AddElmFilesFromDirectory(
                                    opt.Elm,
                                    filePredicate: file => !elmOpt.SkipFiles.Contains(file.Name));
        if (elmToolkit.Conversions.Count == 0)
        {
            logger.LogInformation($"Exiting. No ELM libraries found in directory {opt.Elm}.");
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
        if (packOpt.JsonPretty)
            configureJsonSerializerOptions = options =>
            {
                options.WriteIndented = true;
                return options;
            };

        if (opt.Fhir is not null)
            packagingToolkit
                .AddPackagingInputsFromCqlAndElmToolkits(cqlToolkit, elmToolkit)
                .ConvertToFhirResources(packOpt.CanonicalRootUrl, packOpt.OverrideDate)
                .SaveFhirResourcesToDirectory(
                    opt.Fhir,
                    DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.json"),
                    configureJsonSerializerOptions);

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