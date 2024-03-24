using System.Diagnostics;
using System.Linq.Expressions;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler;

[DebuggerDisplay("{DebuggerView}")]
internal class ContextualLibrarySetExpressionBuilder : IBuilderContext
{
    private readonly LibrarySet _librarySet;
    private readonly BuilderContextInfo _contextInfo;
    private readonly DefinitionDictionary<LambdaExpression> _allDefinitions;

    public ContextualLibrarySetExpressionBuilder(
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression> definitions)
    {
        _librarySet = librarySet;
        _allDefinitions = definitions;
        _contextInfo = new BuilderContextInfo("LibrarySet", Name: _librarySet.Name!);
    }

    IBuilderContext? IBuilderContext.OuterContext => null;

    BuilderContextInfo IBuilderContext.ContextInfo => _contextInfo;

    public LibrarySet LibrarySet => _librarySet;

    public void MergeDefinitions(DefinitionDictionary<LambdaExpression> definitions) => 
        _allDefinitions.Merge(definitions);

    public string DebuggerView => this.GetDebuggerView();
}