using CqlSdkPrototype.Internal;
using CqlSdkPrototype.Invocation.Fluent;
using CqlSdkPrototype.Invocation.Internal;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Invocation;


/// <summary>
/// Builder class for creating instances of <see cref="LibrarySetInvoker"/>.
/// </summary>
public sealed class LibrarySetInvokerBuilder
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LibrarySetInvokerBuilder"/> class.
    /// </summary>
    /// <param name="loggerFactory">Optional logger factory for logging purposes.</param>
    public LibrarySetInvokerBuilder(
        ILoggerFactory? loggerFactory = null/*,
        LibrarySetInvokerBuilderConfig? config = null*/)
    {
        /*config ??= LibrarySetInvokerBuilderConfig.Default;*/
        loggerFactory ??= NullLoggerFactory.Instance;
        LoggerFactory = loggerFactory;
        AssemblyBinaries = AssemblyBinaryHashSet.Empty;
        /*Config = config;*/
        _services = LibrarySetInvokerBuilderServices.Create(loggerFactory);
    }

    /// <summary>
    /// Gets the logger factory used by extensions on the <see cref="FluentInvocationToolkit"/>.
    /// </summary>
    internal ILoggerFactory LoggerFactory { get; }

    /// <summary>
    /// Gets the set of assembly binaries.
    /// </summary>
    public AssemblyBinaryHashSet AssemblyBinaries { get; private set; }

    /*public LibrarySetInvokerBuilderConfig Config { get; private set; }*/

    private LibrarySetInvokerBuilderServices _services;

    /// <summary>
    /// Sets the assembly binaries.
    /// </summary>
    /// <param name="assemblyBinaries">The assembly binaries to set.</param>
    private void SetAssemblyBinaries(
        AssemblyBinaryHashSet assemblyBinaries)
    {
        AssemblyBinaries = assemblyBinaries;
    }

    /*public void Reconfigure(
        LibrarySetInvokerBuilderConfig config)
    {
        // No need to recreate services here yet
        Config = config;
    }*/

    /// <summary>
    /// Adds assembly binaries to the current set.
    /// </summary>
    /// <param name="assemblyBinary">The assembly binaries to add.</param>
    /// <exception cref="InvalidOperationException">Thrown when AssemblyBytes is null.</exception>
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

    /// <summary>
    /// Creates a new instance of <see cref="LibrarySetInvoker"/>.
    /// </summary>
    /// <param name="name">The name of the AssemblyLoadContext.</param>
    /// <returns>A new instance of <see cref="LibrarySetInvoker"/>.</returns>
    public LibrarySetInvoker ToLibrarySetInvoker(string name = "")
    {
        _services.Logger.LogDebug("Creating LibrarySetInvoker");
        var alc = new AssemblyLoadContext(name, true);
        foreach (var (assembly, debugSymbols) in AssemblyBinaries)
            alc.LoadFromBytes(assembly!, debugSymbols);
        return new LibrarySetInvoker(this, alc);
    }
}
