/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.CodeGeneration.NET;

internal readonly record struct IndentedTextWriter(StringWriter TextWriter, int Indent = 0) : IAddIndentMutable<IndentedTextWriter>
{
    /// <summary>
    /// Writes a multiline text to the <see cref="TextWriter"/> while following a consistent indent.
    /// Leading tabs will be treated as indents.
    /// </summary>
    public void WriteLine(string text = "") => WriteLine(0, text);

    /// <summary>
    /// Writes a multiline text to the <see cref="TextWriter"/> while following a consistent indent plus an additional indent from <paramref name="addIndent"/>.
    /// Leading tabs will be treated as indents.
    /// </summary>
    public void WriteLine(int addIndent, string multilineText = "")
    {
        var sb = GetStringBuilder();
        foreach (var line in multilineText.Split(Environment.NewLine))
        {
            if (line.Length > 0)
            {
                if (!sb.AtBeginningOfLine())
                    throw new InvalidOperationException("Expecting indents to start at beginning of a line");

                int leadingTabs = line.TakeWhile(c => c == '\t').Count();
                var strippedLeadingTabs = line[leadingTabs..];
                if (strippedLeadingTabs.Length > 0)
                {
                    var finalIndent = Indent + leadingTabs + addIndent;
                    sb.AppendLine(finalIndent, strippedLeadingTabs);
                    continue;
                }
            }

            sb.AppendLine();
        }
    }

    public IndentedTextWriter AddIndent(int addIndent = 1)
    {
        return this with { Indent = Indent + addIndent };
    }

    private StringWriter TextWriter { get; } = TextWriter;

    public int Indent { get; private init; } = Indent;

    private StringBuilder GetStringBuilder() => TextWriter.GetStringBuilder();
}
