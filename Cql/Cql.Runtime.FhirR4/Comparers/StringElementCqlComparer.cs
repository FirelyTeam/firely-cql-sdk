using Hl7.Cql.Comparers;
using Hl7.Cql.Poco.Fhir.R4.Model;

namespace Hl7.Cql.Runtime.FhirR4.Comparers
{
    public class StringElementCqlComparer : CqlComparerBase<StringElement>
    {
        public CqlComparers Comparers { get; }

        public StringElementCqlComparer(CqlComparers comparers)
        {
            Comparers = comparers;
        }

        public override int? Compare(StringElement x, StringElement y, string? precision) =>
            x == null || y == null
            ? null
            : Comparers.Compare(x.value, y.value, precision);


        public override bool Equivalent(StringElement x, StringElement y, string? precision) =>
            x == null || y == null
            ? false
            : Comparers.Equivalent(x.value, y.value, precision);

        public override int GetHashCode(StringElement? x)
        {
            if (x == null || x.value == null)
                return typeof(StringElement).GetHashCode();
            else return x.value.GetHashCode();
        }
    }
}
