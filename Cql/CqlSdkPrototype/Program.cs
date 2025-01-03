using System.Text;
using CqlSdkPrototype.CqlToElm;
using CqlSdkPrototype.ElmToAssembly;
using CqlSdkPrototype.Internal;
using CqlSdkPrototype.Logging;
using CqlSdkPrototype.Runtime;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Fhir;
using Hl7.Cql.Model;
using Hl7.Cql.Runtime;
using Hl7.Cql.Runtime.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using static System.FormattableString;

namespace CqlSdkPrototype;

internal class Program
{
    static void Main(string[] args)
    {
        Directories.GeneratedDirectory.Delete(recursive: true);
        var serviceProvider = BuildServiceProvider();
        var librarySetName = "Demo";

        var cqlTranslation =
                CqlTranslator.Create(
                                 serviceProvider,
                                 CqlTranslationCreateOptions.Default with
                                 {
                                     ShouldThrowError = e =>
                                     {
                                         e.Logger.LogWarning(
                                             e.Exception,
                                             "Ignoring error during {method} for {id}",
                                             e.Method,
                                             e.Identifier);
                                         return false;
                                     }
                                 })
                             .LoadCqlFilesFromDirectory(
                                 Directories.CqlInDirectory(librarySetName),
                                 options: new EnumerationOptions()
                                 {
                                     /*RecurseSubdirectories = false*/
                                 }/*,
                                 filePredicate: fi => fi.Name.TrimFileExtension(".cql") is
                                     "FHIRHelpers"
                                     or "NCQATerminology"
                                     or "NCQAStatus"*/
                                 )
                             .Translate()
                             .SaveElmFileToDirectory(Directories.ElmOutDirectory)
            ;

        var elmCompilation =
                ElmCompiler.Create(
                                  serviceProvider,
                                  ElmCompilationCreateOptions.Default with
                                  {
                                      ShouldThrowError = e =>
                                      {
                                          e.Logger.LogWarning(
                                              e.Exception,
                                              "Ignoring error during {method} for {id}",
                                              e.Method,
                                              e.Identifier);
                                          return false;
                                      }
                                  })
                              .LoadCqlTranslation(cqlTranslation)
                              //.LoadElmFile(elmDirIn, ElmLibraryIdentifier.Parse("FHIRHelpers")) //
                              //.LoadElmFilesFromDirectory(elmDirIn, enumerationOptions)
                              .Compile()
                              .SaveCSharpFilesToDirectory(Directories.CSharpOutDirectory)
                              .SaveAssemblyBinariesToDirectory(Directories.AssembliesOutDirectory)
            ;

        DumpOutputFilesToConsole(serviceProvider, cqlTranslation, elmCompilation);
        ExecuteLibrary(serviceProvider, cqlTranslation, elmCompilation);
    }

    private static void ExecuteLibrary(
        ServiceProvider serviceProvider,
        CqlTranslator cqlTranslation,
        ElmCompiler elmCompilation)
    {
        var logger = serviceProvider.GetLogger<Program>();
        if (LibrarySetInvoker.TryCreate(out var librarySetInvoker, cqlTranslation, elmCompilation, logger))
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

            CqlContext cqlContext = FhirCqlContext.ForBundle();
            var devDays = librarySetInvoker.LibraryInvokers[CqlVersionedLibraryIdentifier.Parse("DevDays-2023.0.0")];
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

        var configuration = new ConfigurationBuilder()
                            .AddInMemoryCollection(inMemoryConfiguration)
                            .Build();

        var serviceProvider = new ServiceCollection()
                              .AddSingleton<IConfiguration>(configuration)
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