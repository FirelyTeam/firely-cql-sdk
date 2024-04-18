using System.Linq.Expressions;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler.Builders;

internal interface ILibrarySetExpressionBuilderFactory
{
    LibrarySetExpressionBuilder New(
        LibrarySet librarySet,
        DefinitionDictionary<LambdaExpression>? definitions = null);
}