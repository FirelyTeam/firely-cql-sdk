using System;
using static System.Net.Mime.MediaTypeNames;

namespace Hl7.Cql.CodeGeneration.NET;

internal readonly record struct IndentedTextWriter(TextWriter TextWriter, int Indent = 0) : IAddIndentMutable<IndentedTextWriter>
{
    public void WriteLine(int addIndent, string text = "") => TextWriter.WriteLine(Indent + addIndent, text);

    public void WriteLine(string text = "") => WriteLine(0, text);
    public void WriteLineNoIndent(string text = "") => TextWriter.WriteLine(text);

    public void Write(int addIndent, string text = "") => TextWriter.Write(Indent + addIndent, text);

    public void Write(string text = "") => Write(0, text);

    public void WriteSkipIndent(string text = "") => TextWriter.Write(text);

    public void WriteIndent(int addIndent = 0) => TextWriter.Write(StringExtensions.IndentString(Indent + addIndent));


    public IndentedTextWriter AddIndent(int addIndent = 1)
    {
        return this with { Indent = Indent + addIndent };
    }

    public TextWriter TextWriter { get; } = TextWriter;

    public int Indent { get; private init; } = Indent;
}