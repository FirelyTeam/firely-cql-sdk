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
    {
        options ??= RuntimeApiOptions.Default;
        _entries = RuntimeApiStateEntryHashSet.Empty;
        _services = RuntimeServices.Create(loggerFactory, options);
        _options = options;
    }

    #region State

    private RuntimeServices _services;
    private RuntimeApiStateEntryHashSet _entries;
    private RuntimeApiOptions _options;

    private RuntimeApi WithEntries(
        RuntimeApiStateEntryHashSet entries)
    {
        if (ReferenceEquals(_entries, entries))
            return this;

        _entries = entries;
        return this;
    }

    public RuntimeApi WithOptions(
        Func<RuntimeApiOptions, RuntimeApiOptions> replaceOptions)
    {
        var newOptions = replaceOptions(_services.Options);
        if (ReferenceEquals(_services.Options, newOptions))
            return this;

        _services = _services with { Options = newOptions };
        return this;
    }

    RuntimeApiOptions IRuntimeApiExtendable<RuntimeApi>.Options => _services.Options;
    IReadOnlySet<RuntimeApiStateEntry> IRuntimeApiExtendable<RuntimeApi>.Entries => _services.Entries;
    ILoggerFactory IRuntimeApiExtendable<RuntimeApi>.LoggerFactory => _services.LoggerFactory;

    #endregion

    #region Input (AssemblyData's)

    public RuntimeApi AddAssemblies(IEnumerable<AssemblyData> assemblyData)
    {
        var assembliesBuilder = _services.Entries.ToBuilder();
        var oldCount = assembliesBuilder.Count;
        var addEntries = assemblyData.Select(ad => new RuntimeApiStateEntry(ad.AssemblyBytes ?? throw new InvalidOperationException("AssemblyBytes must not be null"), ad.DebugSymbolsBytes));
        assembliesBuilder.AddRange(addEntries);
        return oldCount == assembliesBuilder.Count ? this : WithEntries(assembliesBuilder.ToImmutable());
    }

    #endregion

    #region Output (InvocationScope)

    public RuntimeScope CreateRuntimeScope()
    {
        var alc = new AssemblyLoadContext("", true);
        foreach (var (assembly, debugSymbols) in _services.Entries)
            alc.LoadFromBytes(assembly!, debugSymbols);
        return new RuntimeScope(this, alc);
    }

    #endregion
}