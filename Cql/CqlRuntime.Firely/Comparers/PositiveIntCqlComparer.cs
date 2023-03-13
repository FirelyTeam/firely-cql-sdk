using Hl7.Fhir.Model;
using Ncqa.Cql.Runtime.Comparers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.Firely.Comparers
{
    public class PositiveIntCqlComparer : CqlComparerBase<PositiveInt>
    {
        public override int? Compare(PositiveInt x, PositiveInt y, string? precision) =>
            x == null || y == null || x.Value == null || y.Value == null
            ? null
            : Comparer<int>.Default.Compare(x.Value.Value, y.Value.Value);

        public override bool? Equals(PositiveInt x, PositiveInt y, string? precision) =>
            x == null || y == null || x.Value == null || y.Value == null
            ? null
            : EqualityComparer<int>.Default.Equals(x.Value.Value, y.Value.Value);

        public override bool Equivalent(PositiveInt x, PositiveInt y, string? precision) =>
            x == null || y == null || x.Value == null || y.Value == null
            ? false
            : EqualityComparer<int>.Default.Equals(x.Value.Value, y.Value.Value);

        public override int GetHashCode(PositiveInt? x)
        {
            if (x == null || x.Value == null)
                return typeof(PositiveInt).GetHashCode();
            return x.Value.GetHashCode();
        }

        public override int GetHashCode(object x) => GetHashCode(x as PositiveInt);
    }
}
