using Hl7.Cql.Compiler.Expressions;

namespace Hl7.Cql.Compiler;

internal class CqlValueSetDefinition(
    LambdaExpression lambda,
    string declarationName,
    params (string tagName, string[] tagValues)[] tags)
    : CqlDefinition(lambda, declarationName, tags);