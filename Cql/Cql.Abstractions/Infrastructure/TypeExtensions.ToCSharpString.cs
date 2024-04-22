using System;
using System.IO;
using System.Reflection;

namespace Hl7.Cql.Abstractions.Infrastructure;

partial class TypeExtensions
{
    public static string ToCSharpString(
        this Type type,
        TypeToCSharpStringOptions? opt = null) =>
        ToCSharpString(type, new StringWriter(), opt ?? TypeToCSharpStringOptions.Default).ToString()!;

    public static TextWriter ToCSharpString(
        Type type,
        TextWriter textWriter,
        TypeToCSharpStringOptions opt)
    {
        if (opt.PreferKeywords && GetCSharpKeyword(type) is { } keyword)
        {
            textWriter.Write(keyword);
            return textWriter;
        }

        switch (type)
        {
            case { IsGenericTypeParameter: true }:
                // Do not remove this, otherwise we go inside the IsNested case.
                if (opt.ShowGenericTypeParameterNames)
                {
                    WriteName();
                }
                return textWriter;

            case { IsSZArray: true }:
                ToCSharpString(type.GetElementType()!, textWriter, opt);
                textWriter.Write("[]");
                return textWriter;

            case { IsVariableBoundArray: true }:
                ToCSharpString(type.GetElementType()!, textWriter, opt);
                textWriter.Write('[');
                for (int i = 1; i < type.GetArrayRank(); i++)
                    textWriter.Write(',');
                textWriter.Write(']');
                return textWriter;

            case { IsNested: true }:
                ToCSharpString(type.DeclaringType!, textWriter, opt);
                textWriter.Write('+');
                opt = opt with { HideNamespaces = true };
                WriteName();
                return textWriter;

            case { IsValueType: true } when IsNullableValueType(type, out var underlyingType):
                ToCSharpString(underlyingType, textWriter, opt);
                textWriter.Write("?");
                return textWriter;

            case { IsGenericType: true } or { IsGenericTypeDefinition: true }:
                WriteName();
                textWriter.Write('<');
                bool first = true;
                foreach (var arg in type.GetGenericArguments())
                {
                    if (first) first = false;
                    else textWriter.Write(opt.TypeArgDelimited);
                    ToCSharpString(arg, textWriter, opt);
                }
                textWriter.Write('>');
                return textWriter;

            case { IsPointer: true }:
                ToCSharpString(type.GetElementType()!, textWriter, opt);
                textWriter.Write("*");
                return textWriter;

            default:
                WriteName();
                return textWriter;
        }

        void WriteName()
        {
            string name = opt.HideNamespaces ? type.Name : (type.FullName ?? type.Name);
            if (name.IndexOf('`') is var i and >= 0)
                textWriter.Write(name[..i]);
            else
                textWriter.Write(name[..]);
        }
    }

    public static string? GetCSharpKeyword(Type t)
    {
        if (t.Namespace != "System")
            return null;

        string? result = t.Name switch
        {
            "Void" when t == typeof(void)       => "void",
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
}

internal record TypeToCSharpStringOptions(
    bool HideNamespaces = false,
    bool PreferKeywords = false,
    bool ShowGenericTypeParameterNames = false, // e.g. TKey
    string TypeArgDelimited = ",")
{
    public static readonly TypeToCSharpStringOptions Default = new();
}

internal static partial class ParameterExtensions
{
    public static string ToCSharpString(
        this ParameterInfo parameterInfo,
        ParameterToCSharpStringOptions? opt = null) =>
        ToCSharpString(parameterInfo, new StringWriter(), opt ?? ParameterToCSharpStringOptions.Default).ToString()!;

    public static TextWriter ToCSharpString(
        ParameterInfo parameterInfo,
        TextWriter textWriter,
        ParameterToCSharpStringOptions opt)
    {
        // TypeExtensions.ToCSharpString(parameterInfo.ParameterType, textWriter, opt.TypeOptions);
        //
        // if (!opt.HideParameterName)
        // {
        //     textWriter.Write(' ');
        //     textWriter.Write(parameterInfo.Name);
        // }
        //
        return textWriter.Write();
    }
}

internal record ParameterToCSharpStringOptions(
    string Format = "{type} {name}",
    TypeToCSharpStringOptions? TypeOptions = null)
{
    public static readonly ParameterToCSharpStringOptions Default = new();

    public TypeToCSharpStringOptions TypeOptions { get; init; } = TypeOptions ?? TypeToCSharpStringOptions.Default;
    internal string FormatArg { get; } = Format.Replace("{type", "{0").Replace("{name", "{1");
}

internal static partial class MethodExtensions
{
    public static string ToCSharpString(
        this MethodInfo methodInfo,
        MethodToCSharpStringOptions? opt = null) =>
        ToCSharpString(methodInfo, new StringWriter(), opt ?? MethodToCSharpStringOptions.Default).ToString()!;

    public static TextWriter ToCSharpString(
        MethodInfo methodInfo,
        TextWriter textWriter,
        MethodToCSharpStringOptions opt)
    {
        bool addSpace = false;
        if (!opt.HideReturnType)
        {
            TypeExtensions.ToCSharpString(methodInfo.ReturnType, textWriter, opt.ParameterOptions.TypeOptions);
            addSpace = true;
        }

        if (!opt.HideMethodName)
        {
            if (addSpace) textWriter.Write(' ');
            textWriter.Write(methodInfo.Name);
        }

        return textWriter;
    }
}

internal record MethodToCSharpStringOptions(
    bool HideReturnType = false,
    bool HideMethodName = false,
    ParameterToCSharpStringOptions? ParameterOptions = null)
{
    public static readonly MethodToCSharpStringOptions Default = new();

    public ParameterToCSharpStringOptions ParameterOptions { get; init; } = ParameterOptions ?? ParameterToCSharpStringOptions.Default;
}