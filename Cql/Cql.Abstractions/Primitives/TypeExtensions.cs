/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Primitives;

/// <summary>
/// Provides extension methods for CQL-related <see cref="Type"/>.
/// </summary>
public static class TypeExtensions
{
    /// <summary>
    /// Determines if the specified type is a CqlInterval and retrieves its element type.
    /// </summary>
    /// <param name="type">The type to check.</param>
    /// <param name="elementType">The element type of the CqlInterval, if it is a CqlInterval.</param>
    /// <returns><c>true</c> if the type is a CqlInterval; otherwise, <c>false</c>.</returns>
    public static bool IsCqlInterval(this Type type, [NotNullWhen(true)] out Type? elementType)
    {
        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(CqlInterval<>))
        {
            elementType = type.GetGenericArguments()[0];
            return true;
        }
        elementType = null;
        return false;
    }

    /// <summary>
    /// Determines whether the specified <see cref="Type"/> represents a CQL value tuple.
    /// </summary>
    ///
    /// <param name="type">The <see cref="Type"/> to evaluate.</param>
    ///
    /// <returns>
    /// <see langword="true"/> if the specified <see cref="Type"/> is a generic value type, implements <see cref="ITuple"/>,
    /// and has a first generic type argument of <see cref="CqlTupleMetadata"/>;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    public static bool IsCqlValueTuple(this Type type)
    {
        bool isCqlValueTuple =
            type is { IsValueType: true, IsGenericType: true }
            && type.IsAssignableTo(typeof(ITuple))
            && type.GenericTypeArguments.ElementAtOrDefault(0) == typeof(CqlTupleMetadata);
        return isCqlValueTuple;
    }

    internal static bool IsTupleBaseType(this Type type)
    {
        var isTupleBaseType = type.IsAssignableTo(typeof(TupleBaseType));
        return isTupleBaseType;
    }
}
