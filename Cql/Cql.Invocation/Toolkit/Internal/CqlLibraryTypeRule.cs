/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.CodeGeneration.NET;

namespace Hl7.Cql.Invocation.Toolkit.Internal;

/// <summary>
/// Decides whether a type is a CQL library the code generator wrote, and whether this toolkit runs it.
/// </summary>
/// <remarks>
/// <see cref="LibraryInvoker.TryCreateFromType"/> applies this rule to the types it loads, and
/// <see cref="CqlAssemblyInfoReader"/> applies it to the types it reads from metadata, so a host
/// that checks an assembly before loading it and the invoker that loads it cannot disagree.
/// </remarks>
internal static class CqlLibraryTypeRule
{
    /// <summary>
    /// Reads the version of the code generator from the tool and version that a type's
    /// <see cref="GeneratedCodeAttribute"/> names.
    /// </summary>
    /// <param name="tool">The tool the attribute names.</param>
    /// <param name="version">The version the attribute names.</param>
    /// <param name="generatorToolVersion">The version of the code generator, when it wrote the type.</param>
    /// <returns>
    /// <see langword="false"/> when another tool wrote the type, or when the version does not parse.
    /// </returns>
    /// <remarks>
    /// The code generator's current name and its legacy name are both recognized: the legacy name for the libraries
    /// that generator versions up to 6.0.3.0 wrote. Whether this toolkit runs a library is decided by its version
    /// alone, in <see cref="IsGeneratorToolVersionSupported"/>.
    /// </remarks>
    public static bool TryGetGeneratorToolVersion(
        string? tool,
        string? version,
        [NotNullWhen(true)] out Version? generatorToolVersion)
    {
        generatorToolVersion = null;
        return tool is LibrarySetCSharpCodeGenerator.GeneratorToolName or LibrarySetCSharpCodeGenerator.LegacyGeneratorToolName
               && Version.TryParse(version, out generatorToolVersion);
    }

    /// <summary>
    /// Determines whether an invoker of this toolkit runs code written by the specified version of the
    /// code generator. A component the version leaves out counts as 0.
    /// </summary>
    /// <remarks>
    /// An invoker added for a new major version of the code generator extends this, and nothing else.
    /// </remarks>
    public static bool IsGeneratorToolVersionSupported(Version generatorToolVersion) =>
        LibraryInstanceInvoker_6_0.SupportsVersion(PadMissingComponents(generatorToolVersion));

    /// <summary>
    /// Fills the components a version leaves out with 0. <see cref="Version"/> orders an undefined component
    /// before 0, so without this <c>6.0</c> would compare as less than <c>6.0.0.0</c>.
    /// </summary>
    private static Version PadMissingComponents(Version version) =>
        new(version.Major, version.Minor, Math.Max(version.Build, 0), Math.Max(version.Revision, 0));
}
