/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Comparers;
using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;

namespace CoreTests;

/// <summary>
/// Spec §9.B, Clinical Operators. Equal: "The equal (=) operator for Codes and Concepts uses tuple equality semantics.
/// This means that the operator will return true if and only if the values for each element by name are equal. If
/// either argument is null, or has different components specified, the result is null." Equivalent: "For Concept
/// values, equivalence is defined as a non-empty intersection of the codes in each Concept using Code equivalence to
/// determine the intersection. The display element is ignored for the purposes of determining Concept equivalence."
/// </summary>
/// <remarks>
/// Every case runs in both operand orders, through <see cref="CqlComparers"/> and through <see cref="ICqlOperators"/>.
/// </remarks>
[TestClass]
public class ConceptEqualityTests
{
    private static readonly CqlCode C = new("8480-6", "http://loinc.org");

    private static readonly CqlCode D = new("8462-4", "http://loinc.org");

    /// <summary><see cref="C"/> without its system: whether it equals <see cref="C"/> is unknown.</summary>
    private static readonly CqlCode CWithoutSystem = new("8480-6");

    private static CqlConcept Concept(CqlCode?[]? codes = null, string? display = null) => new(codes!, display);

    private static ICqlOperators Operators() => FhirCqlContext.WithDataSource().Operators;

    #region Equal

    private static IEnumerable<object?[]> EqualCases =>
    [
        ["same codes, different displays (the specification's EqualIsFalse)", Concept([C], "Concepts"), Concept([C], "More Concepts"), false],
        ["same codes, same display", Concept([C], "x"), Concept([C], "x"), true],
        ["same codes, neither with a display", Concept([C]), Concept([C]), true],
        ["different codes, same display", Concept([C], "x"), Concept([D], "x"), false],
        ["same codes in a different order", Concept([C, D], "x"), Concept([D, C], "x"), false],
        ["one code more", Concept([C], "x"), Concept([C, D], "x"), false],
        ["displays that differ in case only", Concept([C], "x"), Concept([C], "X"), false],
        ["no codes, different displays", Concept(display: "x"), Concept(display: "y"), false],
        ["no codes, same display", Concept(display: "x"), Concept(display: "x"), true],
        ["neither codes nor a display", Concept(), Concept(), true],
        ["empty codes, same display", Concept([], "x"), Concept([], "x"), true],
        ["codes on one side only", Concept(display: "x"), Concept([C], "x"), null],
        ["empty codes on one side, none on the other", Concept([], "x"), Concept(display: "x"), null],
        ["a display on one side only", Concept([C], "x"), Concept([C]), null],
        ["different codes, and a display on one side only", Concept([C], "x"), Concept([D]), null],
        ["codes whose equality is unknown", Concept([C], "x"), Concept([CWithoutSystem], "x"), null],
        ["a code whose equality is unknown beside one known to differ", Concept([C, C], "x"), Concept([CWithoutSystem, D], "x"), false],
        ["same codes whose equality is unknown, different displays", Concept([C], "x"), Concept([CWithoutSystem], "y"), false],
        ["null codes in the same places", Concept([null, C], "x"), Concept([null, C], "x"), true],
        ["a null code against a code", Concept([null], "x"), Concept([C], "x"), false],
    ];

    [TestMethod]
    [DynamicData(nameof(EqualCases))]
    public void Concept_Equal_FollowsTupleEquality(string caseDescription, CqlConcept left, CqlConcept right, bool? expected)
    {
        var comparers = new CqlComparers();
        var operators = Operators();

        comparers.Equals(left, right, null).Should().Be(expected, caseDescription);
        comparers.Equals(right, left, null).Should().Be(expected, caseDescription);
        operators.Equal(left, right).Should().Be(expected, caseDescription);
        operators.Equal(right, left).Should().Be(expected, caseDescription);
        operators.NotEqual(left, right).Should().Be(!expected, caseDescription);

        // Equality is decided by the comparison, so the comparison agrees with it: 0 when equal, null when unknown.
        var compare = comparers.Compare(left, right, null);
        var compareReversed = comparers.Compare(right, left, null);
        switch (expected)
        {
            case true:
                compare.Should().Be(0, caseDescription);
                compareReversed.Should().Be(0, caseDescription);
                comparers.GetHashCode(left).Should().Be(comparers.GetHashCode(right), caseDescription);
                break;
            case false:
                compare.Should().NotBeNull(caseDescription).And.NotBe(0, caseDescription);
                compareReversed.Should().NotBeNull(caseDescription).And.NotBe(0, caseDescription);
                break;
            case null:
                compare.Should().BeNull(caseDescription);
                compareReversed.Should().BeNull(caseDescription);
                break;
        }
    }

    [TestMethod]
    public void Concept_EqualToNull_IsNull()
    {
        var comparers = new CqlComparers();
        var operators = Operators();
        CqlConcept[] concepts = [Concept([C], "x"), Concept(display: "x"), Concept()];

        foreach (var concept in concepts)
        {
            comparers.Equals(concept, null, null).Should().BeNull();
            comparers.Equals(null, concept, null).Should().BeNull();
            operators.Equal(concept, null).Should().BeNull();
            operators.Equal(null, concept).Should().BeNull();
        }

        comparers.Equals(null, null, null).Should().BeNull();
        operators.Equal(null, null).Should().BeNull();
    }

    #endregion

    #region Equivalent

    private static readonly CqlConcept WithoutCodes = Concept(display: "x");

    /// <summary>The specification's Concept2 in the Equivalent examples: <c>Concept { codes: { null } }</c>.</summary>
    private static readonly CqlConcept WithANullCode = Concept([null], "More Concepts");

    private static IEnumerable<object?[]> EquivalentCases =>
    [
        ["same codes, different displays", Concept([C], "Concepts"), Concept([C], "More Concepts"), true],
        ["overlapping codes", Concept([C, D], "x"), Concept([D]), true],
        ["same codes in a different order", Concept([C, D]), Concept([D, C]), true],
        ["disjoint codes, same display", Concept([C], "x"), Concept([D], "x"), false],
        ["no codes, different displays", Concept(display: "x"), Concept(display: "y"), false],
        ["no codes, same display", Concept(display: "x"), Concept(display: "x"), false],
        ["the same concept without codes", WithoutCodes, WithoutCodes, false],
        ["neither codes nor a display", Concept(), Concept(), false],
        ["empty codes", Concept([], "x"), Concept([], "x"), false],
        ["codes on one side only", Concept(display: "x"), Concept([C], "x"), false],
        ["empty codes on one side", Concept([], "x"), Concept([C], "x"), false],
        // The specification's EquivalentIsAlsoTrue (Concept2 ~ Concept2) and EquivalentIsFalse (Concept1 ~ Concept2).
        ["the same concept with a null code", WithANullCode, WithANullCode, true],
        ["concepts with a null code each", Concept([null], "x"), Concept([null], "y"), true],
        ["a code against a null code", Concept([C], "Concepts"), WithANullCode, false],
    ];

    [TestMethod]
    [DynamicData(nameof(EquivalentCases))]
    public void Concept_Equivalent_IsANonEmptyIntersectionOfTheCodes(string caseDescription, CqlConcept left, CqlConcept right, bool expected)
    {
        var comparers = new CqlComparers();
        var operators = Operators();

        comparers.Equivalent(left, right, null).Should().Be(expected, caseDescription);
        comparers.Equivalent(right, left, null).Should().Be(expected, caseDescription);
        operators.Equivalent(left, right).Should().Be(expected, caseDescription);
        operators.Equivalent(right, left).Should().Be(expected, caseDescription);
        operators.NotEquivalent(left, right).Should().Be(!expected, caseDescription);
    }

    [TestMethod]
    public void Concept_EquivalentToNull_IsFalse_AndNullIsEquivalentToNull()
    {
        var comparers = new CqlComparers();
        var operators = Operators();
        CqlConcept[] concepts = [Concept([C], "x"), Concept(display: "x"), Concept()];

        foreach (var concept in concepts)
        {
            comparers.Equivalent(concept, null, null).Should().BeFalse();
            comparers.Equivalent(null, concept, null).Should().BeFalse();
            operators.Equivalent(concept, null).Should().BeFalse();
            operators.Equivalent(null, concept).Should().BeFalse();
        }

        comparers.Equivalent(null, null, null).Should().BeTrue();
        operators.Equivalent(null, null).Should().BeTrue();
    }

    #endregion

    #region Operations that use equality

    // The list operations use equality semantics (spec §9.B, List Operators): a concept is a duplicate of another, or
    // found in a list, only when the two are equal, never when their equality is unknown.

    private static string?[] Displays(IEnumerable<CqlConcept>? concepts) => concepts!.Select(c => c.display).ToArray();

    [TestMethod]
    public void Distinct_KeepsConceptsThatAreNotEqual()
    {
        var operators = Operators();

        Displays(operators.Distinct([Concept([C], "a"), Concept([C], "b"), Concept([C], "a")]))
            .Should().Equal("a", "b");
        Displays(operators.Distinct([Concept(display: "x"), Concept(display: "y"), Concept(display: "x")]))
            .Should().Equal("x", "y");
        operators.Distinct([Concept([C, D], "x"), Concept([D, C], "x")]).Should().HaveCount(2);
        operators.Distinct([Concept([C], "x"), Concept([C])]).Should().HaveCount(2);
        operators.Distinct([Concept(), Concept()]).Should().HaveCount(1);
        operators.SelectDistinct<string, CqlConcept>(["a", "b", "a"], display => Concept([C], display))
            .Should().HaveCount(2);
    }

    [TestMethod]
    public void UnionExceptAndIntersect_MatchOnlyEqualConcepts()
    {
        var operators = Operators();
        CqlConcept[] displayA = [Concept([C], "a"), Concept(display: "x")];
        CqlConcept[] displayB = [Concept([C], "b"), Concept(display: "y")];
        CqlConcept[] displayAAgain = [Concept([C], "a"), Concept(display: "x")];

        Displays(operators.Union(displayA, displayB)).Should().Equal("a", "x", "b", "y");
        Displays(operators.Except(displayA, displayB)).Should().Equal("a", "x");
        operators.Intersect(displayA, displayB).Should().BeEmpty();

        Displays(operators.Union(displayA, displayAAgain)).Should().Equal("a", "x");
        operators.Except(displayA, displayAAgain).Should().BeEmpty();
        Displays(operators.Intersect(displayA, displayAAgain)).Should().Equal("a", "x");
    }

    [TestMethod]
    public void InContainsAndIndexOf_FindOnlyAnEqualConcept()
    {
        var operators = Operators();
        CqlConcept?[] list = [Concept([C], "a"), Concept(display: "x")];

        operators.In(Concept([C], "b"), list).Should().BeFalse();
        operators.In(Concept([C]), list).Should().BeFalse();
        operators.In(Concept(display: "y"), list).Should().BeFalse();
        operators.In(Concept([C], "a"), list).Should().BeTrue();
        operators.In(Concept(display: "x"), list).Should().BeTrue();

        operators.Contains(list, Concept([C], "b")).Should().BeFalse();
        operators.Contains(list, Concept(display: "x")).Should().BeTrue();

        operators.IndexOf(list, Concept([C], "b")).Should().Be(-1);
        operators.IndexOf(list, Concept(display: "x")).Should().Be(1);

        operators.ListIncludesList(list, [Concept(display: "y")]).Should().BeFalse();
        operators.ListIncludesList(list, [Concept(display: "x")]).Should().BeTrue();
    }

    [TestMethod]
    public void ListEqualAndListEquivalent_CompareTheConceptsInTheLists()
    {
        var operators = Operators();

        operators.ListEqual([Concept([C], "a")], [Concept([C], "b")]).Should().BeFalse();
        operators.ListEqual([Concept(display: "x")], [Concept(display: "y")]).Should().BeFalse();
        operators.ListEqual([Concept([C], "a")], [Concept([C])]).Should().BeNull();
        operators.ListEqual([Concept([C], "a")], [Concept([C], "a")]).Should().BeTrue();

        operators.Equivalent<CqlConcept>([Concept([C], "a")], [Concept([C], "b")]).Should().BeTrue();
        operators.Equivalent<CqlConcept>([Concept(display: "x")], [Concept(display: "x")]).Should().BeFalse();
    }

    [TestMethod]
    public void Mode_CountsOnlyEqualConceptsTogether()
    {
        var operators = Operators();

        operators.Mode([Concept([C], "b"), Concept([C], "b"), Concept([C], "a")]).display.Should().Be("b");
        operators.Mode([Concept(display: "y"), Concept(display: "y"), Concept(display: "x")]).display.Should().Be("y");
    }

    [TestMethod]
    public void Tuple_WithAConceptElement_ComparesTheConceptByConceptEqualityAndEquivalence()
    {
        var operators = Operators();
        var metadata = new CqlTupleMetadata([typeof(CqlConcept)], ["concept"]);
        (CqlTupleMetadata, CqlConcept) TupleOf(CqlConcept concept) => (metadata, concept);

        operators.Equal(TupleOf(Concept([C], "a")), TupleOf(Concept([C], "b"))).Should().BeFalse();
        operators.Equal(TupleOf(Concept(display: "x")), TupleOf(Concept(display: "x"))).Should().BeTrue();
        operators.Equal(TupleOf(Concept([C], "a")), TupleOf(Concept([C]))).Should().BeNull();
        operators.Equivalent(TupleOf(Concept([C], "a")), TupleOf(Concept([C], "b"))).Should().BeTrue();
        operators.Equivalent(TupleOf(Concept(display: "x")), TupleOf(Concept(display: "x"))).Should().BeFalse();
        operators.Distinct<object>([TupleOf(Concept([C], "a")), TupleOf(Concept([C], "b")), TupleOf(Concept([C], "a"))])
            .Should().HaveCount(2);
    }

    #endregion

    #region Concepts inside lists, tuples and key-value pairs

    // Lists and tuples are equivalent when their elements are (spec §9.B, Comparison Operators, Equivalent), so whether
    // the two sides hold the same instance does not matter: a concept without codes is equivalent to no concept,
    // wherever it sits.

    private static void AssertEquivalent(object left, object right, bool expected, string because)
    {
        var comparers = new CqlComparers();
        var operators = Operators();

        comparers.Equivalent(left, right, null).Should().Be(expected, because);
        comparers.Equivalent(right, left, null).Should().Be(expected, because);
        operators.Equivalent(left, right).Should().Be(expected, because);
        operators.Equivalent(right, left).Should().Be(expected, because);
    }

    [TestMethod]
    public void Tuple_WithAListOfConcepts_IsEquivalentByTheConcepts_WhetherTheListIsSharedOrNot()
    {
        var metadata = new CqlTupleMetadata([typeof(IEnumerable<CqlConcept>)], ["concepts"]);
        (CqlTupleMetadata, IEnumerable<CqlConcept>) TupleOf(IEnumerable<CqlConcept> concepts) => (metadata, concepts);

        CqlConcept[] shared = [Concept(display: "x")];
        AssertEquivalent(TupleOf(shared), TupleOf(shared), false, "two tuples share a list of a concept without codes");
        AssertEquivalent(
            TupleOf(new[] { Concept(display: "x") }),
            TupleOf(new[] { Concept(display: "x") }),
            false,
            "two tuples hold separately allocated lists of a concept without codes");

        CqlConcept[] sharedWithACode = [Concept([C], "x")];
        AssertEquivalent(TupleOf(sharedWithACode), TupleOf(sharedWithACode), true, "two tuples share a list of a concept with a code");
    }

    [TestMethod]
    public void NestedList_OfConcepts_IsEquivalentByTheConcepts_WhetherTheInnerListIsSharedOrNot()
    {
        var operators = Operators();
        CqlConcept[] shared = [Concept(display: "x")];
        IEnumerable<CqlConcept>[] outer = [shared];
        IEnumerable<CqlConcept>[] otherOuter = [shared];

        AssertEquivalent(outer, otherOuter, false, "two lists hold one shared list of a concept without codes");
        AssertEquivalent(shared, shared, false, "a list of a concept without codes against itself");
        AssertEquivalent(
            new IEnumerable<CqlConcept>[] { new[] { Concept(display: "x") } },
            new IEnumerable<CqlConcept>[] { new[] { Concept(display: "x") } },
            false,
            "two lists hold separately allocated lists of a concept without codes");

        operators.Equivalent<IEnumerable<CqlConcept>>(outer, otherOuter).Should().BeFalse();
        operators.Equivalent<IEnumerable<CqlConcept>>(otherOuter, outer).Should().BeFalse();

        IEnumerable<CqlConcept>[] outerWithACode = [new[] { Concept([C], "x") }];
        AssertEquivalent(outerWithACode, outerWithACode, true, "a nested list of a concept with a code against itself");
    }

    [TestMethod]
    public void KeyValuePair_WithAConceptValue_IsEquivalentByTheConcept()
    {
        var withoutCodes = new KeyValuePair<string, CqlConcept>("k", Concept(display: "x"));
        var withoutCodesAgain = new KeyValuePair<string, CqlConcept>("k", Concept(display: "x"));

        AssertEquivalent(withoutCodes, withoutCodesAgain, false, "the values are equal concepts without codes");
        AssertEquivalent(withoutCodes, withoutCodes, false, "a pair whose value is a concept without codes against itself");
        AssertEquivalent(
            new KeyValuePair<string, CqlConcept>("k", Concept([C], "a")),
            new KeyValuePair<string, CqlConcept>("k", Concept([C], "b")),
            true,
            "the values share a code");
    }

    #endregion
}
