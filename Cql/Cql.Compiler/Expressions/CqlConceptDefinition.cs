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

namespace Hl7.Cql.Compiler.Expressions;

/// <seealso cref="ConceptDef"/>
/// <seealso cref="CqlConcept"/>
/// <seealso cref="CqlConceptDefinitionAttribute"/>
internal class CqlConceptDefinition(
    string name,
    string? display,
    IReadOnlyList<CqlCode> codes)
    : CqlDefinition(name) {
    public string? Display { get; } = display;
    public IReadOnlyList<CqlCode> Codes { get; } = codes;
    public override Type ReturnType => typeof(CqlConcept);
}