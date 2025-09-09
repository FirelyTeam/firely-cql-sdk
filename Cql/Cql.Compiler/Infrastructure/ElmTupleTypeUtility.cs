/*
 * Copyright (c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Primitives;

namespace Hl7.Cql.Compiler.Infrastructure;

internal static class ElmTupleTypeUtility
{


    /// <summary>
    /// Determines whether two types are compatible for Union operations in ELM to LINQ conversion.
    /// This includes exact equality, assignability, and structural equivalence for tuple types.
    /// </summary>
    /// <param name="leftType">The left operand type.</param>
    /// <param name="rightType">The right operand type.</param>
    /// <returns><c>true</c> if the types are compatible for Union operations; otherwise, <c>false</c>.</returns>
    public static bool AreCompatibleForUnionOperation(Type leftType, Type rightType)
    {
        // First check for exact equality
        if (leftType == rightType)
            return true;

        // Check if one type is assignable from the other (for polymorphic cases)
        if (leftType.IsAssignableFrom(rightType) || rightType.IsAssignableFrom(leftType))
            return true;

        // Check for structural equivalence of tuple types
        if (AreElmTupleTypesStructurallyEquivalent(leftType, rightType))
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
    private static bool AreElmTupleTypesStructurallyEquivalent(Type leftType, Type rightType)
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
        // This includes exact matches, assignability, and known CQL/FHIR type conversions.
        static bool AreElmPropertyTypesCompatible(Type leftPropType, Type rightPropType)
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
    }
}
