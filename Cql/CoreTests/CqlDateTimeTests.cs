/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable
using System.Linq.Expressions;
using Hl7.Cql.Exceptions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Iso8601;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;

namespace CoreTests;

[TestClass]
[TestCategory("UnitTest")]
public class CqlDateTimeTests
{
    private CqlContext GetNewContext() => FhirCqlContext.WithDataSource();

    [TestMethod]
    public void Add_Year_By_Units()
    {
        Assert.IsTrue(CqlDateTime.TryParse("1960", out var baseDate));
        Assert.AreEqual(DateTimePrecision.Year, baseDate!.Value.Precision);
        var plusOneYear = baseDate.Add(new CqlQuantity(1m, "year"));
        Assert.AreEqual(DateTimePrecision.Year, plusOneYear!.Value.Precision);
        Assert.IsNull(plusOneYear!.Value.Month);
        Assert.AreEqual("1961", plusOneYear.ToString());

        var plusTwelveMonths = baseDate.Add(new CqlQuantity(12m, "month"));
        Assert.AreEqual(DateTimePrecision.Year, plusTwelveMonths!.Value.Precision);
        Assert.IsNull(plusTwelveMonths!.Value.Month);
        Assert.AreEqual("1961", plusTwelveMonths.ToString());

        var plus364days = baseDate.Add(new CqlQuantity(364, "day"));
        Assert.AreEqual(DateTimePrecision.Year, plus364days!.Value.Precision);
        Assert.IsNull(plus364days!.Value.Month);
        Assert.AreEqual("1960", plus364days.ToString());

        var plus365days = baseDate.Add(new CqlQuantity(365, "day"));
        Assert.AreEqual(DateTimePrecision.Year, plus365days!.Value.Precision);
        Assert.IsNull(plus365days!.Value.Month);
        Assert.AreEqual("1961", plus365days.ToString());

        var plus366days = baseDate.Add(new CqlQuantity(366, "day"));
        Assert.AreEqual(DateTimePrecision.Year, plus366days!.Value.Precision);
        Assert.IsNull(plus366days!.Value.Month);
        Assert.AreEqual("1961", plus366days.ToString());

        var plus366DaysInHours = baseDate.Add(new CqlQuantity(366 * 24, "hours"));
        Assert.AreEqual(DateTimePrecision.Year, plus366DaysInHours!.Value.Precision);
        Assert.IsNull(plus366DaysInHours!.Value.Month);
        Assert.AreEqual("1961", plus366DaysInHours.ToString());

        var plus365DaysInSeconds = baseDate.Add(new CqlQuantity(365 * 24 * 60 * 60, "seconds"));
        Assert.AreEqual(DateTimePrecision.Year, plus365DaysInSeconds!.Value.Precision);
        Assert.IsNull(plus365DaysInSeconds!.Value.Month);
        Assert.AreEqual("1961", plus365DaysInSeconds.ToString());
    }

    [TestMethod]
    public void Add_Month()
    {
        Assert.IsTrue(CqlDateTime.TryParse("2022-01-01", out var baseDate));

        var plus1Month = baseDate!.Add(new CqlQuantity(1m, "month"));
        Assert.AreEqual(DateTimePrecision.Day, plus1Month!.Value.Precision);
        Assert.IsNull(plus1Month!.Value.Hour);
        Assert.AreEqual("2022-02-01", plus1Month.ToString());

        var plus2Months = baseDate.Add(new CqlQuantity(2m, "month"));
        Assert.AreEqual(DateTimePrecision.Day, plus2Months!.Value.Precision);
        Assert.IsNull(plus2Months!.Value.Hour);
        Assert.AreEqual("2022-03-01", plus2Months.ToString());

        var plus2pt5Months = baseDate.Add(new CqlQuantity(2.5m, "month"));
        Assert.AreEqual(DateTimePrecision.Day, plus2pt5Months!.Value.Precision);
        Assert.IsNull(plus2pt5Months!.Value.Hour);
        Assert.AreEqual("2022-03-01", plus2pt5Months.ToString());

        Assert.ThrowsException<CqlException<CqlUcumMonthArithmeticError>>(() => baseDate.Add(new CqlQuantity(1m, "mo")));

    }

    [TestMethod]
    public void Subtract_Month()
    {
        Assert.IsTrue(CqlDateTime.TryParse("2022-03-01", out var baseDate));

        var minus1Month = baseDate!.Subtract(new CqlQuantity(1m, "month"));
        Assert.AreEqual(DateTimePrecision.Day, minus1Month!.Value.Precision);
        Assert.IsNull(minus1Month!.Value.Hour);
        Assert.AreEqual("2022-02-01", minus1Month.ToString());

        var minus2Months = baseDate.Subtract(new CqlQuantity(2m, "month"));
        Assert.AreEqual(DateTimePrecision.Day, minus2Months!.Value.Precision);
        Assert.IsNull(minus2Months!.Value.Hour);
        Assert.AreEqual("2022-01-01", minus2Months.ToString());

        var minus2pt5Months = baseDate.Subtract(new CqlQuantity(2.5m, "month"));
        Assert.AreEqual(DateTimePrecision.Day, minus2pt5Months!.Value.Precision);
        Assert.IsNull(minus2pt5Months!.Value.Hour);
        Assert.AreEqual("2022-01-01", minus2pt5Months.ToString());

        Assert.ThrowsException<CqlException<CqlUcumMonthArithmeticError>>(() => baseDate.Subtract(new CqlQuantity(1m, "mo")));

    }

    [TestMethod]
    public void Subtract_Months_From_Year()
    {
        Assert.IsTrue(CqlDateTime.TryParse("2014", out var baseDate));
        var result = baseDate!.Subtract(new CqlQuantity(25m, "month"));
        Assert.AreEqual(2012, result!.Value.Year);
        Assert.AreEqual(DateTimePrecision.Year, result.Precision);
    }

    // Per the "Add" and "Subtract" sections of "Date and Time Operators" (CQL Appendix B – Reference), a quantity more
    // precise than the date time is converted to the date time's precision, truncating any resulting decimal portion,
    // before it is applied: 12 months per year, 365 days per year, 30 days per month, 7 days per week, 24 hours per
    // day, 60 minutes per hour, 60 seconds per minute and 1000 milliseconds per second.
    [DataTestMethod]
    [DataRow("2014", "24", "months", "2016", DisplayName = "DateTime(2014) + 24 months")]
    [DataRow("2014", "18", "months", "2015", DisplayName = "DateTime(2014) + 18 months")]
    [DataRow("2014", "730", "days", "2016", DisplayName = "DateTime(2014) + 730 days")]
    [DataRow("2014", "735", "days", "2016", DisplayName = "DateTime(2014) + 735 days")]
    [DataRow("2014", "8760", "hours", "2015", DisplayName = "DateTime(2014) + 8760 hours")]
    [DataRow("2014", "8759", "hours", "2014", DisplayName = "DateTime(2014) + 8759 hours")]
    [DataRow("2014", "-25", "months", "2012", DisplayName = "DateTime(2014) + -25 months")]
    [DataRow("2014-06", "33", "days", "2014-07", DisplayName = "DateTime(2014,6) + 33 days")]
    [DataRow("2014-06", "1440", "hours", "2014-08", DisplayName = "DateTime(2014,6) + 1440 hours")]
    [DataRow("2014-06", "1439", "hours", "2014-07", DisplayName = "DateTime(2014,6) + 1439 hours")]
    [DataRow("2014-06-10", "47", "hours", "2014-06-11", DisplayName = "DateTime(2014,6,10) + 47 hours")]
    [DataRow("2014-06-10", "23", "hours", "2014-06-10", DisplayName = "DateTime(2014,6,10) + 23 hours")]
    [DataRow("2014-06-10", "2880", "minutes", "2014-06-12", DisplayName = "DateTime(2014,6,10) + 2880 minutes")]
    [DataRow("2014-06-10", "2879", "minutes", "2014-06-11", DisplayName = "DateTime(2014,6,10) + 2879 minutes")]
    [DataRow("2014-06-10", "172800", "seconds", "2014-06-12", DisplayName = "DateTime(2014,6,10) + 172800 seconds")]
    [DataRow("2014-06-10", "172799", "seconds", "2014-06-11", DisplayName = "DateTime(2014,6,10) + 172799 seconds")]
    [DataRow("2014-06-10", "172800000", "milliseconds", "2014-06-12", DisplayName = "DateTime(2014,6,10) + 172800000 milliseconds")]
    [DataRow("2014-06-10", "172799999", "milliseconds", "2014-06-11", DisplayName = "DateTime(2014,6,10) + 172799999 milliseconds")]
    [DataRow("2014-06-10", "-47", "hours", "2014-06-09", DisplayName = "DateTime(2014,6,10) + -47 hours")]
    [DataRow("2014-06-10", "2", "days", "2014-06-12", DisplayName = "DateTime(2014,6,10) + 2 days")]
    [DataRow("2014-06-10", "1", "week", "2014-06-17", DisplayName = "DateTime(2014,6,10) + 1 week")]
    [DataRow("2014-06-10T10Z", "119", "minutes", "2014-06-10T11Z", DisplayName = "DateTime(2014,6,10,10) + 119 minutes")]
    [DataRow("2014-06-10T10:20Z", "119", "seconds", "2014-06-10T10:21Z", DisplayName = "DateTime(2014,6,10,10,20) + 119 seconds")]
    [DataRow("2014-06-10T10:20:30Z", "1999", "milliseconds", "2014-06-10T10:20:31Z", DisplayName = "DateTime(2014,6,10,10,20,30) + 1999 milliseconds")]
    [DataRow("2014-06-10T10:20:30Z", "-1999", "milliseconds", "2014-06-10T10:20:29Z", DisplayName = "DateTime(2014,6,10,10,20,30) + -1999 milliseconds")]
    [DataRow("2014-06-10T10:20:30Z", "2", "seconds", "2014-06-10T10:20:32Z", DisplayName = "DateTime(2014,6,10,10,20,30) + 2 seconds")]
    public void Add_QuantityMorePreciseThanDateTime_ConvertsToDateTimePrecisionTruncating(string dateTime, string value, string unit, string expected) =>
        AssertArithmetic(dateTime, d => d.Add(new CqlQuantity(decimal.Parse(value, CultureInfo.InvariantCulture), unit)), expected);

    [DataTestMethod]
    [DataRow("2014", "24", "months", "2012", DisplayName = "DateTime(2014) - 24 months")]
    [DataRow("2014", "25", "months", "2012", DisplayName = "DateTime(2014) - 25 months")]
    [DataRow("2014", "18", "months", "2013", DisplayName = "DateTime(2014) - 18 months")]
    [DataRow("2014", "11", "months", "2014", DisplayName = "DateTime(2014) - 11 months")]
    [DataRow("2014", "735", "days", "2012", DisplayName = "DateTime(2014) - 735 days")]
    [DataRow("2014", "-25", "months", "2016", DisplayName = "DateTime(2014) - -25 months")]
    [DataRow("2014-06", "33", "days", "2014-05", DisplayName = "DateTime(2014,6) - 33 days")]
    [DataRow("2016-05", "31535999", "seconds", "2015-05", DisplayName = "DateTime(2016,5) - 31535999 seconds")]
    [DataRow("2014-06-10", "47", "hours", "2014-06-09", DisplayName = "DateTime(2014,6,10) - 47 hours")]
    [DataRow("2014-06-10", "1", "hour", "2014-06-10", DisplayName = "DateTime(2014,6,10) - 1 hour")]
    [DataRow("2014-06-10T10:20:30Z", "1999", "milliseconds", "2014-06-10T10:20:29Z", DisplayName = "DateTime(2014,6,10,10,20,30) - 1999 milliseconds")]
    public void Subtract_QuantityMorePreciseThanDateTime_ConvertsToDateTimePrecisionTruncating(string dateTime, string value, string unit, string expected) =>
        AssertArithmetic(dateTime, d => d.Subtract(new CqlQuantity(decimal.Parse(value, CultureInfo.InvariantCulture), unit)), expected);

    [TestMethod]
    public void Subtract_UcumMonthFromYearPrecisionDateTime_ThrowsCqlExceptionAsCqlUcumMonthArithmeticError()
    {
        Assert.IsTrue(CqlDateTime.TryParse("2014", out var dateTime));
        Assert.ThrowsException<CqlException<CqlUcumMonthArithmeticError>>(() => dateTime!.Subtract(new CqlQuantity(25m, "mo")));
    }

    private static void AssertArithmetic(string dateTime, Func<CqlDateTime, CqlDateTime?> operation, string expected)
    {
        Assert.IsTrue(CqlDateTime.TryParse(dateTime, out var cqlDateTime));
        Assert.IsTrue(CqlDateTime.TryParse(expected, out var expectedDateTime));

        var result = operation(cqlDateTime!);

        Assert.IsNotNull(result);
        Assert.AreEqual(expectedDateTime!.Value.Precision, result.Value.Precision);
        Assert.AreEqual(expectedDateTime.ToString(), result.ToString());
    }

    [TestMethod]
    public void Subtract_Year()
    {
        Assert.IsTrue(CqlDateTime.TryParse("2025-03-01", out var baseDate));

        var minus1Year = baseDate!.Subtract(new CqlQuantity(1m, "year"));
        Assert.AreEqual(DateTimePrecision.Day, minus1Year!.Value.Precision);
        Assert.IsNull(minus1Year!.Value.Hour);
        Assert.AreEqual("2024-03-01", minus1Year.ToString());

        Assert.ThrowsException<CqlException<CqlUcumYearArithmeticError>>(() => baseDate.Subtract(new CqlQuantity(1m, "a")));

    }

    [TestMethod]
    public void Subtract_Day_and_Days()
    {
        var threeDays = new CqlQuantity(3, "days");
        var oneDay = new CqlQuantity(1, "day");
        var method = typeof(ICqlOperators)
                     .GetMethods()
                     .Where(x =>
                                x.Name == nameof(CqlOperators.Subtract) &&
                                x.GetParameters().Count() == 2 &&
                                x.GetParameters()[0].ParameterType == typeof(CqlQuantity) &&
                                x.GetParameters()[1].ParameterType == typeof(CqlQuantity)
                     ).First();


        var tdExpr = Expression.Constant(threeDays);
        var odExpr = Expression.Constant(oneDay);

        var rc = GetNewContext();
        var fcq = rc.Operators;
        var memExpr = Expression.Constant(fcq);

        var call = Expression.Call(memExpr, method, tdExpr, odExpr);
        var le = Expression.Lambda<Func<CqlQuantity>>(call);
        var compiled = le.Compile();
        var result = compiled.Invoke();


    }

    [TestMethod]
    public void BoundariesBetween_Months()
    {
        Assert.IsTrue(DateTimeIso8601.TryParse("2020-02-29", out var startDate));
        Assert.IsTrue(CqlDateTime.TryParse("2020-04-01", out var cqlStartDate));
        Assert.IsTrue(CqlDateTime.TryParse("2020-03-31", out var cqlEndDate));
        var boundariesBetween = new CqlDateTime(startDate!).BoundariesBetween(cqlStartDate!, "month");
        Assert.AreEqual(2, boundariesBetween);
        boundariesBetween = new CqlDateTime(startDate!).BoundariesBetween(cqlEndDate!, "month");
        Assert.AreEqual(1, boundariesBetween);

        Assert.IsTrue(DateTimeIso8601.TryParse("2020-03-01", out startDate));
        Assert.IsTrue(CqlDateTime.TryParse("2020-04-30", out cqlStartDate));
        Assert.IsTrue(CqlDateTime.TryParse("2020-03-31", out cqlEndDate));
        boundariesBetween = new CqlDateTime(startDate!).BoundariesBetween(cqlStartDate!, "month");
        Assert.AreEqual(1, boundariesBetween);

        boundariesBetween = new CqlDateTime(startDate!).BoundariesBetween(cqlEndDate!, "month");
        Assert.AreEqual(0, boundariesBetween);
    }
    [TestMethod]
    public void BoundariesBetween_Years()
    {
        Assert.IsTrue(DateTimeIso8601.TryParse("2020-02-29", out var startDate));
        Assert.IsTrue(CqlDateTime.TryParse("2021-02-28", out var cqlStartDate));
        var boundariesBetween = new CqlDateTime(startDate!).BoundariesBetween(cqlStartDate!, "year");
        Assert.AreEqual(1, boundariesBetween);

        Assert.IsTrue(CqlDateTime.TryParse("2022-01-01", out cqlStartDate));
        boundariesBetween = new CqlDateTime(startDate!).BoundariesBetween(cqlStartDate!, "year");
        Assert.AreEqual(2, boundariesBetween);

        Assert.IsTrue(CqlDateTime.TryParse("2020-03-31", out cqlStartDate));
        boundariesBetween = new CqlDateTime(startDate!).BoundariesBetween(cqlStartDate!, "year");
        Assert.AreEqual(0, boundariesBetween);
    }

    [TestMethod]
    public void WholeCalendarPeriodsBetween_Years()
    {
        Assert.IsTrue(DateTimeIso8601.TryParse("2020-02-29", out var startDate));
        Assert.IsTrue(CqlDateTime.TryParse("2020-06-30", out var cqlStartDate));

        var boundariesBetween = new CqlDateTime(startDate!).WholeCalendarPeriodsBetween(cqlStartDate!, "year");
        Assert.AreEqual(0, boundariesBetween);

        Assert.IsTrue(CqlDateTime.TryParse("2021-02-28", out cqlStartDate));
        boundariesBetween = new CqlDateTime(startDate!).WholeCalendarPeriodsBetween(cqlStartDate!, "year");
        Assert.AreEqual(1, boundariesBetween); // 28 February is the anniversary of a leap day in a year without one

        Assert.IsTrue(CqlDateTime.TryParse("2021-03-01", out cqlStartDate));
        boundariesBetween = new CqlDateTime(startDate!).WholeCalendarPeriodsBetween(cqlStartDate!, "year");
        Assert.AreEqual(1, boundariesBetween);

        Assert.IsTrue(CqlDateTime.TryParse("2021-06-30", out cqlStartDate));
        boundariesBetween = new CqlDateTime(startDate!).WholeCalendarPeriodsBetween(cqlStartDate!, "year");
        Assert.AreEqual(1, boundariesBetween);

        Assert.IsTrue(DateTimeIso8601.TryParse("2008-04-11", out startDate));
        Assert.IsTrue(CqlDateTime.TryParse("2024-04-10", out cqlStartDate));
        boundariesBetween = new CqlDateTime(startDate!).WholeCalendarPeriodsBetween(cqlStartDate!, "year");
        Assert.AreEqual(15, boundariesBetween);

        // leap year
        Assert.IsTrue(DateTimeIso8601.TryParse("2020-04-11", out startDate));
        Assert.IsTrue(CqlDateTime.TryParse("2023-05-11", out cqlStartDate));
        boundariesBetween = new CqlDateTime(startDate!).WholeCalendarPeriodsBetween(cqlStartDate!, "year");
        Assert.AreEqual(3, boundariesBetween);

        // leap day
        Assert.IsTrue(DateTimeIso8601.TryParse("2003-03-01", out startDate));
        Assert.IsTrue(CqlDateTime.TryParse("2024-02-29", out cqlStartDate));
        boundariesBetween = new CqlDateTime(startDate!).WholeCalendarPeriodsBetween(cqlStartDate!, "year");
        Assert.AreEqual(20, boundariesBetween);
    }

    [TestMethod]
    public void WholeCalendarPeriodsBetween_Months()
    {
        Assert.IsTrue(DateTimeIso8601.TryParse("2020-02-29", out var startDate));
        Assert.IsTrue(CqlDateTime.TryParse("2020-06-30", out var cqlStartDate));

        var boundariesBetween = new CqlDateTime(startDate!).WholeCalendarPeriodsBetween(cqlStartDate!, "month");
        Assert.AreEqual(4, boundariesBetween);

        Assert.IsTrue(CqlDateTime.TryParse("2021-02-28", out cqlStartDate));
        boundariesBetween = new CqlDateTime(startDate!).WholeCalendarPeriodsBetween(cqlStartDate!, "month");
        Assert.AreEqual(11, boundariesBetween); // 1 full year occurs on mar 1, not feb 28

        Assert.IsTrue(CqlDateTime.TryParse("2021-03-01", out cqlStartDate));
        boundariesBetween = new CqlDateTime(startDate!).WholeCalendarPeriodsBetween(cqlStartDate!, "month");
        Assert.AreEqual(12, boundariesBetween);

        Assert.IsTrue(CqlDateTime.TryParse("2021-06-30", out cqlStartDate));
        boundariesBetween = new CqlDateTime(startDate!).WholeCalendarPeriodsBetween(cqlStartDate!, "month");
        Assert.AreEqual(16, boundariesBetween);

    }

    [TestMethod]
    public void Add_Years_OperatorAndMethod()
    {
        var dt = new CqlDateTime(2020, 1, 1, 0, 0, 0, 0, 0, 0);
        var quantity = new CqlQuantity(2, "year");

        var resultMethod = dt.Add(quantity);
        var resultOperator = dt + quantity;

        Assert.IsNotNull(resultMethod);
        Assert.IsNotNull(resultOperator);
        Assert.AreEqual(2022, resultMethod!.Value.Year);
        Assert.AreEqual(2022, resultOperator!.Value.Year);
        Assert.AreEqual(dt!.Value.Month, resultMethod.Value.Month);
        Assert.AreEqual(dt!.Value.Day, resultMethod.Value.Day);
    }

    [TestMethod]
    public void Subtract_Years_OperatorAndMethod()
    {
        var dt = new CqlDateTime(2020, 1, 1, 0, 0, 0, 0, 0, 0);
        var quantity = new CqlQuantity(3, "year");

        var resultMethod = dt.Subtract(quantity);
        var resultOperator = dt - quantity;

        Assert.IsNotNull(resultMethod);
        Assert.IsNotNull(resultOperator);
        Assert.AreEqual(2017, resultMethod!.Value.Year);
        Assert.AreEqual(2017, resultOperator!.Value.Year);
        Assert.AreEqual(dt!.Value.Month, resultMethod.Value.Month);
        Assert.AreEqual(dt!.Value.Day, resultMethod.Value.Day);
    }

    [TestMethod]
    public void Add_Months()
    {
        var dt = new CqlDateTime(2021, 5, 15, 0, 0, 0, 0, 0, 0);
        var quantity = new CqlQuantity(7, "month");

        var result = dt.Add(quantity);

        Assert.IsNotNull(result);
        Assert.AreEqual(2021, result!.Value.Year);
        Assert.AreEqual(12, result.Value.Month);
        Assert.AreEqual(15, result.Value.Day);
    }

    [TestMethod]
    public void Subtract_Days()
    {
        var dt = new CqlDateTime(2021, 1, 10, 0, 0, 0, 0, 0, 0);
        var quantity = new CqlQuantity(5, "day");

        var result = dt.Subtract(quantity);

        Assert.IsNotNull(result);
        Assert.AreEqual(2021, result!.Value.Year);
        Assert.AreEqual(1, result.Value.Month);
        Assert.AreEqual(5, result.Value.Day);
    }

    [TestMethod]
    public void Add_NullQuantity_ReturnsNull()
    {
        var dt = new CqlDateTime(2021, 1, 1, 0, 0, 0, 0, 0, 0);
        CqlQuantity? quantity = null;

        var result = dt.Add(quantity);
        var resultOp = dt + quantity;

        Assert.IsNull(result);
        Assert.IsNull(resultOp);
    }

    [TestMethod]
    public void Operator_NullDateTime_ReturnsNull()
    {
        CqlDateTime? dt = null;
        var quantity = new CqlQuantity(1, "year");

        var resultAdd = dt + quantity;
        var resultSub = dt - quantity;

        Assert.IsNull(resultAdd);
        Assert.IsNull(resultSub);
    }

    [TestMethod]
    public void Add_Days_ToMaxDateTime_ReturnsNull()
    {
        var dateTime = CqlDateTime.MaxValue; // 9999-12-31T23:59:59.999Z
        var quantity = new CqlQuantity(1, "day");
        var result = dateTime.Add(quantity);
        Assert.IsNull(result, "Adding days to maximum datetime should return null to prevent overflow");
    }

    [TestMethod]
    public void Subtract_Days_FromMinDateTime_ReturnsNull()
    {
        var dateTime = CqlDateTime.MinValue; // 0001-01-01T00:00:00.000Z
        var quantity = new CqlQuantity(1, "day");
        var result = dateTime.Subtract(quantity);
        Assert.IsNull(result, "Subtracting days from minimum datetime should return null to prevent overflow");
    }

    [TestMethod]
    public void Add_Years_ToMaxDateTime_ReturnsNull()
    {
        var dateTime = CqlDateTime.MaxValue; // 9999-12-31T23:59:59.999Z
        var quantity = new CqlQuantity(1, "year");
        var result = dateTime.Add(quantity);
        Assert.IsNull(result, "Adding years to maximum datetime should return null to prevent overflow");
    }

    [TestMethod]
    public void Subtract_Years_FromMinDateTime_ReturnsNull()
    {
        var dateTime = CqlDateTime.MinValue; // 0001-01-01T00:00:00.000Z
        var quantity = new CqlQuantity(1, "year");
        var result = dateTime.Subtract(quantity);
        Assert.IsNull(result, "Subtracting years from minimum datetime should return null to prevent overflow");
    }

    [TestMethod]
    public void Add_FinerUnitBeyondIntegerRangeAfterConversion_ReturnsNull()
    {
        // 51539607552 hours convert to 2147483648 days for a day-precision value, one more than Integer can hold.
        var dateTime = new CqlDateTime(2014, 6, 10, null, null, null, null, null, null);
        var quantity = new CqlQuantity(51539607552m, "hours");
        Assert.IsNull(dateTime.Add(quantity), "Adding a quantity that overflows after conversion should return null");
        Assert.IsNull(dateTime.Subtract(quantity), "Subtracting a quantity that overflows after conversion should return null");
    }

    [TestMethod]
    public void Add_FinerUnitBeyondDecimalRangeDuringConversion_ReturnsNull()
    {
        // Converting the largest decimal number of hours to years overflows the decimal multiplication itself.
        var dateTime = new CqlDateTime(2014, null, null, null, null, null, null, null, null);
        var quantity = new CqlQuantity(decimal.MaxValue, "hours");
        Assert.IsNull(dateTime.Add(quantity), "Adding a quantity whose conversion overflows should return null");
        Assert.IsNull(dateTime.Subtract(quantity), "Subtracting a quantity whose conversion overflows should return null");
    }

    [TestMethod]
    [DataRow("2026-13-45T10:00:00.000Z", DisplayName = "month and day out of range")]
    [DataRow("2026-02-31T10:00:00.000Z", DisplayName = "day beyond the month")]
    public void TryParse_DateThatDoesNotExist_ReturnsFalse(string value)
    {
        Assert.IsFalse(CqlDateTime.TryParse(value, out var dateTime));
        Assert.IsNull(dateTime);
    }

    /// <summary>
    /// "Timezone Offset | Real | [-13.00, 14.00] | The timezone offset is represented as a real with two digits of
    /// precision" (CQL 1.5.3 Errata 2, Language Semantics, section "Timing Calculations", Table 5-H).
    /// </summary>
    [TestMethod]
    [DataRow("24", DisplayName = "a whole day ahead")]
    [DataRow("-24", DisplayName = "a whole day behind")]
    [DataRow("14.5", DisplayName = "above the maximum")]
    [DataRow("14.01", DisplayName = "just above the maximum")]
    [DataRow("-13.5", DisplayName = "below the minimum")]
    [DataRow("0.001", DisplayName = "a fraction of a minute")]
    [DataRow("5.33", DisplayName = "a whole number of hundredths that is not a whole number of minutes")]
    public void DateTimeOperator_OffsetOutsideRangeOrNotWholeMinutes_ThrowsInvalidComponents(string offset)
    {
        var operators = GetNewContext().Operators;
        var value = decimal.Parse(offset, CultureInfo.InvariantCulture);

        var exception = Assert.ThrowsException<CqlException<CqlInvalidDateTimeComponentsError>>(
            () => operators.DateTime(2020, 6, 15, 12, 0, 0, 0, value));
        Assert.AreEqual(value, exception.Error.TimezoneOffset);
    }

    [TestMethod]
    [DataRow("14", 14, 0, DisplayName = "the maximum")]
    [DataRow("-13", -13, 0, DisplayName = "the minimum")]
    [DataRow("-13.00", -13, 0, DisplayName = "the minimum with two digits")]
    [DataRow("0", 0, 0, DisplayName = "zero")]
    [DataRow("5.75", 5, 45, DisplayName = "three quarters of an hour")]
    [DataRow("-9.5", -9, -30, DisplayName = "a half hour behind")]
    [DataRow("0.05", 0, 3, DisplayName = "three minutes")]
    public void DateTimeOperator_OffsetWithinRange_KeepsOffset(string offset, int hours, int minutes)
    {
        var operators = GetNewContext().Operators;
        var value = decimal.Parse(offset, CultureInfo.InvariantCulture);

        var dateTime = operators.DateTime(2020, 6, 15, 12, 0, 0, 0, value);

        Assert.IsNotNull(dateTime);
        Assert.AreEqual(hours, dateTime.Value.OffsetHour);
        Assert.AreEqual(minutes, dateTime.Value.OffsetMinute);
        Assert.AreEqual(value, operators.TimezoneOffsetFrom(dateTime));
    }
}