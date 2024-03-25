using System.Diagnostics;
using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler;

[DebuggerDisplay("{DebuggerView}")]
internal partial class LibrarySetExpressionBuilder : IBuilderNode
{
    private readonly ILoggerFactory _loggerFactory;
    private readonly OperatorBinding _operatorBinding;
    private readonly TypeManager _typeManager;
    private readonly ExpressionBuilderSettings _expressionBuilderSettings;
    private readonly LibrarySet _librarySet;
    private readonly BuilderDebuggerInfo _debuggerInfo;
    private readonly DefinitionDictionary<LambdaExpression> _allDefinitions;

    public LibrarySetExpressionBuilder(
        ILoggerFactory loggerFactory,
        OperatorBinding operatorBinding,
        TypeManager typeManager,
        ExpressionBuilderSettings expressionBuilderSettings,
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression> definitions)
    {
        // External Services
        _loggerFactory = loggerFactory;
        _operatorBinding = operatorBinding;
        _typeManager = typeManager;
        _expressionBuilderSettings = expressionBuilderSettings;

        // External State
        _librarySet = librarySet;
        _allDefinitions = definitions;

        // Internal State
        _debuggerInfo = new BuilderDebuggerInfo("LibrarySet", Name: _librarySet.Name!);
    }

    IBuilderNode? IBuilderNode.OuterBuilder => null;

    BuilderDebuggerInfo IBuilderNode.BuilderDebuggerInfo => _debuggerInfo;

    public LibrarySet LibrarySet => _librarySet;

    public string DebuggerView => this.GetDebuggerView();

    public LibraryExpressionBuilder CreateContextualLibraryExpressionBuilder(
        Library library,
        DefinitionDictionary<LambdaExpression> definitions) =>
        new(library, _expressionBuilderSettings, _operatorBinding, definitions, _typeManager, _loggerFactory, this);

}