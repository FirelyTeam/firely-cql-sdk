using Microsoft.Extensions.Configuration;
using Hl7.Cql.ValueSets;
using System;
using Hl7.Cql.Poco.Fhir.R4.Model;
using Hl7.Cql.Poco.Fhir.TerminologyClient;

namespace Hl7.Cql.ValueSetLoaders
{
    public class TerminologyClientValueSetLoader : IValueSetLoader
    {
        private readonly string[] ValueSetIds;
        private readonly R4Client Client;

        public Func<ValueSet, bool>? OnInvalidValueSet { get; }

        public TerminologyClientValueSetLoader(IConfiguration configuration,
            Func<ValueSet, bool>? onInvalidValueSet = null,
            params string[] valueSetIds)
        {
            OnInvalidValueSet = onInvalidValueSet;
            ValueSetIds = valueSetIds;
            Client = new R4Client(configuration);
        }


        public IValueSetDictionary Load()
        {
            var bundle = GetBundle();     
            var valueSets = bundle.entry.GetResourcesByType<ValueSet>();
            var fhirLoader = new FhirR4ValueSetLoader(valueSets, true, OnInvalidValueSet);
            return fhirLoader.Load();
        }

        public void Load(IValueSetDictionary dictionary)
        {
            var bundle = GetBundle();
            var valueSets = bundle.entry.GetResourcesByType<ValueSet>();
            var fhirLoader = new FhirR4ValueSetLoader(valueSets, true, OnInvalidValueSet);
            fhirLoader.Load(dictionary);
        }
        private Bundle GetBundle()
        {
            var task = System.Threading.Tasks.Task.Run(() => Client.ExpandValueSetsAsync(ValueSetIds));
            task.Wait();
            var bundle = task.Result;
            return bundle;
        }

    }
}
