using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Conversion;
using Hl7.Cql.Fhir;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Packaging;

internal class LibraryPackagerCreator
{
    private readonly ExpressionBuilderCreator _ExpressionBuilderCreator;
    private readonly Lazy<CSharpSourceCodeWriter> _CSharpSourceCodeWriter;
    private readonly Lazy<AssemblyCompiler> _AssemblyCompiler;
    private readonly Lazy<LibraryPackager> _LibraryPackager;

    public LibraryPackagerCreator(ILoggerFactory loggerFactory, int cacheSize = 0)
    {
        _ExpressionBuilderCreator = new ExpressionBuilderCreator(loggerFactory, cacheSize);
        _CSharpSourceCodeWriter = Deferred(() =>
        {
            ILogger<CSharpSourceCodeWriter> cSharpSourceCodeWriterLogger = loggerFactory.CreateLogger<CSharpSourceCodeWriter>(); 
            return new CSharpSourceCodeWriter(cSharpSourceCodeWriterLogger, FhirTypeResolver);
        });
        _AssemblyCompiler = Deferred(() => new AssemblyCompiler(ExpressionBuilderService, FhirTypeResolver, CSharpSourceCodeWriter, TypeManager));
        _LibraryPackager = Deferred(() => new LibraryPackager(FhirTypeResolver, AssemblyCompiler, ExpressionBuilderService));


        static Lazy<T> Deferred<T>(Func<T> deferred) => new(deferred);
    }

    public ModelInspector ModelInspector => _ExpressionBuilderCreator.ModelInspector;
    public TypeConverter TypeConverter => _ExpressionBuilderCreator.TypeConverter;
    public FhirTypeResolver FhirTypeResolver => _ExpressionBuilderCreator.FhirTypeResolver;
    public CqlOperatorsBinding CqlOperatorsBinding => _ExpressionBuilderCreator.CqlOperatorsBinding;
    public TypeManager TypeManager => _ExpressionBuilderCreator.TypeManager;
    public ExpressionBuilderService ExpressionBuilderService => _ExpressionBuilderCreator.ExpressionBuilderService;
    public CSharpSourceCodeWriter CSharpSourceCodeWriter => _CSharpSourceCodeWriter.Value;
    public AssemblyCompiler AssemblyCompiler => _AssemblyCompiler.Value;
    public LibraryPackager LibraryPackager => _LibraryPackager.Value;

}