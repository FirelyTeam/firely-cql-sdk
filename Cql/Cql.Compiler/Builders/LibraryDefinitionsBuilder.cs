using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Represents a builder for library definitions.
/// </summary>
internal class LibraryDefinitionsBuilder
{
    private readonly ExpressionBuildingDependencies _dependencies;

    /// <summary>
    /// Initializes a new instance of the <see cref="LibraryDefinitionsBuilder"/> class.
    /// </summary>
    public LibraryDefinitionsBuilder(
        ExpressionBuildingDependencies dependencies)
    {
        _dependencies = dependencies;
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
        new LibrarySetExpressionBuilder(_dependencies, librarySet, definitions ?? new())
            .ProcessLibrarySet();

    /// <summary>
    /// Processes the library and returns the definition dictionary of lambda expressions.
    /// </summary>
    /// <param name="library">The library to process.</param>
    /// <param name="definitions">The optional existing definition dictionary.</param>
    /// <returns>The definition dictionary of lambda expressions.</returns>
    public DefinitionDictionary<LambdaExpression> ProcessLibrary(
        Library library,
        DefinitionDictionary<LambdaExpression>? definitions = null) =>
        new LibraryExpressionBuilder(_dependencies, library, definitions ?? new())
            .ProcessLibrary();
}