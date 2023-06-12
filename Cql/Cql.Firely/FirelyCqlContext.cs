using Cql.Operators;
using Hl7.Cql.Comparers;
using Hl7.Cql.Conversion;
using Hl7.Cql.Iso8601;
using Hl7.Cql.Model;
using Hl7.Cql.Operators;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Firely
{
    public static class FirelyCqlContext
    {


        public static CqlContext Create(Bundle? bundle = null,
            IDictionary<string, object>? parameters = null,
            IValueSetDictionary? valueSets = null,
            DateTimeOffset? now = null,
            DefinitionDictionary<Delegate>? delegates = null)
        {
            valueSets ??= new HashValueSetDictionary();
            var unitConverter = new UnitConverter();
            var typeResolver = new FirelyTypeResolver(Hl7.Fhir.Model.ModelInfo.ModelInspector);
            IDataRetriever dataRetriever = bundle != null
                ? new BundleDataRetriever(bundle, valueSets, typeResolver)
                : new CompositeDataRetriever();

            var cqlComparers = new CqlComparers();
            var operators = CqlOperators.Create(typeResolver,
                FirelyTypeConverter.Create(Fhir.Model.ModelInfo.ModelInspector),
                dataRetriever,
                cqlComparers,
                valueSets,
                null,
                new DateTimeIso8601(now ?? DateTimeOffset.UtcNow, DateTimePrecision.Millisecond));
            cqlComparers.AddIntervalComparisons(operators);
            var ctx = new CqlContext(operators, delegates, parameters);
            return ctx;
        }
    }
}
