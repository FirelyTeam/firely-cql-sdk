using Hl7.Fhir.Model;
using Ncqa.Cql.Runtime.Comparers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.Firely.Comparers
{
    public class IdentifierCqlComparer : CqlComparerBase<Identifier>
    {
        public FirelyCqlComparers Comparers { get; }
        public IComparer<string> SystemComparer { get; }

        public IdentifierCqlComparer(FirelyCqlComparers comparers, 
            IComparer<string>? systemComparer = null)
        {
            Comparers = comparers;
            SystemComparer = systemComparer ?? StringComparer.OrdinalIgnoreCase;
        }

        public override int? Compare(Identifier x, Identifier y, string? precision)
        {
            if (x == null || y == null)
                return null;
            var system = SystemComparer.Compare(x.System ?? "", y.System ?? "");
            if (system == 0)
                return Comparers.Compare(x.Value, y.Value, precision);
            else return system;
        }


        public override bool? Equals(Identifier x, Identifier y, string? precision) =>
            x == null || y == null
            ? null
            : Compare(x, y, precision) == 0;

        public override bool Equivalent(Identifier x, Identifier y, string? precision) =>
            Compare(x, y, precision) == 0
            ? true
            : false;

        public override int GetHashCode(Identifier? x)
        {
            if (x == null || x.Value == null)
                return typeof(FhirString).GetHashCode();
            else return $"{x.Value}{x.System}".GetHashCode();
        }
        public override int GetHashCode(object x) => GetHashCode(x as Identifier);
    }
}
