/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using System.ComponentModel;
using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Runtime;

namespace CoreTests;

/// <summary>
/// Covers the operators whose observable behaviour was pinned down or corrected while removing repeated work from
/// the evaluation path: the results have to stay the same no matter how many times a result is walked, and the
/// aggregates that used to read the wrong sequence have to read the right one.
/// </summary>
[TestClass]
[TestCategory("UnitTest")]
public class OperatorPerformanceSweepTests
{
    private static ICqlOperators Operators() => FhirCqlContext.WithDataSource().Operators;

    #region Results are stable across repeated walks

    [TestMethod]
    public void SortBy_WalkedTwice_YieldsTheSameOrderBothTimes()
    {
        var source = new object[] { "c", "a", "d", "b" };

        var sorted = Operators().SortBy(source, e => e, ListSortDirection.Ascending)!;

        CollectionAssert.AreEqual(new[] { "a", "b", "c", "d" }, sorted.ToArray());
        CollectionAssert.AreEqual(new[] { "a", "b", "c", "d" }, sorted.ToArray());
    }

    [TestMethod]
    public void SortBy_EvaluatesTheSortExpressionOncePerElement()
    {
        var source = new object[] { "c", "a", "b" };
        var evaluations = 0;

        var sorted = Operators().SortBy(
            source,
            e =>
            {
                evaluations++;
                return e;
            },
            ListSortDirection.Ascending)!;

        // Walking the result must not evaluate the expression again, whatever it costs to compute.
        _ = sorted.ToArray();
        _ = sorted.ToArray();

        Assert.AreEqual(source.Length, evaluations);
    }

    [TestMethod]
    public void SortBy_ConsumesASingleUseSourceOnce()
    {
        var sorted = Operators().SortBy(SingleUse(["b", "a"]), e => e, ListSortDirection.Ascending)!;

        CollectionAssert.AreEqual(new object[] { "a", "b" }, sorted.ToArray());
        CollectionAssert.AreEqual(new object[] { "a", "b" }, sorted.ToArray());
    }

    [TestMethod]
    public void ListSort_ConsumesASingleUseSourceOnce()
    {
        var sorted = Operators().ListSort(SingleUse(["b", "a"]), ListSortDirection.Ascending)!;

        CollectionAssert.AreEqual(new object[] { "a", "b" }, sorted.ToArray());
        CollectionAssert.AreEqual(new object[] { "a", "b" }, sorted.ToArray());
    }

    /// <summary>
    /// A sequence that throws if it is walked more than once, standing in for a source that is expensive rather
    /// than impossible to produce twice.
    /// </summary>
    private static IEnumerable<object> SingleUse(object[] items)
    {
        var walked = false;
        return Walk();

        IEnumerable<object> Walk()
        {
            if (walked)
                throw new InvalidOperationException("The source was enumerated more than once.");
            walked = true;

            foreach (var item in items)
                yield return item;
        }
    }

    #endregion

    #region Null ordering and sort stability

    [TestMethod]
    public void ListSort_PutsNullsFirstAscendingAndLastDescending()
    {
        var source = new object?[] { "b", null, "a" };

        CollectionAssert.AreEqual(
            new object?[] { null, "a", "b" },
            Operators().ListSort(source, ListSortDirection.Ascending)!.ToArray());

        CollectionAssert.AreEqual(
            new object?[] { "b", "a", null },
            Operators().ListSort(source, ListSortDirection.Descending)!.ToArray());
    }

    [TestMethod]
    public void SortBy_PutsNullKeysFirstAscendingAndLastDescending()
    {
        var source = new[]
        {
            new Keyed("second", "b"),
            new Keyed("none", null),
            new Keyed("first", "a"),
        };

        CollectionAssert.AreEqual(
            new[] { "none", "first", "second" },
            Operators().SortBy(source, k => k.Key!, ListSortDirection.Ascending)!.Select(k => k.Name).ToArray());

        CollectionAssert.AreEqual(
            new[] { "second", "first", "none" },
            Operators().SortBy(source, k => k.Key!, ListSortDirection.Descending)!.Select(k => k.Name).ToArray());
    }

    /// <summary>
    /// Elements whose keys compare equal keep their input order, in either direction — the sort is stable, and
    /// reversing the direction reverses which key sorts first, not the order among equal ones.
    /// </summary>
    [TestMethod]
    public void SortBy_IsStableWithinEqualKeys()
    {
        var source = new[]
        {
            new Keyed("first", "a"),
            new Keyed("second", "a"),
            new Keyed("third", "a"),
        };

        CollectionAssert.AreEqual(
            new[] { "first", "second", "third" },
            Operators().SortBy(source, k => k.Key!, ListSortDirection.Ascending)!.Select(k => k.Name).ToArray());

        CollectionAssert.AreEqual(
            new[] { "first", "second", "third" },
            Operators().SortBy(source, k => k.Key!, ListSortDirection.Descending)!.Select(k => k.Name).ToArray());
    }

    /// <summary>
    /// Distinct keys still sort in opposite directions, so the stability above is not masking a sort that ignores
    /// the direction.
    /// </summary>
    [TestMethod]
    public void SortBy_OrdersDistinctKeysInBothDirections()
    {
        var source = new[]
        {
            new Keyed("b", "b"),
            new Keyed("a", "a"),
            new Keyed("c", "c"),
        };

        CollectionAssert.AreEqual(
            new[] { "a", "b", "c" },
            Operators().SortBy(source, k => k.Key!, ListSortDirection.Ascending)!.Select(k => k.Name).ToArray());

        CollectionAssert.AreEqual(
            new[] { "c", "b", "a" },
            Operators().SortBy(source, k => k.Key!, ListSortDirection.Descending)!.Select(k => k.Name).ToArray());
    }

    private sealed record Keyed(string Name, object? Key);

    #endregion

    #region Includes

    [TestMethod]
    public void ListIncludesList_HandlesDuplicatesAndNulls()
    {
        var operators = Operators();

        Assert.AreEqual(true, operators.ListIncludesList<object?>(["a", "b", "a"], ["a", "a"]));
        Assert.AreEqual(false, operators.ListIncludesList<object?>(["a", "b"], ["a", "c"]));

        // A null on the right is included only when the left holds one too.
        Assert.AreEqual(true, operators.ListIncludesList<object?>(["a", null], [null]));
        Assert.AreEqual(false, operators.ListIncludesList<object?>(["a", "b"], [null]));

        Assert.IsNull(operators.ListIncludesList<object?>(null, ["a"]));
        Assert.IsNull(operators.ListIncludesList<object?>(["a"], null));
    }

    [TestMethod]
    public void ListProperlyIncludesList_ComparesSizesAfterInclusion()
    {
        var operators = Operators();

        Assert.AreEqual(true, operators.ListProperlyIncludesList<object?>(["a", "b"], ["a"]));
        Assert.AreEqual(false, operators.ListProperlyIncludesList<object?>(["a"], ["a"]));
        Assert.AreEqual(false, operators.ListProperlyIncludesList<object?>(["a"], ["a", "b"]));
    }

    #endregion

    #region Aggregates

    /// <summary>
    /// The median of an odd number of elements is the middle of the sorted, non-null values — not the element that
    /// happens to sit at that index of the source.
    /// </summary>
    [TestMethod]
    public void Median_OfOddCount_ReadsTheSortedNonNullValues()
    {
        var operators = Operators();

        Assert.AreEqual(4m, operators.Median(new decimal?[] { 8m, 2m, 4m }));
        Assert.AreEqual(4, operators.Median(new int?[] { 8, 2, 4 }));
        Assert.AreEqual(4L, operators.Median(new long?[] { 8L, 2L, 4L }));

        // With nulls mixed in, the middle is the middle of what remains.
        Assert.AreEqual(4m, operators.Median(new decimal?[] { null, 8m, null, 2m, 4m }));
    }

    [TestMethod]
    public void Median_OfEvenCount_AveragesTheTwoMiddleValues()
    {
        var operators = Operators();

        Assert.AreEqual(5m, operators.Median(new decimal?[] { 2m, 4m, 8m, 6m }));
        Assert.AreEqual(5, operators.Median(new int?[] { 2, 4, 8, 6 }));
        Assert.AreEqual(5L, operators.Median(new long?[] { 2L, 4L, 8L, 6L }));
    }

    [TestMethod]
    public void Median_OfAllNullsOrNull_IsNull()
    {
        var operators = Operators();

        Assert.IsNull(operators.Median((IEnumerable<decimal?>)[null, null]));
        Assert.IsNull(operators.Median((IEnumerable<decimal?>)null!));
    }

    /// <summary>
    /// Spec §9.B: <c>GeometricMean(X) = Power(Product(X), 1 / Count(X))</c>, and CQL's <c>Count</c> is the number of
    /// non-null elements — so the nulls must not dilute the root.
    /// </summary>
    [TestMethod]
    public void GeometricMean_TakesTheRootOverTheNonNullCount()
    {
        var operators = Operators();

        Assert.AreEqual(4m, operators.GeometricMean([2.0m, 8.0m]));
        Assert.AreEqual(4m, operators.GeometricMean([2.0m, null, 8.0m, null]));
        Assert.IsNull(operators.GeometricMean([null, null]));
    }

    [TestMethod]
    public void Avg_IgnoresNullsAndIsNullWithoutValues()
    {
        var operators = Operators();

        Assert.AreEqual(4m, operators.Avg([2m, null, 6m]));
        Assert.IsNull(operators.Avg([null, null]));
        Assert.IsNull(operators.Avg(null));
    }

    #endregion

    #region Hash-based operators over strings

    /// <summary>
    /// Two strings that differ only in Unicode normalization form are equal under CQL's string comparison, so the
    /// hash-based operators have to treat them as one value rather than two.
    /// </summary>
    [TestMethod]
    public void Distinct_TreatsDifferentNormalizationFormsOfTheSameStringAsOneValue()
    {
        // "cafe" with an acute accent, written two ways: the precomposed U+00E9, and a plain "e" followed by
        // the combining acute U+0301. Escapes rather than literals, so that normalizing the file cannot quietly
        // turn these into the same string and make the test pass for the wrong reason.
        const string composed = "caf\u00E9";
        const string decomposed = "cafe\u0301";

        var operators = Operators();

        Assert.AreEqual(true, operators.Equal(composed, decomposed));

        var distinct = operators.Distinct<object>([composed, decomposed])!.ToArray();
        Assert.AreEqual(1, distinct.Length);

        Assert.AreEqual(true, operators.ListIncludesList<object>([composed], [decomposed]));
    }

    #endregion
}
