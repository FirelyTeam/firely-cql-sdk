/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.CodeGeneration.NET;

internal static class StringBuilderExtensions
{
    public const int SpacesPerIndentLevel = 4;

    /// <summary>
    /// The line ending generated C# is written with.
    /// </summary>
    /// <remarks>
    /// Fixed rather than <see cref="Environment.NewLine"/> so the same inputs produce the same bytes on
    /// every operating system. The generated C# is embedded verbatim as a base64 attachment on a packaged
    /// FHIR Library, where git cannot normalize it the way it normalizes a file on disk, so a
    /// platform-dependent newline would make those resources a record of the machine that built them.
    /// LF is what the repository stores.
    /// </remarks>
    public const string NewLine = "\n";

    public static void AppendLine(
        this StringBuilder sb,
        int indent,
        string text)
    {
        if (text.Length == 0)
            sb.Append(NewLine); // Blank lines should not contain dangling whitespace
        else
        {
            sb.Append(StringExtensions.IndentString(indent));
            sb.Append(text).Append(NewLine);
        }
    }

    public static void Append(
        this StringBuilder sb,
        int indent,
        string text)
    {
        sb.Append(StringExtensions.IndentString(indent));
        sb.Append(text);
    }

    public static bool EndsWith(this StringBuilder sb, string text = "")
    {
        if (text.Length == 0)
            return true;

        if (sb.Length < text.Length)
            return false;

        for (int i = 0; i < text.Length; i++)
            if (sb[sb.Length - text.Length + i] != text[i])
                return false;

        return true;
    }

    public static bool EndsWithNewLine(this StringBuilder sb) => sb.EndsWith(NewLine);

    public static bool AtBeginningOfLine(this StringBuilder sb) => sb.Length is 0 || sb.EndsWithNewLine();
}