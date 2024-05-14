/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System;
using System.Diagnostics.CodeAnalysis;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Compiler.Infrastructure;

internal static class TypeExtensions
{
    public static bool IsCqlInterval(this Type t, [NotNullWhen(true)] out Type? elementType)
    {
        if (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(CqlInterval<>))
        {
            elementType = t.GetGenericArguments()[0];
            return true;
        }
        elementType = null;
        return false;
    }
}