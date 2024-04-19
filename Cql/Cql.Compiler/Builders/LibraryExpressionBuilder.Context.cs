using System.Diagnostics;

namespace Hl7.Cql.Compiler.Builders;

[DebuggerDisplay("{DebuggerView}")]
partial class LibraryExpressionBuilder : ILibraryExpressionBuilderContext
{

    IBuilderContext? IBuilderContext.OuterBuilderContext => LibrarySetContext;

    BuilderContextDebuggerInfo? IBuilderContext.DebuggerInfo => BuilderContextDebuggerInfo.FromElement(Library);

    public string DebuggerView => this.GetDebuggerView();

}