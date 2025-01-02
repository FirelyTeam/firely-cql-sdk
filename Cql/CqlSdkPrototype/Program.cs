using System.Runtime.CompilerServices;
using System.Runtime.Loader;
using CqlSdkPrototype.CqlToElm;
using CqlSdkPrototype.ElmToAssembly;
using CqlSdkPrototype.Internal;
using CqlSdkPrototype.Logging;
using CqlSdkPrototype.Runtime;
using Hl7.Cql.Runtime.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

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
        LibrarySetInvoker.Run(serviceProvider, cqlTranslation, elmCompilation);
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
                              .AddElmCompilation()
                              .AddCqlTranslation()
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

        var id2 = elmCompiler.CSharpSourceCodes.Keys.First()!;
        logger.LogInformation(
            $"""
             First 50 C# lines for {id2}:
             {elmCompiler.CSharpSourceCodes[id2].TakeLines(50)}
             """);
    }
}