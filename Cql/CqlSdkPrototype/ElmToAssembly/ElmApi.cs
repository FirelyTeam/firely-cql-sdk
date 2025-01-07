using System.Linq.Expressions;
using CqlSdkPrototype.Advanced;
using CqlSdkPrototype.ElmToAssembly.Advanced;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Hl7.Cql.Runtime.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using ElmCompilationEntriesMap = System.Collections.Immutable.ImmutableDictionary<CqlSdkPrototype.CqlVersionedLibraryIdentifier, CqlSdkPrototype.ElmToAssembly.ElmApi.ElmCompilationEntry>;

namespace CqlSdkPrototype.ElmToAssembly;

public class ElmApi :
    IElmApiBase<ElmApi>,
    ILogAccessor<ElmApi>
{
    private readonly State _state;

    public ElmApiOptions Options => _state.Options;

    public IReadOnlyDictionary<CqlLibraryIdentifier, CqlVersionedLibraryIdentifier> GetVersionedIdentifiers() =>
        _state.Entries
              .ToDictionary(kv => kv.Key.Identifier, kv => kv.Key);

    public IReadOnlyDictionary<CqlVersionedLibraryIdentifier, string> GetCSharpSourceCodes() =>
        _state.Entries
              .Where(kv => kv.Value.CSharpSourceCode is not null)
              .ToDictionary(kv => kv.Key, kv => kv.Value.CSharpSourceCode!,
                            CqlVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer);

    public IReadOnlyDictionary<CqlVersionedLibraryIdentifier, AssemblyData> GetAssemblyBinaries() =>
        _state.Entries
              .Where(kv => kv.Value.AssemblyBinary is not null)
              .ToDictionary(kv => kv.Key,
                            kv => new AssemblyData(kv.Value.AssemblyBinary!, kv.Value.DebugSymbolsBinary),
                            CqlVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer);

    #region Nested Types

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

    internal readonly record struct ElmCompilationEntry
        (Library ElmLibrary, string? CSharpSourceCode = null, byte[]? AssemblyBinary = null, byte[]? DebugSymbolsBinary = null);

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

    private ElmApi Mutate(
        ElmCompilationEntriesMap? entries = null)
    {
        return new ElmApi(_state with
        {
            Entries = entries ?? _state.Entries
        });
    }

    #endregion

    #region Adding ELM Libraries

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
                   ? Mutate(entries: entries.ToImmutable())
                   : this;
    }

    #endregion

    #region Processing

    internal ElmApi CompileAssemblies()
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
                   ? Mutate(entries: entriesBuilder.ToImmutable())
                   : this;
    }

    #endregion

    ILogger<ElmApi> ILogAccessor<ElmApi>.Logger => _state.Logger;
}