/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Conversion;
using Hl7.Cql.Primitives;
using TypeConverter = Hl7.Cql.Conversion.TypeConverter;

namespace Hl7.Cql.Compiler.Infrastructure;

internal static class ElmTupleTypeUtility
{
    /// <summary>
    /// Determines whether two types are compatible for Union operations in ELM to LINQ conversion.
    /// This includes exact equality, assignability, and structural equivalence for tuple types.
    /// </summary>
    /// <param name="leftType">The left operand type.</param>
    /// <param name="rightType">The right operand type.</param>
    /// <param name="typeConverter">The type converter to check for known conversions between types.</param>
    /// <returns><c>true</c> if the types are compatible for Union operations; otherwise, <c>false</c>.</returns>
    public static bool AreCompatibleForUnionOperation(Type leftType, Type rightType, TypeConverter typeConverter)
    {
        // First check for exact equality
        if (leftType == rightType)
            return true;

        // Check if one type is assignable from the other (for polymorphic cases)
        if (leftType.IsAssignableFrom(rightType) || rightType.IsAssignableFrom(leftType))
            return true;

        // Check for structural equivalence of tuple types
        if (AreElmTupleTypesStructurallyCompatible(leftType, rightType, typeConverter, directional: false))
            return true;

        return false;
    }

    /// <summary>
    /// Determines whether elements of type <paramref name="fromType"/> can be converted to
    /// <paramref name="toType"/> for a Union operation: exact equality, assignability to the
    /// target, or element-wise structural conversion for tuple types. Unlike
    /// <see cref="AreCompatibleForUnionOperation"/> this check is directional, matching the
    /// conversion that is actually performed on the operand: a symmetric check would accept
    /// operands for which only the reverse conversion exists (see #1354).
    /// </summary>
    /// <param name="fromType">The operand element type to convert from.</param>
    /// <param name="toType">The union element type to convert to.</param>
    /// <param name="typeConverter">The type converter to check for known conversions between types.</param>
    /// <returns><c>true</c> if <paramref name="fromType"/> converts to <paramref name="toType"/>; otherwise, <c>false</c>.</returns>
    public static bool CanConvertForUnionOperation(Type fromType, Type toType, TypeConverter typeConverter)
    {
        if (fromType == toType)
            return true;

        if (toType.IsAssignableFrom(fromType))
            return true;

        return AreElmTupleTypesStructurallyCompatible(fromType, toType, typeConverter, directional: true);
    }

    /// <summary>
    /// Determines whether two types are structurally compatible ELM tuple types.
    /// ELM tuple types are considered structurally compatible if they have the same properties
    /// in the same order with compatible types. When <paramref name="directional"/> is
    /// <c>true</c>, property types must be assignable or convertible from left to right; when
    /// <c>false</c>, a conversion in either direction counts.
    /// </summary>
    /// <param name="leftType">The left (source) tuple type.</param>
    /// <param name="rightType">The right (target) tuple type.</param>
    /// <param name="typeConverter">The type converter to check for known conversions between types.</param>
    /// <param name="directional">Whether property conversions are only considered from left to right.</param>
    /// <returns><c>true</c> if both types are ELM tuple types and are structurally compatible; otherwise, <c>false</c>.</returns>
    private static bool AreElmTupleTypesStructurallyCompatible(Type leftType, Type rightType, TypeConverter typeConverter, bool directional)
    {
        // Check if both types are tuple-like (derive from TupleBaseType or have tuple-like properties)
        if (!leftType.IsTupleBaseType() || !rightType.IsTupleBaseType())
            return false;

        var leftProps = leftType.GetProperties();
        var rightProps = rightType.GetProperties();

        // Check if they have the same number of properties
        if (leftProps.Length != rightProps.Length)
            return false;

        // Check if each property has the same name and compatible type (order matters for tuples)
        for (int i = 0; i < leftProps.Length; i++)
        {
            var leftProp = leftProps[i];
            var rightProp = rightProps[i];

            // Property names must match
            if (leftProp.Name != rightProp.Name)
                return false;

            // For property types, check if they are the same or convertible
            if (!AreElmPropertyTypesCompatible(leftProp.PropertyType, rightProp.PropertyType))
                return false;
        }

        return true;

        // Determines whether two property types are compatible in the context of ELM tuple operations.
        // This includes exact matches, assignability, and type converter conversions.
        bool AreElmPropertyTypesCompatible(Type leftPropType, Type rightPropType)
        {
            // Exact match
            if (leftPropType == rightPropType)
                return true;

            if (directional)
                return rightPropType.IsAssignableFrom(leftPropType)
                       || typeConverter.CanConvert(leftPropType, rightPropType);

            // Check assignability in both directions
            if (leftPropType.IsAssignableFrom(rightPropType) || rightPropType.IsAssignableFrom(leftPropType))
                return true;

            // Check if the type converter knows how to convert between these types
            if (typeConverter.CanConvert(leftPropType, rightPropType) || typeConverter.CanConvert(rightPropType, leftPropType))
                return true;

            return false;
        }
    }
}
