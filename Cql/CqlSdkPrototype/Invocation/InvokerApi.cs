using CqlSdkPrototype.Internal;
using CqlSdkPrototype.Invocation.Extensibility;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Invocation;

public class InvokerApi : IInvokerApiExtendable<InvokerApi>
{
    public InvokerApi(
        ILoggerFactory? loggerFactory = null,
        InvokerApiOptions? options = null)
    {
        options ??= InvokerApiOptions.Default;
        _entries = RuntimeApiStateEntryHashSet.Empty;
        _services = InvokerApiServices.Create(loggerFactory);
        _options = options;
    }

    #region State

    private InvokerApiServices _services;
    private RuntimeApiStateEntryHashSet _entries;
    private InvokerApiOptions _options;

    private InvokerApi WithEntries(
        RuntimeApiStateEntryHashSet entries)
    {
        if (ReferenceEquals(_entries, entries))
            return this;

        _entries = entries;
        return this;
    }

    public InvokerApi WithOptions(
        Func<InvokerApiOptions, InvokerApiOptions> replaceOptions)
    {
        var newOptions = replaceOptions(_options);
        if (ReferenceEquals(_options, newOptions))
            return this;

        _options = newOptions;
        _services = InvokerApiServices.Create(_services.LoggerFactory);
        return this;
    }

    InvokerApiOptions IInvokerApiExtendable<InvokerApi>.Options => _options;
    IReadOnlySet<InvokerApiStateEntry> IInvokerApiExtendable<InvokerApi>.Entries => _entries;
    ILoggerFactory IInvokerApiExtendable<InvokerApi>.LoggerFactory => _services.LoggerFactory;

    #endregion

    #region Input (AssemblyData's)

    public InvokerApi AddAssemblies(IEnumerable<AssemblyData> assemblyData)
    {
        var assembliesBuilder = _entries.ToBuilder();
        var oldCount = assembliesBuilder.Count;
        var addEntries = assemblyData.Select(ad => new InvokerApiStateEntry(ad.AssemblyBytes ?? throw new InvalidOperationException("AssemblyBytes must not be null"), ad.DebugSymbolsBytes));
        assembliesBuilder.AddRange(addEntries);
        return oldCount == assembliesBuilder.Count ? this : WithEntries(assembliesBuilder.ToImmutable());
    }

    #endregion

    #region Output (InvocationScope)

    public LibrarySetInvoker CreateLibrarySetInvoker()
    {
        var alc = new AssemblyLoadContext("", true);
        foreach (var (assembly, debugSymbols) in _entries)
            alc.LoadFromBytes(assembly!, debugSymbols);
        return new LibrarySetInvoker(this, alc);
    }

    #endregion
}