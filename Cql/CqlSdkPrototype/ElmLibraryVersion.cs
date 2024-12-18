using System.Diagnostics.CodeAnalysis;

namespace CqlSdkPrototype;

#pragma warning disable CS1591
public readonly record struct ElmLibraryVersion :
    IParsable<ElmLibraryVersion>,
    IComparable<ElmLibraryVersion>,
    IComparable
{
    private readonly string _value;

    private ElmLibraryVersion(string value) => _value = value;

    public override string ToString() => _value;


    #region Parsing

    static ElmLibraryVersion IParsable<ElmLibraryVersion>.Parse(string s, IFormatProvider? provider)
    {
        return Parse(s);
    }

    public static ElmLibraryVersion Parse(string s)
    {
        return TryParse(s, out var result)
                   ? result
                   : throw new FormatException("Not a valid ElmLibraryVersion");
    }

    static bool IParsable<ElmLibraryVersion>.TryParse(
        [NotNullWhen(true)] string? s,
        IFormatProvider? provider,
        out ElmLibraryVersion result)
    {
        return TryParse(s, out result);
    }

    public static bool TryParse(string? s, out ElmLibraryVersion result)
    {
        if (s is null)
        {
            result = default;
            return false;
        }

        result = new ElmLibraryVersion(s);
        return true;
    }

    #endregion

    #region Comparison

    public int CompareTo(ElmLibraryVersion other)
    {
        return string.Compare(_value, other._value, StringComparison.Ordinal);
    }

    int IComparable.CompareTo(object? obj)
    {
        return obj switch
        {
            ElmLibraryVersion other => CompareTo(other),
            _ => throw new ArgumentException($"Object must be of type {nameof(ElmVersionedLibraryIdentifier)}")
        };
    }

    #endregion
}