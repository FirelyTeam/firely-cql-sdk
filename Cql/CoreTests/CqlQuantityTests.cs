/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable
using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;

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

}