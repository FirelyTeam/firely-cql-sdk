/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;

namespace Hl7.Cql.Elm
{
    partial class VersionedIdentifier : IComparable<VersionedIdentifier>, IEquatable<VersionedIdentifier>
    {
        // Spec-conformant comparison primitives — shared DRY helpers that delegate to
        // Hl7.Cql.Runtime.CqlLibrarySemantics (accessible via transitive project dependency
        // Elm → Cql.Firely → Cql.Runtime, with InternalsVisibleTo granted by Cql.Runtime to Elm).
        // The Cql* runtime structs (CqlLibraryIdentifier, CqlLibraryVersion, CqlVersionedLibraryIdentifier)
        // call CqlLibrarySemantics directly.

        /// <summary>
        /// Compares two library identifier strings using spec-conformant case-sensitive ordinal comparison.
        /// Delegates to <see cref="CqlLibrarySemantics.CompareIds"/>.
        /// </summary>
        internal static int CompareIds(string? a, string? b) => CqlLibrarySemantics.CompareIds(a, b);

        /// <summary>
        /// Compares two library version strings using spec-conformant exact ordinal comparison.
        /// Delegates to <see cref="CqlLibrarySemantics.CompareVersions"/>.
        /// </summary>
        internal static int CompareVersions(string? a, string? b) => CqlLibrarySemantics.CompareVersions(a, b);

        /// <summary>
        /// Computes a hash code for a library identifier and optional version using spec-conformant semantics.
        /// Delegates to <see cref="CqlLibrarySemantics.ComputeHashCode"/>.
        /// </summary>
        internal static int ComputeHashCode(string? id, string? version) => CqlLibrarySemantics.ComputeHashCode(id, version);

        /// <inheritdoc/>
        public int CompareTo(VersionedIdentifier? other)
        {
            if (other is null || other.id is null)
                throw new ArgumentNullException("other");
            else if (id is null)
                throw new InvalidOperationException("id is requlred for comparison");
            else
            {
                var idComparison = CompareIds(this.id, other.id);
                if (idComparison == 0)
                {
                    return CompareVersions(version, other.version);
                }
                else return idComparison;
            }
        }

        /// <inheritdoc/>
        public bool Equals(VersionedIdentifier? other) => other is not null && CompareTo(other) == 0;

        /// <inheritdoc/>
        public override bool Equals(object? obj) =>
            obj switch
            {
                VersionedIdentifier vi => Equals(vi),
                _ => false
            };

        /// <inheritdoc/>
        public override int GetHashCode() => ComputeHashCode(id, version);

        /// <nodoc/>
        public void Deconstruct(out string id, out string? version)
        {
            id = this.id;
            version = this.version is {Length:>0} v ? v : null;
        }
    }
}
