using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Conversion;
using Hl7.Cql.Fhir;
using Hl7.Fhir.Introspection;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Packaging;

/// <summary>
/// This creates all services necessary for a <see cref="LibraryPackager"/>.
/// The idea is not to inject this into service types, it's purpose is to
/// be one alternative to the .net hosting's <see cref="IServiceProvider"/>.
/// </summary>
internal class LibraryPackagerFactory
{
    private readonly LibraryExpressionBuilderFactory _libraryExpressionBuilderFactory;
    private readonly Lazy<CSharpSourceCodeWriter> _cSharpSourceCodeWriter;
    private readonly Lazy<AssemblyCompiler> _assemblyCompiler;
    private readonly Lazy<LibraryPackager> _libraryPackager;

    public LibraryPackagerFactory(ILoggerFactory loggerFactory, int cacheSize = 0)
    {
        _libraryExpressionBuilderFactory = new LibraryExpressionBuilderFactory(loggerFactory, cacheSize);
        _cSharpSourceCodeWriter = Deferred(() => new CSharpSourceCodeWriter(Logger<CSharpSourceCodeWriter>(), FhirTypeResolver));
        _assemblyCompiler = Deferred(() => new AssemblyCompiler(LibraryExpressionBuilder, CSharpSourceCodeWriter, TypeManager));
        _libraryPackager = Deferred(() => new LibraryPackager(FhirTypeResolver, AssemblyCompiler));


        static Lazy<T> Deferred<T>(Func<T> deferred) => new(deferred);

        ILogger<T> Logger<T>() => loggerFactory.CreateLogger<T>();
    }

    public ModelInspector ModelInspector => _libraryExpressionBuilderFactory.ModelInspector;
    public TypeConverter TypeConverter => _libraryExpressionBuilderFactory.TypeConverter;
    public FhirTypeResolver FhirTypeResolver => _libraryExpressionBuilderFactory.FhirTypeResolver;
    public CqlOperatorsBinding CqlOperatorsBinding => _libraryExpressionBuilderFactory.CqlOperatorsBinding;
    public TypeManager TypeManager => _libraryExpressionBuilderFactory.TypeManager;
    public ExpressionBuilder ExpressionBuilder => _libraryExpressionBuilderFactory.ExpressionBuilder;
    public LibraryExpressionBuilder LibraryExpressionBuilder => _libraryExpressionBuilderFactory.LibraryExpressionBuilder;
    public CSharpSourceCodeWriter CSharpSourceCodeWriter => _cSharpSourceCodeWriter.Value;
    public AssemblyCompiler AssemblyCompiler => _assemblyCompiler.Value;
    public LibraryPackager LibraryPackager => _libraryPackager.Value;
}