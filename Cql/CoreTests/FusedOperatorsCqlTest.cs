/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime;

namespace CoreTests;

/// <summary>
/// End-to-end coverage for operator fusion (issue #1484): CQL in
/// <c>Input/ELM/HL7/FusedOperatorsTest.cql</c> whose generated C# contains all four fused
/// operators, executed here for its real results.
///
/// <para><see cref="FusedOperatorTests"/> calls the runtime operators directly and
/// <see cref="CqlOperatorsBinderFusionTests"/> asserts on the rewritten IR; neither proves that
/// the compiler and the runtime agree on a library that was actually generated. Only
/// <c>SelectDistinct</c> occurs in the rest of this repository's generated corpus — every
/// <c>WhereAny</c>, <c>WhereSelect</c> and <c>SelectWhere</c> call site lives in
/// <c>Demo/Measures.dqm-content-qicore-2025</c>, which is outside <c>Cql-Sdk.slnf</c> and whose
/// runtime tests live in a private submodule. This fixture is what makes a regression in those
/// three fail a build a public-repo contributor can run.</para>
/// </summary>
[TestClass]
[TestCategory("UnitTest")]
public class FusedOperatorsCqlTest
{
    private static FusedOperatorsTest_1_0_0 Library => FusedOperatorsTest_1_0_0.Instance;

    private static CqlContext Context() => FhirCqlContext.ForBundle();

    /// <summary><c>exists (Numbers N where N &gt; 4)</c>, which the compiler emits as <c>WhereAny</c>.</summary>
    [TestMethod]
    public void AnyGreaterThanFour_IsTrue()
    {
        Assert.AreEqual(true, Library.AnyGreaterThanFour(Context()));
    }

    /// <summary>
    /// <c>Numbers N where N mod 2 = 0 return all N * 10</c>, emitted as <c>WhereSelect</c>.
    /// <c>return all</c> keeps the duplicate, so a silently distinct-ing implementation fails here.
    /// </summary>
    [TestMethod]
    public void TenTimesEvens_KeepsEveryMatchingElementInSourceOrder()
    {
        CollectionAssert.AreEqual(
            new int?[] { 20, 40, 20 },
            Library.TenTimesEvens(Context())!.ToArray());
    }

    /// <summary><c>(Numbers N return all N * 2) D where D &gt; 6</c>, emitted as <c>SelectWhere</c>.</summary>
    [TestMethod]
    public void DoublesOverSix_FiltersOnTheProjectedValue()
    {
        CollectionAssert.AreEqual(
            new int?[] { 8, 10 },
            Library.DoublesOverSix(Context())!.ToArray());
    }

    /// <summary>
    /// <c>Numbers N return N * N</c> — a CQL return clause is distinct by default, which the
    /// compiler emits as <c>SelectDistinct</c>. 2 and 3 occur twice in the source, so their squares
    /// must appear once each, at the position of their first occurrence.
    /// </summary>
    [TestMethod]
    public void DistinctSquares_DropsRepeatedProjections()
    {
        CollectionAssert.AreEqual(
            new int?[] { 1, 4, 9, 16, 25 },
            Library.DistinctSquares(Context())!.ToArray());
    }

    /// <summary>
    /// The results above would still hold if fusion stopped firing and the composed operators were
    /// emitted instead, so this pins the emitted shape as well: regenerating the fixture's C# from
    /// its ELM must produce the four fused calls and leave no unfused producer behind.
    /// </summary>
    [TestMethod]
    public void GeneratedCSharp_UsesAllFourFusedOperators()
    {
        LibrarySet librarySet = new();
        librarySet.LoadLibraryAndDependencies(new DirectoryInfo("Input/ELM/HL7"), "FusedOperatorsTest", "1.0.0");

        var generated = new ElmToolkit()
            .AddElmLibraries(librarySet)
            .CompileToAssemblies()
            .GetElmToCSharpResults()
            .Single()
            .cSharp;

        foreach (var fused in new[] { "WhereAny", "WhereSelect", "SelectWhere", "SelectDistinct" })
            StringAssert.Contains(generated, $"context.Operators.{fused}<", $"Expected a fused {fused} call.");

        foreach (var composed in new[] { "Where", "Select", "Exists", "Distinct" })
            Assert.IsFalse(
                generated.Contains($"context.Operators.{composed}<"),
                $"An unfused {composed} call survived; every producer in this fixture is immediately consumed.");
    }
}
