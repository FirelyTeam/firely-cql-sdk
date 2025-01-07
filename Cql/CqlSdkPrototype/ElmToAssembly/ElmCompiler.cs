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

using ElmCompilationEntriesMap = System.Collections.Immutable.ImmutableDictionary<CqlSdkPrototype.CqlVersionedLibraryIdentifier, CqlSdkPrototype.ElmToAssembly.ElmCompiler.ElmCompilationEntry>;

namespace CqlSdkPrototype.ElmToAssembly;

public class ElmCompiler :
    IElmLibraryAcceptor<ElmCompiler>,
    ILogAccessor<ElmCompiler>
{
    private readonly State _state;

    public IReadOnlyDictionary<CqlLibraryIdentifier, CqlVersionedLibraryIdentifier> GetVersionedIdentifiers() =>
        _state.Entries
              .ToDictionary(kv => kv.Key.Identifier, kv => kv.Key);

    public IReadOnlyDictionary<CqlVersionedLibraryIdentifier, string> GetCSharpSourceCodes() =>
        _state.Entries
              .Where(kv => kv.Value.CSharpSourceCode is not null)
              .ToDictionary(kv => kv.Key, kv => kv.Value.CSharpSourceCode!,
                            CqlVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer);

    public IReadOnlyDictionary<CqlVersionedLibraryIdentifier, (byte[] assemblyBytes, byte[]? symbolsBytes)> GetAssemblyBinaries() =>
        _state.Entries
              .Where(kv => kv.Value.AssemblyBinary is not null)
              .ToDictionary(kv => kv.Key,
                            kv => (kv.Value.AssemblyBinary!, kv.Value.DebugSymbolsBinary),
                            CqlVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer);

    #region Nested Types

    private readonly record struct State(
        IServiceProvider ServiceProvider,
        ILogger<ElmCompiler> Logger,
        ElmCompilationEntriesMap Entries,
        ElmCompilationCreateOptions Options);

    internal readonly record struct ElmCompilationEntry
        (Library ElmLibrary, string? CSharpSourceCode = null, byte[]? AssemblyBinary = null, byte[]? DebugSymbolsBinary = null);

    #endregion

    #region Construction

    internal ElmCompiler(
        IServiceProvider serviceProvider,
        ElmCompilationCreateOptions options)
        : this(new State(
                   serviceProvider,
                   serviceProvider.GetLogger<ElmCompiler>(),
                   ElmCompilationEntriesMap.Empty.WithComparers(
                       CqlVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer),
                   options)) { }

    private ElmCompiler(State state)
    {
        _state = state;
    }

    private ElmCompiler Mutate(
        ElmCompilationEntriesMap? entries = null)
    {
        return new ElmCompiler(_state with
        {
            Entries = entries ?? _state.Entries
        });
    }

    internal static ElmCompiler Create(
        IServiceProvider serviceProvider,
        ElmCompilationCreateOptions? options = null)
    {
        return new ElmCompiler(
            serviceProvider,
            options ?? ElmCompilationCreateOptions.Default);
    }

    #endregion

    #region Adding ELM Libraries

    ElmCompiler IElmLibraryAcceptor<ElmCompiler>.AcceptLibraries(IEnumerable<Library> libraries)
    {
        return AcceptLibraries(libraries);
    }

    private ElmCompiler AcceptLibraries(IEnumerable<Library> libraries)
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

    #region Compilation

    internal ElmCompiler Compile()
    {
        if (_state.Entries.Values.All(predicate: lc => lc is { AssemblyBinary: not null }))
            return this;

        _state.Logger.LogInformation(message: "Compiling ELM into C# and .NET Binaries");
        using var servicesScope = _state.ServiceProvider.CreateScope();
        LibrarySetExpressionBuilder librarySetExpressionBuilderScoped = servicesScope.ServiceProvider.GetLibrarySetExpressionBuilderScoped();
        AssemblyCompiler assemblyCompiler = servicesScope.ServiceProvider.GetAssemblyCompiler();
        Library[] libraries = _state.Entries.Values.Select(selector: v => v.ElmLibrary).ToArray();
        LibrarySet librarySet = new LibrarySet(name: "", libraries: libraries);

        var removedLibraries = librarySet.RemoveLibrariesWithMissingDependencies();
        foreach (var (id, _) in removedLibraries)
            _state.Logger.LogWarning(message: "Removed library with missing dependencies: {id}", args: id);

        DefinitionDictionary<LambdaExpression> definitionDictionary =
            librarySetExpressionBuilderScoped.ProcessLibrarySet(
                librarySet: librarySet,
                processLibraryExceptionHandling: _state.Options.ProcessBatchItemExceptionHandling);

        IReadOnlyDictionary<string, AssemblyData> assemblyDatas =
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

    ILogger<ElmCompiler> ILogAccessor<ElmCompiler>.Logger => _state.Logger;
}