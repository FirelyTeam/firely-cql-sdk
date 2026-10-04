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
using Hl7.Cql.Primitives;

namespace CoreTests;

/// <summary>
/// Regression tests for the aggregate operators (<c>Avg</c>, <c>Median</c>, <c>GeometricMean</c>, <c>Product</c>,
/// <c>StdDev</c>, <c>Variance</c> and their population forms): the values they return per spec §9.B, null with a
/// warning where a result cannot be represented, and the fact that the first three read their source exactly once.
/// </summary>
[TestClass]
[TestCategory("UnitTest")]
public class AggregateOperatorTests
{
    private static ICqlOperators Operators() => FhirCqlContext.WithDataSource().Operators;

    /// <summary>
    /// Invokes an operator and returns its result together with the codes of the warnings it reported.
    /// </summary>
    private static (T Result, List<string?> Warnings) WithWarnings<T>(Func<ICqlOperators, T> invoke)
    {
        var operators = Operators();
        var warnings = new List<string?>();
        operators.MessageReceived += (_, e) =>
        {
            if (e.Severity == "Warning")
                warnings.Add(e.Code);
        };
        return (invoke(operators), warnings);
    }

    private static void AssertNullWithOneWarning<T>(Func<ICqlOperators, T> invoke, string code)
    {
        var (result, warnings) = WithWarnings(invoke);

        Assert.IsNull(result);
        CollectionAssert.AreEqual(new[] { code }, warnings);
    }

    /// <summary>The midpoint of <see cref="decimal.MaxValue"/> and 1.</summary>
    private const decimal MidpointOfMaxValueAndOne = 39614081257132168796771975168m;

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

    /// <summary>
    /// The even-count midpoint of two values near the type's maximum must not overflow: summing the two middle
    /// values first wraps in C#'s default unchecked context, which turns the median of two maxima into a negative
    /// value.
    /// </summary>
    [TestMethod]
    public void Median_Integer_EvenCountOfLargeValues_DoesNotOverflow()
    {
        Assert.AreEqual(int.MaxValue, Operators().Median(new int?[] { int.MaxValue, int.MaxValue }));
    }

    [TestMethod]
    public void Median_Long_EvenCountOfLargeValues_DoesNotOverflow()
    {
        Assert.AreEqual(long.MaxValue, Operators().Median(new long?[] { long.MaxValue, long.MaxValue }));
    }

    /// <summary>
    /// The two most negative values have the same problem in the other direction. A pair whose midpoint is not a
    /// whole number keeps truncating towards zero, which is what dividing the sum of the two middle values does.
    /// </summary>
    [TestMethod]
    public void Median_Integer_EvenCountOfNegativeValues_DoesNotOverflowAndTruncatesTowardsZero()
    {
        var operators = Operators();

        Assert.AreEqual(int.MinValue, operators.Median(new int?[] { int.MinValue, int.MinValue }));
        Assert.AreEqual(-2, operators.Median(new int?[] { -3, -2 }));
    }

    [TestMethod]
    public void Median_Long_EvenCountOfNegativeValues_DoesNotOverflowAndTruncatesTowardsZero()
    {
        var operators = Operators();

        Assert.AreEqual(long.MinValue, operators.Median(new long?[] { long.MinValue, long.MinValue }));
        Assert.AreEqual(-2L, operators.Median(new long?[] { -3L, -2L }));
    }

    /// <summary>
    /// The sum of the two middle values leaves the Decimal range, but their midpoint lies between them and is returned.
    /// </summary>
    [TestMethod]
    public void Median_Decimal_EvenCountOfLargeValues_IsTheirMidpoint()
    {
        Assert.AreEqual(decimal.MaxValue, Operators().Median(new decimal?[] { decimal.MaxValue, decimal.MaxValue }));
        Assert.AreEqual(MidpointOfMaxValueAndOne, Operators().Median(new decimal?[] { decimal.MaxValue, 1m }));
        Assert.AreEqual(-MidpointOfMaxValueAndOne, Operators().Median(new decimal?[] { decimal.MinValue, -1m }));
    }

    [TestMethod]
    public void Median_EmptySource_IsNull()
    {
        var operators = Operators();

        Assert.IsNull(operators.Median(Array.Empty<decimal?>()));
        Assert.IsNull(operators.Median(Array.Empty<int?>()));
        Assert.IsNull(operators.Median(Array.Empty<long?>()));
    }

    /// <summary>
    /// The sort behind Median must be stable: <c>4.0m</c> and <c>4.00m</c> are equal to the comparer but differ in
    /// scale, so which representation the median reports depends on the sort preserving input order of equal values.
    /// The expectation is computed with the documented-stable <c>OrderBy</c>; an unstable in-place sort reorders the
    /// equal middle run of this input and reports a different scale.
    /// </summary>
    [TestMethod]
    public void Median_Decimal_EqualValuesWithDifferentScales_KeepsInputOrder()
    {
        var rng = new Random(0);
        var values = new List<decimal?>();
        for (var i = 0; i < 101; i++)
        {
            var value = rng.Next(1, 6);
            var scale = rng.Next(0, 20);
            var text = scale == 0 ? value.ToString() : value + "." + new string('0', scale);
            values.Add(decimal.Parse(text, System.Globalization.CultureInfo.InvariantCulture));
        }

        var stableReference = values.Where(v => v.HasValue).Select(v => v!.Value).OrderBy(v => v).ToList();
        var expected = stableReference[stableReference.Count >> 1];

        var median = Operators().Median(values);

        Assert.AreEqual(
            expected.ToString(System.Globalization.CultureInfo.InvariantCulture),
            median!.Value.ToString(System.Globalization.CultureInfo.InvariantCulture));
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

    /// <summary>
    /// A genuine zero element makes the product — and so the geometric mean — zero. The product loop used to treat
    /// a zero product as "not yet initialized" and dropped the element while still counting it.
    /// </summary>
    [TestMethod]
    public void GeometricMean_WithZero_IsZero()
    {
        Assert.AreEqual(0m, Operators().GeometricMean(new decimal?[] { 0m, 4m, 9m }));
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

    /// <summary>
    /// A negative product with a fractional root has no real value, and the spec's <c>Power</c> rule (§9.B) says a
    /// result that cannot be represented is null — not an <c>OverflowException</c> from casting <c>NaN</c>.
    /// </summary>
    [TestMethod]
    public void GeometricMean_NegativeProductWithFractionalRoot_IsNull()
    {
        Assert.IsNull(Operators().GeometricMean(new decimal?[] { -2.0m, 8.0m }));
    }

    /// <summary>
    /// A product that overflows <c>Decimal</c> cannot be represented either, so the result is null rather than an
    /// <c>OverflowException</c> escaping the operator.
    /// </summary>
    [TestMethod]
    public void GeometricMean_ProductOverflow_IsNull()
    {
        Assert.IsNull(Operators().GeometricMean(new decimal?[] { decimal.MaxValue, 2.0m }));
    }

    /// <summary>
    /// A single non-null negative value is its own geometric mean: the exponent is <c>1.0</c>, so nothing fractional
    /// is asked of a negative base and the value is representable.
    /// </summary>
    [TestMethod]
    public void GeometricMean_SingleNegativeValue_IsTheValue()
    {
        Assert.AreEqual(-16.0m, Operators().GeometricMean(new decimal?[] { -16.0m, null }));
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

    [TestMethod]
    public void Avg_TotalOutsideDecimalRange_IsNullWithOneWarning()
    {
        var (result, warnings) = WithWarnings(o => o.Avg(new decimal?[] { decimal.MaxValue, null, decimal.MaxValue }));

        Assert.IsNull(result);
        CollectionAssert.AreEqual(new[] { "CqlOperators.AggregateFunctions.Avg" }, warnings);
    }

    #endregion

    #region Product

    [TestMethod]
    public void Product_WithinRange_IsTheProductOfTheValuesThatAreNotNull()
    {
        Assert.AreEqual(6, Operators().Product(new int?[] { 2, null, 3 }));
        Assert.AreEqual(6L, Operators().Product(new long?[] { 2L, null, 3L }));
        Assert.AreEqual(7.5m, Operators().Product(new decimal?[] { 2.5m, null, 3m }));
        var quantity = Operators().Product([new CqlQuantity(2.5m, "mg"), null, new CqlQuantity(3m, "mg")]);
        Assert.AreEqual(7.5m, quantity?.value);
        Assert.AreEqual("mg", quantity?.unit);
    }

    /// <summary>
    /// An Integer or Long product outside the type's range is null, not the value it wraps around to.
    /// </summary>
    [TestMethod]
    public void Product_OutsideRange_IsNullWithOneWarning()
    {
        AssertNullWithOneWarning(o => o.Product(new int?[] { int.MaxValue, 2 }), "CqlOperators.AggregateFunctions.Product");
        AssertNullWithOneWarning(o => o.Product(new long?[] { long.MaxValue, 2L }), "CqlOperators.AggregateFunctions.Product");
        AssertNullWithOneWarning(o => o.Product(new decimal?[] { decimal.MaxValue, 2m }), "CqlOperators.AggregateFunctions.Product");
        AssertNullWithOneWarning(
            o => o.Product([new CqlQuantity(decimal.MaxValue, "mg"), new CqlQuantity(2m, "mg")]),
            "CqlOperators.AggregateFunctions.Product");
    }

    /// <summary>
    /// A Decimal product of nonzero values too small in magnitude to represent is null, as for <c>*</c>.
    /// </summary>
    [TestMethod]
    public void Product_DecimalTooSmallToRepresent_IsNullWithOneWarning()
    {
        AssertNullWithOneWarning(o => o.Product(new decimal?[] { 1e-20m, 1e-20m }), "CqlOperators.AggregateFunctions.Product");
    }

    [TestMethod]
    public void Product_QuantitiesOfDifferentUnits_IsNullWithOneWarning()
    {
        AssertNullWithOneWarning(
            o => o.Product([new CqlQuantity(2m, "mg"), new CqlQuantity(3m, "g")]),
            "CqlOperators.AggregateFunctions.Product");
    }

    #endregion

    #region StdDev, Variance, PopulationStdDev, PopulationVariance

    /// <summary>
    /// The sample standard deviation and variance divide by one less than the number of values, which is zero for a
    /// single value; division by zero results in null.
    /// </summary>
    [TestMethod]
    public void StdDevAndVariance_SingleValue_AreNull()
    {
        Assert.IsNull(Operators().StdDev(new decimal?[] { 1m, null }));
        Assert.IsNull(Operators().Variance(new decimal?[] { 1m, null }));
        Assert.IsNull(Operators().StdDev([new CqlQuantity(1m, "mg")]));
        Assert.IsNull(Operators().Variance([new CqlQuantity(1m, "mg")]));
    }

    [TestMethod]
    public void StdDev_OutsideDecimalRange_IsNullWithOneWarning()
    {
        AssertNullWithOneWarning(o => o.StdDev(new decimal?[] { decimal.MaxValue, decimal.MinValue }), "CqlOperators.AggregateFunctions.StdDev");
        AssertNullWithOneWarning(
            o => o.StdDev([new CqlQuantity(decimal.MaxValue, "mg"), new CqlQuantity(decimal.MinValue, "mg")]),
            "CqlOperators.AggregateFunctions.StdDev");
    }

    /// <summary>
    /// The standard deviation of these values is representable, its square is not.
    /// </summary>
    [TestMethod]
    public void Variance_OutsideDecimalRange_IsNullWithOneWarning()
    {
        AssertNullWithOneWarning(o => o.Variance(new decimal?[] { 1e15m, -1e15m }), "CqlOperators.AggregateFunctions.Variance");
        AssertNullWithOneWarning(
            o => o.Variance([new CqlQuantity(1e15m, "mg"), new CqlQuantity(-1e15m, "mg")]),
            "CqlOperators.AggregateFunctions.Variance");
    }

    [TestMethod]
    public void StdDevAndVariance_QuantitiesOfDifferentUnits_AreNullWithOneWarning()
    {
        CqlQuantity?[] quantities = [new CqlQuantity(1m, "mg"), new CqlQuantity(2m, "g")];

        AssertNullWithOneWarning(o => o.StdDev(quantities), "CqlOperators.AggregateFunctions.StdDev");
        AssertNullWithOneWarning(o => o.Variance(quantities), "CqlOperators.AggregateFunctions.Variance");
    }

    /// <summary>
    /// A squared deviation too small to represent adds nothing to the sum of squares, so the variance of nearly equal
    /// values is zero rather than null.
    /// </summary>
    [TestMethod]
    public void PopulationVariance_SquaredDeviationTooSmallToRepresent_CountsAsZero()
    {
        var (result, warnings) = WithWarnings(o => o.PopulationVariance(new decimal?[] { 0.3333333333333333333333333333m, 0.3333333333333333333333333334m }));

        Assert.AreEqual(0m, result);
        Assert.AreEqual(0, warnings.Count);
    }

    /// <summary>
    /// The total of the values, a deviation from their mean or its square leaves the Decimal range.
    /// </summary>
    [TestMethod]
    public void PopulationStdDevAndVariance_OutsideDecimalRange_AreNullWithOneWarning()
    {
        foreach (var values in new[] { new decimal?[] { decimal.MaxValue, decimal.MaxValue }, [decimal.MaxValue, decimal.MinValue], [1e15m, -1e15m] })
        {
            AssertNullWithOneWarning(o => o.PopulationVariance(values), "CqlOperators.AggregateFunctions.PopulationVariance");
            AssertNullWithOneWarning(
                o => o.PopulationVariance(values.Select(v => (CqlQuantity?)new CqlQuantity(v, "mg"))),
                "CqlOperators.AggregateFunctions.PopulationVariance");
        }

        AssertNullWithOneWarning(o => o.PopulationStdDev(new decimal?[] { decimal.MaxValue, decimal.MinValue }), "CqlOperators.AggregateFunctions.PopulationStdDev");
        AssertNullWithOneWarning(
            o => o.PopulationStdDev([new CqlQuantity(decimal.MaxValue, "mg"), new CqlQuantity(decimal.MinValue, "mg")]),
            "CqlOperators.AggregateFunctions.PopulationStdDev");
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
