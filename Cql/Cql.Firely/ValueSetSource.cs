/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using System.Runtime.CompilerServices;
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
/// <remarks>
/// <para>
/// Aggressively caches the loaded valuesets to improve performance, in two layers.
/// </para>
/// <para>
/// The first layer is per-source: a dictionary from canonical to facade, which is what every query
/// method looks in. It alone determines what this source answers.
/// </para>
/// <para>
/// The second layer is process-wide: a memo of facades keyed on the
/// <see cref="ValueSet.ExpansionComponent"/> a valueset carries. Building a facade is a pure function
/// of that expansion - nothing else about the valueset feeds into it - so two sources handed the same
/// component can share the result instead of each materializing and hashing every code in it again.
/// The memo only ever hits when the resolver returns the same expansion object again: a host with an
/// instance-stable resolver (a conformance cache, for instance) hits it on every request, while a host
/// without one loses nothing, since a fresh instance carries a fresh expansion and simply builds the
/// way it always did. Entries are held under weak keys, so they live exactly as long as the host keeps
/// the expansion alive - the memo needs no bounds and no invalidation of its own.
/// </para>
/// <para>
/// Being a process-wide static under weak keys, rather than a cache the host configures and injects, is
/// what buys that inherited invalidation. An entry lives exactly as long as the resolver keeps the
/// expansion it was keyed on alive, so when a host's conformance cache evicts or replaces a valueset,
/// the expansion arriving in its place misses the memo and the entry built from the old one dies with
/// the object it hung on: there is nothing to wire up, nothing to clear, and no state in which a stale
/// facade is served for a canonical. A host that wants lifetime and scoping under its own control does
/// not need the memo to offer them - it can seed each source through
/// <see cref="Add(string, IEnumerable{CqlCode})"/> with a facade it holds onto, which reuses the hashed
/// contents rather than rebuilding them (see <see cref="InMemoryValueSet"/>) - at the price of owning
/// the invalidation that such a lifetime brings with it.
/// </para>
/// <para>
/// Keying on the expansion rather than on the valueset instance is what makes the contract tractable,
/// and that contract is:
/// </para>
/// <list type="bullet">
/// <item>
/// A memoized facade is a snapshot of the expansion as it looked when the facade was built from it.
/// </item>
/// <item>
/// <em>Replacing</em> <see cref="ValueSet.Expansion"/> on a retained instance is honored: the
/// replacement is a different key, so the next <see cref="Add(ValueSet)"/> builds a facade from it.
/// Handing out a copy of the whole valueset (the FHIR SDK's <c>DeepCopy</c>) works for the same reason.
/// </item>
/// <item>
/// Editing an expansion <em>in place</em> after a facade was successfully built from it - appending to
/// <c>Contains</c>, moving <c>Total</c> - is not observed, because the key did not change and the
/// facade built from it is retained. That is not an assumption this class invents: a resolver that
/// hands the same expansion to many consumers already forbids editing it, since every consumer, cache
/// or no cache, would be looking at whatever the last writer left behind.
/// </item>
/// <item>
/// Editing an expansion after a build <em>failed</em> on it - a partial expansion completed after the
/// fact - is honored, because a failed build retains nothing: the entry is evicted and the next
/// attempt reads the expansion afresh (see <see cref="GetOrBuildMemoized"/>).
/// </item>
/// </list>
/// <para>
/// A valueset that arrives without an expansion is expanded here instead, and that expansion depends
/// on the CodeSystems and valuesets this source's resolver can reach - things the valueset alone does
/// not determine - so its facade stays in the per-source layer only. The expansion is computed on a
/// private copy of the valueset: the instance handed in is on loan - on the <see cref="Load"/> path it
/// belongs to the resolver, which may be serving the same object to every consumer in the process -
/// and the underlying expander writes into its argument (and clears the expansion on failure), so
/// running it on the original would edit, or on failure damage, an object this class does not own.
/// This class therefore never modifies the valueset handed to <see cref="Add(ValueSet)"/> or resolved
/// by <see cref="Load"/>. The copy does not reach further: the expander pulls <c>compose.include</c>
/// dependencies from the resolver on its own and still expands an expansion-less <em>included</em>
/// valueset in place - that is the expander's own behavior, tracked upstream as adjacent defect B of
/// <see href="https://github.com/FirelyTeam/firely-net-sdk/issues/3582"/>. A cache serving an
/// expansion-less valueset that another valueset includes is therefore still written to through that
/// path, and still loses its expansion if that expansion fails. The price of the copy is that
/// another source handed the same expansion-less instance expands its own copy rather than finding an
/// expansion already written; each source still expands a given canonical at most once, through its
/// per-canonical facade layer, and a host that wants cross-source reuse can serve valuesets with
/// static expansions or seed sources via <see cref="Add(string, IEnumerable{CqlCode})"/>.
/// </para>
/// </remarks>
public class ValueSetSource : IValueSetDictionary
{
    private static readonly IEqualityComparer<CqlCode> OrdinalIgnoreCaseEqualityComparer = CqlCodeCqlComparer.OrdinalIgnoreCase.ToEqualityComparer();

    /// <summary>
    /// The process-wide, second cache layer described in the remarks on this class: the facade built
    /// from the <see cref="ValueSet.ExpansionComponent"/> a resolved valueset carries, memoized against
    /// that component under a weak key.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The value is a <see cref="Lazy{T}"/> rather than the facade itself because
    /// <see cref="ConditionalWeakTable{TKey,TValue}.GetValue"/> does not serialize its factory: under
    /// contention it may run the factory on several threads and keep one result (see the note on
    /// <c>LibrarySetInvokerPoolKey.GetOrComputeContentHash</c>). Racing the factory is fine when it is
    /// cheap and pure, but this factory is the expensive materialization the memo exists to avoid, so
    /// the table races only on creating the wrapper and every caller then joins the single build
    /// inside the one retained <see cref="Lazy{T}"/>.
    /// </para>
    /// <para>
    /// What that wrapper holds is a <see cref="Task{TResult}"/>, started with <c>Task.Run</c>, so the
    /// racers that lose await the build instead of blocking a thread on it.
    /// <see cref="Add(ValueSet)"/> is reached from <c>Parallel.ForEachAsync</c> and from a server's
    /// request path, where a cold valueset would otherwise park every racer but one on a pool thread and
    /// have the pool inject more to replace them. The price is one <c>Task.Run</c> per cold build, paid
    /// once per expansion; the lazy's own lock is held only long enough to start that task.
    /// </para>
    /// <para>
    /// The factory closes over the valueset the expansion was reached through - it needs its
    /// <see cref="ValueSet.Url"/> for error messages - and hence over the key itself, since the
    /// valueset holds the expansion. Inside a <see cref="ConditionalWeakTable{TKey,TValue}"/> that is
    /// harmless: the table links a value to its key through a <c>DependentHandle</c>, so an entry whose
    /// key is unreachable from outside the table is collected no matter what its value points at. The
    /// closure does not outlive the build either: a <see cref="Lazy{T}"/> drops its factory once it has
    /// produced its value, and a task drops its delegate once it settles - both so that holding the
    /// cached object alive does not also hold its closure alive - which leaves an entry that is the
    /// facade and no path back to the source that happened to build it.
    /// </para>
    /// </remarks>
    private static readonly ConditionalWeakTable<ValueSet.ExpansionComponent, Lazy<Task<InMemoryValueSet>>> FacadesByExpansion = new();

    /// <summary>
    /// Counts calls to <see cref="BuildFromExpansion"/>, so tests can pin that racing sources run the
    /// build exactly once rather than merely agreeing on one result.
    /// </summary>
    internal static int BuildFromExpansionCount;

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
    /// The instance is not modified: an expansion this source has to compute is computed on a private
    /// copy. See the remarks on this class.
    /// </summary>
    public async Task<IValueSetFacade> Add(ValueSet vs)
    {
        if(vs.Url is null) throw new ArgumentException("ValueSet must have a URL to be added to the cache.", nameof(vs));

        if (_valueSets.TryGetValue(vs.Url, out var valueSet)) return valueSet;

        // Not cached yet, build it first.
        var newVs = await build(vs).ConfigureAwait(false);

        // Add it, or return whatever was in the cache by now. If we were pre-empted, this might be
        // another instance than ours.
        return _valueSets.GetOrAdd(vs.Url, newVs);

        async Task<InMemoryValueSet> build(ValueSet vs)
        {
            // An expansion that arrives with the valueset determines the facade completely, so the
            // build is a pure function of that expansion and can be memoized against it.
            if (vs.HasExpansion)
                return await GetOrBuildMemoized(vs).ConfigureAwait(false);

            // Without an expansion we have to compute one, and what that yields depends on the
            // CodeSystems and valuesets this source's resolver can reach. The memo key cannot see any
            // of that, so this facade stays private to this source.
            //
            // The expander writes the expansion it computes into its argument (and nulls it on
            // failure), while the instance we hold is on loan: on the Load path it belongs to the
            // resolver, which may be handing the very same object to every consumer in the process.
            // The expansion is only needed to build the facade, so it is computed on a private copy
            // and the caller's instance stays untouched, success or failure.
            var copy = (ValueSet)vs.DeepCopy();
            var expander = BuildExpander();
            await expander.ExpandAsync(copy).ConfigureAwait(false);

            return BuildFromExpansion(copy);
        }
    }

    /// <summary>
    /// Returns the memoized facade for the expansion carried by <paramref name="vs"/>, building it
    /// exactly once per <see cref="ValueSet.ExpansionComponent"/> across all sources.
    /// </summary>
    /// <remarks>
    /// Only reached where <see cref="ValueSet.HasExpansion"/> holds, which is exactly where
    /// <see cref="ValueSet.Expansion"/> - the key - is non-null. Sources racing on the same expansion
    /// meet inside one retained <see cref="Lazy{T}"/> (see the remarks on
    /// <see cref="FacadesByExpansion"/>), so exactly one of them runs the build and the others await its
    /// task. A build that fails - a partial expansion - must not stick, though: the
    /// <see cref="Lazy{T}"/> retains the faulted task just as surely as it would have retained a thrown
    /// exception, so the entry is dropped from the table on failure and the next attempt starts fresh.
    /// Concurrent awaiters of the failed build still observe its fault, which is correct - they were
    /// asking about the same expansion in the same state.
    /// </remarks>
    private async Task<InMemoryValueSet> GetOrBuildMemoized(ValueSet vs)
    {
        var expansion = vs.Expansion!;

        // The factory keeps vs, not just the expansion, so a partial expansion can name the valueset it
        // came from in its error message. Task.Run is spelled out in full because Hl7.Fhir.Model, which
        // this file has in scope, carries a Task resource of its own.
        var lazyFacade = FacadesByExpansion.GetValue(
            expansion,
            _ => new Lazy<Task<InMemoryValueSet>>(() => System.Threading.Tasks.Task.Run(() => BuildFromExpansion(vs))));

        try
        {
            return await lazyFacade.Value.ConfigureAwait(false);
        }
        catch
        {
            // Another thread may already have replaced the failed entry with a fresh one; evicting
            // that would throw away a good build. Only drop the wrapper that actually failed.
            if (FacadesByExpansion.TryGetValue(expansion, out var current) && ReferenceEquals(current, lazyFacade))
                FacadesByExpansion.Remove(expansion);
            throw;
        }
    }

    /// <summary>
    /// Builds the immutable facade for a <see cref="ValueSet"/> that holds an expansion.
    /// </summary>
    /// <remarks>
    /// The codes are interned into this source's table (see <see cref="Intern"/>), so a memoized facade
    /// can hand out <see cref="CqlCode"/> instances owned by whichever source happened to build it
    /// first. Membership <em>through <see cref="IValueSetFacade"/></em> is decided by a comparer and
    /// never by reference, so a shared facade answers those queries exactly as a private one would.
    /// Interning is not equally inert on the <see cref="IEnumerable{T}"/> surface:
    /// <see cref="CqlCode"/> is a record, so LINQ over the facade compares ordinal and case-sensitively,
    /// while the intern table uses <see cref="CqlCodeCqlComparer.OrdinalIgnoreCase"/> - interning has
    /// been collapsing case-variant codes into one object, and a memoized facade no longer interns into
    /// the source that reads it. What it does mean is that two facades held by one source need not
    /// intern into the same table, so the same code reached through two of its valuesets is not
    /// guaranteed to be one object; compare codes with a comparer, never by reference.
    /// The codes are materialized here rather than left as a deferred query, so the facade that comes
    /// out holds a reference neither to this source nor to <paramref name="vs"/> - it is the snapshot of
    /// the expansion that the memo hands to every later caller, not a window onto it.
    /// </remarks>
    private InMemoryValueSet BuildFromExpansion(ValueSet vs)
    {
        Interlocked.Increment(ref BuildFromExpansionCount);

        // A cached value set answers membership questions definitively, so a partial
        // expansion must not be cached: it would turn "this page does not contain the
        // code" into "this value set does not contain the code". An expansion we build
        // ourselves is always complete (the expander throws otherwise); one that arrived
        // with the resource may be a page of a larger result.
        EnsureCompleteExpansion(vs);

        var codes = ToCodes(vs.Expansion!.Contains).ToList();
        return new InMemoryValueSet(codes);
    }

    /// <summary>
    /// Given a canonical, returns the <see cref="IValueSetFacade"/> for that canonical from the
    /// cache, or uses the resolver to load it. The resolved instance is not modified; see the remarks
    /// on this class.
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

    /// <summary>
    /// Rejects an expansion that is only a page of a larger result, identified by a non-zero
    /// <c>offset</c> or a <c>total</c> that exceeds the number of concepts actually present.
    /// </summary>
    /// <exception cref="InvalidOperationException">The expansion is partial.</exception>
    private static void EnsureCompleteExpansion(ValueSet vs)
    {
        var expansion = vs.Expansion;
        if (expansion is null) return;

        if (expansion.Offset is > 0)
            throw new InvalidOperationException(
                $"ValueSet '{vs.Url}' carries a partial expansion (offset {expansion.Offset}); " +
                "only a completely expanded value set can be cached.");

        if (expansion.Total is { } total)
        {
            var present = CountConcepts(expansion.Contains);
            if (total > present)
                throw new InvalidOperationException(
                    $"ValueSet '{vs.Url}' carries a partial expansion ({present} of {total} concepts); " +
                    "only a completely expanded value set can be cached.");
        }
    }

    private static int CountConcepts(IEnumerable<ValueSet.ContainsComponent>? contains) =>
        contains?.Sum(c => 1 + CountConcepts(c.Contains)) ?? 0;

    private IEnumerable<CqlCode> ToCodes(IEnumerable<ValueSet.ContainsComponent> expansion) =>
        expansion.SelectMany(c => ToCodes(c.Contains).Prepend(Intern(new CqlCode(c.Code, c.System, c.Version, c.Display))));

    // A membership test against an already-loaded value set is the overwhelmingly common case, and
    // it needs neither of the lambdas that CheckInternalAndExternalTs takes. Those lambdas capture
    // the code, so merely *mentioning* them in this method would make the compiler allocate their
    // display class on entry - before any early return could skip it. The unresolved path therefore
    // lives in its own method, which keeps the resolved path allocation-free.

    /// <inheritdoc />
    public bool IsCodeInValueSet(string valueSetUri, CqlCode code) =>
        _valueSets.TryGetValue(valueSetUri, out var cached)
            ? cached.IsCodeInValueSet(code)
            : ResolveThenCheck(valueSetUri, code);

    private bool ResolveThenCheck(string valueSetUri, CqlCode code) =>
        CheckInternalAndExternalTs(valueSetUri,
            vs => vs.IsCodeInValueSet(code),
            pb => pb.WithCoding(new Coding(code.system, code.code, code.display) { Version = code.version }));

    /// <inheritdoc />
    public bool IsCodeInValueSet(string valueSetUri, string code) =>
        _valueSets.TryGetValue(valueSetUri, out var cached)
            ? cached.IsCodeInValueSet(code)
            : ResolveThenCheck(valueSetUri, code);

    private bool ResolveThenCheck(string valueSetUri, string code) =>
        CheckInternalAndExternalTs(valueSetUri,
                                   vs => vs.IsCodeInValueSet(code),
                                   pb => pb.WithCode(code));

    /// <inheritdoc />
    public bool IsCodeInValueSet(string valueSetUri, string code, string? system) =>
        _valueSets.TryGetValue(valueSetUri, out var cached)
            ? cached.IsCodeInValueSet(code, system)
            : ResolveThenCheck(valueSetUri, code, system);

    private bool ResolveThenCheck(string valueSetUri, string code, string? system) =>
        CheckInternalAndExternalTs(valueSetUri,
                                   vs => vs.IsCodeInValueSet(code, system),
                                   pb => pb.WithCode(code, system));

    private bool CheckInternalAndExternalTs(
        string valueSetUri,
        Predicate<IValueSetFacade> @internal,
        Action<ValidateCodeParameters> external)
    {
        // Every caller reaches this only after missing the cache, and Load re-checks it anyway,
        // so there is no warm path left to shortcut here.
        var resolved = TaskHelper.Await(() => Load(valueSetUri));

        // A resolved value set carries a complete expansion (an expansion that could not be
        // completed throws in Add and is never cached), so it answers definitively: a miss
        // means "this code is not in this value set", not "ask someone else".
        if (resolved is not null)
            return @internal(resolved);

        // Only an *unknown* value set is worth a terminology round-trip.
        if (_termService is null) return false;

        var parameters = new ValidateCodeParameters()
            .WithValueSet(valueSetUri);
        external(parameters);

        var second = TaskHelper.Await(() => _termService.ValueSetValidateCode(parameters.DeepCopy()));
        return second.GetSingleValue<FhirBoolean>("result")?.Value == true;
    }

    /// <inheritdoc />
    public bool TryGetCodesInValueSet(string valueSetUri, out IEnumerable<CqlCode>? codes)
    {
        // Fast path: a warm cache hit does not need the sync-over-async machinery in Load.
        if (_valueSets.TryGetValue(valueSetUri, out var cachedValueSet))
        {
            codes = cachedValueSet;
            return true;
        }

        codes = TaskHelper.Await(() => Load(valueSetUri));
        if (codes is not null) return true;

        if (_termService is not IExpandingTerminologyService ets) return false;

        var expansionParameters = new ExpandParameters().WithValueSet(valueSetUri).DeepCopy();

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
