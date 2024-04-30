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
    public class Tuple_FBHNjYWJgMKheadEZUgcdQGXN: TupleBaseType
    {
        [CqlDeclaration("FirstUSSAssessment")]
        public Tuple_GNNDVIQPcTANSdLebhBKYIdga FirstUSSAssessment { get; set; }
        [CqlDeclaration("FollowUpUSSAssessment")]
        public Tuple_GNNDVIQPcTANSdLebhBKYIdga FollowUpUSSAssessment { get; set; }
    }
}
