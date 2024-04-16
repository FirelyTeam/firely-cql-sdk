using Hl7.Cql.Abstractions;
using Hl7.Cql.Conversion;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Since the same dependencies are passed to all the *ExpressionBuilder classes, they are grouped together in this class.
/// </summary>
internal class ExpressionBuildingDependencies(
    ILoggerFactory LoggerFactory,
    OperatorBinder OperatorBinder,
    TypeManager TypeManager,
    TypeConverter TypeConverter,
    LibraryDefinitionBuilderSettings LibraryDefinitionBuilderSettings)
{
    public ILoggerFactory LoggerFactory { get; } = LoggerFactory;
    public OperatorBinder OperatorBinder { get; } = OperatorBinder;
    public TypeConverter TypeConverter { get; } = TypeConverter;
    public TypeManager TypeManager { get; } = TypeManager;
    public LibraryDefinitionBuilderSettings LibraryDefinitionBuilderSettings { get; } = LibraryDefinitionBuilderSettings;
    public TypeResolver TypeResolver => TypeManager.Resolver;
}