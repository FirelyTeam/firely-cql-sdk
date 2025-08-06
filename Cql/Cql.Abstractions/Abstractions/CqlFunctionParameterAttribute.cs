/*
 * Copyright (c) 2025, Firely and NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Abstractions;

/// <summary>
/// Declares the original CQL parameter name for a generated C# method parameter.
/// This attribute is used when the CQL parameter name contains characters that are not valid 
/// in C# parameter names and thus had to be normalized during code generation.
/// </summary>
[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
public sealed class CqlFunctionParameterAttribute : Attribute
{
    /// <summary>
    /// Initializes a new instance of the CqlFunctionParameterAttribute class.
    /// </summary>
    /// <param name="cqlParameterName">The original CQL parameter name</param>
    public CqlFunctionParameterAttribute(string cqlParameterName)
    {
        CqlParameterName = cqlParameterName ?? throw new ArgumentNullException(nameof(cqlParameterName));
    }

    /// <summary>
    /// Gets the original CQL parameter name.
    /// </summary>
    public string CqlParameterName { get; }
}