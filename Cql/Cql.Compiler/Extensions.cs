// /*
//  * Copyright (c) 2024, NCQA and contributors
//  * See the file CONTRIBUTORS for details.
//  *
//  * This file is licensed under the BSD 3-Clause license
//  * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
//  */

using System;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Hl7.Cql.Abstractions.Infrastructure;

namespace Hl7.Cql.Compiler;

#pragma warning disable CS1591
internal static class Extensions
{
    internal static StringBuilder AppendCSharp(
        this StringBuilder sb,
        string methodName,
        Expression[] methodArguments,
        Type[] genericTypeArguments,
        MethodCSharpFormat? methodCSharpFormatOptions = null)
    {
        methodCSharpFormatOptions ??= Defaults.MethodCSharpFormat;
        var methodCSharpFormatContext = new MethodExpressionsContext((methodName, methodArguments, genericTypeArguments), methodCSharpFormatOptions);
        var formattableString = methodCSharpFormatOptions.MethodFormat(methodCSharpFormatContext);
        var sbAdapter = new BasicStringBuilderAdapter(sb);
        formattableString.WriteTo(sbAdapter);
        return sb;
    }

    private readonly record struct MethodExpressionsContext
    (
        (string methodName,
            Expression[] methodArguments,
            Type[] genericTypeArguments) MethodExpressions,
        MethodCSharpFormat MethodFormat) : IMethodCSharpFormatContext
    {
        private (string methodName,
            Expression[] methodArguments,
            Type[] genericTypeArguments) MethodExpressions
        { get; } = MethodExpressions;

        public string Name => MethodExpressions.methodName;
        public TextWriterFormattableString ReturnType => default;

        public TextWriterFormattableString GenericArguments
        {
            get
            {
                var typeFormat = MethodFormat.ParameterFormat.TypeFormat;
                return TextWriterFormattableString.Join(
                    MethodExpressions
                        .genericTypeArguments
                        .Select(type => typeFormat.GetFormattableString(type)),
                    MethodFormat.GenericArgumentSeparator,
                    MethodFormat.GenericArgumentsOpenBracket,
                    MethodFormat.GenericArgumentsCloseBracket,
                    noBracketsWhenEmpty: true);
            }
        }

        public TextWriterFormattableString Parameters
        {
            get
            {
                var typeFormat = MethodFormat.ParameterFormat.TypeFormat;
                return TextWriterFormattableString.Join(
                    MethodExpressions
                        .methodArguments
                        .Select(expression => typeFormat.GetFormattableString(expression.Type)),
                    MethodFormat.ParameterSeparator,
                    MethodFormat.ParametersOpenBracket,
                    MethodFormat.ParametersCloseBracket);
            }
        }
    }
}