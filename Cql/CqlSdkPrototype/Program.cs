using CqlSdkPrototype.CqlToElm;
using CqlSdkPrototype.ElmToAssembly;
using CqlSdkPrototype.Logging;
using Hl7.Cql.Runtime.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype;

internal class Program
{
    static void Main(string[] args)
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
                                                .AddProvider(
                                                    new CustomConsoleLoggerProvider(cat => cat.Split('.').Last()))
                                                .AddFilter((string? category, LogLevel l) =>
                                                {
                                                    var result = category?.Contains(nameof(CqlSdkPrototype)) ?? false;
                                                    return result;
                                                })
                              )
                              .AddElmCompilation()
                              .AddCqlTranslation()
                              .BuildServiceProvider();

        var enumerationOptions = new EnumerationOptions()
        {
            /*RecurseSubdirectories = false*/
        };

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
                CqlTranslation.Create(
                                  serviceProvider,
                                  CqlTranslationCreateOptions.Default with
                                  {
                                      ShouldThrowError = e =>
                                      {
                                          e.Logger.LogWarning(
                                              e.Exception,
                                              "Ignoring error during '{method}' for '{id}'",
                                              e.Method,
                                              e.Identifier);
                                          return false;
                                      }
                                  })
                              .LoadCqlFilesFromDirectory(cqlDirIn, enumerationOptions)
                              .Translate()
                              .SaveElmFileToDirectory(elmDirOut)
            ;

        var elmCompilation =
                ElmCompilation.Create(
                                  serviceProvider,
                                  ElmCompilationCreateOptions.Default with
                                  {
                                      ShouldThrowError = e =>
                                      {
                                          e.Logger.LogWarning(
                                              e.Exception,
                                              "Ignoring error during '{method}' for '{id}'",
                                              e.Method,
                                              e.Identifier);
                                          return false;
                                      }
                                  })
                              //.LoadCqlTranslation(cqlTranslation)
                              //.LoadElmFile(elmDirIn, ElmLibraryIdentifier.Parse("FHIRHelpers")) //
                              .LoadElmFilesFromDirectory(elmDirIn, enumerationOptions)
                              .Compile()
                              .SaveCSharpFilesToDirectory(cSharpDirOut)
                              .SaveAssemblyBinariesToDirectory(assemblyDirOut)
            ;

        //         var logger = serviceProvider.GetLogger<Program>();
        //         var id1 = cqlTranslation.ElmJsonStrings.Keys.First()!;
        //         logger.LogInformation(
        //             $"""
        //              First 50 C# lines for {id1}:
        //              {cqlTranslation.ElmJsonStrings[id1].TakeLines(50)}
        //              """);
        //
        //         var id2 = elmCompilation.CSharpSourceCodes.Keys.First()!;
        //         logger.LogInformation(
        //             $"""
        //              First 50 C# lines for {id2}:
        //              {elmCompilation.CSharpSourceCodes[id2].TakeLines(50)}
        //              """);
    }
}