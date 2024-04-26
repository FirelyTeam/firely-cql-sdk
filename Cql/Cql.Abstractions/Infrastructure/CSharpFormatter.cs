using System.IO;
using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Hl7.Cql.Abstractions.Infrastructure;

internal static class CSharpFormatter
{
    public static string? GetCSharpKeyword(this Type t)
    {
        if (t.Namespace != "System")
            return null;

        string? result = t.Name switch
        {
            "Void" when t == typeof(void)       => "void",
            "Boolean" when t == typeof(bool)    => "bool",
            "Byte" when t == typeof(byte)       => "byte",
            "SByte" when t == typeof(sbyte)     => "sbyte",
            "Char" when t == typeof(char)       => "char",
            "Int16" when t == typeof(short)     => "short",
            "UInt16" when t == typeof(ushort)   => "ushort",
            "Int32" when t == typeof(int)       => "int",
            "UInt32" when t == typeof(uint)     => "uint",
            "IntPtr" when t == typeof(nint)     => "nint",
            "UIntPtr" when t == typeof(nuint)   => "nuint",
            "Int64" when t == typeof(long)      => "long",
            "UInt64" when t == typeof(ulong)    => "ulong",
            "Single" when t == typeof(float)    => "float",
            "Double" when t == typeof(double)   => "double",
            "Decimal" when t == typeof(decimal) => "decimal",
            "String" when t == typeof(string)   => "string",
            "Object" when t == typeof(object)   => "object",
            _                                   => null
        };
        return result;
    }

    public static TextWriter WriteCSharp(
        this Type type,
        CSharpWriteTypeOptions? typeOptions = null,
        TextWriter? textWriter = null)
    {
        typeOptions ??= CSharpWriteTypeOptions.Default;
        return typeOptions.Write(textWriter, type);
    }

    public static TextWriter WriteCSharp(
        this ParameterInfo parameterInfo,
        CSharpWriteParameterOptions? parameterOptions = null,
        TextWriter? textWriter = null)
    {
        parameterOptions ??= CSharpWriteParameterOptions.Default;
        return parameterOptions.Write(
            textWriter,
            parameterInfo.Name!,
            () => parameterInfo.ParameterType.WriteCSharp(parameterOptions.CSharpWriteTypeOptions).ToString()!);
    }

    public static TextWriter WriteCSharp(
        this MethodInfo methodInfo,
        CSharpWriteMethodOptions? methodOptions = null,
        TextWriter? textWriter = null)
    {
        methodOptions ??= CSharpWriteMethodOptions.Default;
        return methodOptions.Write(
            textWriter,
            methodInfo.Name,
            () => methodInfo.GetParameters().SelectToArray(p => p.WriteCSharp(methodOptions.CSharpWriteParameterOptions).ToString()!),
            () => methodInfo.ReturnType.WriteCSharp(methodOptions.CSharpWriteParameterOptions.CSharpWriteTypeOptions).ToString()!);
    }

    internal static StringWriter NewInvariantCultureStringWriter() =>
        new(CultureInfo.InvariantCulture);
}

internal record CSharpWriteTypeOptions(
    bool HideNamespaces = false,
    bool PreferKeywords = false,
    bool ShowGenericTypeParameterNames = false, // e.g. IDictionary<TKey,TValue> instead of IDictionary<,>
    string TypeDelimiter = ",", // [int,string] or <TKey,TValue>
    string NestedTypeDelimiter = ".") // A.Nested.Nested
{
    public static readonly CSharpWriteTypeOptions Default = new();

    private const char OpenArrayBracket = '[';
    private const char CloseArrayBracket = ']';
    private const char NullOperator = '?';
    private const char OpenGenericTypeBracket = '<';
    private const char CloseGenericTypeBracket = '>';
    private const char PointerOperator = '*';

    protected internal virtual TextWriter Write(
        TextWriter? textWriter,
        Type type)
    {
        textWriter ??= CSharpFormatter.NewInvariantCultureStringWriter();

        if (PreferKeywords && type.GetCSharpKeyword() is { } keyword)
        {
            textWriter.Write(keyword);
            return textWriter;
        }

        var hideNamespaces = HideNamespaces;
        var isNullableValueType = false;

        // Nested parts first.
        if (type is {
                IsNested: true,
                IsGenericParameter: false, // Generic Parameters are nested, but not really.
                //IsGenericTypeParameter: false,
                DeclaringType: {} declaringType
        })
        {
            declaringType!.WriteCSharp(this, textWriter);
            textWriter.Write(NestedTypeDelimiter);
            hideNamespaces = true; // Nested types are always in the same namespace.
        }

        // Name
        if (type.IsGenericTypeParameter)
        {
            if (ShowGenericTypeParameterNames)
                WriteName(this);
        }
        else if (type.IsArray)
        {
            type.GetElementType()!.WriteCSharp(this, textWriter);
        }
        else if (type.IsValueType && type.IsNullableValueType(out var underlyingType))
        {
            isNullableValueType = true;
            underlyingType.WriteCSharp(this, textWriter);
        }
        else if (type.IsPointer)
        {
            type.GetElementType()!.WriteCSharp(this, textWriter);
        }
        else
        {
            WriteName(this);
        }


        // Brackets/Operators

        if (type.IsSZArray)
        {
            textWriter.Write(OpenArrayBracket);
            textWriter.Write(CloseArrayBracket);
        }
        else if (type.IsVariableBoundArray)
        {
            textWriter.Write(OpenArrayBracket);
            for (int i = 1; i < type.GetArrayRank(); i++)
                textWriter.Write(TypeDelimiter);
            textWriter.Write(CloseArrayBracket);
        }

        // Type Args
        if (isNullableValueType)
        {
            textWriter.Write(NullOperator);
        }
        else if (type.IsGenericType && !isNullableValueType)
        {
            textWriter.Write(OpenGenericTypeBracket);
            bool first = true;
            foreach (var arg in type.GetGenericArguments())
            {
                if (first) first = false;
                else textWriter.Write(TypeDelimiter);
                arg.WriteCSharp(this, textWriter);
            }
            textWriter.Write(CloseGenericTypeBracket);
        }

        // Pointer
        if (type.IsPointer)
            textWriter.Write(PointerOperator);

        return textWriter;

        void WriteName(CSharpWriteTypeOptions opt)
        {
            string name = hideNamespaces ? type.Name : (type.FullName ?? type.Name);
            if (name.IndexOf('`') is var i and >= 0)
                textWriter.Write(name[..i]);
            else
                textWriter.Write(name);
        }
    }
}

internal record CSharpWriteParameterOptions
{
    public static readonly CSharpWriteParameterOptions Default = new();

    public CSharpWriteParameterOptions(
        Func<(string name, Func<string> type), TextWriterFormatString>? parameterFormat = null,
        CSharpWriteTypeOptions? typeOptions = null)
    {
        CSharpWriteTypeOptions = typeOptions ?? CSharpWriteTypeOptions.Default;
        _format = parameterFormat ?? (t => $"{t.type} {t.name}");
    }

    private readonly Func<(string name, Func<string> type), TextWriterFormatString> _format;

    public CSharpWriteTypeOptions CSharpWriteTypeOptions { get; init; }

    protected internal virtual TextWriter Write(
        TextWriter? writer,
        string name,
        Func<string> type) =>
        _format((name, type)).Write(writer);
}

internal record CSharpWriteMethodOptions
{
    public static readonly CSharpWriteMethodOptions Default = new();

    public CSharpWriteMethodOptions(
        string parameterDelimiter = ", ",
        CSharpWriteParameterOptions? parameterOptions = null,
        Func<(
            string name,
            Func<string[]> parameters,
            Func<string> returnType), TextWriterFormatString>? methodFormat = null)
    {
        ParameterDelimiter = parameterDelimiter;
        _format = methodFormat ?? (t => $"{t.returnType} {t.name}({t.parameters})");
        CSharpWriteParameterOptions = parameterOptions ?? CSharpWriteParameterOptions.Default;
    }

    private readonly Func<(string name, Func<string[]> parameters, Func<string> returnType), TextWriterFormatString> _format;

    public string ParameterDelimiter { get; init; }

    public CSharpWriteParameterOptions CSharpWriteParameterOptions { get; init; }

    protected internal virtual TextWriter Write(
        TextWriter? writer,
        string name,
        Func<string[]> parameters,
        Func<string> returnType) =>
        _format((name, parameters, returnType)).Write(writer, ParameterDelimiter);
}

[InterpolatedStringHandler]
internal struct TextWriterFormatString
{
    private Action<(TextWriter writer, string delimiter)> _appender = null!;

    public TextWriterFormatString(int literalLength, int formattedCount)
    {
    }

    public void AppendLiteral(string s) => _appender += t => t.writer.Write(s);
    public void AppendFormatted(string s) => AppendLiteral(s);
    public void AppendFormatted(Func<string> s) => AppendLiteral(s());
    public void AppendFormatted(Func<string[]> s) => _appender += t => t.writer.Write(string.Join(t.delimiter, s()));
    public TextWriter Write(TextWriter? writer, string delimiter = "")
    {
        writer ??= CSharpFormatter.NewInvariantCultureStringWriter();
        _appender?.Invoke((writer, delimiter));
        return writer;
    }
}