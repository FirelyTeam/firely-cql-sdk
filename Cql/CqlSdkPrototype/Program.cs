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
        var cqlDirIn = rootDir.CreateSubdirectory(@"firely-cql-sdk\LibrarySets\Demo\Cql"); // Input
        var elmDirOut = rootDir.CreateSubdirectory(@"prototype-output\Elm");               // Output
        var elmDirIn = elmDirOut;                                                          // Input
        //var elmDirIn = rootDir.CreateSubdirectory(@"firely-cql-sdk\LibrarySets\Demo\Elm");   // Input
        var cSharpDirOut = rootDir.CreateSubdirectory(@"prototype-output\CSharp");         // Output
        var assemblyDirOut = rootDir.CreateSubdirectory(@"prototype-output\Dlls");         // Output
        var fhirResourceDirOut = rootDir.CreateSubdirectory(@"prototype-output\Fhir");     // Output

        cSharpDirOut.Delete(recursive: true);
        assemblyDirOut.Delete(recursive: true);
        fhirResourceDirOut.Delete(recursive: true);

        var cqlTranslation =
            CqlTranslation.Create()
                          .LoadCqlFilesFromDirectory(cqlDirIn, enumerationOptions)
                          .Translate()
                          .SaveElmFileToDirectory(elmDirOut)
                          ;

        var elmCompilation =
                ElmCompilation.Create()
                              .LoadCqlTranslation(cqlTranslation)
                              //.LoadElmFilesFromDirectory(elmDir, enumerationOptions)
                              //.LoadElmFile(elmDir, ElmLibraryIdentifier.Parse("FHIRHelpers"))
                              // .Compile()
                              // .LoadElmFilesFromDirectory(elmDir, enumerationOptions)
                              .Compile()
                              .SaveCSharpFilesToDirectory(cSharpDirOut)
                              .SaveAssemblyBinariesToDirectory(assemblyDirOut)
            ;

        var libraryIdentifier = cqlTranslation.VersionedIdentifiers.Values.First()!;
        Console.WriteLine(
            $"""
             First 50 C# lines for {libraryIdentifier}:
             {cqlTranslation.ElmJsonStrings[libraryIdentifier].TakeLines(50)}
             """);

        Console.WriteLine(
            $"""
             First 50 C# lines for {libraryIdentifier}:
             {elmCompilation.CSharpSourceCodes[libraryIdentifier].TakeLines(50)}
             """);
    }
}