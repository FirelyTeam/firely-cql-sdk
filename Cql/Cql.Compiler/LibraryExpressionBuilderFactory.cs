using System;
using Hl7.Cql.Compiler;
using Hl7.Cql.Conversion;
using Hl7.Cql.Fhir;
using Hl7.Fhir.Introspection;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Packaging;

/// <summary>
/// This creates all services necessary for a <see cref="IServiceProvider"/>.
/// The idea is not to inject this into service types, it's purpose is to
/// be one alternative to the .net hosting's <see cref="LibraryExpressionBuilder"/>.
/// </summary>
internal class LibraryExpressionBuilderFactory
{
    private readonly ExpressionBuilderFactory _expressionBuilderFactory;
    private readonly Lazy<LibraryExpressionBuilder> _libraryExpressionsBuilder;

    public LibraryExpressionBuilderFactory(ILoggerFactory loggerFactory, int cacheSize = 0)
    {
        _expressionBuilderFactory = new ExpressionBuilderFactory(loggerFactory, cacheSize);
        _libraryExpressionsBuilder = Deferred(() => new LibraryExpressionBuilder(Logger<LibraryExpressionBuilder>(), ExpressionBuilder, CqlOperatorsBinding));


        static Lazy<T> Deferred<T>(Func<T> deferred) => new(deferred);

        ILogger<T> Logger<T>() => loggerFactory.CreateLogger<T>();
    }

    public ModelInspector ModelInspector => _expressionBuilderFactory.ModelInspector;
    public TypeConverter TypeConverter => _expressionBuilderFactory.TypeConverter;
    public FhirTypeResolver FhirTypeResolver => _expressionBuilderFactory.FhirTypeResolver;
    public CqlOperatorsBinding CqlOperatorsBinding => _expressionBuilderFactory.CqlOperatorsBinding;
    public TypeManager TypeManager => _expressionBuilderFactory.TypeManager;
    public ExpressionBuilder ExpressionBuilder => _expressionBuilderFactory.ExpressionBuilder;
    public LibraryExpressionBuilder LibraryExpressionBuilder => _libraryExpressionsBuilder.Value;
}