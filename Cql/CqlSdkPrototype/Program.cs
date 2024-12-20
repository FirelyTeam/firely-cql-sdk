using CqlSdkPrototype.ElmToAssembly;
using Hl7.Cql.Runtime.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace CqlSdkPrototype;

internal class Program
{
    static void Main(string[] args)
    {
        // Dictionary<string, string?> inMemoryConfiguration = new()
        // {
        //     ["ElmCompilationCreateOptions:ShouldThrowError"] = "true"
        // };
        //
        // var configuration = new ConfigurationBuilder()
        //                     .AddInMemoryCollection(inMemoryConfiguration)
        //                     .Build();
        //
        var serviceProvider = new ServiceCollection()
            // .AddSingleton<IConfiguration>(configuration)
            .AddLogging(lb => lb
                              .ClearProviders()
                              .AddSimpleConsole(o => o.SingleLine = true)
                              .AddFilter((string? category, LogLevel l) =>
                              {
                                  return false;
                              })
                              )
            // .ConfigureOptions<ElmCompilationCreateOptions>()
            //  .Configure<ElmCompilationCreateOptions>(configuration)
            //  .AddOptions<ElmCompilationCreateOptions>(
            //      b =>
            //      {
            //          //
            //      })
            .BuildServiceProvider();

        var enumerationOptions = new EnumerationOptions()
        {
            /*RecurseSubdirectories = false*/
        };

        var rootDir = new DirectoryInfo(@"C:\Dev");
        var librarySetName = "CMS";

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

        // var cqlTranslation =
        //     CqlTranslation.Create()
        //                   .LoadCqlFilesFromDirectory(cqlDirIn, enumerationOptions)
        //                   .Translate()
        //                   .SaveElmFileToDirectory(elmDirOut)
        //                   ;

        var loggerProvider = serviceProvider.GetRequiredService<IEnumerable<ILoggerProvider>>().Single();
        var elmCompilation =
                ElmCompilation.Create(
                                  ElmCompilationCreateOptions.Default with {
                                      LoggerProvider = loggerProvider,
                                      ShouldThrowError = e =>
                                      {
                                          Console.WriteLine($"Ignoring error during '{e.Method}' for '{e.Identifier}' with error type: {e.Exception.GetType().FullName}");
                                          return false;
                                      }
                                  })
                              // .LoadCqlTranslation(cqlTranslation)
                              // .Compile()
                              // .LoadElmFile(elmDirIn, ElmLibraryIdentifier.Parse("FHIRHelpers")) //
                              // // Check errors?
                              // .Compile()
                              // // Check errors?
                              .LoadElmFilesFromDirectory(elmDirIn, enumerationOptions)
                              .Compile()
                              // .LoadElmFilesFromDirectory(elmDir, enumerationOptions)
                              // // Check errors?
                              // Check errors?
                              .SaveCSharpFilesToDirectory(cSharpDirOut)
                              .SaveAssemblyBinariesToDirectory(assemblyDirOut)
            ;

        //         var libraryIdentifier = cqlTranslation.VersionedIdentifiers.Values.First()!;
        //         Console.WriteLine(
        //             $"""
        //              First 50 C# lines for {libraryIdentifier}:
        //              {cqlTranslation.ElmJsonStrings[libraryIdentifier].TakeLines(50)}
        //              """);

        var libraryIdentifier = elmCompilation.CSharpSourceCodes.Keys.First()!;
        Console.WriteLine(
            $"""
             First 50 C# lines for {libraryIdentifier}:
             {elmCompilation.CSharpSourceCodes[libraryIdentifier].TakeLines(50)}
             """);
    }
}