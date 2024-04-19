using System.Linq.Expressions;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler.Builders;

internal interface ILibraryExpressionBuilder
{
    DefinitionDictionary<LambdaExpression> ProcessLibrary(
        Library library,
        DefinitionDictionary<LambdaExpression>? libraryDefinitions = null,
        ILibrarySetExpressionBuilderContext? libsCtx = null);
}