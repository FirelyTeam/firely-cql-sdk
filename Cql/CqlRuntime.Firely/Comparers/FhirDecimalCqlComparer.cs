using Hl7.Fhir.Model;
using Ncqa.Cql.Runtime.Comparers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.Firely.Comparers
{
    public class FhirDecimalCqlComparer : CqlComparerBase<FhirDecimal>
    {
        public override int? Compare(FhirDecimal x, FhirDecimal y, string? precision) =>
            x == null || y == null || x.Value == null || y.Value == null
            ? null
            : Comparer<decimal>.Default.Compare(x.Value.Value, y.Value.Value);

        public override bool? Equals(FhirDecimal x, FhirDecimal y, string? precision) =>
            x == null || y == null || x.Value == null || y.Value == null
            ? null
            : EqualityComparer<decimal>.Default.Equals(x.Value.Value, y.Value.Value);

        public override bool Equivalent(FhirDecimal x, FhirDecimal y, string? precision) =>
            x == null || y == null || x.Value == null || y.Value == null
            ? false
            : EqualityComparer<decimal>.Default.Equals(x.Value.Value, y.Value.Value);

        public override int GetHashCode(FhirDecimal? x)
        {
            if (x == null || x.Value == null)
                return typeof(FhirDecimal).GetHashCode();
            return x.Value.GetHashCode();
        }

        public override int GetHashCode(object x) => GetHashCode(x as FhirDecimal);
    }
}
