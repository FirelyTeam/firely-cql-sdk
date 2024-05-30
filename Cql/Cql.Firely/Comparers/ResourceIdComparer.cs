#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/*
 * Copyright (c) 2023, NCQA and contributors
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
    internal class ResourceIdCqlComparer : CqlComparerBase<Resource>
    {

        public ResourceIdCqlComparer(ICqlComparer idComparer)
        {
            IdComparer = idComparer ?? throw new ArgumentNullException(nameof(idComparer));
        }

        public ICqlComparer IdComparer { get; }

        public override int? Compare(Resource? x, Resource? y, string? precision)
        {
            if (x == null || y == null)
                return null;
            var compareId = IdComparer.Compare(x.Id, y.Id, precision);
            return compareId;

        }

        public override bool? Equals(Resource? x, Resource? y, string? precision)
        {
            if (x == null || y == null)
                return null;
            var compareId = IdComparer.Equals(x.Id, y.Id, precision);
            return compareId;
        }

        public override bool Equivalent(Resource? x, Resource? y, string? precision)
        {
            if (x == null)
            {
                if (y == null)
                    return true;
                else return false;
            }
            else if (y == null)
                return false;
            var compareId = IdComparer.Equivalent(x.Id, y.Id, precision);
            return compareId;
        }

        public override int GetHashCode(Resource? x)
        {
            if (x == null || x.Id == null)
                return typeof(Resource).GetHashCode();
            else
                return x.Id.GetHashCode();
        }
    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member