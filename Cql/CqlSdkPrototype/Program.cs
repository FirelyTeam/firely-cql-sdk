using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.Loader;
using System.Text;
using CqlSdkPrototype.CqlToElm;
using CqlSdkPrototype.ElmToAssembly;
using CqlSdkPrototype.Internal;
using CqlSdkPrototype.Logging;
using CqlSdkPrototype.Runtime;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CodeGeneration.NET;
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
        var serviceProvider = BuildServiceProvider();

        var rootDir = new DirectoryInfo(@"C:\Dev");
        var librarySetName = "Demo";

        // Keep these output dirs outside the repo:
        var cqlDirIn = rootDir.CreateSubdirectory($@"firely-cql-sdk\LibrarySets\{librarySetName}\Cql"); // Input
        var elmDirOut = rootDir.CreateSubdirectory(@"prototype-output\Elm");                            // Output
        var elmDirIn = rootDir.CreateSubdirectory($@"firely-cql-sdk\LibrarySets\{librarySetName}\Elm"); // Input
        var cSharpDirOut = rootDir.CreateSubdirectory(@"prototype-output\CSharp");                      // Output
        var assemblyDirOut = rootDir.CreateSubdirectory(@"prototype-output\Dlls");                      // Output
        var fhirResourceDirOut = rootDir.CreateSubdirectory(@"prototype-output\Fhir");                  // Output

        cSharpDirOut.Delete(recursive: true);
        assemblyDirOut.Delete(recursive: true);
        fhirResourceDirOut.Delete(recursive: true);

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
                                 cqlDirIn,
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
                             .SaveElmFileToDirectory(elmDirOut)
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
                              .SaveCSharpFilesToDirectory(cSharpDirOut)
                              .SaveAssemblyBinariesToDirectory(assemblyDirOut)
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
        //Directories.GeneratedDirectory.Delete(true);

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
                                      opt.CSharpOutDirectory = Directories.CSharpOutDirectory;
                                      opt.AssembliesDebugMode = true;
                                      opt.AssembliesOutDirectory = Directories.AssembliesOutDirectory;
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