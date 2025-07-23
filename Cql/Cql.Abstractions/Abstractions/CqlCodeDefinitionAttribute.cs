/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Abstractions;

/// <summary>
/// Represents an attribute that declares a method or property as being translated from an ELM code definition.
/// </summary>
/// <remarks>
/// This attribute is used to associate a method or property with a specific code definition in ELM. 
/// It provides metadata such as the code identifier, code system, version, and display name.
/// </remarks>
/// <param name="name">The name of the ELM code definition.</param>
/// <param name="codeId">The unique identifier of the code within the code system.</param>
/// <param name="codeSystem">The URI of the code system to which the code belongs. This parameter is optional.</param>
/// <param name="codeVersion">The version of the code system. This parameter is optional.</param>
/// <param name="codeDisplay">The human-readable display name of the code. This parameter is optional.</param>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public sealed class CqlCodeDefinitionAttribute
(
    string name,
    string codeId,
    string? codeSystem = null,
    string? codeVersion = null,
    string? codeDisplay = null) : CqlDefinitionAttribute(name)
{
    /// <summary>
    /// The unique identifier of the code within the code system.
    /// </summary>
    public string CodeId { get; } = codeId;

    /// <summary>
    /// The URI of the code system to which the code belongs. This property is optional.
    /// </summary>
    public string? CodeSystem { get; } = codeSystem;

    /// <summary>
    /// The version of the code system. This property is optional.
    /// </summary>
    public string? CodeVersion { get; } = codeVersion;

    /// <summary>
    /// The human-readable display name of the code. This property is optional.
    /// </summary>
    public string? CodeDisplay { get; } = codeDisplay;
}
