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
    public class Tuple_BhaRdDVNNUEZDBgSheMGTUMHO: TupleBaseType
    {
        [CqlDeclaration("Intervals")]
        public IEnumerable<CqlInterval<CqlDateTime>> Intervals { get; set; }
        [CqlDeclaration("Interval Count")]
        public int? Interval_Count { get; set; }
        [CqlDeclaration("Total Days In Intervals")]
        public int? Total_Days_In_Intervals { get; set; }
        [CqlDeclaration("Longest Interval")]
        public CqlInterval<CqlDateTime> Longest_Interval { get; set; }
        [CqlDeclaration("Total Days In Longest Interval")]
        public int? Total_Days_In_Longest_Interval { get; set; }
    }
}
