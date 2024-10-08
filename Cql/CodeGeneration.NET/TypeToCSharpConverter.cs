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

        return $"dynamic";
    }

    public IEnumerable<(Type Type, string Name)> GetTupleProperties(Type type)
    {
        var length = type.GetProperties().Length;
        for (var i = 0; i < length; i++)
        {
            var prop = type.GetProperties()[i];
            yield return (prop.PropertyType, prop.Name);
        }

        if (length == 1)
            yield return (typeof(nint), "_");
    }

    public bool ShouldUseTupleType(Type type) =>
        _useCSharpValueTuples && type.Name.StartsWith("Tuple_"); // REVIEW: This is a heuristic, and may not be correct in all cases.

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