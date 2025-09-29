/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable
using Hl7.Cql.Primitives;

namespace CoreTests;

[TestClass]
[TestCategory("UnitTest")]
public class CqlTimeTests
{
    [TestMethod]
    public void AdditionOperator_AddsMinutes()
    {
        var time = new CqlTime(10, 15, 0, 0, 0, 0);
        var quantity = new CqlQuantity(5, "minute");
        var result = time + quantity;
        Assert.IsNotNull(result);
        Assert.AreEqual(10, result.Value.Hour);
        Assert.AreEqual(20, result.Value.Minute);
        Assert.AreEqual(0, result.Value.Second);
    }

    [TestMethod]
    public void AdditionOperator_AddsHours()
    {
        var time = new CqlTime(8, 0, 0, 0, 0, 0);
        var quantity = new CqlQuantity(2, "hour");
        var result = time + quantity;
        Assert.IsNotNull(result);
        Assert.AreEqual(10, result.Value.Hour);
        Assert.AreEqual(0, result.Value.Minute);
    }

    [TestMethod]
    public void SubtractionOperator_SubtractsMinutes()
    {
        var time = new CqlTime(12, 30, 0, 0, 0, 0);
        var quantity = new CqlQuantity(15, "minute");
        var result = time - quantity;
        Assert.IsNotNull(result);
        Assert.AreEqual(12, result.Value.Hour);
        Assert.AreEqual(15, result.Value.Minute);
    }

    [TestMethod]
    public void SubtractionOperator_SubtractsHours()
    {
        var time = new CqlTime(14, 0, 0, 0, 0, 0);
        var quantity = new CqlQuantity(3, "hour");
        var result = time - quantity;
        Assert.IsNotNull(result);
        Assert.AreEqual(11, result.Value.Hour);
        Assert.AreEqual(0, result.Value.Minute);
    }

    [TestMethod]
    public void AdditionOperator_NullQuantity_ReturnsNull()
    {
        var time = new CqlTime(10, 0, 0, 0, 0, 0);
        CqlQuantity? quantity = null;
        var result = time + quantity;
        Assert.IsNull(result);
    }

    [TestMethod]
    public void SubtractionOperator_NullQuantity_ReturnsNull()
    {
        var time = new CqlTime(10, 0, 0, 0, 0, 0);
        CqlQuantity? quantity = null;
        var result = time - quantity;
        Assert.IsNull(result);
    }

    [TestMethod]
    public void AdditionOperator_NullTime_ReturnsNull()
    {
        CqlTime? time = null;
        var quantity = new CqlQuantity(1, "hour");
        var result = time + quantity;
        Assert.IsNull(result);
    }

    [TestMethod]
    public void SubtractionOperator_NullTime_ReturnsNull()
    {
        CqlTime? time = null;
        var quantity = new CqlQuantity(1, "hour");
        var result = time - quantity;
        Assert.IsNull(result);
    }
}