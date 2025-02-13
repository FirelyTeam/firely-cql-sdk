using System.Linq.Expressions;
using Hl7.Cql.Abstractions.Infrastructure;
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
        librarySetExpressionBuilder.BuildEachLibraryDefinitions(librarySet, librarySetDefinitions).ForEach();
        return librarySetDefinitions;
    }
}