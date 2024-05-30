using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

namespace Tuples
{
    [System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
    public class Tuple_DZhWGXhMBfAVMZfaSZbEKSOHj: TupleBaseType
    {
        [CqlDeclaration("ValidEncounters")]
        public Encounter ValidEncounters { get; set; }
        [CqlDeclaration("InitialPROMIS10Date")]
        public CqlDate InitialPROMIS10Date { get; set; }
        [CqlDeclaration("FollowupPROMIS10Date")]
        public CqlDate FollowupPROMIS10Date { get; set; }
    }
}
