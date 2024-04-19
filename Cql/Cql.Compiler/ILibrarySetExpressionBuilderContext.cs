using System.Linq.Expressions;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler;

internal interface ILibrarySetExpressionBuilderContext : IBuilderContext
{
    DefinitionDictionary<LambdaExpression> LibrarySetDefinitions { get; }
    LibrarySet LibrarySet { get; }
}