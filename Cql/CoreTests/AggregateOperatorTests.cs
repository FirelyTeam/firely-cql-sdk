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
/// Regression tests for the aggregate operators (<c>Avg</c>, <c>Median</c>, <c>GeometricMean</c>): the values they
/// return per spec §9.B, and the fact that each of them reads its source exactly once.
/// </summary>
[TestClass]
[TestCategory("UnitTest")]
public class AggregateOperatorTests
{
    private static ICqlOperators Operators() => FhirCqlContext.WithDataSource().Operators;

    #region Median

    /// <summary>
    /// With an odd number of values the median is the middle of the <em>sorted</em> values — not whatever element
    /// happens to sit at that index of the source in its original order.
    /// </summary>
    [TestMethod]
    public void Median_Decimal_OddCount_IsTheMiddleOfTheSortedValues()
    {
        Assert.AreEqual(4m, Operators().Median(new decimal?[] { 8m, 2m, 4m }));
    }

    [TestMethod]
    public void Median_Integer_OddCount_IsTheMiddleOfTheSortedValues()
    {
        Assert.AreEqual(4, Operators().Median(new int?[] { 8, 2, 4 }));
    }

    [TestMethod]
    public void Median_Long_OddCount_IsTheMiddleOfTheSortedValues()
    {
        Assert.AreEqual(4L, Operators().Median(new long?[] { 8L, 2L, 4L }));
    }

    /// <summary>
    /// Nulls are dropped before the middle is picked, so a null sitting at the middle index of the source must not
    /// leak out as the result.
    /// </summary>
    [TestMethod]
    public void Median_Decimal_OddCountWithInterleavedNulls_IgnoresTheNulls()
    {
        Assert.AreEqual(4m, Operators().Median(new decimal?[] { null, 8m, null, 2m, 4m }));
    }

    [TestMethod]
    public void Median_Integer_OddCountWithInterleavedNulls_IgnoresTheNulls()
    {
        Assert.AreEqual(4, Operators().Median(new int?[] { null, 8, null, 2, 4 }));
    }

    [TestMethod]
    public void Median_Long_OddCountWithInterleavedNulls_IgnoresTheNulls()
    {
        Assert.AreEqual(4L, Operators().Median(new long?[] { null, 8L, null, 2L, 4L }));
    }

    /// <summary>
    /// Spec §9.B: <c>Median({ 2.0, 4.0, 8.0, 6.0 })</c> is <c>5.0</c> — the average of the two middle values.
    /// </summary>
    [TestMethod]
    public void Median_Decimal_EvenCount_AveragesTheTwoMiddleValues()
    {
        Assert.AreEqual(5m, Operators().Median(new decimal?[] { 2m, 4m, 8m, 6m }));
    }

    [TestMethod]
    public void Median_Integer_EvenCount_AveragesTheTwoMiddleValues()
    {
        Assert.AreEqual(5, Operators().Median(new int?[] { 2, 4, 8, 6 }));
    }

    [TestMethod]
    public void Median_Long_EvenCount_AveragesTheTwoMiddleValues()
    {
        Assert.AreEqual(5L, Operators().Median(new long?[] { 2L, 4L, 8L, 6L }));
    }

    [TestMethod]
    public void Median_EmptySource_IsNull()
    {
        var operators = Operators();

        Assert.IsNull(operators.Median(Array.Empty<decimal?>()));
        Assert.IsNull(operators.Median(Array.Empty<int?>()));
        Assert.IsNull(operators.Median(Array.Empty<long?>()));
    }

    [TestMethod]
    public void Median_AllNulls_IsNull()
    {
        var operators = Operators();

        Assert.IsNull(operators.Median(new decimal?[] { null, null }));
        Assert.IsNull(operators.Median(new int?[] { null, null }));
        Assert.IsNull(operators.Median(new long?[] { null, null }));
    }

    [TestMethod]
    public void Median_NullSource_IsNull()
    {
        var operators = Operators();

        Assert.IsNull(operators.Median((IEnumerable<decimal?>)null!));
        Assert.IsNull(operators.Median((IEnumerable<int?>)null!));
        Assert.IsNull(operators.Median((IEnumerable<long?>)null!));
    }

    #endregion

    #region GeometricMean

    [TestMethod]
    public void GeometricMean_IsTheRootOfTheProduct()
    {
        Assert.AreEqual(4m, Operators().GeometricMean(new decimal?[] { 2.0m, 8.0m }));
    }

    /// <summary>
    /// Spec §9.B defines <c>GeometricMean(X) = Power(Product(X), 1 / Count(X))</c> over the non-null elements, so
    /// the nulls the product skipped must not dilute the root either: <c>16^(1/2)</c>, not <c>16^(1/4)</c>.
    /// </summary>
    [TestMethod]
    public void GeometricMean_WithInterleavedNulls_RootsByTheNonNullCount()
    {
        Assert.AreEqual(4m, Operators().GeometricMean(new decimal?[] { 2.0m, null, 8.0m, null }));
    }

    [TestMethod]
    public void GeometricMean_EmptySource_IsNull()
    {
        Assert.IsNull(Operators().GeometricMean(Array.Empty<decimal?>()));
    }

    [TestMethod]
    public void GeometricMean_AllNulls_IsNull()
    {
        Assert.IsNull(Operators().GeometricMean(new decimal?[] { null, null }));
    }

    [TestMethod]
    public void GeometricMean_NullSource_IsNull()
    {
        Assert.IsNull(Operators().GeometricMean(null!));
    }

    #endregion

    #region Avg

    [TestMethod]
    public void Avg_IgnoresNulls()
    {
        Assert.AreEqual(4m, Operators().Avg(new decimal?[] { 2m, null, 6m }));
    }

    [TestMethod]
    public void Avg_EmptySource_IsNull()
    {
        Assert.IsNull(Operators().Avg(Array.Empty<decimal?>()));
    }

    [TestMethod]
    public void Avg_AllNulls_IsNull()
    {
        Assert.IsNull(Operators().Avg(new decimal?[] { null, null }));
    }

    [TestMethod]
    public void Avg_NullSource_IsNull()
    {
        Assert.IsNull(Operators().Avg(null));
    }

    #endregion

    #region Single enumeration of the source

    /// <summary>
    /// For a lazily produced source every extra walk re-runs the query behind it, so an aggregate has to take
    /// everything it needs — emptiness, total, count, the values themselves — out of one pass.
    /// </summary>
    [TestMethod]
    public void Avg_EnumeratesItsSourceOnce()
    {
        var source = new CountingSequence<decimal?>([2m, null, 6m]);

        Assert.AreEqual(4m, Operators().Avg(source));
        Assert.AreEqual(1, source.EnumerationCount);
    }

    [TestMethod]
    public void Median_EnumeratesItsSourceOnce()
    {
        var source = new CountingSequence<decimal?>([8m, null, 2m, 4m, null]);

        Assert.AreEqual(4m, Operators().Median(source));
        Assert.AreEqual(1, source.EnumerationCount);
    }

    [TestMethod]
    public void GeometricMean_EnumeratesItsSourceOnce()
    {
        var source = new CountingSequence<decimal?>([2.0m, null, 8.0m]);

        Assert.AreEqual(4m, Operators().GeometricMean(source));
        Assert.AreEqual(1, source.EnumerationCount);
    }

    /// <summary>
    /// A sequence that counts how often it is walked and refuses a second walk, standing in for a source that is
    /// expensive rather than impossible to produce twice.
    /// </summary>
    private sealed class CountingSequence<T>(T[] items) : IEnumerable<T>
    {
        public int EnumerationCount { get; private set; }

        public IEnumerator<T> GetEnumerator()
        {
            EnumerationCount++;
            if (EnumerationCount > 1)
                throw new InvalidOperationException("The source was enumerated more than once.");

            return ((IEnumerable<T>)items).GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
    }

    #endregion
}
