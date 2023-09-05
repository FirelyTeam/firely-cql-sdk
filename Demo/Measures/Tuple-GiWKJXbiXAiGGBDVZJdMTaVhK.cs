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

    [System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.9.0.0")]
    public class Tuple_GiWKJXbiXAiGGBDVZJdMTaVhK: TupleBaseType
    {
        [CqlDeclaration("encounter")]
        public Encounter encounter { get; set; }
        [CqlDeclaration("relevantPeriod")]
        public CqlInterval<CqlDateTime> relevantPeriod { get; set; }
        [CqlDeclaration("relevantDays")]
        public IEnumerable<Tuples.Tuple_EPQMNeOgChVRHOcBPRccPNZeF> relevantDays { get; set; }
    }
}