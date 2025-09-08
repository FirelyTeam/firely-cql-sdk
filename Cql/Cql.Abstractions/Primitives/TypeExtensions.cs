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

    /// <summary>
    /// Determines whether two types are compatible for Union operations in ELM to LINQ conversion.
    /// This includes exact equality, assignability, and structural equivalence for tuple types.
    /// </summary>
    /// <param name="leftType">The left operand type.</param>
    /// <param name="rightType">The right operand type.</param>
    /// <returns><c>true</c> if the types are compatible for Union operations; otherwise, <c>false</c>.</returns>
    public static bool AreCompatibleForUnionOperation(this Type leftType, Type rightType)
    {
        // First check for exact equality
        if (leftType == rightType)
            return true;

        // Check if one type is assignable from the other (for polymorphic cases)
        if (leftType.IsAssignableFrom(rightType) || rightType.IsAssignableFrom(leftType))
            return true;

        // Check for structural equivalence of tuple types
        if (leftType.AreElmTupleTypesStructurallyEquivalent(rightType))
            return true;

        return false;
    }

    /// <summary>
    /// Determines whether two types are structurally equivalent ELM tuple types.
    /// ELM tuple types are considered structurally equivalent if they have the same properties
    /// in the same order with compatible types.
    /// </summary>
    /// <param name="leftType">The left tuple type.</param>
    /// <param name="rightType">The right tuple type.</param>
    /// <returns><c>true</c> if both types are ELM tuple types and are structurally equivalent; otherwise, <c>false</c>.</returns>
    public static bool AreElmTupleTypesStructurallyEquivalent(this Type leftType, Type rightType)
    {
        // Check if both types are tuple-like (derive from TupleBaseType or have tuple-like properties)
        if (!leftType.IsElmTupleType() || !rightType.IsElmTupleType())
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
            if (!leftProp.PropertyType.AreElmPropertyTypesCompatible(rightProp.PropertyType))
                return false;
        }

        return true;
    }

    /// <summary>
    /// Determines whether two property types are compatible in the context of ELM tuple operations.
    /// This includes exact matches, assignability, and known CQL/FHIR type conversions.
    /// </summary>
    /// <param name="leftPropType">The left property type.</param>
    /// <param name="rightPropType">The right property type.</param>
    /// <returns><c>true</c> if the property types are compatible; otherwise, <c>false</c>.</returns>
    public static bool AreElmPropertyTypesCompatible(this Type leftPropType, Type rightPropType)
    {
        // Exact match
        if (leftPropType == rightPropType)
            return true;

        // Check assignability in both directions
        if (leftPropType.IsAssignableFrom(rightPropType) || rightPropType.IsAssignableFrom(leftPropType))
            return true;

        // Special cases for known compatible CQL types
        // CqlDateTime and FhirDateTime are convertible
        if ((leftPropType == typeof(CqlDateTime) && rightPropType.Name == "FhirDateTime") ||
            (rightPropType == typeof(CqlDateTime) && leftPropType.Name == "FhirDateTime"))
            return true;

        // Add other known convertible pairs as needed
        
        return false;
    }

    /// <summary>
    /// Determines whether a type represents an ELM-generated tuple type.
    /// ELM tuple types are dynamically generated classes typically in the "Tuples" namespace
    /// or derive from TupleBaseType.
    /// </summary>
    /// <param name="type">The type to check.</param>
    /// <returns><c>true</c> if the type is an ELM tuple type; otherwise, <c>false</c>.</returns>
    public static bool IsElmTupleType(this Type type)
    {
        // Check if it's a dynamically generated tuple type by looking for the tuple namespace or base type
        return type.Namespace == "Tuples" || 
               type.BaseType == typeof(TupleBaseType) ||
               (type.IsClass && type.GetProperties().Length > 0 && type.Name.StartsWith("Tuple_"));
    }

    internal static bool IsTupleBaseType(this Type type)
    {
        var isTupleBaseType = type.IsAssignableTo(typeof(TupleBaseType));
        return isTupleBaseType;
    }
}
