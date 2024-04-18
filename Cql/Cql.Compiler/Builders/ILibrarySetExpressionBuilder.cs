using System.Linq.Expressions;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler.Builders;

internal interface ILibrarySetExpressionBuilder : IBuilderNode
{
    DefinitionDictionary<LambdaExpression> LibrarySetDefinitions { get; }
    LibrarySet LibrarySet { get; }
}