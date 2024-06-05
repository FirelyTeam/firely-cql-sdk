using Hl7.Cql.Abstractions.Infrastructure;
using System.Reflection;

namespace Measures.Authoring;

internal class Program
{
    static void Main(string[] args)
    {
        var projectDirectory = new DirectoryInfo(Directory.GetCurrentDirectory()).FindParentDirectoryContaining("*.csproj")
        ?? throw new DirectoryNotFoundException("Cannot find the parent directory containing the project file.");

        string[] newArgs = {
            "--a", $"{Assembly.GetExecutingAssembly().Location}",
             //"--r", $"{Path.Combine(projectDirectory.FullName,"Resources")}",
            "--d", $"{Path.Combine(projectDirectory.FullName,"input","tests")}",
            "--v", $"{Path.Combine(projectDirectory.FullName,"input","vocabulary","ValueSet")}",
            "--o", $"{Path.Combine(projectDirectory.FullName,"input","tests","results")}",
            "--t", "Text",
        };
        string[] allArgs = new string[args.Length + newArgs.Length];
        args.CopyTo(allArgs, 0);
        newArgs.CopyTo(allArgs, args.Length);

        CLI.Program.Main(allArgs);

    }
}
