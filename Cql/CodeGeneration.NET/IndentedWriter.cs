using System.IO;

namespace Hl7.Cql.CodeGeneration.NET;

internal record IndentedWriter(StreamWriter StreamWriter, int Indent = 0) : IAddIndentMutable<IndentedWriter>
{
    public void WriteLine(int addIndent, string text = "") => StreamWriter.WriteLine(Indent + addIndent, text);

    public void WriteLine(string text = "") => WriteLine(0, text);

    public IndentedWriter AddIndent(int addIndent = 1)
    {
        return this with { Indent = Indent + addIndent };
    }

    private StreamWriter StreamWriter { get; } = StreamWriter;

    public int Indent { get; private init; } = Indent;
}