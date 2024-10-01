using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;

namespace CqlSdkUseCases;

public class CSharpToBinarySdk
{
    private readonly AssemblyCompiler _assemblyCompiler;
    private readonly Dictionary<string, AssemblyData> _results;

    internal CSharpToBinarySdk(
        AssemblyCompiler assemblyCompiler,
        LibrarySet librarySet)
    {
        _assemblyCompiler = assemblyCompiler;
        _results = new Dictionary<string, AssemblyData>();
        LibrarySet = librarySet;
    }

    public LibrarySet LibrarySet { get; }

    public Stream CompileToAssembly(Library library, Stream csharpStream)
    {
        var assemblyData = _assemblyCompiler.CompileNode(csharpStream, _results, LibrarySet, library);
        _results.Add(library.GetVersionedIdentifier()!, assemblyData);
        return new MemoryStream(assemblyData.Binary);
    }
}