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
/// function of that instance, so <see cref="ValueSetSource"/> memoizes it process-wide against the
/// instance. These tests pin what that memo does and - just as importantly - what it does not key on.
/// </summary>
[TestClass]
public class ValueSetSourceFacadeMemoTests
{
    private const string CodeSystem = "http://snomed.info/sct";

    private static ValueSet ExpandedValueSet(string url, params string[] codes) =>
        new()
        {
            Url = url,
            Status = PublicationStatus.Active,
            Expansion = new ValueSet.ExpansionComponent
            {
                Contains = codes.Select(c => new ValueSet.ContainsComponent { System = CodeSystem, Code = c }).ToList()
            }
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
            "an expansion-carrying instance determines its facade completely, so the second source must reuse the first one's build.");
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
    public async Task StructurallyIdenticalInstances_DoNotShareAFacade()
    {
        // The memo is keyed on object identity, never on content: two equal-looking valuesets may
        // still have been loaded from different places, and nothing here proves they agree.
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

    private static async Task AssertRejectsPartialExpansion(Func<Task<IValueSetFacade>> add)
    {
        var ex = await Assert.ThrowsExceptionAsync<InvalidOperationException>(add);
        StringAssert.Contains(ex.Message, "partial expansion");
    }
}
