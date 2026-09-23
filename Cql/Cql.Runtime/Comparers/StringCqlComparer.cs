/*
 * Copyright (c) 2023, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Comparers;

/// <summary>
/// Compares normalized strings given <see cref="StringComparer"/>.
/// </summary>
/// <remarks>
/// Strings are normalized using <see cref="string.Normalize()"/>.
/// Equality, ordering and hashing use the supplied <see cref="StringComparer"/>. Equivalence always
/// follows the CQL string semantics implemented by <see cref="EquivalentValues"/>.
/// </remarks>
internal class StringCqlComparer(
    StringComparer stringComparer) : CqlComparer<string>()
{
    private StringComparer StringComparer { get; } = stringComparer ?? throw new ArgumentNullException(nameof(stringComparer));

    /// <summary>
    /// The character every member of the whitespace lexical category is mapped to for equivalence.
    /// </summary>
    private const char CanonicalWhitespace = ' ';

    /// <summary>
    /// The members of the whitespace lexical category other than <see cref="CanonicalWhitespace"/>. CQL
    /// defines that category in Appendix A - CQL Syntax, Lexer Rules, as <c>WS : [ \r\n\t]+</c>.
    /// </summary>
    private static readonly char[] NonCanonicalWhitespaceCharacters = ['\r', '\n', '\t'];

    /// <inheritdoc/>
    protected override int? CompareValues(
        string x,
        string y,
        string? precision)
    {
        var result = StringComparer.Compare(x.Normalize(), y.Normalize());
        return result;
    }

    /// <inheritdoc/>
    protected override bool? EqualsValues(
        string x,
        string y,
        string? precision)
    {
        var thisNormalized = x.Normalize();
        var otherNormalized = y.Normalize();
        var areEqual = StringComparer.Equals(thisNormalized, otherNormalized);
        return areEqual;
    }

    /// <summary>
    /// Implements the string semantics of the CQL equivalent (<c>~</c>) operator, §9.B Equivalent:
    /// "For string values, equivalence returns true if the strings are the same value while ignoring
    /// case and locale, and normalizing whitespace. Normalizing whitespace means that all whitespace
    /// characters are treated as equivalent, with whitespace characters as defined in the whitespace
    /// lexical category."
    /// </summary>
    /// <remarks>
    /// Whitespace characters are equivalent to one another one for one; a run of them is not collapsed,
    /// so <c>'a  b'</c> is not equivalent to <c>'a b'</c>. Ignoring locale means comparing with
    /// <see cref="StringComparison.OrdinalIgnoreCase"/>, which behaves identically under every system
    /// locale, rather than with the <see cref="StringComparer"/> this instance carries for equality and
    /// ordering.
    /// </remarks>
    protected override bool EquivalentValues(
        string x,
        string y,
        string? precision)
    {
        var thisNormalized = CanonicalizeWhitespace(Normalize(x));
        var otherNormalized = CanonicalizeWhitespace(Normalize(y));
        return string.Equals(thisNormalized, otherNormalized, StringComparison.OrdinalIgnoreCase);
    }

    /// <inheritdoc/>
    protected override int GetHashCodeValue(string value) =>
        StringComparer.GetHashCode(Normalize(value));

    /// <summary>
    /// Unicode-normalizes <paramref name="value"/>, falling back to the raw string for invalid Unicode,
    /// which cannot be normalized. That keeps comparison and hashing total and deterministic.
    /// </summary>
    private static string Normalize(string value)
    {
        try
        {
            return value.Normalize();
        }
        catch (ArgumentException)
        {
            return value;
        }
    }

    /// <summary>
    /// Replaces every character of the whitespace lexical category with a single canonical one, so those
    /// characters compare as equivalent to each other while every other character is left untouched.
    /// </summary>
    private static string CanonicalizeWhitespace(string value)
    {
        if (value.IndexOfAny(NonCanonicalWhitespaceCharacters) < 0)
            return value;

        return string.Create(value.Length, value, static (destination, source) =>
        {
            for (var i = 0; i < source.Length; i++)
            {
                var c = source[i];
                destination[i] = c is '\r' or '\n' or '\t' ? CanonicalWhitespace : c;
            }
        });
    }
}
