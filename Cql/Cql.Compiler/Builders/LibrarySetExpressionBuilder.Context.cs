using System.Diagnostics;
using System.Linq.Expressions;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler.Builders;


internal partial class LibrarySetExpressionBuilder
{
    [DebuggerDisplay("{DebuggerView}")]
    protected class Context : ILibrarySetExpressionBuilderContext
    {
        public Context(
            DefinitionDictionary<LambdaExpression> librarySetDefinitions,
            LibrarySet librarySet)
        {
            LibrarySetDefinitions = librarySetDefinitions;
            LibrarySet = librarySet;
            DebuggerInfo = new BuilderContextDebuggerInfo("LibrarySet", Name: LibrarySet!.Name!);
        }

        public IBuilderContext? OuterBuilderContext => null;
        public BuilderContextDebuggerInfo? DebuggerInfo { get; }
        public DefinitionDictionary<LambdaExpression> LibrarySetDefinitions { get; }
        public LibrarySet LibrarySet { get; }
        public string DebuggerView => this.GetDebuggerView();

        public DefinitionDictionary<LambdaExpression> ProcessLibrarySet(
            ILibraryExpressionBuilderFactory libraryExpressionBuilderFactory) =>
            this.CatchRethrowExpressionBuildingException(_ =>
            {
                foreach (var library in LibrarySet)
                {
                    var libraryExpressionBuilder = libraryExpressionBuilderFactory.New(library, null, this);
                    var librarySetDefinitions = libraryExpressionBuilder.ProcessLibrary();
                    LibrarySetDefinitions.Merge(librarySetDefinitions);
                }

                return LibrarySetDefinitions;
            });
    }
}