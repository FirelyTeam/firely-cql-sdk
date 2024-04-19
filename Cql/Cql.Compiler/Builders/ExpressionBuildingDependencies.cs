using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler.Binders;
using Hl7.Cql.Conversion;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler.Builders;

/// <summary>
/// Since the same dependencies are passed to all the *ExpressionBuilder classes, they are grouped together in this class.
/// </summary>
internal class ExpressionBuildingDependencies(
    ILoggerFactory LoggerFactory,
    OperatorsBinder operatorsBinder,
    TypeManager TypeManager,
    TypeConverter TypeConverter,
    ContextBinder ContextBinder,
    LibraryDefinitionBuilderSettings LibraryDefinitionBuilderSettings)
{
    public ILoggerFactory LoggerFactory { get; } = LoggerFactory;
    public OperatorsBinder OperatorsBinder { get; } = operatorsBinder;
    public ContextBinder ContextBinder { get; } = ContextBinder;
    public TypeConverter TypeConverter { get; } = TypeConverter;
    public TypeManager TypeManager { get; } = TypeManager;
    public LibraryDefinitionBuilderSettings LibraryDefinitionBuilderSettings { get; } = LibraryDefinitionBuilderSettings;
    public TypeResolver TypeResolver => TypeManager.Resolver;
}