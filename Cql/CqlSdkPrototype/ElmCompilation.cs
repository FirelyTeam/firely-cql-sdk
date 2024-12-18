using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq.Expressions;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Packaging;
using Hl7.Cql.Runtime;
using Hl7.Cql.Runtime.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace CqlSdkPrototype;

public class ElmCompilation
{
    private readonly record struct LibraryCompilation
        (Library Library, string? CSharpSourceCode = null, byte[]? AssemblyBinary = null);

    private static readonly HashSet<string> _hardcodedSkipFileNames =
        new(HardCodedSkipElmFiles.FileNames, StringComparer.OrdinalIgnoreCase);

    private readonly ServiceProvider _serviceProvider;
    private readonly ImmutableDictionary<ElmVersionedLibraryIdentifier, LibraryCompilation> _libraryCompilations;


    private ElmCompilation(
        ElmCompilation? source = null,
        ImmutableDictionary<ElmVersionedLibraryIdentifier, LibraryCompilation>? libraryCompilations = null,
        ServiceProvider? serviceProvider = null)
    {
        Debug.Assert((source, serviceProvider) is ({ }, null) or (null, { }),
                     "Must set either 'source' or 'serviceProvider'.");

        _serviceProvider = serviceProvider
                           ?? source!._serviceProvider;
        _libraryCompilations = libraryCompilations
                               ?? source?._libraryCompilations
                               ?? ImmutableDictionary<ElmVersionedLibraryIdentifier, LibraryCompilation>.Empty
                                   .WithComparers(ElmVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer, null);
    }

    internal static ElmCompilation New => new(serviceProvider: BuildServiceProvider());

    internal ElmCompilation AddLibraries(IEnumerable<Library> libraries)
    {
        var libraryCompilationsBuilder = _libraryCompilations.ToBuilder();
        var hasChanged = false;
        foreach (var library in libraries)
        {
            var elmVersionedIdentifier = ElmVersionedLibraryIdentifier.FromVersionedIdentifier(library.identifier);

            if (libraryCompilationsBuilder.ContainsKey(elmVersionedIdentifier))
            {
                Console.WriteLine($"Skipping adding previous library to compilation: {elmVersionedIdentifier}");
                continue;
            }

            var libraryCompilation = new LibraryCompilation(library);
            libraryCompilationsBuilder.Add(elmVersionedIdentifier, libraryCompilation);
            Console.WriteLine($"Adding library to compilation: {elmVersionedIdentifier}");
            hasChanged = true;
        }

        return hasChanged
                   ? new ElmCompilation(this, libraryCompilations: libraryCompilationsBuilder.ToImmutable())
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
                    if (_hardcodedSkipFileNames.Contains(f.Name))
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

    internal ElmCompilation Compile()
    {
        if (_libraryCompilations.Values.All(lc => lc is { AssemblyBinary: not null }))
            return this;

        using var servicesScope = _serviceProvider.CreateScope();
        LibrarySetExpressionBuilder librarySetExpressionBuilderScoped =
            servicesScope.ServiceProvider.GetLibrarySetExpressionBuilderScoped();
        AssemblyCompiler assemblyCompiler = servicesScope.ServiceProvider.GetAssemblyCompiler();
        Library[] libraries = _libraryCompilations.Values.Select(v => v.Library).ToArray();
        LibrarySet librarySet = new LibrarySet("", libraries);
        Console.WriteLine("Compiling Libraries");
        DefinitionDictionary<LambdaExpression> definitionDictionary =
            librarySetExpressionBuilderScoped.ProcessLibrarySet(librarySet);
        IReadOnlyDictionary<string, AssemblyData> assemblyDatas =
            assemblyCompiler.Compile(librarySet, definitionDictionary);

        var libraryCompilationsBuilder = _libraryCompilations.ToBuilder();
        bool hasChanged = false;
        foreach (var (name, (assemblyBinary, sourceCodePerName)) in assemblyDatas)
        {
            var elmVersionedIdentifier = ElmVersionedLibraryIdentifier.Parse(name);
            var libraryCompilation = libraryCompilationsBuilder[elmVersionedIdentifier];
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
            libraryCompilationsBuilder[elmVersionedIdentifier] = libraryCompilation;
            Console.WriteLine($"Library compiled: {elmVersionedIdentifier}");
            hasChanged = true;
        }

        return hasChanged
                   ? new ElmCompilation(this, libraryCompilations: libraryCompilationsBuilder.ToImmutable())
                   : this;
    }

    private static ServiceProvider BuildServiceProvider()
    {
        var serviceProvider =
            new ServiceCollection()
                .AddDebugLogging()
                .AddCqlCodeGenerationServices()
                .BuildServiceProvider(validateScopes: true);
        return serviceProvider;
    }

    public IReadOnlyDictionary<string, ElmVersionedLibraryIdentifier> LibraryNames =>
        _libraryCompilations
            .ToDictionary(kv => kv.Key.Identifier.ToString(), kv => kv.Key);

    public IReadOnlyDictionary<ElmVersionedLibraryIdentifier, string> SourceCodeByLibraryName =>
        _libraryCompilations
            .Where(kv => kv.Value.CSharpSourceCode is not null)
            .ToDictionary(kv => kv.Key, kv => kv.Value.CSharpSourceCode!,
                          ElmVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer);

    public IReadOnlyDictionary<ElmVersionedLibraryIdentifier, byte[]> AssemblyBinariesByLibraryName =>
        _libraryCompilations
            .Where(kv => kv.Value.AssemblyBinary is not null)
            .ToDictionary(kv => kv.Key, kv => kv.Value.AssemblyBinary!,
                          ElmVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer);

    public ElmCompilation SaveCSharpFilesToDirectory(DirectoryInfo directory)
    {
        if (!directory.Exists)
            directory.Create();

        foreach (var (libraryName, sourceCode) in SourceCodeByLibraryName)
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

        foreach (var (libraryName, assemblyBinary) in AssemblyBinariesByLibraryName)
        {
            var fileName = Path.Combine(directory.FullName, $"{libraryName}.dll");
            File.WriteAllBytes(fileName, assemblyBinary);
            Console.WriteLine($"Saved assembly binary to file: {fileName}");
        }

        return this;
    }
}