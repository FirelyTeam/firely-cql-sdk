/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Runtime;

/// <summary>
/// Represents an identifier for a CQL library.
/// </summary>
public readonly record struct CqlLibraryIdentifier :
    IParsable<CqlLibraryIdentifier>,
    IComparable<CqlLibraryIdentifier>,
    IComparable
{
    /// <summary>
    /// Implicitly converts a <see cref="CqlLibraryIdentifier"/> to a <see cref="string"/>.
    /// </summary>
    /// <param name="identifier">The <see cref="CqlLibraryIdentifier"/> to convert.</param>
    /// <returns>The string representation of the identifier.</returns>
    public static implicit operator string(CqlLibraryIdentifier identifier) => identifier._value;

    /// <summary>
    /// Explicitly converts a <see cref="string"/> to a <see cref="CqlLibraryIdentifier"/>.
    /// </summary>
    /// <param name="identifier">The string to convert.</param>
    /// <returns>The <see cref="CqlLibraryIdentifier"/> representation of the string.</returns>
    /// <exception cref="FormatException">Thrown when the string is not a valid identifier.</exception>
    public static explicit operator CqlLibraryIdentifier(string identifier) => Parse(identifier);

    private readonly string _value;

    /// <summary>
    /// Initializes a new instance of the <see cref="CqlLibraryIdentifier"/> struct.
    /// </summary>
    /// <param name="value">The string value of the identifier.</param>
    private CqlLibraryIdentifier(string value) => _value = value;

    /// <summary>
    /// Returns the string representation of the identifier.
    /// </summary>
    /// <returns>The string representation of the identifier.</returns>
    public override string ToString() => _value;

    #region Parsing

    /// <summary>
    /// Parses the specified string to a <see cref="CqlLibraryIdentifier"/>.
    /// </summary>
    /// <param name="s">The string to parse.</param>
    /// <param name="provider">The format provider.</param>
    /// <returns>The parsed <see cref="CqlLibraryIdentifier"/>.</returns>
    static CqlLibraryIdentifier IParsable<CqlLibraryIdentifier>.Parse(string s, IFormatProvider? provider)
    {
        return Parse(s);
    }

    /// <summary>
    /// Parses the specified string to a <see cref="CqlLibraryIdentifier"/>.
    /// </summary>
    /// <param name="s">The string to parse.</param>
    /// <returns>The parsed <see cref="CqlLibraryIdentifier"/>.</returns>
    /// <exception cref="FormatException">Thrown when the string is not a valid identifier.</exception>
    public static CqlLibraryIdentifier Parse(string s)
    {
        return TryParse(s, out var result)
                   ? result
                   : throw new FormatException("Not a valid ElmLibraryName");
    }

    /// <summary>
    /// Tries to parse the specified string to a <see cref="CqlLibraryIdentifier"/>.
    /// </summary>
    /// <param name="s">The string to parse.</param>
    /// <param name="provider">The format provider.</param>
    /// <param name="result">The parsed <see cref="CqlLibraryIdentifier"/>.</param>
    /// <returns><c>true</c> if the string was successfully parsed; otherwise, <c>false</c>.</returns>
    static bool IParsable<CqlLibraryIdentifier>.TryParse(
        [NotNullWhen(true)] string? s,
        IFormatProvider? provider,
        out CqlLibraryIdentifier result)
    {
        return TryParse(s, out result);
    }

    /// <summary>
    /// Tries to parse the specified string to a <see cref="CqlLibraryIdentifier"/>.
    /// </summary>
    /// <param name="s">The string to parse.</param>
    /// <param name="result">The parsed <see cref="CqlLibraryIdentifier"/>.</param>
    /// <returns><c>true</c> if the string was successfully parsed; otherwise, <c>false</c>.</returns>
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

    /// <summary>
    /// Compares the current instance with another <see cref="CqlLibraryIdentifier"/> and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other identifier.
    /// </summary>
    /// <param name="other">The other identifier to compare with.</param>
    /// <returns>A value that indicates the relative order of the identifiers being compared.</returns>
    public int CompareTo(CqlLibraryIdentifier other)
    {
        return string.Compare(_value, other._value, StringComparison.Ordinal);
    }

    /// <summary>
    /// Compares the current instance with another object and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
    /// </summary>
    /// <param name="obj">The object to compare with.</param>
    /// <returns>A value that indicates the relative order of the objects being compared.</returns>
    /// <exception cref="ArgumentException">Thrown when the object is not of type <see cref="CqlLibraryIdentifier"/>.</exception>
    int IComparable.CompareTo(object? obj)
    {
        return obj switch
        {
            CqlLibraryIdentifier other => CompareTo(other),
            _ => throw new ArgumentException($"Object must be of type {nameof(CqlLibraryIdentifier)}")
        };
    }

    #endregion
}
