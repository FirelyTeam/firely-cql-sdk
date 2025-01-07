using System.Text;
using CqlSdkPrototype.CqlToElm;
using CqlSdkPrototype.ElmToAssembly;
using CqlSdkPrototype.Internal;
using CqlSdkPrototype.Logging;
using CqlSdkPrototype.Runtime;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Abstractions.Infrastructure;
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
using static System.FormattableString;

namespace CqlSdkPrototype;

internal class Program
{
    static void Main(string[] args)
    {
        var librarySetName = "Authoring";
        Directories dirs = new(librarySetName);
        dirs.GeneratedDirectory.Delete(recursive: true);
        var serviceProvider = BuildServiceProvider();

        var cqlTranslation =
                CqlTranslator.Create(
                                 serviceProvider,
                                 CqlTranslationCreateOptions.Default with
                                 {
                                     ProcessBatchItemExceptionHandling = ProcessBatchItemExceptionHandling.IgnoreExceptionAndContinue,
                                 })
                             .LoadCqlFilesFromDirectory(
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
                             .Translate()
                             .SaveElmFileToDirectory(dirs.ElmOutDirectory)
            ;

        var elmCompilation =
                ElmCompiler.Create(
                                  serviceProvider,
                                  ElmCompilationCreateOptions.Default with
                                  {
                                      ProcessBatchItemExceptionHandling = ProcessBatchItemExceptionHandling.IgnoreExceptionAndContinue,
                                  })
                              .LoadCqlTranslation(cqlTranslation)
                              //.LoadElmFile(elmDirIn, ElmLibraryIdentifier.Parse("FHIRHelpers")) //
                              //.LoadElmFilesFromDirectory(elmDirIn, enumerationOptions)
                              .Compile()
                              .SaveCSharpFilesToDirectory(dirs.CSharpOutDirectory)
                              .SaveAssemblyBinariesToDirectory(dirs.AssembliesOutDirectory)
            ;

        FhirJsonPocoDeserializer fhirJsonPocoDeserializer = null!;
        DumpOutputFilesToConsole(serviceProvider, cqlTranslation, elmCompilation);
        ExecuteLibrary(serviceProvider, dirs, cqlTranslation, elmCompilation, fhirJsonPocoDeserializer);
    }

    private static void ExecuteLibrary(
        ServiceProvider serviceProvider,
        Directories dirs,
        CqlTranslator cqlTranslation,
        ElmCompiler elmCompilation,
        FhirJsonPocoDeserializer fhirJsonPocoDeserializer)
    {
        var logger = serviceProvider.GetLogger<Program>();
        if (LibrarySetInvoker.TryCreate(
                out var librarySetInvoker,
                cqlTranslation,
                elmCompilation,
                logger))
        {
            StringBuilder sb = new();
            sb.AppendLine("Libraries and Declarations:");
            foreach (var (libId, lib) in librarySetInvoker.LibraryInvokers)
            {
                sb.AppendLine(Invariant($"- {libId}"));
                foreach (var (declId, decl) in lib.Declarations)
                    sb.AppendLine(Invariant($"  - {declId} : {decl.ReturnType.ToCSharpString(TypeCSharpFormat.Default with {UseKeywords = true})}"));
            }
            logger.LogInformation("{msg}", sb.ToString());

            if (dirs.ValueSetsInDirectory is null)
            {
                logger.LogWarning("No value sets directory found. Skipping execution.");
                return;
            }

            /*dirs.ValueSetsInDirectory.EnumerateFiles("*.json", SearchOption.AllDirectories)
                .Select(fi =>
                {
                    using var stream = fi.OpenRead();
                    var reader = new Utf8JsonReader();
                    return fhirJsonPocoDeserializer.DeserializeObject<ValueSet>(reader);
                });*/

            Bundle? bundle = new Bundle(){};
            Dictionary<string, object>? parameters = new()
            {
                ["Measurement Period"] = new CqlInterval<CqlDate>(
                    low: new CqlDate(2023, 1, 1),
                    high: new CqlDate(2023, 12, 31),
                    lowClosed: true,
                    highClosed: true)
            };

            IValueSetDictionary? valueSets = null;
            FhirCqlContextOptions? options = null;
            CqlContext cqlContext = FhirCqlContext
                                    //.WithDataSource(source, parameters, valueSets, options: options);
                                    .ForBundle(bundle, parameters, valueSets, options:options);
            var devDays = librarySetInvoker.LibraryInvokers[CqlVersionedLibraryIdentifier.Parse("ParametersExample-0.0.1")];
            var patientDeclaration = devDays.Declarations["Patient"];
            var patient = patientDeclaration.Invoke(cqlContext);
        }
    }

    private static ServiceProvider BuildServiceProvider()
    {
        Dictionary<string, string?> inMemoryConfiguration = new()
        {
            //["ElmCompilationCreateOptions:ShouldThrowError"] = "true"
        };

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
                              .AddElmCompilation(
                                  opt =>
                                  {
                                      opt.AssembliesDebugMode = true;
                                  })
                              .AddCqlTranslation(
                                  opt =>
                                  {
                                      opt.Models = [Models.ElmR1, Models.Fhir401];
                                  })
                              .BuildServiceProvider();
        return serviceProvider;
    }

    private static void DumpOutputFilesToConsole(
        ServiceProvider serviceProvider,
        CqlTranslator cqlTranslator,
        ElmCompiler elmCompiler)
    {
        var logger = serviceProvider.GetLogger<Program>();
        var id1 = cqlTranslator.ElmJsonStrings.Keys.First()!;
        logger.LogInformation(
            $"""
             First 50 C# lines for {id1}:
             {cqlTranslator.ElmJsonStrings[id1].TakeLines(50)}
             """);

        var id2 = elmCompiler.GetCSharpSourceCodes().Keys.First()!;
        logger.LogInformation(
            $"""
             First 50 C# lines for {id2}:
             {elmCompiler.GetCSharpSourceCodes()[id2].TakeLines(50)}
             """);
    }
}