/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Abstractions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;

namespace CoreTests;

[TestClass]
[TestCategory("UnitTest")]
public class CqlQuantityTests
{
    private static ICqlOperators GetOperators() => FhirCqlContext.WithDataSource().Operators;
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

    #region Add

    [TestMethod]
    public void Add_SameUnit_ReturnsSumWithSameUnit()
    {
        var ops = GetOperators();
        var result = ops.Add(new CqlQuantity(1m, "mg"), new CqlQuantity(2m, "mg"));
        Assert.IsNotNull(result);
        Assert.AreEqual(3m, result.value);
        Assert.AreEqual("mg", result.unit);
    }

    /// <summary>
    /// CQL treats singular/plural calendar duration units as equivalent (e.g. "year" == "years").
    /// The result keeps the left operand's unit.
    /// </summary>
    [TestMethod]
    public void Add_CqlCalendarAlias_PluralPlusSingular_ReturnsSumWithLeftUnit()
    {
        var ops = GetOperators();
        var result = ops.Add(new CqlQuantity(3m, "years"), new CqlQuantity(2m, "year"));
        Assert.IsNotNull(result);
        Assert.AreEqual(5m, result.value);
        Assert.AreEqual("years", result.unit);
    }

    /// <summary>
    /// Adding commensurable UCUM quantities (kg + g) delegates to IMetricService.TryAdd,
    /// which canonicalises both operands and returns the result in canonical units.
    /// </summary>
    [TestMethod, Ignore("Requires a full IMetricService implementation (e.g. Firely.UCUM); the default FhirMetricService does not implement TryAdd.")]
    public void Add_CommensurableUcumUnits_ReturnsSumInCanonicalUnit()
    {
        var ops = GetOperators();
        var result = ops.Add(new CqlQuantity(1m, "kg"), new CqlQuantity(500m, "g"));
        Assert.IsNotNull(result);
        // FhirMetricService canonicalises kg and g to g; 1 kg = 1000 g + 500 g = 1500 g
        Assert.AreEqual(1500m, result!.value);
        Assert.AreEqual("g", result.unit);
    }

    [TestMethod]
    [ExpectedException(typeof(NotSupportedException))]
    public void Add_IncompatibleUnits_Throws()
    {
        var ops = GetOperators();
        ops.Add(new CqlQuantity(1m, "kg"), new CqlQuantity(1m, "s"));
    }

    [TestMethod]
    public void Add_NullLeft_ReturnsNull()
    {
        var ops = GetOperators();
        Assert.IsNull(ops.Add((CqlQuantity?)null, new CqlQuantity(1m, "mg")));
    }

    [TestMethod]
    public void Add_NullRight_ReturnsNull()
    {
        var ops = GetOperators();
        Assert.IsNull(ops.Add(new CqlQuantity(1m, "mg"), (CqlQuantity?)null));
    }

    #endregion

    #region Subtract

    [TestMethod]
    public void Subtract_SameUnit_ReturnsCorrectDifference()
    {
        var ops = GetOperators();
        var result = ops.Subtract(new CqlQuantity(5m, "mg"), new CqlQuantity(3m, "mg"));
        Assert.IsNotNull(result);
        Assert.AreEqual(2m, result.value);
        Assert.AreEqual("mg", result.unit);
    }

    /// <summary>
    /// Regression test: previously called Add instead of Subtract in the mixed-unit branch,
    /// so "5 days - 3 day" would return 8 instead of 2.
    /// </summary>
    [TestMethod]
    public void Subtract_CqlCalendarAlias_PluralMinusSingular_ReturnsCorrectDifference()
    {
        var ops = GetOperators();
        var result = ops.Subtract(new CqlQuantity(5m, "days"), new CqlQuantity(3m, "day"));
        Assert.IsNotNull(result);
        Assert.AreEqual(2m, result.value);
        Assert.AreEqual("days", result.unit);
    }

    [TestMethod]
    public void Subtract_NullLeft_ReturnsNull()
    {
        var ops = GetOperators();
        Assert.IsNull(ops.Subtract((CqlQuantity?)null, new CqlQuantity(3m, "mg")));
    }

    [TestMethod]
    public void Subtract_NullRight_ReturnsNull()
    {
        var ops = GetOperators();
        Assert.IsNull(ops.Subtract(new CqlQuantity(5m, "mg"), null));
    }

    /// <summary>
    /// Subtracting commensurable UCUM quantities (kg - g) delegates to IMetricService.TrySubtract,
    /// which canonicalises both operands and returns the result in canonical units.
    /// </summary>
    [TestMethod, Ignore("Requires a full IMetricService implementation (e.g. Firely.UCUM); the default FhirMetricService does not implement TrySubtract.")]
    public void Subtract_CommensurableUcumUnits_ReturnsDifferenceInCanonicalUnit()
    {
        var ops = GetOperators();
        var result = ops.Subtract(new CqlQuantity(2m, "kg"), new CqlQuantity(500m, "g"));
        Assert.IsNotNull(result);
        // FhirMetricService canonicalises kg and g to g; 2 kg = 2000 g - 500 g = 1500 g
        Assert.AreEqual(1500m, result!.value);
        Assert.AreEqual("g", result.unit);
    }

    [TestMethod]
    [ExpectedException(typeof(NotSupportedException))]
    public void Subtract_IncompatibleUnits_Throws()
    {
        var ops = GetOperators();
        ops.Subtract(new CqlQuantity(1m, "kg"), new CqlQuantity(1m, "s"));
    }

    #endregion

    #region Modulo

    [TestMethod]
    public void Modulo_SameUnit_ReturnsCorrectRemainder()
    {
        var ops = GetOperators();
        var result = ops.Modulo(new CqlQuantity(7m, UCUMUnits.Day), new CqlQuantity(3m, UCUMUnits.Day));
        Assert.IsNotNull(result);
        Assert.AreEqual(1m, result.value);
        Assert.AreEqual(UCUMUnits.Day, result.unit);
    }

    /// <summary>
    /// Regression test: previously called Add instead of Modulo in the mixed-unit branch,
    /// so "7 days % 3 day" would return 10 instead of 1.
    /// </summary>
    [TestMethod]
    public void Modulo_CqlCalendarAlias_PluralModuloSingular_ReturnsCorrectRemainder()
    {
        var ops = GetOperators();
        var result = ops.Modulo(new CqlQuantity(7m, "days"), new CqlQuantity(3m, "day"));
        Assert.IsNotNull(result);
        Assert.AreEqual(1m, result.value);
        Assert.AreEqual("days", result.unit);
    }

    [TestMethod]
    public void Modulo_NullLeft_ReturnsNull()
    {
        var ops = GetOperators();
        Assert.IsNull(ops.Modulo(null!, new CqlQuantity(3m, "mg")));
    }

    #endregion

    #region Between

    [TestMethod]
    public void Between_CqlQuantity_SameUnit_WithinRange_ReturnsTrue()
    {
        var ops = GetOperators();
        Assert.IsTrue(ops.Between(new CqlQuantity(5m, "mg"), new CqlQuantity(1m, "mg"), new CqlQuantity(10m, "mg")));
    }

    [TestMethod]
    public void Between_CqlQuantity_SameUnit_OnLowBoundary_ReturnsTrue()
    {
        var ops = GetOperators();
        Assert.IsTrue(ops.Between(new CqlQuantity(1m, "mg"), new CqlQuantity(1m, "mg"), new CqlQuantity(10m, "mg")));
    }

    [TestMethod]
    public void Between_CqlQuantity_SameUnit_OnHighBoundary_ReturnsTrue()
    {
        var ops = GetOperators();
        Assert.IsTrue(ops.Between(new CqlQuantity(10m, "mg"), new CqlQuantity(1m, "mg"), new CqlQuantity(10m, "mg")));
    }

    [TestMethod]
    public void Between_CqlQuantity_SameUnit_BelowRange_ReturnsFalse()
    {
        var ops = GetOperators();
        Assert.IsFalse(ops.Between(new CqlQuantity(0m, "mg"), new CqlQuantity(1m, "mg"), new CqlQuantity(10m, "mg")));
    }

    [TestMethod]
    public void Between_CqlQuantity_SameUnit_AboveRange_ReturnsFalse()
    {
        var ops = GetOperators();
        Assert.IsFalse(ops.Between(new CqlQuantity(11m, "mg"), new CqlQuantity(1m, "mg"), new CqlQuantity(10m, "mg")));
    }

    /// <summary>
    /// Verifies cross-unit Between works by canonicalizing via IMetricService.
    /// 500 g is between 400 g (= 0.4 kg) and 1000 g (= 1 kg).
    /// </summary>
    [TestMethod]
    public void Between_CqlQuantity_CrossUnit_UsesCanonicalisation()
    {
        var ops = GetOperators();
        Assert.IsTrue(ops.Between(new CqlQuantity(500m, "g"), new CqlQuantity(0.4m, "kg"), new CqlQuantity(1m, "kg")));
    }

    [TestMethod]
    public void Between_CqlQuantity_NullArgument_ReturnsNull()
    {
        var ops = GetOperators();
        Assert.IsNull(ops.Between((CqlQuantity?)null, new CqlQuantity(1m, "mg"), new CqlQuantity(10m, "mg")));
    }

    [TestMethod]
    public void Between_CqlQuantity_NullLow_ReturnsNull()
    {
        var ops = GetOperators();
        Assert.IsNull(ops.Between(new CqlQuantity(5m, "mg"), null, new CqlQuantity(10m, "mg")));
    }

    #endregion

    #region Divide

    [TestMethod]
    public void Divide_SameUnit_ReturnsQuotientWithUnitOne()
    {
        var ops = GetOperators();
        var result = ops.Divide(new CqlQuantity(6m, "mg"), new CqlQuantity(2m, "mg"));
        Assert.IsNotNull(result);
        Assert.AreEqual(3m, result.value);
        Assert.AreEqual(UCUMUnits.Default, result.unit);
    }

    [TestMethod]
    public void Divide_ByScalar_ReturnsQuotientWithLeftUnit()
    {
        var ops = GetOperators();
        var result = ops.Divide(new CqlQuantity(6m, "mg"), new CqlQuantity(2m, UCUMUnits.Default));
        Assert.IsNotNull(result);
        Assert.AreEqual(3m, result.value);
        Assert.AreEqual("mg", result.unit);
    }

    [TestMethod]
    public void Divide_ByZero_ReturnsNull()
    {
        var ops = GetOperators();
        Assert.IsNull(ops.Divide(new CqlQuantity(6m, "mg"), new CqlQuantity(0m, "mg")));
    }

    /// <summary>
    /// Dividing commensurable UCUM quantities (kg / g) delegates to IMetricService.TryDivide.
    /// TryDivide canonicalises both operands first: 2 kg → 2000 g, then 2000 g / 1 g = 2000 (dimensionless).
    /// </summary>
    [TestMethod]
    public void Divide_CommensurableUcumUnits_ReturnsDimensionlessQuotient()
    {
        var ops = GetOperators();
        var result = ops.Divide(new CqlQuantity(2m, "kg"), new CqlQuantity(1m, "g"));
        Assert.IsNotNull(result);
        Assert.AreEqual(2000m, result!.value);
        // FhirMetricService returns "" (empty) for the dimensionless unit when units cancel
        Assert.AreEqual(string.Empty, result.unit);
    }

    /// <summary>
    /// FhirMetricService.TryDivide canonicalises operands before dividing:
    /// 6 kg → 6000 g, so 6 kg / 2 s = 3000 (g/s as compound unit).
    /// </summary>
    [TestMethod]
    public void Divide_DifferentValidUcumUnits_ReturnsCompoundUnitResult()
    {
        var ops = GetOperators();
        var result = ops.Divide(new CqlQuantity(6m, "kg"), new CqlQuantity(2m, "s"));
        Assert.IsNotNull(result);
        Assert.AreEqual(3000m, result!.value);
    }

    [TestMethod]
    public void Divide_NullLeft_ReturnsNull()
    {
        var ops = GetOperators();
        Assert.IsNull(ops.Divide((CqlQuantity?)null, new CqlQuantity(2m, "mg")));
    }

    #endregion

    #region Multiply

    [TestMethod]
    public void Multiply_ByScalar_ReturnsScalarProduct()
    {
        var ops = GetOperators();
        var unitedQuantity = new CqlQuantity(3m, "mg");
        var scalarQuantity = new CqlQuantity(4m, UCUMUnits.Default);

        var result1 = ops.Multiply(unitedQuantity, scalarQuantity);
        Assert.IsNotNull(result1);
        Assert.AreEqual(12m, result1.value);
        Assert.AreEqual(UCUMUnits.Default, result1.unit);

        var result2 = ops.Multiply(scalarQuantity, unitedQuantity);
        Assert.IsNotNull(result2);
        Assert.AreEqual(12m, result2.value);
        Assert.AreEqual(UCUMUnits.Default, result2.unit);
    }

    [TestMethod]
    public void Multiply_UcumUnits_ReturnsProductWithCombinedUnit()
    {
        var ops = GetOperators();
        var result = ops.Multiply(new CqlQuantity(3m, "m"), new CqlQuantity(2m, "m"));
        Assert.IsNotNull(result);
        Assert.AreEqual(6m, result.value);
        Assert.AreEqual("m2", result.unit);
    }

    [TestMethod]
    public void Multiply_NullLeft_ReturnsNull()
    {
        var ops = GetOperators();
        Assert.IsNull(ops.Multiply((CqlQuantity?)null, new CqlQuantity(4m, UCUMUnits.Default)));
    }

    #endregion

    #region CanConvertQuantity

    [TestMethod]
    public void CanConvertQuantity_NullArgument_ReturnsNull()
    {
        var ops = GetOperators();
        Assert.IsNull(ops.CanConvertQuantity(null, "kg"));
    }

    [TestMethod]
    public void CanConvertQuantity_NullUnit_ReturnsNull()
    {
        var ops = GetOperators();
        Assert.IsNull(ops.CanConvertQuantity(new CqlQuantity(1m, "kg"), null));
    }

    [TestMethod]
    public void CanConvertQuantity_SameUnit_ReturnsTrue()
    {
        var ops = GetOperators();
        Assert.IsTrue(ops.CanConvertQuantity(new CqlQuantity(1m, "kg"), "kg"));
    }

    /// <summary>
    /// Inches to feet is a pre-configured conversion in UnitConverter, so this must return true.
    /// </summary>
    [TestMethod]
    public void CanConvertQuantity_PreConfiguredLengthConversion_ReturnsTrue()
    {
        var ops = GetOperators();
        Assert.IsTrue(ops.CanConvertQuantity(new CqlQuantity(12m, UCUMUnits.Inch), UCUMUnits.Foot));
    }

    /// <summary>
    /// Days to months is a pre-configured calendar conversion in UnitConverter, so this must return true.
    /// </summary>
    [TestMethod]
    public void CanConvertQuantity_PreConfiguredCalendarConversion_ReturnsTrue()
    {
        var ops = GetOperators();
        Assert.IsTrue(ops.CanConvertQuantity(new CqlQuantity(30m, UCUMUnits.Day), UCUMUnits.Month));
    }

    [TestMethod]
    public void CanConvertQuantity_IncompatibleUnits_ReturnsFalse()
    {
        var ops = GetOperators();
        Assert.IsFalse(ops.CanConvertQuantity(new CqlQuantity(1m, "kg"), "s"));
    }

    #endregion
}