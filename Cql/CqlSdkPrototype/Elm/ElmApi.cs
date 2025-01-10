using System.Linq.Expressions;
using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Elm.Extensibility;
using CqlSdkPrototype.Internal;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Hl7.Cql.Runtime.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ElmCompilationEntriesMap = System.Collections.Immutable.ImmutableDictionary<
    CqlSdkPrototype.CqlVersionedLibraryIdentifier,
    CqlSdkPrototype.Elm.Extensibility.ElmCompilationEntry>;

namespace CqlSdkPrototype.Elm;

public class ElmApi :
    IElmApi<ElmApi>
{
    #region State

    private State _state;
    ElmApiOptions IElmApi<ElmApi>.Options => _state.Options;
    IReadOnlyDictionary<CqlVersionedLibraryIdentifier, ElmCompilationEntry> IElmApi<ElmApi>.Entries => _state.Entries;

    private readonly record struct State(
        ElmApiOptions Options,
        ElmCompilationEntriesMap Entries)
    {
        public ILogger<ElmApi> Logger { get; } = Options.ServiceProvider.GetLogger<ElmApi>();
        public AssemblyCompiler AssemblyCompiler { get; } = Options.ServiceProvider.GetAssemblyCompiler();
        public CSharpCodeGenerator CSharpCodeGenerator { get; } = Options.ServiceProvider.GetLibrarySetDefinitionsToCSharpCodeProcessor();
        public Scope CreateScope() => new(Options.ServiceProvider.CreateScope());
    }

    internal class Scope(IServiceScope scope) : IDisposable
    {
        public LibrarySetExpressionBuilder LibrarySetExpressionBuilder { get; } = scope.ServiceProvider.GetLibrarySetExpressionBuilderScoped();

        public void Dispose() => scope.Dispose();
    }

    #endregion

    #region Construction

    public static ElmApi Create(IServiceProvider serviceProvider)
    {
        var entries = ElmCompilationEntriesMap.Empty.WithComparers(CqlVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer);
        var options = ElmApiOptions.Create(serviceProvider);
        var state = new State(options, entries);
        return new ElmApi(state);
    }

    private ElmApi(State state)
    {
        _state = state;
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

    public ElmApi Compile(Action<ElmCompileResult>? result = null)
    {
        var entries = _state.Entries;
        if (entries.Values.All(predicate: lc => lc is { AssemblyBinary: not null }))
            return this;

        using var servicesScope = _state.CreateScope();
        var logger = _state.Logger;
        logger.LogInformation(message: "Compiling ELM into C# and .NET Binaries");
        var exceptionHandling = _state.Options.ProcessBatchItemExceptionHandling;
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
                      .GenerateCSharpV2(librarySet, definitions)
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
            .Compile(librarySet, cSharps)
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