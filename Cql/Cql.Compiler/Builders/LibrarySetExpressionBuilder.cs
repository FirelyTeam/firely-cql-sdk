using System.Linq.Expressions;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler.Builders;

internal partial class LibrarySetExpressionBuilder
{
    private readonly ILibraryExpressionBuilderFactory _libraryExpressionBuilderFactory;

    public LibrarySetExpressionBuilder(
        ILibraryExpressionBuilderFactory libraryExpressionBuilderFactory)
    {
        // External Services
        _libraryExpressionBuilderFactory = libraryExpressionBuilderFactory;
    }

    public DefinitionDictionary<LambdaExpression> ProcessLibrarySet(
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression>? definitions = null)
    {
        Context context = new(definitions ?? new(), librarySet);
        return context.ProcessLibrarySet(_libraryExpressionBuilderFactory);
    }
}