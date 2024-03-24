using System.Linq.Expressions;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler;

partial class ExpressionBuilder
{
    // private readonly ILogger<LibrarySetExpressionBuilder> _logger;
    // private readonly LibraryExpressionBuilder _libraryExpressionBuilder;
    //
    // public LibrarySetExpressionBuilder(
    //     ILogger<LibrarySetExpressionBuilder> logger, 
    //     LibraryExpressionBuilder libraryExpressionBuilder)
    // {
    //     _logger = logger;
    //     _libraryExpressionBuilder = libraryExpressionBuilder;
    // }
    //
    private ContextualLibrarySetExpressionBuilder CreateContextualLibrarySetExpressionBuilder(
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression> definitions) =>
        new ContextualLibrarySetExpressionBuilder(librarySet, definitions);

    public DefinitionDictionary<LambdaExpression> ProcessLibrarySet(
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression>? definitions = null)

    {
        definitions ??= new();
        var libsCtx = CreateContextualLibrarySetExpressionBuilder(librarySet, definitions);
        ProcessLibrarySet(libsCtx);
        return definitions;
    }

    private void ProcessLibrarySet(ContextualLibrarySetExpressionBuilder libsCtx)
    {
        foreach (var library in libsCtx.LibrarySet)
        { 
            var packageDefinitions = ProcessLibrary(library, libsCtx);
            libsCtx.MergeDefinitions(packageDefinitions);
        }
    }
}