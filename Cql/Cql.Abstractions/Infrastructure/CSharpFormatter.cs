using System.IO;
using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;

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
        TypeFormatterOptions? typeFormatterOptions = null,
        TextWriter? textWriter = null)
    {
        typeFormatterOptions ??= TypeFormatterOptions.Default;
        var typeFormatContext = new TypeFormatterContext(type, typeFormatterOptions);
        return typeFormatterOptions.TypeFormat(typeFormatContext).WriteToTextWriter(textWriter);
    }

    public static TextWriter WriteCSharp(
        this ParameterInfo parameterInfo,
        ParameterFormatterOptions? parameterFormatterOptions = null,
        TextWriter? textWriter = null)
    {
        parameterFormatterOptions ??= ParameterFormatterOptions.Default;
        var parameterFormatContext = new ParameterFormatterContext(parameterInfo, parameterFormatterOptions);
        return parameterFormatterOptions.ParameterFormat(parameterFormatContext).WriteToTextWriter(textWriter);
    }

    public static TextWriter WriteCSharp(
        this MethodInfo methodInfo,
        MethodFormatterOptions? methodFormatterOptions = null,
        TextWriter? textWriter = null)
    {
        methodFormatterOptions ??= MethodFormatterOptions.Default;
        var methodFormatContext = new MethodFormatterContext(methodInfo, methodFormatterOptions);
        return methodFormatterOptions.MethodFormat(methodFormatContext).WriteToTextWriter(textWriter);
    }

    internal static StringWriter NewInvariantCultureStringWriter() => new(CultureInfo.InvariantCulture);
}

internal delegate TextWriterFormattableString TypeFormatter(TypeFormatterContext type);

internal record TypeFormatterOptions(
    bool HideNamespaces = false,
    bool PreferKeywords = false,
    bool ShowGenericTypeParameterNames = false, // e.g. IDictionary<TKey,TValue> instead of IDictionary<,>
    string TypeDelimiter = ",", // [int,string] or <TKey,TValue>
    string NestedTypeDelimiter = ".") // A.Nested.Nested
{
    public static readonly TypeFormatterOptions Default = new();

    private const char OpenArrayBracket = '[';
    private const char CloseArrayBracket = ']';
    private const char NullOperator = '?';
    private const char OpenGenericTypeBracket = '<';
    private const char CloseGenericTypeBracket = '>';
    private const char PointerOperator = '*';

    public static readonly TypeFormatter DefaultTypeFormat = type => $"{type.Type}";
    public TypeFormatter TypeFormat => DefaultTypeFormat;

    protected internal virtual TextWriter WriteToTextWriter(
        Type type,
        TextWriter? textWriter = null)
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
            WriteToTextWriter(declaringType, textWriter);
            textWriter.Write(NestedTypeDelimiter);
            hideNamespaces = true; // Nested types are always in the same namespace.
        }

        // Name
        if (type.IsGenericTypeParameter)
        {
            if (ShowGenericTypeParameterNames)
                WriteName();
        }
        else if (type.IsArray)
        {
            WriteToTextWriter(type.GetElementType()!, textWriter);
        }
        else if (type.IsValueType && type.IsNullableValueType(out var underlyingType))
        {
            isNullableValueType = true;
            WriteToTextWriter(underlyingType, textWriter);
        }
        else if (type.IsPointer)
        {
            WriteToTextWriter(type.GetElementType()!, textWriter);
        }
        else
        {
            WriteName();
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
                WriteToTextWriter(arg, textWriter);
            }
            textWriter.Write(CloseGenericTypeBracket);
        }

        // Pointer
        if (type.IsPointer)
            textWriter.Write(PointerOperator);

        return textWriter;

        void WriteName()
        {
            string name = hideNamespaces ? type.Name : (type.FullName ?? type.Name);
            if (name.IndexOf('`') is var i and >= 0)
                textWriter.Write(name[..i]);
            else
                textWriter.Write(name);
        }
    }
}

internal readonly record struct TypeFormatterContext(
    Type TypeInfo,
    TypeFormatterOptions TypeFormatterOptions)
{
    public Type TypeInfo { get; } = TypeInfo;

    public TextWriterFormattableString Type => $"{TypeFormatterOptions.WriteToTextWriter(TypeInfo).ToString()!}";
}


internal delegate TextWriterFormattableString ParameterFormatter(ParameterFormatterContext parameter);

internal class ParameterFormatterOptions(
    ParameterFormatter? parameterFormat = null,
    TypeFormatterOptions? typeFormatting = null)
{
    private static readonly ParameterFormatter DefaultParameterFormat = (parameter => $"{parameter.Type} {parameter.Name}");
    public ParameterFormatter ParameterFormat { get; } = parameterFormat ?? DefaultParameterFormat;
    public TypeFormatterOptions TypeFormatterOptions { get; } = typeFormatting ?? TypeFormatterOptions.Default;
    public static ParameterFormatterOptions Default { get; } = new();
}

internal readonly record struct ParameterFormatterContext(
    ParameterInfo ParameterInfo,
    ParameterFormatterOptions ParameterFormatterOptions)
{
    public ParameterInfo ParameterInfo { get; } = ParameterInfo;
    public string Name => ParameterInfo.Name!;

    public TextWriterFormattableString Type =>
        ParameterFormatterOptions.TypeFormatterOptions.TypeFormat(
            new TypeFormatterContext(ParameterInfo.ParameterType, ParameterFormatterOptions.TypeFormatterOptions));
}

internal delegate TextWriterFormattableString MethodFormatter(MethodFormatterContext method);

internal class MethodFormatterOptions(
    MethodFormatter? methodFormat = null,
    ParameterFormatterOptions? parameterFormatting = null,
    string parameterSeparator = ", ")
{
    private static readonly MethodFormatter DefaultMethodFormat = (method => $"{method.ReturnType} {method.Name}({method.Parameters})");
    public MethodFormatter MethodFormat { get; } = methodFormat ?? DefaultMethodFormat;
    public ParameterFormatterOptions ParameterFormatterOptions { get; } = parameterFormatting ?? ParameterFormatterOptions.Default;
    public string ParameterSeparator { get; } = parameterSeparator;
    public static MethodFormatterOptions Default { get; } = new();
}

internal readonly record struct MethodFormatterContext(
    MethodInfo MethodInfo,
    MethodFormatterOptions MethodFormatterOptions)
{
    public MethodInfo MethodInfo { get; } = MethodInfo;

    public string Name => MethodInfo.Name;

    public TextWriterFormattableString ReturnType =>
        MethodFormatterOptions.ParameterFormatterOptions.TypeFormatterOptions.TypeFormat(
            new TypeFormatterContext(MethodInfo.ReturnType, MethodFormatterOptions.ParameterFormatterOptions.TypeFormatterOptions));

    public TextWriterFormattableString Parameters
    {
        get
        {
            MethodFormatterContext self = this;
            IEnumerable<TextWriterFormattableString> formatterParameters =
                MethodInfo
                    .GetParameters()
                    .Select(p => self.MethodFormatterOptions.ParameterFormatterOptions.ParameterFormat(new ParameterFormatterContext(p, self.MethodFormatterOptions.ParameterFormatterOptions)));
            return TextWriterFormattableString.Join(MethodFormatterOptions.ParameterSeparator, formatterParameters);
        }
    }
}

[InterpolatedStringHandler]
internal struct TextWriterFormattableString
{
    private Action<TextWriter> _appender = null!;

    public TextWriterFormattableString(int literalLength = 0, int formattedCount = 0)
    {
    }

    private void Append(Action<TextWriter> a) =>
        _appender += a;

    public void AppendLiteral(string s) =>
        Append(textWriter => textWriter.Write(s));

    public void AppendFormatted(string s) =>
        Append(textWriter => textWriter.Write(s));

    public void AppendFormatted(TextWriterFormattableString innerFormatter) =>
        Append(t => innerFormatter.WriteToTextWriter(t));

    public static TextWriterFormattableString Join(
        string separator,
        IEnumerable<TextWriterFormattableString> formatStrings)
    {
        TextWriterFormattableString s = new();
        bool first = true;
        foreach (var formatString in formatStrings)
        {
            if (first)
                first = false;
            else if (separator != "")
                s.Append(textWriter => textWriter.Write(separator));

            s.Append(textWriter => formatString.WriteToTextWriter(textWriter));
        }
        return s;
    }

    public TextWriter WriteToTextWriter(TextWriter? textWriter = null)
    {
        textWriter ??= CSharpFormatter.NewInvariantCultureStringWriter();
        _appender?.Invoke(textWriter);
        return textWriter;
    }
}
