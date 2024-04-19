using System;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Conversion;
using Hl7.Cql.Fhir;
using Hl7.Fhir.Introspection;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler;

/// <summary>
/// This creates all services necessary for the Hl7.Cql.Compiler assembly.
/// The idea is not to inject this into service types, it's purpose is to
/// be one alternative to the .net hosting's <see cref="IServiceProvider"/>.
/// </summary>
internal class CqlCompilerFactory :
    CqlAbstractionsFactory
{
    protected int? CacheSize { get; }

    public CqlCompilerFactory(ILoggerFactory loggerFactory, int? cacheSize = null) :
        base(loggerFactory: loggerFactory) =>
        CacheSize = cacheSize;


    public virtual ModelInspector ModelInspector => Singleton(fn: NewModelInspector);
    protected virtual ModelInspector NewModelInspector() => Hl7.Fhir.Model.ModelInfo.ModelInspector;


    public virtual TypeConverter TypeConverter => Singleton(fn: NewTypeConverter);
    protected virtual TypeConverter NewTypeConverter() => FhirTypeConverter.Create(ModelInspector, CacheSize);


    public virtual TypeResolver TypeResolver => Singleton(fn: NewTypeResolver);
    protected virtual TypeResolver NewTypeResolver() => new FhirTypeResolver(ModelInspector);


    public virtual OperatorsBinder OperatorsBinder => Singleton(fn: NewOperatorsBinder);
    protected virtual OperatorsBinder NewOperatorsBinder() => new CqlOperatorsBinder(TypeResolver, TypeConverter);


    public virtual ContextBinder ContextBinder => Singleton(fn: NewContextBinder);
    protected virtual ContextBinder NewContextBinder() => new CqlContextBinder();


    public virtual TypeManager TypeManager => Singleton(fn: NewTypeManager);
    protected virtual TypeManager NewTypeManager() => new(resolver: TypeResolver);


    public virtual LibrarySetExpressionBuilder LibrarySetExpressionBuilder => Singleton(fn: NewLibrarySetExpressionBuilder);

    protected virtual LibrarySetExpressionBuilder NewLibrarySetExpressionBuilder() =>
        new(LibraryExpressionBuilder);

    public virtual LibraryExpressionBuilder LibraryExpressionBuilder => Singleton(fn: NewLibraryExpressionBuilder);

    protected virtual LibraryExpressionBuilder NewLibraryExpressionBuilder() =>
        new LibraryExpressionBuilder(
            logger: Singleton(fn: NewLibraryExpressionBuilderLogger),
            ExpressionBuilder);

    protected virtual ExpressionBuilderSettings NewLibraryDefinitionBuilderSettings() =>
        ExpressionBuilderSettings.Default;

    protected virtual ILogger<LibraryExpressionBuilder> NewLibraryExpressionBuilderLogger() =>
        LoggerFactory.CreateLogger<LibraryExpressionBuilder>();

    public virtual ExpressionBuilder ExpressionBuilder => Singleton(fn: NewExpressionBuilder);

    protected virtual ExpressionBuilder NewExpressionBuilder() =>
        new(logger: Singleton(fn: NewExpressionBuilderLogger),
            operatorsBinder: OperatorsBinder,
            typeManager: TypeManager,
            typeConverter: TypeConverter,
            typeResolver: TypeResolver,
            contextBinder: ContextBinder,
            expressionBuilderSettings: Singleton(fn: NewLibraryDefinitionBuilderSettings));

    protected virtual ILogger<ExpressionBuilder> NewExpressionBuilderLogger() =>
        LoggerFactory.CreateLogger<ExpressionBuilder>();
}