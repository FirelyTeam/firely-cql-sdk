using System.Reactive.Linq;
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

    public async IAsyncEnumerable<(Library library, Stream csharpCodeStream)> GenerateCSharpAsyncEnumerable(CancellationToken ct)
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

    public IObservable<(Library library, Stream csharpCodeStream)> GenerateCSharpObservable(
        CancellationToken ct) =>
        Observable.Create<(Library library, Stream csharpCodeStream)>(o =>
        {
            bool stopSignalled = false;

            // No way yet to stop processing with cancellationToken, but we can stop the observer from receiving more items.
            ct.Register(() => stopSignalled = true);

            var definitions = _librarySetExpressionBuilder.ProcessLibrarySet(_librarySet);
            var callbacks = new CSharpSourceCodeWriterCallbacks(
                libraryNameToClassName: null,
                shouldWriteLibrary: null,
                onAfterStep: step =>
                {
                    if (stopSignalled)
                        return;

                    if (step is CSharpSourceCodeStep.OnStream onStream)
                    {
                        var library = _librarySet.GetLibrary(onStream.Name, true);
                        o.OnNext((library: library!, csharpCodeStream: onStream.Stream));
                    }
                });

            try
            {
                _cSharpLibrarySetToStreamsWriter.ProcessDefinitions(definitions, _librarySet, callbacks);
                o.OnCompleted();
            }
            catch (Exception e)
            {
                o.OnError(e);
            }

            return () =>
            {
                // No way yet to stop processing when unsubscribing, but we can stop the observer from receiving more items.
                stopSignalled = true;
            };
        });
}

public delegate Task AsyncAction(CancellationToken ct);
public delegate Task AsyncAction<in TArg0>(TArg0 arg0, CancellationToken ct);
public delegate Task<TReturn> AsyncFunc<TReturn>(CancellationToken ct);

public record AsyncObserver<T>
{
    private static Task DefaultOnStarted(CancellationToken ct) => Task.CompletedTask;
    private static Task DefaultOnNext(T value, CancellationToken ct) => Task.CompletedTask;
    private static void DefaultOnDone(Exception? Error) { }

    public AsyncAction OnStarted { get; init; } = DefaultOnStarted;
    public AsyncAction<T> OnNext { get; init; } = DefaultOnNext;
    public Action<Exception?> OnDone { get; init; } = DefaultOnDone;
}

