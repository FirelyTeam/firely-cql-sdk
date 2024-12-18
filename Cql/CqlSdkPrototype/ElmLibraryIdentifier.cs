using System.Diagnostics.CodeAnalysis;

namespace CqlSdkPrototype;

#pragma warning disable CS1591
public readonly record struct ElmLibraryIdentifier :
    IParsable<ElmLibraryIdentifier>,
    IComparable<ElmLibraryIdentifier>,
    IComparable
{
    private readonly string _value;

    private ElmLibraryIdentifier(string value) => _value = value;

    public override string ToString() => _value;


    #region Parsing

    static ElmLibraryIdentifier IParsable<ElmLibraryIdentifier>.Parse(string s, IFormatProvider? provider)
    {
        return Parse(s);
    }

    public static ElmLibraryIdentifier Parse(string s)
    {
        return TryParse(s, out var result)
                   ? result
                   : throw new FormatException("Not a valid ElmLibraryName");
    }

    static bool IParsable<ElmLibraryIdentifier>.TryParse(
        [NotNullWhen(true)] string? s,
        IFormatProvider? provider,
        out ElmLibraryIdentifier result)
    {
        return TryParse(s, out result);
    }

    public static bool TryParse(string? s, out ElmLibraryIdentifier result)
    {
        if (s is null)
        {
            result = default;
            return false;
        }

        result = new ElmLibraryIdentifier(s);
        return true;
    }

    #endregion

    #region Comparison

    public int CompareTo(ElmLibraryIdentifier other)
    {
        return string.Compare(_value, other._value, StringComparison.Ordinal);
    }

    int IComparable.CompareTo(object? obj)
    {
        return obj switch
        {
            ElmLibraryIdentifier other => CompareTo(other),
            _ => throw new ArgumentException($"Object must be of type {nameof(ElmVersionedLibraryIdentifier)}")
        };
    }

    #endregion
}