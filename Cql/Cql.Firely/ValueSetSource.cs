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
using Hl7.Fhir.Rest;
using Hl7.Fhir.Specification.Source;
using Hl7.Fhir.Specification.Terminology;
using Hl7.Fhir.Utility;

namespace Hl7.Cql.Fhir;

/// <summary>
/// Implementation of <see cref="IValueSetDictionary"/> that uses a <see cref="IResourceResolver"/> as a terminology source.
/// </summary>
/// <remarks>Aggresively caches the loaded valuesets to improve performance.</remarks>
public class ValueSetSource : IValueSetDictionary
{
    private static readonly IEqualityComparer<CqlCode> OrdinalIgnoreCaseEqualityComparer = CqlCodeCqlComparer.OrdinalIgnoreCase.ToEqualityComparer();

    private readonly ConcurrentDictionary<CqlCode, CqlCode> _internHash;

    /// <summary>
    /// Internalize the given <see cref="CqlCode"/>. This method will return the same instance for the same code.
    /// </summary>
    public CqlCode Intern(CqlCode code) => _internHash.GetOrAdd(code, code);

    private const int MAXIMUM_EXPANSION_SIZE = 5000;

    private readonly IAsyncResourceResolver? _resourceResolver;
    private readonly ICodeValidationTerminologyService? _termService;
    private readonly ConcurrentDictionary<string, InMemoryValueSet> _valueSets = new(StringComparer.OrdinalIgnoreCase);

    /// <summary>
    /// Construct a new ValueSetSource with the given <see cref="IAsyncResourceResolver"/> and <see cref="ICodeValidationTerminologyService"/>.
    /// </summary>
    public ValueSetSource(IAsyncResourceResolver? resourceResolver = null, ICodeValidationTerminologyService? termService = null)
    {
        _internHash = new ConcurrentDictionary<CqlCode, CqlCode>(OrdinalIgnoreCaseEqualityComparer);
        _resourceResolver = resourceResolver;
        _termService = termService;
    }

    private ValueSetExpander BuildExpander()
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
    /// Adds a list of <see cref="ValueSet"/>s to the cache, so they will not be retrieved using the resolver.
    /// </summary>
    public async Task<IReadOnlyCollection<IValueSetFacade>> Add(IEnumerable<ValueSet> vsList)
    {
        var result = new ConcurrentBag<IValueSetFacade>();
        await Parallel.ForEachAsync(vsList, async (v,_) => result.Add(await Add(v))).ConfigureAwait(false);
        return result;
    }

    /// <summary>
    /// Adds a <see cref="ValueSet"/> to the cache, so it will not be retrieved using the resolver.
    /// </summary>
    public async Task<IValueSetFacade> Add(ValueSet vs)
    {
        if (_valueSets.TryGetValue(vs.Url!, out var valueSet)) return valueSet;

        // Not cached yet, build it first.
        var newVs = await build(vs).ConfigureAwait(false);

        // Add it, or return whatever was in the cache by now. If we were pre-empted, this might be
        // another instance than ours.
        return _valueSets.GetOrAdd(vs.Url!, newVs);

        async Task<InMemoryValueSet> build(ValueSet vs)
        {
            if (!vs.HasExpansion)
            {
                var expander = BuildExpander();
                await expander.ExpandAsync(vs).ConfigureAwait(false);
            }

            var codes = ToCodes(vs.Expansion!.Contains);
            return new InMemoryValueSet(codes);
        }
    }

    /// <summary>
    /// Given a canonical, returns the <see cref="IValueSetFacade"/> for that canonical from the
    /// cache, or uses the resolver to load it.
    /// </summary>
    public async Task<IValueSetFacade?> Load(string canonical)
    {
        if (_valueSets.TryGetValue(canonical, out var valueSet)) return valueSet;

        if(_resourceResolver is null) return null;

        var vs = await _resourceResolver.FindValueSetAsync(canonical).ConfigureAwait(false);
        return vs is null ? null : await Add(vs);
    }

    /// <summary>
    /// Adds a new <see cref="IValueSetFacade"/> to the cache, based on the codes and the canonical.
    /// Is a no-op if the canonical is already in the cache.
    /// </summary>
    public IValueSetFacade Add(string canonical, IEnumerable<CqlCode> codes)
    {
        if (_valueSets.TryGetValue(canonical, out var valueSet)) return valueSet;

        return _valueSets.GetOrAdd(canonical, _ => new InMemoryValueSet(codes));
    }

    private IEnumerable<CqlCode> ToCodes(IEnumerable<ValueSet.ContainsComponent> expansion) =>
        expansion.SelectMany(c => ToCodes(c.Contains).Prepend(Intern(new CqlCode(c.Code, c.System, c.Version, c.Display))));

    /// <inheritdoc />
    public bool IsCodeInValueSet(string valueSetUri, CqlCode code) =>
        CheckInternalAndExternalTs(valueSetUri,
            vs => vs.IsCodeInValueSet(code),
            pb => pb.WithCoding(new Coding(code.system, code.code, code.display) { Version = code.version }));

    /// <inheritdoc />
    public bool IsCodeInValueSet(string valueSetUri, string code) =>
        CheckInternalAndExternalTs(valueSetUri,
                                   vs => vs.IsCodeInValueSet(code),
                                   pb => pb.WithCode(code));

    /// <inheritdoc />
    public bool IsCodeInValueSet(string valueSetUri, string code, string? system) =>
        CheckInternalAndExternalTs(valueSetUri,
                                   vs => vs.IsCodeInValueSet(code, system),
                                   pb => pb.WithCode(code, system));

    private bool CheckInternalAndExternalTs(
        string valueSetUri,
        Predicate<IValueSetFacade> @internal,
        Action<ValidateCodeParameters> external)
    {
        if (TaskHelper.Await(() => Load(valueSetUri)) is { } vs && @internal(vs)) return true;

        if (_termService is null) return false;

        var parameters = new ValidateCodeParameters()
            .WithValueSet(valueSetUri);
        external(parameters);

        var second = TaskHelper.Await(() => _termService.ValueSetValidateCode(parameters.Build()));
        return second.GetSingleValue<FhirBoolean>("result")?.Value == true;
    }

    /// <inheritdoc />
    public bool TryGetCodesInValueSet(string valueSetUri, out IEnumerable<CqlCode>? codes)
    {
        codes = TaskHelper.Await(() => Load(valueSetUri));
        if (codes is not null) return true;

        if (_termService is not IExpandingTerminologyService ets) return false;

        var expansionParameters = new ExpandParameters().WithValueSet(valueSetUri).Build();

        try
        {
            var result = TaskHelper.Await(() => ets.Expand(expansionParameters));
            if (result is not ValueSet vs) return false;

            var facade = TaskHelper.Await(() => Add(vs));
            codes = facade;
            return true;
        }
        catch (FhirOperationException)
        {
            return false;
        }
    }
}

/// <summary>
/// Helper methods for constructing an <see cref="IValueSetDictionary"/> from a collection of <see cref="ValueSet"/>s.
/// </summary>
public static class ValueSetExtensions
{
    /// <summary>
    /// Construct a new <see cref="IValueSetDictionary"/> from the given <paramref name="values"/>.
    /// </summary>
    public static async Task<IValueSetDictionary> ToValueSetDictionaryAsync(this IEnumerable<ValueSet> values)
    {
        // Also make sure the valuesets are available via a resource resolver, so the ValueSetSource
        // can expand the valuesets by reaching out to this set.
        var valueSetResolver = new InMemoryResourceResolver(values);
        var result = new ValueSetSource(resourceResolver: valueSetResolver);
        _ = await result.Add(values).ConfigureAwait(false);

        return result;
    }

    /// <inheritdoc cref="ToValueSetDictionaryAsync"/>
    public static IValueSetDictionary ToValueSetDictionary(this IEnumerable<ValueSet> values)
    {
       return TaskHelper.Await(() => ToValueSetDictionaryAsync(values));
    }
}