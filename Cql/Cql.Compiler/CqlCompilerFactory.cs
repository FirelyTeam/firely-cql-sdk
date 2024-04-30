

/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System;
using System.Threading;
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

    public CqlCompilerFactory(
        ILoggerFactory loggerFactory,
        CancellationToken cancellationToken = default,
        int ? cacheSize = null) :
        base(loggerFactory, cancellationToken) =>
        CacheSize = cacheSize;


    public virtual ModelInspector ModelInspector => Singleton(fn: NewModelInspector);
    protected virtual ModelInspector NewModelInspector() => Hl7.Fhir.Model.ModelInfo.ModelInspector;


    public virtual TypeConverter TypeConverter => Singleton(fn: NewTypeConverter);
    protected virtual TypeConverter NewTypeConverter()
    {
        var converter = FhirTypeConverter
                .Create(ModelInspector, CacheSize)
                .UseLogger(Logger<TypeConverter>());
        converter.LogInitialConverters();
        return converter;
    }


    public virtual TypeResolver TypeResolver => Singleton(fn: NewTypeResolver);
    protected virtual TypeResolver NewTypeResolver() => new FhirTypeResolver(ModelInspector);

    public virtual ExpressionConverter ExpressionConverter => Singleton(fn: NewExpressionConverter);
    protected virtual ExpressionConverter NewExpressionConverter() =>
        new ExpressionConverter(
            TypeConverter);


    public virtual CqlOperatorsBinder CqlOperatorsBinder => Singleton(fn: NewOperatorsBinder);
    protected virtual CqlOperatorsBinder NewOperatorsBinder() =>
        new CqlOperatorsBinder(
            Logger<CqlOperatorsBinder>(),
            TypeResolver,
            ExpressionConverter);


    public virtual CqlContextBinder CqlContextBinder => Singleton(fn: NewContextBinder);
    protected virtual CqlContextBinder NewContextBinder() => new CqlContextBinder();


    public virtual TypeManager TypeManager => Singleton(fn: NewTypeManager);
    protected virtual TypeManager NewTypeManager() => new(resolver: TypeResolver);


    public virtual LibrarySetExpressionBuilder LibrarySetExpressionBuilder => Singleton(fn: NewLibrarySetExpressionBuilder);

    protected virtual LibrarySetExpressionBuilder NewLibrarySetExpressionBuilder() =>
        new(LibraryExpressionBuilder);

    public virtual LibraryExpressionBuilder LibraryExpressionBuilder => Singleton(fn: NewLibraryExpressionBuilder);

    protected virtual LibraryExpressionBuilder NewLibraryExpressionBuilder() =>
        new LibraryExpressionBuilder(
            Logger<LibraryExpressionBuilder>(),
            ExpressionBuilder);

    protected virtual ExpressionBuilderSettings NewLibraryDefinitionBuilderSettings() =>
        ExpressionBuilderSettings.Default;

    public virtual ExpressionBuilder ExpressionBuilder => Singleton(fn: NewExpressionBuilder);

    protected virtual ExpressionBuilder NewExpressionBuilder() =>
        new ExpressionBuilder(
            Logger<ExpressionBuilder>(),
            Singleton(fn: NewLibraryDefinitionBuilderSettings),
            CqlOperatorsBinder,
            TypeManager,
            TypeConverter,
            TypeResolver,
            CqlContextBinder,
            ExpressionConverter);
}