/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;

namespace Hl7.Cql.Packaging;

internal static partial class FhirIdGenerator
{
    private static readonly MD5 MD5 = MD5.Create();

    [GeneratedRegex(
        """
        (?<word>
          [A-Z][a-z]+
          |[A-Z]([A-Z0-9](?![a-z]))+
          |[a-z]+
        )
        |
        (?<number>
          [0-9]+
        )
        """, RegexOptions.IgnorePatternWhitespace)]
    private static partial Regex SegmentizeRegex();

    /// <summary>
    /// Combines the name and version and a shortened MD5 hash to generate a FHIR ID which fits within the 64 characters limit.
    /// See the <see href="https://www.hl7.org/fhir/datatypes.html#id">spec</see> for more details.
    /// </summary>
    public static string GenerateFhirId(CqlVersionedLibraryIdentifier identifier)
    {
        string hashSuffix = GetMd5Hash(identifier)[..8];
        int maxSegLength = 64;
        var name = identifier.Identifier.ToString();
        var ver = identifier.Version?.ToString();
        var matches = SegmentizeRegex().Matches(name).ToList();
        while(true)
        {
            string abbreviatedName = Segmentize(matches, maxSegLength, "-");
            string id = ver is { Length: > 0 }
                            ? $"{hashSuffix}-{abbreviatedName}-{ver}"
                            : $"{hashSuffix}-{abbreviatedName}";

            if (id.Length <= 64)
                return id;

            if (maxSegLength == 1)
                break;

            if (maxSegLength > 8)
                maxSegLength /= 2;

            else maxSegLength--;
        }

        return hashSuffix;
    }

    private static string Segmentize(
        IEnumerable<Match> matches,
        int maxAbbrLength,
        string delimiter)
    {
        StringBuilder sb = new StringBuilder();
        foreach (var m in matches)
        {
            if (m.Groups["word"].ValueSpan is { Length: > 0 } word)
                sb.Append(word[..Math.Min(word.Length, maxAbbrLength)]);

            else if (m.Groups["number"].ValueSpan is { Length: > 0 } number)
                sb.Append(number);

            sb.Append(delimiter);
        }
        return sb.ToString(0, sb.Length - delimiter.Length).ToLowerInvariant();
    }

    private static string GetMd5Hash(CqlVersionedLibraryIdentifier input)
    {
        var text = input.FormatDelimited('*');
        byte[] hashBytes = MD5.ComputeHash(Encoding.UTF8.GetBytes(text));
        StringBuilder sb = new StringBuilder();
        foreach (byte b in hashBytes)
            sb.Append(b.ToString("x2", CultureInfo.InvariantCulture));
        return sb.ToString();
    }
}