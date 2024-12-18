namespace CqlSdkPrototype;

internal class Program
{
    static void Main(string[] args)
    {
        var rootDir = new DirectoryInfo(@"C:\Dev\firely-cql-sdk\LibrarySets\CMS");
        var elmDir = rootDir.CreateSubdirectory("Elm");
        var csharpDir = rootDir.CreateSubdirectory("CSharp2");
        var dllDir = rootDir.CreateSubdirectory("Dlls2");
        var fhirDir = rootDir.CreateSubdirectory("Fhir2");

        csharpDir.Delete(recursive: true);
        dllDir.Delete(recursive: true);

        var elmCompilation =
                ElmSdk
                    .NewCompilation()
                    .LoadElmFile(elmDir, ElmLibraryIdentifier.Parse("FHIRHelpers"))
                    .Compile()
                    .LoadElmFilesFromDirectory(elmDir, new EnumerationOptions() { RecurseSubdirectories = false })
                    .Compile()
                    .SaveCSharpFilesToDirectory(csharpDir)
                    .SaveAssemblyBinariesToDirectory(dllDir)
            ;

        //.LoadElmFile(new FileInfo(@"C:\Dev\firely-cql-sdk\LibrarySets\CMS\Elm\ALARACTOQRFHIR.json"))
        //.LoadElmFileWithDependencies(new DirectoryInfo(@"C:\Dev\firely-cql-sdk\LibrarySets\CMS\Elm"), ElmVersionedIdentifier.FromNameAndVersion("ALARACTOQRFHIR", "0.4.000"), new EnumerationOptions() { RecurseSubdirectories = false })

        Console.WriteLine(
            $"""
             First 50 C# lines for {elmCompilation.LibraryNames["FHIRHelpers"]}:
             {
                 string.Join(
                     Environment.NewLine,
                     elmCompilation.SourceCodeByLibraryName[ElmLibraryIdentifier.Parse("FHIRHelpers")]
                                   .Split([Environment.NewLine], StringSplitOptions.None)
                                   .Take(50))
             }
             """);

        fhirDir.Delete(recursive: true);
    }
}