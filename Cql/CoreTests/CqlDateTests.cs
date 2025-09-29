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
}