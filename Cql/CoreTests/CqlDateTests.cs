/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable
using Hl7.Cql.Exceptions;
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
    public void Add_UcumYear_ThrowsArgumentException()
    {
        // Per CQL spec and FHIRPath: definite-duration UCUM unit 'a' cannot be used in date/time arithmetic above days
        var date = new CqlDate(2024, 1, 31);
        Assert.ThrowsException<CqlArithmeticException>(() => date.Add(new CqlQuantity(1m, "a")));
    }

    [TestMethod]
    public void Add_UcumYear_Multiple_ThrowsArgumentException()
    {
        // Regression: even with multiple years the definite-duration error must be signalled
        var date = new CqlDate(2020, 1, 15);
        Assert.ThrowsException<CqlArithmeticException>(() => date.Add(new CqlQuantity(2m, "a")));
    }

    [TestMethod]
    public void Subtract_UcumYear_ThrowsArgumentException()
    {
        var date = new CqlDate(2024, 3, 15);
        Assert.ThrowsException<CqlArithmeticException>(() => date.Subtract(new CqlQuantity(1m, "a")));
    }

    [TestMethod]
    public void Add_UcumMonth_ThrowsArgumentException()
    {
        // Per CQL spec and FHIRPath: definite-duration UCUM unit 'mo' cannot be used in date/time arithmetic above days
        var date = new CqlDate(2024, 1, 31);
        Assert.ThrowsException<CqlArithmeticException>(() => date.Add(new CqlQuantity(1m, "mo")));
    }

    [TestMethod]
    public void Add_UcumMonth_Multiple_ThrowsArgumentException()
    {
        // Regression: even with multiple months the definite-duration error must be signalled
        var date = new CqlDate(2020, 1, 15);
        Assert.ThrowsException<CqlArithmeticException>(() => date.Add(new CqlQuantity(2m, "mo")));
    }

    [TestMethod]
    public void Subtract_UcumMonth_ThrowsArgumentException()
    {
        var date = new CqlDate(2024, 3, 15);
        Assert.ThrowsException<CqlArithmeticException>(() => date.Subtract(new CqlQuantity(1m, "mo")));
    }}
