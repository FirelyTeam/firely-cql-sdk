namespace Hl7.Cql.Compiler.Expressions;

internal class CqlConceptDefinition(
    LambdaExpression lambda,
    string declarationName,
    params (string tagName, string[] tagValues)[] tags)
    : CqlDefinition(lambda, declarationName, tags);