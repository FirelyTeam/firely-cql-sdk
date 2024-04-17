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