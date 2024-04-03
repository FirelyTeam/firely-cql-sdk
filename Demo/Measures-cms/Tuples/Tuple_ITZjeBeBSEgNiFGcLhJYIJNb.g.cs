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
    public class Tuple_ITZjeBeBSEgNiFGcLhJYIJNb: TupleBaseType
    {
        [CqlDeclaration("Promis29Sleep")]
        public Observation Promis29Sleep { get; set; }
        [CqlDeclaration("Promis29SocialRoles")]
        public Observation Promis29SocialRoles { get; set; }
        [CqlDeclaration("Promis29Physical")]
        public Observation Promis29Physical { get; set; }
        [CqlDeclaration("Promis29Pain")]
        public Observation Promis29Pain { get; set; }
        [CqlDeclaration("Promis29Fatigue")]
        public Observation Promis29Fatigue { get; set; }
        [CqlDeclaration("Promis29Depression")]
        public Observation Promis29Depression { get; set; }
        [CqlDeclaration("Promis29Anxiety")]
        public Observation Promis29Anxiety { get; set; }
    }
}
