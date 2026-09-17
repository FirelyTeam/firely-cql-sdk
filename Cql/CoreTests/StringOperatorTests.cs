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
/// Regression tests for the string operators (<c>Combine</c>): the values they return per spec §9.B.
/// </summary>
[TestClass]
[TestCategory("UnitTest")]
public class StringOperatorTests
{
    private static ICqlOperators Operators() => FhirCqlContext.WithDataSource().Operators;

    #region Combine

    /// <summary>
    /// Spec §9.B, Combine: "If the source argument is null, or the source list is empty, the result is null." An
    /// empty source is therefore null rather than the empty string, whether or not a separator is supplied.
    /// </summary>
    [TestMethod]
    public void Combine_EmptySource_IsNull()
    {
        Assert.IsNull(Operators().Combine(Array.Empty<string>(), null));
    }

    [TestMethod]
    public void Combine_EmptySourceWithSeparator_IsNull()
    {
        Assert.IsNull(Operators().Combine(Array.Empty<string>(), ";"));
    }

    [TestMethod]
    public void Combine_NullSource_IsNull()
    {
        var operators = Operators();

        Assert.IsNull(operators.Combine(null!, null));
        Assert.IsNull(operators.Combine(null!, ";"));
    }

    /// <summary>
    /// Spec §9.B: <c>Combine({ 'A', 'B', 'C' })</c> is <c>'ABC'</c> — without a separator the elements are
    /// concatenated as they are.
    /// </summary>
    [TestMethod]
    public void Combine_WithoutSeparator_ConcatenatesTheElements()
    {
        Assert.AreEqual("abc", Operators().Combine(["a", "b", "c"], null));
    }

    /// <summary>
    /// Spec §9.B: <c>Combine({ 'A', 'B', 'C' }, ' ')</c> is <c>'A B C'</c> — the separator goes between the
    /// elements, not before the first or after the last.
    /// </summary>
    [TestMethod]
    public void Combine_WithSeparator_PutsTheSeparatorBetweenTheElements()
    {
        Assert.AreEqual("a;b;c", Operators().Combine(["a", "b", "c"], ";"));
    }

    /// <summary>
    /// A single element has nothing to separate it from, so it comes back unchanged with or without a separator.
    /// </summary>
    [TestMethod]
    public void Combine_SingleElement_IsThatElement()
    {
        var operators = Operators();

        Assert.AreEqual("a", operators.Combine(["a"], null));
        Assert.AreEqual("a", operators.Combine(["a"], ";"));
    }

    #endregion
}
