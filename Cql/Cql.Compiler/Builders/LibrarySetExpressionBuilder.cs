using System.Linq.Expressions;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler.Builders;

internal partial class LibrarySetExpressionBuilder : ILibrarySetExpressionBuilder
{
    private readonly ILibraryExpressionBuilder _libraryExpressionBuilder;

    public LibrarySetExpressionBuilder(
        ILibraryExpressionBuilder libraryExpressionBuilder)
    {
        _libraryExpressionBuilder = libraryExpressionBuilder;
    }

    public DefinitionDictionary<LambdaExpression> ProcessLibrarySet(
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression>? librarySetDefinitions = null)
    {
        Context context = new(this, librarySetDefinitions ?? new(), librarySet);
        return context.ProcessLibrarySet();
    }

    protected partial class Context
    {
        private readonly ILibraryExpressionBuilder _libraryExpressionBuilder;

        public Context(
            LibrarySetExpressionBuilder libraryExpressionBuilder,
            DefinitionDictionary<LambdaExpression> librarySetDefinitions,
            LibrarySet librarySet)
        {
            _libraryExpressionBuilder = libraryExpressionBuilder._libraryExpressionBuilder;
            LibrarySetDefinitions = librarySetDefinitions;
            LibrarySet = librarySet;
            DebuggerInfo = new BuilderContextDebuggerInfo("LibrarySet", Name: LibrarySet!.Name!);
        }

        public DefinitionDictionary<LambdaExpression> LibrarySetDefinitions { get; }
        public LibrarySet LibrarySet { get; }

        public DefinitionDictionary<LambdaExpression> ProcessLibrarySet() =>
            this.CatchRethrowExpressionBuildingException(_ =>
            {
                foreach (var library in LibrarySet)
                {
                    var librarySetDefinitions = _libraryExpressionBuilder.ProcessLibrary(library, null, this);
                    LibrarySetDefinitions.Merge(librarySetDefinitions);
                }

                return LibrarySetDefinitions;
            });
    }
}