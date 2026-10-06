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
    public void Add_FinerUnitBeyondIntegerRangeAfterConversion_ReturnsNull()
    {
        // 100000000000 days convert to 3333333333 months for a month-precision value, more than Integer can hold.
        var date = new CqlDate(2014, 6, null);
        var quantity = new CqlQuantity(100000000000m, "days");
        Assert.IsNull(date.Add(quantity), "Adding a quantity that overflows after conversion should return null");
        Assert.IsNull(date.Subtract(quantity), "Subtracting a quantity that overflows after conversion should return null");
    }

    [TestMethod]
    public void Add_FinerUnitBeyondDecimalRangeDuringConversion_ReturnsNull()
    {
        // Converting the largest decimal number of days to years overflows the decimal multiplication itself.
        var date = new CqlDate(2014, null, null);
        var quantity = new CqlQuantity(decimal.MaxValue, "days");
        Assert.IsNull(date.Add(quantity), "Adding a quantity whose conversion overflows should return null");
        Assert.IsNull(date.Subtract(quantity), "Subtracting a quantity whose conversion overflows should return null");
    }

    [DataTestMethod]
    [DataRow("h")]
    [DataRow("hour")]
    [DataRow("hours")]
    [DataRow("min")]
    [DataRow("minute")]
    [DataRow("minutes")]
    [DataRow("s")]
    [DataRow("second")]
    [DataRow("seconds")]
    [DataRow("ms")]
    [DataRow("millisecond")]
    [DataRow("milliseconds")]
    public void Add_TimeBasedUnit_ThrowsCqlUnsupportedTemporalUnitError(string unit)
    {
        var date = new CqlDate(2024, 1, 15);
        var quantity = new CqlQuantity(1, unit);

        var exception = Assert.ThrowsException<CqlException<CqlUnsupportedTemporalUnitError>>(() => date.Add(quantity));

        Assert.AreEqual(new CqlUnsupportedTemporalUnitError(unit, "Date"), exception.Error);
        StringAssert.Contains(exception.Message, "For Date values, the quantity unit must be one of: years, months, weeks, or days.");
    }

    [DataTestMethod]
    [DataRow("h")]
    [DataRow("hour")]
    [DataRow("hours")]
    [DataRow("min")]
    [DataRow("minute")]
    [DataRow("minutes")]
    [DataRow("s")]
    [DataRow("second")]
    [DataRow("seconds")]
    [DataRow("ms")]
    [DataRow("millisecond")]
    [DataRow("milliseconds")]
    public void Subtract_TimeBasedUnit_ThrowsCqlUnsupportedTemporalUnitError(string unit)
    {
        var date = new CqlDate(2024, 1, 15);
        var quantity = new CqlQuantity(1, unit);

        var exception = Assert.ThrowsException<CqlException<CqlUnsupportedTemporalUnitError>>(() => date.Subtract(quantity));

        Assert.AreEqual(new CqlUnsupportedTemporalUnitError(unit, "Date"), exception.Error);
        StringAssert.Contains(exception.Message, "For Date values, the quantity unit must be one of: years, months, weeks, or days.");
    }

    [TestMethod]
    public void Add_UcumYear_ThrowsCqlExceptionAsCqlUcumYearArithmeticError()
    {
        // Per CQL spec and FHIRPath: definite-duration UCUM unit 'a' cannot be used in date/time arithmetic above days
        var date = new CqlDate(2024, 1, 31);
        Assert.ThrowsException<CqlException<CqlUcumYearArithmeticError>>(() => date.Add(new CqlQuantity(1m, "a")));
    }

    [TestMethod]
    public void Add_UcumYear_Multiple_ThrowsCqlExceptionAsCqlUcumYearArithmeticError()
    {
        // Regression: even with multiple years the definite-duration error must be signalled
        var date = new CqlDate(2020, 1, 15);
        Assert.ThrowsException<CqlException<CqlUcumYearArithmeticError>>(() => date.Add(new CqlQuantity(2m, "a")));
    }

    [TestMethod]
    public void Subtract_UcumYear_ThrowsCqlExceptionAsCqlUcumYearArithmeticError()
    {
        var date = new CqlDate(2024, 3, 15);
        Assert.ThrowsException<CqlException<CqlUcumYearArithmeticError>>(() => date.Subtract(new CqlQuantity(1m, "a")));
    }

    [TestMethod]
    public void Add_UcumMonth_ThrowsCqlExceptionAsCqlUcumMonthArithmeticError()
    {
        // Per CQL spec and FHIRPath: definite-duration UCUM unit 'mo' cannot be used in date/time arithmetic above days
        var date = new CqlDate(2024, 1, 31);
        Assert.ThrowsException<CqlException<CqlUcumMonthArithmeticError>>(() => date.Add(new CqlQuantity(1m, "mo")));
    }

    [TestMethod]
    public void Add_UcumMonth_Multiple_ThrowsCqlExceptionAsUcumMonthArithmeticError()
    {
        // Regression: even with multiple months the definite-duration error must be signalled
        var date = new CqlDate(2020, 1, 15);
        Assert.ThrowsException<CqlException<CqlUcumMonthArithmeticError>>(() => date.Add(new CqlQuantity(2m, "mo")));
    }

    [TestMethod]
    public void Subtract_UcumMonth_ThrowsCqlExceptionAsCqlUcumMonthArithmeticError()
    {
        var date = new CqlDate(2024, 3, 15);
        Assert.ThrowsException<CqlException<CqlUcumMonthArithmeticError>>(() => date.Subtract(new CqlQuantity(1m, "mo")));
    }

    // Per the "Add" and "Subtract" sections of "Date and Time Operators" (CQL Appendix B – Reference), a quantity more
    // precise than the date is converted to the date's precision, truncating any resulting decimal portion, before
    // it is applied: 12 months per year, 365 days per year, 30 days per month and 7 days per week.
    [DataTestMethod]
    [DataRow("2014", "24", "months", "2016", DisplayName = "Date(2014) + 24 months")]
    [DataRow("2014", "25", "months", "2016", DisplayName = "Date(2014) + 25 months")]
    [DataRow("2014", "18", "months", "2015", DisplayName = "Date(2014) + 18 months")]
    [DataRow("2014", "18.9", "months", "2015", DisplayName = "Date(2014) + 18.9 months")]
    [DataRow("2014", "11", "months", "2014", DisplayName = "Date(2014) + 11 months")]
    [DataRow("2014", "730", "days", "2016", DisplayName = "Date(2014) + 730 days")]
    [DataRow("2014", "735", "days", "2016", DisplayName = "Date(2014) + 735 days")]
    [DataRow("2014", "364", "days", "2014", DisplayName = "Date(2014) + 364 days")]
    [DataRow("2014", "53", "weeks", "2015", DisplayName = "Date(2014) + 53 weeks")]
    [DataRow("2014", "52", "weeks", "2014", DisplayName = "Date(2014) + 52 weeks")]
    [DataRow("2014", "-25", "months", "2012", DisplayName = "Date(2014) + -25 months")]
    [DataRow("2014", "-11", "months", "2014", DisplayName = "Date(2014) + -11 months")]
    [DataRow("2014", "1", "year", "2015", DisplayName = "Date(2014) + 1 year")]
    [DataRow("2014-06", "33", "days", "2014-07", DisplayName = "Date(2014,6) + 33 days")]
    [DataRow("2014-06", "29", "days", "2014-06", DisplayName = "Date(2014,6) + 29 days")]
    [DataRow("2014-06", "60", "days", "2014-08", DisplayName = "Date(2014,6) + 60 days")]
    [DataRow("2014-06", "5", "weeks", "2014-07", DisplayName = "Date(2014,6) + 5 weeks")]
    [DataRow("2014-06", "4", "weeks", "2014-06", DisplayName = "Date(2014,6) + 4 weeks")]
    [DataRow("2014-06", "2", "months", "2014-08", DisplayName = "Date(2014,6) + 2 months")]
    [DataRow("2014-06-10", "2", "weeks", "2014-06-24", DisplayName = "Date(2014,6,10) + 2 weeks")]
    [DataRow("2014-06-10", "33", "days", "2014-07-13", DisplayName = "Date(2014,6,10) + 33 days")]
    public void Add_QuantityMorePreciseThanDate_ConvertsToDatePrecisionTruncating(string date, string value, string unit, string expected) =>
        AssertArithmetic(date, d => d.Add(new CqlQuantity(decimal.Parse(value, CultureInfo.InvariantCulture), unit)), expected);

    [DataTestMethod]
    [DataRow("2014", "24", "months", "2012", DisplayName = "Date(2014) - 24 months")]
    [DataRow("2014", "25", "months", "2012", DisplayName = "Date(2014) - 25 months")]
    [DataRow("2014", "18", "months", "2013", DisplayName = "Date(2014) - 18 months")]
    [DataRow("2014", "11", "months", "2014", DisplayName = "Date(2014) - 11 months")]
    [DataRow("2014", "735", "days", "2012", DisplayName = "Date(2014) - 735 days")]
    [DataRow("2014", "364", "days", "2014", DisplayName = "Date(2014) - 364 days")]
    [DataRow("2014", "-25", "months", "2016", DisplayName = "Date(2014) - -25 months")]
    [DataRow("2014", "1", "year", "2013", DisplayName = "Date(2014) - 1 year")]
    [DataRow("2014-06", "33", "days", "2014-05", DisplayName = "Date(2014,6) - 33 days")]
    [DataRow("2014-06", "29", "days", "2014-06", DisplayName = "Date(2014,6) - 29 days")]
    [DataRow("2014-06", "5", "weeks", "2014-05", DisplayName = "Date(2014,6) - 5 weeks")]
    [DataRow("2014-06", "-33", "days", "2014-07", DisplayName = "Date(2014,6) - -33 days")]
    [DataRow("2014-06-10", "33", "days", "2014-05-08", DisplayName = "Date(2014,6,10) - 33 days")]
    public void Subtract_QuantityMorePreciseThanDate_ConvertsToDatePrecisionTruncating(string date, string value, string unit, string expected) =>
        AssertArithmetic(date, d => d.Subtract(new CqlQuantity(decimal.Parse(value, CultureInfo.InvariantCulture), unit)), expected);

    [DataTestMethod]
    [DataRow("2014")]
    [DataRow("2014-06")]
    public void Add_TimeBasedUnitToPartialDate_ThrowsArgumentException(string date)
    {
        Assert.IsTrue(CqlDate.TryParse(date, out var cqlDate));

        var exception = Assert.ThrowsException<ArgumentException>(() => cqlDate!.Add(new CqlQuantity(48m, "hours")));

        StringAssert.Contains(exception.Message, "For Date values, the quantity unit must be one of: years, months, weeks, or days.");
    }

    [TestMethod]
    public void Subtract_UcumMonthFromYearPrecisionDate_ThrowsCqlExceptionAsCqlUcumMonthArithmeticError()
    {
        Assert.IsTrue(CqlDate.TryParse("2014", out var date));
        Assert.ThrowsException<CqlException<CqlUcumMonthArithmeticError>>(() => date!.Subtract(new CqlQuantity(25m, "mo")));
    }

    private static void AssertArithmetic(string date, Func<CqlDate, CqlDate?> operation, string expected)
    {
        Assert.IsTrue(CqlDate.TryParse(date, out var cqlDate));
        Assert.IsTrue(CqlDate.TryParse(expected, out var expectedDate));

        var result = operation(cqlDate!);

        Assert.IsNotNull(result);
        Assert.AreEqual(expectedDate!.Value.Precision, result.Value.Precision);
        Assert.AreEqual(expected, result.ToString());
    }

    [TestMethod]
    [DataRow("2026-13-45", DisplayName = "month and day out of range")]
    [DataRow("2026-02-29", DisplayName = "29 February in a common year")]
    [DataRow("0000-01-01", DisplayName = "year 0")]
    public void TryParse_DateThatDoesNotExist_ReturnsFalse(string value)
    {
        Assert.IsFalse(CqlDate.TryParse(value, out var date));
        Assert.IsNull(date);
    }

    [TestMethod]
    public void TryParse_LeapDay_ReturnsTrue()
    {
        Assert.IsTrue(CqlDate.TryParse("2024-02-29", out var date));
        Assert.AreEqual("2024-02-29", date!.ToString());
    }
}
