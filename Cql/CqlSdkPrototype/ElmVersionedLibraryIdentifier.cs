using System.Diagnostics.CodeAnalysis;
using Hl7.Cql.Elm;

namespace CqlSdkPrototype;

public readonly record struct ElmVersionedLibraryIdentifier : IParsable<ElmVersionedLibraryIdentifier>
{

    private ElmVersionedLibraryIdentifier(ElmLibraryIdentifier Identifier, ElmLibraryVersion? Version = null)
    {
        this.Identifier = Identifier;
        this.Version = Version;
    }

    public static ElmVersionedLibraryIdentifier FromNameAndVersion(ElmLibraryIdentifier identifier, ElmLibraryVersion? version = null)
    {
        return new ElmVersionedLibraryIdentifier(identifier, version);
    }

    public static ElmVersionedLibraryIdentifier FromVersionedIdentifier(VersionedIdentifier identifier)
    {
        ArgumentNullException.ThrowIfNull(identifier);
        return FromNameAndVersion(ElmLibraryIdentifier.Parse(identifier.id), ElmLibraryVersion.Parse(identifier.version));
    }

    public ElmLibraryIdentifier Identifier { get; init; }

    public ElmLibraryVersion? Version { get; init; }

    public void Deconstruct(out ElmLibraryIdentifier identifier, out ElmLibraryVersion? version)
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

    static ElmVersionedLibraryIdentifier IParsable<ElmVersionedLibraryIdentifier>.Parse(string s, IFormatProvider? provider)
    {
        return Parse(s);
    }

    public static ElmVersionedLibraryIdentifier Parse(string s)
    {
        return TryParse(s, out var result)
                   ? result
                   : throw new FormatException("Not a valid ElmVersionedIdentifier");
    }

    static bool IParsable<ElmVersionedLibraryIdentifier>.TryParse(
        [NotNullWhen(true)] string? s,
        IFormatProvider? provider,
        out ElmVersionedLibraryIdentifier result)
    {
        return TryParse(s, out result);
    }

    public static bool TryParse(string? s, out ElmVersionedLibraryIdentifier result)
    {
        if (s is not null)
        {
            var tokens = s.Split('-', 2);
            if (ElmLibraryIdentifier.TryParse(tokens[0], out var name))
            {
                switch (tokens.Length)
                {
                    case 1:
                        result = FromNameAndVersion(name);
                        return true;

                    case 2 when ElmLibraryVersion.TryParse(tokens[1], out var version):
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

    private sealed class NameOnlyComparerImpl : IComparer<ElmVersionedLibraryIdentifier>,
                                                IEqualityComparer<ElmVersionedLibraryIdentifier>
    {
        public static NameOnlyComparerImpl Instance { get; } = new();

        public int Compare(ElmVersionedLibraryIdentifier x, ElmVersionedLibraryIdentifier y)
        {
            return x.Identifier.CompareTo(y.Identifier);
        }

        public bool Equals(ElmVersionedLibraryIdentifier x, ElmVersionedLibraryIdentifier y)
        {
            return x.Identifier == y.Identifier;
        }

        public int GetHashCode(ElmVersionedLibraryIdentifier obj)
        {
            return obj.Identifier.GetHashCode();
        }
    }

    public static IComparer<ElmVersionedLibraryIdentifier> IdentifierOnlyComparer => NameOnlyComparerImpl.Instance;

    public static IEqualityComparer<ElmVersionedLibraryIdentifier> IdentifierOnlyEqualityComparer => NameOnlyComparerImpl.Instance;

    #endregion

    #region Cast Operators

    public static implicit operator ElmVersionedLibraryIdentifier(ElmLibraryIdentifier identifier) => FromNameAndVersion(identifier);

    #endregion
}