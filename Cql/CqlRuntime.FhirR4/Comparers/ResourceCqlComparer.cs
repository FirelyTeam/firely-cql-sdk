using Ncqa.Cql.Runtime.Comparers;
using Ncqa.Fhir.R4.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.FhirR4.Comparers
{
    public class ResourceCqlComparer : CqlComparerBase<Resource>
    {

        public ResourceCqlComparer(ICqlComparer idComparer)
        {
            IdComparer = idComparer ?? throw new ArgumentNullException(nameof(idComparer));
        }

        public ICqlComparer IdComparer { get; }

        public override int? Compare(Resource x, Resource y, string? precision)
        {
            if (x == null || y == null)
                return null;
            var compareId = IdComparer.Compare(x.id, y.id, precision);
            return compareId;
            
        }

        public override bool? Equals(Resource x, Resource y, string? precision)
        {
            if (x == null || y == null)
                return null;
            var compareId = IdComparer.Equals(x.id, y.id, precision);
            return compareId;
        }

        public override bool Equivalent(Resource x, Resource y, string? precision)
        {
            if (x == null)
            {
                if (y == null)
                    return true;
                else return false;
            }
            else if (y == null)
                return false;
            var compareId = IdComparer.Equivalent(x.id, y.id, precision);
            return compareId;
        }

        public override int GetHashCode(Resource? x)
        {
            if (x == null || x.id == null)
                return typeof(Resource).GetHashCode();
            else
                return x.id.GetHashCode();
        }

        public override int GetHashCode(object x) => GetHashCode(x as Resource);
    }
}
