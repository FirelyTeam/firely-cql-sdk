using Hl7.Cql.Abstractions;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Compiler;

/// <seealso cref="ValueSetDef"/>
/// <seealso cref="CqlValueSet"/>
/// <seealso cref="CqlValueSetDefinitionAttribute"/>
internal class CqlValueSetDefinition(
    string name,
    string valueSetId,
    string? valueSetVersion)
    : CqlDefinition(name) {
    public string ValueSetId { get; } = valueSetId;
    public string? ValueSetVersion { get; } = valueSetVersion;
    public override Type ReturnType => typeof(CqlValueSet);
}