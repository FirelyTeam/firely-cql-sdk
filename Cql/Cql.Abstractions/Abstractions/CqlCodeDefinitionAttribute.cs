/*
 * Copyright (c) 2025, Firely and NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Abstractions;

/// <summary>
/// Declares that this method or property is translated from an ELM code definition.
/// </summary>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public class CqlCodeDefinitionAttribute(
    string definitionName,
    string codeId,
    string? codeSystem = null,
    string? codeVersion = null,
    string? codeDisplay = null) : CqlDefinitionAttribute(definitionName)
{
    public string CodeId { get; } = codeId;
    public string? CodeSystem { get; } = codeSystem;
    public string? CodeVersion { get; } = codeVersion;
    public string? CodeDisplay { get; } = codeDisplay;
}
