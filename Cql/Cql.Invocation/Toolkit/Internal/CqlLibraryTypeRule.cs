/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Abstractions;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Invocation.Toolkit.Internal;

/// <summary>
/// Decides whether a type is a CQL library the code generator wrote, and what it declares.
/// </summary>
/// <remarks>
/// The rule is <see cref="TryCreateLibraryInfo"/>. <see cref="LibraryInvoker.TryCreateFromType"/> reads its input from
/// a loaded type through <see cref="TryGetLibraryInfo"/>, and <see cref="CqlAssemblyInfoReader"/> reads it from an
/// assembly's metadata. Both therefore produce the same <see cref="CqlLibraryInfo"/> for the same type, so a host that
/// checks an assembly before loading it and the invoker that loads it cannot disagree.
/// </remarks>
internal static class CqlLibraryTypeRule
{
    /// <summary>
    /// Reads the CQL library that a loaded type declares, through reflection.
    /// </summary>
    /// <param name="type">The type to read.</param>
    /// <param name="cqlLibraryInfo">The library the type declares, when it is a CQL library the code generator wrote.</param>
    /// <returns><see langword="false"/> when the type is not a CQL library the code generator wrote.</returns>
    public static bool TryGetLibraryInfo(
        Type type,
        [NotNullWhen(true)] out CqlLibraryInfo? cqlLibraryInfo)
    {
        cqlLibraryInfo = null;
        return type.GetCustomAttribute<CqlLibraryAttribute>() is { } cqlLibrary
               && type.GetCustomAttribute<GeneratedCodeAttribute>() is { } generatedCode
               && TryCreateLibraryInfo(cqlLibrary.Identifier, cqlLibrary.Version, generatedCode.Tool, generatedCode.Version, out cqlLibraryInfo);
    }

    /// <summary>
    /// Decides, from the arguments of a type's <see cref="CqlLibraryAttribute"/> and <see cref="GeneratedCodeAttribute"/>,
    /// whether the type is a CQL library the code generator wrote, and which.
    /// </summary>
    /// <param name="identifier">The identifier the <see cref="CqlLibraryAttribute"/> names.</param>
    /// <param name="version">The library version the <see cref="CqlLibraryAttribute"/> names.</param>
    /// <param name="tool">The tool the <see cref="GeneratedCodeAttribute"/> names.</param>
    /// <param name="generatorVersion">The version the <see cref="GeneratedCodeAttribute"/> names.</param>
    /// <param name="cqlLibraryInfo">The library the type declares, when it is a CQL library the code generator wrote.</param>
    /// <returns>
    /// <see langword="false"/> when another tool wrote the type, when the generator version does not parse, or when the
    /// identifier and version do not form a library identifier.
    /// </returns>
    public static bool TryCreateLibraryInfo(
        string? identifier,
        string? version,
        string? tool,
        string? generatorVersion,
        [NotNullWhen(true)] out CqlLibraryInfo? cqlLibraryInfo)
    {
        cqlLibraryInfo = null;
        if (!IsGeneratorToolName(tool)
            || !Version.TryParse(generatorVersion, out var generatorToolVersion)
            || !TryCreateLibraryIdentifier(identifier, version, out var libraryIdentifier))
            return false;

        cqlLibraryInfo = new CqlLibraryInfo(libraryIdentifier.Value, generatorToolVersion);
        return true;
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
    /// Whether the tool a <see cref="GeneratedCodeAttribute"/> names is the code generator.
    /// </summary>
    /// <remarks>
    /// The code generator's current name and its legacy name are both recognized: the legacy name for the libraries
    /// that generator versions up to 6.0.3.0 wrote. Whether this toolkit runs a library is decided by its version
    /// alone, in <see cref="IsGeneratorToolVersionSupported"/>.
    /// </remarks>
    private static bool IsGeneratorToolName(string? tool) =>
        tool is LibrarySetCSharpCodeGenerator.GeneratorToolName or LibrarySetCSharpCodeGenerator.LegacyGeneratorToolName;

    /// <summary>
    /// Forms a library identifier without throwing: a missing or empty version makes an unversioned identifier.
    /// </summary>
    private static bool TryCreateLibraryIdentifier(
        string? identifier,
        string? version,
        [NotNullWhen(true)] out CqlVersionedLibraryIdentifier? libraryIdentifier)
    {
        libraryIdentifier = null;
        if (!CqlLibraryIdentifier.TryParse(identifier, out var cqlLibraryIdentifier))
            return false;

        CqlLibraryVersion? cqlLibraryVersion = null;
        if (!string.IsNullOrEmpty(version) && !CqlLibraryVersion.TryParse(version, out cqlLibraryVersion))
            return false;

        libraryIdentifier = CqlVersionedLibraryIdentifier.FromIdentifierAndVersion(cqlLibraryIdentifier.Value, cqlLibraryVersion);
        return true;
    }

    /// <summary>
    /// Fills the components a version leaves out with 0. <see cref="Version"/> orders an undefined component
    /// before 0, so without this <c>6.0</c> would compare as less than <c>6.0.0.0</c>.
    /// </summary>
    private static Version PadMissingComponents(Version version) =>
        new(version.Major, version.Minor, Math.Max(version.Build, 0), Math.Max(version.Revision, 0));
}
