/*
 * Copyright (c) 2023, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Comparers;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Fhir.Comparers;

internal class PrimitiveTypeAgainstStringComparer(ICqlComparer inner) :
    CqlComparer<object>(
        equalsMethod: CqlComparerEqualsMethod.Compare,
        equivalentMethod: CqlComparerEquivalentMethod.Compare)
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
            default:
                return inner.CompareValues(x, y, precision);
        }
    }
}