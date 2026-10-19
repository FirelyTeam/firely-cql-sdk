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
/// The rule is <see cref="CreateLibraryInfos"/>. <see cref="LibrarySetInvoker"/> reads its input from loaded types
/// through <see cref="GetLibraryInfos"/>, and <see cref="CqlAssemblyInfoReader"/> reads it from an assembly's metadata.
/// Both therefore produce the same <see cref="CqlLibraryInfo"/>s for the same type, errors included, so a host that
/// checks an assembly before loading it and the invoker that loads it cannot disagree.
/// </remarks>
internal static class CqlLibraryTypeRule
{
    /// <summary>
    /// Reads the CQL libraries that a loaded type declares, through reflection.
    /// </summary>
    /// <param name="type">The type to read.</param>
    /// <returns>The libraries the type declares, as <see cref="CreateLibraryInfos"/> decides them.</returns>
    public static List<CqlLibraryInfo> GetLibraryInfos(Type type)
    {
        List<(string? Identifier, string? Version)> cqlLibraries = [];
        foreach (var cqlLibrary in type.GetCustomAttributes<CqlLibraryAttribute>(inherit: false))
            cqlLibraries.Add((cqlLibrary.Identifier, cqlLibrary.Version));

        if (cqlLibraries.Count == 0)
            return [];

        List<(string? Tool, string? Version)> generatedCodes = [];
        foreach (var generatedCode in type.GetCustomAttributes<GeneratedCodeAttribute>(inherit: false))
            generatedCodes.Add((generatedCode.Tool, generatedCode.Version));

        return CreateLibraryInfos(type.FullName ?? type.Name, cqlLibraries, generatedCodes);
    }

    /// <summary>
    /// Decides, from the arguments of every <see cref="CqlLibraryAttribute"/> and <see cref="GeneratedCodeAttribute"/>
    /// a type carries, which CQL libraries the code generator wrote into it.
    /// </summary>
    /// <param name="typeName">The name of the type, for an error message.</param>
    /// <param name="cqlLibraries">The identifier and version of every <see cref="CqlLibraryAttribute"/> on the type.</param>
    /// <param name="generatedCodes">The tool and version of every <see cref="GeneratedCodeAttribute"/> on the type.</param>
    /// <returns>
    /// One entry per library the type declares. There are none when the type carries no <see cref="CqlLibraryAttribute"/>,
    /// or no <see cref="GeneratedCodeAttribute"/> that names the code generator with a version that parses, and none for
    /// an identifier and version that do not form a library identifier. When the type carries more than one of either
    /// attribute, every entry carries an <see cref="CqlLibraryInfo.Error"/> that says so.
    /// </returns>
    public static List<CqlLibraryInfo> CreateLibraryInfos(
        string typeName,
        IReadOnlyList<(string? Identifier, string? Version)> cqlLibraries,
        IReadOnlyList<(string? Tool, string? Version)> generatedCodes)
    {
        List<CqlLibraryInfo> cqlLibraryInfos = [];
        if (cqlLibraries.Count == 0)
            return cqlLibraryInfos;

        Version? generatorToolVersion = null;
        foreach (var (tool, version) in generatedCodes)
        {
            if (IsGeneratorToolName(tool) && Version.TryParse(version, out var parsedVersion))
            {
                generatorToolVersion = parsedVersion;
                break;
            }
        }

        if (generatorToolVersion is null)
            return cqlLibraryInfos;

        Exception? error =
            cqlLibraries.Count > 1 ? MoreThanOneAttribute(typeName, nameof(CqlLibraryAttribute))
            : generatedCodes.Count > 1 ? MoreThanOneAttribute(typeName, nameof(GeneratedCodeAttribute))
            : null;

        foreach (var (identifier, version) in cqlLibraries)
        {
            if (TryCreateLibraryIdentifier(identifier, version, out var libraryIdentifier))
                cqlLibraryInfos.Add(new CqlLibraryInfo(libraryIdentifier.Value, generatorToolVersion) { Error = error });
        }

        return cqlLibraryInfos;
    }

    /// <summary>
    /// The error for a CQL library that more than one type declares.
    /// </summary>
    public static InvalidOperationException DeclaredByMoreThanOneType(
        CqlVersionedLibraryIdentifier libraryIdentifier,
        IEnumerable<string> typeNames) =>
        new($"CQL library '{libraryIdentifier}' is declared by more than one type: '{string.Join("', '", typeNames)}'. "
            + "A CQL library is declared by exactly one type.");

    private static InvalidOperationException MoreThanOneAttribute(string typeName, string attributeName) =>
        new($"Type '{typeName}' carries more than one {attributeName}. A CQL library type carries exactly one.");

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
