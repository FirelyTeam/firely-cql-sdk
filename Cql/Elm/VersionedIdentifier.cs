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
                var idComparison = StringComparer.OrdinalIgnoreCase.Compare(this.id, other.id);
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
                        return VersionComparer.Instance.Compare(version, other.version);
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
            var hash = new HashCode();
            hash.Add(id, StringComparer.OrdinalIgnoreCase);
            if (version is { Length: > 0 })
            {
                var parts = version.Split('.').Select(int.Parse).ToArray();
                int len = parts.Length;
                while (len > 0 && parts[len - 1] == 0) len--;
                for (int i = 0; i < len; i++) hash.Add(parts[i]);
            }
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
