/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Compiler;

/// <summary>
/// Utility methods for C# identifier normalization.
/// </summary>
internal static class IdentifierNormalizer
{
    /// <summary>
    /// Normalizes a string to be a valid C# identifier.
    /// </summary>
    /// <param name="identifier">The input string to normalize</param>
    /// <returns>A valid C# identifier</returns>
    public static string Normalize(string identifier)
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

        // Start with 1.5x the input length, minimum 16 characters
        var initialSize = Math.Max(16, (int)(span.Length * 1.5));
        char[] buffer = new char[initialSize];
        int bufferIndex = 0;

        foreach (var c in span)
        {
            switch (c)
            {
                case '"':
                case '\'':
                    continue;
                case '&':
                    EnsureBufferCapacity(ref buffer, bufferIndex + 5);
                    buffer[bufferIndex++] = '_';
                    buffer[bufferIndex++] = 'a';
                    buffer[bufferIndex++] = 'n';
                    buffer[bufferIndex++] = 'd';
                    buffer[bufferIndex++] = '_';
                    continue;
                // case '+':
                //     EnsureBufferCapacity(ref buffer, bufferIndex + 6);
                //     buffer[bufferIndex++] = '_';
                //     buffer[bufferIndex++] = 'p';
                //     buffer[bufferIndex++] = 'l';
                //     buffer[bufferIndex++] = 'u';
                //     buffer[bufferIndex++] = 's';
                //     buffer[bufferIndex++] = '_';
                //     continue;
                // case '-':
                //     EnsureBufferCapacity(ref buffer, bufferIndex + 7);
                //     buffer[bufferIndex++] = '_';
                //     buffer[bufferIndex++] = 'm';
                //     buffer[bufferIndex++] = 'i';
                //     buffer[bufferIndex++] = 'n';
                //     buffer[bufferIndex++] = 'u';
                //     buffer[bufferIndex++] = 's';
                //     buffer[bufferIndex++] = '_';
                //     continue;
                default:
                    EnsureBufferCapacity(ref buffer, bufferIndex + 1);
                    buffer[bufferIndex++] = SyntaxFacts.IsIdentifierPartCharacter(c) ? c : '_';
                    break;
            }
        }

        var normalized = new string(buffer, 0, bufferIndex);

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

    /// <summary>
    /// Ensures the buffer has enough capacity for the required length.
    /// If not, grows the buffer by 1.5x and copies existing content.
    /// </summary>
    /// <param name="buffer">The buffer to potentially resize</param>
    /// <param name="requiredLength">The minimum required length</param>
    private static void EnsureBufferCapacity(ref char[] buffer, int requiredLength)
    {
        if (requiredLength <= buffer.Length)
            return;

        // Grow by 1.5x, ensuring we meet the required length
        var newSize = Math.Max(requiredLength, (int)(buffer.Length * 1.5));
        var newBuffer = new char[newSize];
        Array.Copy(buffer, newBuffer, buffer.Length);
        buffer = newBuffer;
    }
}