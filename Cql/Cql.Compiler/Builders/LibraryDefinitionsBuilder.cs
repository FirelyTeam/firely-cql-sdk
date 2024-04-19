using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler.Builders;

/// <summary>
/// Represents a builder for library definitions.
/// </summary>
internal class LibraryDefinitionsBuilder
{
    private readonly ILibrarySetExpressionBuilderFactory _librarySetExpressionBuilderFactory;
    private readonly ILibraryExpressionBuilderFactory _libraryExpressionBuilderFactory;

    /// <summary>
    /// Initializes a new instance of the <see cref="LibraryDefinitionsBuilder"/> class.
    /// </summary>
    public LibraryDefinitionsBuilder(
        ILibrarySetExpressionBuilderFactory librarySetExpressionBuilderFactory,
        ILibraryExpressionBuilderFactory libraryExpressionBuilderFactory)
    {
        _librarySetExpressionBuilderFactory = librarySetExpressionBuilderFactory;
        _libraryExpressionBuilderFactory = libraryExpressionBuilderFactory;
    }

    /// <summary>
    /// Processes the library set and returns the definition dictionary of lambda expressions.
    /// </summary>
    /// <param name="librarySet">The library set to process.</param>
    /// <param name="definitions">The optional existing definition dictionary.</param>
    /// <returns>The definition dictionary of lambda expressions.</returns>
    public DefinitionDictionary<LambdaExpression> ProcessLibrarySet(
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression>? definitions = null) =>
        NewLibrarySetExpressionBuilder()
            .ProcessLibrarySet(librarySet, definitions);

    /// <summary>
    /// Processes the library and returns the definition dictionary of lambda expressions.
    /// </summary>
    /// <param name="library">The library to process.</param>
    /// <param name="libraryDefinitions">The optional existing definition dictionary.</param>
    /// <returns>The definition dictionary of lambda expressions.</returns>
    public DefinitionDictionary<LambdaExpression> ProcessLibrary(
        Library library,
        DefinitionDictionary<LambdaExpression>? libraryDefinitions = null) =>
        NewLibraryExpressionBuilder(library, libraryDefinitions)
            .ProcessLibrary();

    private LibrarySetExpressionBuilder NewLibrarySetExpressionBuilder() =>
        _librarySetExpressionBuilderFactory.New();

    private LibraryExpressionBuilder NewLibraryExpressionBuilder(
        Library library,
        DefinitionDictionary<LambdaExpression>? libraryDefinitions = null) =>
        _libraryExpressionBuilderFactory.New(library, libraryDefinitions);

}