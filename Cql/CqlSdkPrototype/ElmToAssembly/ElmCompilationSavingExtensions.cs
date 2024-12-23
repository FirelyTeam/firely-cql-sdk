using CqlSdkPrototype.Advanced;
using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype.ElmToAssembly;

public static class ElmCompilationSavingExtensions
{

    public static ElmCompiler SaveCSharpFilesToDirectory(
        this ElmCompiler elmCompiler,
        DirectoryInfo directory)
    {
        if (!directory.Exists)
            directory.Create();

        var logger = ((ILogAccessor<ElmCompiler>)elmCompiler).Logger;
        foreach (var (libraryName, sourceCode) in elmCompiler.CSharpSourceCodes)
        {
            var fileName = Path.Combine(directory.FullName, $"{libraryName}.cs");
            File.WriteAllText(fileName, sourceCode);
            logger.LogInformation("Saved C# source code to file: {file}", fileName);
        }

        return elmCompiler;
    }

    public static ElmCompiler SaveAssemblyBinariesToDirectory(
        this ElmCompiler elmCompiler,
        DirectoryInfo directory)
    {
        if (!directory.Exists)
            directory.Create();

        var logger = ((ILogAccessor<ElmCompiler>)elmCompiler).Logger;
        foreach (var (libraryName, assemblyBinary) in elmCompiler.AssemblyBinaries)
        {
            var fileName = Path.Combine(directory.FullName, $"{libraryName}.dll");
            File.WriteAllBytes(fileName, assemblyBinary);
            logger.LogInformation("Saved assembly binary to file: {file}", fileName);
        }

        return elmCompiler;
    }

}