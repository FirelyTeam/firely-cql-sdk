using CqlSdkPrototype.Internal;
using CqlSdkPrototype.Invocation.Internal;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Invocation;

public class LibrarySetInvokerBuilder
{
    public LibrarySetInvokerBuilder(
        ILoggerFactory? loggerFactory = null,
        LibrarySetInvokerBuilderConfig? config = null)
    {
        config ??= LibrarySetInvokerBuilderConfig.Default;
        loggerFactory ??= NullLoggerFactory.Instance;
        LoggerFactory = loggerFactory;
        AssemblyDatas = AssemblyDataHashSet.Empty;
        Config = config;
        _services = LibrarySetInvokerBuilderServices.Create(loggerFactory);
    }

    /// <summary>
    /// Access by the FluentInvocationToolkit.
    /// </summary>
    internal ILoggerFactory LoggerFactory { get; }

    public AssemblyDataHashSet AssemblyDatas { get; private set; }

    public LibrarySetInvokerBuilderConfig Config { get; private set; }

    private LibrarySetInvokerBuilderServices _services;

    private void SetAssemblyDatas(
        AssemblyDataHashSet assemblyDatas)
    {
        AssemblyDatas = assemblyDatas;
    }

    public void Reconfigure(
        LibrarySetInvokerBuilderConfig config)
    {
        // No need to recreate services here yet
        Config = config;
    }

    public void AddAssemblies(IEnumerable<AssemblyData> assemblyData)
    {
        _services.Logger.LogInformation("Adding assemblies");
        var builder = AssemblyDatas.ToBuilder();
        var oldCount = builder.Count;
        var addEntries = assemblyData.Select(ad => new AssemblyData(ad.AssemblyBytes ?? throw new InvalidOperationException("AssemblyBytes must not be null"), ad.DebugSymbolsBytes));
        builder.AddRange(addEntries);
        if (oldCount != builder.Count)
            SetAssemblyDatas(builder.ToImmutable());
    }

    public LibrarySetInvoker CreateLibrarySetInvoker(string name = "")
    {
        _services.Logger.LogDebug("Creating LibrarySetInvoker");
        var alc = new AssemblyLoadContext(name, true);
        foreach (var (assembly, debugSymbols) in AssemblyDatas)
            alc.LoadFromBytes(assembly!, debugSymbols);
        return new LibrarySetInvoker(this, alc);
    }
}