/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using System;
using System.Collections.Generic;
using System.Linq;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.CodeGeneration.NET;

internal class TypeToCSharpConverter
{
    private readonly TypeCSharpFormat _typeCSharpFormat;
    private readonly bool _useCSharpValueTuples = true;

    public TypeToCSharpConverter()
    {
        _typeCSharpFormat = new TypeCSharpFormat(UseKeywords: true, NoNamespaces: true, TypeNameFormat: FormatTypeNameAsTuple);
    }

    private TextWriterFormattableString FormatTypeNameAsTuple(ITypeNameCSharpFormatContext ctx)
    {
        if (!ShouldUseTupleType(ctx.TypePartInfo))
            return ctx.Name;

        var rest = string.Join(
            ", ",
            GetTupleProperties(ctx.TypePartInfo).Select(p => $"{p.Type.ToCSharpString(_typeCSharpFormat)} {p.Name}"));
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

    public string GetMemberAccessNullabilityOperator(Type? type)
    {
        if (type is null) return "";
        if (type.IsNullableValueType(out _)) return "?";
        if (ShouldUseTupleType(type)) return "?";
        return "";
    }
}