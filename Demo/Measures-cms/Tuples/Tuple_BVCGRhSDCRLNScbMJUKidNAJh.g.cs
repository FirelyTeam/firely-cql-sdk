using System;
using Tuples;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

namespace Tuples
{
    [System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
    public class Tuple_BVCGRhSDCRLNScbMJUKidNAJh: TupleBaseType
    {
        [CqlDeclaration("PneumococcalVaccination1")]
        public CqlDate PneumococcalVaccination1 { get; set; }
        [CqlDeclaration("PneumococcalVaccination2")]
        public CqlDate PneumococcalVaccination2 { get; set; }
        [CqlDeclaration("PneumococcalVaccination3")]
        public CqlDate PneumococcalVaccination3 { get; set; }
        [CqlDeclaration("PneumococcalVaccination4")]
        public CqlDate PneumococcalVaccination4 { get; set; }
    }
}
