using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

partial class Program
{
    void LoadElmFromDirSaveCSharpAndDllToDir()
    {
        Environment.CurrentDirectory = Path.Combine(InitialCurrentDirectory, "220 Load ELM from dir, Save C#,DLL to dir");

        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
        var elmToolkit = new ElmToolkit(loggerFactory);

        // Add CQL libraries from a directory
        var elmDirectory = new DirectoryInfo("input/elm");
        elmToolkit.AddElmFilesFromDirectory(elmDirectory);

        // Compile to Assemblies
        elmToolkit.CompileToAssemblies();

        // Save compiled assemblies and C# files
        elmToolkit.SaveCSharpFilesToDirectory(new DirectoryInfo("output/cs"));
        elmToolkit.SaveAssemblyBinariesToDirectory(new DirectoryInfo("output/dll"));

        // Open Explorer to the output directory
        _ = Process.Start("explorer.exe", "output");
    }
}
