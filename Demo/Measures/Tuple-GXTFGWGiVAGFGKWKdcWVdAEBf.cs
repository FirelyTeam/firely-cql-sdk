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
    public class Tuple_GXTFGWGiVAGFGKWKdcWVdAEBf: TupleBaseType
    {
        [CqlDeclaration("StartYear")]
        public int? StartYear { get; set; }
        [CqlDeclaration("StartMonth")]
        public int? StartMonth { get; set; }
        [CqlDeclaration("StartDay")]
        public int? StartDay { get; set; }
        [CqlDeclaration("StartHour")]
        public int? StartHour { get; set; }
        [CqlDeclaration("StartMinute")]
        public int? StartMinute { get; set; }
        [CqlDeclaration("StartSecond")]
        public int? StartSecond { get; set; }
        [CqlDeclaration("StartMillisecond")]
        public int? StartMillisecond { get; set; }
        [CqlDeclaration("EndYear")]
        public int? EndYear { get; set; }
        [CqlDeclaration("EndMonth")]
        public int? EndMonth { get; set; }
        [CqlDeclaration("EndDay")]
        public int? EndDay { get; set; }
        [CqlDeclaration("EndHour")]
        public int? EndHour { get; set; }
        [CqlDeclaration("EndMinute")]
        public int? EndMinute { get; set; }
        [CqlDeclaration("EndSecond")]
        public int? EndSecond { get; set; }
        [CqlDeclaration("EndMillisecond")]
        public int? EndMillisecond { get; set; }
    }
}