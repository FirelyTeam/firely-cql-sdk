using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Internal;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Elm;

public class ElmToolkit :
    IElmFluentToolkit,
    IServiceProviderAccessorForTesting<ElmToolkit>
{
    public ElmToolkit(
        ILoggerFactory? loggerFactory = null,
        ElmToolkitSettings? options = null) : this(ElmApiState.Create(loggerFactory ?? NullLoggerFactory.Instance, options ?? ElmToolkitSettings.Default)) { }

    public IElmFluentToolkit AsFluent() => this;

    internal ElmToolkit(ElmApiState state) => _state = state; // Might make this public later. Used for testing now.

    private ElmApiState _state;

    public ElmToolkitSettings Settings => _state.Settings;

    public ElmToAssemblyConversionReadOnlyDictionary ElmToAssemblyConversions => _state.ElmToAssemblyItems;

    public ILoggerFactory LoggerFactory => _state.LoggerFactory;

    ElmToolkit IElmFluentToolkit.ElmToolkit => this;

    ServiceProvider IServiceProviderAccessorForTesting<ElmToolkit>.ServiceProvider => _state.ServiceProvider;

    IElmFluentToolkit IElmFluentToolkit.ReplaceSettings(Func<ElmToolkitSettings, ElmToolkitSettings> replace)
    {
        SetSettings(replace(_state.Settings));
        return this;
    }

    IElmFluentToolkit IElmFluentToolkit.AddElmLibraries(IEnumerable<Library> libraries)
    {
        AddElmLibraries(libraries);
        return this;
    }

    IElmFluentToolkit IElmFluentToolkit.ProcessElmToAssemblies()
    {
        ProcessElmToAssemblies();
        return this;
    }


    private void SetEntries(
        ElmToAssemblyConversionDictionary conversions)
    {
        _state = _state with { ElmToAssemblyItems = conversions };
    }

    private void SetSettings(
        ElmToolkitSettings settings)
    {
        if (!ReferenceEquals(_state.Settings, settings))
            _state = _state with { Settings = settings };
    }

    private void AddElmLibraries(IEnumerable<Library> libraries)
    {
        var entries = _state.ElmToAssemblyItems.ToBuilder();
        var hasChanged = false;
        foreach (var library in libraries)
        {
            var versionedIdentifier = CqlVersionedLibraryIdentifier.FromVersionedIdentifier(library.identifier);

            if (entries.TryGetValue(versionedIdentifier, out var existingVersionedIdentifier))
            {
                _state.Logger.LogInformation("Skipping replacing library {existingVersionedIdentifier} to compiler with new library: {versionedIdentifier}, ",
                                             existingVersionedIdentifier, versionedIdentifier);
                continue;
            }

            var libraryCompilation = new ElmToAssemblyConversion(library);
            entries.Add(versionedIdentifier, libraryCompilation);
            _state.Logger.LogInformation("Adding library to compiler: {versionedIdentifier}", versionedIdentifier);
            hasChanged = true;
        }

        if (hasChanged)
            SetEntries(conversions: entries.ToImmutable());
    }

    private void ProcessElmToAssemblies()
    {
        var entries = _state.ElmToAssemblyItems;
        if (entries.Values.All(predicate: lc => lc is { AssemblyBinary: not null })) return;

        using var servicesScope = _state.CreateScopedState();
        var logger = _state.Logger;
        logger.LogInformation(message: "Compiling ELM into C# and .NET Binaries");
        var exceptionHandling = _state.Settings.ProcessBatchItemExceptionHandling;
        var debugInformationFormat = _state.Settings.AssemblyCompilerDebugInformationFormat;
        AssemblyCompiler assemblyCompiler = _state.AssemblyCompiler;
        LibrarySetCSharpCodeGenerator cSharpCodeProcessor = _state.LibrarySetCSharpCodeGenerator;
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
            SetEntries(conversions: entriesBuilder.ToImmutable());
    }

    private static bool UpdateStateEntries(
        IEnumerable<(Library library, AssemblyDataWithSourceCode assemblyDataWithSourceCode)> assemblyDatas,
        ElmToAssemblyConversionDictionary.Builder entriesBuilder,
        ILogger<ElmToolkit> logger)
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
        ILogger<ElmToolkit> logger,
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
        ILogger<ElmToolkit> logger,
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
        ILogger<ElmToolkit> logger,
        LogExceptionMessageAction log,
        ProcessBatchItemExceptionHandling exceptionHandling)
    {
        var libraryDefinitions = librarySetExpressionBuilderScoped
                                 .ProcessLibrarySetDeferred(librarySet: librarySet)
                                 .Select(t =>
                                 {
                                     var libraryName = t.library.identifier;
                                     logger.LogInformation("Generating definitions for library : {libraryName}", libraryName);
                                     return t;
                                 })
                                 .TryProcessEach(t => (t.library, cSharp: t.generateLibraryDefinitions))
                                 .WithEachException(t =>
                                 {
                                     var libraryName = t.Input.library.identifier;
                                     log(t.Exception, "Error generating definitions for library : {libraryName}", libraryName);
                                 })
                                 .HandleExceptions(exceptionHandling);

        DefinitionDictionary<LambdaExpression> librarySetDefinitions = new();
        foreach (var (_, generateLibraryDefinitions) in libraryDefinitions)
            librarySetDefinitions.Merge(generateLibraryDefinitions());

        return librarySetDefinitions;
    }
}