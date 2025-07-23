/*
 * Copyright (c) 2025, Firely and NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Abstractions;

/// <summary>
/// Declares that this method or property is translated from an ELM value set definition.
/// </summary>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public sealed class CqlValueSetDefinitionAttribute(
    string name,
    string valueSetId,
    string? valueSetVersion = null) : CqlDefinitionAttribute(name)
{
    /// <summary>
    /// The canonical URI of the code.
    /// </summary>
    public string ValueSetId { get; } = valueSetId;

    /// <summary>
    /// The version of the code.
    /// </summary>
    public string ValueSetVersion { get; } = valueSetVersion;
}