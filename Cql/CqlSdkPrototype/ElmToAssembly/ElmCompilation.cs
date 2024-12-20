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
    private readonly ServiceProvider _serviceProvider;
    private readonly ElmCompilationDictionary _entries;
    private readonly ElmCompilationCreateOptions _options;

    public IReadOnlyDictionary<ElmLibraryIdentifier, ElmVersionedLibraryIdentifier> VersionedIdentifiers =>
        _entries
            .ToDictionary(kv => kv.Key.Identifier, kv => kv.Key);

    public IReadOnlyDictionary<ElmVersionedLibraryIdentifier, string> CSharpSourceCodes =>
        _entries
            .Where(kv => kv.Value.CSharpSourceCode is not null)
            .ToDictionary(kv => kv.Key, kv => kv.Value.CSharpSourceCode!,
                          ElmVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer);

    public IReadOnlyDictionary<ElmVersionedLibraryIdentifier, byte[]> AssemblyBinaries =>
        _entries
            .Where(kv => kv.Value.AssemblyBinary is not null)
            .ToDictionary(kv => kv.Key, kv => kv.Value.AssemblyBinary!,
                          ElmVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer);

    #region Nested Types

    internal readonly record struct ElmCompilationEntry
        (Library ElmLibrary, string? CSharpSourceCode = null, byte[]? AssemblyBinary = null);

    #endregion

    #region Construction

    internal ElmCompilation(
        ElmCompilationCreateOptions options,
        ServiceProvider serviceProvider)
    {
        _options = options;
        _serviceProvider = serviceProvider;
        _entries = ElmCompilationDictionary.Empty.WithComparers(
            ElmVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer);
    }

    private ElmCompilation(
        ElmCompilation source,
        ElmCompilationDictionary? entries,
        ElmCompilationCreateOptions? options)
    {
        _serviceProvider = source._serviceProvider;
        _entries = entries ?? source._entries;
        _options = options ?? source._options;
    }

    private ElmCompilation Mutate(
        ElmCompilationDictionary? entries = null,
        ElmCompilationCreateOptions? options = null)
    {
        return new ElmCompilation(this, entries, options);
    }

    internal static ElmCompilation Create(ElmCompilationCreateOptions? options = null)
    {
        return (options ?? ElmCompilationCreateOptions.Default).CreateElmCompilation();
    }

    #endregion

    #region Adding ELM Libraries

    ElmCompilation ILibraryAcceptor<ElmCompilation>.AcceptLibraries(IEnumerable<Library> libraries)
    {
        return AcceptLibraries(libraries);
    }

    private ElmCompilation AcceptLibraries(IEnumerable<Library> libraries)
    {
        var libraryCompilationsBuilder = _entries.ToBuilder();
        var hasChanged = false;
        foreach (var library in libraries)
        {
            var versionedIdentifier = ElmVersionedLibraryIdentifier.FromVersionedIdentifier(library.identifier);

            if (libraryCompilationsBuilder.ContainsKey(versionedIdentifier))
            {
                Console.WriteLine($"Skipping adding previous library to compilation: {versionedIdentifier}");
                continue;
            }

            var libraryCompilation = new ElmCompilationEntry(library);
            libraryCompilationsBuilder.Add(versionedIdentifier, libraryCompilation);
            Console.WriteLine($"Adding library to compilation: {versionedIdentifier}");
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
        if (_entries.Values.All(lc => lc is { AssemblyBinary: not null }))
            return this;

        Console.WriteLine("Compiling ELM into C# and .NET Binaries");
        using var servicesScope = _serviceProvider.CreateScope();
        LibrarySetExpressionBuilder librarySetExpressionBuilderScoped =
            servicesScope.ServiceProvider.GetLibrarySetExpressionBuilderScoped();
        AssemblyCompiler assemblyCompiler = servicesScope.ServiceProvider.GetAssemblyCompiler();
        Library[] libraries = _entries.Values.Select(v => v.ElmLibrary).ToArray();
        LibrarySet librarySet = new LibrarySet("", libraries);

        //if (_options.ShouldThrowError)
        Func<LibrarySetExpressionBuilderContext.ProcessLibrarySetError, bool>?
            shouldThrowProcessLibraryException = null;
        Func<AssemblyCompiler.CompileError, bool>? shouldThrowCompileException = null;
        if (_options.ShouldThrowError is { } fn)
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

        var entriesBuilder = _entries.ToBuilder();
        bool hasChanged = false;
        foreach (var (name, (assemblyBinary, sourceCodePerName)) in assemblyDatas)
        {
            var elmVersionedIdentifier = ElmVersionedLibraryIdentifier.Parse(name);
            var libraryCompilation = entriesBuilder[elmVersionedIdentifier];
            if (libraryCompilation.CSharpSourceCode is not null
                || libraryCompilation.AssemblyBinary is not null)
            {
                Console.WriteLine($"Library already compiled: {elmVersionedIdentifier}");
                continue;
            }

            var cSharpSourceCode = sourceCodePerName.Values.Single(); // We always expect a single source file
            libraryCompilation = libraryCompilation with
            {
                CSharpSourceCode = cSharpSourceCode,
                AssemblyBinary = assemblyBinary
            };
            entriesBuilder[elmVersionedIdentifier] = libraryCompilation;
            Console.WriteLine($"Library compiled: {elmVersionedIdentifier}");
            hasChanged = true;
        }

        return hasChanged
                   ? Mutate(entries: entriesBuilder.ToImmutable())
                   : this;
    }

    #endregion

    #region Saving Output

    public ElmCompilation SaveCSharpFilesToDirectory(DirectoryInfo directory)
    {
        if (!directory.Exists)
            directory.Create();

        foreach (var (libraryName, sourceCode) in CSharpSourceCodes)
        {
            var fileName = Path.Combine(directory.FullName, $"{libraryName}.cs");
            File.WriteAllText(fileName, sourceCode);
            Console.WriteLine($"Saved C# source code to file: {fileName}");
        }

        return this;
    }

    public ElmCompilation SaveAssemblyBinariesToDirectory(DirectoryInfo directory)
    {
        if (!directory.Exists)
            directory.Create();

        foreach (var (libraryName, assemblyBinary) in AssemblyBinaries)
        {
            var fileName = Path.Combine(directory.FullName, $"{libraryName}.dll");
            File.WriteAllBytes(fileName, assemblyBinary);
            Console.WriteLine($"Saved assembly binary to file: {fileName}");
        }

        return this;
    }

    #endregion

    ILogger<ElmCompilation> ILogAccessor<ElmCompilation>.Logger => _serviceProvider.GetLogger<ElmCompilation>();
}