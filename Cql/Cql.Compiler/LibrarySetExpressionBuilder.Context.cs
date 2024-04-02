using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler;

internal partial class LibrarySetExpressionBuilder : IBuilderNode
{
    private readonly ILoggerFactory _loggerFactory;
    private readonly OperatorBinding _operatorBinding;
    private readonly TypeManager _typeManager;
    private readonly LibraryDefinitionBuilderSettings _libraryDefinitionBuilderSettings;
    private readonly LibrarySet _librarySet;
    private readonly BuilderDebuggerInfo _debuggerInfo;
    public DefinitionDictionary<LambdaExpression> LibrarySetDefinitions { get; }

    public LibrarySetExpressionBuilder(
        ILoggerFactory loggerFactory,
        OperatorBinding operatorBinding,
        TypeManager typeManager,
        LibraryDefinitionBuilderSettings libraryDefinitionBuilderSettings,
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression> definitions)
    {
        // External Services
        _loggerFactory = loggerFactory;
        _operatorBinding = operatorBinding;
        _typeManager = typeManager;
        _libraryDefinitionBuilderSettings = libraryDefinitionBuilderSettings;

        // External State
        _librarySet = librarySet;
        LibrarySetDefinitions = definitions;

        // Internal State
        _debuggerInfo = new BuilderDebuggerInfo("LibrarySet", Name: _librarySet.Name!);
    }

    public LibrarySet LibrarySet => _librarySet;

    public LibraryExpressionBuilder CreateLibraryExpressionBuilder(
        Library library,
        DefinitionDictionary<LambdaExpression>? definitions = null) =>
        new(library, _libraryDefinitionBuilderSettings, _operatorBinding, definitions ?? new(), _typeManager, _loggerFactory, this);
}