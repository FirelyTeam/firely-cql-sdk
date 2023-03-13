using Ncqa.Cql.Runtime.Comparers;
using Ncqa.Cql.Runtime.Conversion;
using Ncqa.Cql.Runtime.FhirR4.Comparers;
using Ncqa.Fhir.R4.Model;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Loader;

namespace Ncqa.Cql.Runtime.FhirR4
{
    public class FhirRuntimeContext : RuntimeContext
    {
        public FhirRuntimeContext(Bundle bundle,
            DefinitionDictionary<Delegate> definitions,
            IValueSetDictionary valueSetDictionary,
            IDictionary<string, object> parameters,
            DateTimeOffset now,
            RuntimeOptions? options = null) :
            base(definitions, parameters, valueSetDictionary, now, options)
        {
            FhirOperators = new FhirCqlOperators(this, FhirTypeResolver.Default);
            FhirComparers = new FhirCqlComparers(new UnitConverter(), Operators);
            DataRetriever = new BundleDataRetriever(this, bundle);
        }
        public FhirRuntimeContext(IDataRetriever retriever,
            DefinitionDictionary<Delegate> definitions,
            IValueSetDictionary valueSetDictionary,
            IDictionary<string, object> parameters,
            DateTimeOffset now,
            RuntimeOptions? options = null) :
            base(definitions, parameters, valueSetDictionary, now, options)
        {
            FhirOperators = new FhirCqlOperators(this, FhirTypeResolver.Default);
            FhirComparers = new FhirCqlComparers(new UnitConverter(), Operators);
            DataRetriever = retriever;
        }
        public override IDataRetriever DataRetriever { get; }

        public override CqlComparers Comparers => FhirComparers;
        public override ICqlOperators Operators => FhirOperators;

        public FhirCqlOperators FhirOperators { get; }
        public FhirCqlComparers FhirComparers { get; }

        public override RuntimeContext Clone()
        {
            var clone = new FhirRuntimeContext(DataRetriever, Definitions, ValueSets, Parameters, Now, Options);
            PopulateClone(clone);
            return clone;
        }
    }
}
