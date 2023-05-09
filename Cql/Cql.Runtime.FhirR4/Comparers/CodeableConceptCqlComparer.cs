using Ncqa.Cql.Comparers;
using Ncqa.Fhir.R4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ncqa.Cql.Runtime.FhirR4.Comparers
{
    public class CodeableConceptCqlComparer : CqlComparerBase<CodeableConcept>
    {
        public CodeableConceptCqlComparer(CqlComparers comparers)
        {
            Comparers = comparers;
        }

        public CqlComparers Comparers { get; }

        public override int? Compare(CodeableConcept x, CodeableConcept y, string? precision)
        {
            if (x == null || x.coding == null || y == null || y.coding == null)
                return null;
            foreach(var xc in x.coding)
            {
                foreach(var yc in y.coding)
                {
                    if (Comparers.Compare(xc, yc, precision) == 0)
                        return 0;
                }
            }
            return null;
        }

        public override bool? Equals(CodeableConcept x, CodeableConcept y, string? precision)
        {
            if (x == null || x.coding == null || y == null || y.coding == null)
                return null;
            foreach (var xc in x.coding)
            {
                foreach (var yc in y.coding)
                {
                    if (Comparers.Equals(xc, yc, precision) == true)
                        return true;
                }
            }
            return false;
        }

        public override bool Equivalent(CodeableConcept x, CodeableConcept y, string? precision)
        {
            if (x == null || x.coding == null || y == null || y.coding == null)
                return false;
            foreach (var xc in x.coding)
            {
                foreach (var yc in y.coding)
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
            if (x == null || x.coding == null)
                return baseHashCode;
            else foreach (var xc in x.coding)
                baseHashCode ^= Comparers.GetHashCode(xc);
            return baseHashCode;
        }

    }
}
