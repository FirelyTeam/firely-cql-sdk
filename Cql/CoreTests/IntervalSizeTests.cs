/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;

namespace CoreTests;

/// <summary>
/// The Size operator (§9.B Size): <c>(end of argument - start of argument) + point-size</c>, where the point-size is
/// the step from a value to its successor, so <c>Size(Interval[3, 7])</c> and <c>Size(Interval[3, 8))</c> are both 5.
/// </summary>
[TestClass]
[TestCategory("UnitTest")]
public class IntervalSizeTests
{
    private static ICqlOperators Operators() => FhirCqlContext.WithDataSource().Operators;

    [TestMethod]
    public void Size_Integer_CountsThePointsOfTheInterval()
    {
        Assert.AreEqual(5, Operators().Size(new CqlInterval<int?>(3, 7, true, true)));
        Assert.AreEqual(5, Operators().Size(new CqlInterval<int?>(3, 8, true, false)));
        Assert.AreEqual(5, Operators().Size(new CqlInterval<int?>(2, 7, false, true)));
        Assert.AreEqual(1, Operators().Size(new CqlInterval<int?>(4, 4, true, true)));
    }

    [TestMethod]
    public void Size_Long_CountsThePointsOfTheInterval()
    {
        Assert.AreEqual(5L, Operators().Size(new CqlInterval<long?>(3L, 7L, true, true)));
        Assert.AreEqual(5L, Operators().Size(new CqlInterval<long?>(3L, 8L, true, false)));
    }

    /// <summary>The Decimal point-size is the minimum precision 10^-8, so a half-open interval of width 1 has size 1.</summary>
    [TestMethod]
    public void Size_Decimal_AddsTheMinimumPrecision()
    {
        Assert.AreEqual(4.00000001m, Operators().Size(new CqlInterval<decimal?>(3m, 7m, true, true)));
        Assert.AreEqual(1m, Operators().Size(new CqlInterval<decimal?>(1m, 2m, true, false)));
    }

    /// <summary>A Quantity interval's size has the boundaries' unit and the Decimal point-size.</summary>
    [TestMethod]
    public void Size_Quantity_AddsTheMinimumPrecisionInTheIntervalsUnit()
    {
        var size = Operators().Size(new CqlInterval<CqlQuantity?>(new CqlQuantity(3m, "mg"), new CqlQuantity(7m, "mg"), true, true));

        Assert.AreEqual(4.00000001m, size?.value);
        Assert.AreEqual("mg", size?.unit);
    }

    /// <summary>§9.B Size: a null interval gives null, and so does an interval with a null boundary.</summary>
    [TestMethod]
    public void Size_NullIntervalOrNullBoundary_IsNull()
    {
        var operators = Operators();

        Assert.IsNull(operators.Size((CqlInterval<int?>?)null));
        Assert.IsNull(operators.Size((CqlInterval<long?>?)null));
        Assert.IsNull(operators.Size((CqlInterval<decimal?>?)null));
        Assert.IsNull(operators.Size((CqlInterval<CqlQuantity?>?)null));
        Assert.IsNull(operators.Size(new CqlInterval<int?>(3, null, true, false)));
        Assert.IsNull(operators.Size(new CqlInterval<decimal?>(null, 7m, false, true)));
    }

    /// <summary>
    /// A closed null boundary is the type's minimum or maximum (§9.B Start and End), so the size runs to that extreme;
    /// a Quantity extreme takes the other boundary's unit.
    /// </summary>
    [TestMethod]
    public void Size_ClosedNullBoundary_RunsToTheTypesExtreme()
    {
        var operators = Operators();

        Assert.AreEqual(int.MaxValue - 2, operators.Size(new CqlInterval<int?>(3, null, true, true)));
        Assert.AreEqual(int.MaxValue - 4, operators.Size(new CqlInterval<int?>(null, -6, true, true)));
        Assert.AreEqual(long.MaxValue - 2, operators.Size(new CqlInterval<long?>(3L, null, true, true)));
        Assert.AreEqual(decimal.MaxValue - 3m + 0.00000001m, operators.Size(new CqlInterval<decimal?>(3m, null, true, true)));

        var quantity = operators.Size(new CqlInterval<CqlQuantity?>(new CqlQuantity(3m, "mg"), null, true, true));
        Assert.AreEqual(decimal.MaxValue - 3m + 0.00000001m, quantity?.value);
        Assert.AreEqual("mg", quantity?.unit);
    }

    /// <summary>A size outside the type's range is null, not the value it wraps around to.</summary>
    [TestMethod]
    public void Size_OutsideTheTypesRange_IsNull()
    {
        Assert.IsNull(Operators().Size(new CqlInterval<int?>(int.MinValue, int.MaxValue, true, true)));
        Assert.IsNull(Operators().Size(new CqlInterval<long?>(0L, long.MaxValue, true, true)));
        Assert.IsNull(Operators().Size(new CqlInterval<int?>(null, 3, true, true)));
    }
}
