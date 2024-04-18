using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Hl7.Cql.Abstractions.Infrastructure;

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
        if (!type.IsValueType)
        {
            // All classes are nullable, return the type itself
            underlyingType = type;
            return true;
        }

        underlyingType = Nullable.GetUnderlyingType(type);
        return underlyingType != null;
    }

    /// <summary>
    /// Checks if the specified type is an enum or a nullable enum.
    /// </summary>
    /// <param name="type">The type to check.</param>
    /// <returns>True if the type is an enum or a nullable enum, false otherwise.</returns>
    public static bool IsEnum(this Type type)
    {
        if (type.IsEnum)
            return true;

        if (IsNullable(type, out var underlyingType) && underlyingType.IsEnum)
            return true;

        return false;
    }

    /// <summary>
    /// Checks if the specified type is implementing the specified generic type definition.
    /// </summary>
    /// <param name="type">The type to check.</param>
    /// <param name="genericTypeDefinition">The generic type definition to check against.</param>
    /// <returns>True if the type is implementing the generic type definition, false otherwise.</returns>
    public static bool IsImplementingGenericTypeDefinition(this Type type, Type genericTypeDefinition)
    {
        if (type.IsGenericType && type.GetGenericTypeDefinition() == genericTypeDefinition)
            return true;

        var hasInterfaceImplementing = type.GetInterfaces()
            .Where(ifc => ifc.IsGenericType)
            .Select(ifc => ifc.GetGenericTypeDefinition())
            .Any(ifc => ifc == genericTypeDefinition);
        return hasInterfaceImplementing;
    }
}
