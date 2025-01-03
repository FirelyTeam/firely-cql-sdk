namespace CqlSdkPrototype;

public static class Directories
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
    public static DirectoryInfo LibrarySetsDirectory { get; } = SolutionDirectory.CreateSubdirectory("LibrarySets");
    public static DirectoryInfo CqlInDirectory(string librarySetName) => LibrarySetsDirectory.CreateSubdirectory(librarySetName).CreateSubdirectory("Cql");
    public static DirectoryInfo ElmInDirectory(string librarySetName) => LibrarySetsDirectory.CreateSubdirectory(librarySetName).CreateSubdirectory("Elm");
    public static DirectoryInfo ProjectDirectory { get; } = FindAncestor(CurrentDirectory, d => d.EnumerateFiles("*.csproj").Any());
    public static DirectoryInfo GeneratedDirectory { get; } = ProjectDirectory.CreateSubdirectory("generated");
    public static DirectoryInfo ElmOutDirectory { get; } = GeneratedDirectory.CreateSubdirectory("Elm");
    public static DirectoryInfo CSharpOutDirectory { get; } = GeneratedDirectory.CreateSubdirectory("CSharp");
    public static DirectoryInfo AssembliesOutDirectory { get; } = GeneratedDirectory.CreateSubdirectory("Assemblies");
    public static DirectoryInfo FhirOutDirectory { get; } = GeneratedDirectory.CreateSubdirectory("Fhir");
}