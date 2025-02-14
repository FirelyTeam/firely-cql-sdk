namespace CqlSdkPrototype.Elm.Fluent;

/// <summary>
/// Provides a fluent interface for working with the ElmToAssemblyCompiler.
/// </summary>
public sealed class ElmToolkit
{
    private readonly ElmToAssemblyCompiler elmToAssemblyCompiler;

    /// <summary>
    /// Initializes a new instance of the <see cref="ElmToolkit"/> class.
    /// </summary>
    /// <param name="loggerFactory">The logger factory to use for logging.</param>
    /// <param name="config">The configuration settings for the compiler.</param>
    public ElmToolkit(
        ILoggerFactory? loggerFactory = null,
        ElmToAssemblyCompilerConfig? config = null) : this(new ElmToAssemblyCompiler(loggerFactory, config))
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ElmToolkit"/> class with the specified compiler.
    /// </summary>
    /// <param name="elmToAssemblyCompiler">The compiler to use.</param>
    public ElmToolkit(ElmToAssemblyCompiler elmToAssemblyCompiler)
    {
        this.elmToAssemblyCompiler = elmToAssemblyCompiler;
    }

    /// <summary>
    /// Gets the service provider used by tests.
    /// </summary>
    internal ServiceProvider ServiceProvider => elmToAssemblyCompiler.ServiceProvider;

    /// <summary>
    /// Gets the logger factory used by extensions.
    /// </summary>
    public ILoggerFactory LoggerFactory => elmToAssemblyCompiler.LoggerFactory;

    /// <summary>
    /// Gets the configuration for the compiler.
    /// </summary>
    public ElmToAssemblyCompilerConfig ProcessorConfig => elmToAssemblyCompiler.Config;

    /// <summary>
    /// Gets the dictionary of ELM to assembly compilations.
    /// </summary>
    public ElmToAssemblyCompilationReadOnlyDictionary ElmToAssemblyCompilations => elmToAssemblyCompiler.ElmToAssemblyCompilations;

    /// <summary>
    /// Reconfigures the compiler with the specified configuration.
    /// </summary>
    /// <param name="configure">A function that takes the current configuration and returns a new configuration.</param>
    /// <returns>The current instance of <see cref="ElmToolkit"/>.</returns>
    public ElmToolkit Reconfigure(Func<ElmToAssemblyCompilerConfig, ElmToAssemblyCompilerConfig> configure)
    {
        elmToAssemblyCompiler.Reconfigure(configure(ProcessorConfig));
        return this;
    }

    /// <summary>
    /// Adds ELM libraries to the compiler.
    /// </summary>
    /// <param name="libraries">The libraries to add.</param>
    /// <returns>The current instance of <see cref="ElmToolkit"/>.</returns>
    public ElmToolkit AddElmLibraries(IEnumerable<ElmLibrary> libraries)
    {
        elmToAssemblyCompiler.AddElmLibraries(libraries);
        return this;
    }

    /// <summary>
    /// Compiles the ELM libraries into .NET assemblies.
    /// </summary>
    /// <returns>The current instance of <see cref="ElmToolkit"/>.</returns>
    public ElmToolkit CompileElmToAssemblies()
    {
        elmToAssemblyCompiler.CompileElmToAssemblies();
        return this;
    }
}
