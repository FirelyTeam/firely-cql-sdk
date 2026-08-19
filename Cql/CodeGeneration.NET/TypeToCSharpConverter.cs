/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.CodeGeneration.NET;

internal class TypeToCSharpConverter
{
    private readonly TypeCSharpFormat _typeCSharpFormat;
    private readonly TypeCSharpFormat _declarationCSharpFormat;
    private readonly TypeCSharpFormat _asTargetCSharpFormat;
    private readonly bool _useCSharpValueTuples = true;

    /// <summary>
    /// When <see langword="false"/>, declarations render null-oblivious and the emitter suppresses
    /// every nullable-specific construct (the <c>#nullable</c> directive, annotations and
    /// null-forgiving operators).
    /// </summary>
    public bool NullabilityEnabled { get; }

    public TypeToCSharpConverter(CSharpConfig? cSharpGeneratingConfig = null)
    {
        NullabilityEnabled = (cSharpGeneratingConfig ?? CSharpConfig.Default).NullabilityEnabled;
        _typeCSharpFormat = new TypeCSharpFormat(UseKeywords: true, NoNamespaces: true, FormatName: FormatTypeNameAsTuple);
        _declarationCSharpFormat = _typeCSharpFormat with
        {
            NullableReferenceTypes = true,
            // CQL tuples render as nullable C# value tuples, so FormatTypeNameAsTuple already
            // appends the '?' itself.
            RendersItsOwnNullOperator = ShouldUseTupleType,
            FormatName = FormatTypeNameAsDeclarationTuple,
        };
        _asTargetCSharpFormat = _declarationCSharpFormat with
        {
            NoTopLevelNullableReferenceOperator = true,
        };
    }

    private TextWriterFormattableString FormatTypeNameAsTuple(ITypeNameCSharpFormatContext ctx)
        => FormatTypeNameAsTuple(_typeCSharpFormat, ctx);

    private TextWriterFormattableString FormatTypeNameAsDeclarationTuple(ITypeNameCSharpFormatContext ctx)
        => FormatTypeNameAsTuple(_declarationCSharpFormat, ctx);

    private TextWriterFormattableString FormatTypeNameAsTuple(
        TypeCSharpFormat typeFormat,
        ITypeNameCSharpFormatContext ctx)
    {
        if (!ShouldUseTupleType(ctx.TypeInfo))
            return ctx.Name;

        var rest = string.Join(
            ", ",
            GetTupleProperties(ctx.TypeInfo).Select(p => $"{p.Type.ToCSharpString(typeFormat)} {p.Name}"));
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
    public string ToCSharpDeclaration(Type type) =>
        NullabilityEnabled ? type.ToCSharpString(_declarationCSharpFormat) : ToCSharp(type);

    /// <summary>
    /// Formats a type for an <c>as</c>-cast target: declaration-style generic/array element
    /// nullability, but without a top-level nullable-reference <c>?</c> (illegal in <c>as</c>
    /// targets, CS8651).
    /// </summary>
    public string ToCSharpAsTarget(Type type) =>
        NullabilityEnabled ? type.ToCSharpString(_asTargetCSharpFormat) : ToCSharp(type);

    public string GetMemberAccessNullabilityOperator(Type? type)
    {
        if (type is null) return "";
        if (type.IsNullableValueType(out _)) return "?";
        if (ShouldUseTupleType(type)) return "?";
        return "";
    }
}