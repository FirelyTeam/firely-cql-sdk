/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Runtime;

/// <summary>
/// Spec-conformant comparison primitives shared by all CQL library identifier types
/// (<see cref="CqlLibraryIdentifier"/>, <see cref="CqlLibraryVersion"/>,
/// <see cref="CqlVersionedLibraryIdentifier"/>, and <c>Hl7.Cql.Elm.VersionedIdentifier</c>).
/// </summary>
/// <remarks>
/// <para>
/// CQL is a case-sensitive language, so library identifiers must be compared case-sensitively.
/// (spec/condensed/03-developersguide.md §3.4.1 "Case-Sensitivity":
/// "CQL is a case-sensitive language. This means that case is considered when matching
/// keywords and identifiers in the language.")
/// </para>
/// <para>
/// Version specifiers must match exactly — they are opaque strings, not semantic versions to normalize.
/// (spec/condensed/03-developersguide.md §3.2 "Libraries":
/// "If the reference includes a version specifier, the library with that version specifier must be used.")
/// (spec/condensed/04-logicalspecification.md §2.1.5 "VersionedIdentifier":
/// "the actual version of the instance of interest in this set")
/// </para>
/// </remarks>
internal static class CqlLibrarySemantics
{
    /// <summary>
    /// Compares two library identifier strings using spec-conformant case-sensitive ordinal comparison.
    /// </summary>
    internal static int CompareIds(string? a, string? b) =>
        StringComparer.Ordinal.Compare(a, b);

    /// <summary>
    /// Compares two library version strings using spec-conformant exact ordinal comparison.
    /// Null and empty string are treated as "no version specified" and sort before any version.
    /// </summary>
    internal static int CompareVersions(string? a, string? b)
    {
        var aNorm = string.IsNullOrEmpty(a) ? null : a;
        var bNorm = string.IsNullOrEmpty(b) ? null : b;
        if (aNorm is null && bNorm is null) return 0;
        if (aNorm is null) return -1;
        if (bNorm is null) return 1;
        return StringComparer.Ordinal.Compare(aNorm, bNorm);
    }

    /// <summary>
    /// Computes a hash code for a library identifier and optional version using spec-conformant semantics.
    /// </summary>
    internal static int ComputeHashCode(string? id, string? version)
    {
        var hash = new HashCode();
        hash.Add(id, StringComparer.Ordinal);
        if (!string.IsNullOrEmpty(version))
            hash.Add(version, StringComparer.Ordinal);
        return hash.ToHashCode();
    }
}
