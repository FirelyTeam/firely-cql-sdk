/*
 * Copyright (c) 2023, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Comparers;
using Hl7.Cql.Primitives;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Fhir.Comparers;

internal class PrimitiveTypeAgainstStringComparer(ICqlComparer inner) :
    CqlComparer<object>(
        equalsImplementation: CqlComparerEqualsImplementation.Compare,
        equivalentImplementation: CqlComparerEquivalentImplementation.Compare)
{
    protected override int? CompareValues(
        object x,
        object y,
        string? precision)
    {
        switch (x, y)
        {
            // We always expect x to be a Code<T> but we only need the ObjectValue on the non-generic base type PrimitiveType.
            case (PrimitiveType xCode, string yString):
            {
                if (precision != null)
                    throw new InvalidOperationException(
                        $"Precision '{precision}' is not supported for comparing Code<T> to string.");

                return StringComparer.Ordinal.Compare(xCode.ObjectValue, yString);
            }
            // Handle comparison between PrimitiveType (e.g., Code<T>) and CqlCode
            case (PrimitiveType xCode, CqlCode yCqlCode):
            {
                if (precision != null)
                    throw new InvalidOperationException(
                        $"Precision '{precision}' is not supported for comparing Code<T> to CqlCode.");

                return StringComparer.Ordinal.Compare(xCode.ObjectValue, yCqlCode.code);
            }
            // Handle comparison between CqlCode and PrimitiveType (e.g., Code<T>) - reverse case
            case (CqlCode xCqlCode, PrimitiveType yCode):
            {
                if (precision != null)
                    throw new InvalidOperationException(
                        $"Precision '{precision}' is not supported for comparing CqlCode to Code<T>.");

                return StringComparer.Ordinal.Compare(xCqlCode.code, yCode.ObjectValue);
            }
            default:
                return inner.CompareValues(x, y, precision);
        }
    }
}