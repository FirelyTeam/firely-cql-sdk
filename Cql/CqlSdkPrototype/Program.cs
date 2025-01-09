using System;
using System.Diagnostics;
using System.Text;
using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Cql.Extensibility;
using CqlSdkPrototype.Elm;
using CqlSdkPrototype.Elm.Extensibility;
using CqlSdkPrototype.Internal;
using CqlSdkPrototype.Logging;
using CqlSdkPrototype.Runtime;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Model;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Cql.Runtime.Hosting;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype;

internal class Program
{
    static void Main(string[] args)
    {
        // CONSIDERATIONS:
        // - Encapsulate the creation of the service provider
        // - Move any options such as the AssembliesDebugMode and Models to the Cql- or ElmApi instead of via the hosted IOptions<T>
        // - Should we keep the dependency on Microsoft's ILogger or should we create our own logging abstraction?
        var serviceProvider = BuildServiceProvider(
            configureElmCompilationOptions: opt => opt.AssembliesDebugMode = true,
            configureCqlTranslationOptions: opt => opt.Models = [Models.ElmR1, Models.Fhir401]);
        var logger = serviceProvider.GetLogger<Program>();
        var cqlApi = CqlApi.Create(serviceProvider);

        InvokeCqlFromExamplesFolder(logger, cqlApi);
        InvokeCqlExample(logger, cqlApi);
        foreach (var librarySetName in (string[])["Authoring", "CMS", "Demo"])
            VerboseExample(logger, cqlApi, librarySetName);
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
        cqlApi = cqlApi.WithOptions(o => o with
                       {
                           ProcessBatchItemExceptionHandling =
                           ProcessBatchItemExceptionHandling.IgnoreExceptionAndContinue
                       })
                       .AddCqlLibrariesFromDirectory(dirs.CqlInDirectory);

        var cqlContext = FhirCqlContext.ForBundle();

        // We need a disposable invokation scope, which contains the AssemblyLoadContext and the related library Assemblies.
        using var invokationScope = cqlApi.CreateInvokationScope();
        logger.LogInformation("{dump}", invokationScope.DumpLibraryDeclarations());
        Debug.Assert(Invoke("CqlAggregateFunctionsTest-1.0.000", "Count.CountTestTime") is 3);
        Debug.Assert(Invoke("CqlAggregateFunctionsTest-1.0.000", "Count.CountTestNull") is 0);
        Debug.Assert(Invoke("CqlStringOperatorsTest-1.0.000", "Combine.CombineABCSepDash") is "a-b-c");

        object? Invoke(string libraryName, string declarationName)
        {
            var libraryIdentifier = CqlVersionedLibraryIdentifier.Parse(libraryName);
            var result = invokationScope.InvokeLibraryDeclaration(libraryIdentifier, declarationName, cqlContext);
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
        using var invokationScope = cqlApi.AddCqlLibraryString(cqlLibraryString).CreateInvokationScope();
        var result = invokationScope.InvokeLibraryDeclaration(libraryIdentifier, "Three", cqlContext);
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
        cqlApi = cqlApi
                 .WithOptions(o => o with
                 {
                     ProcessBatchItemExceptionHandling = ProcessBatchItemExceptionHandling.IgnoreExceptionAndContinue
                 })
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
                 .ConvertToElm()
                 .SaveElmFileToDirectory(dirs.ElmOutDirectory)
                 ;

        var elmApi = cqlApi
                     .CreateElmApi()
                     .LoadElmFromCqlApi(cqlApi)
                     //.LoadElmFile(elmDirIn, ElmLibraryIdentifier.Parse("FHIRHelpers")) //
                     //.LoadElmFilesFromDirectory(elmDirIn, enumerationOptions)
                     .CompileAssemblies()
                     .SaveCSharpFilesToDirectory(dirs.CSharpOutDirectory)
                     .SaveAssemblyBinariesToDirectory(dirs.AssembliesOutDirectory)
            ;

        DumpFirstElmAndCSharp(cqlApi, elmApi, logger);
        // ExecuteLibrary(serviceProvider, dirs, cqlApi, elmApi, fhirJsonPocoDeserializer);
    }

    // private static void ExecuteLibrary(
    //     ServiceProvider serviceProvider,
    //     Directories dirs,
    //     CqlApi cqlTranslation,
    //     ElmApi elmCompilation,
    //     FhirJsonPocoDeserializer fhirJsonPocoDeserializer)
    // {
    //     var logger = serviceProvider.GetLogger<Program>();
    //     if (CqlRuntimeApi.Create(
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

    private static ServiceProvider BuildServiceProvider(
        Action<ElmCompilationOptions>? configureElmCompilationOptions = null,
        Action<CqlTranslationOptions>? configureCqlTranslationOptions = null)
    {
        // Dictionary<string, string?> inMemoryConfiguration = new()
        // {
        //     //["ElmCompilationCreateOptions:ShouldThrowError"] = "true"
        // };

        // var configuration = new ConfigurationBuilder()
        //                     .AddInMemoryCollection(inMemoryConfiguration)
        //                     .Build();

        var serviceProvider = new ServiceCollection()
                              // .AddSingleton<IConfiguration>(configuration)
                              .AddLogging(lb => lb
                                                .ClearProviders()
                                                .AddProvider(
                                                    new CustomConsoleLoggerProvider(cat => cat.Split('.').Last()))
                                                .AddFilter((string? category, LogLevel logLevel) =>
                                                {
                                                    var result = category?.Contains(nameof(CqlSdkPrototype)) ?? false;
                                                    return result;
                                                })
                              )
                              .AddElmApi(configureElmCompilationOptions)
                              .AddCqlApi(configureCqlTranslationOptions)
                              .BuildServiceProvider();
        return serviceProvider;
    }

    private static void DumpFirstElmAndCSharp<TCqlApi, TElmApi>(
        TCqlApi cqlApi,
        TElmApi elmApi,
        ILogger<Program> logger)
        where TCqlApi : ICqlApiExtensible<TCqlApi>
        where TElmApi : IElmApiExtensible<TElmApi>
    {
        if (cqlApi.Entries.TryFirst(kv => kv.Value.ElmLibrary is not null)
            is {HasValue:true, Value:{Key:{} id1, Value.ElmLibrary:{} lib}})
        {
            logger.LogInformation(
                $"""
                 First 50 C# lines for {id1}:
                 {lib.SerializeToJson().TakeLines(50)}
                 """);
        }

        if (elmApi.Entries.TryFirst(kv => kv.Value.CSharpSourceCode is not null)
            is { HasValue: true, Value: { Key:{} id2, Value.CSharpSourceCode:{} csharp } })
        {
            logger.LogInformation(
                $"""
                 First 50 C# lines for {id2}:
                 {csharp.TakeLines(50)}
                 """);
        }
    }
}