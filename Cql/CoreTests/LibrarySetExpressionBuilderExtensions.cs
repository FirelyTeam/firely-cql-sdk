using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Compiler;

namespace CoreTests;

internal static class LibrarySetExpressionBuilderExtensions
{
    internal static CqlDefinitionDictionary ProcessLibrarySet(
        this LibrarySetExpressionBuilder librarySetExpressionBuilder,
        LibrarySet librarySet)
    {
        CqlDefinitionDictionary definitions = new ();
        librarySetExpressionBuilder.BuildEachLibraryDefinitions(librarySet, definitions).ForEach();
        return definitions;
    }
}