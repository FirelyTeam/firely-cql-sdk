// /*
//  * Copyright (c) 2024, NCQA and contributors
//  * See the file CONTRIBUTORS for details.
//  *
//  * This file is licensed under the BSD 3-Clause license
//  * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
//  */

using Hl7.Cql.Abstractions.Infrastructure;

namespace Hl7.Cql.Compiler;

#pragma warning disable CS1591
internal static class Extensions
{
    /// <summary>
    /// Formats a method call by its argument <em>types</em> (not the expressions/IR nodes that
    /// produced them) — e.g. <c>"MethodName&lt;T1&gt;(Type1, Type2)"</c>. Used by
    /// <see cref="CannotBindToCqlOperatorError"/>, which is expression-representation-agnostic.
    /// </summary>
    internal static StringBuilder AppendCSharp(
        this StringBuilder sb,
        string methodName,
        Type[] methodArgumentTypes,
        Type[] genericTypeArguments,
        MethodCSharpFormat? methodCSharpFormatOptions = null)
    {
        methodCSharpFormatOptions ??= Defaults.MethodCSharpFormat;
        var methodCSharpFormatContext = new MethodTypesContext((methodName, methodArgumentTypes, genericTypeArguments), methodCSharpFormatOptions);
        var formattableString = methodCSharpFormatOptions.Format(methodCSharpFormatContext);
        var sbAdapter = new BasicStringBuilderAdapter(sb);
        formattableString.WriteTo(sbAdapter);
        return sb;
    }

    private readonly record struct MethodTypesContext
    (
        (string methodName,
            Type[] methodArgumentTypes,
            Type[] genericTypeArguments) MethodTypes,
        MethodCSharpFormat MethodFormat) : IMethodCSharpFormatContext
    {
        private (string methodName,
            Type[] methodArgumentTypes,
            Type[] genericTypeArguments) MethodTypes
        { get; } = MethodTypes;

        public string Name => MethodTypes.methodName;
        public TextWriterFormattableString ReturnType => default;

        public TextWriterFormattableString GenericArguments
        {
            get
            {
                var typeFormat = MethodFormat.ParameterFormat.TypeFormat;
                return TextWriterFormattableString.Join(
                    MethodTypes
                        .genericTypeArguments
                        .Select(type => typeFormat.GetFormattableString(type)),
                    typeFormat.GenericArgumentTokens);
            }
        }

        public TextWriterFormattableString Parameters
        {
            get
            {
                var typeFormat = MethodFormat.ParameterFormat.TypeFormat;
                return TextWriterFormattableString.Join(
                    MethodTypes
                        .methodArgumentTypes
                        .Select(type => typeFormat.GetFormattableString(type)),
                    MethodFormat.ParameterTokens);
            }
        }
    }
}