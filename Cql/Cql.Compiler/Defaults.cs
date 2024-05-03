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
internal static class Defaults
{
    public const string NextItem = "\n\t* ";

    public static readonly TypeCSharpFormat TypeCSharpFormat = new(UseKeywords:true, NoNamespaces:true);

    public static readonly MethodCSharpFormat MethodCSharpFormat = new (
        //MethodFormat: method => $"\n\t* {method.Name}{method.GenericArguments}{method.Parameters}",
        ParameterFormat: new (
            //ParameterFormat: parameter => $"{parameter.Type}",
            TypeFormat: TypeCSharpFormat));
}