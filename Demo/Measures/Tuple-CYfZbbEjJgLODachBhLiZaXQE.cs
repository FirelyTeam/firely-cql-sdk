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
    public class Tuple_CYfZbbEjJgLODachBhLiZaXQE: TupleBaseType
    {
        [CqlDeclaration("InpatientDischarge")]
        public IEnumerable<Claim> InpatientDischarge { get; set; }
        [CqlDeclaration("NonacuteInpatientDischarge")]
        public IEnumerable<Claim> NonacuteInpatientDischarge { get; set; }
        [CqlDeclaration("AcuteInpatientDischarge")]
        public IEnumerable<Claim> AcuteInpatientDischarge { get; set; }
    }
}