/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;

namespace CoreTests;

/// <summary>
/// Tests for <see cref="ICqlOperators.AnyRelated{T}"/>, the operator a query relationship clause
/// (<c>with</c> / <c>without</c>) over a list source is compiled to. It is <see langword="true"/>
/// when the <c>such that</c> condition is <see langword="true"/> for at least one element of the
/// related list, null elements included, which is where it differs from
/// <see cref="ICqlOperators.WhereAny{T}"/> (<c>exists (X where c)</c>).
/// </summary>
[TestClass]
[TestCategory("UnitTest")]
public class AnyRelatedOperatorTests
{
    private static ICqlOperators Operators() => FhirCqlContext.WithDataSource().Operators;

    private static List<string?> WithNulls => ["a", null, "bb"];

    private static string Key(string? x) => x ?? "<null>";

    [TestMethod]
    public void AnyRelated_SuchThatTrueOnlyForNullElement_IsTrue()
    {
        Operators().AnyRelated(WithNulls, x => x is null).Should().Be(true);
    }

    [TestMethod]
    public void AnyRelated_SuchThatTrueForEveryElementOfAllNullList_IsTrue()
    {
        Operators().AnyRelated(new List<string?> { null, null }, _ => true).Should().Be(true);
    }

    [TestMethod]
    public void AnyRelated_SuchThatTrueForNonNullElement_IsTrue()
    {
        Operators().AnyRelated(WithNulls, x => x == "bb").Should().Be(true);
    }

    [TestMethod]
    public void AnyRelated_SuchThatFalseForEveryElement_IsFalse()
    {
        Operators().AnyRelated(WithNulls, _ => false).Should().Be(false);
    }

    [TestMethod]
    public void AnyRelated_SuchThatNullForEveryElement_IsFalse()
    {
        // A null condition does not satisfy the clause: only true does.
        Operators().AnyRelated(WithNulls, _ => null).Should().Be(false);
    }

    [TestMethod]
    public void AnyRelated_EmptyList_IsFalseAndNeverEvaluatesSuchThat()
    {
        var evaluated = new List<string>();

        var result = Operators().AnyRelated(new List<string?>(), x => { evaluated.Add(Key(x)); return true; });

        result.Should().Be(false);
        evaluated.Should().BeEmpty();
    }

    [TestMethod]
    public void AnyRelated_NullList_IsFalseAndNeverEvaluatesSuchThat()
    {
        var evaluated = new List<string>();

        var result = Operators().AnyRelated((List<string?>?)null, x => { evaluated.Add(Key(x)); return true; });

        result.Should().Be(false);
        evaluated.Should().BeEmpty();
    }

    [TestMethod]
    public void AnyRelated_NullableValueTypeWithNullElement_CountsTheNullElement()
    {
        Operators().AnyRelated(new List<int?> { 1, null }, x => x is null).Should().Be(true);
    }

    [TestMethod]
    public void AnyRelated_EvaluatesSuchThatForEveryElementInOrder_WithoutStoppingAtTheFirstMatch()
    {
        // The condition's Message side effects must be those of Where over the whole related list.
        var evaluated = new List<string>();

        var result = Operators().AnyRelated(WithNulls, x => { evaluated.Add(Key(x)); return true; });

        result.Should().Be(true);
        evaluated.Should().Equal("a", "<null>", "bb");
    }

    [TestMethod]
    public void AnyRelated_DiffersFromWhereAnyOnlyInCountingNullElements()
    {
        var op = Operators();

        op.AnyRelated(WithNulls, x => x is null).Should().Be(true);
        op.WhereAny(WithNulls, x => x is null).Should().Be(false, "exists (X where c) ignores null elements");

        op.AnyRelated(WithNulls, x => x == "a").Should().Be(op.WhereAny(WithNulls, x => x == "a"));
    }
}
