using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq.Expressions;
using System;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Packaging;
using Hl7.Cql.Runtime;
using Hl7.Cql.Runtime.Hosting;
using Microsoft.Extensions.DependencyInjection;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable RS0016

namespace CqlSdkPrototype;

internal class Program
{
    static void Main(string[] args)
    {
        // NOTE: This is a prototype of the CQL SDK
        // Considerations:
        // - Keeping it very simple
        // - Error handling will be available through an Errors property instead of exceptions
        // - Single-threaded, non-async
        // - Immutable compilation units
        // - Using files, strings and byte arrays as input and output. No streams (considered advanced)
        // - Only focused on translating, not on introspection of libraries
        // - Split into multiple SDKS: CQL-to-ELM SDK, ELM-to-.NET SDK, ELM-to-FHIR SDK, Runtime SDK
        //
        // 1. CQL SDK
        // - Load CQL file(s) from a directory
        // - Translate CQL files to ELM JSON files (or ELM XML files)
        // - Write ELM files to directory
        //
        // 2. ELM SDK
        // - Load ELM file(s) from a directory
        // - TO DO: Load ELM file(s) from a file with all its dependencies, assuming the dependencies are in the same directory
        // - Load ELM file from a single file
        // - Translate ELM files to C# source code and assembly byte[]
        // - Writing C# files to directory
        // - Writing assembly binaries to directory
        //
        // 3. FHIR SDK
        // - Input: Elm Compilation
        // - Translate to FHIR Libraries and Measures
        // - Write FHIR Libraries and Measures to directory
        //
        // 4. Runtime SDK
        // - Load CQL, ELM files into AssemblyLoadContext
        // - Load FHIR Libraries and Measures into AssemblyLoadContext
        // - Load .NET assemblies into AssemblyLoadContext
        // - Execute libraries

        var rootDir = new DirectoryInfo(@"C:\Dev\firely-cql-sdk\LibrarySets\CMS");
        var elmInDir = rootDir.CreateSubdirectory("Elm");
        var csharpOutDir = rootDir.CreateSubdirectory("CSharp2");
        var dllOutDir = rootDir.CreateSubdirectory("Dlls2");

        csharpOutDir.Delete(recursive: true);
        dllOutDir.Delete(recursive: true);

        var elmCompilation =
            ElmSdk
                 .NewCompilation()
                 .LoadElmFile(elmInDir, ElmVersionedIdentifier.FromNameAndVersion("FHIRHelpers"))
                 .Compile()
                 .LoadElmFilesFromDirectory(elmInDir, new EnumerationOptions() { RecurseSubdirectories = false })
                 .Compile()
                 .SaveCSharpFilesToDirectory(csharpOutDir)
                 .SaveAssemblyBinariesToDirectory(dllOutDir)
                ;

        //.LoadElmFile(new FileInfo(@"C:\Dev\firely-cql-sdk\LibrarySets\CMS\Elm\ALARACTOQRFHIR.json"))
        //.LoadElmFileWithDependencies(new DirectoryInfo(@"C:\Dev\firely-cql-sdk\LibrarySets\CMS\Elm"), ElmVersionedIdentifier.FromNameAndVersion("ALARACTOQRFHIR", "0.4.000"), new EnumerationOptions() { RecurseSubdirectories = false })

        Console.WriteLine(
            $"""
             First 50 C# lines for {elmCompilation.LibraryNames["FHIRHelpers"]}:
             {
                 string.Join(
                     Environment.NewLine,
                     elmCompilation.SourceCodeByLibraryName[ElmVersionedIdentifier.FromNameAndVersion("FHIRHelpers")]
                        .Split([Environment.NewLine], StringSplitOptions.None)
                        .Take(50))
             }
             """);
    }
}


public static class ElmSdk
{
    public static ElmCompilation NewCompilation() => ElmCompilation.New;
}

public class ElmCompilation
{
    private readonly record struct LibraryCompilation(Library Library, string? CSharpSourceCode = null, byte[]? AssemblyBinary = null);

    private static readonly HashSet<string> _hardcodedSkipFileNames = new(HardCodedSkipElmFiles.FileNames, StringComparer.OrdinalIgnoreCase);
    private readonly ServiceProvider _serviceProvider;
    private readonly ImmutableDictionary<ElmVersionedIdentifier, LibraryCompilation> _libraryCompilations;


    private ElmCompilation(
        ElmCompilation? source = null,
        ImmutableDictionary<ElmVersionedIdentifier, LibraryCompilation>? libraryCompilations = null,
        ServiceProvider? serviceProvider = null)
    {
        Debug.Assert((source, serviceProvider) is ({ }, null) or (null, { }), "Must set either 'source' or 'serviceProvider'.");

        _serviceProvider = serviceProvider
                           ?? source!._serviceProvider;
        _libraryCompilations = libraryCompilations
                               ?? source?._libraryCompilations
                               ?? ImmutableDictionary<ElmVersionedIdentifier, LibraryCompilation>.Empty
                                   .WithComparers(ElmVersionedIdentifier.NameOnlyEqualityComparer, null);
    }

    internal static ElmCompilation New => new(serviceProvider: BuildServiceProvider());

    internal ElmCompilation AddLibraries(IEnumerable<Library> libraries)
    {
        var libraryCompilationsBuilder = _libraryCompilations.ToBuilder();
        var hasChanged = false;
        foreach (var library in libraries)
        {
            var elmVersionedIdentifier = ElmVersionedIdentifier.FromVersionedIdentifier(library.identifier);

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
                })                                                 // Log skipped files
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
        return new ElmCompilation(this);
    }

    public ElmCompilation LoadElmFileWithDependencies(
        DirectoryInfo directory,
        ElmVersionedIdentifier fileName,
        EnumerationOptions options) => new(this);

    public ElmCompilation LoadElmFile(FileInfo file)
    {
        return LoadElmFiles([file]);
    }

    public ElmCompilation LoadElmFile(DirectoryInfo directory, ElmVersionedIdentifier libraryName)
    {
        FileInfo file = new(Path.Combine(directory.FullName, $"{libraryName}.json"));
        if (file.Exists)
            return LoadElmFile(file);

        if (libraryName.Version is null)
            throw new FileNotFoundException($"Could not find file '{file.FullName}'.");

        Console.WriteLine($"Could not load library from file with name and version, trying without version: {file.FullName}");
        file = new FileInfo(Path.Combine(directory.FullName, $"{libraryName with { Version = null}}.json"));
        return LoadElmFile(file);
    }

    internal ElmCompilation Compile()
    {
        if (_libraryCompilations.Values.All(lc => lc is { AssemblyBinary: not null }))
            return this;

        using var servicesScope = _serviceProvider.CreateScope();
        LibrarySetExpressionBuilder librarySetExpressionBuilderScoped = servicesScope.ServiceProvider.GetLibrarySetExpressionBuilderScoped();
        AssemblyCompiler assemblyCompiler = servicesScope.ServiceProvider.GetAssemblyCompiler();
        Library[] libraries = _libraryCompilations.Values.Select(v => v.Library).ToArray();
        LibrarySet librarySet = new LibrarySet("", libraries);
        Console.WriteLine("Compiling Libraries");
        DefinitionDictionary<LambdaExpression> definitionDictionary = librarySetExpressionBuilderScoped.ProcessLibrarySet(librarySet);
        IReadOnlyDictionary<string, AssemblyData> assemblyDatas = assemblyCompiler.Compile(librarySet, definitionDictionary);

        var libraryCompilationsBuilder = _libraryCompilations.ToBuilder();
        bool hasChanged = false;
        foreach (var (name, (assemblyBinary, sourceCodePerName)) in assemblyDatas)
        {
            var elmVersionedIdentifier = ElmVersionedIdentifier.ParseString(name);
            var libraryCompilation = libraryCompilationsBuilder[elmVersionedIdentifier];
            if (libraryCompilation.CSharpSourceCode is not null
                || libraryCompilation.AssemblyBinary is not null)
            {
                Console.WriteLine($"Library already compiled: {elmVersionedIdentifier}");
                continue;
            }

            var cSharpSourceCode = sourceCodePerName.Values.Single(); // We always expect a single source file
            libraryCompilation = libraryCompilation with { CSharpSourceCode  = cSharpSourceCode, AssemblyBinary = assemblyBinary };
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

    public IReadOnlyDictionary<string, ElmVersionedIdentifier> LibraryNames =>
        _libraryCompilations
            .ToDictionary(kv => kv.Key.Name.ToString(), kv => kv.Key);

    public IReadOnlyDictionary<ElmVersionedIdentifier, string> SourceCodeByLibraryName =>
        _libraryCompilations
            .Where(kv => kv.Value.CSharpSourceCode is not null)
            .ToDictionary(kv => kv.Key, kv => kv.Value.CSharpSourceCode!, ElmVersionedIdentifier.NameOnlyEqualityComparer);

    public IReadOnlyDictionary<ElmVersionedIdentifier, byte[]> AssemblyBinariesByLibraryName =>
        _libraryCompilations
            .Where(kv => kv.Value.AssemblyBinary is not null)
            .ToDictionary(kv => kv.Key, kv => kv.Value.AssemblyBinary!, ElmVersionedIdentifier.NameOnlyEqualityComparer);

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


public readonly record struct ElmVersionedIdentifier
{
    private sealed class NameOnlyComparerImpl : IComparer<ElmVersionedIdentifier>, IEqualityComparer<ElmVersionedIdentifier>
    {
        public static NameOnlyComparerImpl Instance { get;  } = new();

        public int Compare(ElmVersionedIdentifier x, ElmVersionedIdentifier y)
        {
            return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
        }

        public bool Equals(ElmVersionedIdentifier x, ElmVersionedIdentifier y)
        {
            return x.Name == y.Name;
        }

        public int GetHashCode(ElmVersionedIdentifier obj)
        {
            return obj.Name.GetHashCode();
        }
    }

    public static IComparer<ElmVersionedIdentifier> NameOnlyComparer => NameOnlyComparerImpl.Instance;

    public static IEqualityComparer<ElmVersionedIdentifier> NameOnlyEqualityComparer { get; } = new NameOnlyComparerImpl();

    private ElmVersionedIdentifier(string Name, string? Version = null)
    {
        this.Name = Name;
        this.Version = Version;
    }

    public static ElmVersionedIdentifier FromNameAndVersion(string name, string? version = null)
    {
        ArgumentNullException.ThrowIfNullOrEmpty(name);
        return new ElmVersionedIdentifier(name, version);
    }

    public static ElmVersionedIdentifier FromVersionedIdentifier(VersionedIdentifier identifier)
    {
        ArgumentNullException.ThrowIfNull(identifier);
        return FromNameAndVersion(identifier.id, identifier.version);
    }

    public string Name { get; init; }

    public string? Version { get; init; }

    public void Deconstruct(out string name, out string? version)
    {
        name = Name;
        version = Version;
    }

    public static ElmVersionedIdentifier ParseString(string text)
    {
        var result = text.Split('-', 2) switch
        {
            [{ } name]              => FromNameAndVersion(name),
            [{ } name, { } version] => FromNameAndVersion(name, version),
            _                       => throw new UnreachableException(),
        };
        return result;
    }

    public override string ToString()
    {
        return (Name, Version) switch
        {
            ({} name, null)         => name,
            ({ } name, { } version) => $"{name}-{version}",
            _                       => throw new UnreachableException(),
        };
    }
}