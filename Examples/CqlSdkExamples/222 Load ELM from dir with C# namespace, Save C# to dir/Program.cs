/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Diagnostics;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Microsoft.Extensions.Logging;

namespace CqlSdkExamples;

partial class Program
{
    void LoadElmFromDirWithCSharpNamespaceSaveCSharpToDir()
    {
        SetCurrentDirectory(Path.Combine(InitialCurrentDirectory, "222 Load ELM from dir with C# namespace, Save C# to dir"));

        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
        var elmToolkitConfig = new ElmToolkitConfig(CSharpNamespace: "MyCompany.MyCqlLibraries");
        var elmToolkit = new ElmToolkit(loggerFactory, elmToolkitConfig);

        // Add ELM libraries from a directory
        var elmDirectory = new DirectoryInfo("input/elm");
        elmToolkit.AddElmFilesFromDirectory(elmDirectory);

        // Compile to Assemblies (this generates C# code internally)
        elmToolkit.CompileToAssemblies();

        // Save C# files with the specified namespace
        elmToolkit.SaveCSharpFilesToDirectory(new DirectoryInfo("output/cs"));

        // Open Explorer to the output directory
        _ = Process.Start("explorer.exe", "output");
    }
}
