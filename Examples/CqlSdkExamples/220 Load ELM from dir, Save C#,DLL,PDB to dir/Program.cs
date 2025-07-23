/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Diagnostics;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Microsoft.Extensions.Logging;

namespace CqlSdkExamples;

partial class Program
{
    void LoadElmFromDirSaveCSharpDllAndPdbToDir()
    {
        SetCurrentDirectory(Path.Combine(InitialCurrentDirectory, "220 Load ELM from dir, Save C#,DLL,PDB to dir"));

        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
        var elmToolkitConfig = new ElmToolkitConfig(DebugSymbolsFormat.PortablePdb);
        var elmToolkit = new ElmToolkit(loggerFactory, elmToolkitConfig);

        // Add CQL libraries from a directory
        var elmDirectory = new DirectoryInfo("input/elm");
        elmToolkit.AddElmFilesFromDirectory(elmDirectory);

        // Compile to Assemblies
        elmToolkit.CompileToAssemblies();

        // Save compiled assemblies and C# files
        elmToolkit.SaveCSharpFilesToDirectory(new DirectoryInfo("output/cs"));
        elmToolkit.SaveAssemblyBinariesToDirectory(new DirectoryInfo("output/dll"), new DirectoryInfo("output/pdb"));

        // Open Explorer to the output directory
        _ = Process.Start("explorer.exe", "output");
    }
}
