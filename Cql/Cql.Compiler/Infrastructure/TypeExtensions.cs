using System;
using System.Diagnostics.CodeAnalysis;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Compiler.Infrastructure;
internal static class TypeExtensions
{
    /// <summary>
    /// Checks if the specified type is nullable and returns it via <paramref name="underlyingType"/>
    /// </summary>
    /// <param name="type">The type to check.</param>
    /// <param name="underlyingType">The underlying type for nullable.</param>
    /// <returns>True if the type is nullable, false otherwise.</returns>
    public static bool IsNullable(this Type type, [NotNullWhen(true)] out Type? underlyingType)
    {
        underlyingType = Nullable.GetUnderlyingType(type);
        return underlyingType != null;
    }

    public static bool IsEnum(this Type type)
    {
        if (type.IsEnum)
            return true;

        if (IsNullable(type, out var underlyingType) && underlyingType.IsEnum)
            return true;

        return false;
    }

    public static bool IsCqlInterval(this Type t, [NotNullWhen(true)]out Type? elementType)
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
