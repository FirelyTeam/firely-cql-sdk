using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Hl7.Cql.CodeGeneration.NET;

internal abstract class CodeWriter : TextWriter
{
    public const string DefaultTabString = "    ";

    private readonly IBaseWriterHelper _helper;
    private readonly string _indent;
    private ImmutableList<string> _currentIndents;
    private ImmutableList<string> _nextIndents;
    private bool _isAfterNewLine;
    private char _lastChar;
    private char _secondLastChar;
    protected readonly TextWriter _baseWriter;

    public override Encoding Encoding => _baseWriter.Encoding;


    protected CodeWriter(TextWriter baseWriter, string tabString = DefaultTabString)
    {
        _baseWriter = baseWriter;
        _isAfterNewLine = false;
        _indent = tabString;
        _currentIndents = _nextIndents = ImmutableList<string>.Empty;
        _helper = CreateBaseWriterHelper() ?? throw new NotSupportedException("BaseWriter not supported.");
    }

    protected abstract IBaseWriterHelper? CreateBaseWriterHelper();

    public void Indent(string indent, Action action)
    {
        _nextIndents = _nextIndents.Add(indent);
        if (_isAfterNewLine)
            _currentIndents = _nextIndents;
        try
        {
            action();
        }
        finally
        {
            _nextIndents = _nextIndents.RemoveAt(_nextIndents.Count - 1);
            if (_isAfterNewLine)
                _currentIndents = _nextIndents;
        }
    }

    public void Indent(Action action) =>
        Indent(_indent, action);

    public override string ToString() => _helper.WriteToString(this);

    private void DumpIndents()
    {
        foreach (var indent in _currentIndents)
        {
            _baseWriter.Write(indent);
        }
        _currentIndents = _nextIndents;
    }

    public override void Write(char value)
    {
        if (_isAfterNewLine)
        {
            bool nextCharIsNewLine = IsANewLineChar(value);

            if (!nextCharIsNewLine)
            {
                DumpIndents();
            }
        }

        _baseWriter.Write(value);

        _secondLastChar = _lastChar;
        _lastChar = value;
        _isAfterNewLine = IsNewLine(_secondLastChar, _lastChar);
    }

    private bool IsNewLine(char c0, char c1) =>
        NewLine.Length switch
        {
            1 => NewLine[0] == c1,
            2 => NewLine[0] == c0 && NewLine[1] == c1,
            _ => false,
        };

    private bool IsANewLineChar(char value) =>
        NewLine.Length switch
        {
            1 => NewLine[0] == value,
            2 => NewLine[0] == value || NewLine[1] == value,
            _ => false,
        };

    public override void Flush()
    {
        _baseWriter.Flush();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            _baseWriter.Dispose();
        }
        base.Dispose(disposing);
    }

    protected interface IBaseWriterHelper
    {
        string WriteToString(CodeWriter owner);
    }
}

internal class StreamCodeWriter : CodeWriter
{
    public StreamCodeWriter(Stream stream, Encoding? encoding = null, int bufferSize = 1024, bool leaveOpen = false, string tabString = DefaultTabString)
        : base(new StreamWriter(stream, encoding ?? Encoding.UTF8, bufferSize, leaveOpen), tabString)
    {
    }

    protected override IBaseWriterHelper? CreateBaseWriterHelper() =>
        _baseWriter is StreamWriter { BaseStream: { CanSeek: true, CanWrite: true } s }
            ? new StreamBaseWriterHelper(s)
            : null;

    private readonly record struct StreamBaseWriterHelper(Stream BaseStream) : IBaseWriterHelper
    {
        public string WriteToString(CodeWriter owner)
        {
            if (BaseStream.Position == 0)
                return "";

            BaseStream.Seek(0, SeekOrigin.Begin);
            var text = new StreamReader(BaseStream).ReadToEnd();
            return text;
        }
    }
}

internal class StringBuilderCodeWriter : CodeWriter
{
    public StringBuilderCodeWriter(string tabString = DefaultTabString) : base(new StringWriter(), tabString)
    {
    }

    protected override IBaseWriterHelper? CreateBaseWriterHelper() =>
        _baseWriter is StringWriter sw
            ? new StringBuilderBaseWriterHelper(sw.GetStringBuilder())
            : null;


    private readonly record struct StringBuilderBaseWriterHelper(StringBuilder BaseStringBuilder) : IBaseWriterHelper
    {
        public string WriteToString(CodeWriter owner) => BaseStringBuilder.ToString();
    }
}