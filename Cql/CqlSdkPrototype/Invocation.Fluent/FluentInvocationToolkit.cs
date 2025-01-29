using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Invocation.Fluent;

public sealed class FluentInvocationToolkit(LibrarySetInvokerBuilder librarySetInvokerBuilder)
{
    public FluentInvocationToolkit(
        ILoggerFactory? loggerFactory = null,
        LibrarySetInvokerBuilderConfig? config = null)
        : this (new LibrarySetInvokerBuilder(loggerFactory, config))
    { }

    /// <remarks>
    /// Used by extensions to access the logger factory.
    /// </remarks>>
    public ILoggerFactory LoggerFactory => librarySetInvokerBuilder.LoggerFactory;

    public FluentInvocationToolkit AddAssemblyBinaries(IEnumerable<AssemblyBinary> assemblyBinary)
    {
        librarySetInvokerBuilder.AddAssemblyBinaries(assemblyBinary);
        return this;
    }

    public FluentInvocationToolkit Reconfigure(
        Func<LibrarySetInvokerBuilderConfig, LibrarySetInvokerBuilderConfig> configure)
    {
        librarySetInvokerBuilder.Reconfigure(configure(librarySetInvokerBuilder.Config));
        return this;
    }

    public LibrarySetInvoker ToLibrarySetInvoker(string name = "")
    {
        return librarySetInvokerBuilder.ToLibrarySetInvoker(name);
    }
}