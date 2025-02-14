using CqlSdkPrototype.Elm.Fluent;
using CqlSdkPrototype.Elm.Internal;
using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Fhir.Model;

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
    /// Gets the logger factory used by extensions via <seealso cref="ElmToolkit.LoggerFactory"/>.
    /// </summary>
    internal ILoggerFactory LoggerFactory { get; }

    /// <summary>
    /// Gets the service provider used by tests via <seealso cref="ElmToolkit.ServiceProvider"/>.
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
    public void AddElmLibraries(IEnumerable<ElmLibrary> libraries)
    {
        var builder = _elmToAssemblyCompilations.ToBuilder();
        var hasChanged = false;
        foreach (var library in libraries)
        {
            var versionedIdentifier = CqlVersionedLibraryIdentifier.FromVersionedIdentifier(library.identifier);

            if (builder.TryGetValue(versionedIdentifier, out var existingVersionedIdentifier))
            {
                _services.Logger.LogWarning(
                    "Skipping replacing library {existingVersionedIdentifier} to compiler with new library: {versionedIdentifier}, ",
                    existingVersionedIdentifier, versionedIdentifier);
                continue;
            }

            var libraryCompilation = new ElmToAssemblyCompilation(library);
            builder.Add(versionedIdentifier, libraryCompilation);
            _services.Logger.LogInformation("Adding library to compiler: {versionedIdentifier}", versionedIdentifier);
            hasChanged = true;
        }

        if (hasChanged)
            SetConversions(elmToAssemblyCompilations: builder.ToImmutable());
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
        var exceptionHandling = Config.EnumerationExceptionHandling;
        var debugInformationFormat = Config.AssemblyCompilerDebugInformationFormat;
        AssemblyCompiler assemblyCompiler = _services.AssemblyCompiler;
        LibrarySetCSharpCodeGenerator cSharpCodeProcessor = _services.LibrarySetCSharpCodeGenerator;
        LibrarySetExpressionBuilder librarySetExpressionBuilderScoped = servicesScope.LibrarySetExpressionBuilder;
        ElmLibrary[] libraries = entries.Values.Select(selector: v => v.ElmLibrary).ToArray();
        LibrarySet librarySet = new LibrarySet(name: "", libraries: libraries);

        var removedLibraries = librarySet.RemoveLibrariesWithMissingDependencies();
        foreach (var (id, _) in removedLibraries)
            logger.LogWarning(message: "Removed library with missing dependencies: {id}", args: id);

        var librarySetDefinitions = BuildLibrarySetDefinitions(librarySetExpressionBuilderScoped, librarySet, logger, exceptionHandling);
        var cSharps = GenerateCSharp(cSharpCodeProcessor, librarySet, librarySetDefinitions, logger, exceptionHandling);
        var assemblyBinaries = CompileAssemblies(assemblyCompiler, librarySet, cSharps, debugInformationFormat, logger, exceptionHandling);

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
        IEnumerable<(ElmLibrary library, AssemblyBinaryWithSourceCode assemblyBinaryWithSourceCode)> assemblyBinaries,
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
    /// <param name="exceptionHandling">The exception handling strategy.</param>
    /// <returns>The compiled assemblies.</returns>
    private static IEnumerable<(ElmLibrary library, AssemblyBinaryWithSourceCode assemblyBinaryWithSourceCode)> CompileAssemblies(
        AssemblyCompiler assemblyCompiler,
        LibrarySet librarySet,
        IEnumerable<(ElmLibrary library, string cSharp)> cSharps,
        AssemblyCompilerDebugInformationFormat debugInformationFormat,
        ILogger<ElmToAssemblyCompiler> logger,
        EnumerationExceptionHandling exceptionHandling)
    {
        var logExceptions = logger.CreateLogExceptionHandler<(ElmLibrary library, string)>(
            exceptionHandling,
            (t, log) => log("Could not compile C# to .NET Assembly for {id}", t.library.GetVersionedIdentifier()!));

        return assemblyCompiler
            .CompileEachLibraryToAssemblies(
                cSharps.WithEach(t => logger.LogInformation("Compiling assembly for library : {libraryName}", t.library.identifier)),
                librarySet,
                debugInformationFormat,
                logExceptions)
            .WithEach(t => logger.LogInformation("Compiled assembly for library : {libraryName}", t.library.identifier));
    }

    /// <summary>
    /// Generates the C# code for the libraries.
    /// </summary>
    /// <param name="cSharpCodeProcessor">The C# code processor to use.</param>
    /// <param name="librarySet">The set of libraries to generate code for.</param>
    /// <param name="librarySetDefinitions">The definitions for the library set.</param>
    /// <param name="logger">The logger to use for logging.</param>
    /// <param name="exceptionHandling">The exception handling strategy.</param>
    /// <returns>The generated C# code.</returns>
    private static IEnumerable<(ElmLibrary library, string cSharp)> GenerateCSharp(
        LibrarySetCSharpCodeGenerator cSharpCodeProcessor,
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression> librarySetDefinitions,
        ILogger<ElmToAssemblyCompiler> logger,
        EnumerationExceptionHandling exceptionHandling)
    {
        var logExceptions = logger.CreateLogExceptionHandler<ElmLibrary>(
            exceptionHandling,
            (lib, log) => log("Could not generate definitions into C# for {id}", lib.GetVersionedIdentifier()!));

        return cSharpCodeProcessor
            .GenerateEachLibraryToCSharp(
                librarySet,
                librarySetDefinitions,
                logExceptions);
    }

    /// <summary>
    /// Builds the library set definitions.
    /// </summary>
    /// <param name="librarySetExpressionBuilderScoped">The library set expression builder to use.</param>
    /// <param name="librarySet">The set of libraries to build definitions for.</param>
    /// <param name="logger">The logger to use for logging.</param>
    /// <param name="exceptionHandling">The exception handling strategy.</param>
    /// <returns>The dictionary of library set definitions.</returns>
    private static DefinitionDictionary<LambdaExpression> BuildLibrarySetDefinitions(
        LibrarySetExpressionBuilder librarySetExpressionBuilderScoped,
        LibrarySet librarySet,
        ILogger<ElmToAssemblyCompiler> logger,
        EnumerationExceptionHandling exceptionHandling)
    {
        var logExceptions = logger.CreateLogExceptionHandler<ElmLibrary>(
            exceptionHandling,
            (lib, log) => log("Could not generate ELM into definitions for {id}", lib.GetVersionedIdentifier()!));

        DefinitionDictionary<LambdaExpression> librarySetDefinitions = new();
        librarySetExpressionBuilderScoped
            .BuildEachLibraryDefinitions(
                librarySet,
                librarySetDefinitions,
                exceptionHandler: logExceptions)
            .ForEach(); // Important to enumerate
        return librarySetDefinitions;
    }
}