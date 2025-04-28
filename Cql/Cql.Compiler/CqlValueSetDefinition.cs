using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler.Expressions;

namespace Hl7.Cql.Compiler;

internal class CqlValueSetDefinition(
    LambdaExpression lambda,
    string definitionName,
    string valueSetId,
    string? valueSetVersion)
    : CqlDefinition(lambda, definitionName) {
    public string ValueSetId { get; } = valueSetId;
    public string? ValueSetVersion { get; } = valueSetVersion;
}