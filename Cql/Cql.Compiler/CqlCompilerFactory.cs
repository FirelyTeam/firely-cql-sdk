using System;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Fhir;
using Hl7.Fhir.Introspection;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler;

/// <summary>
/// This creates all services necessary for a <see cref="LibraryDefinitionsBuilder"/>.
/// The idea is not to inject this into service types, it's purpose is to
/// be one alternative to the .net hosting's <see cref="IServiceProvider"/>.
/// </summary>
internal class CqlCompilerFactory : CqlAbstractionsFactory
{
    protected int? CacheSize { get; }

    public CqlCompilerFactory(ILoggerFactory loggerFactory, int? cacheSize = null) : base(loggerFactory) =>
        CacheSize = cacheSize;


    public virtual ModelInspector ModelInspector => Singleton(NewModelInspector);
    protected virtual ModelInspector NewModelInspector() => Hl7.Fhir.Model.ModelInfo.ModelInspector;


    public virtual Conversion.TypeConverter TypeConverter => Singleton(NewTypeConverter);
    protected virtual Conversion.TypeConverter NewTypeConverter() => FhirTypeConverter.Create(ModelInspector, CacheSize);

    public virtual TypeResolver TypeResolver => Singleton(NewTypeResolver);
    protected virtual TypeResolver NewTypeResolver() => new FhirTypeResolver(ModelInspector);

    public virtual CqlOperatorsBinding OperatorsBinding => Singleton(NewCqlOperatorsBinding);
    protected virtual CqlOperatorsBinding NewCqlOperatorsBinding() => new(TypeResolver, TypeConverter);

    public virtual TypeManager TypeManager => Singleton(NewTypeManager);
    protected virtual TypeManager NewTypeManager() => new(TypeResolver);

    public virtual LibraryDefinitionsBuilder LibraryDefinitionsBuilder => Singleton(NewLibraryDefinitionsBuilder);
    protected virtual LibraryDefinitionsBuilder NewLibraryDefinitionsBuilder() => new(LoggerFactory, TypeManager, OperatorsBinding);
}