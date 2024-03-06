using System;
using Hl7.Cql.Fhir;
using Hl7.Fhir.Introspection;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler;

/// <summary>
/// This creates all services necessary for a <see cref="ExpressionBuilderService"/>.
/// The idea is not to inject this into service types, it's purpose is to
/// be one alternative to the .net hosting's <see cref="IServiceProvider"/>.
/// </summary>

internal class ExpressionBuilderFactory
{
    private readonly Lazy<FhirTypeResolver> _FhirTypeResolver;
    private readonly Lazy<Conversion.TypeConverter> _TypeConverter;
    private readonly Lazy<CqlOperatorsBinding> _CqlOperatorsBinding;
    private readonly Lazy<TypeManager> _TypeManager;
    private readonly Lazy<ExpressionBuilderService> _ExpressionBuilderService;

    public ExpressionBuilderFactory(ILoggerFactory loggerFactory, int? cacheSize = null)
    {
        _FhirTypeResolver = Deferred(() => new FhirTypeResolver(ModelInspector));
        _TypeConverter = Deferred(() => FhirTypeConverter.Create(ModelInspector, cacheSize));
        _CqlOperatorsBinding = Deferred(() => new CqlOperatorsBinding(FhirTypeResolver, TypeConverter));
        _TypeManager = Deferred(() => new TypeManager(FhirTypeResolver));
        _ExpressionBuilderService = Deferred(() => new ExpressionBuilderService(Logger<ExpressionBuilder>(), CqlOperatorsBinding, TypeManager));


        static Lazy<T> Deferred<T>(Func<T> deferred) => new(deferred);

        ILogger<T> Logger<T>() => loggerFactory.CreateLogger<T>();
    }

    public ModelInspector ModelInspector => Hl7.Fhir.Model.ModelInfo.ModelInspector;
    public Conversion.TypeConverter TypeConverter => _TypeConverter.Value;
    public FhirTypeResolver FhirTypeResolver => _FhirTypeResolver.Value;
    public CqlOperatorsBinding CqlOperatorsBinding => _CqlOperatorsBinding.Value;
    public TypeManager TypeManager => _TypeManager.Value;
    public ExpressionBuilderService ExpressionBuilderService => _ExpressionBuilderService.Value;

}