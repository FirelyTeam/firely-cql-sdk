using Hl7.Fhir.Model;
using Ncqa.Cql.Runtime.Comparers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.Firely.Comparers
{
    public class StringElementCqlComparer : CqlComparerBase<FhirString>
    {
        public FirelyCqlComparers Comparers { get; }

        public StringElementCqlComparer(FirelyCqlComparers comparers)
        {
            Comparers = comparers;
        }

        public override int? Compare(FhirString x, FhirString y, string? precision) =>
            x == null || y == null
            ? null
            : Comparers.Compare(x.Value, y.Value, precision);

        public override bool? Equals(FhirString x, FhirString y, string? precision) =>
            x == null || y == null
            ? null
            : Comparers.Equals(x.Value, y.Value, precision);

        public override bool Equivalent(FhirString x, FhirString y, string? precision) =>
            x == null || y == null
            ? false
            : Comparers.Equivalent(x.Value, y.Value, precision);

        public override int GetHashCode(FhirString? x)
        {
            if (x == null || x.Value == null)
                return typeof(FhirString).GetHashCode();
            else return x.Value.GetHashCode();
        }
        public override int GetHashCode(object x) => GetHashCode(x as FhirString);
    }
}
