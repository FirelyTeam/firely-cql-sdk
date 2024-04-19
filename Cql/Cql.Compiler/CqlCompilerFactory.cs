using System;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler.Binders;
using Hl7.Cql.Compiler.Builders;
using Hl7.Cql.Conversion;
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


    public virtual TypeConverter TypeConverter => Singleton(NewTypeConverter);
    protected virtual TypeConverter NewTypeConverter() => FhirTypeConverter.Create(ModelInspector, CacheSize);


    public virtual TypeResolver TypeResolver => Singleton(NewTypeResolver);
    protected virtual TypeResolver NewTypeResolver() => new FhirTypeResolver(ModelInspector);


    public virtual OperatorsBinder OperatorsBinder => Singleton(NewOperatorsBinder);
    protected virtual OperatorsBinder NewOperatorsBinder() => new CqlOperatorsBinder(TypeResolver, TypeConverter);


    public virtual ContextBinder ContextBinder => Singleton(NewContextBinder);
    protected virtual ContextBinder NewContextBinder() => new CqlContextBinder();


    public virtual TypeManager TypeManager => Singleton(NewTypeManager);
    protected virtual TypeManager NewTypeManager() => new(TypeResolver);


    public virtual LibraryDefinitionsBuilder LibraryDefinitionsBuilder => Singleton(NewLibraryDefinitionsBuilder);
    protected virtual LibraryDefinitionsBuilder NewLibraryDefinitionsBuilder() =>
        new(new (LoggerFactory, OperatorsBinder, TypeManager, TypeConverter, ContextBinder, LibraryDefinitionBuilderSettings.Default));
}