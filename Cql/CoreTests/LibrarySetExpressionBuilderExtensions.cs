using System.Linq.Expressions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Runtime;

namespace CoreTests;

internal static class LibrarySetExpressionBuilderExtensions
{
    internal static DefinitionDictionary<LambdaExpression> ProcessLibrarySet(
        this LibrarySetExpressionBuilder librarySetExpressionBuilder,
        LibrarySet librarySet)
    {
        var librarySetDefinitions = new DefinitionDictionary<LambdaExpression>();
        _ = librarySetExpressionBuilder.TryBuildEachLibraryDefinitions(librarySet, librarySetDefinitions).CatchEach().Count();
        return librarySetDefinitions;
    }
}