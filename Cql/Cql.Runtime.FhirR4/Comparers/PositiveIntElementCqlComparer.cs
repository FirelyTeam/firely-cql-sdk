using Ncqa.Cql.Comparers;
using Ncqa.Fhir.R4.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.FhirR4.Comparers
{
    public class PositiveIntElementCqlComparer : CqlComparerBase<PositiveIntElement>
    {
        public override int? Compare(PositiveIntElement x, PositiveIntElement y, string? precision) =>
            x == null || y == null || x.value == null || y.value == null
            ? null
            : Comparer<int>.Default.Compare(x.value.Value, y.value.Value);

        public override bool? Equals(PositiveIntElement x, PositiveIntElement y, string? precision) =>
            x == null || y == null || x.value == null || y.value == null
            ? null
            : EqualityComparer<int>.Default.Equals(x.value.Value, y.value.Value);

        public override bool Equivalent(PositiveIntElement x, PositiveIntElement y, string? precision) =>
            x == null || y == null || x.value == null || y.value == null
            ? false
            : EqualityComparer<int>.Default.Equals(x.value.Value, y.value.Value);

        public override int GetHashCode(PositiveIntElement? x)
        {
            if (x == null || x.value == null)
                return typeof(PositiveIntElement).GetHashCode();
            return x.value.GetHashCode();
        }
    }
}
