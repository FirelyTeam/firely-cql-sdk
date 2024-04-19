using System.Diagnostics;

namespace Hl7.Cql.Compiler;

[DebuggerDisplay("{DebuggerView}")]
partial class LibraryExpressionBuilder : IBuilderNode
{

    IBuilderNode? IBuilderNode.OuterBuilder => LibrarySetContext;

    BuilderDebuggerInfo? IBuilderNode.BuilderDebuggerInfo => BuilderDebuggerInfo.FromElement(Library);

    public string DebuggerView => this.GetDebuggerView();

}