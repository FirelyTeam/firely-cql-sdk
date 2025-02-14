using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Invocation;

/// <summary>
/// Provides a fluent interface for building and configuring a <see cref="LibrarySetInvoker"/>.
/// </summary>
public sealed class InvocationToolkit
{
    private readonly LibrarySetInvokerBuilder librarySetInvokerBuilder;

    /// <summary>
    /// Initializes a new instance of the <see cref="InvocationToolkit"/> class with a default logger factory.
    /// </summary>
    public InvocationToolkit() : this(default(ILoggerFactory)) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="InvocationToolkit"/> class with the specified logger factory.
    /// </summary>
    /// <param name="loggerFactory">The logger factory to use for logging.</param>
    public InvocationToolkit(ILoggerFactory? loggerFactory)
        : this(new LibrarySetInvokerBuilder(loggerFactory))
    { }

    /// <summary>
    /// Initializes a new instance of the <see cref="InvocationToolkit"/> class with the specified library set invoker builder.
    /// </summary>
    /// <param name="librarySetInvokerBuilder">The library set invoker builder to use.</param>
    public InvocationToolkit(LibrarySetInvokerBuilder librarySetInvokerBuilder)
    {
        this.librarySetInvokerBuilder = librarySetInvokerBuilder;
    }

    /// <summary>
    /// Gets the logger factory used by the extensions.
    /// </summary>
    public ILoggerFactory LoggerFactory => librarySetInvokerBuilder.LoggerFactory;

    /// <summary>
    /// Adds the specified assembly binaries to the toolkit.
    /// </summary>
    /// <param name="assemblyBinary">The assembly binaries to add.</param>
    /// <returns>The current instance of <see cref="InvocationToolkit"/>.</returns>
    public InvocationToolkit AddAssemblyBinaries(IEnumerable<AssemblyBinary> assemblyBinary)
    {
        librarySetInvokerBuilder.AddAssemblyBinaries(assemblyBinary);
        return this;
    }

    /// <summary>
    /// Builds and returns a <see cref="LibrarySetInvoker"/> with the specified name.
    /// </summary>
    /// <param name="name">The name of the library set invoker.</param>
    /// <returns>A <see cref="LibrarySetInvoker"/> instance.</returns>
    public LibrarySetInvoker ToLibrarySetInvoker(string name = "")
    {
        return librarySetInvokerBuilder.ToLibrarySetInvoker(name);
    }
}
