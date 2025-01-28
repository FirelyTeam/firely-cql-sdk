using Hl7.Cql.Elm;

namespace CqlSdkPrototype.Elm.Fluent;

public sealed class FluentElmToolkit(ElmToAssemblyCompiler elmToAssemblyCompiler)
{
    public FluentElmToolkit(
        ILoggerFactory? loggerFactory = null,
        ElmToAssemblyCompilerConfig? settings = null) : this(new ElmToAssemblyCompiler(loggerFactory, settings))
    {
    }

    /// <summary>
    /// For testing purposes only.
    /// </summary>
    internal ServiceProvider ServiceProvider => elmToAssemblyCompiler.ServiceProvider;

    /// <summary>
    /// Used by extensions to access the logger factory.
    /// </summary>
    public ILoggerFactory LoggerFactory => elmToAssemblyCompiler.LoggerFactory;

    public ElmToAssemblyCompilerConfig ProcessorConfig => elmToAssemblyCompiler.Config;

    public ElmToAssemblyCompilationReadOnlyDictionary ElmToAssemblyCompilations => elmToAssemblyCompiler.ElmToAssemblyCompilations;

    public FluentElmToolkit Reconfigure(Func<ElmToAssemblyCompilerConfig, ElmToAssemblyCompilerConfig> configure)
    {
        elmToAssemblyCompiler.Reconfigure(configure(ProcessorConfig));
        return this;

    }

    public FluentElmToolkit AddElmLibraries(IEnumerable<Library> libraries)
    {
        elmToAssemblyCompiler.AddElmLibraries(libraries);
        return this;
    }

    public FluentElmToolkit CompileElmToAssemblies()
    {
        elmToAssemblyCompiler.CompileElmToAssemblies();
        return this;
    }
}