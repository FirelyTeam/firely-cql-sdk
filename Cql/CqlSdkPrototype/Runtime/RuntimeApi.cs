using CqlSdkPrototype.Internal;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CodeGeneration.NET;
using CqlSdkPrototype.Runtime.Extensibility;

namespace CqlSdkPrototype.Runtime;

public class RuntimeApi(RuntimeApiOptions? options = null) : IRuntimeApiExtensible<RuntimeApi>
{
    internal IRuntimeApiExtensible<RuntimeApi> AsExtensible() => this;

    #region State

    private RuntimeApiState _state = RuntimeApiState.Create(options ?? RuntimeApiOptions.Default);

    RuntimeApiOptions IRuntimeApiExtensible<RuntimeApi>.Options => _state.Options;
    IReadOnlySet<RuntimeApiStateEntry> IRuntimeApiExtensible<RuntimeApi>.Entries => _state.Entries;

    #endregion

    #region Construction

    private RuntimeApi WithEntries(
        ImmutableHashSet<RuntimeApiStateEntry>? assemblyData = null)
    {
        _state = _state with
        {
            Entries = assemblyData ?? _state.Entries
        };
        return this;
    }

    public RuntimeApi WithOptions(
        Func<RuntimeApiOptions, RuntimeApiOptions> replaceOptions)
    {
        var newOptions = replaceOptions(_state.Options);
        if (!ReferenceEquals(_state.Options, newOptions))
            _state = _state with { Options = newOptions };
        return this;
    }

    #endregion

    #region Input (AssemblyData's)

    public RuntimeApi AddAssemblies(IEnumerable<AssemblyData> assemblyData)
    {
        var assembliesBuilder = _state.Entries.ToBuilder();
        var oldCount = assembliesBuilder.Count;
        var addEntries = assemblyData.Select(ad => new RuntimeApiStateEntry(ad.AssemblyBytes ?? throw new InvalidOperationException("AssemblyBytes must not be null"), ad.DebugSymbolsBytes));
        assembliesBuilder.AddRange(addEntries);
        return oldCount == assembliesBuilder.Count ? this : WithEntries(assemblyData: assembliesBuilder.ToImmutable());
    }

    #endregion

    #region Output (InvocationScope)

    public RuntimeScope CreateRuntimeScope()
    {
        var alc = new AssemblyLoadContext("", true);
        foreach (var (assembly, debugSymbols) in _state.Entries)
            alc.LoadFromBytes(assembly!, debugSymbols);
        return new RuntimeScope(this, alc);
    }

    #endregion
}