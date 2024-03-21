using System;
using System.CodeDom.Compiler;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Hl7.Cql.CodeGeneration.NET;

internal class CodeWriter : IndentedTextWriter
{
    private static readonly FieldInfo __tabsPendingField = typeof(IndentedTextWriter).GetField("_tabsPending", BindingFlags.NonPublic | BindingFlags.Instance)!;
    private readonly IUtility _util;

    protected CodeWriter(TextWriter writer, string tabString = DefaultTabString) : base(writer, tabString)
    {
        _util = Wrap(writer);
    }

    private static IUtility Wrap(TextWriter writer) =>
        writer switch
        {
            StreamWriter { BaseStream: { CanSeek: true, CanWrite: true } s } => new StreamUtility(s),
            StringWriter s => new StringBuilderUtility(s.GetStringBuilder()),
            _ => throw new NotSupportedException("Writer must either be a StreamWriter with a seekable and writable BaseStream, or a StringWriter."),
        };

    public int Position => _util.GetPosition(this);

    public void TruncateToLength(int length) => _util.TruncateToLength(this, length);

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

    public string DebuggerView =>
        _util.WriteToString(this);

    public string DebuggerViewLast20Lines =>
        string.Join(Environment.NewLine,
            DebuggerView.Split(new []{Environment.NewLine}, StringSplitOptions.None).TakeLast(20)
        );

    public override string ToString() => _util.WriteToString(this);

    protected override void OutputTabs()
    {
        if (Indent > 0 && _util.GetPosition(this) == 0)
        {
            __tabsPendingField.SetValue(this, true);
        }
        base.OutputTabs();
    }

    private interface IUtility
    {
        int GetPosition(CodeWriter owner);
        void TruncateToLength(CodeWriter owner, int length);
        string WriteToString(CodeWriter owner);
    }

    private readonly record struct StreamUtility(Stream BaseStream) : IUtility
    {
        public int GetPosition(CodeWriter owner)
        {
            owner.Flush();
            return (int)BaseStream.Position;
        }

        public void TruncateToLength(CodeWriter owner, int length)
        {
            owner.Flush();
            BaseStream.SetLength(length);
        }

        public string WriteToString(CodeWriter owner)
        {
            owner.Flush();
            if (GetPosition(owner) == 0) 
                return "";

            BaseStream.Seek(0, SeekOrigin.Begin);
            var text = new StreamReader(BaseStream).ReadToEnd();
            return text;
        }
    }

    private readonly record struct StringBuilderUtility(StringBuilder BaseStringBuilder) : IUtility
    {
        public int GetPosition(CodeWriter owner)
        {
            owner.Flush();
            return BaseStringBuilder.Length;
        }

        public void TruncateToLength(CodeWriter owner, int length)
        {
            owner.Flush();
            BaseStringBuilder.Remove(length, BaseStringBuilder.Length - length);
        }

        public string WriteToString(CodeWriter owner)
        {
            owner.Flush();
            if (GetPosition(owner) == 0) 
                return "";

            return BaseStringBuilder.ToString();
        }
    }
}

internal class StringBuilderCodeWriter : CodeWriter
{
    public StringBuilderCodeWriter(string tabString = DefaultTabString) : base(new StringWriter(), tabString)
    {
    }
}

internal class StreamCodeWriter : CodeWriter
{
    public StreamCodeWriter(Stream stream, Encoding? encoding = null, int bufferSize = 1024, bool leaveOpen = false, string tabString = DefaultTabString)
        : base(new StreamWriter(stream, encoding ?? Encoding.UTF8, bufferSize, leaveOpen), tabString)
    {
    }
}