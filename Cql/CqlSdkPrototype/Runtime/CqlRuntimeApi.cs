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
    #region State

    private State _state;

    public CqlRuntimeApiOptions Options => _state.Options;

    private readonly record struct State(
        CqlRuntimeApiOptions Options,
        ImmutableHashSet<AssemblyData>? AssemblyData = null)
    {
        public ILogger<CqlRuntimeApi> Logger { get; } = Options.ServiceProvider.GetLogger<CqlRuntimeApi>();
        public ImmutableHashSet<AssemblyData> AssemblyData { get; init; } = AssemblyData ?? [];
    }

    #endregion

    #region Construction

    public static CqlRuntimeApi Create(
        CqlRuntimeApiOptions options)
    {
        var state = new State(options, ImmutableHashSet<AssemblyData>.Empty);
        state.Logger.LogInformation("Creating LibrarySetInvoker");
        var librarySetInvoker = new CqlRuntimeApi(state);
        return librarySetInvoker;
    }

    private CqlRuntimeApi(
        State state)
    {
        _state = state;
    }

    private CqlRuntimeApi WithAssemblyData(
        ImmutableHashSet<AssemblyData>? assemblyData = null)
    {
        _state = _state with
        {
            AssemblyData = assemblyData ?? _state.AssemblyData
        };
        return this;
        //return new CqlRuntimeApi(state);
    }

    #endregion

    #region Input (AssemblyData's)

    internal CqlRuntimeApi AddAssemblies(IEnumerable<AssemblyData> assemblyData)
    {
        var assembliesBuilder = _state.AssemblyData.ToBuilder();
        var oldCount = assembliesBuilder.Count;
        assembliesBuilder.AddRange(assemblyData);
        return oldCount == assembliesBuilder.Count
                   ? this
                   : WithAssemblyData(assemblyData: assembliesBuilder.ToImmutable());
    }

    #endregion

    #region Output (InvocationScope)

    public CqlInvocationScope CreateInvocationScope()
    {
        var alc = new AssemblyLoadContext("", true);
        foreach (var (assembly, debugSymbols) in _state.AssemblyData)
            alc.LoadFromBytes(assembly, debugSymbols);
        return new CqlInvocationScope(this, alc);
    }

    #endregion
}