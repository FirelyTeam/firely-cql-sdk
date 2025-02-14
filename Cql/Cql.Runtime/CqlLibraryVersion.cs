namespace Hl7.Cql.Runtime;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

public readonly record struct CqlLibraryVersion :
    IParsable<CqlLibraryVersion>,
    IComparable<CqlLibraryVersion>,
    IComparable
{
    private readonly string _value;

    private CqlLibraryVersion(string value) => _value = value;

    public override string ToString() => _value;

    #region Parsing

    static CqlLibraryVersion IParsable<CqlLibraryVersion>.Parse(string s, IFormatProvider? provider)
    {
        return Parse(s);
    }

    public static CqlLibraryVersion Parse(string s)
    {
        return TryParse(s, out var result)
                   ? result
                   : throw new FormatException("Not a valid ElmLibraryVersion");
    }

    static bool IParsable<CqlLibraryVersion>.TryParse(
        [NotNullWhen(true)] string? s,
        IFormatProvider? provider,
        out CqlLibraryVersion result)
    {
        return TryParse(s, out result);
    }

    public static bool TryParse(string? s, out CqlLibraryVersion result)
    {
        if (string.IsNullOrEmpty(s))
        {
            result = default;
            return false;
        }

        result = new CqlLibraryVersion(s);
        return true;
    }

    #endregion

    #region Comparison

    public int CompareTo(CqlLibraryVersion other)
    {
        return string.Compare(_value, other._value, StringComparison.Ordinal);
    }

    int IComparable.CompareTo(object? obj)
    {
        return obj switch
        {
            CqlLibraryVersion other => CompareTo(other),
            _ => throw new ArgumentException($"Object must be of type {nameof(CqlVersionedLibraryIdentifier)}")
        };
    }
    public static bool operator <(CqlLibraryVersion left, CqlLibraryVersion right)
    {
        return left.CompareTo(right) < 0;
    }

    public static bool operator <=(CqlLibraryVersion left, CqlLibraryVersion right)
    {
        return left.CompareTo(right) <= 0;
    }

    public static bool operator >(CqlLibraryVersion left, CqlLibraryVersion right)
    {
        return left.CompareTo(right) > 0;
    }

    public static bool operator >=(CqlLibraryVersion left, CqlLibraryVersion right)
    {
        return left.CompareTo(right) >= 0;
    }

    #endregion
}