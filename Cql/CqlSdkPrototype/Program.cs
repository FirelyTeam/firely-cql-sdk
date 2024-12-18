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
        var cqlDir = rootDir.CreateSubdirectory(@"firely-cql-sdk\LibrarySets\Demo\Cql"); // Input
        var elmDir = rootDir.CreateSubdirectory(@"firely-cql-sdk\LibrarySets\Demo\Elm"); // Output/Input

        // Keep these output dirs outside the repo:
        var csharpDir = rootDir.CreateSubdirectory(@"prototype-output\CSharp"); // Output
        var dllDir = rootDir.CreateSubdirectory(@"prototype-output\Dlls");      // Output
        var fhirDir = rootDir.CreateSubdirectory(@"prototype-output\Fhir");     // Output

        var cqlTranslation =
            CqlTranslation.New
                          .LoadCqlFilesFromDirectory(cqlDir, enumerationOptions)
                          .Translate()
                          .SaveElmFileToDirectory(elmDir);

        Console.WriteLine(
            $"""
             First 50 C# lines for {cqlTranslation.VersionedIdentifiers[ElmLibraryIdentifier.Parse("FHIRHelpers")]}:
             {cqlTranslation.ElmJsonStrings[ElmLibraryIdentifier.Parse("FHIRHelpers")]
                            .SplitLines()
                            .Take(50)
                            .JoinLines()}
             """);

        csharpDir.Delete(recursive: true);
        dllDir.Delete(recursive: true);

        var elmCompilation =
                ElmCompilation.New
                              .LoadElmFile(elmDir, ElmLibraryIdentifier.Parse("FHIRHelpers"))
                              .Compile()
                              .LoadElmFilesFromDirectory(elmDir, enumerationOptions)
                              .Compile()
                              .SaveCSharpFilesToDirectory(csharpDir)
                              .SaveAssemblyBinariesToDirectory(dllDir)
            ;

        Console.WriteLine(
            $"""
             First 50 C# lines for {elmCompilation.VersionedIdentifiersByIdentifier[ElmLibraryIdentifier.Parse("FHIRHelpers")]}:
             {
                 elmCompilation.SourceCodeByVersionedIdentifier[ElmLibraryIdentifier.Parse("FHIRHelpers")]
                               .SplitLines()
                               .Take(50)
                               .JoinLines()}
             """);

        fhirDir.Delete(recursive: true);
    }
}

file static class Extensions
{
    public static string[] SplitLines(this string multilineString) =>
        multilineString.Split([Environment.NewLine], StringSplitOptions.None);

    public static string JoinLines(this IEnumerable<string> lines) =>
        string.Join(Environment.NewLine, lines);
}