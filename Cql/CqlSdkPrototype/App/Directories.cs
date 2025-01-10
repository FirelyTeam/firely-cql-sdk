using System.Diagnostics;

namespace CqlSdkPrototype.App;

internal class Directories(string librarySetName)
{
    public static Directories Create(string librarySetName)
    {
        Debug.Assert(
            librarySetName is
               "Demo"
            or "CMS"
            or "Authoring"
            or "Examples");
        return new Directories(librarySetName);
    }

    private static DirectoryInfo FindAncestor(DirectoryInfo start, Func<DirectoryInfo, bool> match)
    {
        DirectoryInfo? current = start;
        while (current != null)
        {
            if (match(current))
                return current;
            current = current.Parent;
        }

        throw new InvalidOperationException("Could not find ancestor directory from search criteria.");
    }

    public static DirectoryInfo CurrentDirectory { get; } = new(Directory.GetCurrentDirectory());
    public static DirectoryInfo CurrentSolutionDirectory { get; } = FindAncestor(CurrentDirectory, d => d.EnumerateFiles("*.sln?").Any());
    public static DirectoryInfo CurrentProjectDirectory { get; } = FindAncestor(CurrentDirectory, d => d.EnumerateFiles("*.csproj").Any());
    public static DirectoryInfo AuthoringProjectDirectory => CurrentSolutionDirectory.CreateSubdirectory("Demo").CreateSubdirectory("Measures.Authoring");
    public static DirectoryInfo LibrarySetsDirectory { get; } = CurrentSolutionDirectory.CreateSubdirectory("LibrarySets");

    public string LibrarySetName { get; } = librarySetName;
    public DirectoryInfo GeneratedDirectory => CurrentProjectDirectory.CreateSubdirectory("generated").CreateSubdirectory(LibrarySetName);
    public DirectoryInfo CqlInDirectory =>
        LibrarySetName switch
        {
            "Examples" => CurrentProjectDirectory.CreateSubdirectory("examples"),
            "Authoring" => AuthoringProjectDirectory.CreateSubdirectory("Input").CreateSubdirectory("cql"),
            _ => LibrarySetsDirectory.CreateSubdirectory(LibrarySetName).CreateSubdirectory("Cql")
        };

    //public static DirectoryInfo ElmInDirectory(string librarySetName) => LibrarySetsDirectory.CreateSubdirectory(LibrarySetName).CreateSubdirectory("Elm");
    public DirectoryInfo ElmOutDirectory => GeneratedDirectory.CreateSubdirectory("Elm");
    public DirectoryInfo CSharpOutDirectory => GeneratedDirectory.CreateSubdirectory("CSharp");
    public DirectoryInfo AssembliesOutDirectory => GeneratedDirectory.CreateSubdirectory("Assemblies");
    public DirectoryInfo FhirOutDirectory => GeneratedDirectory.CreateSubdirectory("Fhir");
    public DirectoryInfo? ValueSetsInDirectory =>
        LibrarySetName switch
        {
            "Authoring" => AuthoringProjectDirectory.CreateSubdirectory("Input").CreateSubdirectory("cql").CreateSubdirectory("vocabulary").CreateSubdirectory("valueset"),
            _ => null
        };
}