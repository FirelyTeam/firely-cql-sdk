using Hl7.Cql.Elm;

namespace CqlSdkPrototype.Elm.Fluent;

public sealed class FluentElmToolkit(ElmToAssemblyProcessor elmToAssemblyProcessor)
{
    public FluentElmToolkit(
        ILoggerFactory? loggerFactory = null,
        ElmToAssemblySettings? settings = null) : this(new ElmToAssemblyProcessor(loggerFactory, settings))
    {
    }

    /// <summary>
    /// For testing purposes only.
    /// </summary>
    internal ServiceProvider ServiceProvider => elmToAssemblyProcessor.ServiceProvider;

    public ILoggerFactory LoggerFactory => ServiceProvider.GetRequiredService<ILoggerFactory>();

    public ElmToAssemblySettings Settings => elmToAssemblyProcessor.Settings;

    public ElmToAssemblyConversionReadOnlyDictionary ElmToAssemblyConversions => elmToAssemblyProcessor.ElmToAssemblyConversions;

    public FluentElmToolkit ReplaceSettings(Func<ElmToAssemblySettings, ElmToAssemblySettings> replace)
    {
        elmToAssemblyProcessor.SetSettings(replace(Settings));
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