using Hl7.Cql.Operators;
using Hl7.Cql.Conversion;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System;
using System.Collections.Generic;
using Hl7.Cql.Poco.Fhir.R4.Model;

namespace Hl7.Cql.Runtime.FhirR4
{
    public static class FhirRuntimeContext
    {
        public static RuntimeContext Create(Bundle? bundle = null, 
            IDictionary<string,object>? parameters = null,
            IValueSetDictionary? valueSets = null,
            DateTimeOffset? now = null,
            DefinitionDictionary<Delegate>? delegates = null)
        {
            valueSets ??= new HashValueSetDictionary();
            var unitConverter = new UnitConverter();
            IDataRetriever dataRetriever = bundle != null
                ? new BundleDataRetriever(bundle, FhirTypeResolver.Default, valueSets)
                : new CompositeDataRetriever();

            var operators = CqlOperators.Create(FhirTypeResolver.Default,
                FhirTypeConverter.Default,
                dataRetriever,
                null,
                valueSets,
                null,
                new DateTimeIso8601(now ?? DateTimeOffset.UtcNow, DateTimePrecision.Millisecond));
            var ctx = new RuntimeContext(operators, delegates, parameters);
            return ctx;
        }
    }
}
