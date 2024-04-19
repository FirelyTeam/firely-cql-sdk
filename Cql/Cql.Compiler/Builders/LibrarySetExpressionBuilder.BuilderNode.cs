using System.Diagnostics;

namespace Hl7.Cql.Compiler.Builders;

[DebuggerDisplay("{DebuggerView}")]
internal partial class LibrarySetExpressionBuilder : ILibrarySetExpressionBuilderContext
{
    IBuilderContext? IBuilderContext.OuterBuilderContext => null;

    BuilderContextDebuggerInfo? IBuilderContext.DebuggerInfo => _debuggerInfo;

    public string DebuggerView => this.GetDebuggerView();
}