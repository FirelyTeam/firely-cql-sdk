/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System.IO;
using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

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

    public static string WriteCSharp(
        this Type type,
        TypeCSharpFormat? typeFormatterOptions = null) =>
        (typeFormatterOptions ?? TypeCSharpFormat.Default).WriteToString(type);

    public static string WriteCSharp(
        this ParameterInfo parameterInfo,
        ParameterCSharpFormat? parameterFormatterOptions = null) =>
        (parameterFormatterOptions ?? ParameterCSharpFormat.Default).WriteToString(parameterInfo);

    public static string WriteCSharp(
        this MethodInfo methodInfo,
        MethodCSharpFormat? methodFormatterOptions = null) =>
        (methodFormatterOptions ?? MethodCSharpFormat.Default).WriteToString(methodInfo);
}

internal abstract record CSharpFormat<T>
{
    public abstract TextWriterFormattableString GetFormattableString(T target);

    public void WriteTo(T target, TextWriter textWriter) =>
        GetFormattableString(target).WriteTo(new TextWriterAdapter(textWriter));

    public void WriteTo(T target, StringBuilder stringBuilder) =>
        GetFormattableString(target).WriteTo(new StringBuilderAdapter(stringBuilder));

    public string WriteToString(T target)
    {
        var sb = new StringBuilder();
        WriteTo(target, sb);
        return sb.ToString();
    }
}

internal delegate TextWriterFormattableString FormattableStringProvider<in TContext>(TContext context);

internal record TypeCSharpFormat(
    FormattableStringProvider<TypeCSharpFormatContext>? TypeFormat = null,
    bool NoNamespaces = false,
    bool UseKeywords = false,
    bool NoNullableOperator = false, // e.g. Nullable<int> instead of int?
    bool NoGenericTypeParameterNames = false, // e.g.IDictionary<,> instead of  IDictionary<TKey,TValue>
    string TypeSeparator = ",", // [int,string] or <TKey,TValue>
    string NestedTypeSeparator = ".") // A.Nested.Nested
    : CSharpFormat<Type>
{
    public static readonly FormattableStringProvider<TypeCSharpFormatContext> DefaultTypeFormat = type => $"{type.Type}";
    public static readonly TypeCSharpFormat Default = new();

    private const char OpenArrayBracket = '[';
    private const char CloseArrayBracket = ']';
    private const char NullOperator = '?';
    private const char OpenGenericTypeBracket = '<';
    private const char CloseGenericTypeBracket = '>';
    private const char PointerOperator = '*';

    public FormattableStringProvider<TypeCSharpFormatContext> TypeFormat { get; } = TypeFormat ?? DefaultTypeFormat;

    public override TextWriterFormattableString GetFormattableString(Type type) =>
        TypeFormat(new TypeCSharpFormatContext(type, this));

    protected internal void WriteTo(
        Type type,
        IBasicTextWriter textWriter)
    {
        if (UseKeywords && type.GetCSharpKeyword() is { } keyword)
        {
            textWriter.Write(keyword);
            return;
        }

        var hideNamespaces = NoNamespaces;
        var isNullableValueType = false;

        // Nested parts first.
        if (type is {
                IsNested: true,
                IsGenericParameter: false, // Generic Parameters are nested, but not really.
                //IsGenericTypeParameter: false,
                DeclaringType: {} declaringType
        })
        {
            WriteTo(declaringType, textWriter);
            textWriter.Write(NestedTypeSeparator);
            hideNamespaces = true; // Nested types are always in the same namespace.
        }

        // Name
        if (type.IsGenericTypeParameter)
        {
            if (!NoGenericTypeParameterNames)
            {
                switch (type.GenericParameterAttributes & GenericParameterAttributes.VarianceMask)
                {
                    case GenericParameterAttributes.None:
                        break;
                    case GenericParameterAttributes.Covariant:
                        textWriter.Write("out ");
                        break;
                    case GenericParameterAttributes.Contravariant:
                        textWriter.Write("in ");
                        break;
                    default:
                        Debug.Fail("Unexpected variance flag");
                        break;
                }

                var rest = type.GenericParameterAttributes & ~GenericParameterAttributes.VarianceMask;
                Debug.Assert(rest == GenericParameterAttributes.None, "Not implemented");
                WriteName();
            }
        }
        else if (type.IsArray)
        {
            WriteTo(type.GetElementType()!, textWriter);
        }
        else if (!NoNullableOperator && type.IsValueType && type.IsNullableValueType(out var underlyingType))
        {
            isNullableValueType = true;
            WriteTo(underlyingType, textWriter);
        }
        else if (type.IsPointer)
        {
            WriteTo(type.GetElementType()!, textWriter);
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
                textWriter.Write(TypeSeparator);
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
            foreach (var typeArg in type.GetGenericArguments())
            {
                if (first) first = false;
                else textWriter.Write(TypeSeparator);
                WriteTo(typeArg, textWriter);
            }
            textWriter.Write(CloseGenericTypeBracket);
        }

        // Pointer
        if (type.IsPointer)
            textWriter.Write(PointerOperator);

        return;

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

internal readonly record struct TypeCSharpFormatContext(
    Type TypeInfo,
    TypeCSharpFormat TypeCSharpFormat)
{
    public Type TypeInfo { get; } = TypeInfo;

    public TextWriterFormattableString Type
    {
        get
        {
            var self = this;
            return $"{textWriter => self.TypeCSharpFormat.WriteTo(self.TypeInfo, textWriter)}";
        }
    }
}


internal record ParameterCSharpFormat(
    FormattableStringProvider<ParameterCSharpFormatContext>? ParameterFormat = null,
    TypeCSharpFormat? TypeFormat = null)
    : CSharpFormat<ParameterInfo>
{
    private static readonly FormattableStringProvider<ParameterCSharpFormatContext> DefaultParameterFormat = (parameter => $"{parameter.Type} {parameter.Name}");
    public static ParameterCSharpFormat Default { get; } = new();
    public FormattableStringProvider<ParameterCSharpFormatContext> ParameterFormat { get; } = ParameterFormat ?? DefaultParameterFormat;
    public TypeCSharpFormat TypeFormat { get; } = TypeFormat ?? TypeCSharpFormat.Default;

    public override TextWriterFormattableString GetFormattableString(ParameterInfo parameterInfo) =>
        ParameterFormat(new ParameterCSharpFormatContext(parameterInfo, this));
}

internal readonly record struct ParameterCSharpFormatContext(
    ParameterInfo ParameterInfo,
    ParameterCSharpFormat ParameterFormat)
{
    public ParameterInfo ParameterInfo { get; } = ParameterInfo;
    public string Name => ParameterInfo.Name!;
    public TextWriterFormattableString Type =>
        ParameterFormat
            .TypeFormat
            .GetFormattableString(ParameterInfo.ParameterType);
}

internal record MethodCSharpFormat(
    FormattableStringProvider<MethodCSharpFormatContext>? MethodFormat = null,
    ParameterCSharpFormat? ParameterFormat = null,
    string ParameterSeparator = ", ",
    string ParametersOpenBracket = "(",
    string ParametersCloseBracket = ")",
    string GenericArgumentSeparator = ", ",
    string GenericArgumentsOpenBracket = "<",
    string GenericArgumentsCloseBracket = ">")
    : CSharpFormat<MethodInfo>
{
    private static readonly FormattableStringProvider<MethodCSharpFormatContext> DefaultMethodFormat = (method => $"{method.ReturnType} {method.Name}{method.GenericArguments}{method.Parameters}");
    public static MethodCSharpFormat Default { get; } = new();
    public FormattableStringProvider<MethodCSharpFormatContext> MethodFormat { get; } = MethodFormat ?? DefaultMethodFormat;
    public ParameterCSharpFormat ParameterFormat { get; } = ParameterFormat ?? ParameterCSharpFormat.Default;

    public override TextWriterFormattableString GetFormattableString(MethodInfo methodInfo) =>
        MethodFormat(new MethodCSharpFormatContext(methodInfo, this));
}

internal readonly record struct MethodCSharpFormatContext(
    MethodInfo MethodInfo,
    MethodCSharpFormat MethodFormat)
{
    public MethodInfo MethodInfo { get; } = MethodInfo;

    public string Name => MethodInfo.Name;

    public TextWriterFormattableString ReturnType =>
        MethodFormat
            .ParameterFormat
            .TypeFormat
            .GetFormattableString(MethodInfo.ReturnType);

    public TextWriterFormattableString GenericArguments
    {
        get
        {
            var genericArguments = MethodInfo.IsGenericMethod
                                       ?MethodInfo.GetGenericArguments()
                                       :[];

            if (genericArguments.Length == 0)
                return $"";

            var typeFormatterOptions = MethodFormat.ParameterFormat.TypeFormat;

            IEnumerable<TextWriterFormattableString> formatterGenericArguments =
                genericArguments.Select(type => typeFormatterOptions.GetFormattableString(type));

            return TextWriterFormattableString.Join(
                MethodFormat.GenericArgumentSeparator,
                formatterGenericArguments,
                MethodFormat.GenericArgumentsOpenBracket, MethodFormat.GenericArgumentsCloseBracket);
        }
    }

    public TextWriterFormattableString Parameters
    {
        get
        {
            var parameterFormatterOptions = MethodFormat.ParameterFormat;
            IEnumerable<TextWriterFormattableString> formatterParameters =
                MethodInfo
                    .GetParameters()
                    .Select(p => parameterFormatterOptions.GetFormattableString(p));
            return TextWriterFormattableString.Join(
                MethodFormat.ParameterSeparator,
                formatterParameters,
                MethodFormat.ParametersOpenBracket, MethodFormat.ParametersCloseBracket);
        }
    }
}

[InterpolatedStringHandler]
internal struct TextWriterFormattableString
{
    private Action<IBasicTextWriter> _write = null!;

    public TextWriterFormattableString(int literalLength = 0, int formattedCount = 0)
    {
    }

    public void AppendFormatted(Action<IBasicTextWriter> s) =>
        _write += s;

    public void AppendLiteral(string s) =>
        AppendFormatted(w => w.Write(s));

    public void AppendFormatted(string s) =>
        AppendFormatted(w => w.Write(s));

    public void AppendFormatted(TextWriterFormattableString s) =>
        AppendFormatted(w => s.WriteTo(w));

    public static TextWriterFormattableString Join(
        string separator,
        IEnumerable<TextWriterFormattableString> formatStrings,
        string openBracket = "",
        string closeBracket = "",
        bool noBracketsWhenEmpty = false)
    {
        TextWriterFormattableString s = new();
        bool first = true;
        foreach (var formatString in formatStrings)
        {
            if (first)
            {
                if (openBracket.Length>0)
                    s.AppendFormatted(w => w.Write(openBracket));
                first = false;
            }
            else if (separator != "")
                s.AppendFormatted(w => w.Write(separator));

            s.AppendFormatted(formatString.WriteTo);
        }

        if (!noBracketsWhenEmpty && !first && closeBracket.Length > 0)
            s.AppendFormatted(w => w.Write(closeBracket));
        return s;
    }

    public void WriteTo(IBasicTextWriter textWriter) =>
        _write?.Invoke(textWriter);
}

internal interface IBasicTextWriter
{
    void Write(string s);
    void Write(char s);
}

file readonly record struct TextWriterAdapter(TextWriter Inner) : IBasicTextWriter
{
    public void Write(string s) => Inner.Write(s);
    public void Write(char s) => Inner.Write(s);
}

file readonly record struct StringBuilderAdapter(StringBuilder Inner) : IBasicTextWriter
{
    public void Write(string s) => Inner.Append(s);
    public void Write(char s) => Inner.Append(s);
}