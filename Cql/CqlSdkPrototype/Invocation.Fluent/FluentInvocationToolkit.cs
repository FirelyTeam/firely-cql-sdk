using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Invocation.Fluent;

public class FluentInvocationToolkit(LibrarySetInvokerBuilder librarySetInvokerBuilder)
{
    public FluentInvocationToolkit(
        ILoggerFactory? loggerFactory = null,
        LibrarySetInvokerBuilderConfig? config = null)
        : this (new LibrarySetInvokerBuilder(loggerFactory, config))
    { }

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

    public LibrarySetInvoker CreateLibrarySetInvoker(string name = "")
    {
        return librarySetInvokerBuilder.CreateLibrarySetInvoker(name);
    }
}