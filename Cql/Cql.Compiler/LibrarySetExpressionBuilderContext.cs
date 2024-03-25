using System.Diagnostics;
using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler;

[DebuggerDisplay("{DebuggerView}")]
internal partial class ContextualLibrarySetExpressionBuilder : IContextualExpressionBuilder
{
    private readonly ILoggerFactory _loggerFactory;
    private readonly OperatorBinding _operatorBinding;
    private readonly TypeManager _typeManager;
    private readonly ExpressionBuilderSettings _expressionBuilderSettings;
    private readonly LibrarySet _librarySet;
    private readonly BuilderContextInfo _contextInfo;
    private readonly DefinitionDictionary<LambdaExpression> _allDefinitions;

    public ContextualLibrarySetExpressionBuilder(
        ILoggerFactory loggerFactory,
        OperatorBinding operatorBinding,
        TypeManager typeManager,
        ExpressionBuilderSettings expressionBuilderSettings,
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression> definitions)
    {
        _loggerFactory = loggerFactory;
        _operatorBinding = operatorBinding;
        _typeManager = typeManager;
        _expressionBuilderSettings = expressionBuilderSettings;
        _librarySet = librarySet;
        _allDefinitions = definitions;
        _contextInfo = new BuilderContextInfo("LibrarySet", Name: _librarySet.Name!);
    }

    IContextualExpressionBuilder? IContextualExpressionBuilder.OuterContext => null;

    BuilderContextInfo IContextualExpressionBuilder.ContextInfo => _contextInfo;

    public LibrarySet LibrarySet => _librarySet;

    public string DebuggerView => this.GetDebuggerView();

    public ContextualLibraryExpressionBuilder CreateContextualLibraryExpressionBuilder(
        Library library,
        DefinitionDictionary<LambdaExpression> definitions) =>
        new(library, _expressionBuilderSettings, _operatorBinding, definitions, _typeManager, _loggerFactory, this);

}