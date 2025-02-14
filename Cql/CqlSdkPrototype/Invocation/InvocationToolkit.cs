using CqlSdkPrototype.Internal;
using CqlSdkPrototype.Invocation.Internal;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Invocation;


/// <summary>
/// Builder class for creating instances of <see cref="LibrarySetInvoker"/>.
/// </summary>
public sealed class InvocationToolkit
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InvocationToolkit"/> class.
    /// </summary>
    /// <param name="loggerFactory">Optional logger factory for logging purposes.</param>
    public InvocationToolkit(
        ILoggerFactory? loggerFactory = null)
    {
        loggerFactory ??= NullLoggerFactory.Instance;
        LoggerFactory = loggerFactory;
        AssemblyBinaries = AssemblyBinaryHashSet.Empty;
        _services = LibrarySetInvokerBuilderServices.Create(loggerFactory);
    }

    /// <summary>
    /// Gets the logger factory used by extensions on the <see cref="InvocationToolkit"/>.
    /// </summary>
    internal ILoggerFactory LoggerFactory { get; }

    /// <summary>
    /// Gets the set of assembly binaries.
    /// </summary>
    public AssemblyBinaryHashSet AssemblyBinaries { get; private set; }

    private readonly LibrarySetInvokerBuilderServices _services;

    /// <summary>
    /// Sets the assembly binaries.
    /// </summary>
    /// <param name="assemblyBinaries">The assembly binaries to set.</param>
    private void ReplaceAssemblyBinaries(
        AssemblyBinaryHashSet assemblyBinaries)
    {
        AssemblyBinaries = assemblyBinaries;
    }

    /// <summary>
    /// Adds assembly binaries to the current set.
    /// </summary>
    /// <param name="assemblyBinary">The assembly binaries to add.</param>
    /// <exception cref="InvalidOperationException">Thrown when AssemblyBytes is null.</exception>
    public InvocationToolkit AddAssemblyBinaries(IEnumerable<AssemblyBinary> assemblyBinary)
    {
        var builder = AssemblyBinaries.ToBuilder();
        var oldCount = builder.Count;
        builder.AddRange(
            assemblyBinary
                             .Select(ad =>
                             {
                                 _services.Logger.LogDebug("Adding assembly binary with {bytesLength} bytes.", ad.AssemblyBytes?.Length ?? 0);
                                 return new AssemblyBinary(ad.AssemblyBytes ?? throw new InvalidOperationException("AssemblyBytes must not be null"),
                                                           ad.DebugSymbolsBytes);
                             }));
        if (oldCount != builder.Count)
            ReplaceAssemblyBinaries(builder.ToImmutable());

        return this;
    }

    /// <summary>
    /// Creates a new instance of <see cref="LibrarySetInvoker"/>.
    /// </summary>
    /// <param name="name">The name of the AssemblyLoadContext.</param>
    /// <returns>A new instance of <see cref="LibrarySetInvoker"/>
    /// which must be disposed when no longer in use,
    /// so that the loaded assemblies may unload from the
    /// application domain.</returns>
    public LibrarySetInvoker CreateLibrarySetInvoker(string name = "")
    {
        _services.Logger.LogDebug("Creating LibrarySetInvoker {name}", name);

        var alc = new AssemblyLoadContext(name, true);
        foreach (var (assembly, debugSymbols) in AssemblyBinaries)
        {
            var asm = alc.LoadFromBytes(assembly!, debugSymbols);
            _services.Logger.LogInformation("Loaded assembly {assemblyName}", asm.FullName);
        }

        return new LibrarySetInvoker(this, alc);
    }
}
