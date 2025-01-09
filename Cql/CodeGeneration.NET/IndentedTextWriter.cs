using System.IO;

namespace Hl7.Cql.CodeGeneration.NET;

internal readonly record struct IndentedTextWriter(TextWriter TextWriter, int Indent = 0) : IAddIndentMutable<IndentedTextWriter>
{
    public void WriteLine(int addIndent, string text = "") => TextWriter.WriteLine(Indent + addIndent, text);

    public void WriteLine(string text = "") => WriteLine(0, text);

    public IndentedTextWriter AddIndent(int addIndent = 1)
    {
        return this with { Indent = Indent + addIndent };
    }

    private TextWriter TextWriter { get; } = TextWriter;

    public int Indent { get; private init; } = Indent;
}