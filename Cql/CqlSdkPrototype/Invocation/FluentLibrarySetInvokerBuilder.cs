using CqlSdkPrototype.Internal;
using CqlSdkPrototype.Invocation.Internal;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Invocation;

public class FluentLibrarySetInvokerBuilder
{
    public FluentLibrarySetInvokerBuilder(
        ILoggerFactory? loggerFactory = null,
        LibrarySetInvokerBuilderSettings? options = null)
        : this (LibrarySetInvokerBuilderServices.Create(loggerFactory ?? NullLoggerFactory.Instance, options ?? LibrarySetInvokerBuilderSettings.Default))
    { }

    internal FluentLibrarySetInvokerBuilder(LibrarySetInvokerBuilderServices state) => _state = state; // Might make this public later. Used for testing now.

    private LibrarySetInvokerBuilderServices _state;

    private FluentLibrarySetInvokerBuilder WithEntries(
        ImmutableHashSet<LibraryBinaries>? assemblyData = null)
    {
        _state = _state with
        {
            Entries = assemblyData ?? _state.Entries
        };
        return this;
    }

    public FluentLibrarySetInvokerBuilder WithOptions(
        Func<LibrarySetInvokerBuilderSettings, LibrarySetInvokerBuilderSettings> replaceOptions)
    {
        var newOptions = replaceOptions(_state.Options);
        if (!ReferenceEquals(_state.Options, newOptions))
            _state = _state with { Options = newOptions };
        return this;
    }

    public FluentLibrarySetInvokerBuilder AddAssemblies(IEnumerable<AssemblyData> assemblyData)
    {
        var assembliesBuilder = _state.Entries.ToBuilder();
        var oldCount = assembliesBuilder.Count;
        var addEntries = assemblyData.Select(ad => new LibraryBinaries(ad.AssemblyBytes ?? throw new InvalidOperationException("AssemblyBytes must not be null"), ad.DebugSymbolsBytes));
        assembliesBuilder.AddRange(addEntries);
        return oldCount == assembliesBuilder.Count ? this : WithEntries(assemblyData: assembliesBuilder.ToImmutable());
    }

    public LibrarySetInvoker CreateLibrarySetInvoker(string name = "")
    {
        var alc = new AssemblyLoadContext(name, true);
        foreach (var (assembly, debugSymbols) in _state.Entries)
            alc.LoadFromBytes(assembly!, debugSymbols);
        return new LibrarySetInvoker(this, alc);
    }
}