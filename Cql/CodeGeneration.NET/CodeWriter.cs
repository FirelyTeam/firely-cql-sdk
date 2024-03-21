using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;

namespace Hl7.Cql.CodeGeneration.NET;

internal class CodeWriter : IndentedTextWriter
{
    private readonly Stream _baseStream;

    public CodeWriter(TextWriter writer, string tabString = "    ") : base(writer, tabString)
    {
        _baseStream = GetBaseStream(writer);
    }

    private static Stream GetBaseStream(TextWriter writer)
    {
        Stream? stream = writer is StreamWriter { BaseStream: { CanSeek: true, CanWrite: true } s } ? s: null;
        Debug.Assert(stream is not null, "Must have a StreamWriter with a seekable and writable BaseStream.");
        return stream!;
    }

    public long Position => _baseStream.Position;

    public void TruncateToLength(long length) => _baseStream.SetLength(length);

    public void WithIndent(Action action)
    {
        Indent++;
        try
        {
            action();
        }
        finally
        {
            Indent--;
        }
    }
}