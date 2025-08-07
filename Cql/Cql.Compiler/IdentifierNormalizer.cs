/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Microsoft.CodeAnalysis.CSharp;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Utility methods for C# identifier normalization.
/// </summary>
public static class IdentifierNormalizer
{
    /// <summary>
    /// Normalizes a string to be a valid C# identifier.
    /// </summary>
    /// <param name="identifier">The input string to normalize</param>
    /// <returns>A valid C# identifier</returns>
    public static string NormalizeIdentifier(string identifier)
    {
        if (string.IsNullOrEmpty(identifier))
            return "_"; // Return a valid identifier for empty input

        ReadOnlySpan<char> span = identifier.AsSpan();

        int leadingUnderscoreCount = 0;
        while (leadingUnderscoreCount < span.Length && span[leadingUnderscoreCount] == '_')
            leadingUnderscoreCount++;

        if (leadingUnderscoreCount > 0)
            span = span[leadingUnderscoreCount..];

        if (span.Length > 0 && span[0] == '$')
            span = span[1..];

        Span<char> buffer = stackalloc char[span.Length + 2];
        int bufferIndex = 0;

        foreach (var c in span)
        {
            switch (c)
            {
                case '"':
                case '\'':
                    continue;
                case '&':
                    buffer[bufferIndex++] = 'a';
                    buffer[bufferIndex++] = 'n';
                    buffer[bufferIndex++] = 'd';
                    continue;
                default:
                    buffer[bufferIndex++] = SyntaxFacts.IsIdentifierPartCharacter(c) ? c : '_';
                    break;
            }
        }

        var normalized = buffer[..bufferIndex].ToString();

        if (normalized.Length > 0 && !SyntaxFacts.IsIdentifierStartCharacter(normalized[0]))
            leadingUnderscoreCount++;

        if (leadingUnderscoreCount > 0)
            normalized = new string('_', leadingUnderscoreCount) + normalized;

        // Ensure we never return an empty string
        if (string.IsNullOrEmpty(normalized))
            normalized = "_";

        if (SyntaxFacts.GetKeywordKind(normalized) != SyntaxKind.None)
            normalized = $"@{normalized}";

        return normalized;
    }
}