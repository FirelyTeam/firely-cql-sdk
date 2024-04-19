using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler;

internal partial class LibrarySetExpressionBuilder
{
    private readonly ExpressionBuildingDependencies _dependencies;
    private readonly LibrarySet _librarySet;
    private readonly BuilderDebuggerInfo _debuggerInfo;

    public LibrarySetExpressionBuilder(
        ExpressionBuildingDependencies dependencies,
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression> definitions)
    {
        // External Services
        _dependencies = dependencies;

        // External State
        _librarySet = librarySet;
        LibrarySetDefinitions = definitions;

        // Internal State
        _debuggerInfo = new BuilderDebuggerInfo("LibrarySet", Name: _librarySet.Name!);
    }

    public DefinitionDictionary<LambdaExpression> ProcessLibrarySet() =>
        this.CatchRethrowExpressionBuildingException(_ =>
        {
            foreach (var library in LibrarySet)
            {
                var packageDefinitions = CreateLibraryExpressionBuilder(library, new()).ProcessLibrary();
                LibrarySetDefinitions.Merge(packageDefinitions);
            }

            return LibrarySetDefinitions;
        });

    public DefinitionDictionary<LambdaExpression> LibrarySetDefinitions { get; }
    public LibrarySet LibrarySet => _librarySet;

    private LibraryExpressionBuilder CreateLibraryExpressionBuilder(
        Library library,
        DefinitionDictionary<LambdaExpression>? definitions = null) =>
        new(_dependencies, library, definitions ?? new(), this);
}