using Hl7.Cql.Elm;

namespace CqlSdkPrototype.Elm;

public sealed class ElmFluentToolkit(ElmToAssemblyProcessor elmToAssemblyProcessor)
{
    public ElmFluentToolkit(
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

    public ElmFluentToolkit ReplaceSettings(Func<ElmToAssemblySettings, ElmToAssemblySettings> replace)
    {
        elmToAssemblyProcessor.SetSettings(replace(Settings));
        return this;

    }

    public ElmFluentToolkit AddElmLibraries(IEnumerable<Library> libraries)
    {
        elmToAssemblyProcessor.AddElmLibraries(libraries);
        return this;
    }

    public ElmFluentToolkit ProcessElmToAssemblies()
    {
        elmToAssemblyProcessor.ProcessElmToAssemblies();
        return this;
    }
}