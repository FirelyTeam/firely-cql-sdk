using CqlSdkPrototype.Internal;
using CqlSdkPrototype.Invocation.Internal;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Invocation;

public sealed class LibrarySetInvokerBuilder
{
    public LibrarySetInvokerBuilder(
        ILoggerFactory? loggerFactory = null,
        LibrarySetInvokerBuilderConfig? config = null)
    {
        config ??= LibrarySetInvokerBuilderConfig.Default;
        loggerFactory ??= NullLoggerFactory.Instance;
        LoggerFactory = loggerFactory;
        AssemblyBinaries = AssemblyBinaryHashSet.Empty;
        Config = config;
        _services = LibrarySetInvokerBuilderServices.Create(loggerFactory);
    }

    /// <summary>
    /// Access by the FluentInvocationToolkit.
    /// </summary>
    internal ILoggerFactory LoggerFactory { get; }

    public AssemblyBinaryHashSet AssemblyBinaries { get; private set; }

    public LibrarySetInvokerBuilderConfig Config { get; private set; }

    private LibrarySetInvokerBuilderServices _services;

    private void SetAssemblyBinaries(
        AssemblyBinaryHashSet assemblyBinaries)
    {
        AssemblyBinaries = assemblyBinaries;
    }

    public void Reconfigure(
        LibrarySetInvokerBuilderConfig config)
    {
        // No need to recreate services here yet
        Config = config;
    }

    public void AddAssemblyBinaries(IEnumerable<AssemblyBinary> assemblyBinary)
    {
        _services.Logger.LogInformation("Adding assemblies");
        var builder = AssemblyBinaries.ToBuilder();
        var oldCount = builder.Count;
        var addEntries = assemblyBinary.Select(ad => new AssemblyBinary(ad.AssemblyBytes ?? throw new InvalidOperationException("AssemblyBytes must not be null"), ad.DebugSymbolsBytes));
        builder.AddRange(addEntries);
        if (oldCount != builder.Count)
            SetAssemblyBinaries(builder.ToImmutable());
    }

    public LibrarySetInvoker ToLibrarySetInvoker(string name = "")
    {
        _services.Logger.LogDebug("Creating LibrarySetInvoker");
        var alc = new AssemblyLoadContext(name, true);
        foreach (var (assembly, debugSymbols) in AssemblyBinaries)
            alc.LoadFromBytes(assembly!, debugSymbols);
        return new LibrarySetInvoker(this, alc);
    }
}