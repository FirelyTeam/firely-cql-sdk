using System.Diagnostics.CodeAnalysis;

namespace CqlSdkPrototype;

#pragma warning disable CS1591
public readonly record struct CqlLibraryVersion :
    IParsable<CqlLibraryVersion>,
    IComparable<CqlLibraryVersion>,
    IComparable
{
    public static CqlLibraryVersion Empty { get; } = new CqlLibraryVersion("");

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

    public static CqlLibraryVersion ParseOrEmpty(string s)
    {
        return TryParse(s, out var result)
           ? result
           : Empty;
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
        if (s is null)
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

    #endregion
}