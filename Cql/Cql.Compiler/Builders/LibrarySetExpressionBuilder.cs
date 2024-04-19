using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler.Builders;

internal partial class LibrarySetExpressionBuilder
{
    private readonly ILibraryExpressionBuilderFactory _libraryExpressionBuilderFactory;
    private readonly LibrarySet _librarySet;
    private readonly BuilderContextDebuggerInfo _debuggerInfo;

    public LibrarySetExpressionBuilder(
        ILibraryExpressionBuilderFactory libraryExpressionBuilderFactory,
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression> definitions)
    {
        // External Services
        _libraryExpressionBuilderFactory = libraryExpressionBuilderFactory;

        // External State
        _librarySet = librarySet;
        LibrarySetDefinitions = definitions;

        // Internal State
        _debuggerInfo = new BuilderContextDebuggerInfo("LibrarySet", Name: _librarySet.Name!);
    }

    public DefinitionDictionary<LambdaExpression> ProcessLibrarySet() =>
        this.CatchRethrowExpressionBuildingException(_ =>
        {
            foreach (var library in LibrarySet)
            {
                var librarySetDefinitions = NewLibraryExpressionBuilder(library).ProcessLibrary();
                LibrarySetDefinitions.Merge(librarySetDefinitions);
            }

            return LibrarySetDefinitions;
        });

    public DefinitionDictionary<LambdaExpression> LibrarySetDefinitions { get; }

    public LibrarySet LibrarySet => _librarySet;

    private LibraryExpressionBuilder NewLibraryExpressionBuilder(
        Library library,
        DefinitionDictionary<LambdaExpression>? libraryDefinitions = null) =>
        _libraryExpressionBuilderFactory.New(library, libraryDefinitions, this);
}