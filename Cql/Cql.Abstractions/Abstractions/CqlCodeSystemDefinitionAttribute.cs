/*
 * Copyright (c) 2025, Firely and NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Abstractions;

/// <summary>
/// Represents an attribute used to define a CQL (Clinical Quality Language) code system.
/// This attribute is applied to methods or properties to specify metadata about the
/// associated code system, including its name, identifier, and optional version.
/// </summary>
/// <param name="name">The name of the code system being defined.</param>
/// <param name="codeSystemId">The unique identifier of the code system.</param>
/// <param name="codeSystemVersion">The version of the code system, if applicable.</param>
/// <remarks>
/// The <see cref="CqlCodeSystemDefinitionAttribute"/> is a specialized attribute derived from
/// <see cref="CqlDefinitionAttribute"/>. It is used to annotate elements with information
/// about the code system they are associated with in the context of CQL.
/// </remarks>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public sealed class CqlCodeSystemDefinitionAttribute(string name, string codeSystemId, string? codeSystemVersion) : CqlDefinitionAttribute(name) {
    /// <summary>
    /// Gets the unique identifier of the code system associated with the ELM code system definition.
    /// </summary>
    /// <remarks>
    /// The <see cref="CodeSystemId"/> property represents the identifier of the code system
    /// that is being referenced or defined in the context of the ELM (Expression Logical Model) translation.
    /// </remarks>
    public string CodeSystemId { get; } = codeSystemId;

    /// <summary>
    /// Gets the version of the code system associated with this attribute.
    /// </summary>
    /// <remarks>
    /// This property represents the version of the code system as defined in the ELM code system definition.
    /// It may be <c>null</c> if no specific version is specified.
    /// </remarks>
    public string? CodeSystemVersion { get; } = codeSystemVersion;
}