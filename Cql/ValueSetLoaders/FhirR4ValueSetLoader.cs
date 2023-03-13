using Ncqa.Cql.Runtime;
using Ncqa.Cql.Runtime.Primitives;
using Ncqa.Fhir.R4.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace Ncqa.Cql.ValueSetLoaders
{
    public class FhirR4ValueSetLoader : IValueSetLoader
    {

        public FhirR4ValueSetLoader(IEnumerable<ValueSet> valuesets, 
            bool activeOnly = true,
            Func<ValueSet, bool>? onInvalidValueSet = null)
        {
            ValueSets = valuesets;
            ActiveOnly = activeOnly;
            OnInvalidValueSet = onInvalidValueSet;
        }

        public IEnumerable<ValueSet> ValueSets { get; }

        public bool ActiveOnly { get; }
        public Func<ValueSet, bool>? OnInvalidValueSet { get; }

        public IValueSetDictionary Load()
        {
            var vsd = new CqlValueSetDictionary();
            Load(vsd);
            return vsd;
        }

        public void Load(IValueSetDictionary dictionary)
        {
            foreach (var vs in ValueSets)
            {
                if ((ActiveOnly && vs.status != "active"!) || string.IsNullOrWhiteSpace(vs.url))
                {
                    var handler = OnInvalidValueSet;
                    if (handler != null)
                    {
                        var cancel = handler(vs);
                        if (cancel)
                            break;
                    }
                    continue;
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
                            dictionary.Add(vs.url, new CqlCode(code, system, component.version, component.display));
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
                                    dictionary.Add(vs.url, new CqlCode(code, system, component.version, conceptComponent.display));
                                }
                            }
                        }
                    }
                } 
            }
        }
    }
}
