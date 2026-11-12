/*
 * Copyright (c) 2023, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Comparers;
using Hl7.Cql.Primitives;

// We always expect x to be a Code<T> but we can access ObjectValue from the base type PrimitiveType.
using CodeOfT = Hl7.Fhir.Model.PrimitiveType;

namespace Hl7.Cql.Fhir.Comparers;

internal class CodeOfTComparer(ICqlComparer inner) :
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
            case (CodeOfT xCode, string yString):
            {

                Debug.Assert(xCode.GetType().Name == "Code`1");

                if (precision != null)
                    throw new InvalidOperationException(
                        $"Precision '{precision}' is not supported for comparing Code<T> to string.");

                return StringComparer.Ordinal.Compare(xCode.JsonValue, yString);
            }

            case (CodeOfT xCode, CqlCode yCqlCode):
            {
                // We always expect x to be a Code<T> but we can access ObjectValue from the base type PrimitiveType.
                // Note the reverse is handled in CqlCodeComparer.
                Debug.Assert(xCode.GetType().Name == "Code`1");

                if (precision != null)
                    throw new InvalidOperationException(
                        $"Precision '{precision}' is not supported for comparing Code<T> to CqlCode.");

                return StringComparer.Ordinal.Compare(xCode.JsonValue, yCqlCode.code);
            }

            default:
                return inner.CompareValues(x, y, precision);
        }
    }

    /// <summary>
    /// A <c>Code&lt;T&gt;</c> compares with a string and with a <see cref="CqlCode"/> by its code, and
    /// with any other value as far as the comparer it falls back on compares the two: with a
    /// <c>Code&lt;T&gt;</c> of the same <c>T</c>.
    /// </summary>
    protected override bool CanCompare(
        object x,
        object y) =>
        (x, y) switch
        {
            (CodeOfT, string) or (CodeOfT, CqlCode) => true,
            _                                       => inner is not ITypedCqlComparer typedInner || typedInner.CanCompare(x, y),
        };
}