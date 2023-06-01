using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSets;
using System;
using System.Collections.Generic;
using System.Linq;
using Hl7.Cql.Poco.Fhir.R4.Model;
using System.Diagnostics;

namespace Hl7.Cql.ValueSetLoaders
{
    public class FhirR4ValueSetLoader : IValueSetLoader
    {

        public FhirR4ValueSetLoader(IEnumerable<ValueSet> valuesets,
            bool activeOnly = true,
            Func<ValueSet, bool>? onInvalidValueSet = null)
        {
            ValueSets = valuesets.ToDictionary(vs => vs.url.value);
            ActiveOnly = activeOnly;
            OnInvalidValueSet = onInvalidValueSet;
        }

        protected IDictionary<string, ValueSet> ValueSets { get; }
        public bool ActiveOnly { get; }
        public Func<ValueSet, bool>? OnInvalidValueSet { get; }

        public IValueSetDictionary Load()
        {
            var vsd = new HashValueSetDictionary();
            Load(vsd);
            return vsd;
        }
        public void Load(IValueSetDictionary dictionary)
        {
            foreach (var vs in ValueSets)
            {
                Load(dictionary, vs.Value);
            }
        }

        private void Load(IValueSetDictionary dictionary, ValueSet vs, params string[] soFar)
        {
            if ((ActiveOnly && vs.status != "active"!) || string.IsNullOrWhiteSpace(vs.url))
            {
                var handler = OnInvalidValueSet;
                if (handler != null)
                {
                    var cancel = handler(vs);
                    if (cancel)
                        return;
                }
            }
            var contains = vs.expansion?.contains;
            if (contains != null)
            {
                foreach (var component in contains)
                {
                    var code = component.code;
                    var system = component.system;
                    if (!string.IsNullOrWhiteSpace(code)
                        && !string.IsNullOrWhiteSpace(system))
                    {
                        if (!dictionary.IsCodeInValueSet(vs.url, code, system))
                        {
                            dictionary.Add(vs.url, new CqlCode(code, system, component.version, component.display));
                        }
                    }

                }
            }
            var include = vs.compose?.include;
            if (include != null)
            {
                foreach (var component in include)
                {
                    var system = component.system;
                    var concept = component.concept;

                    if (concept != null)
                    {
                        foreach (var conceptComponent in concept)
                        {
                            var code = conceptComponent.code;

                            if (!string.IsNullOrWhiteSpace(code)
                                && !string.IsNullOrWhiteSpace(system))
                            {
                                if (!dictionary.IsCodeInValueSet(vs.url, code, system))
                                    dictionary.Add(vs.url, new CqlCode(code, system, component.version, conceptComponent.display));
                            }
                        }
                    }

                    var cValueSets = component.valueSet;
                    if (cValueSets != null)
                    {
                        foreach (var includedValueSetUri in cValueSets)
                        {
                            if (soFar.Contains(includedValueSetUri.value))
                            {
                                var cycle = string.Join(" => ", soFar);
                                throw new InvalidOperationException($"Value set {vs.id} has a cyclical reference in its composition: {cycle}");
                            }
                            if (!dictionary.TryGetCodesInValueSet(includedValueSetUri, out var cvsCodes))
                            {
                                if (ValueSets.TryGetValue(includedValueSetUri, out var includedVs))
                                {
                                    var deeper = new string[soFar.Length + 1];
                                    Array.Copy(soFar, deeper, soFar.Length);
                                    deeper[deeper.Length - 1] = includedValueSetUri;
                                    Load(dictionary, includedVs, deeper);
                                    if (!dictionary.TryGetCodesInValueSet(includedValueSetUri, out cvsCodes))
                                        cvsCodes = new List<CqlCode>().AsReadOnly();
                                    else throw new InvalidOperationException($"Couldn't load {includedValueSetUri}");
                                }
                                else throw new InvalidOperationException($"Intensional value set {vs.id} includes value set {includedValueSetUri}, which was not provided to this loader.");
                            }
                            foreach (var code in cvsCodes!)
                            {
                                if (!string.IsNullOrWhiteSpace(code.code) && !string.IsNullOrWhiteSpace(code.system))
                                {
                                    if (!dictionary.IsCodeInValueSet(vs.url, code.code!, code.system))
                                    {
                                        dictionary.Add(vs.url, new CqlCode(code.code, code.system, code.version, code.display));
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
