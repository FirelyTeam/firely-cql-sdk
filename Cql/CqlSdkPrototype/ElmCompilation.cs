using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.Elm;
using Hl7.Cql.Model;
using Hl7.Cql.Packaging;
using Hl7.Cql.Runtime;
using Hl7.Cql.Runtime.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace CqlSdkPrototype;

public class CqlTranslation
{
    private readonly record struct CqlLibrary(ElmVersionedLibraryIdentifier VersionedIdentifier, string Cql);
    private readonly record struct CqlTranslationEntry(CqlLibrary CqlLibrary, Library? ElmLibrary = null);


    private readonly ServiceProvider _serviceProvider;
    private readonly ImmutableDictionary<ElmVersionedLibraryIdentifier, CqlTranslationEntry> _entries;

    public IReadOnlyDictionary<ElmLibraryIdentifier, ElmVersionedLibraryIdentifier> VersionedIdentifiers =>
        _entries
            .ToDictionary(kv => kv.Key.Identifier, kv => kv.Key);

    internal IReadOnlyDictionary<ElmVersionedLibraryIdentifier, Library> ElmLibraries =>
        _entries
            .Where(kv => kv.Value.ElmLibrary is not null)
            .ToDictionary(kv => kv.Key, kv => kv.Value.ElmLibrary!);

    internal IReadOnlyDictionary<ElmVersionedLibraryIdentifier, string> ElmJsonStrings =>
        ElmLibraries
            .ToDictionary(kv => kv.Key, kv =>
            {
                var json = kv.Value.SerializeToJson(true);
                return json;
            });



    #region Construction

    private CqlTranslation(
        CqlTranslation? source = null,
        ImmutableDictionary<ElmVersionedLibraryIdentifier, CqlTranslationEntry>? entries = null,
        ServiceProvider? serviceProvider = null)
    {
        Debug.Assert((source, serviceProvider) is ({ }, null) or (null, { }),
                     "Must set either 'source' or 'serviceProvider'.");

        _serviceProvider = serviceProvider
                           ?? source!._serviceProvider;

        _entries =
            entries
            ?? source?._entries
            ?? ImmutableDictionary<ElmVersionedLibraryIdentifier, CqlTranslationEntry>.Empty
                .WithComparers(ElmVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer);
    }

    public static CqlTranslation New { get; } = new(serviceProvider: BuildServiceProvider());

    private static ServiceProvider BuildServiceProvider()
    {
        var serviceProvider =
            new ServiceCollection()
                .AddDebugLogging()
                .AddCqlToElmServices()
                .AddCqlToElmModels(
                    mp => mp
                        .Add(Models.Fhir401)
                        .Add(Models.ElmR1)
                    )
                .AddCqlToElmOptions(opt =>
                {
                    // Options
                })
                .BuildServiceProvider(validateScopes: true);
        return serviceProvider;
    }

    #endregion

    #region Loading/Adding CQL Libraries

    private CqlTranslation AddCqlLibraries(IEnumerable<CqlLibrary> cqlLibraries)
    {
        var libraryCompilationsBuilder = _entries.ToBuilder();
        var hasChanged = false;
        foreach (var cqlLibrary in cqlLibraries)
        {
            var versionedIdentifier = cqlLibrary.VersionedIdentifier;

            if (libraryCompilationsBuilder.ContainsKey(versionedIdentifier))
            {
                Console.WriteLine($"Skipping adding previous cql to translation: {versionedIdentifier}");
                continue;
            }

            var libraryCompilation = new CqlTranslationEntry(cqlLibrary);
            libraryCompilationsBuilder.Add(versionedIdentifier, libraryCompilation);
            Console.WriteLine($"Adding cql library to translation: {versionedIdentifier}");
            hasChanged = true;
        }

        return hasChanged
                   ? new CqlTranslation(this, entries: libraryCompilationsBuilder.ToImmutable())
                   : this;
    }

    public CqlTranslation LoadCqlFilesFromDirectory(DirectoryInfo directory, EnumerationOptions options)
    {
        var files = directory.EnumerateFiles("*.cql", options);
        return LoadCqlFiles(files);
    }

    private CqlTranslation LoadCqlFiles(IEnumerable<FileInfo> files)
    {
        var cqlLibraries =
            files
                .Where(f =>
                {
                    if (HardcodedSkipFileNames.Names.Contains(f.Name))
                    {
                        Console.WriteLine($"Skipping file as from hardcoded names: {f.FullName}");
                        return false;
                    }

                    return true;
                }) // Log skipped files
                .Select(f =>
                {
                    Console.WriteLine($"Loading library from file: {f}");
                    var cqlLibrary = new CqlLibrary(ElmVersionedLibraryIdentifier.Parse(f.Name.StripExtension(".cql")), File.ReadAllText(f.FullName) );
                    return cqlLibrary;
                }); // Log errors
        return AddCqlLibraries(cqlLibraries);
    }

    #endregion

    #region Translation

    public CqlTranslation Translate()
    {
        CqlToElmConverter cqlToElmConverter = null!;
        ImmutableDictionary<ElmVersionedLibraryIdentifier, CqlTranslationEntry>.Builder entriesBuilder = _entries.ToBuilder();
        int changedCount = 0;
        foreach (var (versionedIdentifier, cqlTranslationEntry) in entriesBuilder
                     .Where(kv => kv.Value.ElmLibrary is null))
        {
            if (changedCount == 0)
            {
                Console.WriteLine("Translating CQL into ELM");
                cqlToElmConverter = _serviceProvider.GetCqlToElmConverter();
                entriesBuilder = _entries.ToBuilder();
            }

            var library = cqlToElmConverter.ConvertLibrary(new StringReader(cqlTranslationEntry.CqlLibrary.Cql));
            entriesBuilder[versionedIdentifier] = cqlTranslationEntry with { ElmLibrary = library };
            changedCount++;
        }

        return changedCount > 0
                   ? new CqlTranslation(this, entries: entriesBuilder.ToImmutable())
                   : this;
    }

    #endregion

    #region Saving Output

    public CqlTranslation SaveElmFileToDirectory(DirectoryInfo directory)
    {
        return this;
    }

    #endregion
}

public class ElmCompilation
{
    private readonly record struct ElmCompilationEntry
        (Library ElmLibrary, string? CSharpSourceCode = null, byte[]? AssemblyBinary = null);

    private readonly ServiceProvider _serviceProvider;
    private readonly ImmutableDictionary<ElmVersionedLibraryIdentifier, ElmCompilationEntry> _entries;

    public IReadOnlyDictionary<ElmLibraryIdentifier, ElmVersionedLibraryIdentifier> VersionedIdentifiersByIdentifier =>
        _entries
            .ToDictionary(kv => kv.Key.Identifier, kv => kv.Key);

    public IReadOnlyDictionary<ElmVersionedLibraryIdentifier, string> SourceCodeByVersionedIdentifier =>
        _entries
            .Where(kv => kv.Value.CSharpSourceCode is not null)
            .ToDictionary(kv => kv.Key, kv => kv.Value.CSharpSourceCode!,
                          ElmVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer);

    public IReadOnlyDictionary<ElmVersionedLibraryIdentifier, byte[]> AssemblyBinariesByVersionedIdentifier =>
        _entries
            .Where(kv => kv.Value.AssemblyBinary is not null)
            .ToDictionary(kv => kv.Key, kv => kv.Value.AssemblyBinary!,
                          ElmVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer);


    #region Construction

    private ElmCompilation(
        ElmCompilation? source = null,
        ImmutableDictionary<ElmVersionedLibraryIdentifier, ElmCompilationEntry>? entries = null,
        ServiceProvider? serviceProvider = null)
    {
        Debug.Assert((source, serviceProvider) is ({ }, null) or (null, { }),
                     "Must set either 'source' or 'serviceProvider'.");

        _serviceProvider = serviceProvider
                           ?? source!._serviceProvider;

        _entries = entries
                   ?? source?._entries
                   ?? ImmutableDictionary<ElmVersionedLibraryIdentifier, ElmCompilationEntry>.Empty
                       .WithComparers(ElmVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer);
    }

    internal static ElmCompilation New => new(serviceProvider: BuildServiceProvider());

    private static ServiceProvider BuildServiceProvider()
    {
        var serviceProvider =
            new ServiceCollection()
                .AddDebugLogging()
                .AddCqlCodeGenerationServices()
                .BuildServiceProvider(validateScopes: true);
        return serviceProvider;
    }

    #endregion

    #region Loading/Adding ELM Libraries

    private ElmCompilation AddLibraries(IEnumerable<Library> libraries)
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
                   ? new ElmCompilation(this, entries: libraryCompilationsBuilder.ToImmutable())
                   : this;
    }

    public ElmCompilation LoadElmFilesFromDirectory(DirectoryInfo directory, EnumerationOptions options)
    {
        var files = directory.EnumerateFiles("*.json", options);
        return LoadElmFiles(files);
    }

    private ElmCompilation LoadElmFiles(IEnumerable<FileInfo> files)
    {
        var libraries =
            files
                .Where(f =>
                {
                    if (HardcodedSkipFileNames.Names.Contains(f.Name))
                    {
                        Console.WriteLine($"Skipping file as from hardcoded names: {f.FullName}");
                        return false;
                    }

                    return true;
                }) // Log skipped files
                .Select(f =>
                {
                    Console.WriteLine($"Loading library from file: {f}");
                    var library = Library.LoadFromJson(f);
                    return library;
                }); // Log errors
        return AddLibraries(libraries);
    }

    public ElmCompilation LoadElmFileWithDependencies(FileInfo file, EnumerationOptions options)
    {
        // TODO
        return new ElmCompilation(this);
    }

    public ElmCompilation LoadElmFileWithDependencies(
        DirectoryInfo directory,
        ElmVersionedLibraryIdentifier fileName,
        EnumerationOptions options)
    {
        // TODO
        return new ElmCompilation(this);
    }

    public ElmCompilation LoadElmFile(FileInfo file)
    {
        return LoadElmFiles([file]);
    }

    public ElmCompilation LoadElmFile(DirectoryInfo directory, ElmVersionedLibraryIdentifier libraryName)
    {
        FileInfo file = new(Path.Combine(directory.FullName, $"{libraryName}.json"));
        if (file.Exists)
            return LoadElmFile(file);

        if (libraryName.Version is null)
            throw new FileNotFoundException($"Could not find file '{file.FullName}'.");

        Console.WriteLine(
            $"Could not load library from file with name and version, trying without version: {file.FullName}");
        file = new FileInfo(Path.Combine(directory.FullName, $"{libraryName with { Version = null }}.json"));
        return LoadElmFile(file);
    }

    #endregion

    #region Compilation

    internal ElmCompilation Compile()
    {
        if (_entries.Values.All(lc => lc is { AssemblyBinary: not null }))
            return this;

        Console.WriteLine("Compiling ELM into C# and .NET Binaries");
        using var servicesScope = _serviceProvider.CreateScope();
        LibrarySetExpressionBuilder librarySetExpressionBuilderScoped = servicesScope.ServiceProvider.GetLibrarySetExpressionBuilderScoped();
        AssemblyCompiler assemblyCompiler = servicesScope.ServiceProvider.GetAssemblyCompiler();
        Library[] libraries = _entries.Values.Select(v => v.ElmLibrary).ToArray();
        LibrarySet librarySet = new LibrarySet("", libraries);
        DefinitionDictionary<LambdaExpression> definitionDictionary = librarySetExpressionBuilderScoped.ProcessLibrarySet(librarySet);
        IReadOnlyDictionary<string, AssemblyData> assemblyDatas = assemblyCompiler.Compile(librarySet, definitionDictionary);

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
                CSharpSourceCode = cSharpSourceCode, AssemblyBinary = assemblyBinary
            };
            entriesBuilder[elmVersionedIdentifier] = libraryCompilation;
            Console.WriteLine($"Library compiled: {elmVersionedIdentifier}");
            hasChanged = true;
        }

        return hasChanged
                   ? new ElmCompilation(this, entries: entriesBuilder.ToImmutable())
                   : this;
    }

    #endregion

    #region Saving Output

    public ElmCompilation SaveCSharpFilesToDirectory(DirectoryInfo directory)
    {
        if (!directory.Exists)
            directory.Create();

        foreach (var (libraryName, sourceCode) in SourceCodeByVersionedIdentifier)
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

        foreach (var (libraryName, assemblyBinary) in AssemblyBinariesByVersionedIdentifier)
        {
            var fileName = Path.Combine(directory.FullName, $"{libraryName}.dll");
            File.WriteAllBytes(fileName, assemblyBinary);
            Console.WriteLine($"Saved assembly binary to file: {fileName}");
        }

        return this;
    }

    #endregion
}

file static class HardcodedSkipFileNames
{
    public static readonly HashSet<string> Names =
        new(HardCodedSkipElmFiles.FileNames, StringComparer.OrdinalIgnoreCase);
}

file static class Extensions
{
    public static string StripExtension(this string filePath, string extension) =>
        filePath.EndsWith(extension, StringComparison.OrdinalIgnoreCase)
            ? filePath[..^extension.Length]
            : filePath;
}