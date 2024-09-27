// See https://aka.ms/new-console-template for more information

using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using static Hl7.Cql.CodeGeneration.NET.CSharpSourceCodeStep;

// Load the ELM files from the directory
Console.WriteLine("Loading ELM into LibrarySet");
DirectoryInfo elmDir = new DirectoryInfo("C:\\Dev\\firely-cql-sdk\\LibrarySets\\Demo\\Elm");
DirectoryInfo csharpDir = new DirectoryInfo("CSharp");
DirectoryInfo dllDir = new DirectoryInfo("Dll");
LibrarySet librarySet = new LibrarySet("Example Library");
librarySet.LoadLibrariesFromDirectory(elmDir);

// ELM -> C#
Console.WriteLine("Generate LibrarySet to C#");
ServiceCollection services = new ServiceCollection();
services.AddLogging(lb => lb.ClearProviders());
services.AddCqlCodeGenerationServices();
services.AddScoped<ElmToCSharp>();
services.AddScoped<CSharpToBinary>();
await using var sp = services.BuildServiceProvider(true);
using var spScope = sp.CreateScope();
var cqlToCSharp = spScope.ServiceProvider.GetRequiredService<ElmToCSharp>();
var csharpToBinary = spScope.ServiceProvider.GetRequiredService<CSharpToBinary>();
csharpDir.Create();
dllDir.Create();
ElmToCSharpContext elmToCSharpContext = cqlToCSharp.ForLibrarySet(librarySet);
CSharpToBinaryContext librarySetCompileContext = csharpToBinary.ForLibrarySet(librarySet);
await foreach (var (library, csharpCodeStream) in elmToCSharpContext.GenerateCSharp(CancellationToken.None))
{
    Console.WriteLine($"Library: {library.GetVersionedIdentifier()}");
    await using var fileWriter = File.OpenWrite(Path.Combine(csharpDir.FullName, $"{library.identifier}.g.cs"));
    csharpCodeStream.CopyTo(fileWriter);

    var assemblyStream = librarySetCompileContext.CompileToAssembly(library, csharpCodeStream);
    await using var dllWriter = File.OpenWrite(Path.Combine(dllDir.FullName, $"{library.identifier}.dll"));
    assemblyStream.CopyTo(dllWriter);
}


Console.WriteLine("Goodbye");


public class CSharpToBinaryContext
{
    private readonly AssemblyCompiler _assemblyCompiler;
    private readonly Dictionary<string, AssemblyData> _results;

    internal CSharpToBinaryContext(
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


internal class CSharpToBinary(
    AssemblyCompiler assemblyCompiler)
{
    public CSharpToBinaryContext ForLibrarySet(LibrarySet librarySet) =>
        new CSharpToBinaryContext(assemblyCompiler, librarySet);
}

public class ElmToCSharpContext
{
    private readonly LibrarySetExpressionBuilder _librarySetExpressionBuilder;
    private readonly CSharpLibrarySetToStreamsWriter _cSharpLibrarySetToStreamsWriter;
    private readonly LibrarySet _librarySet;

    internal ElmToCSharpContext(
        LibrarySetExpressionBuilder librarySetExpressionBuilder,
        CSharpLibrarySetToStreamsWriter cSharpLibrarySetToStreamsWriter,
        LibrarySet librarySet)
    {
        _librarySetExpressionBuilder = librarySetExpressionBuilder;
        _cSharpLibrarySetToStreamsWriter = cSharpLibrarySetToStreamsWriter;
        _librarySet = librarySet;
    }

    public async IAsyncEnumerable<(Library library, Stream csharpCodeStream)> GenerateCSharp(CancellationToken ct)
    {
        ct.ThrowIfCancellationRequested();

        TaskCompletionSource<CSharpSourceCodeStep> tcs = new();
        Queue<Task<CSharpSourceCodeStep>> steps = new();
        steps.Enqueue(tcs.Task);

        var definitions = _librarySetExpressionBuilder.ProcessLibrarySet(_librarySet);
        var callbacks = new CSharpSourceCodeWriterCallbacks(
            libraryNameToClassName: null,
            shouldWriteLibrary: null,
            onAfterStep: OnAfterStep);
        var processTask = Task.Run(() => _cSharpLibrarySetToStreamsWriter.ProcessDefinitions(definitions, _librarySet, callbacks), ct);

        void OnAfterStep(CSharpSourceCodeStep step)
        {
            switch (step)
            {
                case CSharpSourceCodeStep.OnStream onStream:
                    TaskCompletionSource<CSharpSourceCodeStep> tcsNext = new();
                    steps.Enqueue(tcsNext.Task);
                    tcs.SetResult(onStream);
                    tcs = tcsNext;
                    break;
                case CSharpSourceCodeStep.OnDone onDone:
                    tcs.SetResult(onDone);
                    break;
            }
        }

        while (steps.TryDequeue(out var stepTask))
        {
            var step = await stepTask.WaitAsync(ct);
            switch (step)
            {
                case OnStream onStream:
                    yield return (_librarySet.GetLibrary(onStream.Name, true)!, onStream.Stream);
                    break;
                case OnDone _:
                    break;
            }
        }

        await processTask;
    }

}

internal class ElmToCSharp(
    LibrarySetExpressionBuilder librarySetExpressionBuilder,
    CSharpLibrarySetToStreamsWriter cSharpLibrarySetToStreamsWriter)
{
    public ElmToCSharpContext ForLibrarySet(LibrarySet librarySet) =>
        new ElmToCSharpContext(librarySetExpressionBuilder, cSharpLibrarySetToStreamsWriter, librarySet);
}