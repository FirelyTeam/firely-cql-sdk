using Ncqa.Cql.Runtime.Comparers;
using Ncqa.Fhir.R4.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.FhirR4.Comparers
{
    public class StringElementCqlComparer : CqlComparerBase<StringElement>
    {
        public FhirCqlComparers Comparers { get; }

        public StringElementCqlComparer(FhirCqlComparers comparers)
        {
            Comparers = comparers;
        }

        public override int? Compare(StringElement x, StringElement y, string? precision) =>
            x == null || y == null
            ? null
            : Comparers.Compare(x.value, y.value, precision);

        public override bool? Equals(StringElement x, StringElement y, string? precision) =>
            x == null || y == null
            ? null
            : Comparers.Equals(x.value, y.value, precision);

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
        public override int GetHashCode(object x) => GetHashCode(x as StringElement);
    }
}
