using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;

namespace CqlSdkUseCases;

public class ElmToCSharpSdk
{
    private readonly LibrarySetExpressionBuilder _librarySetExpressionBuilder;
    private readonly CSharpLibrarySetToStreamsWriter _cSharpLibrarySetToStreamsWriter;
    private readonly LibrarySet _librarySet;

    internal ElmToCSharpSdk(
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
                case CSharpSourceCodeStep.OnStream onStream:
                    yield return (_librarySet.GetLibrary(onStream.Name, true)!, onStream.Stream);
                    break;
                case CSharpSourceCodeStep.OnDone _:
                    break;
            }
        }

        await processTask;
    }

}