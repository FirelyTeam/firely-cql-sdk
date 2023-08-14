using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
namespace Tuples
{

    [System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.0.1.0")]
    public class Tuple_FOLKddIQBPRMYYfjeMUjEIBhC: TupleBaseType
    {
        [CqlDeclaration("Claim")]
        public Claim Claim { get; set; }
        [CqlDeclaration("LineItem")]
        public IEnumerable<Claim.ItemComponent> LineItem { get; set; }
        [CqlDeclaration("ServicePeriod")]
        public IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod { get; set; }
        [CqlDeclaration("CoveredDays")]
        public IEnumerable<CqlInterval<CqlDateTime>> CoveredDays { get; set; }
    }
}