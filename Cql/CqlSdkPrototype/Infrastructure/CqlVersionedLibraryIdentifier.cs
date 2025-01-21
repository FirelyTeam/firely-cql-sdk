using Hl7.Cql.Elm;

namespace CqlSdkPrototype.Infrastructure;

public readonly record struct CqlVersionedLibraryIdentifier : IParsable<CqlVersionedLibraryIdentifier>
{
    public static CqlVersionedLibraryIdentifier Empty { get; } = new CqlVersionedLibraryIdentifier(CqlLibraryIdentifier.Empty, CqlLibraryVersion.Empty);

    private CqlVersionedLibraryIdentifier(CqlLibraryIdentifier Identifier, CqlLibraryVersion? Version = null)
    {
        this.Identifier = Identifier;
        this.Version = Version;
    }

    public static CqlVersionedLibraryIdentifier FromNameAndVersion(CqlLibraryIdentifier identifier, CqlLibraryVersion? version = null)
    {
        return new CqlVersionedLibraryIdentifier(identifier, version);
    }

    public static CqlVersionedLibraryIdentifier FromVersionedIdentifier(VersionedIdentifier identifier)
    {
        ArgumentNullException.ThrowIfNull(identifier);
        return FromNameAndVersion(CqlLibraryIdentifier.Parse(identifier.id), CqlLibraryVersion.Parse(identifier.version));
    }

    public CqlLibraryIdentifier Identifier { get; init; }

    public CqlLibraryVersion? Version { get; init; }

    public void Deconstruct(out CqlLibraryIdentifier identifier, out CqlLibraryVersion? version)
    {
        identifier = Identifier;
        version = Version;
    }

    public override string ToString()
    {
        return (Identifier, Version) switch
        {
            ({ } identifier, null) => identifier.ToString(),
            ({ } identifier, { } version) => $"{identifier}-{version}",
        };
    }

    #region Parsing

    static CqlVersionedLibraryIdentifier IParsable<CqlVersionedLibraryIdentifier>.Parse(string s, IFormatProvider? provider)
    {
        return Parse(s);
    }

    public static CqlVersionedLibraryIdentifier Parse(string s)
    {
        return TryParse(s, out var result)
                   ? result
                   : throw new FormatException("Not a valid ElmVersionedIdentifier");
    }

    static bool IParsable<CqlVersionedLibraryIdentifier>.TryParse(
        [NotNullWhen(true)] string? s,
        IFormatProvider? provider,
        out CqlVersionedLibraryIdentifier result)
    {
        return TryParse(s, out result);
    }

    public static bool TryParse(string? s, out CqlVersionedLibraryIdentifier result)
    {
        if (s is not null)
        {
            var tokens = s.Split('-', 2);
            if (CqlLibraryIdentifier.TryParse(tokens[0], out var name))
            {
                switch (tokens.Length)
                {
                    case 1:
                        result = FromNameAndVersion(name);
                        return true;

                    case 2 when CqlLibraryVersion.TryParse(tokens[1], out var version):
                        result = FromNameAndVersion(name, version);
                        return true;
                }
            }
        }

        result = default;
        return false;
    }

    #endregion

    #region Comparison

    private sealed class NameOnlyComparerImpl : IComparer<CqlVersionedLibraryIdentifier>,
                                                IEqualityComparer<CqlVersionedLibraryIdentifier>
    {
        public static NameOnlyComparerImpl Instance { get; } = new();

        public int Compare(CqlVersionedLibraryIdentifier x, CqlVersionedLibraryIdentifier y)
        {
            return x.Identifier.CompareTo(y.Identifier);
        }

        public bool Equals(CqlVersionedLibraryIdentifier x, CqlVersionedLibraryIdentifier y)
        {
            return x.Identifier == y.Identifier;
        }

        public int GetHashCode(CqlVersionedLibraryIdentifier obj)
        {
            return obj.Identifier.GetHashCode();
        }
    }

    public static IComparer<CqlVersionedLibraryIdentifier> IdentifierOnlyComparer => NameOnlyComparerImpl.Instance;

    public static IEqualityComparer<CqlVersionedLibraryIdentifier> IdentifierOnlyEqualityComparer => NameOnlyComparerImpl.Instance;

    #endregion

    #region Cast Operators

    public static implicit operator CqlVersionedLibraryIdentifier(CqlLibraryIdentifier identifier) => FromNameAndVersion(identifier);

    #endregion
}