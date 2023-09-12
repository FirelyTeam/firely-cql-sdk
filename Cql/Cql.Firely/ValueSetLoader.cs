#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Fhir
{
    public static class ValueSetExtensions
    {
        public static IValueSetDictionary ToValueSetDictionary(this IEnumerable<ValueSet> values,
            bool activeOnly = true,
            Func<ValueSet, bool>? onInvalidValueSet = null) =>
                new ValueSetLoader(values, activeOnly, onInvalidValueSet).Load();
    }

    internal class ValueSetLoader
    {

        public ValueSetLoader(IEnumerable<ValueSet> valuesets,
            bool activeOnly = true,
            Func<ValueSet, bool>? onInvalidValueSet = null)
        {
            ValueSets = valuesets.ToDictionary(vs => vs.Url);
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
        public void Load(HashValueSetDictionary dictionary)
        {
            foreach (var vs in ValueSets)
            {
                Load(dictionary, vs.Value);
            }
        }

        private void Load(HashValueSetDictionary dictionary, ValueSet vs, params string[] soFar)
        {
            if ((ActiveOnly && vs.Status != PublicationStatus.Active) || string.IsNullOrWhiteSpace(vs.Url))
            {
                var handler = OnInvalidValueSet;
                if (handler != null)
                {
                    var cancel = handler(vs);
                    if (cancel)
                        return;
                }
            }
            var contains = vs.Expansion?.Contains;
            if (contains != null)
            {
                foreach (var component in contains)
                {
                    var code = component.Code;
                    var system = component.System;
                    if (!string.IsNullOrWhiteSpace(code)
                        && !string.IsNullOrWhiteSpace(system))
                    {
                        if (!dictionary.IsCodeInValueSet(vs.Url, code, system))
                        {
                            dictionary.Add(vs.Url, new CqlCode(code, system, component.Version, component.Display));
                        }
                    }

                }
            }
            var include = vs.Compose?.Include;
            if (include != null)
            {
                foreach (var component in include)
                {
                    var system = component.System;
                    var concept = component.Concept;

                    if (concept != null)
                    {
                        foreach (var conceptComponent in concept)
                        {
                            var code = conceptComponent.Code;

                            if (!string.IsNullOrWhiteSpace(code)
                                && !string.IsNullOrWhiteSpace(system))
                            {
                                if (!dictionary.IsCodeInValueSet(vs.Url, code, system))
                                    dictionary.Add(vs.Url, new CqlCode(code, system, component.Version, conceptComponent.Display));
                            }
                        }
                    }

                    var cValueSets = component.ValueSet;
                    if (cValueSets != null)
                    {
                        foreach (var includedValueSetUri in cValueSets)
                        {
                            if (soFar.Contains(includedValueSetUri))
                            {
                                var cycle = string.Join(" => ", soFar);
                                throw new InvalidOperationException($"Value set {vs.Id} has a cyclical reference in its composition: {cycle}");
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
                                        throw new InvalidOperationException($"Couldn't load {includedValueSetUri}");
                                }
                                else throw new InvalidOperationException($"Intensional value set {vs.Id} includes value set {includedValueSetUri}, which was not provided to this loader.");
                            }
                            foreach (var code in cvsCodes!)
                            {
                                if (!string.IsNullOrWhiteSpace(code.code) && !string.IsNullOrWhiteSpace(code.system))
                                {
                                    if (!dictionary.IsCodeInValueSet(vs.Url, code.code!, code.system))
                                    {
                                        dictionary.Add(vs.Url, new CqlCode(code.code, code.system, code.version, code.display));
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
