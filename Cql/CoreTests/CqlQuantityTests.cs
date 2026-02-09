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
public class CqlQuantityTests
{
    [TestMethod]
    public void Negate_PositiveValue_ReturnsNegativeValue()
    {
        var quantity = new CqlQuantity(5.5m, "mg");
        var negated = CqlQuantity.Negate(quantity);

        Assert.IsNotNull(negated);
        Assert.AreEqual(-5.5m, negated.value);
        Assert.AreEqual("mg", negated.unit);
    }

    [TestMethod]
    public void Negate_NullValue_ReturnsNullValueWithUnit()
    {
        var quantity = new CqlQuantity(null, "mg");
        var negated = CqlQuantity.Negate(quantity);

        Assert.IsNotNull(negated);
        Assert.IsNull(negated.value);
        Assert.AreEqual("mg", negated.unit);
    }

    [TestMethod]
    public void Negate_NullQuantity_ReturnsNull()
    {
        CqlQuantity? quantity = null;
        var negated = CqlQuantity.Negate(quantity);

        Assert.IsNull(negated);
    }

    [TestMethod]
    public void OperatorNegate_PositiveValue_ReturnsNegativeValue()
    {
        var quantity = new CqlQuantity(10m, "g");
        var negated = -quantity;

        Assert.IsNotNull(negated);
        Assert.AreEqual(-10m, negated.value);
        Assert.AreEqual("g", negated.unit);
    }

    [TestMethod]
    public void OperatorNegate_NullValue_ReturnsNullValueWithUnit()
    {
        var quantity = new CqlQuantity(null, "g");
        var negated = -quantity;

        Assert.IsNotNull(negated);
        Assert.IsNull(negated.value);
        Assert.AreEqual("g", negated.unit);
    }

    [TestMethod]
    public void OperatorNegate_NullQuantity_ReturnsNull()
    {
        CqlQuantity? quantity = null;
        var negated = -quantity;

        Assert.IsNull(negated);
    }

    [TestMethod]
    public void Divide_SameUnits_ReturnsUnitless()
    {
        var operators = new Hl7.Cql.Operators.CqlOperators(
            Hl7.Cql.Runtime.FhirCqlContext.ForBundle());

        var left = new CqlQuantity(6m, "mg");
        var right = new CqlQuantity(3m, "mg");
        var result = operators.Divide(left, right);

        Assert.IsNotNull(result);
        Assert.AreEqual(2m, result.value);
        Assert.AreEqual("1", result.unit); // Unitless
    }

    [TestMethod]
    public void Divide_DifferentUnits_ReturnsCompoundUnit()
    {
        var operators = new Hl7.Cql.Operators.CqlOperators(
            Hl7.Cql.Runtime.FhirCqlContext.ForBundle());

        var left = new CqlQuantity(10m, "mg");
        var right = new CqlQuantity(2m, "mL");
        var result = operators.Divide(left, right);

        Assert.IsNotNull(result);
        Assert.AreEqual(5m, result.value);
        // The result should be mg/mL or an equivalent UCUM representation
        Assert.IsTrue(result.unit?.Contains("mg") == true && result.unit?.Contains("mL") == true ||
                     result.unit?.Contains("/") == true);
    }

    [TestMethod]
    public void Divide_ByUnitless_PreservesLeftUnit()
    {
        var operators = new Hl7.Cql.Operators.CqlOperators(
            Hl7.Cql.Runtime.FhirCqlContext.ForBundle());

        var left = new CqlQuantity(10m, "mg");
        var right = new CqlQuantity(2m, "1");
        var result = operators.Divide(left, right);

        Assert.IsNotNull(result);
        Assert.AreEqual(5m, result.value);
        Assert.AreEqual("mg", result.unit);
    }

    [TestMethod]
    public void Divide_ByZero_ReturnsNull()
    {
        var operators = new Hl7.Cql.Operators.CqlOperators(
            Hl7.Cql.Runtime.FhirCqlContext.ForBundle());

        var left = new CqlQuantity(10m, "mg");
        var right = new CqlQuantity(0m, "mg");
        var result = operators.Divide(left, right);

        Assert.IsNull(result);
    }

}