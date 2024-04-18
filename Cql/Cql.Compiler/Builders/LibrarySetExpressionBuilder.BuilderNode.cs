using System.Diagnostics;

namespace Hl7.Cql.Compiler.Builders;

[DebuggerDisplay("{DebuggerView}")]
internal partial class LibrarySetExpressionBuilder : ILibrarySetExpressionBuilder
{
    IBuilderNode? IBuilderNode.OuterBuilder => null;

    BuilderDebuggerInfo? IBuilderNode.BuilderDebuggerInfo => _debuggerInfo;

    public string DebuggerView => this.GetDebuggerView();
}