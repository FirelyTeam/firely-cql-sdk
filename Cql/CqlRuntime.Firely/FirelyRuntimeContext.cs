using Hl7.Fhir.Model;
using Ncqa.Cql.Runtime;
using Ncqa.Cql.Runtime.Comparers;
using Ncqa.Cql.Runtime.Conversion;
using Ncqa.Cql.Runtime.Firely.Comparers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.Firely
{
    public class FirelyRuntimeContext : RuntimeContext
    {
        public FirelyRuntimeContext(Bundle bundle,
            DefinitionDictionary<Delegate> definitions,
            IValueSetDictionary valueSetDictionary,
            IDictionary<string, object> parameters,
            DateTimeOffset now,
            RuntimeOptions? options = null):
            base(definitions, parameters, valueSetDictionary, now, options)
        {
            FhirOperators = new FirelyCqlOperators(this, FirelyTypeResolver.Default);
            FhirComparers = new FirelyCqlComparers(new UnitConverter(), Operators);
            DataRetriever = new BundleRetriever(this, bundle);
        }

        public FirelyRuntimeContext(IDataRetriever dataRetriever,
            DefinitionDictionary<Delegate> definitions,
            IValueSetDictionary valueSetDictionary,
            IDictionary<string, object> parameters,
            DateTimeOffset now,
            RuntimeOptions? options = null) :
            base(definitions, parameters, valueSetDictionary, now, options)
        {
            FhirOperators = new FirelyCqlOperators(this, FirelyTypeResolver.Default);
            FhirComparers = new FirelyCqlComparers(new UnitConverter(), Operators);
            DataRetriever = dataRetriever;
        }

        public override CqlComparers Comparers => FhirComparers;
        public override ICqlOperators Operators => FhirOperators;

        public FirelyCqlOperators FhirOperators { get; }
        public FirelyCqlComparers FhirComparers { get; }
        public override IDataRetriever DataRetriever { get; }

        public override RuntimeContext Clone()
        {
            var clone = new FirelyRuntimeContext(DataRetriever, Definitions, ValueSets, Parameters, Now, Options);
            PopulateClone(clone);
            return clone;
        }
    }
}
