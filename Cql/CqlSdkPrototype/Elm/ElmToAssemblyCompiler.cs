using CqlSdkPrototype.Elm.Fluent;
using CqlSdkPrototype.Elm.Internal;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Internal;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Elm;

/// <summary>
/// Compiles ELM (Expression Logical Model) into .NET assemblies.
/// </summary>
public sealed class ElmToAssemblyCompiler
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ElmToAssemblyCompiler"/> class.
    /// </summary>
    /// <param name="loggerFactory">The logger factory to use for logging.</param>
    /// <param name="config">The configuration for the compiler.</param>
    public ElmToAssemblyCompiler(
        ILoggerFactory? loggerFactory = null,
        ElmToAssemblyCompilerConfig? config = null)
    {
        config ??= ElmToAssemblyCompilerConfig.Default;
        loggerFactory ??= NullLoggerFactory.Instance;
        LoggerFactory = loggerFactory;
        _elmToAssemblyCompilations = ElmToAssemblyCompilationDictionary.Empty;
        Config = config;
        _services = ElmToAssemblyProcessorServices.Create(loggerFactory, config);
    }

    private ElmToAssemblyCompilationDictionary _elmToAssemblyCompilations;
    private ElmToAssemblyProcessorServices _services;

    /// <summary>
    /// Gets the logger factory used by extensions via <seealso cref="FluentElmToolkit.LoggerFactory"/>.
    /// </summary>
    internal ILoggerFactory LoggerFactory { get; }

    /// <summary>
    /// Gets the service provider used by tests via <seealso cref="FluentElmToolkit.ServiceProvider"/>.
    /// </summary>
    internal ServiceProvider ServiceProvider => _services.ServiceProvider;

    /// <summary>
    /// Gets the configuration for the compiler.
    /// </summary>
    public ElmToAssemblyCompilerConfig Config { get; private set; }

    /// <summary>
    /// Gets the dictionary of ELM to assembly compilations.
    /// </summary>
    public ElmToAssemblyCompilationReadOnlyDictionary ElmToAssemblyCompilations => _elmToAssemblyCompilations;

    /// <summary>
    /// Sets the conversions for the ELM to assembly compilations.
    /// </summary>
    /// <param name="elmToAssemblyCompilations">The dictionary of ELM to assembly compilations.</param>
    private void SetConversions(
        ElmToAssemblyCompilationDictionary elmToAssemblyCompilations)
    {
        _elmToAssemblyCompilations = elmToAssemblyCompilations;
    }

    /// <summary>
    /// Reconfigures the compiler with the specified configuration.
    /// </summary>
    /// <param name="config">The new configuration for the compiler.</param>
    public void Reconfigure(
        ElmToAssemblyCompilerConfig config)
    {
        if (Config == config)
            return;

        _services.ServiceProvider.Dispose();
        Config = config;
        _services = ElmToAssemblyProcessorServices.Create(LoggerFactory, config);
    }

    /// <summary>
    /// Adds ELM libraries to the compiler.
    /// </summary>
    /// <param name="libraries">The libraries to add.</param>
    public void AddElmLibraries(IEnumerable<Library> libraries)
    {
        var entries = _elmToAssemblyCompilations.ToBuilder();
        var hasChanged = false;
        foreach (var library in libraries)
        {
            var versionedIdentifier = CqlVersionedLibraryIdentifier.FromVersionedIdentifier(library.identifier);

            if (entries.TryGetValue(versionedIdentifier, out var existingVersionedIdentifier))
            {
                _services.Logger.LogInformation(
                    "Skipping replacing library {existingVersionedIdentifier} to compiler with new library: {versionedIdentifier}, ",
                    existingVersionedIdentifier, versionedIdentifier);
                continue;
            }

            var libraryCompilation = new ElmToAssemblyCompilation(library);
            entries.Add(versionedIdentifier, libraryCompilation);
            _services.Logger.LogInformation("Adding library to compiler: {versionedIdentifier}", versionedIdentifier);
            hasChanged = true;
        }

        if (hasChanged)
            SetConversions(elmToAssemblyCompilations: entries.ToImmutable());
    }

    /// <summary>
    /// Compiles the ELM libraries into .NET assemblies.
    /// </summary>
    public void CompileElmToAssemblies()
    {
        var entries = _elmToAssemblyCompilations;
        if (entries.Values.All(predicate: lc => lc is { AssemblyBinary: not null })) return;

        using var servicesScope = _services.CreateScopedState();
        var logger = _services.Logger;
        logger.LogInformation(message: "Compiling ELM into C# and .NET Binaries");
        var exceptionHandling = Config.ProcessBatchItemExceptionHandling;
        var debugInformationFormat = Config.AssemblyCompilerDebugInformationFormat;
        AssemblyCompiler assemblyCompiler = _services.AssemblyCompiler;
        LibrarySetCSharpCodeGenerator cSharpCodeProcessor = _services.LibrarySetCSharpCodeGenerator;
        LibrarySetExpressionBuilder librarySetExpressionBuilderScoped = servicesScope.LibrarySetExpressionBuilder;
        Library[] libraries = entries.Values.Select(selector: v => v.ElmLibrary).ToArray();
        LibrarySet librarySet = new LibrarySet(name: "", libraries: libraries);

        var removedLibraries = librarySet.RemoveLibrariesWithMissingDependencies();
        foreach (var (id, _) in removedLibraries)
            logger.LogWarning(message: "Removed library with missing dependencies: {id}", args: id);

        LogExceptionMessageAction log = logger.GetLogExceptionMessageAction(exceptionHandling);

        var librarySetDefinitions = BuildLibrarySetDefinitions(librarySetExpressionBuilderScoped, librarySet, logger, log, exceptionHandling);

        var cSharps = GenerateCSharp(cSharpCodeProcessor, librarySet, librarySetDefinitions, logger, log, exceptionHandling);

        var assemblyBinaries = CompileAssemblies(assemblyCompiler, librarySet, cSharps, debugInformationFormat, logger, log, exceptionHandling);

        var entriesBuilder = entries.ToBuilder();
        var hasChanged = UpdateStateEntries(assemblyBinaries, entriesBuilder, logger);
        if (hasChanged)
            SetConversions(elmToAssemblyCompilations: entriesBuilder.ToImmutable());
    }

    /// <summary>
    /// Updates the state entries with the compiled assemblies.
    /// </summary>
    /// <param name="assemblyBinaries">The compiled assemblies.</param>
    /// <param name="entriesBuilder">The builder for the entries dictionary.</param>
    /// <param name="logger">The logger to use for logging.</param>
    /// <returns><see langword="true"/> if the state entries were updated; otherwise, <see langword="false"/>.</returns>
    private static bool UpdateStateEntries(
        IEnumerable<(Library library, AssemblyBinaryWithSourceCode assemblyBinaryWithSourceCode)> assemblyBinaries,
        ElmToAssemblyCompilationDictionary.Builder entriesBuilder,
        ILogger<ElmToAssemblyCompiler> logger)
    {
        bool hasChanged = false;
        foreach (var (library, (assemblyBinary, sourceCodePerName, debugSymbols)) in assemblyBinaries)
        {
            var elmVersionedIdentifier = CqlVersionedLibraryIdentifier.FromVersionedIdentifier(library.identifier);
            var libraryCompilation = entriesBuilder[key: elmVersionedIdentifier];
            if (libraryCompilation.CSharpSourceCode is not null
                || libraryCompilation.AssemblyBinary is not null)
            {
                logger.LogInformation(message: "Library already compiled: {versionedIdentifier}", args: elmVersionedIdentifier);
                continue;
            }

            var cSharpSourceCode = sourceCodePerName!.Values.Single(); // We always expect a single source file
            libraryCompilation = libraryCompilation with
            {
                CSharpSourceCode = cSharpSourceCode,
                AssemblyBinary = assemblyBinary,
                DebugSymbolsBinary = debugSymbols,
            };
            entriesBuilder[key: elmVersionedIdentifier] = libraryCompilation;
            logger.LogInformation(message: "Library compiled: {versionedIdentifier}", args: elmVersionedIdentifier);
            hasChanged = true;
        }

        return hasChanged;
    }

    /// <summary>
    /// Compiles the C# code into .NET assemblies.
    /// </summary>
    /// <param name="assemblyCompiler">The assembly compiler to use.</param>
    /// <param name="librarySet">The set of libraries to compile.</param>
    /// <param name="cSharps">The C# code to compile.</param>
    /// <param name="debugInformationFormat">The format for debug information.</param>
    /// <param name="logger">The logger to use for logging.</param>
    /// <param name="log">The action to log exceptions.</param>
    /// <param name="exceptionHandling">The exception handling strategy.</param>
    /// <returns>The compiled assemblies.</returns>
    private static IEnumerable<(Library library, AssemblyBinaryWithSourceCode assemblyBinaryWithSourceCode)> CompileAssemblies(
        AssemblyCompiler assemblyCompiler,
        LibrarySet librarySet,
        IEnumerable<(Library library, string cSharp)> cSharps,
        AssemblyCompilerDebugInformationFormat debugInformationFormat,
        ILogger<ElmToAssemblyCompiler> logger,
        LogExceptionMessageAction log,
        ProcessBatchItemExceptionHandling exceptionHandling)
    {
        var assemblyBinaries = assemblyCompiler
                            .CompileDeferred(librarySet, cSharps, debugInformationFormat)
                            .Select(t =>
                            {
                                var libraryName = t.library.identifier;
                                logger.LogInformation("Compiling assembly for library : {libraryName}", libraryName);
                                return t;
                            })
                            .TryProcessEach(t => (t.library, assemblyBinaryWithSourceCode: t.generateAssemblyBinaryWithSourceCode()))
                            .WithEachException(t =>
                            {
                                var libraryName = t.Input.library.identifier;
                                log(t.Exception, "Error compiling assembly for library: {libraryName}", libraryName);
                            })
                            .HandleExceptions(exceptionHandling);
        return assemblyBinaries;
    }

    /// <summary>
    /// Generates the C# code for the libraries.
    /// </summary>
    /// <param name="cSharpCodeProcessor">The C# code processor to use.</param>
    /// <param name="librarySet">The set of libraries to generate code for.</param>
    /// <param name="librarySetDefinitions">The definitions for the library set.</param>
    /// <param name="logger">The logger to use for logging.</param>
    /// <param name="log">The action to log exceptions.</param>
    /// <param name="exceptionHandling">The exception handling strategy.</param>
    /// <returns>The generated C# code.</returns>
    private static IEnumerable<(Library library, string cSharp)> GenerateCSharp(
        LibrarySetCSharpCodeGenerator cSharpCodeProcessor,
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression> librarySetDefinitions,
        ILogger<ElmToAssemblyCompiler> logger,
        LogExceptionMessageAction log,
        ProcessBatchItemExceptionHandling exceptionHandling)
    {
        var cSharps = cSharpCodeProcessor
                      .GenerateCSharpDeferred(librarySet, librarySetDefinitions)
                      .Select(t =>
                      {
                          var libraryName = t.library.identifier;
                          logger.LogInformation("Generating C# for library : {libraryName}", libraryName);
                          return t;
                      })
                      .TryProcessEach(t => (t.library, cSharp: t.generateCSharp()))
                      .WithEachException(t =>
                      {
                          var libraryName = t.Input.library.identifier;
                          log(t.Exception, "Error generating C# for library : {libraryName}", libraryName);
                      })
                      .HandleExceptions(exceptionHandling);
        return cSharps;
    }

    /// <summary>
    /// Builds the library set definitions.
    /// </summary>
    /// <param name="librarySetExpressionBuilderScoped">The library set expression builder to use.</param>
    /// <param name="librarySet">The set of libraries to build definitions for.</param>
    /// <param name="logger">The logger to use for logging.</param>
    /// <param name="log">The action to log exceptions.</param>
    /// <param name="exceptionHandling">The exception handling strategy.</param>
    /// <returns>The dictionary of library set definitions.</returns>
    private static DefinitionDictionary<LambdaExpression> BuildLibrarySetDefinitions(
        LibrarySetExpressionBuilder librarySetExpressionBuilderScoped,
        LibrarySet librarySet,
        ILogger<ElmToAssemblyCompiler> logger,
        LogExceptionMessageAction log,
        ProcessBatchItemExceptionHandling exceptionHandling)
    {
        DefinitionDictionary<LambdaExpression> librarySetDefinitions = new();
        foreach (var (_, libraryDefinitions) in
                 librarySetExpressionBuilderScoped
                     .ProcessLibrarySetDeferred(librarySet: librarySet)
                     .Select(t =>
                     {
                         var libraryName = t.library.identifier;
                         logger.LogInformation("Generating definitions for library : {libraryName}", libraryName);
                         return t;
                     })
                     .TryProcessEach(t => (t.library, cSharp: t.generateLibraryDefinitions()))
                     .WithEachException(t =>
                     {
                         var libraryName = t.Input.library.identifier;
                         log(t.Exception, "Error generating definitions for library : {libraryName}", libraryName);
                     })
                     .HandleExceptions(exceptionHandling))
            librarySetDefinitions.Merge(libraryDefinitions);
        return librarySetDefinitions;
    }
}
