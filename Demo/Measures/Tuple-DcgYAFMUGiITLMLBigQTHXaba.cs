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
    public class Tuple_DcgYAFMUGiITLMLBigQTHXaba: TupleBaseType
    {
        [CqlDeclaration("ValidEncounters")]
        public Encounter ValidEncounters { get; set; }
        [CqlDeclaration("InitialPROMIS29Date")]
        public CqlDate InitialPROMIS29Date { get; set; }
        [CqlDeclaration("FollowupPROMIS29Date")]
        public CqlDate FollowupPROMIS29Date { get; set; }
    }
}