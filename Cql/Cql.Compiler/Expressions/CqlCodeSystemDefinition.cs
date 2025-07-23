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

/// <seealso cref="CodeSystemDef"/>
/// <seealso cref="CqlCodeSystem"/>
/// <seealso cref="CqlCodeSystemDefinitionAttribute"/>
internal class CqlCodeSystemDefinition(
    string name,
    CqlCodeSystem codeSystem)
    : CqlDefinition(name)
{
    public CqlCodeSystem CodeSystem { get; } = codeSystem;
    public override Type ReturnType => typeof(CqlCodeSystem);
}