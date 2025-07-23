/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

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