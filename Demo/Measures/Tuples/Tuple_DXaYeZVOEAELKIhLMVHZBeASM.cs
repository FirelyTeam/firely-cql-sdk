﻿using System;
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
    public class Tuple_DXaYeZVOEAELKIhLMVHZBeASM: TupleBaseType
    {
        [CqlDeclaration("ClaimofInterest")]
        public Claim ClaimofInterest { get; set; }
        [CqlDeclaration("ClaimID")]
        public Id ClaimID { get; set; }
        [CqlDeclaration("LineItems")]
        public IEnumerable<Claim.ItemComponent> LineItems { get; set; }
    }
}