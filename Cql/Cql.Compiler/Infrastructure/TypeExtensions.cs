using System;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Compiler.Infrastructure;
internal static class TypeExtensions
{
    public static bool IsTypeCqlInterval(this Type type) =>
        type.IsGenericType
        && type.GetGenericTypeDefinition() == typeof(CqlInterval<>);

    /// <summary>
    /// Checks if the specified type is nullable.
    /// </summary>
    /// <param name="type">The type to check.</param>
    /// <returns>True if the type is nullable, false otherwise.</returns>
    public static bool IsNullable(this Type type) => type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);

    public static bool IsEnum(this Type type)
    {
        if (type.IsEnum)
            return true;
        if (type.IsNullable() && (Nullable.GetUnderlyingType(type)?.IsEnum ?? false))
            return true;
        return false;
    }
}
