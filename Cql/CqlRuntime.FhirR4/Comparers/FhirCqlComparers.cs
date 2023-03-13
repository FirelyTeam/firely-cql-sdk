using Ncqa.Cql.Runtime;
using Ncqa.Cql.Runtime.Comparers;
using Ncqa.Cql.Runtime.Conversion;
using Ncqa.Fhir.R4.Model;
using Ncqa.Iso8601;
using System;
using System.Collections.Generic;

namespace Ncqa.Cql.Runtime.FhirR4.Comparers
{
    public class FhirCqlComparers : CqlComparers
    {
        protected override Type ResourceType => typeof(Resource);

        public FhirCqlComparers(IUnitConverter unitConverter, ICqlOperators operators)
            : base(unitConverter, operators)
        {
            Comparers.TryAdd(typeof(Resource), new ResourceCqlComparer(this));
            Comparers.TryAdd(typeof(DecimalElement), new DecimalElementCqlComparer());
            Comparers.TryAdd(typeof(PositiveIntElement), new PositiveIntElementCqlComparer());
            Comparers.TryAdd(typeof(Coding), new CodingCqlComparer(StringComparer.OrdinalIgnoreCase));
            Comparers.TryAdd(typeof(CodeableConcept), new CodeableConceptCqlComparer(this));
            Comparers.TryAdd(typeof(Identifier), new IdentifierCqlComparer(this));
            var stringElementComparer = new StringElementCqlComparer(this);
            Comparers.TryAdd(typeof(CodeElement), stringElementComparer);
            Comparers.TryAdd(typeof(StringElement), stringElementComparer);
            Comparers.TryAdd(typeof(IdElement), stringElementComparer);

            Comparers.TryAdd(typeof(MarkdownElement), stringElementComparer);
            
        }
    }
}
