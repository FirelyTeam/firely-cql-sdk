/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime.Serialization;

namespace Hl7.Cql.Runtime;

/// <summary>
/// Represents the version part of a CQL library identifier.
/// </summary>
[JsonConverter(typeof(StringEncapsulatedValueJsonConverter<CqlLibraryVersion>))]
public readonly record struct CqlLibraryVersion :
    IParsable<CqlLibraryVersion>
{
    /// <summary>
    /// Implicitly converts a <see cref="CqlLibraryVersion"/> to a <see cref="string"/>.
    /// </summary>
    /// <param name="version">The <see cref="CqlLibraryVersion"/> to convert.</param>
    /// <returns>The string representation of the version.</returns>
    public static implicit operator string(CqlLibraryVersion version) => version._value;

    /// <summary>
    /// Explicitly converts a <see cref="string"/> to a <see cref="CqlLibraryVersion"/>.
    /// </summary>
    /// <param name="version">The string to convert.</param>
    /// <returns>The <see cref="CqlLibraryVersion"/> representation of the string.</returns>
    /// <exception cref="FormatException">Thrown when the string is not a valid version.</exception>
    public static explicit operator CqlLibraryVersion(string version) => Parse(version);

    private readonly string _value;

    /// <summary>
    /// Initializes a new instance of the <see cref="CqlLibraryVersion"/> struct.
    /// </summary>
    /// <param name="value">The version string.</param>
    private CqlLibraryVersion(string value) => _value = value ?? throw new ArgumentNullException(nameof(value));

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
}