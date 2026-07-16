/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Elm
{
    partial class VersionedIdentifier : IComparable<VersionedIdentifier>, IEquatable<VersionedIdentifier>
    {
        /// <inheritdoc/>
        public int CompareTo(VersionedIdentifier? other)
        {
            if (other is null || other.id is null)
                throw new ArgumentNullException("other");
            else if (id is null)
                throw new InvalidOperationException("id is requlred for comparison");
            else
            {
                // CQL is a case-sensitive language (spec/condensed/03-developersguide.md §3.4.1 "Case-Sensitivity"):
                // "To encourage consistency and reduce potential confusion, CQL is a case-sensitive language."
                // Library identifiers are CQL identifiers, so id comparison must be case-sensitive.
                var idComparison = StringComparer.Ordinal.Compare(this.id, other.id);
                if (idComparison == 0)
                {
                    if (version is null)
                    {
                        if (other.version is null)
                        {
                            return 0;
                        }
                        else return -1;
                    }
                    else if (other.version is null)
                        return 1;
                    else
                    {
                        // Version specifiers must match exactly (spec/condensed/03-developersguide.md §3.2 "Libraries"):
                        // "If the reference includes a version specifier, the library with that version specifier must be used."
                        // The version is an opaque string identifier
                        // (spec/condensed/04-logicalspecification.md §2.1.5 "VersionedIdentifier"):
                        // "the actual version of the instance of interest in this set"
                        return StringComparer.Ordinal.Compare(version, other.version);
                    }
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
        public override int GetHashCode()
        {
            // Hash must be consistent with Equals/CompareTo semantics:
            // - id uses case-sensitive Ordinal comparison (CQL is case-sensitive per
            //   spec/condensed/03-developersguide.md §3.4.1 "Case-Sensitivity")
            // - version is an opaque string matched exactly (spec/condensed/03-developersguide.md
            //   §3.2 "Libraries", spec/condensed/04-logicalspecification.md §2.1.5 "VersionedIdentifier")
            var hash = new HashCode();
            hash.Add(id, StringComparer.Ordinal);
            if (version is { Length: > 0 })
                hash.Add(version, StringComparer.Ordinal);
            return hash.ToHashCode();
        }

        /// <nodoc/>
        public void Deconstruct(out string id, out string? version)
        {
            id = this.id;
            version = this.version is {Length:>0} v ? v : null;
        }
    }
}
