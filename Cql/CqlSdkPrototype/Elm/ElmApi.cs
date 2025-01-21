using CqlSdkPrototype.Elm.Extensibility;
using CqlSdkPrototype.Elm.Internal;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Internal;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Elm;

public sealed class ElmApi :
    IElmApiExtendable,
    IElmApiInternal
{
    public ElmApi(
        ILoggerFactory? loggerFactory = null,
        ElmApiOptions? options = null)
    {
        options ??= ElmApiOptions.Default;
        var entries = ElmApiStateEntryDictionary.Empty.WithComparers(CqlVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer);
        _entries = entries;
        _services = ElmApiServices.Create(loggerFactory);
        _options = options;
    }

    #region State

    private ElmApiServices _services;
    private ElmApiStateEntryDictionary _entries;
    private ElmApiOptions _options;

    public ElmApiOptions Options => _options;
    public IReadOnlyDictionary<CqlVersionedLibraryIdentifier, ElmApiStateEntry> Entries => _entries;

    private ElmApi WithEntries(
        ElmApiStateEntryDictionary entries)
    {
        if (ReferenceEquals(_entries, entries))
            return this;

        _entries = entries;
        return this;
    }

    public ElmApi WithOptions(
        Func<ElmApiOptions, ElmApiOptions> replaceOptions)
    {
        var newOptions = replaceOptions(_options);
        if (ReferenceEquals(_options, newOptions))
            return this;

        _options = newOptions;
        _services.ServiceProvider.Dispose();
        _services = ElmApiServices.Create(_services.LoggerFactory);
        return this;
    }

    ElmApiServices IElmApiInternal.Services => _services;
    public ILoggerFactory LoggerFactory => _services.LoggerFactory;

    #endregion

    #region Input (ELM Libraries)

    public ElmApi AddElmLibraries(IEnumerable<Library> libraries)
    {
        var entries = _entries.ToBuilder();
        var hasChanged = false;
        foreach (var library in libraries)
        {
            var versionedIdentifier = CqlVersionedLibraryIdentifier.FromVersionedIdentifier(library.identifier);

            if (entries.TryGetValue(versionedIdentifier, out var existingVersionedIdentifier))
            {
                _services.Logger.LogInformation("Skipping replacing library {existingVersionedIdentifier} to compiler with new library: {versionedIdentifier}, ",
                                             existingVersionedIdentifier, versionedIdentifier);
                continue;
            }

            var libraryCompilation = new ElmApiStateEntry(library);
            entries.Add(versionedIdentifier, libraryCompilation);
            _services.Logger.LogInformation("Adding library to compiler: {versionedIdentifier}", versionedIdentifier);
            hasChanged = true;
        }

        return hasChanged
                   ? WithEntries(entries: entries.ToImmutable())
                   : this;
    }

    #endregion

    #region Processing

    public ElmApi Compile()
    {
        var entries = _entries;
        if (entries.Values.All(predicate: lc => lc is { AssemblyBinary: not null }))
            return this;

        using var servicesScope = _services.CreateScopedState();
        var logger = _services.Logger;
        logger.LogInformation(message: "Compiling ELM into C# and .NET Binaries");
        var exceptionHandling = _options.ProcessBatchItemExceptionHandling;
        var debugInformationFormat = _options.AssemblyCompilerDebugInformationFormat;
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

        var assemblyDatas = CompileAssemblies(assemblyCompiler, librarySet, cSharps, debugInformationFormat, logger, log, exceptionHandling);

        var entriesBuilder = entries.ToBuilder();
        var hasChanged = UpdateStateEntries(assemblyDatas, entriesBuilder, logger);
        return hasChanged ? WithEntries(entries: entriesBuilder.ToImmutable()) : this;
    }

    private static bool UpdateStateEntries(
        IEnumerable<(Library library, AssemblyDataWithSourceCode assemblyDataWithSourceCode)> assemblyDatas,
        ElmApiStateEntryDictionary.Builder entriesBuilder,
        ILogger<ElmApi> logger)
    {
        bool hasChanged = false;
        foreach (var (library, (assemblyBinary, sourceCodePerName, debugSymbols)) in assemblyDatas)
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

    private static IEnumerable<(Library library, AssemblyDataWithSourceCode assemblyDataWithSourceCode)> CompileAssemblies(
        AssemblyCompiler assemblyCompiler,
        LibrarySet librarySet,
        IEnumerable<(Library library, string cSharp)> cSharps,
        AssemblyCompilerDebugInformationFormat debugInformationFormat,
        ILogger<ElmApi> logger,
        LogExceptionMessageAction log,
        ProcessBatchItemExceptionHandling exceptionHandling)
    {
        var assemblyDatas = assemblyCompiler
                            .CompileDeferred(librarySet, cSharps, debugInformationFormat)
                            .Select(t =>
                            {
                                var libraryName = t.library.identifier;
                                logger.LogInformation("Compiling assembly for library : {libraryName}", libraryName);
                                return t;
                            })
                            .TryProcessEach(t => (t.library, assemblyDataWithSourceCode: t.generateAssemblyDataWithSourceCode()))
                            .WithEachException(t =>
                            {
                                var libraryName = t.Input.library.identifier;
                                log(t.Exception, "Error compiling assembly for library: {libraryName}", libraryName);
                            })
                            .HandleExceptions(exceptionHandling)
            //.ToArray()
            ;
        return assemblyDatas;
    }

    private static IEnumerable<(Library library, string cSharp)> GenerateCSharp(
        LibrarySetCSharpCodeGenerator cSharpCodeProcessor,
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression> librarySetDefinitions,
        ILogger<ElmApi> logger,
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
        ILogger<ElmApi> logger,
        LogExceptionMessageAction log,
        ProcessBatchItemExceptionHandling exceptionHandling)
    {
        DefinitionDictionary<LambdaExpression> librarySetDefinitions = new();
        librarySetExpressionBuilderScoped
            .ProcessLibrarySetDeferred(librarySet: librarySet)
            .Select(t =>
            {
                var libraryName = t.library.identifier;
                logger.LogInformation("Generating definitions for library : {libraryName}", libraryName);
                return t;
            })
            .TryProcessEach(t =>
            {
                librarySetDefinitions.Merge(t.generateLibraryDefinitions());
                return t.library;
            })
            .WithEachException(t =>
            {
                var libraryName = t.Input.library.identifier;
                log(t.Exception, "Error generating definitions for library : {libraryName}", libraryName);
            })
            .HandleExceptions(exceptionHandling)
            .Count() // Must enumerate all
            ;
        return librarySetDefinitions;
    }

    #endregion
}