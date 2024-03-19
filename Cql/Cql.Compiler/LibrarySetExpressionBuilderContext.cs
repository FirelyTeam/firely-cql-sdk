using System.Diagnostics;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler;

[DebuggerDisplay("{DebuggerView}")]
internal class LibrarySetExpressionBuilderContext : IBuilderContext
{
    private readonly LibrarySet _librarySet;
    public ExpressionDefinitionDictionary AllDefinitions { get; }
    private readonly BuilderContextInfo _contextInfo;

    public LibrarySetExpressionBuilderContext(
        LibrarySet librarySet,
        ExpressionDefinitionDictionary definitions)
    {
        _librarySet = librarySet;
        AllDefinitions = definitions;
        _contextInfo = new BuilderContextInfo("LibrarySet", Name: _librarySet.Name!);
    }

    IBuilderContext? IBuilderContext.OuterContext => null;

    BuilderContextInfo IBuilderContext.ContextInfo => _contextInfo;

    public LibrarySet LibrarySet => _librarySet;

    public void MergeDefinitions(ExpressionDefinitionDictionary definitions) => 
        AllDefinitions.Merge(definitions);

    public string DebuggerView => this.GetDebuggerView();
}