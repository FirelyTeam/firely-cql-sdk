using Hl7.Cql.Elm;

namespace CqlSdkPrototype.Elm.Fluent;

public sealed class FluentElmToolkit(ElmToAssemblyProcessor elmToAssemblyProcessor)
{
    public FluentElmToolkit(
        ILoggerFactory? loggerFactory = null,
        ElmToAssemblyProcessorConfig? settings = null) : this(new ElmToAssemblyProcessor(loggerFactory, settings))
    {
    }

    /// <summary>
    /// For testing purposes only.
    /// </summary>
    internal ServiceProvider ServiceProvider => elmToAssemblyProcessor.ServiceProvider;

    public ILoggerFactory LoggerFactory => elmToAssemblyProcessor.LoggerFactory;

    public ElmToAssemblyProcessorConfig ProcessorConfig => elmToAssemblyProcessor.Config;

    public ElmToAssemblyConversionReadOnlyDictionary ElmToAssemblyConversions => elmToAssemblyProcessor.ElmToAssemblyConversions;

    public FluentElmToolkit Reconfigure(Func<ElmToAssemblyProcessorConfig, ElmToAssemblyProcessorConfig> replace)
    {
        elmToAssemblyProcessor.Reconfigure(replace(ProcessorConfig));
        return this;

    }

    public FluentElmToolkit AddElmLibraries(IEnumerable<Library> libraries)
    {
        elmToAssemblyProcessor.AddElmLibraries(libraries);
        return this;
    }

    public FluentElmToolkit ProcessElmToAssemblies()
    {
        elmToAssemblyProcessor.ProcessElmToAssemblies();
        return this;
    }
}