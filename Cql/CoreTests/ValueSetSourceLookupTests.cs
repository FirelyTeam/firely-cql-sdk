/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Fhir;
using Hl7.Fhir.Model;
using Hl7.Fhir.Specification.Terminology;
using Task = System.Threading.Tasks.Task;

namespace CoreTests;

/// <summary>
/// A resolved value set carries a complete expansion, so it answers membership questions on its
/// own. Only an unknown value set is worth a terminology round-trip. These tests pin that split.
/// </summary>
[TestClass]
public class ValueSetSourceLookupTests
{
    private const string KnownValueSet = "http://example.org/ValueSet/known";
    private const string UnknownValueSet = "http://example.org/ValueSet/unknown";
    private const string CodeSystem = "http://snomed.info/sct";

    private static ValueSet KnownValueSetWithCodes(params string[] codes) =>
        new()
        {
            Url = KnownValueSet,
            Expansion = new ValueSet.ExpansionComponent
            {
                Contains = codes.Select(c => new ValueSet.ContainsComponent { System = CodeSystem, Code = c }).ToList()
            }
        };

    private static async Task<(ValueSetSource Source, SpyTerminologyService Spy)> CreateSource(ValueSet seed)
    {
        var spy = new SpyTerminologyService();
        var source = new ValueSetSource(resourceResolver: null, termService: spy);
        await source.Add(seed);
        return (source, spy);
    }

    [TestMethod]
    public async Task CodeInResolvedValueSet_ReturnsTrue_WithoutConsultingTerminologyService()
    {
        var (source, spy) = await CreateSource(KnownValueSetWithCodes("111", "222"));

        Assert.IsTrue(source.IsCodeInValueSet(KnownValueSet, "111", CodeSystem));
        Assert.AreEqual(0, spy.Calls, "A resolved value set must answer without a terminology round-trip.");
    }

    [TestMethod]
    public async Task CodeMissingFromResolvedValueSet_ReturnsFalse_WithoutConsultingTerminologyService()
    {
        var (source, spy) = await CreateSource(KnownValueSetWithCodes("111", "222"));

        Assert.IsFalse(source.IsCodeInValueSet(KnownValueSet, "999", CodeSystem));
        Assert.AreEqual(0, spy.Calls,
            "A miss in a completely expanded value set means 'not a member', not 'ask someone else'.");
    }

    [TestMethod]
    public async Task CodeOnlyOverload_OnResolvedValueSet_DoesNotThrow()
    {
        // The code-only overload cannot be expressed as a validate-code request (no system), so
        // reaching the terminology service with it threw. A resolved value set never reaches it.
        var (source, spy) = await CreateSource(KnownValueSetWithCodes("111"));

        Assert.IsTrue(source.IsCodeInValueSet(KnownValueSet, "111"));
        Assert.IsFalse(source.IsCodeInValueSet(KnownValueSet, "999"));
        Assert.AreEqual(0, spy.Calls);
    }

    [TestMethod]
    public async Task UnknownValueSet_FallsThroughToTerminologyService()
    {
        var (source, spy) = await CreateSource(KnownValueSetWithCodes("111"));

        // The spy answers 'true' for anything, so a true result proves it was consulted.
        Assert.IsTrue(source.IsCodeInValueSet(UnknownValueSet, "111", CodeSystem));
        Assert.AreEqual(1, spy.Calls, "An unresolvable value set is the one case worth a round-trip.");
    }

    [TestMethod]
    public async Task UnknownValueSet_WithoutTerminologyService_ReturnsFalse()
    {
        var source = new ValueSetSource(resourceResolver: null, termService: null);
        await source.Add(KnownValueSetWithCodes("111"));

        Assert.IsFalse(source.IsCodeInValueSet(UnknownValueSet, "111", CodeSystem));
    }

    [TestMethod]
    public async Task PartialExpansion_ByTotal_IsRejected()
    {
        var partial = KnownValueSetWithCodes("111", "222");
        partial.Expansion!.Total = 500; // server says there are 500 concepts; we hold 2

        var source = new ValueSetSource();

        var ex = await Assert.ThrowsExceptionAsync<InvalidOperationException>(() => source.Add(partial));
        StringAssert.Contains(ex.Message, "partial expansion");
    }

    [TestMethod]
    public async Task PartialExpansion_ByOffset_IsRejected()
    {
        var partial = KnownValueSetWithCodes("111", "222");
        partial.Expansion!.Offset = 100; // this is page 2 of a larger expansion

        var source = new ValueSetSource();

        var ex = await Assert.ThrowsExceptionAsync<InvalidOperationException>(() => source.Add(partial));
        StringAssert.Contains(ex.Message, "partial expansion");
    }

    [TestMethod]
    public async Task CompleteExpansion_WithMatchingTotal_IsAccepted()
    {
        var complete = KnownValueSetWithCodes("111", "222");
        complete.Expansion!.Total = 2;

        var source = new ValueSetSource();
        await source.Add(complete);

        Assert.IsTrue(source.IsCodeInValueSet(KnownValueSet, "222", CodeSystem));
    }

    [TestMethod]
    public async Task NestedExpansion_CountsTowardsTotal()
    {
        // 'total' counts every concept in the expansion, including nested ones.
        var nested = new ValueSet
        {
            Url = KnownValueSet,
            Expansion = new ValueSet.ExpansionComponent
            {
                Total = 3,
                Contains =
                [
                    new ValueSet.ContainsComponent
                    {
                        System = CodeSystem, Code = "parent",
                        Contains =
                        [
                            new ValueSet.ContainsComponent { System = CodeSystem, Code = "child-1" },
                            new ValueSet.ContainsComponent { System = CodeSystem, Code = "child-2" },
                        ]
                    }
                ]
            }
        };

        var source = new ValueSetSource();
        await source.Add(nested);

        Assert.IsTrue(source.IsCodeInValueSet(KnownValueSet, "child-2", CodeSystem));
    }

    /// <summary>Counts calls and approves everything, so any 'true' proves it was consulted.</summary>
    private sealed class SpyTerminologyService : ICodeValidationTerminologyService
    {
        public int Calls { get; private set; }

        public System.Threading.Tasks.Task<Parameters> ValueSetValidateCode(
            Parameters parameters, string? id = null, bool useGet = false)
        {
            Calls++;
            var result = new Parameters();
            result.Add("result", new FhirBoolean(true));
            return System.Threading.Tasks.Task.FromResult(result);
        }

        public System.Threading.Tasks.Task<Parameters> CodeSystemValidateCode(
            Parameters parameters, string? id = null, bool useGet = false) =>
            throw new NotSupportedException();

        public System.Threading.Tasks.Task<Parameters> Subsumes(
            Parameters parameters, string? id = null, bool useGet = false) =>
            throw new NotSupportedException();
    }
}
