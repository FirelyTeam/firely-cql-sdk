using Hl7.Cql.Runtime;

namespace Hl7.Cql.Elm
{
    partial class VersionedIdentifier : IComparable<VersionedIdentifier>, IEquatable<VersionedIdentifier>
    {
        /// <summary>
        /// Converts this instance to a <see cref="CqlVersionedLibraryIdentifier"/>.
        /// </summary>
        public CqlVersionedLibraryIdentifier ToCqlVersionedLibraryIdentifier()
        {
            // We have to check for nulls because the generated ELM code does not emit nullability annotations.
            ArgumentNullException.ThrowIfNull(id);

            var cqlLibraryIdentifier = CqlLibraryIdentifier.Parse(id);
            CqlLibraryVersion? cqlLibraryVersion = version is null ? null : CqlLibraryVersion.Parse(version);
            return CqlVersionedLibraryIdentifier.FromNameAndVersion(cqlLibraryIdentifier, cqlLibraryVersion);
        }

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

        /// <nodoc/>
        public void Deconstruct(out string id, out string? version)
        {
            id = this.id;
            version = this.version is {Length:>0} v ? v : null;
        }
    }
}
