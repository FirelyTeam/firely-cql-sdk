/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Runtime;

/// <summary>
/// Represents the version part of a CQL library identifier.
/// </summary>
public readonly record struct CqlLibraryVersion :
    IParsable<CqlLibraryVersion>,
    IComparable<CqlLibraryVersion>,
    IComparable
{
    private readonly string _value;

    /// <summary>
    /// Initializes a new instance of the <see cref="CqlLibraryVersion"/> struct.
    /// </summary>
    /// <param name="value">The version string.</param>
    private CqlLibraryVersion(string value) => _value = value;

    /// <summary>
    /// Returns the string representation of the version.
    /// </summary>
    /// <returns>The version string.</returns>
    public override string ToString() => _value;

    #region Parsing

    /// <summary>
    /// Parses the specified string to a <see cref="CqlLibraryVersion"/>.
    /// </summary>
    /// <param name="s">The string to parse.</param>
    /// <param name="provider">The format provider.</param>
    /// <returns>The parsed <see cref="CqlLibraryVersion"/>.</returns>
    static CqlLibraryVersion IParsable<CqlLibraryVersion>.Parse(string s, IFormatProvider? provider)
    {
        return Parse(s);
    }

    /// <summary>
    /// Parses the specified string to a <see cref="CqlLibraryVersion"/>.
    /// </summary>
    /// <param name="s">The string to parse.</param>
    /// <returns>The parsed <see cref="CqlLibraryVersion"/>.</returns>
    /// <exception cref="FormatException">Thrown when the string is not a valid CQL library version.</exception>
    public static CqlLibraryVersion Parse(string s)
    {
        return TryParse(s, out var result)
                   ? result
                   : throw new FormatException("Not a valid ElmLibraryVersion");
    }

    /// <summary>
    /// Tries to parse the specified string to a <see cref="CqlLibraryVersion"/>.
    /// </summary>
    /// <param name="s">The string to parse.</param>
    /// <param name="provider">The format provider.</param>
    /// <param name="result">The parsed <see cref="CqlLibraryVersion"/>.</param>
    /// <returns><c>true</c> if the string was successfully parsed; otherwise, <c>false</c>.</returns>
    static bool IParsable<CqlLibraryVersion>.TryParse(
        [NotNullWhen(true)] string? s,
        IFormatProvider? provider,
        out CqlLibraryVersion result)
    {
        return TryParse(s, out result);
    }

    /// <summary>
    /// Tries to parse the specified string to a <see cref="CqlLibraryVersion"/>.
    /// </summary>
    /// <param name="s">The string to parse.</param>
    /// <param name="result">The parsed <see cref="CqlLibraryVersion"/>.</param>
    /// <returns><c>true</c> if the string was successfully parsed; otherwise, <c>false</c>.</returns>
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

    /// <summary>
    /// Compares the current instance with another <see cref="CqlLibraryVersion"/> and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other <see cref="CqlLibraryVersion"/>.
    /// </summary>
    /// <param name="other">The other <see cref="CqlLibraryVersion"/> to compare to.</param>
    /// <returns>A value that indicates the relative order of the objects being compared.</returns>
    public int CompareTo(CqlLibraryVersion other)
    {
        return string.Compare(_value, other._value, StringComparison.Ordinal);
    }

    /// <summary>
    /// Compares the current instance with another object and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
    /// </summary>
    /// <param name="obj">The object to compare to.</param>
    /// <returns>A value that indicates the relative order of the objects being compared.</returns>
    /// <exception cref="ArgumentException">Thrown when the object is not of type <see cref="CqlLibraryVersion"/>.</exception>
    int IComparable.CompareTo(object? obj)
    {
        return obj switch
        {
            CqlLibraryVersion other => CompareTo(other),
            _ => throw new ArgumentException($"Object must be of type {nameof(CqlLibraryVersion)}")
        };
    }

    #endregion
}
