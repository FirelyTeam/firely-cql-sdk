using CqlSdkPrototype.Elm.Extensibility;
using CqlSdkPrototype.Elm.Internal;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Internal;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging.Abstractions;
using ElmCompilationEntriesMap = System.Collections.Immutable.ImmutableDictionary<
    CqlSdkPrototype.Infrastructure.CqlVersionedLibraryIdentifier,
    CqlSdkPrototype.Elm.Extensibility.ElmApiStateEntry>;

namespace CqlSdkPrototype.Elm;

public class ElmApi :
    IElmApiExtendable<ElmApi>,
    IElmApiInternal<ElmApi>
{
    public ElmApi(
        ILoggerFactory? loggerFactory = null,
        ElmApiOptions? options = null) : this(ElmApiState.Create(loggerFactory ?? NullLoggerFactory.Instance, options ?? ElmApiOptions.Default))
    {
    }

    internal ElmApi(ElmApiState state) => _state = state; // Might make this public later. Used for testing now.

    #region State

    private ElmApiState _state;

    ElmApiOptions IElmApiExtendable<ElmApi>.Options => _state.Options;
    IReadOnlyDictionary<CqlVersionedLibraryIdentifier, ElmApiStateEntry> IElmApiExtendable<ElmApi>.Entries => _state.Entries;

    private ElmApi WithEntries(
        ElmCompilationEntriesMap entries)
    {
        _state = _state with { Entries = entries };
        return this;
    }

    public ElmApi WithOptions(
        Func<ElmApiOptions, ElmApiOptions> replaceOptions)
    {
        var newOptions = replaceOptions(_state.Options);
        if (!ReferenceEquals(_state.Options, newOptions))
            _state = _state with { Options = newOptions };
        return this;
    }

    TResult IElmApiExtendable<ElmApi>.UseLogger<TResult>(Func<ElmApi, ILogger<ElmApi>, TResult> action) => action(this, _state.Logger);
    ElmApiState IElmApiInternal<ElmApi>.State => _state;
    ILoggerFactory IElmApiExtendable<ElmApi>.LoggerFactory => _state.LoggerFactory;

    #endregion

    #region Input (ELM Libraries)

    public ElmApi AddElmLibraries(IEnumerable<Library> libraries)
    {
        var entries = _state.Entries.ToBuilder();
        var hasChanged = false;
        foreach (var library in libraries)
        {
            var versionedIdentifier = CqlVersionedLibraryIdentifier.FromVersionedIdentifier(library.identifier);

            if (entries.TryGetValue(versionedIdentifier, out var existingVersionedIdentifier))
            {
                _state.Logger.LogInformation("Skipping replacing library {existingVersionedIdentifier} to compiler with new library: {versionedIdentifier}, ", existingVersionedIdentifier, versionedIdentifier);
                continue;
            }

            var libraryCompilation = new ElmApiStateEntry(library);
            entries.Add(versionedIdentifier, libraryCompilation);
            _state.Logger.LogInformation("Adding library to compiler: {versionedIdentifier}", versionedIdentifier);
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
        var entries = _state.Entries;
        if (entries.Values.All(predicate: lc => lc is { AssemblyBinary: not null }))
            return this;

        using var servicesScope = _state.CreateScopedState();
        var logger = _state.Logger;
        logger.LogInformation(message: "Compiling ELM into C# and .NET Binaries");
        var exceptionHandling = _state.Options.ProcessBatchItemExceptionHandling;
        var debugInformationFormat = _state.Options.AssemblyCompilerDebugInformationFormat;
        AssemblyCompiler assemblyCompiler = _state.AssemblyCompiler;
        LibrarySetCSharpCodeGenerator cSharpCodeProcessor = _state.LibrarySetCSharpCodeGenerator;
        LibrarySetExpressionBuilder librarySetExpressionBuilderScoped = servicesScope.LibrarySetExpressionBuilder;
        Library[] libraries = entries.Values.Select(selector: v => v.ElmLibrary).ToArray();
        LibrarySet librarySet = new LibrarySet(name: "", libraries: libraries);

        var removedLibraries = librarySet.RemoveLibrariesWithMissingDependencies();
        foreach (var (id, _) in removedLibraries)
            logger.LogWarning(message: "Removed library with missing dependencies: {id}", args: id);

        DefinitionDictionary<LambdaExpression> definitions =
            librarySetExpressionBuilderScoped.ProcessLibrarySet(
                librarySet: librarySet,
                processLibraryExceptionHandling: exceptionHandling);

        LogExceptionMessageAction log = logger.GetLogExceptionMessageAction(exceptionHandling);

        var cSharps = cSharpCodeProcessor
                      .GenerateCSharpDeferred(librarySet, definitions)
                      .Select(t =>
                      {
                          var libraryName = t.library.identifier;
                          logger.LogInformation("Generating C# for library : {libraryName}", libraryName);
                          return t;
                      })
                      .TryProcessEach(t => (t.library, cSharp:t.generateCSharp()))
                      .WithEachException(t =>
                      {
                          var libraryName = t.Input.library.identifier;
                          log(t.Exception, "Error generating C# for library : {libraryName}", libraryName);
                      })
                      .HandleExceptions(exceptionHandling);

        var assemblyDatas = assemblyCompiler
            .CompileDeferred(librarySet, cSharps, debugInformationFormat)
            .Select(t =>
            {
                var libraryName = t.library.identifier;
                logger.LogInformation("Compiling assembly for library : {libraryName}", libraryName);
                return t;
            })
            .TryProcessEach(t => (t.library, assemblyDataWithSourceCode:t.generateAssemblyDataWithSourceCode()))
            .WithEachException(t =>
            {
                var libraryName = t.Input.library.identifier;
                log(t.Exception, "Error compiling assembly for library: {libraryName}", libraryName);
            })
            .HandleExceptions(exceptionHandling)
            //.ToArray()
            ;

        var entriesBuilder = entries.ToBuilder();
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

        return hasChanged
                   ? WithEntries(entries: entriesBuilder.ToImmutable())
                   : this;
    }

    #endregion
}