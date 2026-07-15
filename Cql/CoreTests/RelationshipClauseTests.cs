/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Runtime;

namespace CoreTests;

/// <summary>
/// Tests for the query 'with'/'without' relationship clauses (see issue #1366).
/// A 'with' is a semi-join and a 'without' an anti-semi-join: each source element must be
/// emitted at most once, no matter how many related elements satisfy the 'such that' condition,
/// and duplicates in the source must be preserved.
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
}
