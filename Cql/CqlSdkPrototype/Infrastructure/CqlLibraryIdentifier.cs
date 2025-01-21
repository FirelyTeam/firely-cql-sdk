namespace CqlSdkPrototype.Infrastructure;

#pragma warning disable CS1591
public readonly record struct CqlLibraryIdentifier :
    IParsable<CqlLibraryIdentifier>,
    IComparable<CqlLibraryIdentifier>,
    IComparable
{
    private readonly string _value;

    private CqlLibraryIdentifier(string value) => _value = value;

    public override string ToString() => _value;


    #region Parsing

    static CqlLibraryIdentifier IParsable<CqlLibraryIdentifier>.Parse(string s, IFormatProvider? provider)
    {
        return Parse(s);
    }

    public static CqlLibraryIdentifier Parse(string s)
    {
        return TryParse(s, out var result)
                   ? result
                   : throw new FormatException("Not a valid ElmLibraryName");
    }

    static bool IParsable<CqlLibraryIdentifier>.TryParse(
        [NotNullWhen(true)] string? s,
        IFormatProvider? provider,
        out CqlLibraryIdentifier result)
    {
        return TryParse(s, out result);
    }

    public static bool TryParse(string? s, out CqlLibraryIdentifier result)
    {
        if (s is null)
        {
            result = default;
            return false;
        }

        result = new CqlLibraryIdentifier(s);
        return true;
    }

    #endregion

    #region Comparison

    public int CompareTo(CqlLibraryIdentifier other)
    {
        return string.Compare(_value, other._value, StringComparison.Ordinal);
    }

    int IComparable.CompareTo(object? obj)
    {
        return obj switch
        {
            CqlLibraryIdentifier other => CompareTo(other),
            _ => throw new ArgumentException($"Object must be of type {nameof(CqlVersionedLibraryIdentifier)}")
        };
    }

    #endregion
}