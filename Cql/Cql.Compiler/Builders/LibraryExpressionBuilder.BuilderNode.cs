using System.Diagnostics;

namespace Hl7.Cql.Compiler.Builders;

[DebuggerDisplay("{DebuggerView}")]
partial class LibraryExpressionBuilder : ILibraryExpressionBuilderContext
{

    IBuilderNode? IBuilderNode.OuterBuilder => LibrarySetContext;

    BuilderDebuggerInfo? IBuilderNode.BuilderDebuggerInfo => BuilderDebuggerInfo.FromElement(Library);

    public string DebuggerView => this.GetDebuggerView();

}