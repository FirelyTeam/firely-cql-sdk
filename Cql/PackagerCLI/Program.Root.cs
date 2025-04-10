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

namespace Hl7.Cql.Packager;

partial class Program
{
    private static RootCommand BuildRootCommand() =>
        new RootCommand("Firely CQL Packager")
            {
                Option<DirectoryInfo>("--elm", "ELM input directory")
                    .Required()
                    .ExistingOnly(),

                Option<DirectoryInfo>("--cql", "CQL input directory")
                    .Required()
                    .ExistingOnly(),

                Option<DirectoryInfo>("--cs", "C# output directory"),

                Option<DirectoryInfo>("--dll", "DLL/PDB output directory"),

                Option<DirectoryInfo>("--fhir", "FHIR Resource output directory")
                    .Required(),

                Option<bool>("--log-debug", "Debug-level logging"),

                Option<bool>("--log-append", "Append to existing log file, instead of clearing"),

                Option<bool>("--json-pretty", "Output JSON using multiline and indentation"),

                Option<string>("--canonical-root-url", "The root canonical url output in FHIR library"),

                Option<DateTimeOffset>("--override-utc-date-time", "Override date output in FHIR library"),
            }
            .SetHandler(nameof(LegacyProgram));

    private static int LegacyProgram(
        IConsole console,
        LegacyProgramArgs legacyProgramArgs)
    {
        var result =
            CreateHostBuilder(console, legacyProgramArgs)
                .ConfigureServices(
                    (context, services) =>
                        services.AddSingleton<OptionsConsoleDumper>())
                .RunProgram<LegacyProgram>();
        return result;
    }
}

internal record LegacyProgramArgs(
    DirectoryInfo cql,
    DirectoryInfo elm,
    DirectoryInfo? cs,
    DirectoryInfo? dll,
    DirectoryInfo fhir,
    bool? logDebug,
    bool? logAppend,
    bool? jsonPretty,
    DateTimeOffset? overrideUtcDateTime,
    string? canonicalRootUrl);

internal sealed class LegacyProgram(
    ILoggerFactory loggerFactory,
    ILogger<LegacyProgram> logger,
    IOptions<CqlOptions> cqlOptions,
    IOptions<ElmOptions> elmOptions,
    IOptions<PackagingOptions> packagingOptions,
    LegacyProgramArgs args,
    OptionsConsoleDumper optionsConsoleDumper) : IProgram
{
    public int Run()
    {
        optionsConsoleDumper.DumpToConsole();

        var cqlOpt = cqlOptions.Value;
        var elmOpt = elmOptions.Value;
        var packOpt = packagingOptions.Value;

        CqlToolkit cqlToolkit = new CqlToolkit(loggerFactory, cqlOpt)
                                .SetIgnoreEnumerationExceptions()
                                .AddCqlLibrariesFromDirectory(args.cql);

        if (cqlToolkit.Conversions.Count == 0)
        {
            logger.LogInformation($"Exiting. No CQL libraries found in directory {args.cql}.");
            return 1;
        }

        ElmToolkit elmToolkit = new ElmToolkit(loggerFactory, elmOpt)
                                .SetIgnoreEnumerationExceptions()
                                .AddElmFilesFromDirectory(
                                    args.elm,
                                    filePredicate: file => !elmOpt.SkipFiles.Contains(file.Name));
        if (elmToolkit.Conversions.Count == 0)
        {
            logger.LogInformation($"Exiting. No ELM libraries found in directory {args.elm}.");
            return 2;
        }

        var elmToolkitResultRecords = elmToolkit
                                      .ConvertElmToAssemblies()
                                      .GetElmToAssemblyResults()
                                      .ToList();
        if (elmToolkitResultRecords.Count == 0)
        {
            logger.LogInformation("Exiting. No ELM libraries compiled.");
            return 3;
        }

        if (args.cs is not null)
            elmToolkit
                .SaveCSharpFilesToDirectory(
                    args.cs,
                    DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.g.cs"));

        if (args.dll is not null)
            elmToolkit
                .ConvertElmToAssemblies() // This is a no-op if the ElmToolkit has already compiled the ELM to assemblies
                .SaveAssemblyBinariesToDirectory(args.dll, DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.dll"));

        var packagingToolkit = new PackagingToolkit(loggerFactory)
            .AddPackagingInputsFromCqlAndElmToolkits(cqlToolkit, elmToolkit);
        if (packagingToolkit.Conversions.Count == 0)
        {
            logger.LogInformation("Exiting. No CQL or ELM libraries matched with each other for packaging.");
            return 4;
        }

        Mutator<JsonSerializerOptions>? configureJsonSerializerOptions = null;
        if (packOpt.JsonPretty)
            configureJsonSerializerOptions = options =>
            {
                options.WriteIndented = true;
                return options;
            };

        packagingToolkit
            .AddPackagingInputsFromCqlAndElmToolkits(cqlToolkit, elmToolkit)
            .ConvertToFhirResources(packOpt.CanonicalRootUrl, packOpt.OverrideDate)
            .SaveFhirResourcesToDirectory(
                args.fhir,
                DirectoryPreparationStrategy.CreateFileDeletionDirectoryHandler("*.json"),
                configureJsonSerializerOptions);

        return 0;
    }
}