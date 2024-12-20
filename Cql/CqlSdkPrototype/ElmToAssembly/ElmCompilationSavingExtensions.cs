using CqlSdkPrototype.Advanced;
using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype.ElmToAssembly;

public static class ElmCompilationSavingExtensions
{

    public static ElmCompilation SaveCSharpFilesToDirectory(
        this ElmCompilation elmCompilation,
        DirectoryInfo directory)
    {
        if (!directory.Exists)
            directory.Create();

        var logger = ((ILogAccessor<ElmCompilation>)elmCompilation).Logger;
        foreach (var (libraryName, sourceCode) in elmCompilation.CSharpSourceCodes)
        {
            var fileName = Path.Combine(directory.FullName, $"{libraryName}.cs");
            File.WriteAllText(fileName, sourceCode);
            logger.LogInformation("Saved C# source code to file: {file}", fileName);
        }

        return elmCompilation;
    }

    public static ElmCompilation SaveAssemblyBinariesToDirectory(
        this ElmCompilation elmCompilation,
        DirectoryInfo directory)
    {
        if (!directory.Exists)
            directory.Create();

        var logger = ((ILogAccessor<ElmCompilation>)elmCompilation).Logger;
        foreach (var (libraryName, assemblyBinary) in elmCompilation.AssemblyBinaries)
        {
            var fileName = Path.Combine(directory.FullName, $"{libraryName}.dll");
            File.WriteAllBytes(fileName, assemblyBinary);
            logger.LogInformation("Saved assembly binary to file: {file}", fileName);
        }

        return elmCompilation;
    }

}