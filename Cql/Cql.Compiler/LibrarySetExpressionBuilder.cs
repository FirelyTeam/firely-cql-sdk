using System.Linq.Expressions;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler;

partial class ExpressionBuilder
{
    public DefinitionDictionary<LambdaExpression> ProcessLibrarySet(
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression>? definitions = null) =>
        new ContextualLibrarySetExpressionBuilder( _loggerFactory, _operatorBinding, _typeManager, _settings, librarySet, definitions ?? new())
            .ProcessLibrarySet();
}

internal partial class ContextualLibrarySetExpressionBuilder
{
    public DefinitionDictionary<LambdaExpression> ProcessLibrarySet()
    {
        foreach (var library in LibrarySet)
        {
            var packageDefinitions = CreateContextualLibraryExpressionBuilder(library, new()).ProcessLibrary();
            _allDefinitions.Merge(packageDefinitions);
        }

        return _allDefinitions;
    }

}