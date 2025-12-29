/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.CodeGeneration.NET;

internal class IndentedStringBuilder(
    StringBuilder? stringBuilder = null,
    int indent = 0) : IAddIndentMutable<IndentedStringBuilder>
{
    /// <summary>
    /// Writes a multiline text to the underlying <see cref="System.Text.StringBuilder"/> while following a consistent indent.
    /// Leading tabs will be treated as indents.
    /// </summary>
    public IndentedStringBuilder Append(string text = "")
    {
        StringBuilder.Append(text);
        return this;
    }

    /// <summary>
    /// Writes a multiline text to the underlying <see cref="System.Text.StringBuilder"/> while following a consistent indent.
    /// Leading tabs will be treated as indents.
    /// </summary>
    public IndentedStringBuilder AppendLine(string text = "") => AppendLine(0, text);

    /// <summary>
    /// Writes a multiline text to the underlying <see cref="System.Text.StringBuilder"/> while following a consistent indent plus an additional indent from <paramref name="addIndent"/>.
    /// Leading tabs will be treated as indents.
    /// </summary>
    public IndentedStringBuilder AppendLine(int addIndent, string multilineText = "")
    {
        foreach (var line in multilineText.Split(Environment.NewLine))
        {
            if (line.Length > 0)
            {
                if (!StringBuilder.AtBeginningOfLine())
                    throw new InvalidOperationException("Expecting indents to start at beginning of a line");

                int leadingTabs = line.TakeWhile(c => c == '\t').Count();
                var strippedLeadingTabs = line[leadingTabs..];
                if (strippedLeadingTabs.Length > 0)
                {
                    var finalIndent = Indent + leadingTabs + addIndent;
                    StringBuilder.AppendLine(finalIndent, strippedLeadingTabs);
                    continue;
                }
            }

            StringBuilder.AppendLine();
        }
        return this;
    }

    public IndentedStringBuilder AddIndent(int addIndent = 1) => new(StringBuilder, Indent + addIndent);

    public int Indent { get; } = indent;

    public StringBuilder StringBuilder { get; } = stringBuilder ?? new();

    public override string ToString() => StringBuilder.ToString();
}
