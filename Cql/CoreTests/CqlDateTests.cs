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

    [TestMethod]
    public void Add_UcumYear_UsesCalendarMath()
    {
        // @2024-01-31 + 1 'a' should equal @2025-01-31 (calendar math), not @2025-01-30 (365.25 days)
        var date = new CqlDate(2024, 1, 31);
        var result = date.Add(new CqlQuantity(1m, "a"));
        Assert.AreEqual(new CqlDate(2025, 1, 31), result);
    }

    [TestMethod]
    public void Add_UcumYear_Multiple_UsesMagnitude()
    {
        // Regression for Math.Sign bug: adding 2 UCUM years should add 2 years, not 1 year
        var date = new CqlDate(2020, 1, 15);
        var result = date.Add(new CqlQuantity(2m, "a"));
        Assert.AreEqual(new CqlDate(2022, 1, 15), result, "Adding 2 UCUM years should add 2 calendar years, not 1");
    }

    [TestMethod]
    public void Add_UcumYear_Negative()
    {
        // Negative UCUM years should subtract calendar years
        var date = new CqlDate(2024, 3, 15);
        var result = date.Add(new CqlQuantity(-2m, "a"));
        Assert.AreEqual(new CqlDate(2022, 3, 15), result);
    }

    [TestMethod]
    public void Add_UcumMonth_UsesCalendarMath()
    {
        // @2024-01-31 + 1 'mo' should equal @2024-02-29 (calendar math, leap year), not @2024-03-01 (~30.4 days)
        var date = new CqlDate(2024, 1, 31);
        var result = date.Add(new CqlQuantity(1m, "mo"));
        Assert.AreEqual(new CqlDate(2024, 2, 29), result);
    }

    [TestMethod]
    public void Add_UcumMonth_Multiple_UsesMagnitude()
    {
        // Regression for Math.Sign bug: adding 2 UCUM months should add 2 months, not 1 month
        var date = new CqlDate(2020, 1, 15);
        var result = date.Add(new CqlQuantity(2m, "mo"));
        Assert.AreEqual(new CqlDate(2020, 3, 15), result, "Adding 2 UCUM months should add 2 calendar months, not 1");
    }

    [TestMethod]
    public void Add_UcumMonth_Negative()
    {
        // Negative UCUM months should subtract calendar months
        var date = new CqlDate(2024, 3, 15);
        var result = date.Add(new CqlQuantity(-2m, "mo"));
        Assert.AreEqual(new CqlDate(2024, 1, 15), result);
    }

    [TestMethod]
    public void Add_UcumYear_FractionalValue_Truncates()
    {
        // @2020-01-15 + 2.5 'a' should equal @2022-01-15 (truncates to 2 years)
        var date = new CqlDate(2020, 1, 15);
        var result = date.Add(new CqlQuantity(2.5m, "a"));
        Assert.AreEqual(new CqlDate(2022, 1, 15), result);
    }

    [TestMethod]
    public void Add_UcumYear_EquivalentToCalendarYear()
    {
        // UCUM 'a' should produce same result as calendar 'year'
        var date = new CqlDate(2024, 1, 31);
        var ucumResult = date.Add(new CqlQuantity(1m, "a"));
        var calendarResult = date.Add(new CqlQuantity(1m, "year"));
        Assert.AreEqual(calendarResult, ucumResult);
    }

    [TestMethod]
    public void Add_UcumMonth_EquivalentToCalendarMonth()
    {
        // UCUM 'mo' should produce same result as calendar 'month'
        var date = new CqlDate(2024, 1, 31);
        var ucumResult = date.Add(new CqlQuantity(1m, "mo"));
        var calendarResult = date.Add(new CqlQuantity(1m, "month"));
        Assert.AreEqual(calendarResult, ucumResult);
    }}
