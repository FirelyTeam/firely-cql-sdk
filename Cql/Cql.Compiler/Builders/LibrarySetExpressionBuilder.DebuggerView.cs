using System.Diagnostics;

namespace Hl7.Cql.Compiler.Builders;

internal partial class LibrarySetExpressionBuilder 
{
    [DebuggerDisplay("{DebuggerView}")]
    protected partial class Context : ILibrarySetExpressionBuilderContext
    {
        public IBuilderContext? OuterBuilderContext => null;
        public BuilderContextDebuggerInfo? DebuggerInfo { get; }
        public string DebuggerView => this.GetDebuggerView();
    }
}