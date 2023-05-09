using Cql.Operators;
using Ncqa.Cql.Comparers;
using Ncqa.Cql.Operators;
using Ncqa.Cql.Runtime.Conversion;
using Ncqa.Cql.Runtime.FhirR4.Comparers;
using Ncqa.Cql.Runtime.Primitives;
using Ncqa.Cql.ValueSets;
using Ncqa.Fhir.R4.Model;
using Ncqa.Iso8601;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Loader;

namespace Ncqa.Cql.Runtime.FhirR4
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
