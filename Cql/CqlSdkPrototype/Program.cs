using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Cql.Extensions;
using CqlSdkPrototype.Elm;
using CqlSdkPrototype.Elm.Extensions;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Internal;
using CqlSdkPrototype.Invocation.Extensions;
using CqlSdkPrototype.Logging;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime.Hosting;
using static Hl7.Cql.Abstractions.Exceptions.ProcessBatchItemExceptionHandling;

namespace CqlSdkPrototype;

internal class Program
{
    static void Main(string[] args)
    {
        using var serviceProvider =
            new ServiceCollection()
                .AddLogging(lb => lb
                                  .ClearProviders()
                                  .AddProvider(new ColorConsoleLoggerProvider())
                                  .AddFilter((category, _) => category?.Contains(value: nameof(CqlSdkPrototype)) ?? false))
                .BuildServiceProvider();

        var loggerFactory = serviceProvider.GetRequiredService<ILoggerFactory>();
        var settings = new CqlToElmProcessorSettings(Models: [CqlModel.ElmR1, CqlModel.Fhir401]);
        var cqlFluentToolkit = new CqlFluentToolkit(loggerFactory, settings);
        var logger = serviceProvider.GetLogger<Program>();

        //InvokeCqlExample(cqlApi: cqlApi);

        //InvokeCqlFromExamplesFolder(logger: logger, cqlApi: cqlApi);
        //
        foreach (var librarySetName in (string[]) ["CMS"])//"Authoring", "CMS", "Demo", "Examples"])
            VerboseExample(logger: logger, cqlToolkit: cqlFluentToolkit, librarySetName: librarySetName, shouldBuildCqlToElm:false);

        // VerboseExample(logger, cqlApi, "CMS");
    }

    private static void InvokeCqlFromExamplesFolder(
        ILogger<Program> logger,
        CqlFluentToolkit cqlToolkit)
    {
        // INTRO:
        // This example demonstrates how to load CQL libraries from a directory and invoke a library declarations directly.

        // "Directories" is not a part of the API, but a helper class for this example
        var dirs = Directories.Create("Examples");

        // We can write extensions to make it even easier to change exception handling
        var cqlContext = FhirCqlContext.ForBundle();

        // We need a disposable invocation scope, which contains the AssemblyLoadContext and the related library Assemblies.
        using var invocationScope = cqlToolkit
                                    .ReplaceSettings(o => o with { ProcessBatchItemExceptionHandling = IgnoreExceptionAndContinue })
                                    .AddCqlLibrariesFromDirectory(dirs.CqlInDirectory)
                                    .CreateRuntimeScope();
        logger.LogInformation("{dump}", invocationScope.DumpLibraryDeclarations());
        Debug.Assert(Invoke("CqlAggregateFunctionsTest-1.0.000", "Count.CountTestTime") is 3);
        Debug.Assert(Invoke("CqlAggregateFunctionsTest-1.0.000", "Count.CountTestNull") is 0);
        Debug.Assert(Invoke("CqlStringOperatorsTest-1.0.000", "Combine.CombineABCSepDash") is "a-b-c");

        object? Invoke(string libraryName, string declarationName)
        {
            var libraryIdentifier = CqlVersionedLibraryIdentifier.Parse(libraryName);
            var result = invocationScope.GetLibraryDefinitionResult(cqlContext, libraryIdentifier, declarationName);
            return result;
        }
    }

    private static void InvokeCqlExample(CqlFluentToolkit cqlToolkit)
    {
        // INTRO:
        // This example demonstrates how to add a CqlLibraryString to the CqlApi and invoke a library declaration directly.

        // NICE TO HAVE: Would be nice to parse the CqlLibraryString only from the CQL and extract the identifier from the CQL
        var cqlLibraryString = CqlLibraryString.Parse(
            """
            library AdditionLib version '0.0.0'

            define private Three: 1 + 2
            """);
        var cqlContext = FhirCqlContext.ForBundle();
        using var invocationScope = cqlToolkit
                                    .AddCqlLibraryString(cqlLibraryString)
                                    .CreateRuntimeScope(elmOpt => elmOpt with { AssemblyCompilerDebugInformationFormat = AssemblyCompilerDebugInformationFormat.Embedded });
        var result = invocationScope.GetLibraryDefinitionResult(cqlContext, cqlLibraryString.VersionedLibraryIdentifier, "Three");
        Debug.Assert(result is 3);
    }

    private static void VerboseExample(
        ILogger<Program> logger,
        CqlFluentToolkit cqlToolkit,
        string librarySetName,
        bool shouldBuildCqlToElm = false)
    {
        // INTRO:
        // This example loads the CQL libraries, translates them to ELM, and compiles them to assemblies.
        // Each intermediate format is saved to directory (e.g. ELM, C#, and assembly binaries with their debug symbols).
        // It also demonstrates how to execute a library.

        Directories dirs = Directories.Create(librarySetName);
        dirs.GeneratedDirectory.Delete(recursive: true);

        cqlToolkit.ReplaceSettings(o => o with { ProcessBatchItemExceptionHandling = IgnoreExceptionAndContinue });

        if (shouldBuildCqlToElm)
        {
            cqlToolkit
                .AddCqlLibrariesFromDirectory(
                    dirs.CqlInDirectory /*,
                             options: new EnumerationOptions()
                             {
                                 //RecurseSubdirectories = false
                             }*/ /*,
                             filePredicate: fi => fi.Name.TrimFileExtension(".cql") is
                                 "FHIRHelpers"
                                 or "NCQATerminology"
                                 or "NCQAStatus"*/
                )
                .ProcessCqlToElm()
                .SaveElmFileToDirectory(dirs.ElmOutDirectory)
                ;
        }

        var elmApi = cqlToolkit.CreateElmApi(o => o with { AssemblyCompilerDebugInformationFormat = AssemblyCompilerDebugInformationFormat.Embedded })
                           .AddElmFilesFromDirectory(dirs.ElmInDirectory)
                           .ProcessElmToAssemblies()
                           .SaveCSharpFilesToDirectory(dirs.CSharpOutDirectory)
                           .SaveAssemblyBinariesToDirectory(dirs.AssembliesOutDirectory);

        cqlToolkit.TryGetFirstElmFileLines()
              .Switch(t => logger.LogInformation(
                          $"""
                           First 50 ELM lines for {t.id}:
                           {t.elmJson.TakeLines(50)}
                           """));

        elmApi.TryGetFirstCSharpFileLines()
              .Switch(t => logger.LogInformation(
                          $"""
                           First 50 C# lines for {t.id}:
                           {t.cSharpSourceCode.TakeLines(50)}
                           """));
    }

    // private static void ExecuteLibrary(
    //     ServiceProvider serviceProvider,
    //     Directories dirs,
    //     CqlApi cqlTranslation,
    //     ElmApi elmCompilation,
    //     FhirJsonPocoDeserializer fhirJsonPocoDeserializer)
    // {
    //     var logger = serviceProvider.GetLogger<Program>();
    //     if (RuntimeApi.Create(
    //             out var librarySetInvoker))
    //     {
    //         // logger.LogInformation("{msg}", sb.ToString());
    //         //
    //         // if (dirs.ValueSetsInDirectory is null)
    //         // {
    //         //     logger.LogWarning("No value sets directory found. Skipping execution.");
    //         //     return;
    //         // }
    //
    //         /*dirs.ValueSetsInDirectory.EnumerateFiles("*.json", SearchOption.AllDirectories)
    //             .Select(fi =>
    //             {
    //                 using var stream = fi.OpenRead();
    //                 var reader = new Utf8JsonReader();
    //                 return fhirJsonPocoDeserializer.DeserializeObject<ValueSet>(reader);
    //             });*/
    //
    //         Bundle? bundle = new Bundle(){};
    //         Dictionary<string, object>? parameters = new()
    //         {
    //             ["Measurement Period"] = new CqlInterval<CqlDate>(
    //                 low: new CqlDate(2023, 1, 1),
    //                 high: new CqlDate(2023, 12, 31),
    //                 lowClosed: true,
    //                 highClosed: true)
    //         };
    //
    //         IValueSetDictionary? valueSets = null;
    //         FhirCqlContextOptions? options = null;
    //         CqlContext cqlContext = FhirCqlContext
    //                                 //.WithDataSource(source, parameters, valueSets, options: options);
    //                                 .ForBundle(bundle, parameters, valueSets, options:options);
    //         var parametersExample = librarySetInvoker.LibraryInvokers[CqlVersionedLibraryIdentifier.Parse("ParametersExample-0.0.1")];
    //         var patientDeclaration = parametersExample.Declarations["Patient"];
    //         var patient = patientDeclaration.Invoke(cqlContext);
    //     }
    // }
}

file static class X
{
    public static Maybe<(CqlVersionedLibraryIdentifier id, string cSharpSourceCode)> TryGetFirstCSharpFileLines(this ElmFluentToolkit elmApi) =>
        elmApi.ElmToAssemblyConversions
              .TryGetFirst(kv => kv.Value.CSharpSourceCode is not null)
              .TryReturn(kv => (kv.Key, kv.Value.CSharpSourceCode!));

    public static Maybe<(CqlVersionedLibraryIdentifier id, string elmJson)> TryGetFirstElmFileLines(
        this CqlFluentToolkit cqlApi) =>
        cqlApi.CqlToElmConversions
              .TryGetFirst(kv => kv.Value.ElmLibrary is not null)
              .TryReturn(kv => (kv.Key, kv.Value.ElmLibrary!.SerializeToJson()!));
}