/*
 * Copyright (c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using Hl7.Cql.Comparers;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Fhir.Comparers
{
    internal class IdentifierComparer(
        ICqlComparer<string> systemComparer,
        ICqlComparer<string> valueComparer) :
        CqlComparer<Identifier>(
            CqlComparerEqualsImplementation.Compare,
            CqlComparerEquivalentImplementation.Compare)
    {
        protected override int? CompareValues(
            Identifier x,
            Identifier y,
            string? precision)
        {
            var systemComp = systemComparer.Compare(x.System, y.System, precision);
            if (systemComp == 0)
            {
                var valueComp = valueComparer.Compare(x.Value, y.Value, precision);
                return valueComp;
            }

            return systemComp;
        }

        protected override bool IsNull([NotNullWhen(false)] Identifier? value) =>
            value?.Value is null;

        protected override int GetHashCodeValue(Identifier value) =>
            HashCode.Combine(value.Value, value.System);
    }
}