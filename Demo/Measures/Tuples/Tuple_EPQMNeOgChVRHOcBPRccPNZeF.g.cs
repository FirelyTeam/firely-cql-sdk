using System;
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
    public class Tuple_EPQMNeOgChVRHOcBPRccPNZeF: TupleBaseType
    {
        [CqlDeclaration("dayIndex")]
        public int? dayIndex { get; set; }
        [CqlDeclaration("dayPeriod")]
        public CqlInterval<CqlDateTime> dayPeriod { get; set; }
        [CqlDeclaration("hasSevereResult")]
        public bool? hasSevereResult { get; set; }
        [CqlDeclaration("hasElevatedResult")]
        public bool? hasElevatedResult { get; set; }
        [CqlDeclaration("hasNoResult")]
        public bool? hasNoResult { get; set; }
    }
}
