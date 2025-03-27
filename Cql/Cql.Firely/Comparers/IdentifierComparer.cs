/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using Hl7.Cql.Abstractions;
using Hl7.Cql.Comparers;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Fhir.Comparers
{
    internal class IdentifierComparer(
        ICqlComparer<string> systemComparer,
        ICqlComparer<string> valueComparer) : CqlComparer<Identifier>
    {
        protected override bool CompareReturnNullOnAnyNull() =>
            true;

        protected override int? CompareValues(
            Identifier left,
            Identifier right,
            string? precision)
        {
            var systemComp = systemComparer.Compare(left.System, right.System, precision);
            if (systemComp == 0)
            {
                var valueComp = valueComparer.Compare(left.Value, right.Value, precision);
                return valueComp;
            }
            else return systemComp;
        }

        // public override int? Compare(Identifier? x, Identifier? y, string? precision)
        // {
        //     if (x == null || y == null) return null;
        //     else
        //     {
        //         var systemComp = systemComparer.Compare(x.System, y.System, precision);
        //         if (systemComp == 0)
        //         {
        //             var valueComp = valueComparer.Compare(x.Value, y.Value, precision);
        //             return valueComp;
        //         }
        //         else return systemComp;
        //     }
        // }

        protected override bool EquivalentValues(Identifier x, Identifier y, string? precision) =>
            (Compare(x, y, precision) ?? -1) == 0;

        // public override int GetHashCode(Identifier? x) =>
        //     x?.Value == null
        //         ? typeof(Identifier).GetHashCode()
        //         : HashCode.Combine(x.Value, x.System);

        protected override bool IsNull([NotNullWhen(false)] Identifier? value) =>
            value?.Value is null;

        protected override int GetHashCodeValue(Identifier value) =>
            HashCode.Combine(value.Value, value.System);
    }
}