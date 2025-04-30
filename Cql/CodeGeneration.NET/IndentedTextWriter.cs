namespace Hl7.Cql.CodeGeneration.NET;

internal readonly record struct IndentedTextWriter(TextWriter TextWriter, int Indent = 0) : IAddIndentMutable<IndentedTextWriter>
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
        foreach (var line in multilineText.Split(Environment.NewLine))
        {
            if (line.Length > 0)
            {
                int leadingTabs = line.TakeWhile(c => c == '\t').Count();
                var strippedLeadingTabs = line[leadingTabs..];
                if (strippedLeadingTabs.Length > 0)
                {
                    TextWriter.WriteLine(Indent + leadingTabs + addIndent, strippedLeadingTabs);
                    continue;
                }
            }

            TextWriter.WriteLine();
        }
    }

    public IndentedTextWriter AddIndent(int addIndent = 1)
    {
        return this with { Indent = Indent + addIndent };
    }

    private TextWriter TextWriter { get; } = TextWriter;

    public int Indent { get; private init; } = Indent;
}