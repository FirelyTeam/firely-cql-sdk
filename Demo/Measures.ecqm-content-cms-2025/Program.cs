/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;
using System.Reflection;

namespace Measures.CMS;

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
