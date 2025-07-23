/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Abstractions;

/// <summary>
/// The base interface for generated CQL libraries.
/// </summary>
public interface ILibrary
{
    /// <summary>
    /// Gets the name of the library.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Gets the version of the library.
    /// </summary>
    string Version { get; }

    /// <summary>
    /// Gets the dependencies of the library.
    /// </summary>
    ILibrary[] Dependencies { get; }
}