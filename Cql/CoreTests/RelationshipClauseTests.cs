/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Runtime;

namespace CoreTests;

/// <summary>
/// Tests for the query 'with'/'without' relationship clauses (see issues #1366 and #1669).
/// A 'with' is a semi-join and a 'without' an anti-semi-join: each source element must be
/// emitted at most once, no matter how many related elements satisfy the 'such that' condition,
/// and duplicates in the source must be preserved. Every element of a related list takes part,
/// null elements included, while a null singleton related source relates to nothing.
/// </summary>
[TestClass]
public class RelationshipClauseTests
{
    private static LibrarySetInvoker _invoker = null!;
    private static CqlVersionedLibraryIdentifier _libraryIdentifier;

    [ClassInitialize]
    public static void Initialize(TestContext context)
    {
        var cqlLibrary = CqlLibraryString.Parse(
            """
            library RelationshipClauseTest version '1.0.0'

            define "Sources": { 1, 2, 3 }
            define "SourcesWithDuplicates": { 1, 1, 3 }
            define "Related": { 10, 20, 30 }

            // 1 matches 20 and 30, 2 matches 10, 3 matches nothing
            define "With Clause":
              "Sources" S
                with "Related" R
                  such that (S = 1 and R > 10) or (S = 2 and R = 10)

            define "Without Clause":
              "Sources" S
                without "Related" R
                  such that (S = 1 and R > 10) or (S = 2 and R = 10)

            define "With Clause Preserves Duplicates":
              "SourcesWithDuplicates" S
                with "Related" R
                  such that R = 10 * S

            define "Without Clause Preserves Duplicates":
              "SourcesWithDuplicates" S
                without "Related" R
                  such that R = 100 * S

            define "Multiple With Clauses":
              "Sources" S
                with "Related" R1
                  such that R1 = 10 * S
                with "Related" R2
                  such that R2 > 10 * S

            define "With Clause Promotes Singleton Source":
              from "Sources" S
                with (10 * S) R
                  such that R = 10 * S

            define "Multi Source With Clause":
              from
                "Sources" S,
                "Related" T
                with "Related" R
                  such that R = T and R = 10 * S
                return T

            define "Source": { 1 }

            define "With Null Related": "Source" S with ({ null as Integer }) R such that R is null
            define "Without Null Related": "Source" S without ({ null as Integer }) R such that R is null
            define "With Null Singleton": "Source" S with (null as Integer) R such that R is null
            define "Without Null Singleton": "Source" S without (null as Integer) R such that R is null

            define "With Non-Null Related": "Source" S with ({ 2 }) R such that R is null
            define "Without Non-Null Related": "Source" S without ({ 2 }) R such that R is null
            define "With Non-Null Singleton": "Source" S with (2) R such that R = 2
            define "Without Non-Null Singleton": "Source" S without (2) R such that R = 2

            define "With Null Related Such That Null": "Source" S with ({ null as Integer }) R such that R > 0
            define "Without Null Related Such That Null": "Source" S without ({ null as Integer }) R such that R > 0

            define "With Null List": "Source" S with (null as List<Integer>) R such that true
            define "Without Null List": "Source" S without (null as List<Integer>) R such that true

            define function "Event For"(S Integer):
              if S = 1 then null as Integer else 10 * S

            // 1 has no event, whose null case the condition accepts; 2's event is on the cutoff, 3's after it
            define "With Singleton List From Nullable Function":
              "Sources" S
                with ({ "Event For"(S) }) E
                  such that E is null or E <= 20
            """);
        _libraryIdentifier = cqlLibrary.LibraryIdentifier;
        _invoker = new CqlToolkit()
                   .AddCqlLibraries(cqlLibrary)
                   .CreateLibrarySetInvoker();
    }

    [ClassCleanup]
    public static void Cleanup()
    {
        _invoker?.Dispose();
    }

    private static IEnumerable<int?> Invoke(string definition) =>
        ((IEnumerable<int?>)_invoker.InvokeLibraryDefinition(FhirCqlContext.ForBundle(), _libraryIdentifier, definition)!);

    [TestMethod]
    public void With_EmitsEachSourceElementAtMostOnce()
    {
        // Element 1 has two matching related elements but must be emitted only once.
        Invoke("With Clause").Should().Equal(1, 2);
    }

    [TestMethod]
    public void Without_KeepsOnlySourceElementsWithNoMatch()
    {
        Invoke("Without Clause").Should().Equal(3);
    }

    [TestMethod]
    public void With_PreservesDuplicateSourceElements()
    {
        // Both 1s match related element 10 and must both be kept.
        Invoke("With Clause Preserves Duplicates").Should().Equal(1, 1, 3);
    }

    [TestMethod]
    public void Without_PreservesDuplicateSourceElements()
    {
        // Nothing matches, so the whole source survives, including the duplicate.
        Invoke("Without Clause Preserves Duplicates").Should().Equal(1, 1, 3);
    }

    [TestMethod]
    public void MultipleWiths_ApplyEachExistenceFilterOnce()
    {
        // 1 matches R1 = 10 and R2 in { 20, 30 }; 2 matches R1 = 20 and R2 = 30; 3 matches R1 = 30 but no R2.
        Invoke("Multiple With Clauses").Should().Equal(1, 2);
    }

    [TestMethod]
    public void With_PromotesSingletonRelationshipSource()
    {
        Invoke("With Clause Promotes Singleton Source").Should().Equal(1, 2, 3);
    }

    [TestMethod]
    public void With_InMultiSourceQuery_UsesOuterAliases()
    {
        Invoke("Multi Source With Clause").Should().Equal(10, 20, 30);
    }

    [TestMethod]
    public void With_NullRelatedElementSatisfyingSuchThat_KeepsSourceElement()
    {
        Invoke("With Null Related").Should().Equal(1);
    }

    [TestMethod]
    public void Without_NullRelatedElementSatisfyingSuchThat_DropsSourceElement()
    {
        Invoke("Without Null Related").Should().BeEmpty();
    }

    [TestMethod]
    public void With_NullSingletonRelatedSource_RelatesToNothing()
    {
        // A null singleton is an empty related source, not a list holding one null element.
        Invoke("With Null Singleton").Should().BeEmpty();
    }

    [TestMethod]
    public void Without_NullSingletonRelatedSource_RelatesToNothing()
    {
        Invoke("Without Null Singleton").Should().Equal(1);
    }

    [TestMethod]
    public void With_NonNullRelatedElementNotSatisfyingSuchThat_DropsSourceElement()
    {
        Invoke("With Non-Null Related").Should().BeEmpty();
    }

    [TestMethod]
    public void Without_NonNullRelatedElementNotSatisfyingSuchThat_KeepsSourceElement()
    {
        Invoke("Without Non-Null Related").Should().Equal(1);
    }

    [TestMethod]
    public void With_NonNullSingletonSatisfyingSuchThat_KeepsSourceElement()
    {
        Invoke("With Non-Null Singleton").Should().Equal(1);
    }

    [TestMethod]
    public void Without_NonNullSingletonSatisfyingSuchThat_DropsSourceElement()
    {
        Invoke("Without Non-Null Singleton").Should().BeEmpty();
    }

    [TestMethod]
    public void With_NullRelatedElementWhoseSuchThatIsNull_DropsSourceElement()
    {
        // Only a true condition relates; null does not.
        Invoke("With Null Related Such That Null").Should().BeEmpty();
    }

    [TestMethod]
    public void Without_NullRelatedElementWhoseSuchThatIsNull_KeepsSourceElement()
    {
        Invoke("Without Null Related Such That Null").Should().Equal(1);
    }

    [TestMethod]
    public void With_NullRelatedList_RelatesToNothing()
    {
        Invoke("With Null List").Should().BeEmpty();
    }

    [TestMethod]
    public void Without_NullRelatedList_RelatesToNothing()
    {
        Invoke("Without Null List").Should().Equal(1);
    }

    [TestMethod]
    public void With_SingletonListOfNullableFunctionResult_LetsSuchThatHandleTheNullCase()
    {
        Invoke("With Singleton List From Nullable Function").Should().Equal(1, 2);
    }

    /// <summary>
    /// A relationship clause over a list source is emitted as <c>AnyRelated</c>, which counts null
    /// elements. The results above would not tell a regression back to <c>WhereAny</c> apart for
    /// source elements with only non-null related elements, so the emitted shape is pinned too.
    /// </summary>
    [TestMethod]
    public void GeneratedCSharp_ListRelatedSource_UsesAnyRelated()
    {
        var generated = GenerateCSharp(
            """
            library RelationshipClauseListShape version '1.0.0'

            define "With": ({ 1 }) S with ({ 1, null }) R such that R is null
            define "Without": ({ 1 }) S without ({ 1, null }) R such that R is null
            """);

        generated.Should().Contain("context.Operators.AnyRelated<");
        generated.Should().NotContain("context.Operators.WhereAny<");
    }

    /// <summary>
    /// A singleton related source is tested with <c>Exists</c> semantics (fused to
    /// <c>WhereAny</c>), which makes a null singleton relate to nothing; an author's own
    /// <c>exists (X where c)</c> keeps its <c>WhereAny</c> fusion.
    /// </summary>
    [TestMethod]
    public void GeneratedCSharp_SingletonRelatedSourceAndExplicitExists_UseWhereAny()
    {
        var generated = GenerateCSharp(
            """
            library RelationshipClauseSingletonShape version '1.0.0'

            define "With Singleton": ({ 1 }) S with (2) R such that R = 2
            define "Exists Where": exists (({ 1, null }) X where X is null)
            """);

        generated.Should().Contain("context.Operators.WhereAny<");
        generated.Should().NotContain("context.Operators.AnyRelated<");
    }

    [TestMethod]
    public void ExplicitExistsWhere_IgnoresNullElements()
    {
        var library = CqlLibraryString.Parse(
            """
            library RelationshipClauseExists version '1.0.0'

            define "Exists Where": exists (({ 1, null }) X where X is null)
            """);
        using var invoker = new CqlToolkit()
                            .AddCqlLibraries(library)
                            .CreateLibrarySetInvoker();

        invoker.InvokeLibraryDefinition(FhirCqlContext.ForBundle(), library.LibraryIdentifier, "Exists Where")
               .Should().Be(false);
    }

    private static string GenerateCSharp(string cql) =>
        new CqlToolkit()
            .AddCqlLibraries(CqlLibraryString.Parse(cql))
            .CompileToAssemblies()
            .GetElmToCSharpResults()
            .Single()
            .cSharp;
}
