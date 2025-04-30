/*
 * Copyright (c) 2025, Firely and NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Compiler.Expressions;

/// <seealso cref="CodeDef"/>
/// <seealso cref="CqlCodeDefinitionAttribute"/>
internal class CqlCodeDefinition(
    string name,
    CqlCode code)
    : CqlDefinition(null!, name) {
    public CqlCode Code { get; } = code;
}