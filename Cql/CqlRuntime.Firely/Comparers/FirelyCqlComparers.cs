using Hl7.Fhir.Model;
using Ncqa.Cql.Runtime;
using Ncqa.Cql.Runtime.Comparers;
using Ncqa.Cql.Runtime.Conversion;
using Ncqa.Iso8601;
using System;
using System.Collections.Generic;

namespace Ncqa.Cql.Runtime.Firely.Comparers
{
    public class FirelyCqlComparers : CqlComparers
    {
        protected override Type ResourceType => typeof(Resource);

        public FirelyCqlComparers(IUnitConverter unitConverter, ICqlOperators operators)
            : base(unitConverter, operators)
        {
            Comparers.TryAdd(typeof(Resource), new ResourceCqlComparer(this));
            Comparers.TryAdd(typeof(FhirDecimal), new FhirDecimalCqlComparer());
            Comparers.TryAdd(typeof(PositiveInt), new PositiveIntCqlComparer());
            Comparers.TryAdd(typeof(Coding), new CodingCqlComparer(StringComparer.OrdinalIgnoreCase));
            Comparers.TryAdd(typeof(CodeableConcept), new CodeableConceptCqlComparer(this));
            Comparers.TryAdd(typeof(Identifier), new IdentifierCqlComparer(this));
            var stringElementComparer = new StringElementCqlComparer(this);
            Comparers.TryAdd(typeof(Code), stringElementComparer);
            Comparers.TryAdd(typeof(FhirString), stringElementComparer);
            Comparers.TryAdd(typeof(Id), stringElementComparer);

            Comparers.TryAdd(typeof(Markdown), stringElementComparer);
            
        }

        private static readonly HashSet<Type> CacheableComparisonTypes = new HashSet<Type>
        {
            typeof(int),
            typeof(int?),
            typeof(long),
            typeof(long?),
            typeof(decimal),
            typeof(decimal?),
            typeof(bool),
            typeof(bool?),
            typeof(string),
            // strictly speaking these are not cacheable since their values are mutable
            // changing these values while running a measure would be an egregious usage error
            // so let's cache them
            typeof(DateTimeIso8601),
            typeof(DateIso8601),
            typeof(TimeIso8601),
            typeof(PositiveInt),
            typeof(Code),
            typeof(Resource)
        };
    }
}
