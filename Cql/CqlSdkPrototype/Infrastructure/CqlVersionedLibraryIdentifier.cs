namespace CqlSdkPrototype.Infrastructure;

public readonly record struct CqlVersionedLibraryIdentifier(
    CqlLibraryIdentifier Identifier,
    CqlLibraryVersion? Version = null) : IParsable<CqlVersionedLibraryIdentifier>
{
    public static CqlVersionedLibraryIdentifier ParseFromNameAndVersion(string identifier, string? version = null)
    {
        var cqlLibraryIdentifier = CqlLibraryIdentifier.Parse(identifier);
        CqlLibraryVersion? cqlLibraryVersion = version is null ? null : CqlLibraryVersion.Parse(version);
        return FromNameAndVersion(cqlLibraryIdentifier, cqlLibraryVersion);
    }

    public static CqlVersionedLibraryIdentifier FromNameAndVersion(CqlLibraryIdentifier identifier, CqlLibraryVersion? version = null)
    {
        return new CqlVersionedLibraryIdentifier(identifier, version);
    }


    public override string ToString()
    {
        return (Identifier, Version) switch
        {
            ({ } identifier, { } version) => $"{identifier}-{version}",
            ({ } identifier, _)                          => identifier.ToString(),
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

    #region Cast Operators

    public static implicit operator CqlVersionedLibraryIdentifier(CqlLibraryIdentifier identifier) => FromNameAndVersion(identifier);

    #endregion
}