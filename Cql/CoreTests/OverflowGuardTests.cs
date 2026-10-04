/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;

namespace CoreTests;

/// <summary>
/// "Operations that cause arithmetic overflow or underflow, or otherwise cannot be performed (such as division by 0)
/// will result in null, rather than a run-time error" (CQL 1.5.3 Errata 2, Appendix B - CQL Reference, section
/// "Arithmetic Operators").
/// </summary>
[TestClass]
[TestCategory("UnitTest")]
public class OverflowGuardTests
{
    [TestMethod]
    public void Multiply_DecimalProductTooSmallToRepresent_ReturnsNull()
    {
        Assert.IsNull(OverflowGuard.Multiply(1e-28m, 0.1m));
        Assert.IsNull(OverflowGuard.Multiply(-1e-28m, 0.1m));
    }

    [TestMethod]
    public void Divide_DecimalQuotientTooSmallToRepresent_ReturnsNull()
    {
        Assert.IsNull(OverflowGuard.Divide(1e-28m, 10m));
        Assert.IsNull(OverflowGuard.Divide(-1e-28m, 10m));
    }

    [TestMethod]
    public void Multiply_DecimalZeroOperand_ReturnsZero()
    {
        Assert.AreEqual(0m, OverflowGuard.Multiply(0m, 1e-28m));
        Assert.AreEqual(0m, OverflowGuard.Multiply(1e-28m, 0m));
        Assert.AreEqual(0m, OverflowGuard.Multiply(0m, decimal.MaxValue));
    }

    [TestMethod]
    public void Divide_DecimalZeroDividend_ReturnsZero()
    {
        Assert.AreEqual(0m, OverflowGuard.Divide(0m, 10m));
        Assert.AreEqual(0m, OverflowGuard.Divide(0m, 1e-28m));
    }

    [TestMethod]
    public void MultiplyAndDivide_DecimalSmallestRepresentableResult_ReturnsResult()
    {
        Assert.AreEqual(1e-28m, OverflowGuard.Multiply(1e-27m, 0.1m));
        Assert.AreEqual(1e-28m, OverflowGuard.Divide(1e-27m, 10m));
    }

    [TestMethod]
    public void Multiply_IntegerZeroOperand_ReturnsZero()
    {
        Assert.AreEqual(0, OverflowGuard.Multiply(0, 5));
        Assert.AreEqual(0L, OverflowGuard.Multiply(5L, 0L));
    }

    [TestMethod]
    public void TruncatedDivide_IntegerQuotientBelowOne_ReturnsZero()
    {
        Assert.AreEqual(0, OverflowGuard.TruncatedDivide(1, 10));
        Assert.AreEqual(0L, OverflowGuard.TruncatedDivide(-1L, 10L));
    }

    [TestMethod]
    public void TruncatedDivide_IntegerQuotientOutsideRange_ReturnsNull()
    {
        Assert.IsNull(OverflowGuard.TruncatedDivide(int.MinValue, -1));
        Assert.IsNull(OverflowGuard.TruncatedDivide(long.MinValue, -1L));
    }

    [TestMethod]
    public void ToDecimal_NonzeroDoubleTooSmallToRepresent_ReturnsNull()
    {
        Assert.IsNull(OverflowGuard.ToDecimal(1e-30));
        Assert.IsNull(OverflowGuard.ToDecimal(-1e-30));
        Assert.IsNull(OverflowGuard.ToDecimal(double.Epsilon));
    }

    [TestMethod]
    public void ToDecimal_Zero_ReturnsZero()
    {
        Assert.AreEqual(0m, OverflowGuard.ToDecimal(0.0));
        Assert.AreEqual(0m, OverflowGuard.ToDecimal(-0.0));
    }

    [TestMethod]
    public void ToDecimal_SmallestRepresentableMagnitude_ReturnsIt()
    {
        var result = OverflowGuard.ToDecimal(1e-28);

        Assert.IsNotNull(result);
        Assert.IsTrue(result > 0m);
    }

    /// <summary>
    /// The operators computed in <see cref="double"/> answer null with a warning for a nonzero result too small to
    /// represent as a Decimal.
    /// </summary>
    [TestMethod]
    public void Operators_DoubleResultTooSmallToRepresent_ReturnNullWithWarning()
    {
        var operators = FhirCqlContext.WithDataSource().Operators;
        var warnings = new List<string?>();
        operators.MessageReceived += (_, e) =>
        {
            if (e.Severity == "Warning")
                warnings.Add(e.Code);
        };

        Assert.IsNull(operators.Exp(-100m));
        Assert.IsNull(operators.Power(2m, -100m));
        Assert.IsNull(operators.Power(2, -100));
        CollectionAssert.AreEqual(
            new[] { "CqlOperators.ArithmeticOperators.Exp", "CqlOperators.ArithmeticOperators.Power", "CqlOperators.ArithmeticOperators.Power" },
            warnings);
    }

    [TestMethod]
    public void Operators_DecimalMultiplyAndDivideUnderflow_ReturnNull()
    {
        var operators = FhirCqlContext.WithDataSource().Operators;

        Assert.IsNull(operators.Multiply(1e-28m, 0.1m));
        Assert.IsNull(operators.Divide(1e-28m, 10m));
        Assert.IsNull(operators.Multiply(new CqlQuantity(1e-28m, "mg"), new CqlQuantity(0.1m, "1")));
        Assert.IsNull(operators.Divide(new CqlQuantity(1e-28m, "mg"), new CqlQuantity(10m, "1")));
        Assert.AreEqual(0m, operators.Multiply(0m, 0.1m));
        Assert.AreEqual(0m, operators.Divide(0m, 10m));
    }

    [TestMethod]
    public void Operators_TruncatedDivideWithQuotientBelowOne_ReturnsZero()
    {
        var operators = FhirCqlContext.WithDataSource().Operators;

        Assert.AreEqual(0m, operators.TruncatedDivide(1e-28m, 10m));
        Assert.AreEqual(0m, operators.TruncatedDivide(-1e-28m, 10m));
        Assert.AreEqual(0m, operators.TruncatedDivide(1m, 10m));
        Assert.AreEqual(0, operators.TruncatedDivide(1, 10));
        Assert.AreEqual(0L, operators.TruncatedDivide(-1L, 10L));
        Assert.AreEqual(3m, operators.TruncatedDivide(10m, 3m));
    }
}
