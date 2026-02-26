/*
 * Copyright (c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

namespace Hl7.Cql.Exceptions;

/// <summary>
/// Represents a structured error that can occur within the CQL SDK.
/// Implementations carry a human-readable message and are used as
/// the typed payload of <see cref="CqlException{TError}"/>.
/// </summary>
public interface ICqlError
{
    /// <summary>Returns the human-readable message describing this error.</summary>
    string GetMessage();
}