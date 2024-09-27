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
services.AddScoped<ElmToCSharpFactory>();
services.AddScoped<CSharpToBinaryFactory>();
await using var sp = services.BuildServiceProvider(true);
using var spScope = sp.CreateScope();
var elmToCSharpFactory = spScope.ServiceProvider.GetRequiredService<ElmToCSharpFactory>();
var cSharpToBinaryFactory = spScope.ServiceProvider.GetRequiredService<CSharpToBinaryFactory>();
csharpDir.Create();
dllDir.Create();
ElmToCSharp elmToCSharp = elmToCSharpFactory.ForLibrarySet(librarySet);
CSharpToBinary cSharpToBinary = cSharpToBinaryFactory.ForLibrarySet(librarySet);
await foreach (var (library, csharpCodeStream) in elmToCSharp.GenerateCSharp(CancellationToken.None))
{
    var libraryVersionedIdentifier = library.GetVersionedIdentifier();

    Console.WriteLine($"Library: {libraryVersionedIdentifier}");
    await using var fileWriter = File.OpenWrite(Path.Combine(csharpDir.FullName, $"{libraryVersionedIdentifier}.g.cs"));
    csharpCodeStream.CopyTo(fileWriter);

    var assemblyStream = cSharpToBinary.CompileToAssembly(library, csharpCodeStream);
    await using var dllWriter = File.OpenWrite(Path.Combine(dllDir.FullName, $"{libraryVersionedIdentifier}.dll"));
    assemblyStream.CopyTo(dllWriter);
}


Console.WriteLine("Goodbye");



public class CSharpToBinary
{
    private readonly AssemblyCompiler _assemblyCompiler;
    private readonly Dictionary<string, AssemblyData> _results;

    internal CSharpToBinary(
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


internal class CSharpToBinaryFactory(
    AssemblyCompiler assemblyCompiler)
{
    public CSharpToBinary ForLibrarySet(LibrarySet librarySet) =>
        new CSharpToBinary(assemblyCompiler, librarySet);
}

public class ElmToCSharp
{
    private readonly LibrarySetExpressionBuilder _librarySetExpressionBuilder;
    private readonly CSharpLibrarySetToStreamsWriter _cSharpLibrarySetToStreamsWriter;
    private readonly LibrarySet _librarySet;

    internal ElmToCSharp(
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

internal class ElmToCSharpFactory(
    LibrarySetExpressionBuilder librarySetExpressionBuilder,
    CSharpLibrarySetToStreamsWriter cSharpLibrarySetToStreamsWriter)
{
    public ElmToCSharp ForLibrarySet(LibrarySet librarySet) =>
        new ElmToCSharp(librarySetExpressionBuilder, cSharpLibrarySetToStreamsWriter, librarySet);
}