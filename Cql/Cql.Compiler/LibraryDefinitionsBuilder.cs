using System.Linq.Expressions;
using Hl7.Cql.Conversion;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Represents a builder for library definitions.
/// </summary>
internal class LibraryDefinitionsBuilder
{
    /// <summary>
    /// The context parameter for expressions.
    /// </summary>
    public static readonly ParameterExpression ContextParameter = Expression.Parameter(typeof(CqlContext), "context");

    private readonly TypeManager _typeManager;
    private readonly TypeConverter _typeConverter;
    private readonly ILoggerFactory _loggerFactory;
    private readonly OperatorBinding _operatorBinding;

    /// <summary>
    /// Initializes a new instance of the <see cref="LibraryDefinitionsBuilder"/> class.
    /// </summary>
    /// <param name="loggerFactory">The logger factory.</param>
    /// <param name="operatorBinding">The operator binding.</param>
    /// <param name="typeManager">The type manager.</param>
    /// <param name="typeConverter">The type converter.</param>
    public LibraryDefinitionsBuilder(
        ILoggerFactory loggerFactory,
        OperatorBinding operatorBinding,
        TypeManager typeManager,
        TypeConverter typeConverter)
    {
        _typeManager = typeManager;
        _loggerFactory = loggerFactory;
        _operatorBinding = operatorBinding;
        _typeConverter = typeConverter;
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
        new LibrarySetExpressionBuilder(_loggerFactory, _operatorBinding, _typeManager, _typeConverter, LibraryDefinitionBuilderSettings.Default, librarySet, definitions ?? new())
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
        new LibraryExpressionBuilder(_loggerFactory, _operatorBinding, _typeManager, _typeConverter, library, LibraryDefinitionBuilderSettings.Default, definitions ?? new())
            .ProcessLibrary();

    /// <summary>
    /// Creates a lambda expression for the specified library and expression.
    /// </summary>
    /// <param name="library">The library.</param>
    /// <param name="expression">The expression.</param>
    /// <param name="lambdas">The optional existing definition dictionary of lambda expressions.</param>
    /// <returns>The lambda expression.</returns>
    public LambdaExpression Lambda(
        Library library,
        Elm.Expression expression,
        DefinitionDictionary<LambdaExpression>? lambdas = null)
    {
        var librarySet = CreateLibrarySetOfOne(library);
        var translated = CreateLibrarySetExpressionBuilder(librarySet)
            .CreateLibraryExpressionBuilder(library)
            .CreateExpressionBuilder()
            .TranslateExpression(expression);
        var parameter = Expression.Parameter(typeof(CqlContext), "rtx");
        var lambda = Expression.Lambda(translated, parameter);
        return lambda;
    }

    private static LibrarySet CreateLibrarySetOfOne(Library library) =>
        new($"Single LibrarySet `{library}`", library);

    private LibrarySetExpressionBuilder CreateLibrarySetExpressionBuilder(LibrarySet librarySet, DefinitionDictionary<LambdaExpression>? lambdas = null) =>
        new(_loggerFactory, _operatorBinding, _typeManager, _typeConverter, LibraryDefinitionBuilderSettings.Default, librarySet, lambdas ?? new());
}