using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Compiler;

internal class LibrarySetExpressionBuilder
{
    private readonly ILogger<LibrarySetExpressionBuilder> _logger;
    private readonly LibraryExpressionBuilder _libraryExpressionBuilder;

    public LibrarySetExpressionBuilder(
        ILogger<LibrarySetExpressionBuilder> logger, 
        LibraryExpressionBuilder libraryExpressionBuilder)
    {
        _logger = logger;
        _libraryExpressionBuilder = libraryExpressionBuilder;
    }

    public LibrarySetExpressionBuilderContext CreateContext(
        LibrarySet librarySet,
        ExpressionDefinitionDictionary definitions) =>
        new LibrarySetExpressionBuilderContext(librarySet, definitions);

    public ExpressionDefinitionDictionary ProcessLibrarySet(
        LibrarySet librarySet,
        ExpressionDefinitionDictionary? definitions = null)

    {
        definitions ??= new();
        var libsCtx = CreateContext(librarySet, definitions);
        ProcessLibrarySet(libsCtx);
        return definitions;
    }

    private void ProcessLibrarySet(LibrarySetExpressionBuilderContext libsCtx)
    {
        foreach (var library in libsCtx.LibrarySet)
        { 
            var packageDefinitions = _libraryExpressionBuilder.ProcessLibrary(library, libsCtx);
            libsCtx.MergeDefinitions(packageDefinitions);
        }
    }
}