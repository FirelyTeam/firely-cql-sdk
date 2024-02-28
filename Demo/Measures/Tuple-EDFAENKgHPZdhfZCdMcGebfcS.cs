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
    [System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "1.0.0.0")]
    public class Tuple_EDFAENKgHPZdhfZCdMcGebfcS: TupleBaseType
    {
        [CqlDeclaration("DTaPVaccination1")]
        public CqlDate DTaPVaccination1 { get; set; }
        [CqlDeclaration("DTaPVaccination2")]
        public CqlDate DTaPVaccination2 { get; set; }
        [CqlDeclaration("DTaPVaccination3")]
        public CqlDate DTaPVaccination3 { get; set; }
        [CqlDeclaration("DTaPVaccination4")]
        public CqlDate DTaPVaccination4 { get; set; }
    }
}