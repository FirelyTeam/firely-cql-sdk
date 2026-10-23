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
}
