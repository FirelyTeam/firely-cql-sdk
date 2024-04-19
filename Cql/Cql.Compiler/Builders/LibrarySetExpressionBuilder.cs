using System.Linq.Expressions;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler.Builders;

internal class LibrarySetExpressionBuilder
{
    internal readonly LibraryExpressionBuilder _libraryExpressionBuilder;

    public LibrarySetExpressionBuilder(
        LibraryExpressionBuilder libraryExpressionBuilder)
    {
        _libraryExpressionBuilder = libraryExpressionBuilder;
    }

    public DefinitionDictionary<LambdaExpression> ProcessLibrarySet(
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression>? librarySetDefinitions = null)
    {
        LibrarySetExpressionBuilderContext context = new(this, librarySetDefinitions ?? new(), librarySet);
        return context.ProcessLibrarySet();
    }
}

internal partial class LibrarySetExpressionBuilderContext
{
    private readonly LibraryExpressionBuilder _libraryExpressionBuilder;

    public LibrarySetExpressionBuilderContext(
        LibrarySetExpressionBuilder builder,
        DefinitionDictionary<LambdaExpression> librarySetDefinitions,
        LibrarySet librarySet)
    {
        _libraryExpressionBuilder = builder._libraryExpressionBuilder;
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