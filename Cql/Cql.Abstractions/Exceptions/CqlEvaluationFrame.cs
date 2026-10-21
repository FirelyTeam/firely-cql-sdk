/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Exceptions;

/// <summary>
/// A CQL definition that was being evaluated when an exception was thrown: its name and the library that declares it.
/// </summary>
/// <remarks>
/// <see cref="CqlException.EvaluationFrames"/> lists these innermost first. A function without operands is computed
/// like a definition and has a frame of its own. A function with operands has one only when the host invoked it
/// directly; called from a definition, it is reported as that definition.
/// </remarks>
public sealed record CqlEvaluationFrame
{
    internal CqlEvaluationFrame(string libraryName, string? libraryVersion, string definitionName)
    {
        LibraryName = libraryName;
        LibraryVersion = libraryVersion;
        DefinitionName = definitionName;
    }

    /// <summary>
    /// Gets the name of the library that declares the definition.
    /// </summary>
    public string LibraryName { get; }

    /// <summary>
    /// Gets the version of the library that declares the definition, or <see langword="null"/> for a library without
    /// a version.
    /// </summary>
    public string? LibraryVersion { get; }

    /// <summary>
    /// Gets the name of the definition, as the CQL declares it.
    /// </summary>
    public string DefinitionName { get; }

    /// <summary>
    /// Describes the frame as it reads in an exception message, for example
    /// <c>definition 'Patient' of library 'AHAOverall' version '4.1.000'</c>.
    /// </summary>
    public override string ToString() =>
        LibraryVersion is null
            ? $"definition '{DefinitionName}' of library '{LibraryName}'"
            : $"definition '{DefinitionName}' of library '{LibraryName}' version '{LibraryVersion}'";
}
