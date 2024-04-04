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
    public class Tuple_BbiPKFIYFfdQCLCHPcXKDaFMV: TupleBaseType
    {
        [CqlDeclaration("KCCQLifeQuality")]
        public Observation KCCQLifeQuality { get; set; }
        [CqlDeclaration("KCCQSymptomStability")]
        public Observation KCCQSymptomStability { get; set; }
        [CqlDeclaration("KCCQSelfEfficacy")]
        public Observation KCCQSelfEfficacy { get; set; }
        [CqlDeclaration("KCCQSymptoms")]
        public Observation KCCQSymptoms { get; set; }
        [CqlDeclaration("KCCQPhysicalLimits")]
        public Observation KCCQPhysicalLimits { get; set; }
        [CqlDeclaration("KCCQSocialLimits")]
        public Observation KCCQSocialLimits { get; set; }
    }
}
