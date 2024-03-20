using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Packaging;

/// <summary>
/// This creates all services necessary for a <see cref="LibraryPackager"/>.
/// The idea is not to inject this into service types, it's purpose is to
/// be one alternative to the .net hosting's <see cref="IServiceProvider"/>.
/// </summary>
internal class LibraryPackagerFactory : LibrarySetExpressionBuilderFactory
{
    private readonly Lazy<CSharpLibrarySetToStreamsWriter> _cSharpSourceCodeWriter;
    private readonly Lazy<CSharpCodeStreamPostProcessor?> _cSharpCodeStreamPostProcessor;
    private readonly Lazy<AssemblyCompiler> _assemblyCompiler;
    private readonly Lazy<LibraryPackager> _libraryPackager;

    public LibraryPackagerFactory(ILoggerFactory loggerFactory, int cacheSize = 0, string? csharpOutDirectory = null) : base(loggerFactory, cacheSize)
    {
        _cSharpCodeStreamPostProcessor = Deferred<CSharpCodeStreamPostProcessor?>(() =>
            csharpOutDirectory is { } dir
                ? new WriteToFileCSharpCodeStreamPostProcessor(Options(new CSharpCodeWriterOptions() { OutDirectory = new DirectoryInfo(dir) })) 
                : null);
        _cSharpSourceCodeWriter = Deferred(() => new CSharpLibrarySetToStreamsWriter(Logger<CSharpLibrarySetToStreamsWriter>(), FhirTypeResolver, CSharpCodeStreamPostProcessor));
        _assemblyCompiler = Deferred(() => new AssemblyCompiler(CSharpLibrarySetToStreamsWriter, TypeManager));
        _libraryPackager = Deferred(() => new LibraryPackager(FhirTypeResolver, AssemblyCompiler, LibrarySetExpressionBuilder));


        static Lazy<T> Deferred<T>(Func<T> deferred) => new(deferred);

        ILogger<T> Logger<T>() => loggerFactory.CreateLogger<T>();

        IOptions<T> Options<T>(T options) where T : class => Microsoft.Extensions.Options.Options.Create<T>(options);
    }

    public CSharpLibrarySetToStreamsWriter CSharpLibrarySetToStreamsWriter => _cSharpSourceCodeWriter.Value;

    public CSharpCodeStreamPostProcessor? CSharpCodeStreamPostProcessor => _cSharpCodeStreamPostProcessor.Value;

    public AssemblyCompiler AssemblyCompiler => _assemblyCompiler.Value;

    public LibraryPackager LibraryPackager => _libraryPackager.Value;
}