namespace CqlSdkPrototype;

public static class Directories
{
    public static DirectoryInfo GeneratedDirectory { get; } = new(Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..", "Generated")));
    public static DirectoryInfo CSharpOutDirectory { get; } = GeneratedDirectory.CreateSubdirectory("CSharp");
    public static DirectoryInfo AssembliesOutDirectory { get; } = GeneratedDirectory.CreateSubdirectory("Assemblies");
}