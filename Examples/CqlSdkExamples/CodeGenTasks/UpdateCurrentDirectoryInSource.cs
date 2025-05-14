using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System;
using System.IO;
// using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
// using System.Threading.Tasks;

public class UpdateCurrentDirectoryInSourceTask : Task
{
    public override bool Execute()
    {

        // Find project directory
        DirectoryInfo currentDir = new DirectoryInfo(Environment.CurrentDirectory);
        DirectoryInfo projectDir = currentDir;
        while (projectDir != null)
        {
            bool isInProjectDir = projectDir.EnumerateFiles("*.csproj", SearchOption.TopDirectoryOnly).Any();
            if (isInProjectDir)
                break;

            projectDir = projectDir.Parent;
        }

        if (projectDir == null)
        {
            Log.LogMessage(MessageImportance.High, "Project directory not found.");
            return false;
        }

        // Find all the Program.cs files in the project directory
        var programCsFiles =
            projectDir
                .EnumerateFiles("Program.cs", SearchOption.AllDirectories)
                .Where(fi => fi.Directory.FullName != projectDir.FullName)
                .ToArray();
        if (programCsFiles.Length == 0)
        {
            Log.LogMessage(MessageImportance.High, "No Program.cs files found in the project directory.");
            return false;
        }

        // Update the "Environment.CurrentDirectory = " with the directory name
        foreach (var programCsFile in programCsFiles)
        {
            var cs = File.ReadAllText(programCsFile.FullName);
            var dir = programCsFile.Directory.Name;
            var csNew = Regex.Replace(
                cs,
                "Environment.CurrentDirectory\\s*=.*?;",
                "Environment.CurrentDirectory = Path.Combine(InitialCurrentDirectory, \"" + dir + "\");");
            if (cs != csNew)
            {
                File.WriteAllText(programCsFile.FullName, csNew);
                Log.LogMessage(MessageImportance.High, "Updated CurrentDirectory in " + programCsFile.FullName);
            }
        }

        return true;

    }
}