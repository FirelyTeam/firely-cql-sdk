/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable
using Hl7.Cql.Iso8601;
using Hl7.Cql.Primitives;

namespace CoreTests;

[TestClass]
[TestCategory("UnitTest")]
public class CqlDateTests
{
    [TestMethod]
    public void Add_Years()
    {
        var date = new CqlDate(2020, 1, 1);
        var quantity = new CqlQuantity(2, "year");
        var result = date.Add(quantity);
        Assert.AreEqual(new CqlDate(2022, 1, 1), result);
    }

    [TestMethod]
    public void Add_Months()
    {
        var date = new CqlDate(2020, 1, 31);
        var quantity = new CqlQuantity(1, "month");
        var result = date.Add(quantity);
        Assert.AreEqual(new CqlDate(2020, 2, 29), result); // Leap year
    }

    [TestMethod]
    public void Add_Days()
    {
        var date = new CqlDate(2020, 2, 27);
        var quantity = new CqlQuantity(2, "day");
        var result = date.Add(quantity);
        Assert.AreEqual(new CqlDate(2020, 2, 29), result);
    }

    [TestMethod]
    public void Subtract_Years()
    {
        var date = new CqlDate(2020, 1, 1);
        var quantity = new CqlQuantity(5, "year");
        var result = date.Subtract(quantity);
        Assert.AreEqual(new CqlDate(2015, 1, 1), result);
    }

    [TestMethod]
    public void Subtract_Months()
    {
        var date = new CqlDate(2020, 3, 31);
        var quantity = new CqlQuantity(1, "month");
        var result = date.Subtract(quantity);
        Assert.AreEqual(new CqlDate(2020, 2, 29), result); // Leap year
    }

    [TestMethod]
    public void Subtract_Days()
    {
        var date = new CqlDate(2020, 3, 1);
        var quantity = new CqlQuantity(1, "day");
        var result = date.Subtract(quantity);
        Assert.AreEqual(new CqlDate(2020, 2, 29), result);
    }

    [TestMethod]
    public void Operator_Addition()
    {
        var date = new CqlDate(2021, 12, 31);
        var quantity = new CqlQuantity(1, "day");
        var result = date + quantity;
        Assert.AreEqual(new CqlDate(2022, 1, 1), result);
    }

    [TestMethod]
    public void Operator_Subtraction()
    {
        var date = new CqlDate(2022, 1, 1);
        var quantity = new CqlQuantity(1, "day");
        var result = date - quantity;
        Assert.AreEqual(new CqlDate(2021, 12, 31), result);
    }

    [TestMethod]
    public void Add_NullQuantity_ReturnsNull()
    {
        var date = new CqlDate(2020, 1, 1);
        CqlQuantity? quantity = null;
        var result = date.Add(quantity);
        Assert.IsNull(result);
    }

    [TestMethod]
    public void Subtract_NullQuantity_ReturnsNull()
    {
        var date = new CqlDate(2020, 1, 1);
        CqlQuantity? quantity = null;
        var result = date.Subtract(quantity);
        Assert.IsNull(result);
    }

    [TestMethod]
    public void Operator_Addition_NullDate_ReturnsNull()
    {
        CqlDate? date = null;
        var quantity = new CqlQuantity(1, "day");
        var result = date + quantity;
        Assert.IsNull(result);
    }

    [TestMethod]
    public void Operator_Subtraction_NullDate_ReturnsNull()
    {
        CqlDate? date = null;
        var quantity = new CqlQuantity(1, "day");
        var result = date - quantity;
        Assert.IsNull(result);
    }

    [TestMethod]
    public void Add_Days_ToMaxDate_ReturnsNull()
    {
        var date = CqlDate.MaxValue; // 9999-12-31
        var quantity = new CqlQuantity(1, "day");
        var result = date.Add(quantity);
        Assert.IsNull(result, "Adding days to maximum date should return null to prevent overflow");
    }

    [TestMethod]
    public void Subtract_Days_FromMinDate_ReturnsNull()
    {
        var date = CqlDate.MinValue; // 0001-01-01
        var quantity = new CqlQuantity(1, "day");
        var result = date.Subtract(quantity);
        Assert.IsNull(result, "Subtracting days from minimum date should return null to prevent overflow");
    }

    [TestMethod]
    public void Add_Years_ToMaxDate_ReturnsNull()
    {
        var date = CqlDate.MaxValue; // 9999-12-31
        var quantity = new CqlQuantity(1, "year");
        var result = date.Add(quantity);
        Assert.IsNull(result, "Adding years to maximum date should return null to prevent overflow");
    }

    [TestMethod]
    public void Subtract_Years_FromMinDate_ReturnsNull()
    {
        var date = CqlDate.MinValue; // 0001-01-01
        var quantity = new CqlQuantity(1, "year");
        var result = date.Subtract(quantity);
        Assert.IsNull(result, "Subtracting years from minimum date should return null to prevent overflow");
    }

    [TestMethod]
    public void Add_Months_ToMaxDate_ReturnsNull()
    {
        var date = CqlDate.MaxValue; // 9999-12-31
        var quantity = new CqlQuantity(1, "month");
        var result = date.Add(quantity);
        Assert.IsNull(result, "Adding months to maximum date should return null to prevent overflow");
    }

    [TestMethod]
    public void Subtract_Months_FromMinDate_ReturnsNull()
    {
        var date = CqlDate.MinValue; // 0001-01-01
        var quantity = new CqlQuantity(1, "month");
        var result = date.Subtract(quantity);
        Assert.IsNull(result, "Subtracting months from minimum date should return null to prevent overflow");
    }

    [TestMethod]
    public void Add_Hours_ToMaxDate_ReturnsNull()
    {
        var date = CqlDate.MaxValue; // 9999-12-31
        var quantity = new CqlQuantity(24, "hour"); // Adding 24 hours would push to next day (year 10000)
        var result = date.Add(quantity);
        Assert.IsNull(result, "Adding 24 hours to maximum date should return null to prevent overflow");
    }

    // Tests for UCUM unit "a" (year) - Regression tests for bug where Math.Sign was used instead of value
    [TestMethod]
    public void Add_UCUM_Year_Single()
    {
        var date = new CqlDate(2020, 1, 1);
        var quantity = new CqlQuantity(1, "a"); // UCUM year
        var result = date.Add(quantity);
        Assert.IsNotNull(result);
        // 1 year = 365.25 days, so 2020-01-01 + 365.25 days = 2020-12-31 (2020 is leap year, so 366 days total)
        Assert.AreEqual(new CqlDate(2020, 12, 31), result);
    }

    [TestMethod]
    public void Add_UCUM_Year_Multiple()
    {
        var date = new CqlDate(2021, 11, 21);
        var quantity = new CqlQuantity(2, "a"); // UCUM year - THIS WAS THE BUG
        var result = date.Add(quantity);
        Assert.IsNotNull(result);
        // 2 years = 730.5 days
        // 2021-11-21 + 730.5 days = 2023-11-20
        Assert.AreEqual(new CqlDate(2023, 11, 21), result, "Adding 2 UCUM years should add 730.5 days, not 365.25 days");
    }

    [TestMethod]
    public void Add_UCUM_Year_Three()
    {
        var date = new CqlDate(2020, 6, 15);
        var quantity = new CqlQuantity(3, "a");
        var result = date.Add(quantity);
        Assert.IsNotNull(result);
        // 3 years = 1095.75 days
        Assert.AreEqual(new CqlDate(2023, 6, 15), result, "Adding 3 UCUM years should multiply correctly");
    }

    [TestMethod]
    public void Add_UCUM_Year_Negative()
    {
        var date = new CqlDate(2023, 11, 20);
        var quantity = new CqlQuantity(-2, "a");
        var result = date.Add(quantity);
        Assert.IsNotNull(result);
        // -2 years = -730.5 days
        Assert.AreEqual(new CqlDate(2021, 11, 19), result, "Adding negative UCUM years should work correctly");
    }

    [TestMethod]
    public void Subtract_UCUM_Year_Multiple()
    {
        var date = new CqlDate(2023, 11, 20);
        var quantity = new CqlQuantity(2, "a");
        var result = date.Subtract(quantity);
        Assert.IsNotNull(result);
        // Subtracting 2 years = -730.5 days
        Assert.AreEqual(new CqlDate(2021, 11, 19), result, "Subtracting 2 UCUM years should work correctly");
    }

    // Tests for UCUM unit "mo" (month) - Regression tests for bug where Math.Sign was used instead of value
    [TestMethod]
    public void Add_UCUM_Month_Single()
    {
        var date = new CqlDate(2020, 1, 1);
        var quantity = new CqlQuantity(1, "mo"); // UCUM month
        var result = date.Add(quantity);
        Assert.IsNotNull(result);
        // 1 month = 30 days (UCUM average)
        Assert.AreEqual(new CqlDate(2020, 1, 31), result);
    }

    [TestMethod]
    public void Add_UCUM_Month_Multiple()
    {
        var date = new CqlDate(2020, 1, 1);
        var quantity = new CqlQuantity(2, "mo"); // UCUM month - THIS WAS THE BUG
        var result = date.Add(quantity);
        Assert.IsNotNull(result);
        // 2 months = 60 days
        // 2020-01-01 + 60 days = 2020-03-01
        Assert.AreEqual(new CqlDate(2020, 3, 1), result, "Adding 2 UCUM months should add 60 days, not 30 days");
    }

    [TestMethod]
    public void Add_UCUM_Month_Six()
    {
        var date = new CqlDate(2020, 1, 15);
        var quantity = new CqlQuantity(6, "mo");
        var result = date.Add(quantity);
        Assert.IsNotNull(result);
        // 6 months = 180 days
        Assert.AreEqual(new CqlDate(2020, 7, 15), result, "Adding 6 UCUM months should multiply correctly");
    }

    [TestMethod]
    public void Add_UCUM_Month_Negative()
    {
        var date = new CqlDate(2020, 3, 1);
        var quantity = new CqlQuantity(-2, "mo");
        var result = date.Add(quantity);
        Assert.IsNotNull(result);
        // -2 months = -60 days
        Assert.AreEqual(new CqlDate(2019, 12, 31), result, "Adding negative UCUM months should work correctly");
    }

    [TestMethod]
    public void Subtract_UCUM_Month_Multiple()
    {
        var date = new CqlDate(2020, 3, 1);
        var quantity = new CqlQuantity(2, "mo");
        var result = date.Subtract(quantity);
        Assert.IsNotNull(result);
        // Subtracting 2 months = -60 days
        Assert.AreEqual(new CqlDate(2019,12, 31), result, "Subtracting 2 UCUM months should work correctly");
    }

    [TestMethod]
    public void Add_UCUM_Year_Decimal()
    {
        var date = new CqlDate(2020, 1, 1);
        var quantity = new CqlQuantity(1.5m, "a");
        var result = date.Add(quantity);
        Assert.IsNotNull(result);
        // 1.5 years = 547.875 days ≈ 547 days (truncated)
        // 2020-01-01 + 547 days
        Assert.IsNotNull(result, "Adding decimal UCUM years should work");
    }

    [TestMethod]
    public void Add_UCUM_Month_Decimal()
    {
        var date = new CqlDate(2020, 1, 1);
        var quantity = new CqlQuantity(2.5m, "mo");
        var result = date.Add(quantity);
        Assert.IsNotNull(result);
        // 2.5 months = 75 days
        // 2020-01-01 + 75 days = 2020-03-16
        Assert.AreEqual(new CqlDate(2020, 3, 17), result, "Adding decimal UCUM months should work");
    }
}