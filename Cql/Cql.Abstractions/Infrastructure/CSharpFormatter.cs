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
        TypeFormatting? typeFormatOptions = null,
        TextWriter? textWriter = null)
    {
        typeFormatOptions ??= TypeFormatting.Default;
        var typeFormatContext = new TypeFormattingContext(type, typeFormatOptions);
        return typeFormatOptions.TypeFormat(typeFormatContext).WriteToTextWriter(textWriter);
    }

    public static TextWriter WriteCSharp(
        this ParameterInfo parameterInfo,
        ParameterFormatting? parameterFormatOptions = null,
        TextWriter? textWriter = null)
    {
        parameterFormatOptions ??= ParameterFormatting.Default;
        var parameterFormatContext = new ParameterFormattingContext(parameterInfo, parameterFormatOptions);
        return parameterFormatOptions.ParameterFormat(parameterFormatContext).WriteToTextWriter(textWriter);
    }

    public static TextWriter WriteCSharp(
        this MethodInfo methodInfo,
        MethodFormatting? methodFormatOptions = null,
        TextWriter? textWriter = null)
    {
        methodFormatOptions ??= MethodFormatting.Default;
        var methodFormatContext = new MethodFormattingContext(methodInfo, methodFormatOptions);
        return methodFormatOptions.MethodFormat(methodFormatContext).WriteToTextWriter(textWriter);
    }

    internal static StringWriter NewInvariantCultureStringWriter() => new(CultureInfo.InvariantCulture);
}

internal record TypeFormatting(
    bool HideNamespaces = false,
    bool PreferKeywords = false,
    bool ShowGenericTypeParameterNames = false, // e.g. IDictionary<TKey,TValue> instead of IDictionary<,>
    string TypeDelimiter = ",", // [int,string] or <TKey,TValue>
    string NestedTypeDelimiter = ".") // A.Nested.Nested
{
    public static readonly TypeFormatting Default = new();

    private const char OpenArrayBracket = '[';
    private const char CloseArrayBracket = ']';
    private const char NullOperator = '?';
    private const char OpenGenericTypeBracket = '<';
    private const char CloseGenericTypeBracket = '>';
    private const char PointerOperator = '*';

    public static readonly Func<TypeFormattingContext, TextWriterFormattableString> DefaultTypeFormat = type => $"{type.Type}";
    public Func<TypeFormattingContext, TextWriterFormattableString> TypeFormat => DefaultTypeFormat;

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

internal readonly record struct TypeFormattingContext(
    Type TypeInfo,
    TypeFormatting TypeFormatting)
{
    public Type TypeInfo { get; } = TypeInfo;

    public TextWriterFormattableString Type => $"{TypeFormatting.WriteToTextWriter(TypeInfo).ToString()!}";
}

internal class ParameterFormatting(
    Func<ParameterFormattingContext, TextWriterFormattableString>? parameterFormat = null,
    TypeFormatting? typeFormatting = null)
{
    private static readonly Func<ParameterFormattingContext, TextWriterFormattableString> DefaultParameterFormat = (parameter => $"{parameter.Type} {parameter.Name}");
    public Func<ParameterFormattingContext, TextWriterFormattableString> ParameterFormat { get; } = parameterFormat ?? DefaultParameterFormat;
    public TypeFormatting TypeFormatFormatting { get; } = typeFormatting ?? TypeFormatting.Default;
    public static ParameterFormatting Default { get; } = new();
}

internal readonly record struct ParameterFormattingContext(
    ParameterInfo ParameterInfo,
    ParameterFormatting ParameterFormatting)
{
    public ParameterInfo ParameterInfo { get; } = ParameterInfo;
    public string Name => ParameterInfo.Name!;

    public TextWriterFormattableString Type =>
        ParameterFormatting.TypeFormatFormatting.TypeFormat(
            new TypeFormattingContext(ParameterInfo.ParameterType, ParameterFormatting.TypeFormatFormatting));
}

internal class MethodFormatting(
    Func<MethodFormattingContext, TextWriterFormattableString>? methodFormat = null,
    ParameterFormatting? parameterFormatting = null,
    string parameterSeparator = ", ")
{
    private static readonly Func<MethodFormattingContext, TextWriterFormattableString> DefaultMethodFormat = (method => $"{method.ReturnType} {method.Name}({method.Parameters})");
    public Func<MethodFormattingContext, TextWriterFormattableString> MethodFormat { get; } = methodFormat ?? DefaultMethodFormat;
    public ParameterFormatting ParameterFormatting { get; } = parameterFormatting ?? ParameterFormatting.Default;
    public string ParameterSeparator { get; } = parameterSeparator;
    public static MethodFormatting Default { get; } = new();
}

internal readonly record struct MethodFormattingContext(
    MethodInfo MethodInfo,
    MethodFormatting MethodFormatting)
{
    public MethodInfo MethodInfo { get; } = MethodInfo;

    public string Name => MethodInfo.Name;

    public TextWriterFormattableString ReturnType =>
        MethodFormatting.ParameterFormatting.TypeFormatFormatting.TypeFormat(
            new TypeFormattingContext(MethodInfo.ReturnType, MethodFormatting.ParameterFormatting.TypeFormatFormatting));

    public TextWriterFormattableString Parameters
    {
        get
        {
            MethodFormattingContext self = this;
            IEnumerable<TextWriterFormattableString> formatterParameters =
                MethodInfo
                    .GetParameters()
                    .Select(p => self.MethodFormatting.ParameterFormatting.ParameterFormat(new ParameterFormattingContext(p, self.MethodFormatting.ParameterFormatting)));
            return TextWriterFormattableString.Join(MethodFormatting.ParameterSeparator, formatterParameters);
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
