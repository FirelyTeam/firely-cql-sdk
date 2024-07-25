/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using System;
using System.Linq;
using Hl7.Cql.Abstractions.Infrastructure;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.CodeGeneration.NET;

internal class TypeToCSharpConverter
{
    private readonly TypeCSharpFormat _typeCSharpFormat;
    private readonly bool _useCSharpValueTuples;

    public TypeToCSharpConverter(IOptions<CSharpCodeWriterOptions> cSharpCodeWriterTypeFormat)
    {
        _typeCSharpFormat = new TypeCSharpFormat(UseKeywords: true, NoNamespaces: true, TypeNameFormat: FormatTypeNameAsTuple);
        _useCSharpValueTuples = cSharpCodeWriterTypeFormat.Value.UseCSharpValueTuples;
    }

    private TextWriterFormattableString FormatTypeNameAsTuple(ITypeNameCSharpFormatContext ctx)
    {
        if (!ShouldUseTupleType(ctx.TypePartInfo))
            return ctx.Name;

        var props =
            ctx.TypePartInfo
               .GetProperties()
               .Select(p => (TypeName:p.PropertyType.ToCSharpString(_typeCSharpFormat), p.Name))
               .ToArray() switch
            {
                [{} single] => [single, ("nint", "_")],
                var p       => p
            };
        TextWriterFormattableString formatTypeNameAsTuple = $"({string.Join(", ", props.Select(p => $"{p.TypeName} {p.Name}"))})?";
        return formatTypeNameAsTuple;
    }

    public bool ShouldUseTupleType(Type type) =>
        _useCSharpValueTuples && type.Name.StartsWith("Tuple_"); // REVIEW: This is a heuristic, and may not be correct in all cases.

    public string ToCSharp(Type type)
    {
        string result = type.ToCSharpString(_typeCSharpFormat);
        return result;
    }
}