/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Comparers;
using Hl7.Cql.Primitives;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;
using Hl7.Fhir.Specification.Source;
using Hl7.Fhir.Specification.Terminology;
using Hl7.Fhir.Utility;
using System.Collections.Concurrent;

namespace Hl7.Cql.ValueSetLoaders
{
    /// <summary>
    /// Implementation of <see cref="IValueSetDictionary"/> that uses a <see cref="IResourceResolver"/> as a terminology source.
    /// </summary>
    /// <remarks>Aggresively caches the loaded valuesets to improve performance.</remarks>
    public class ValueSetSource : IValueSetDictionary
    {
        private readonly ConcurrentDictionary<CqlCode, CqlCode> _internHash;

        public CqlCode Intern(CqlCode code) => _internHash.GetOrAdd(code, code);

        private const int MAXIMUM_EXPANSION_SIZE = 5000;

        private readonly IAsyncResourceResolver? _resourceResolver;
        private readonly ICodeValidationTerminologyService? _termService;
        private readonly ConcurrentDictionary<string, InMemoryValueSet> _valueSets = new(StringComparer.OrdinalIgnoreCase);

        public ValueSetSource(IAsyncResourceResolver? resourceResolver = null, ICodeValidationTerminologyService? termService = null)
        {
            _internHash = new(CqlCodeCqlComparer.DefaultCqlComparer.ToEqualityComparer());
            _resourceResolver = resourceResolver;
            _termService = termService;
        }

        private ValueSetExpander buildExpander()
        {
            var expansionOptions = new ValueSetExpanderSettings()
            {
                IncludeDesignations = false,   // We won't keep them around anyway.
                MaxExpansionSize = MAXIMUM_EXPANSION_SIZE,
                ValueSetSource = _resourceResolver
            };

            return new ValueSetExpander(expansionOptions);
        }

        /// <summary>
        /// Adds a <see cref="ValueSet"/> to the cache, so it will not be retrieved using the resolver.
        /// </summary>
        /// <returns>true if the cache did not yet contains the valueset, and false when it was already cached.</returns>
        public async Task<IValueSetFacade> Add(ValueSet vs)
        {
            if (_valueSets.TryGetValue(vs.Url, out var valueSet)) return valueSet;

            // Not cached yet, build it first.
            var newVs = await build(vs);

            // Add it, or return whatever was in the cache by now. If we were pre-empted, this might be
            // another instance than ours.
            return _valueSets.GetOrAdd(vs.Url, newVs);

            async Task<InMemoryValueSet> build(ValueSet vs)
            {
                var expander = buildExpander();
                if (!vs.HasExpansion)
                {
                    if (_resourceResolver is null)
                        throw new InvalidOperationException($"ValueSet {vs.Url} has no expansion, and there is no resource resolver configured to generate one.");

                    await expander.ExpandAsync(vs);
                }

                var codes = toCodes(vs.Expansion.Contains);
                return new InMemoryValueSet(codes);
            }
        }

        public async Task<IValueSetFacade?> Load(string canonical)
        {
            if (_valueSets.TryGetValue(canonical, out var valueSet)) return valueSet;

            var vs = await _resourceResolver.FindValueSetAsync(canonical);
            return vs is null ? null : await Add(vs);
        }

        public IValueSetFacade Add(string canonical, IEnumerable<CqlCode> codes)
        {
            if (_valueSets.TryGetValue(canonical, out var valueSet)) return valueSet;

            return _valueSets.GetOrAdd(canonical, _ => new InMemoryValueSet(codes));
        }

        private IEnumerable<CqlCode> toCodes(IEnumerable<ValueSet.ContainsComponent> expansion) =>
            expansion.SelectMany(c => toCodes(c.Contains).Prepend(Intern(new CqlCode(c.Code, c.System, c.Version, c.Display))));

        public bool IsCodeInValueSet(string valueSetUri, CqlCode code) =>
            checkInternalAndExternalTS(valueSetUri,
                vs => vs.IsCodeInValueSet(code),
                pb => pb.WithCoding(new(code.system, code.code, code.display) { Version = code.version }));

        public bool IsCodeInValueSet(string valueSetUri, string code) =>
            checkInternalAndExternalTS(valueSetUri,
                vs => vs.IsCodeInValueSet(code),
                pb => pb.WithCode(code));

        public bool IsCodeInValueSet(string valueSetUri, string code, string? system) =>
            checkInternalAndExternalTS(valueSetUri,
                vs => vs.IsCodeInValueSet(code, system),
                pb => pb.WithCode(code, system));

        private bool checkInternalAndExternalTS(string valueSetUri, Predicate<IValueSetFacade> @internal, Action<ValidateCodeParameters> external)
        {
            if (TaskHelper.Await(() => Load(valueSetUri)) is { } vs && @internal(vs)) return true;

            if (_termService is null) return false;

            var parameters = new ValidateCodeParameters()
                    .WithValueSet(valueSetUri);
            external(parameters);

            var second = TaskHelper.Await(() => _termService.ValueSetValidateCode(parameters.Build()));
            return second.GetSingleValue<FhirBoolean>("result")?.Value == true;
        }


        public bool TryGetCodesInValueSet(string valueSetUri, out IEnumerable<CqlCode>? codes)
        {
            codes = TaskHelper.Await(() => Load(valueSetUri));
            if (codes is not null) return true;

            if (_termService is null || _termService is not IExpandingTerminologyService ets) return false;

            var expansionParameters = new ExpandParameters().WithValueSet(valueSetUri).Build();
            var result = TaskHelper.Await(() => ets.Expand(expansionParameters));

            if (result is ValueSet vs)
            {
                var facade = TaskHelper.Await(() => Add(vs));
                codes = facade;
                return true;
            }
            else
                return false;
        }
    }
}
