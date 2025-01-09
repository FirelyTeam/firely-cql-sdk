using System.Linq.Expressions;
using CqlSdkPrototype.Advanced;
using CqlSdkPrototype.Elm.Extensibility;
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
    IElmApiExtensible<ElmApi>
{
    #region State

    private readonly State _state;
    ILogger<ElmApi> ILogAccessor<ElmApi>.Logger => _state.Logger;
    ElmApiOptions IElmApiExtensible<ElmApi>.Options => _state.Options;
    IReadOnlyDictionary<CqlVersionedLibraryIdentifier, ElmCompilationEntry> IElmApiExtensible<ElmApi>.Entries => _state.Entries;

    private readonly record struct State(
        ElmApiOptions Options,
        ElmCompilationEntriesMap Entries)
    {
        public ILogger<ElmApi> Logger { get; } = Options.ServiceProvider.GetLogger<ElmApi>();
        public AssemblyCompiler AssemblyCompiler { get; } = Options.ServiceProvider.GetAssemblyCompiler();
        public Scope CreateScope() => new(Options.ServiceProvider.CreateScope());
    }

    internal class Scope(IServiceScope scope) : IDisposable
    {
        public LibrarySetExpressionBuilder LibrarySetExpressionBuilder { get; } = scope.ServiceProvider.GetLibrarySetExpressionBuilderScoped();

        public void Dispose() => scope.Dispose();
    }

    #endregion

    #region Construction

    public static ElmApi Create(ElmApiOptions options)
    {
        var entries = ElmCompilationEntriesMap.Empty.WithComparers(CqlVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer);
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
        return new ElmApi(_state with { Entries = entries });
    }

    public ElmApi WithOptions(Func<ElmApiOptions, ElmApiOptions> replaceOptions)
    {
        var newOptions = replaceOptions(_state.Options);
        return ReferenceEquals(_state.Options, newOptions) ? this : new ElmApi(_state with { Options = newOptions });
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

    public ElmApi CompileAssemblies()
    {
        if (_state.Entries.Values.All(predicate: lc => lc is { AssemblyBinary: not null }))
            return this;

        _state.Logger.LogInformation(message: "Compiling ELM into C# and .NET Binaries");
        AssemblyCompiler assemblyCompiler = _state.AssemblyCompiler;
        using var servicesScope = _state.CreateScope();
        LibrarySetExpressionBuilder librarySetExpressionBuilderScoped = servicesScope.LibrarySetExpressionBuilder;
        Library[] libraries = _state.Entries.Values.Select(selector: v => v.ElmLibrary).ToArray();
        LibrarySet librarySet = new LibrarySet(name: "", libraries: libraries);

        var removedLibraries = librarySet.RemoveLibrariesWithMissingDependencies();
        foreach (var (id, _) in removedLibraries)
            _state.Logger.LogWarning(message: "Removed library with missing dependencies: {id}", args: id);

        DefinitionDictionary<LambdaExpression> definitionDictionary =
            librarySetExpressionBuilderScoped.ProcessLibrarySet(
                librarySet: librarySet,
                processLibraryExceptionHandling: _state.Options.ProcessBatchItemExceptionHandling);

        IReadOnlyDictionary<string, AssemblyDataWithSourceCode> assemblyDatas =
            assemblyCompiler.Compile(
                librarySet: librarySet,
                definitions: definitionDictionary,
                libraryCSharpWritingExceptionHandling: _state.Options.ProcessBatchItemExceptionHandling,
                libraryAssemblyWritingExceptionHandling: _state.Options.ProcessBatchItemExceptionHandling);

        var entriesBuilder = _state.Entries.ToBuilder();
        bool hasChanged = false;
        foreach (var (name, (assemblyBinary, sourceCodePerName, debugSymbols)) in assemblyDatas)
        {
            var elmVersionedIdentifier = CqlVersionedLibraryIdentifier.Parse(s: name);
            var libraryCompilation = entriesBuilder[key: elmVersionedIdentifier];
            if (libraryCompilation.CSharpSourceCode is not null
                || libraryCompilation.AssemblyBinary is not null)
            {
                _state.Logger.LogInformation(message: "Library already compiled: {versionedIdentifier}", args: elmVersionedIdentifier);
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
            _state.Logger.LogInformation(message: "Library compiled: {versionedIdentifier}", args: elmVersionedIdentifier);
            hasChanged = true;
        }

        return hasChanged
                   ? WithEntries(entries: entriesBuilder.ToImmutable())
                   : this;
    }

    #endregion
}