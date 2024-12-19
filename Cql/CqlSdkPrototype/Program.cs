using Hl7.Cql.CqlToElm;
using Hl7.Cql.Elm;

namespace CqlSdkPrototype;

internal class Program
{
    static void Main(string[] args)
    {
        var enumerationOptions = new EnumerationOptions()
        {
            /*RecurseSubdirectories = false*/
        };

        var rootDir = new DirectoryInfo(@"C:\Dev");

        // Keep these output dirs outside the repo:
        var cqlDir = rootDir.CreateSubdirectory(@"firely-cql-sdk\LibrarySets\Demo\Cql"); // Input
        var elmDirOut = rootDir.CreateSubdirectory(@"prototype-output\Elm");             // Output
        var elmDir = elmDirOut;                                                          // Input
        //var elmDir = rootDir.CreateSubdirectory(@"firely-cql-sdk\LibrarySets\Demo\Elm");           // Input
        var csharpDir = rootDir.CreateSubdirectory(@"prototype-output\CSharp");          // Output
        var dllDir = rootDir.CreateSubdirectory(@"prototype-output\Dlls");               // Output
        var fhirDir = rootDir.CreateSubdirectory(@"prototype-output\Fhir");              // Output
        ElmLibraryIdentifier first;

        var cqlTranslation =
            CqlTranslation.Create()
                          .LoadCqlFilesFromDirectory(cqlDir, enumerationOptions)
                          .Translate()
                          .SaveElmFileToDirectory(elmDirOut)
                          ;

        first = cqlTranslation.VersionedIdentifiers.Keys.First()!;
        Console.WriteLine(
            $"""
             First 50 C# lines for {first}:
             {cqlTranslation.ElmJsonStrings[first]
                            .SplitLines()
                            .Take(50)
                            .JoinLines()}
             """);

        csharpDir.Delete(recursive: true);
        dllDir.Delete(recursive: true);

        var elmCompilation =
                ElmCompilation.Create()
                              .LoadCqlTranslation(cqlTranslation)
                              //.LoadElmFilesFromDirectory(elmDir, enumerationOptions)
                              //.LoadElmFile(elmDir, ElmLibraryIdentifier.Parse("FHIRHelpers"))
                              // .Compile()
                              // .LoadElmFilesFromDirectory(elmDir, enumerationOptions)
                              .Compile()
                              .SaveCSharpFilesToDirectory(csharpDir)
                              .SaveAssemblyBinariesToDirectory(dllDir)
            ;

        first = elmCompilation.VersionedIdentifiers.Keys.First()!;
        Console.WriteLine(
            $"""
             First 50 C# lines for {first}:
             {
                 elmCompilation.CSharpSourceCodes[first]
                               .SplitLines()
                               .Take(50)
                               .JoinLines()}
             """);

        fhirDir.Delete(recursive: true);
    }
}