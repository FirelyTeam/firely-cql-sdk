using System.Diagnostics;

namespace Hl7.Cql.Compiler.Builders;

partial class LibraryExpressionBuilder 
{
    [DebuggerDisplay("{DebuggerView}")]
    protected partial class Context : ILibraryExpressionBuilderContext
    {
        IBuilderContext? IBuilderContext.OuterBuilderContext => LibrarySetContext;

        BuilderContextDebuggerInfo? IBuilderContext.DebuggerInfo => BuilderContextDebuggerInfo.FromElement(Library);

        public string DebuggerView => this.GetDebuggerView();

    }
}