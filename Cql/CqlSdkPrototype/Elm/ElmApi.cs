using CqlSdkPrototype.Elm.Extensibility;
using CqlSdkPrototype.Internal;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using ElmCompilationEntriesMap = System.Collections.Immutable.ImmutableDictionary<
    CqlSdkPrototype.CqlVersionedLibraryIdentifier,
    CqlSdkPrototype.Elm.Extensibility.ElmCompilationEntry>;
using CqlSdkPrototype.App;
using Hl7.Cql.Runtime.Hosting;

namespace CqlSdkPrototype.Elm;

public class ElmApi(ElmApiOptions options) :
    IElmApiExtensible<ElmApi>
{
    internal IElmApiExtensible<ElmApi> AsExtensible() => this;
    ElmApi IElmApiExtensible<ElmApi>.UseServices(Func<(ElmApi elmApi, ILogger<ElmApi> logger), ElmApi> action) => action((this, _state.Logger));
    public static ElmApi Create(ElmApiOptions options) => new(options);

    #region State

    private State _state = CreateState(options);

    ElmApiOptions IElmApiExtensible<ElmApi>.Options => _state.Options;
    IReadOnlyDictionary<CqlVersionedLibraryIdentifier, ElmCompilationEntry> IElmApiExtensible<ElmApi>.Entries => _state.Entries;

    private readonly record struct State(
        ElmApiOptions Options,
        ElmCompilationEntriesMap Entries,
        IServiceProvider ServiceProvider,
        ILogger<ElmApi> Logger,
        AssemblyCompiler AssemblyCompiler,
        CSharpCodeGenerator CSharpCodeGenerator)
    {
        private readonly ElmApiOptions _options = Options;

        public State(
            ElmApiOptions Options,
            ElmCompilationEntriesMap Entries) : this(Options, Entries, null!, null!, null!, null!)
        {
            this.Options = Options;
        }

        public ElmApiOptions Options
        {
            get => _options;
            init
            {
                _options = value;
                var services = new ServiceCollection();
                services.AddLogging(build => build.ClearProviders().UseOptions(value.LoggingOptions));
                services.AddElmApi();
                ServiceProvider = services.BuildServiceProvider();
                Logger = ServiceProvider.GetLogger<ElmApi>();
                AssemblyCompiler = ServiceProvider.GetAssemblyCompiler();
                CSharpCodeGenerator = ServiceProvider.GetCSharpCodeProcessor();
            }
        }

        public ScopedState CreateScopedState() => new(ServiceProvider.CreateScope());
    }

    internal class ScopedState(IServiceScope scope) : IDisposable
    {
        public LibrarySetExpressionBuilder LibrarySetExpressionBuilder { get; } = scope.ServiceProvider.GetLibrarySetExpressionBuilderScoped();

        public void Dispose() => scope.Dispose();
    }

    private static State CreateState(ElmApiOptions options)
    {
        var entries = ElmCompilationEntriesMap.Empty.WithComparers(CqlVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer);
        var state = new State(options, entries);
        return state;
    }

    private ElmApi WithEntries(
        ElmCompilationEntriesMap entries)
    {
        _state = _state with { Entries = entries };
        return this;
        // return new CqlApi(_state with { Entries = entries });
    }

    public ElmApi WithOptions(
        Func<ElmApiOptions, ElmApiOptions> replaceOptions)
    {
        var newOptions = replaceOptions(_state.Options);
        if (!ReferenceEquals(_state.Options, newOptions))
            // return new CqlApi(_state with { Options = newOptions });
            _state = _state with { Options = newOptions };
        return this;
    }

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

            var libraryCompilation = new ElmCompilationEntry(library);
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
        CSharpCodeGenerator cSharpCodeProcessor = _state.CSharpCodeGenerator;
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

            var cSharpSourceCode = sourceCodePerName.Values.Single(); // We always expect a single source file
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