using CqlSdkPrototype.Internal;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CodeGeneration.NET;
using CqlSdkPrototype.Runtime.Extensibility;

namespace CqlSdkPrototype.Runtime;

public class RuntimeApi : IRuntimeApiExtendable<RuntimeApi>
{
    public RuntimeApi(
        ILoggerFactory? loggerFactory = null,
        RuntimeApiOptions? options = null)
        : this (RuntimeApiState.Create(loggerFactory ?? NullLoggerFactory.Instance, options ?? RuntimeApiOptions.Default))
    { }

    internal RuntimeApi(RuntimeApiState state) => _state = state; // Might make this public later. Used for testing now.

    #region State

    private RuntimeApiState _state;

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

    RuntimeApiOptions IRuntimeApiExtendable<RuntimeApi>.Options => _state.Options;
    IReadOnlySet<RuntimeApiStateEntry> IRuntimeApiExtendable<RuntimeApi>.Entries => _state.Entries;
    ILoggerFactory IRuntimeApiExtendable<RuntimeApi>.LoggerFactory => _state.LoggerFactory;

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