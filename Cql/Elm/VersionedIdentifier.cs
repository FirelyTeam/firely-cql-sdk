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
        /// <inheritdoc/>
        public int CompareTo(VersionedIdentifier? other)
        {
            if (other is null)
                throw new ArgumentNullException(nameof(other));

            // CqlLibrarySemantics.CompareIds/CompareVersions tolerate a null id/version on
            // either side (unlike StringComparer.GetHashCode), so a null id here doesn't need
            // special-casing - and, critically, doesn't need to throw. Equals delegates to this
            // method, and IEquatable<T>.Equals must never throw for a valid non-null argument.
            var idComparison = CqlLibrarySemantics.CompareIds(this.id, other.id);
            if (idComparison == 0)
            {
                // VersionComparer orders numerically (so "1.9" sorts before "1.10") while still
                // guaranteeing textually-different versions never compare equal - CompareVersions
                // alone would order "1.9" after "1.10" lexicographically, which is wrong for
                // "most appropriate version" selection (spec/condensed/03-developersguide.md
                // SS Libraries).
                return VersionComparer.Instance.Compare(version, other.version);
            }
            else return idComparison;
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
        public override int GetHashCode() => CqlLibrarySemantics.ComputeHashCode(id, version);

        /// <nodoc/>
        public void Deconstruct(out string id, out string? version)
        {
            id = this.id;
            version = this.version is {Length:>0} v ? v : null;
        }
    }
}
