/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.CodeGeneration.NET;

internal class TypeToCSharpConverter
{
    private readonly TypeCSharpFormat _typeCSharpFormat;
    private readonly bool _useCSharpValueTuples = true;

    public TypeToCSharpConverter()
    {
        _typeCSharpFormat = new TypeCSharpFormat(UseKeywords: true, NoNamespaces: true, FormatName: FormatTypeNameAsTuple);
    }

    private TextWriterFormattableString FormatTypeNameAsTuple(ITypeNameCSharpFormatContext ctx)
    {
        if (!ShouldUseTupleType(ctx.TypeInfo))
            return ctx.Name;

        var rest = string.Join(
            ", ",
            GetTupleProperties(ctx.TypeInfo).Select(p => $"{p.Type.ToCSharpString(_typeCSharpFormat)} {p.Name}"));
        TextWriterFormattableString formatTypeNameAsTuple = $"(CqlTupleMetadata, {rest})?"; // Notice we have to treat it as a nullable type to be consistent with the original tuple types.
        return formatTypeNameAsTuple;
    }

    public IEnumerable<(Type Type, string Name)> GetTupleProperties(Type type)
    {
        var properties = type.GetProperties();
        return properties.Select(p => (p.PropertyType, p.Name));
    }

    public bool ShouldUseTupleType(Type type) =>
        _useCSharpValueTuples && type.IsTupleBaseType();

    public string ToCSharp(Type type)
    {
        string result = type.ToCSharpString(_typeCSharpFormat);
        return result;
    }

    /// <summary>
    /// Formats a type for declarations (locals, parameters, and return types).
    /// The code model carries <see cref="Type"/>, which does not encode reference-type
    /// nullability, so generated declarations apply a blanket nullable annotation to
    /// reference types only.
    /// </summary>
    public string ToCSharpDeclaration(Type type)
    {
        if (ShouldUseTupleType(type))
            return ToCSharp(type);

        if (type.IsNullableValueType(out var underlying))
            return $"{ToCSharpDeclaration(underlying)}?";

        if (type.IsArray)
        {
            var elementType = type.GetElementType() ?? throw new InvalidOperationException($"Array type '{type}' has no element type.");
            return $"{ToCSharpDeclaration(elementType)}[]?";
        }

        if (type.IsGenericType)
        {
            var genericTypeName = ToCSharp(type);
            var tick = genericTypeName.IndexOf('<');
            if (tick >= 0)
                genericTypeName = genericTypeName[..tick];
            genericTypeName = genericTypeName.TrimEnd('?');

            var genericArguments = string.Join(", ", type.GetGenericArguments().Select(ToCSharpDeclaration));
            var result = $"{genericTypeName}<{genericArguments}>";
            return type.IsValueType ? result : $"{result}?";
        }

        if (type.IsValueType)
            return ToCSharp(type);

        return $"{ToCSharp(type).TrimEnd('?')}?";
    }

    public string GetMemberAccessNullabilityOperator(Type? type)
    {
        if (type is null) return "";
        if (type.IsNullableValueType(out _)) return "?";
        if (ShouldUseTupleType(type)) return "?";
        return "";
    }
}