/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable
using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;

namespace CoreTests;

/// <summary>
/// Covers the scalar (point) <c>after</c>/<c>before</c> operators on Date, DateTime and Time.
/// Per the CQL spec (§9.B After / Before) "If either or both arguments are null, the result is
/// null" — see https://github.com/FirelyTeam/firely-cql-sdk/issues/1598, where these returned a
/// boolean because the point comparison fell through to the comparer's total ordering of null.
/// The operands are cast to <see cref="object"/> so the <c>(object?, object?, string?)</c>
/// overload binds, which is what generated code calls for point comparisons.
/// </summary>
[TestClass]
[TestCategory("UnitTest")]
public class ScalarAfterBeforeNullOperandTests
{
    private static ICqlOperators Operators => FhirCqlContext.WithDataSource().Operators;

    private static object? Boxed(CqlDateTime? value) => value;

    private static object? Boxed(CqlDate? value) => value;

    private static object? Boxed(CqlTime? value) => value;

    private static CqlDateTime DateTime(int year, int? month = null, int? day = null) =>
        new(year, month, day, null, null, null, null, null, null);

    private static CqlDate Date(int year, int? month = null, int? day = null) =>
        new(year, month, day);

    private static CqlTime Time(int hour, int? minute = null, int? second = null) =>
        new(hour, minute, second, null, null, null);

    #region DateTime — null operands

    [TestMethod]
    public void DateTime_After_NullLeft_IsNull() =>
        Assert.IsNull(Operators.After(Boxed((CqlDateTime?)null), Boxed(DateTime(2024, 1, 1)), null));

    [TestMethod]
    public void DateTime_After_NullRight_IsNull() =>
        Assert.IsNull(Operators.After(Boxed(DateTime(2024, 1, 1)), Boxed((CqlDateTime?)null), null));

    [TestMethod]
    public void DateTime_After_BothNull_IsNull() =>
        Assert.IsNull(Operators.After(Boxed((CqlDateTime?)null), Boxed((CqlDateTime?)null), null));

    [TestMethod]
    public void DateTime_Before_NullLeft_IsNull() =>
        Assert.IsNull(Operators.Before(Boxed((CqlDateTime?)null), Boxed(DateTime(2024, 1, 1)), null));

    [TestMethod]
    public void DateTime_Before_NullRight_IsNull() =>
        Assert.IsNull(Operators.Before(Boxed(DateTime(2024, 1, 1)), Boxed((CqlDateTime?)null), null));

    [TestMethod]
    public void DateTime_Before_BothNull_IsNull() =>
        Assert.IsNull(Operators.Before(Boxed((CqlDateTime?)null), Boxed((CqlDateTime?)null), null));

    #endregion

    #region Date — null operands

    [TestMethod]
    public void Date_After_NullLeft_IsNull() =>
        Assert.IsNull(Operators.After(Boxed((CqlDate?)null), Boxed(Date(2024, 1, 1)), null));

    [TestMethod]
    public void Date_After_NullRight_IsNull() =>
        Assert.IsNull(Operators.After(Boxed(Date(2024, 1, 1)), Boxed((CqlDate?)null), null));

    [TestMethod]
    public void Date_After_BothNull_IsNull() =>
        Assert.IsNull(Operators.After(Boxed((CqlDate?)null), Boxed((CqlDate?)null), null));

    [TestMethod]
    public void Date_Before_NullLeft_IsNull() =>
        Assert.IsNull(Operators.Before(Boxed((CqlDate?)null), Boxed(Date(2024, 1, 1)), null));

    [TestMethod]
    public void Date_Before_NullRight_IsNull() =>
        Assert.IsNull(Operators.Before(Boxed(Date(2024, 1, 1)), Boxed((CqlDate?)null), null));

    [TestMethod]
    public void Date_Before_BothNull_IsNull() =>
        Assert.IsNull(Operators.Before(Boxed((CqlDate?)null), Boxed((CqlDate?)null), null));

    #endregion

    #region Time — null operands

    [TestMethod]
    public void Time_After_NullLeft_IsNull() =>
        Assert.IsNull(Operators.After(Boxed((CqlTime?)null), Boxed(Time(10, 15, 0)), null));

    [TestMethod]
    public void Time_After_NullRight_IsNull() =>
        Assert.IsNull(Operators.After(Boxed(Time(10, 15, 0)), Boxed((CqlTime?)null), null));

    [TestMethod]
    public void Time_After_BothNull_IsNull() =>
        Assert.IsNull(Operators.After(Boxed((CqlTime?)null), Boxed((CqlTime?)null), null));

    [TestMethod]
    public void Time_Before_NullLeft_IsNull() =>
        Assert.IsNull(Operators.Before(Boxed((CqlTime?)null), Boxed(Time(10, 15, 0)), null));

    [TestMethod]
    public void Time_Before_NullRight_IsNull() =>
        Assert.IsNull(Operators.Before(Boxed(Time(10, 15, 0)), Boxed((CqlTime?)null), null));

    [TestMethod]
    public void Time_Before_BothNull_IsNull() =>
        Assert.IsNull(Operators.Before(Boxed((CqlTime?)null), Boxed((CqlTime?)null), null));

    #endregion

    #region Controls — non-null operands are unaffected

    [TestMethod]
    public void DateTime_After_NonNullOperands_Unchanged()
    {
        var operators = Operators;
        Assert.AreEqual(true, operators.After(Boxed(DateTime(2024, 1, 2)), Boxed(DateTime(2024, 1, 1)), null));
        Assert.AreEqual(false, operators.After(Boxed(DateTime(2024, 1, 1)), Boxed(DateTime(2024, 1, 2)), null));
        Assert.AreEqual(false, operators.After(Boxed(DateTime(2024, 1, 1)), Boxed(DateTime(2024, 1, 1)), null));
    }

    [TestMethod]
    public void DateTime_Before_NonNullOperands_Unchanged()
    {
        var operators = Operators;
        Assert.AreEqual(true, operators.Before(Boxed(DateTime(2024, 1, 1)), Boxed(DateTime(2024, 1, 2)), null));
        Assert.AreEqual(false, operators.Before(Boxed(DateTime(2024, 1, 2)), Boxed(DateTime(2024, 1, 1)), null));
        Assert.AreEqual(false, operators.Before(Boxed(DateTime(2024, 1, 1)), Boxed(DateTime(2024, 1, 1)), null));
    }

    [TestMethod]
    public void Date_After_And_Before_NonNullOperands_Unchanged()
    {
        var operators = Operators;
        Assert.AreEqual(true, operators.After(Boxed(Date(2024, 1, 2)), Boxed(Date(2024, 1, 1)), null));
        Assert.AreEqual(false, operators.After(Boxed(Date(2024, 1, 1)), Boxed(Date(2024, 1, 2)), null));
        Assert.AreEqual(false, operators.After(Boxed(Date(2024, 1, 1)), Boxed(Date(2024, 1, 1)), null));
        Assert.AreEqual(true, operators.Before(Boxed(Date(2024, 1, 1)), Boxed(Date(2024, 1, 2)), null));
        Assert.AreEqual(false, operators.Before(Boxed(Date(2024, 1, 2)), Boxed(Date(2024, 1, 1)), null));
        Assert.AreEqual(false, operators.Before(Boxed(Date(2024, 1, 1)), Boxed(Date(2024, 1, 1)), null));
    }

    [TestMethod]
    public void Time_After_And_Before_NonNullOperands_Unchanged()
    {
        var operators = Operators;
        Assert.AreEqual(true, operators.After(Boxed(Time(15, 59, 59)), Boxed(Time(14, 59, 59)), null));
        Assert.AreEqual(false, operators.After(Boxed(Time(14, 59, 59)), Boxed(Time(15, 59, 59)), null));
        Assert.AreEqual(false, operators.After(Boxed(Time(14, 59, 59)), Boxed(Time(14, 59, 59)), null));
        Assert.AreEqual(true, operators.Before(Boxed(Time(14, 59, 59)), Boxed(Time(15, 59, 59)), null));
        Assert.AreEqual(false, operators.Before(Boxed(Time(15, 59, 59)), Boxed(Time(14, 59, 59)), null));
        Assert.AreEqual(false, operators.Before(Boxed(Time(14, 59, 59)), Boxed(Time(14, 59, 59)), null));
    }

    /// <summary>
    /// The null guard must not swallow the pre-existing uncertainty semantics: a year-precision
    /// operand compared against a day-precision one still has no value for the precision at which
    /// the comparison would be decided, so the result stays null for a different reason.
    /// </summary>
    [TestMethod]
    public void DateTime_After_UncertainPrecision_IsStillNull()
    {
        var operators = Operators;
        Assert.IsNull(operators.After(Boxed(DateTime(2014)), Boxed(DateTime(2014, 2, 15)), null));
        Assert.IsNull(operators.Before(Boxed(DateTime(2014)), Boxed(DateTime(2014, 2, 15)), null));
    }

    #endregion
}
