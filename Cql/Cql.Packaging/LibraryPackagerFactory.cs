using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CodeGeneration.NET.PostProcessors;
using Hl7.Cql.Compiler;
using Hl7.Cql.Packaging.PostProcessors;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Packaging;

/// <summary>
/// This creates all services necessary for a <see cref="ResourcePackager"/>.
/// The idea is not to inject this into service types, it's purpose is to
/// be one alternative to the .net hosting's <see cref="IServiceProvider"/>.
/// </summary>
internal class LibraryPackagerFactory : LibrarySetExpressionBuilderFactory
{
    private readonly Lazy<CSharpLibrarySetToStreamsWriter> _cSharpSourceCodeWriter;
    private readonly Lazy<CSharpCodeStreamPostProcessor?> _cSharpCodeStreamPostProcessor;
    private readonly Lazy<FhirResourcePostProcessor?> _fhirResourcePostProcessor;
    private readonly Lazy<AssemblyCompiler> _assemblyCompiler;
    private readonly Lazy<ResourcePackager> _libraryPackager;
    private readonly Lazy<CqlTypeToFhirTypeMapper> _cqlTypeToFhirTypeMapper;

    public LibraryPackagerFactory(
        ILoggerFactory loggerFactory, 
        int cacheSize = 0, 
        string? csharpOutDirectory = null,
        string? fhirResourceOutDirectory = null,
        DateTime? fhirResourceOverrideDate = null) : base(loggerFactory, cacheSize)
    {
        _cqlTypeToFhirTypeMapper = Deferred(() => new CqlTypeToFhirTypeMapper(FhirTypeResolver));
        _cSharpCodeStreamPostProcessor = Deferred<CSharpCodeStreamPostProcessor?>(() =>
            csharpOutDirectory is not null
                ? new WriteToFileCSharpCodeStreamPostProcessor(
                    Options(new CSharpCodeWriterOptions() { OutDirectory = new DirectoryInfo(csharpOutDirectory) }),
                    Logger<WriteToFileCSharpCodeStreamPostProcessor>()) 
                : null);
        _fhirResourcePostProcessor = Deferred<FhirResourcePostProcessor?>(() =>
            fhirResourceOutDirectory is not null
                ? new WriteToFileFhirResourcePostProcessor(
                    Options(new FhirResourceWriterOptions() { OutDirectory = new DirectoryInfo(fhirResourceOutDirectory), OverrideDate = fhirResourceOverrideDate}),
                    Logger<WriteToFileFhirResourcePostProcessor>())
                : null);
        _cSharpSourceCodeWriter = Deferred(() => new CSharpLibrarySetToStreamsWriter(Logger<CSharpLibrarySetToStreamsWriter>(), FhirTypeResolver));
        _assemblyCompiler = Deferred(() => new AssemblyCompiler(CSharpLibrarySetToStreamsWriter, TypeManager, CSharpCodeStreamPostProcessor));
        _libraryPackager = Deferred(() => new ResourcePackager(FhirTypeResolver, AssemblyCompiler, LibrarySetExpressionBuilder, FhirResourcePostProcessor));


        static Lazy<T> Deferred<T>(Func<T> deferred) => new(deferred);

        ILogger<T> Logger<T>() => loggerFactory.CreateLogger<T>();

        IOptions<T> Options<T>(T options) where T : class => Microsoft.Extensions.Options.Options.Create<T>(options);
    }

    public CqlTypeToFhirTypeMapper CqlTypeToFhirTypeMapper => _cqlTypeToFhirTypeMapper.Value;

    public CSharpLibrarySetToStreamsWriter CSharpLibrarySetToStreamsWriter => _cSharpSourceCodeWriter.Value;

    public CSharpCodeStreamPostProcessor? CSharpCodeStreamPostProcessor => _cSharpCodeStreamPostProcessor.Value;
    public FhirResourcePostProcessor? FhirResourcePostProcessor => _fhirResourcePostProcessor.Value;

    public AssemblyCompiler AssemblyCompiler => _assemblyCompiler.Value;

    public ResourcePackager ResourcePackager => _libraryPackager.Value;
}