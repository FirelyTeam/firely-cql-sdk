using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Cql.Extensibility;
using CqlSdkPrototype.Elm;
using CqlSdkPrototype.Elm.Extensibility;
using CqlSdkPrototype.Internal;
using CqlSdkPrototype.Logging;
using CqlSdkPrototype.Runtime;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Fhir;
using Hl7.Cql.Model;
using Hl7.Cql.Runtime.Hosting;
using static Hl7.Cql.Abstractions.Exceptions.ProcessBatchItemExceptionHandling;

namespace CqlSdkPrototype.App;

internal class Program
{
    static void Main(string[] args)
    {
        // CONSIDERATIONS:
        // - Encapsulate the creation of the service provider
        // - Move any options such as the AssembliesDebugMode and Models to the Cql- or ElmApi instead of via the hosted IOptions<T>
        // - Should we keep the dependency on Microsoft's ILogger or should we create our own logging abstraction?

        using var serviceProvider =
            new ServiceCollection()
                .AddLogging(lb => lb
                  .ClearProviders()
                  .AddProvider(new ColorConsoleLoggerProvider())
                  .AddFilter((category, _) => category?.Contains(value: nameof(CqlSdkPrototype)) ?? false))
                .BuildServiceProvider();

        var loggingOptions = new LoggingOptions(
            LoggerFactory: serviceProvider.GetRequiredService<ILoggerFactory>()
            // LoggerProviders: [new ColorConsoleLoggerProvider()],
            // LogFilter: logFilterArgs => logFilterArgs.Category?.Contains(value: nameof(CqlSdkPrototype)) ?? false
        );

        var cqlApiOptions = new CqlApiOptions(
            LoggingOptions: loggingOptions,
            Models: [Models.ElmR1, Models.Fhir401]);

        var cqlApi = new CqlApi(cqlApiOptions);

        var logger = serviceProvider.GetLogger<Program>();

        //InvokeCqlExample(logger: logger, cqlApi: cqlApi);

        // InvokeCqlFromExamplesFolder(logger: logger, cqlApi: cqlApi);

        foreach (var librarySetName in (string[]) ["Authoring", "CMS", "Demo"])
            VerboseExample(logger: logger, cqlApi: cqlApi, librarySetName: librarySetName);

        // VerboseExample(logger, cqlApi, "CMS");
    }

    private static void InvokeCqlFromExamplesFolder(
        ILogger<Program> logger,
        CqlApi cqlApi)
    {
        // INTRO:
        // This example demonstrates how to load CQL libraries from a directory and invoke a library declarations directly.

        // "Directories" is not a part of the API, but a helper class for this example
        var dirs = Directories.Create("Examples");

        // We can write extensions to make it even easier to change exception handling
        /*cqlApi = */
        cqlApi.WithOptions(o => o with
              {
                  ProcessBatchItemExceptionHandling = IgnoreExceptionAndContinue
              })
              .AddCqlLibrariesFromDirectory(dirs.CqlInDirectory);

        var cqlContext = FhirCqlContext.ForBundle();

        // We need a disposable invocation scope, which contains the AssemblyLoadContext and the related library Assemblies.
        using var invocationScope = cqlApi.CreateRuntimeScope();
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

    private static void InvokeCqlExample(
        ILogger<Program> logger,
        CqlApi cqlApi)
    {
        // INTRO:
        // This example demonstrates how to add a CqlLibraryString to the CqlApi and invoke a library declaration directly.

        // NICE TO HAVE: Would be nice to parse the CqlLibraryString only from the CQL and extract the identifier from the CQL
        var libraryIdentifier = CqlVersionedLibraryIdentifier.Parse("AdditionLib-0.0.0");
        var cqlLibraryString = CqlLibraryString.FromIdentifierAndString(
            libraryIdentifier,
            """
            library AdditionLib version '0.0.0'

            define private Three: 1 + 2
            """);
        var cqlContext = FhirCqlContext.ForBundle();
        using var invocationScope = cqlApi
                                    .AddCqlLibraryString(cqlLibraryString)
                                    .Translate()
                                    .CreateElmApi()
                                    .WithOptions(o => o with { AssemblyCompilerDebugInformationFormat = AssemblyCompilerDebugInformationFormat.Embedded })
                                    .Compile()
                                    .CreateRuntimeApi()
                                    .CreateRuntimeScope();
        var result = invocationScope.GetLibraryDefinitionResult(cqlContext, libraryIdentifier, "Three");
        Debug.Assert(result is 3);
    }

    private static void VerboseExample(
        ILogger<Program> logger,
        CqlApi cqlApi,
        string librarySetName)
    {
        // INTRO:
        // This example loads the CQL libraries, translates them to ELM, and compiles them to assemblies.
        // Each intermediate format is saved to directory (e.g. ELM, C#, and assembly binaries with their debug symbols).
        // It also demonstrates how to execute a library.

        Directories dirs = Directories.Create(librarySetName);
        dirs.GeneratedDirectory.Delete(recursive: true);
        // /*cqlApi = */
        // cqlApi
        //     .WithOptions(o => o with
        //     {
        //         ProcessBatchItemExceptionHandling = IgnoreExceptionAndContinue
        //     })
        //     .AddCqlLibrariesFromDirectory(
        //         dirs.CqlInDirectory /*,
        //                      options: new EnumerationOptions()
        //                      {
        //                          //RecurseSubdirectories = false
        //                      }*/ /*,
        //                      filePredicate: fi => fi.Name.TrimFileExtension(".cql") is
        //                          "FHIRHelpers"
        //                          or "NCQATerminology"
        //                          or "NCQAStatus"*/
        //     )
        //     .Translate()
        //     .SaveElmFileToDirectory(dirs.ElmOutDirectory)
        //     ;

        var elmApi = cqlApi.CreateElmApi()
                           .WithOptions(o => o with
                           {
                               ProcessBatchItemExceptionHandling = IgnoreExceptionAndContinue,
                               AssemblyCompilerDebugInformationFormat = AssemblyCompilerDebugInformationFormat.Embedded
                           })
                           .AddElmFilesFromDirectory(dirs.ElmInDirectory)

                           // var elmApi = cqlApi
                           //              .CreateElmApi()
                           //              .AddElmFromCqlApi(cqlApi)
                           //              //.LoadElmFile(elmDirIn, ElmLibraryIdentifier.Parse("FHIRHelpers")) //
                           //              //.LoadElmFilesFromDirectory(elmDirIn, enumerationOptions)
                           .Compile()
                           .SaveCSharpFilesToDirectory(dirs.CSharpOutDirectory)
                           .SaveAssemblyBinariesToDirectory(dirs.AssembliesOutDirectory)
            ;

        cqlApi.TryGetFirstElmFileLines()
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
    public static Maybe<(CqlVersionedLibraryIdentifier id, string cSharpSourceCode)>
        TryGetFirstCSharpFileLines<TElmApi>(
            this TElmApi elmApi)
        where TElmApi : IElmApiExtensible<TElmApi>
    {
        return elmApi.Entries
                     .TryGetFirst(kv => kv.Value.CSharpSourceCode is not null)
                     .TryReturn(kv => (kv.Key, kv.Value.CSharpSourceCode!));
    }

    public static Maybe<(CqlVersionedLibraryIdentifier id, string elmJson)> TryGetFirstElmFileLines<TCqlApi>(
        this TCqlApi cqlApi)
        where TCqlApi : ICqlApiExtensible<TCqlApi>
    {
        return cqlApi.Entries
                     .TryGetFirst(kv => kv.Value.ElmLibrary is not null)
                     .TryReturn(kv => (kv.Key, kv.Value.ElmLibrary!.SerializeToJson()!));
    }
}