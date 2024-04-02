using System.Diagnostics;

namespace Hl7.Cql.Compiler;

[DebuggerDisplay("{DebuggerView}")]
internal partial class LibrarySetExpressionBuilder : IBuilderNode
{
    IBuilderNode? IBuilderNode.OuterBuilder => null;

    BuilderDebuggerInfo? IBuilderNode.BuilderDebuggerInfo => _debuggerInfo;

    public string DebuggerView => this.GetDebuggerView();
}