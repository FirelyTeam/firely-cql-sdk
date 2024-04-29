using System.Diagnostics;

namespace Hl7.Cql.Compiler;

[DebuggerDisplay("{DebuggerView}")]
partial class LibraryExpressionBuilderContext : ILibraryExpressionBuilderContext
{
    IBuilderContext? IBuilderContext.OuterBuilderContext => LibrarySetContext;

    BuilderContextDebuggerInfo? IBuilderContext.DebuggerInfo => BuilderContextDebuggerInfo.FromElement(Library);

    public string DebuggerView => this.GetDebuggerView();

}