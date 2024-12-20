using System.Linq.Expressions;
using CqlSdkPrototype.Advanced;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Hl7.Cql.Runtime.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype.ElmToAssembly;

public class ElmCompilation :
    ILibraryAcceptor<ElmCompilation>,
    ILogAccessor<ElmCompilation>
{
    private readonly record struct State
    (
        IServiceProvider ServiceProvider,
        ILogger<ElmCompilation> Logger,
        ElmCompilationDictionary Entries,
        ElmCompilationCreateOptions Options);

    private readonly State _state;

    public IReadOnlyDictionary<ElmLibraryIdentifier, ElmVersionedLibraryIdentifier> VersionedIdentifiers =>
        _state.Entries
              .ToDictionary(kv => kv.Key.Identifier, kv => kv.Key);

    public IReadOnlyDictionary<ElmVersionedLibraryIdentifier, string> CSharpSourceCodes =>
        _state.Entries
              .Where(kv => kv.Value.CSharpSourceCode is not null)
              .ToDictionary(kv => kv.Key, kv => kv.Value.CSharpSourceCode!,
                            ElmVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer);

    public IReadOnlyDictionary<ElmVersionedLibraryIdentifier, byte[]> AssemblyBinaries =>
        _state.Entries
              .Where(kv => kv.Value.AssemblyBinary is not null)
              .ToDictionary(kv => kv.Key, kv => kv.Value.AssemblyBinary!,
                            ElmVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer);

    #region Nested Types

    internal readonly record struct ElmCompilationEntry
        (Library ElmLibrary, string? CSharpSourceCode = null, byte[]? AssemblyBinary = null);

    #endregion

    #region Construction

    internal ElmCompilation(
        IServiceProvider serviceProvider,
        ElmCompilationCreateOptions options)
        : this(new State(
                   serviceProvider,
                   serviceProvider.GetLogger<ElmCompilation>(),
                   ElmCompilationDictionary.Empty.WithComparers(
                       ElmVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer),
                   options)) { }

    private ElmCompilation(State state)
    {
        _state = state;
    }

    private ElmCompilation Mutate(
        ElmCompilationDictionary? entries = null)
    {
        return new ElmCompilation(_state with
        {
            Entries = entries ?? _state.Entries
        });
    }

    internal static ElmCompilation Create(
        IServiceProvider serviceProvider,
        ElmCompilationCreateOptions? options = null)
    {
        return new ElmCompilation(
            serviceProvider,
            options ?? ElmCompilationCreateOptions.Default);
    }

    #endregion

    #region Adding ELM Libraries

    ElmCompilation ILibraryAcceptor<ElmCompilation>.AcceptLibraries(IEnumerable<Library> libraries)
    {
        return AcceptLibraries(libraries);
    }

    private ElmCompilation AcceptLibraries(IEnumerable<Library> libraries)
    {
        var libraryCompilationsBuilder = _state.Entries.ToBuilder();
        var hasChanged = false;
        foreach (var library in libraries)
        {
            var versionedIdentifier = ElmVersionedLibraryIdentifier.FromVersionedIdentifier(library.identifier);

            if (libraryCompilationsBuilder.ContainsKey(versionedIdentifier))
            {
                _state.Logger.LogInformation("Skipping adding previous library to compilation: {versionedIdentifier}", versionedIdentifier);
                continue;
            }

            var libraryCompilation = new ElmCompilationEntry(library);
            libraryCompilationsBuilder.Add(versionedIdentifier, libraryCompilation);
            _state.Logger.LogInformation("Adding library to compilation: {versionedIdentifier}", versionedIdentifier);
            hasChanged = true;
        }

        return hasChanged
                   ? Mutate(entries: libraryCompilationsBuilder.ToImmutable())
                   : this;
    }

    #endregion

    #region Compilation

    internal ElmCompilation Compile()
    {
        if (_state.Entries.Values.All(lc => lc is { AssemblyBinary: not null }))
            return this;

        _state.Logger.LogInformation("Compiling ELM into C# and .NET Binaries");
        using var servicesScope = _state.ServiceProvider.CreateScope();
        LibrarySetExpressionBuilder librarySetExpressionBuilderScoped =
            servicesScope.ServiceProvider.GetLibrarySetExpressionBuilderScoped();
        AssemblyCompiler assemblyCompiler = servicesScope.ServiceProvider.GetAssemblyCompiler();
        Library[] libraries = _state.Entries.Values.Select(v => v.ElmLibrary).ToArray();
        LibrarySet librarySet = new LibrarySet("", libraries);

        var removedLibraries = librarySet.RemoveLibrariesWithMissingDependencies();
        foreach (var (id, _) in removedLibraries)
            _state.Logger.LogWarning("Removed library with missing dependencies: {id}", id);

        Func<LibrarySetExpressionBuilderContext.ProcessLibrarySetError, bool>?
            shouldThrowProcessLibraryException = null;
        Func<AssemblyCompiler.CompileError, bool>? shouldThrowCompileException = null;
        if (_state.Options.ShouldThrowError is { } fn)
        {
            shouldThrowProcessLibraryException = processLibrarySetError =>
            {
                var errorData = new ElmCompilationError(this, processLibrarySetError.Exception, "ProcessLibrarySet",
                                                        processLibrarySetError.Library.GetVersionedIdentifier(false));
                return fn(errorData);
            };
            shouldThrowCompileException = compileError =>
            {
                var errorData = new ElmCompilationError(this, compileError.Exception, "CompileLibrary",
                                                        compileError.Library.GetVersionedIdentifier(false));
                return fn(errorData);
            };
        }

        DefinitionDictionary<LambdaExpression> definitionDictionary =
            librarySetExpressionBuilderScoped.ProcessLibrarySet(
                librarySet, shouldThrowException: shouldThrowProcessLibraryException);

        IReadOnlyDictionary<string, AssemblyData> assemblyDatas =
            assemblyCompiler.Compile(librarySet, definitionDictionary,
                                     shouldThrowException: shouldThrowCompileException);

        var entriesBuilder = _state.Entries.ToBuilder();
        bool hasChanged = false;
        foreach (var (name, (assemblyBinary, sourceCodePerName)) in assemblyDatas)
        {
            var elmVersionedIdentifier = ElmVersionedLibraryIdentifier.Parse(name);
            var libraryCompilation = entriesBuilder[elmVersionedIdentifier];
            if (libraryCompilation.CSharpSourceCode is not null
                || libraryCompilation.AssemblyBinary is not null)
            {
                _state.Logger.LogInformation("Library already compiled: {versionedIdentifier}", elmVersionedIdentifier);
                continue;
            }

            var cSharpSourceCode = sourceCodePerName.Values.Single(); // We always expect a single source file
            libraryCompilation = libraryCompilation with
            {
                CSharpSourceCode = cSharpSourceCode,
                AssemblyBinary = assemblyBinary
            };
            entriesBuilder[elmVersionedIdentifier] = libraryCompilation;
            _state.Logger.LogInformation("Library compiled: {versionedIdentifier}", elmVersionedIdentifier);
            hasChanged = true;
        }

        return hasChanged
                   ? Mutate(entries: entriesBuilder.ToImmutable())
                   : this;
    }

    #endregion

    #region Saving Output

    #endregion

    ILogger<ElmCompilation> ILogAccessor<ElmCompilation>.Logger => _state.Logger;
}