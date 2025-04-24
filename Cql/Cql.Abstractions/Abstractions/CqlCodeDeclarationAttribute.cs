/*
 * Copyright (c) 2025, Firely and NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Abstractions;

/// <summary>
/// Declares that this method or property is translated from an ELM code expression.
/// </summary>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public class CqlCodeDeclarationAttribute(
    string declarationName,
    string code,
    string? system = null,
    string? version = null,
    string? display = null) : CqlDeclarationAttribute(declarationName)
{
    /// <summary>
    /// The code.
    /// </summary>
    public string Code { get; } = code;

    /// <summary>
    /// The system of the code.
    /// </summary>
    public string? System { get; } = system;

    /// <summary>
    /// The version of the code.
    /// </summary>
    public string? Version { get; } = version;

    /// <summary>
    /// The display of the code.
    /// </summary>
    public string? Display { get; } = display;
}