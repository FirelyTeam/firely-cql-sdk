using Hl7.Fhir.Model;
using Ncqa.Cql.Runtime.Comparers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ncqa.Cql.Runtime.Firely.Comparers
{
    public class CodeableConceptCqlComparer : CqlComparerBase<CodeableConcept>
    {
        public CodeableConceptCqlComparer(FirelyCqlComparers comparers)
        {
            Comparers = comparers;
        }

        public FirelyCqlComparers Comparers { get; }

        public override int? Compare(CodeableConcept x, CodeableConcept y, string? precision)
        {
            if (x == null || x.Coding == null || y == null || y.Coding == null)
                return null;
            foreach(var xc in x.Coding)
            {
                foreach(var yc in y.Coding)
                {
                    if (Comparers.Compare(xc, yc, precision) == 0)
                        return 0;
                }
            }
            return null;
        }

        public override bool? Equals(CodeableConcept x, CodeableConcept y, string? precision)
        {
            if (x == null || x.Coding == null || y == null || y.Coding == null)
                return null;
            foreach (var xc in x.Coding)
            {
                foreach (var yc in y.Coding)
                {
                    if (Comparers.Equals(xc, yc, precision) == true)
                        return true;
                }
            }
            return false;
        }

        public override bool Equivalent(CodeableConcept x, CodeableConcept y, string? precision)
        {
            if (x == null || x.Coding == null || y == null || y.Coding == null)
                return false;
            foreach (var xc in x.Coding)
            {
                foreach (var yc in y.Coding)
                {
                    if (Comparers.Equivalent(xc, yc, precision) == true)
                        return true;
                }
            }
            return false;
        }

        public override int GetHashCode(CodeableConcept? x)
        {
            var baseHashCode = typeof(CodeableConcept).GetHashCode();
            if (x == null || x.Coding == null)
                return baseHashCode;
            else foreach (var xc in x.Coding)
                baseHashCode ^= Comparers.GetHashCode(xc);
            return baseHashCode;
        }

        public override int GetHashCode(object x) => GetHashCode(x as CodeableConcept);
    }
}
