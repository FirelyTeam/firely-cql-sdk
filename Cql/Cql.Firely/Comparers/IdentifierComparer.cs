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
    internal class IdentifierComparer : CqlComparerBase<Identifier>
    {
        public IdentifierComparer(ICqlComparer systemComparer, ICqlComparer valueComparer)
        {
            SystemComparer = systemComparer;
            ValueComparer = valueComparer;
        }

        public ICqlComparer SystemComparer { get; }
        public ICqlComparer ValueComparer { get; }

        public override int? Compare(Identifier? x, Identifier? y, string? precision)
        {
            if (x == null || y == null) return null;
            else
            {
                var systemComp = SystemComparer.Compare(x.System, y.System, precision);
                if (systemComp == 0)
                {
                    var valueComp = ValueComparer.Compare(x.Value, y.Value, precision);
                    return valueComp;
                }
                else return systemComp;
            }
        }

        protected override bool EquivalentImpl(Identifier x, Identifier y, string? precision) =>
            (Compare(x, y, precision) ?? -1) == 0;

        public override int GetHashCode(Identifier? x)
        {
            if (x == null || x.Value == null)
                return typeof(Identifier).GetHashCode();
            else return $"{x.Value}{x.System}".GetHashCode();
        }
    }
}
