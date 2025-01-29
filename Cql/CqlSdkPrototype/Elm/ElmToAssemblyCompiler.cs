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

public sealed class ElmToAssemblyCompiler
{
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

    /// <remarks>
    /// Used by extensions on the <seealso cref="FluentElmToolkit"/> to access the logger factory.
    /// </remarks>>
    internal ILoggerFactory LoggerFactory { get; }

    /// <remarks>
    /// Used by tests on the <seealso cref="FluentElmToolkit"/> to access the service provider.
    /// </remarks>>
    internal ServiceProvider ServiceProvider => _services.ServiceProvider;

    public ElmToAssemblyCompilerConfig Config { get; private set; }

    public ElmToAssemblyCompilationReadOnlyDictionary ElmToAssemblyCompilations => _elmToAssemblyCompilations;

    private void SetElmToAssemblyCompilations(
        ElmToAssemblyCompilationDictionary elmToAssemblyCompilations)
    {
        _elmToAssemblyCompilations = elmToAssemblyCompilations;
    }

    public void Reconfigure(
        ElmToAssemblyCompilerConfig config)
    {
        if (Config == config)
            return;

        _services.ServiceProvider.Dispose();
        Config = config;
        _services = ElmToAssemblyProcessorServices.Create(LoggerFactory, config);
    }

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
            SetElmToAssemblyCompilations(elmToAssemblyCompilations: entries.ToImmutable());
    }

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
            SetElmToAssemblyCompilations(elmToAssemblyCompilations: entriesBuilder.ToImmutable());
    }

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
                            .HandleExceptions(exceptionHandling)
            //.ToArray()
            ;
        return assemblyBinaries;
    }

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