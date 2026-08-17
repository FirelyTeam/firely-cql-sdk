/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Fhir;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;
using Hl7.Fhir.Specification.Source;
using Task = System.Threading.Tasks.Task;

namespace CoreTests;

/// <summary>
/// Building the facade for a <see cref="ValueSet"/> that already carries its expansion is a pure
/// function of that expansion, so <see cref="ValueSetSource"/> memoizes it process-wide against the
/// <see cref="ValueSet.ExpansionComponent"/>. These tests pin what that memo does and - just as
/// importantly - what it does not key on.
/// </summary>
[TestClass]
public class ValueSetSourceFacadeMemoTests
{
    private const string CodeSystem = "http://snomed.info/sct";

    private static ValueSet.ExpansionComponent ExpansionOf(params string[] codes) =>
        new()
        {
            Contains = codes.Select(c => new ValueSet.ContainsComponent { System = CodeSystem, Code = c }).ToList()
        };

    private static ValueSet ExpandedValueSet(string url, params string[] codes) =>
        new()
        {
            Url = url,
            Status = PublicationStatus.Active,
            Expansion = ExpansionOf(codes)
        };

    /// <summary>A valueset that has to be expanded, by pulling in an already expanded one.</summary>
    private static ValueSet ComposedValueSet(string url, string includedUrl) =>
        new()
        {
            Url = url,
            Status = PublicationStatus.Active,
            Compose = new ValueSet.ComposeComponent
            {
                Include = [new ValueSet.ConceptSetComponent { ValueSet = [includedUrl] }]
            }
        };

    [TestMethod]
    public async Task SameInstanceAddedToTwoSources_SharesTheSameFacade()
    {
        var vs = ExpandedValueSet("http://example.org/ValueSet/shared", "111", "222");

        var facadeA = await new ValueSetSource().Add(vs);
        var facadeB = await new ValueSetSource().Add(vs);

        Assert.AreSame(facadeA, facadeB,
            "the expansion an instance carries determines its facade completely, so the second source must reuse the first one's build.");
    }

    [TestMethod]
    public async Task FacadeFromMemo_AnswersMembershipThroughItsOwnSource()
    {
        const string url = "http://example.org/ValueSet/functional";
        var vs = ExpandedValueSet(url, "111", "222");

        var sourceA = new ValueSetSource();
        var sourceB = new ValueSetSource();

        await sourceA.Add(vs);
        var facadeB = await sourceB.Add(vs);

        // Source B answered from the memo, but the facade still has to land in B's own canonical
        // dictionary - that is what B's query methods look in.
        Assert.AreSame(facadeB, await sourceB.Add(vs));
        Assert.IsTrue(sourceB.IsCodeInValueSet(url, "111", CodeSystem));
        Assert.IsTrue(sourceB.IsCodeInValueSet(url, "222"));
        Assert.IsFalse(sourceB.IsCodeInValueSet(url, "999", CodeSystem));

        Assert.IsTrue(sourceB.TryGetCodesInValueSet(url, out var codes));
        CollectionAssert.AreEquivalent(new[] { "111", "222" }, codes!.Select(c => c.code).ToArray());
    }

    [TestMethod]
    public async Task InstancesSharingOneExpansion_ShareTheSameFacade()
    {
        // The facade is a pure function of the expansion, so the valueset it was reached through does
        // not matter - two instances (here even two canonicals) holding one component get one facade.
        // That is intended, not incidental: nothing but the expansion's concepts feeds into the build.
        var expansion = ExpansionOf("111", "222");
        var first = new ValueSet { Url = "http://example.org/ValueSet/sharing-a", Status = PublicationStatus.Active, Expansion = expansion };
        var second = new ValueSet { Url = "http://example.org/ValueSet/sharing-b", Status = PublicationStatus.Active, Expansion = expansion };

        var facadeA = await new ValueSetSource().Add(first);
        var facadeB = await new ValueSetSource().Add(second);

        Assert.AreSame(facadeA, facadeB);
    }

    [TestMethod]
    public async Task ReplacedExpansion_BuildsAFacadeFromTheNewExpansion()
    {
        // What keying on the expansion rather than on the valueset buys: a host that recomputes an
        // expansion into a *new* component on an instance it retains gets a new key, and therefore a
        // facade reflecting the replacement instead of the snapshot taken from the component before it.
        var vs = ExpandedValueSet("http://example.org/ValueSet/replaced", "111");

        var facadeBefore = await new ValueSetSource().Add(vs);
        Assert.IsTrue(facadeBefore.IsCodeInValueSet("111", CodeSystem));

        vs.Expansion = ExpansionOf("222");

        // The source that already answered for this canonical keeps its own answer - its per-source
        // dictionary is the only thing its queries consult - so the rebuild shows in a fresh source.
        var facadeAfter = await new ValueSetSource().Add(vs);

        Assert.AreNotSame(facadeBefore, facadeAfter);
        Assert.IsTrue(facadeAfter.IsCodeInValueSet("222", CodeSystem));
        Assert.IsFalse(facadeAfter.IsCodeInValueSet("111", CodeSystem));
    }

    [TestMethod]
    public async Task StructurallyIdenticalInstances_DoNotShareAFacade()
    {
        // The memo is keyed on the expansion's object identity, never on its content: two equal-looking
        // valuesets may still have been loaded from different places, and nothing here proves they agree.
        const string url = "http://example.org/ValueSet/twins";
        var first = ExpandedValueSet(url, "111", "222");
        var second = ExpandedValueSet(url, "111", "222");

        var facadeA = await new ValueSetSource().Add(first);
        var facadeB = await new ValueSetSource().Add(second);

        Assert.AreNotSame(facadeA, facadeB);
    }

    [TestMethod]
    public async Task ComputedExpansion_StaysPrivateToItsSource()
    {
        const string includedUrl = "http://example.org/ValueSet/memo-included";
        const string composedUrl = "http://example.org/ValueSet/memo-composed";

        var included = ExpandedValueSet(includedUrl, "111", "222");
        var composed = ComposedValueSet(composedUrl, includedUrl);
        var resolver = new InMemoryResourceResolver(included, composed);

        // No expansion at entry, so this source has to compute one - which depends on what its own
        // resolver can reach, and therefore must not be shared with any other source.
        var facadeA = await new ValueSetSource(resolver).Add(composed);
        var facadeB = await new ValueSetSource(resolver).Add(composed);

        Assert.AreNotSame(facadeA, facadeB);
        Assert.IsTrue(facadeA.IsCodeInValueSet("111", CodeSystem));
        Assert.IsTrue(facadeB.IsCodeInValueSet("111", CodeSystem));
    }

    [TestMethod]
    public async Task ComputedExpansion_IsWrittenIntoTheInstance_SoLaterSourcesShareIt()
    {
        const string includedUrl = "http://example.org/ValueSet/mutation-included";
        const string composedUrl = "http://example.org/ValueSet/mutation-composed";

        var included = ExpandedValueSet(includedUrl, "111", "222");
        var composed = ComposedValueSet(composedUrl, includedUrl);
        var resolver = new InMemoryResourceResolver(included, composed);

        _ = await new ValueSetSource(resolver).Add(composed);

        // Expansion happens in place, so from here on the instance carries one and every further
        // source takes the memo path. This is the pre-existing mutation showing through, not extra
        // staleness: those sources were already looking at the expansion frozen into the instance.
        Assert.IsTrue(composed.HasExpansion);

        var facadeB = await new ValueSetSource(resolver).Add(composed);
        var facadeC = await new ValueSetSource(resolver).Add(composed);

        Assert.AreSame(facadeB, facadeC);
    }

    [TestMethod]
    public async Task PartialExpansion_IsNeverMemoized_AndKeepsThrowing()
    {
        var partial = ExpandedValueSet("http://example.org/ValueSet/partial", "111", "222");
        partial.Expansion!.Total = 500; // the server holds 500 concepts; we hold 2

        var sourceA = new ValueSetSource();
        var sourceB = new ValueSetSource();

        // A throwing factory stores nothing in the memo, so every later attempt has to fail again
        // rather than find a facade built from a page of a larger expansion.
        await AssertRejectsPartialExpansion(() => sourceA.Add(partial));
        await AssertRejectsPartialExpansion(() => sourceA.Add(partial));
        await AssertRejectsPartialExpansion(() => sourceB.Add(partial));
    }

    [TestMethod]
    public async Task PartialExpansionByOffset_IsNeverMemoized_AndKeepsThrowing()
    {
        var partial = ExpandedValueSet("http://example.org/ValueSet/partial-offset", "111", "222");
        partial.Expansion!.Offset = 100; // this is page 2 of a larger expansion

        var sourceA = new ValueSetSource();
        var sourceB = new ValueSetSource();

        await AssertRejectsPartialExpansion(() => sourceA.Add(partial));
        await AssertRejectsPartialExpansion(() => sourceA.Add(partial));
        await AssertRejectsPartialExpansion(() => sourceB.Add(partial));
    }

    [TestMethod]
    public async Task FailedBuild_DoesNotOutliveTheFailure()
    {
        // The memo holds a Lazy, and a Lazy caches its exception - so a failed build has to be
        // evicted, or the expansion would keep throwing the *old* exception even after it became
        // complete. Eviction is the only thing that can make the retry succeed here, because the
        // healing edit deliberately leaves the key alone: Total moves on the very same
        // ExpansionComponent, so no new key can be doing the work instead.
        var vs = ExpandedValueSet("http://example.org/ValueSet/healed", "111", "222");
        var expansion = vs.Expansion!;
        expansion.Total = 500;

        var source = new ValueSetSource();
        await AssertRejectsPartialExpansion(() => source.Add(vs));

        expansion.Total = 2;
        Assert.AreSame(expansion, vs.Expansion, "the memo key has to be unchanged, or this passes without any eviction.");

        var facade = await source.Add(vs);
        Assert.IsTrue(facade.IsCodeInValueSet("111", CodeSystem));
    }

    [TestMethod]
    public async Task ConcurrentSources_ConvergeOnOneFacade()
    {
        var vs = ExpandedValueSet("http://example.org/ValueSet/contended", "111", "222");
        var before = Volatile.Read(ref ValueSetSource.BuildFromExpansionCount);

        var facades = await Task.WhenAll(Enumerable.Range(0, 16).Select(_ => Task.Run(() => new ValueSetSource().Add(vs))));

        foreach (var facade in facades)
            Assert.AreSame(facades[0], facade, "every source racing on the same expansion must end up with the single retained facade.");

        Assert.AreEqual(1, Volatile.Read(ref ValueSetSource.BuildFromExpansionCount) - before,
            "the Lazy exists so exactly one racer runs the expensive build; agreeing on one result is what the bare table already did.");
    }

    private static async Task AssertRejectsPartialExpansion(Func<Task<IValueSetFacade>> add)
    {
        var ex = await Assert.ThrowsExceptionAsync<InvalidOperationException>(add);
        StringAssert.Contains(ex.Message, "partial expansion");
    }
}
