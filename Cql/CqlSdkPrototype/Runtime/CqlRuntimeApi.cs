using System.Collections.Immutable;
using System.Runtime.Loader;
using CqlSdkPrototype.Internal;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Runtime.Hosting;
using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype.Runtime;

public class CqlRuntimeApi
{
    private readonly State _state;

    public CqlRuntimeApiOptions Options => _state.Options;

    private CqlRuntimeApi(
        State state)
    {
        _state = state;
    }

    private CqlRuntimeApi Mutate(
        ImmutableHashSet<AssemblyData>? assemblyData = null)
    {
        return new CqlRuntimeApi(_state with
        {
            AssemblyData = assemblyData ?? _state.AssemblyData
        });
    }

    private readonly record struct State(
        CqlRuntimeApiOptions Options,
        ImmutableHashSet<AssemblyData>? AssemblyData = null)
    {
        public ILogger<CqlRuntimeApi> Logger { get; } = Options.ServiceProvider.GetLogger<CqlRuntimeApi>();
        public ImmutableHashSet<AssemblyData> AssemblyData { get; init; } = AssemblyData ?? [];
    }

    internal CqlRuntimeApi AddAssemblies(IEnumerable<AssemblyData> assemblyData)
    {
        var assembliesBuilder = _state.AssemblyData.ToBuilder();
        var oldCount = assembliesBuilder.Count;
        assembliesBuilder.AddRange(assemblyData);
        return oldCount == assembliesBuilder.Count
                   ? this
                   : Mutate(assemblyData: assembliesBuilder.ToImmutable());
    }

    // public IReadOnlyDictionary<CqlVersionedLibraryIdentifier, LibraryInvoker> LibraryInvokers { get; }

    public static CqlRuntimeApi Create(
        CqlRuntimeApiOptions options)
    {
        var state = new State(options, ImmutableHashSet<AssemblyData>.Empty);
        state.Logger.LogInformation("Creating LibrarySetInvoker");
        var librarySetInvoker = new CqlRuntimeApi(state);
        return librarySetInvoker;
    }

    public CqlInvokationScope CreateInvokationScope()
    {
        var alc = new AssemblyLoadContext("", true);
        foreach (var (assembly, debugSymbols) in _state.AssemblyData)
            alc.LoadFromBytes(assembly, debugSymbols);
        return new CqlInvokationScope(this, alc);
    }
}

public class CqlInvokationScope : IDisposable
{
    private readonly CqlRuntimeApi _cqlRuntimeApi;
    private readonly AssemblyLoadContext _alc;

    public CqlInvokationScope(CqlRuntimeApi cqlRuntimeApi, AssemblyLoadContext alc)
    {
        _cqlRuntimeApi = cqlRuntimeApi;
        _alc = alc;
        LibraryInvokers =
            _alc.Assemblies
                .SelectMany(a => a.GetTypes())
                .SelectWhereNotNull(t =>
                {
                    LibraryInvoker.TryCreateFromType(_cqlRuntimeApi, t, out var libraryInvoker);
                    return libraryInvoker;
                })
                .ToImmutableDictionary(o => o.LibraryVersionedIdentifier);
    }

    public void Dispose()
    {
        _alc.Unload();
    }

    public IReadOnlyDictionary<CqlVersionedLibraryIdentifier, LibraryInvoker> LibraryInvokers { get; }
}