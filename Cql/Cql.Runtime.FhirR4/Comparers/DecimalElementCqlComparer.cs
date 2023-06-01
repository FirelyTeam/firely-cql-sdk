using Hl7.Cql.Comparers;
using Hl7.Cql.Poco.Fhir.R4.Model;
using System.Collections.Generic;

namespace Hl7.Cql.Runtime.FhirR4.Comparers
{
    public class DecimalElementCqlComparer : CqlComparerBase<DecimalElement>
    {
        public override int? Compare(DecimalElement x, DecimalElement y, string? precision) =>
            x == null || y == null || x.value == null || y.value == null
            ? null
            : Comparer<decimal>.Default.Compare(x.value.Value, y.value.Value);

        public override bool? Equals(DecimalElement x, DecimalElement y, string? precision) =>
            x == null || y == null || x.value == null || y.value == null
            ? null
            : EqualityComparer<decimal>.Default.Equals(x.value.Value, y.value.Value);

        public override bool Equivalent(DecimalElement x, DecimalElement y, string? precision) =>
            x == null || y == null || x.value == null || y.value == null
            ? false
            : EqualityComparer<decimal>.Default.Equals(x.value.Value, y.value.Value);

        public override int GetHashCode(DecimalElement? x)
        {
            if (x == null || x.value == null)
                return typeof(DecimalElement).GetHashCode();
            return x.value.GetHashCode();
        }
    }
}
