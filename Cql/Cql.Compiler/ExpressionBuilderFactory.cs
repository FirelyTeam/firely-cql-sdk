using System;
using Hl7.Cql.Fhir;
using Hl7.Fhir.Introspection;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler;

/// <summary>
/// This creates all services necessary for a <see cref="LibraryDefinitionsBuilder"/>.
/// The idea is not to inject this into service types, it's purpose is to
/// be one alternative to the .net hosting's <see cref="IServiceProvider"/>.
/// </summary>

internal class LibraryDefinitionsBuilderFactory
{
    private readonly Lazy<FhirTypeResolver> _fhirTypeResolver;
    private readonly Lazy<Conversion.TypeConverter> _typeConverter;
    private readonly Lazy<CqlOperatorsBinding> _cqlOperatorsBinding;
    private readonly Lazy<TypeManager> _typeManager;
    private readonly Lazy<LibraryDefinitionsBuilder> _libraryDefinitionsBuilder;

    public LibraryDefinitionsBuilderFactory(ILoggerFactory loggerFactory, int? cacheSize = null)
    {
        _fhirTypeResolver = Deferred(() => new FhirTypeResolver(ModelInspector));
        _typeConverter = Deferred(() => FhirTypeConverter.Create(ModelInspector, cacheSize));
        _cqlOperatorsBinding = Deferred(() => new CqlOperatorsBinding(FhirTypeResolver, TypeConverter));
        _typeManager = Deferred(() => new TypeManager(FhirTypeResolver));
        _libraryDefinitionsBuilder = Deferred(() => new LibraryDefinitionsBuilder(loggerFactory, TypeManager, CqlOperatorsBinding));

        //ILogger<T> Logger<T>() => loggerFactory.CreateLogger<T>();
        static Lazy<T> Deferred<T>(Func<T> deferred) => new(deferred);
    }

    public ModelInspector ModelInspector => Hl7.Fhir.Model.ModelInfo.ModelInspector;

    public Conversion.TypeConverter TypeConverter => _typeConverter.Value;

    public FhirTypeResolver FhirTypeResolver => _fhirTypeResolver.Value;

    public CqlOperatorsBinding CqlOperatorsBinding => _cqlOperatorsBinding.Value;

    public TypeManager TypeManager => _typeManager.Value;

    public LibraryDefinitionsBuilder LibraryDefinitionsBuilder => _libraryDefinitionsBuilder.Value;
}