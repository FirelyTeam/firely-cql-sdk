/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Diagnostics;

namespace Hl7.Cql.CodeGeneration.NET;

[DebuggerDisplay("{ToString(),nq}")]
internal class IndentedStringBuilder(
    StringBuilder? stringBuilder = null,
    int indent = 0) : IAddIndentMutable<IndentedStringBuilder>
{
    public IndentedStringBuilder Append(int addIndent, string text = "") =>
        AppendCore(addIndent, text, addNewLine: false);

    public IndentedStringBuilder Append(string text = "") =>
        AppendCore(0, text, addNewLine: false);

    /// <summary>
    /// Writes a multiline text to the underlying <see cref="System.Text.StringBuilder"/> while following a consistent indent.
    /// Leading tabs will be treated as indents.
    /// </summary>
    public IndentedStringBuilder AppendLine(string text = "") =>
        AppendCore(0, text, addNewLine: true);

    /// <summary>
    /// Writes a multiline text to the underlying <see cref="System.Text.StringBuilder"/> while following a consistent indent plus an additional indent from <paramref name="addIndent"/>.
    /// Leading tabs will be treated as indents.
    /// </summary>
    public IndentedStringBuilder AppendLine(int addIndent, string multilineText = "") =>
        AppendCore(addIndent, multilineText, addNewLine: true);

    private IndentedStringBuilder AppendCore(
        int addIndent,
        string multilineText,
        bool addNewLine = false)
    {
        var lines = multilineText.Split(Environment.NewLine);
        var sb = StringBuilder;

        for (var index = 0; index < lines.Length; index++)
        {
            var line = lines[index];
            if (line.Length > 0)
            {
                int finalIndent = 0;
                if (sb.AtBeginningOfLine())
                {
                    int leadingTabs = line.TakeWhile(c => c == '\t').Count();
                    line = line[leadingTabs..];
                    if (line.Length > 0)
                        finalIndent = Indent + leadingTabs + addIndent;
                }

                sb.Append(finalIndent, line);
            }

            if (addNewLine || index < lines.Length - 1)
                sb.AppendLine();
        }

        return this;
    }

    public IndentedStringBuilder AddIndent(int addIndent = 1) => new(StringBuilder, Indent + addIndent);

    public int Indent { get; } = indent;

    public StringBuilder StringBuilder { get; } = stringBuilder ?? new();

    public override string ToString() => StringBuilder.ToString();
}
