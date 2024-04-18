using System.Diagnostics;

namespace Hl7.Cql.Compiler.Builders;

[DebuggerDisplay("{DebuggerView}")]
partial class LibraryExpressionBuilder : ILibraryExpressionBuilder
{

    IBuilderNode? IBuilderNode.OuterBuilder => LibrarySetContext;

    BuilderDebuggerInfo? IBuilderNode.BuilderDebuggerInfo => BuilderDebuggerInfo.FromElement(Library);

    public string DebuggerView => this.GetDebuggerView();

}