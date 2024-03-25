using System;

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
        public bool Equals(VersionedIdentifier? other) => CompareTo(other) == 0;

        /// <inheritdoc/>
        public override bool Equals(object? obj) =>
            obj switch
            {
                VersionedIdentifier vi => Equals(vi),
                _ => false
            };

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Combine(id, version);

    }
}
