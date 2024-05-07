/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;

namespace Hl7.Cql.Compiler;

#pragma warning disable CS1591
internal static class Defaults
{
    public const string NextItem = "\n\t* ";

    public static readonly TypeCSharpFormat TypeCSharpFormat =
        new(
            UseKeywords:true,
            NoNamespaces:true,
            TypeFormat:t => $"{t.Type}{GetClassKind(t)}");

    private static string GetClassKind(ITypeCSharpFormatContext t) =>
        t.TypeInfo switch
        {
            { IsEnum: true } => ":enum",
            { IsInterface: true } => ":interface",
            { } type when type.IsNullable(out var nnType)
                          | // Don't change to &&
                          nnType.GetCSharpKeyword() is { } => "", // simple type
            { IsValueType: true } => ":struct",
            _                     => ":class",
        };

    public static readonly MethodCSharpFormat MethodCSharpFormat =
        new (
            ParameterFormat: new (
                TypeFormat: TypeCSharpFormat));
}