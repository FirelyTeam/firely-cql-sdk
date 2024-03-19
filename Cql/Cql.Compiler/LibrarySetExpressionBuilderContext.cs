using System.Diagnostics;
using System.Linq.Expressions;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler;

[DebuggerDisplay("{DebuggerView}")]
internal class LibrarySetExpressionBuilderContext : IBuilderContext
{
    private readonly LibrarySet _librarySet;
    private readonly DefinitionDictionary<LambdaExpression> _definitions;

    public LibrarySetExpressionBuilderContext(
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression> definitions)
    {
        _librarySet = librarySet;
        _definitions = definitions;
        OuterContext = null;
        ContextInfo = new BuilderContextInfo("LibrarySet", Name: _librarySet.Name!);
    }

    public IBuilderContext? OuterContext { get; }

    public BuilderContextInfo ContextInfo { get; }

    public LibrarySet LibrarySet => _librarySet;

    public void MergeDefinitions(DefinitionDictionary<LambdaExpression> definitions) => 
        _definitions.Merge(definitions);

    public string DebuggerView => this.GetDebuggerView();
}