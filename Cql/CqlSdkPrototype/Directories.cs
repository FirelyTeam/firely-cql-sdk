namespace CqlSdkPrototype;

public class Directories(string librarySetName)
{
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
    public static DirectoryInfo SolutionDirectory { get; } = FindAncestor(CurrentDirectory, d => d.EnumerateFiles("*.sln?").Any());
    public static DirectoryInfo ThisProjectDirectory { get; } = FindAncestor(CurrentDirectory, d => d.EnumerateFiles("*.csproj").Any());
    public static DirectoryInfo AuthoringProjectDirectory => SolutionDirectory.CreateSubdirectory("Demo").CreateSubdirectory("Measures.Authoring");
    public static DirectoryInfo LibrarySetsDirectory { get; } = SolutionDirectory.CreateSubdirectory("LibrarySets");

    public string LibrarySetName { get; } = librarySetName;
    public DirectoryInfo GeneratedDirectory => ThisProjectDirectory.CreateSubdirectory("generated").CreateSubdirectory(LibrarySetName);
    public DirectoryInfo CqlInDirectory =>
        LibrarySetName switch
        {
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