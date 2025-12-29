/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.CodeGeneration.NET;

internal static class TextWriterExtensions
{
    public const int SpacesPerIndentLevel = 4;

    public static void WriteLine(
        this StringWriter writer,
        int indent,
        string text = "")
    {
        var sb = writer.GetStringBuilder();
        sb.AppendLine(indent, text);
    }
}

internal static class StringBuilderExtensions
{
    public static void AppendLine(
        this StringBuilder sb,
        int indent,
        string text)
    {
        if (text.Length == 0)
            sb.AppendLine(); // Blank lines should not contain dangling whitespace
        else
        {
            sb.Append(StringExtensions.IndentString(indent));
            sb.AppendLine(text);
        }
    }

    // public static void AppendLine(
    //     this StringBuilder sb,
    //     int indent,
    //     string text)
    // {
    //     sb.Append(StringExtensions.IndentString(indent));
    //     sb.AppendLine(text);
    // }

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

    public static bool EndsWithNewLine(this StringBuilder sb) => sb.EndsWith(Environment.NewLine);

    public static bool AtBeginningOfLine(this StringBuilder sb) => sb.Length is 0 || sb.EndsWithNewLine();
}