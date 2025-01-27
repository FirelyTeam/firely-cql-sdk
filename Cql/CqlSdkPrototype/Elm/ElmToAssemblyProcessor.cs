using CqlSdkPrototype.Elm.Internal;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Internal;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Elm;

public class ElmToAssemblyProcessor
{
    public ElmToAssemblyProcessor(
        ILoggerFactory? loggerFactory = null,
        ElmToAssemblySettings? settings = null)
    {
        settings ??= ElmToAssemblySettings.Default;
        loggerFactory ??= NullLoggerFactory.Instance;
        _conversions = ElmToAssemblyConversionDictionary.Empty;
        _settings = settings;
        _services = ElmToAssemblyServices.Create(_settings, loggerFactory);
    }

    private ElmToAssemblyConversionDictionary _conversions;
    private ElmToAssemblyServices _services;
    private ElmToAssemblySettings _settings;


    /// <summary>
    /// For testing purposes only.
    /// </summary>
    internal ServiceProvider ServiceProvider => _services.ServiceProvider;

    public ElmToAssemblySettings Settings => _settings;

    public ElmToAssemblyConversionReadOnlyDictionary ElmToAssemblyConversions => _conversions;

    private void SetConversions(
        ElmToAssemblyConversionDictionary conversions)
    {
        _conversions = conversions;
    }

    public void SetSettings(
        ElmToAssemblySettings settings)
    {
        if (_settings == settings)
            return;

        _services.ServiceProvider.Dispose();
        _settings = settings;
        _services = ElmToAssemblyServices.Create(settings, _services.LoggerFactory);
    }

    public void AddElmLibraries(IEnumerable<Library> libraries)
    {
        var entries = _conversions.ToBuilder();
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

            var libraryCompilation = new ElmToAssemblyConversion(library);
            entries.Add(versionedIdentifier, libraryCompilation);
            _services.Logger.LogInformation("Adding library to compiler: {versionedIdentifier}", versionedIdentifier);
            hasChanged = true;
        }

        if (hasChanged)
            SetConversions(conversions: entries.ToImmutable());
    }

    public void ProcessElmToAssemblies()
    {
        var entries = _conversions;
        if (entries.Values.All(predicate: lc => lc is { AssemblyBinary: not null })) return;

        using var servicesScope = _services.CreateScopedState();
        var logger = _services.Logger;
        logger.LogInformation(message: "Compiling ELM into C# and .NET Binaries");
        var exceptionHandling = _settings.ProcessBatchItemExceptionHandling;
        var debugInformationFormat = _settings.AssemblyCompilerDebugInformationFormat;
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
        if (hasChanged)
            SetConversions(conversions: entriesBuilder.ToImmutable());
    }

    private static bool UpdateStateEntries(
        IEnumerable<(Library library, AssemblyDataWithSourceCode assemblyDataWithSourceCode)> assemblyDatas,
        ElmToAssemblyConversionDictionary.Builder entriesBuilder,
        ILogger<ElmToAssemblyProcessor> logger)
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
        ILogger<ElmToAssemblyProcessor> logger,
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
        ILogger<ElmToAssemblyProcessor> logger,
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
        ILogger<ElmToAssemblyProcessor> logger,
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