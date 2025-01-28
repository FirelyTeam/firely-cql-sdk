using CqlSdkPrototype.Internal;
using CqlSdkPrototype.Invocation.Extensibility;
using CqlSdkPrototype.Invocation.Internal;
using CqlSdkPrototype.Invocation.Invokers;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Invocation;

public class LibrarySetInvokerBuilder : IRuntimeApiExtendable<LibrarySetInvokerBuilder>
{
    public LibrarySetInvokerBuilder(
        ILoggerFactory? loggerFactory = null,
        LibrarySetInvokerBuilderSettings? options = null)
        : this (LibrarySetInvokerBuilderServices.Create(loggerFactory ?? NullLoggerFactory.Instance, options ?? LibrarySetInvokerBuilderSettings.Default))
    { }

    internal LibrarySetInvokerBuilder(LibrarySetInvokerBuilderServices state) => _state = state; // Might make this public later. Used for testing now.

    #region State

    private LibrarySetInvokerBuilderServices _state;

    private LibrarySetInvokerBuilder WithEntries(
        ImmutableHashSet<RuntimeApiStateEntry>? assemblyData = null)
    {
        _state = _state with
        {
            Entries = assemblyData ?? _state.Entries
        };
        return this;
    }

    public LibrarySetInvokerBuilder WithOptions(
        Func<LibrarySetInvokerBuilderSettings, LibrarySetInvokerBuilderSettings> replaceOptions)
    {
        var newOptions = replaceOptions(_state.Options);
        if (!ReferenceEquals(_state.Options, newOptions))
            _state = _state with { Options = newOptions };
        return this;
    }

    LibrarySetInvokerBuilderSettings IRuntimeApiExtendable<LibrarySetInvokerBuilder>.Options => _state.Options;
    IReadOnlySet<RuntimeApiStateEntry> IRuntimeApiExtendable<LibrarySetInvokerBuilder>.Entries => _state.Entries;
    ILoggerFactory IRuntimeApiExtendable<LibrarySetInvokerBuilder>.LoggerFactory => _state.LoggerFactory;

    #endregion

    #region Input (AssemblyData's)

    public LibrarySetInvokerBuilder AddAssemblies(IEnumerable<AssemblyData> assemblyData)
    {
        var assembliesBuilder = _state.Entries.ToBuilder();
        var oldCount = assembliesBuilder.Count;
        var addEntries = assemblyData.Select(ad => new RuntimeApiStateEntry(ad.AssemblyBytes ?? throw new InvalidOperationException("AssemblyBytes must not be null"), ad.DebugSymbolsBytes));
        assembliesBuilder.AddRange(addEntries);
        return oldCount == assembliesBuilder.Count ? this : WithEntries(assemblyData: assembliesBuilder.ToImmutable());
    }

    #endregion

    #region Output (InvocationScope)

    public LibrarySetInvoker CreateRuntimeScope()
    {
        var alc = new AssemblyLoadContext("", true);
        foreach (var (assembly, debugSymbols) in _state.Entries)
            alc.LoadFromBytes(assembly!, debugSymbols);
        return new LibrarySetInvoker(this, alc);
    }

    #endregion
}