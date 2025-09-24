/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable
using System.Linq.Expressions;
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
        Assert.AreEqual(DateTimePrecision.Year, baseDate.Value.Precision);
        var plusOneYear = baseDate.Add(new CqlQuantity(1m, "year"));
        Assert.AreEqual(DateTimePrecision.Year, plusOneYear.Value.Precision);
        Assert.IsNull(plusOneYear.Value.Month);
        Assert.AreEqual("1961", plusOneYear.ToString());

        var plusTwelveMonths = baseDate.Add(new CqlQuantity(12m, "month"));
        Assert.AreEqual(DateTimePrecision.Year, plusTwelveMonths.Value.Precision);
        Assert.IsNull(plusTwelveMonths.Value.Month);
        Assert.AreEqual("1961", plusTwelveMonths.ToString());

        var plus365days = baseDate.Add(new CqlQuantity(365, "day"));
        Assert.AreEqual(DateTimePrecision.Year, plus365days.Value.Precision);
        Assert.IsNull(plus365days.Value.Month);
        Assert.AreEqual("1960", plus365days.ToString());

        var plus366days = baseDate.Add(new CqlQuantity(366, "day"));
        Assert.AreEqual(DateTimePrecision.Year, plus366days.Value.Precision);
        Assert.IsNull(plus366days.Value.Month);
        Assert.AreEqual("1961", plus366days.ToString());

        var plus366DaysInHours = baseDate.Add(new CqlQuantity(366 * 24, "hours"));
        Assert.AreEqual(DateTimePrecision.Year, plus366DaysInHours.Value.Precision);
        Assert.IsNull(plus366DaysInHours.Value.Month);
        Assert.AreEqual("1961", plus366DaysInHours.ToString());

        var plus365DaysInSeconds = baseDate.Add(new CqlQuantity(365 * 24 * 60 * 60, "seconds"));
        Assert.AreEqual(DateTimePrecision.Year, plus365DaysInSeconds.Value.Precision);
        Assert.IsNull(plus365DaysInSeconds.Value.Month);
        Assert.AreEqual("1960", plus365DaysInSeconds.ToString());
    }

    [TestMethod]
    public void Add_Month()
    {
        Assert.IsTrue(CqlDateTime.TryParse("2022-01-01", out var baseDate));

        var plus1Month = baseDate.Add(new CqlQuantity(1m, "month"));
        Assert.AreEqual(DateTimePrecision.Day, plus1Month.Value.Precision);
        Assert.IsNull(plus1Month.Value.Hour);
        Assert.AreEqual("2022-02-01", plus1Month.ToString());

        var plus2Months = baseDate.Add(new CqlQuantity(2m, "month"));
        Assert.AreEqual(DateTimePrecision.Day, plus2Months.Value.Precision);
        Assert.IsNull(plus2Months.Value.Hour);
        Assert.AreEqual("2022-03-01", plus2Months.ToString());

        var plus2pt5Months = baseDate.Add(new CqlQuantity(2.5m, "month"));
        Assert.AreEqual(DateTimePrecision.Day, plus2pt5Months.Value.Precision);
        Assert.IsNull(plus2pt5Months.Value.Hour);
        Assert.AreEqual("2022-03-01", plus2pt5Months.ToString());

        var plus1UcumMonth = baseDate.Add(new CqlQuantity(1m, "mo"));
        Assert.AreEqual(DateTimePrecision.Day, plus1UcumMonth.Value.Precision);
        Assert.IsNull(plus1UcumMonth.Value.Hour);
        Assert.AreEqual("2022-01-31", plus1UcumMonth.ToString());

    }

    [TestMethod]
    public void Subtract_Month()
    {
        Assert.IsTrue(CqlDateTime.TryParse("2022-03-01", out var baseDate));

        var minus1Month = baseDate.Subtract(new CqlQuantity(1m, "month"));
        Assert.AreEqual(DateTimePrecision.Day, minus1Month.Value.Precision);
        Assert.IsNull(minus1Month.Value.Hour);
        Assert.AreEqual("2022-02-01", minus1Month.ToString());

        var minus2Months = baseDate.Subtract(new CqlQuantity(2m, "month"));
        Assert.AreEqual(DateTimePrecision.Day, minus2Months.Value.Precision);
        Assert.IsNull(minus2Months.Value.Hour);
        Assert.AreEqual("2022-01-01", minus2Months.ToString());

        var minus2pt5Months = baseDate.Subtract(new CqlQuantity(2.5m, "month"));
        Assert.AreEqual(DateTimePrecision.Day, minus2pt5Months.Value.Precision);
        Assert.IsNull(minus2pt5Months.Value.Hour);
        Assert.AreEqual("2022-01-01", minus2pt5Months.ToString());

        var minus1UcumMonth = baseDate.Subtract(new CqlQuantity(1m, "mo"));
        Assert.AreEqual(DateTimePrecision.Day, minus1UcumMonth.Value.Precision);
        Assert.IsNull(minus1UcumMonth.Value.Hour);
        Assert.AreEqual("2022-01-29", minus1UcumMonth.ToString());

    }

    [TestMethod]
    public void Subtract_Months_From_Year()
    {
        Assert.IsTrue(CqlDateTime.TryParse("2014", out var baseDate));
        var result = baseDate.Subtract(new CqlQuantity(25m, "month"));
        Assert.AreEqual(2011, result.Value.Year);
        Assert.AreEqual(DateTimePrecision.Year, result.Precision);
    }

    [TestMethod]
    public void Subtract_Year()
    {
        Assert.IsTrue(CqlDateTime.TryParse("2025-03-01", out var baseDate));

        var minus1Year = baseDate.Subtract(new CqlQuantity(1m, "year"));
        Assert.AreEqual(DateTimePrecision.Day, minus1Year.Value.Precision);
        Assert.IsNull(minus1Year.Value.Hour);
        Assert.AreEqual("2024-03-01", minus1Year.ToString());

        var minus1UcumYear = baseDate.Subtract(new CqlQuantity(1m, "a"));
        Assert.AreEqual(DateTimePrecision.Day, minus1UcumYear.Value.Precision);
        Assert.IsNull(minus1UcumYear.Value.Hour);
        Assert.AreEqual("2024-02-29", minus1UcumYear.ToString());

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
        var boundariesBetween = new CqlDateTime(startDate).BoundariesBetween(cqlStartDate, "month");
        Assert.AreEqual(2, boundariesBetween);
        boundariesBetween = new CqlDateTime(startDate).BoundariesBetween(cqlEndDate, "month");
        Assert.AreEqual(1, boundariesBetween);

        Assert.IsTrue(DateTimeIso8601.TryParse("2020-03-01", out startDate));
        Assert.IsTrue(CqlDateTime.TryParse("2020-04-30", out cqlStartDate));
        Assert.IsTrue(CqlDateTime.TryParse("2020-03-31", out cqlEndDate));
        boundariesBetween = new CqlDateTime(startDate).BoundariesBetween(cqlStartDate, "month");
        Assert.AreEqual(1, boundariesBetween);

        boundariesBetween = new CqlDateTime(startDate).BoundariesBetween(cqlEndDate, "month");
        Assert.AreEqual(0, boundariesBetween);
    }
    [TestMethod]
    public void BoundariesBetween_Years()
    {
        Assert.IsTrue(DateTimeIso8601.TryParse("2020-02-29", out var startDate));
        Assert.IsTrue(CqlDateTime.TryParse("2021-02-28", out var cqlStartDate));
        var boundariesBetween = new CqlDateTime(startDate).BoundariesBetween(cqlStartDate, "year");
        Assert.AreEqual(1, boundariesBetween);

        Assert.IsTrue(CqlDateTime.TryParse("2022-01-01", out cqlStartDate));
        boundariesBetween = new CqlDateTime(startDate).BoundariesBetween(cqlStartDate, "year");
        Assert.AreEqual(2, boundariesBetween);

        Assert.IsTrue(CqlDateTime.TryParse("2020-03-31", out cqlStartDate));
        boundariesBetween = new CqlDateTime(startDate).BoundariesBetween(cqlStartDate, "year");
        Assert.AreEqual(0, boundariesBetween);
    }

    [TestMethod]
    public void WholeCalendarPeriodsBetween_Years()
    {
        Assert.IsTrue(DateTimeIso8601.TryParse("2020-02-29", out var startDate));
        Assert.IsTrue(CqlDateTime.TryParse("2020-06-30", out var cqlStartDate));

        var boundariesBetween = new CqlDateTime(startDate).WholeCalendarPeriodsBetween(cqlStartDate, "year");
        Assert.AreEqual(0, boundariesBetween);

        Assert.IsTrue(CqlDateTime.TryParse("2021-02-28", out cqlStartDate));
        boundariesBetween = new CqlDateTime(startDate).WholeCalendarPeriodsBetween(cqlStartDate, "year");
        Assert.AreEqual(0, boundariesBetween); // 1 full year occurs on mar 1, not feb 28

        Assert.IsTrue(CqlDateTime.TryParse("2021-03-01", out cqlStartDate));
        boundariesBetween = new CqlDateTime(startDate).WholeCalendarPeriodsBetween(cqlStartDate, "year");
        Assert.AreEqual(1, boundariesBetween);

        Assert.IsTrue(CqlDateTime.TryParse("2021-06-30", out cqlStartDate));
        boundariesBetween = new CqlDateTime(startDate).WholeCalendarPeriodsBetween(cqlStartDate, "year");
        Assert.AreEqual(1, boundariesBetween);

        Assert.IsTrue(DateTimeIso8601.TryParse("2008-04-11", out startDate));
        Assert.IsTrue(CqlDateTime.TryParse("2024-04-10", out cqlStartDate));
        boundariesBetween = new CqlDateTime(startDate).WholeCalendarPeriodsBetween(cqlStartDate, "year");
        Assert.AreEqual(15, boundariesBetween);

        // leap year
        Assert.IsTrue(DateTimeIso8601.TryParse("2020-04-11", out startDate));
        Assert.IsTrue(CqlDateTime.TryParse("2023-05-11", out cqlStartDate));
        boundariesBetween = new CqlDateTime(startDate).WholeCalendarPeriodsBetween(cqlStartDate, "year");
        Assert.AreEqual(3, boundariesBetween);

        // leap day
        Assert.IsTrue(DateTimeIso8601.TryParse("2003-03-01", out startDate));
        Assert.IsTrue(CqlDateTime.TryParse("2024-02-29", out cqlStartDate));
        boundariesBetween = new CqlDateTime(startDate).WholeCalendarPeriodsBetween(cqlStartDate, "year");
        Assert.AreEqual(20, boundariesBetween);
    }

    [TestMethod]
    public void WholeCalendarPeriodsBetween_Months()
    {
        Assert.IsTrue(DateTimeIso8601.TryParse("2020-02-29", out var startDate));
        Assert.IsTrue(CqlDateTime.TryParse("2020-06-30", out var cqlStartDate));

        var boundariesBetween = new CqlDateTime(startDate).WholeCalendarPeriodsBetween(cqlStartDate, "month");
        Assert.AreEqual(4, boundariesBetween);

        Assert.IsTrue(CqlDateTime.TryParse("2021-02-28", out cqlStartDate));
        boundariesBetween = new CqlDateTime(startDate).WholeCalendarPeriodsBetween(cqlStartDate, "month");
        Assert.AreEqual(11, boundariesBetween); // 1 full year occurs on mar 1, not feb 28

        Assert.IsTrue(CqlDateTime.TryParse("2021-03-01", out cqlStartDate));
        boundariesBetween = new CqlDateTime(startDate).WholeCalendarPeriodsBetween(cqlStartDate, "month");
        Assert.AreEqual(12, boundariesBetween);

        Assert.IsTrue(CqlDateTime.TryParse("2021-06-30", out cqlStartDate));
        boundariesBetween = new CqlDateTime(startDate).WholeCalendarPeriodsBetween(cqlStartDate, "month");
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
        Assert.AreEqual(2022, resultMethod.Value.Year);
        Assert.AreEqual(2022, resultOperator.Value.Year);
        Assert.AreEqual(dt.Value.Month, resultMethod.Value.Month);
        Assert.AreEqual(dt.Value.Day, resultMethod.Value.Day);
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
        Assert.AreEqual(2017, resultMethod.Value.Year);
        Assert.AreEqual(2017, resultOperator.Value.Year);
        Assert.AreEqual(dt.Value.Month, resultMethod.Value.Month);
        Assert.AreEqual(dt.Value.Day, resultMethod.Value.Day);
    }

    [TestMethod]
    public void Add_Months()
    {
        var dt = new CqlDateTime(2021, 5, 15, 0, 0, 0, 0, 0, 0);
        var quantity = new CqlQuantity(7, "month");

        var result = dt.Add(quantity);

        Assert.IsNotNull(result);
        Assert.AreEqual(2021, result.Value.Year);
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
        Assert.AreEqual(2021, result.Value.Year);
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
}