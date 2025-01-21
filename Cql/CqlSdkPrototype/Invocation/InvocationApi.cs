using CqlSdkPrototype.Internal;
using CqlSdkPrototype.Invocation.Extensibility;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Invocation;

public class InvocationApi : IInvocationApi
{
    public InvocationApi(
        ILoggerFactory? loggerFactory = null,
        InvocationApiOptions? options = null)
    {
        options ??= InvocationApiOptions.Default;
        _entries = RuntimeApiStateEntryHashSet.Empty;
        _services = InvocationApiServices.Create(loggerFactory);
        _options = options;
    }

    #region State

    private InvocationApiServices _services;
    private RuntimeApiStateEntryHashSet _entries;
    private InvocationApiOptions _options;

    private InvocationApi WithEntries(
        RuntimeApiStateEntryHashSet entries)
    {
        if (ReferenceEquals(_entries, entries))
            return this;

        _entries = entries;
        return this;
    }

    public InvocationApi WithOptions(
        Func<InvocationApiOptions, InvocationApiOptions> replaceOptions)
    {
        var newOptions = replaceOptions(_options);
        if (ReferenceEquals(_options, newOptions))
            return this;

        _options = newOptions;
        _services = InvocationApiServices.Create(_services.LoggerFactory);
        return this;
    }

    public InvocationApiOptions Options => _options;
    public IReadOnlySet<InvokerApiStateEntry> Entries => _entries;
    public ILoggerFactory LoggerFactory => _services.LoggerFactory;

    #endregion

    #region Input (AssemblyData's)

    public InvocationApi AddAssemblies(IEnumerable<AssemblyData> assemblyData)
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