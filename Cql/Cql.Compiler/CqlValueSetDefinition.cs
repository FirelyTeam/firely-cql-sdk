using Hl7.Cql.Abstractions;

namespace Hl7.Cql.Compiler;

internal class CqlValueSetDefinition(
    LambdaExpression lambda,
    string name,
    string valueSetId,
    string? valueSetVersion)
    : CqlDefinition(lambda, name) {
    public string ValueSetId { get; } = valueSetId;
    public string? ValueSetVersion { get; } = valueSetVersion;
}