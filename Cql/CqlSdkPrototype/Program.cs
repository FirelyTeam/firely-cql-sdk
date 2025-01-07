using System.Diagnostics;
using CqlSdkPrototype.CqlToElm;
using CqlSdkPrototype.ElmToAssembly;
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
        //Example1();
        SuperSimpleExpressionInvokeExample();
    }

    private static void SuperSimpleExpressionInvokeExample()
    {
        // Arrange
        var serviceProvider = BuildServiceProvider(
            configureElmCompilationOptions: opt => opt.AssembliesDebugMode = true,
            configureCqlTranslationOptions: opt => opt.Models = [Models.ElmR1, Models.Fhir401]);
        var cqlApiOptions = CqlApiOptions.Create(serviceProvider);
        var cqlApi = CqlApi.Create(cqlApiOptions);
        var libraryIdentifier = CqlVersionedLibraryIdentifier.Parse("AdditionLib-0.0.0");
        var cqlLibraryString = CqlLibraryString.FromIdentifierAndString(
            libraryIdentifier,
            """
            library AdditionLib version '0.0.0'

            define private Three: 1 + 2
            """);

        // Act
        var result = cqlApi
                     .AddCqlLibraryString(cqlLibraryString)
                     .CompileAssemblies()
                     .InvokeLibraryDeclaration(libraryIdentifier, "Three", FhirCqlContext.ForBundle());

        // Assert
        Debug.Assert(result is 3);
    }

    private static void Example1()
    {
        var librarySetName = "Authoring";
        Directories dirs = new(librarySetName);
        dirs.GeneratedDirectory.Delete(recursive: true);
        var serviceProvider = BuildServiceProvider(
            configureElmCompilationOptions: opt => opt.AssembliesDebugMode = true,
            configureCqlTranslationOptions: opt => opt.Models = [Models.ElmR1, Models.Fhir401]);
        var cqlApiOptions = CqlApiOptions.Create(serviceProvider, ProcessBatchItemExceptionHandling.IgnoreExceptionAndContinue);
        var cqlApi =
                CqlApi.Create(cqlApiOptions)
                             .AddCqlLibrariesFromDirectory(
                                 dirs.CqlInDirectory/*,
                                 options: new EnumerationOptions()
                                 {
                                     //RecurseSubdirectories = false
                                 }*//*,
                                 filePredicate: fi => fi.Name.TrimFileExtension(".cql") is
                                     "FHIRHelpers"
                                     or "NCQATerminology"
                                     or "NCQAStatus"*/
                             )
                             .ConvertToElm()
            //.SaveElmFileToDirectory(dirs.ElmOutDirectory)
            ;

        ElmApiOptions elmApiOptions = ElmApiOptions.Create(cqlApiOptions);
        var elmApi =
                ElmApi.Create(elmApiOptions)
                           .LoadElmFromCqlApi(cqlApi)
                           //.LoadElmFile(elmDirIn, ElmLibraryIdentifier.Parse("FHIRHelpers")) //
                           //.LoadElmFilesFromDirectory(elmDirIn, enumerationOptions)
                           .CompileAssemblies()
                           .SaveCSharpFilesToDirectory(dirs.CSharpOutDirectory)
                           .SaveAssemblyBinariesToDirectory(dirs.AssembliesOutDirectory)
            ;

        // FhirJsonPocoDeserializer fhirJsonPocoDeserializer = null!;
        DumpOutputFilesToConsole(serviceProvider, cqlApi, elmApi);
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
    //         // StringBuilder sb = new();
    //         // sb.AppendLine("Libraries and Declarations:");
    //         // foreach (var (libId, lib) in librarySetInvoker.LibraryInvokers)
    //         // {
    //         //     sb.AppendLine(Invariant($"- {libId}"));
    //         //     foreach (var (declId, decl) in lib.Declarations)
    //         //         sb.AppendLine(Invariant($"  - {declId} : {decl.ReturnType.ToCSharpString(TypeCSharpFormat.Default with {UseKeywords = true})}"));
    //         // }
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
                                                .AddProvider(new CustomConsoleLoggerProvider(cat => cat.Split('.').Last()))
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

    private static void DumpOutputFilesToConsole(
        ServiceProvider serviceProvider,
        CqlApi cqlApi,
        ElmApi elmApi)
    {
        var logger = serviceProvider.GetLogger<Program>();
        var id1 = cqlApi.GetElmJsonStrings().Keys.First()!;
        logger.LogInformation(
            $"""
             First 50 C# lines for {id1}:
             {cqlApi.GetElmJsonStrings()[id1].TakeLines(50)}
             """);

        var id2 = elmApi.GetCSharpSourceCodes().Keys.First()!;
        logger.LogInformation(
            $"""
             First 50 C# lines for {id2}:
             {elmApi.GetCSharpSourceCodes()[id2].TakeLines(50)}
             """);
    }
}