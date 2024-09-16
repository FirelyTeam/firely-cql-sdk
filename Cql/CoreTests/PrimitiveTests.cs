using Hl7.Cql.Abstractions;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Fhir;
using Hl7.Cql.Iso8601;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using FluentAssertions;
using DateTimePrecision = Hl7.Cql.Iso8601.DateTimePrecision;
using Expression = System.Linq.Expressions.Expression;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CoreTests
{
    [TestClass]
    [TestCategory("UnitTest")]
    public class PrimitiveTests
    {
        private CqlContext GetNewContext() => FhirCqlContext.WithDataSource();

        [TestMethod]
        public void CqlDate_Subtract_Months_From_Year()
        {
            Assert.IsTrue(CqlDateTime.TryParse("2014", out var baseDate));
            var result = baseDate.Subtract(new CqlQuantity(25m, UCUMUnits.Month));
            Assert.AreEqual(2012, result.Value.Year);
            Assert.AreEqual(DateTimePrecision.Year, result.Precision);
        }

        [TestMethod]
        public void CqlDateTime_Add_Year_By_Units()
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
            Assert.AreEqual("1961", plus365days.ToString());

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
            Assert.AreEqual("1961", plus365DaysInSeconds.ToString());
        }

        [TestMethod]
        public void CqlDateTime_Add_Month()
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

        }

        [TestMethod]
        public void CqlDateTime_Subtract_Month()
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

        }

        [TestMethod]
        public void CqlDateTime_Subtract_Day_and_Days()
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
        public void CqlDateTime_BoundariesBetween_Months()
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
        public void CqlDateTime_BoundariesBetween_Years()
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
        public void CqlDateTime_WholeCalendarPeriodsBetween_Years()
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
        public void CqlDateTime_WholeCalendarPeriodsBetween_Months()
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

        /// <summary>
        /// Handles Interval[3,null) contains 5 = null
        /// </summary>
        [TestMethod]
        public void CqlInterval_Contains_Null_End_Exclusive()
        {
            var interval = new CqlInterval<decimal?>(3, null, true, false);
            var five = (decimal)5;

            var rc = GetNewContext();
            var fcq = rc.Operators;

            var contains = fcq.Contains(interval, five, null);
            Assert.IsNull(contains);
        }

        /// <summary>
        /// Handles Interval[3,null] contains 5 = true
        /// </summary>
        [TestMethod]
        public void CqlInterval_Contains_Null_End_Inclusive_True()
        {
            var interval = new CqlInterval<decimal?>(3, null, true, true);
            var five = (decimal)5;

            var rc = GetNewContext();
            var fcq = rc.Operators;

            var contains = fcq.Contains(interval, five, null);
            Assert.IsTrue(contains ?? false);
        }

        /// <summary>
        /// Handles Interval(null,10] contains 5 = null
        /// </summary>
        [TestMethod]
        public void CqlInterval_Contains_Null_Start_Exclusive()
        {
            var interval = new CqlInterval<decimal?>(null, 10, false, true);
            var five = (decimal)5;

            var rc = GetNewContext();
            var fcq = rc.Operators;

            var contains = fcq.Contains(interval, five, null);
            Assert.IsNull(contains);
        }

        /// <summary>
        /// Handles Interval[null,10] contains 5 = true
        /// </summary>
        [TestMethod]
        public void CqlInterval_Contains_Null_Start_Inclusive_True()
        {
            var interval = new CqlInterval<decimal?>(null, 10, true, true);
            var five = (decimal)5;

            var rc = GetNewContext();
            var fcq = rc.Operators;

            var contains = fcq.Contains(interval, five, null);
            Assert.IsTrue(contains ?? false);
        }

        /// <summary>
        /// Handles Interval[null,5) contains 5 = false
        /// </summary>
        [TestMethod]
        public void CqlInterval_Contains_Null_Start_False()
        {
            var interval = new CqlInterval<decimal?>(null, 5, true, false);
            var five = (decimal)5;

            var rc = GetNewContext();
            var fcq = rc.Operators;

            var contains = fcq.Contains(interval, five, null);
            Assert.IsNotNull(contains);
            Assert.IsTrue((contains ?? false) == false);
        }

        /// <summary>
        /// Handles ( 9 before Interval[null, 20]) = false
        /// same as interval start > 9, inclusive so null becomes the lowest decimal
        /// </summary>
        [TestMethod]
        public void Element_Before_Interval_Null_Start_Inclusive_False()
        {
            var interval = new CqlInterval<decimal?>(null, 20, true, true);
            var nine = (decimal)9;

            var rc = GetNewContext();
            var fcq = rc.Operators;

            var contains = fcq.After(interval, nine, null);
            Assert.IsNotNull(contains);
            Assert.IsTrue((contains ?? false) == false);
        }

        /// <summary>
        /// Handles ( 9 before Interval(null, 20]) = null
        /// /// same as interval start > 9, excluse so null returns null
        /// </summary>
        [TestMethod]
        public void Element_Before_Interval_Null_Start_Inclusive_Null()
        {
            var interval = new CqlInterval<decimal?>(null, 20, false, true);
            var nine = (decimal)9;

            var rc = GetNewContext();
            var fcq = rc.Operators;

            var contains = fcq.After(interval, nine, null);
            Assert.IsNull(contains);
        }

        /// <summary>
        /// Handles ( 9 after Interval[1, null]) = false
        /// same as interval start &lt; 9
        /// </summary>
        [TestMethod]
        public void Element_After_Interval_Null_End_Inclusive_False()
        {
            var interval = new CqlInterval<decimal?>(1, null, true, true);
            var nine = (decimal)9;

            var rc = GetNewContext();
            var fcq = rc.Operators;

            var contains = fcq.Before(interval, nine, null);
            Assert.IsNotNull(contains);
            Assert.IsTrue((contains ?? false) == false);
        }

        /// <summary>
        /// Handles ( 9 after Interval[1, null]) = false
        /// </summary>
        [TestMethod]
        public void Element_After_Interval_Null_End_Exclusive_False()
        {
            var interval = new CqlInterval<decimal?>(1, null, true, true);
            var nine = (decimal)9;

            var rc = GetNewContext();
            var fcq = rc.Operators;

            var contains = fcq.Before(interval, nine, null);
            Assert.IsNotNull(contains);
            Assert.IsTrue((contains ?? false) == false);
        }

        #region Expand Interval<int, decimal, long>
        /// <summary>
        /// expand Interval[1, 10]
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Int_Null_Quantity()
        {
            var interval = new CqlInterval<int?>(1, 10, true, true);
            List<int?> expected = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, null);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        /// <summary>
        /// expand Interval[1, 10] per 2
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Int()
        {
            var interval = new CqlInterval<int?>(1, 10, true, true);
            var quantity = new CqlQuantity(2, null);
            List<int?> expected = [1, 3, 5, 7, 9];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        /// <summary>
        /// expand Interval[1, 10] per 1.5
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Decimal()
        {
            var interval = new CqlInterval<decimal?>(1, 10, true, true);
            var quantity = new CqlQuantity(1.5m, null);
            List<decimal?> expected = [1, 2.5m, 4, 5.5m, 7, 8.5m, 10];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        /// <summary>
        /// expand Interval[1, 10] per 4
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Long()
        {
            var interval = new CqlInterval<long?>(1, 10, true, true);
            var quantity = new CqlQuantity(4, null);
            List<long?> expected = [1, 5, 9];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        /// <summary>
        /// expand Interval[1.0, 10.0] per 1 day
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Decimal_Quantity_Day()
        {
            var interval = new CqlInterval<decimal?>(1, 10, true, true);
            var quantity = new CqlQuantity(1, "day");

            var rc = GetNewContext();

            var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.Count() == 0);
        }

        /// <summary>
        /// expand Interval[1.0, 10.0] per 1
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Decimal_Quantity_Integer()
        {
            var interval = new CqlInterval<decimal?>(1, 10, true, true);
            var quantity = new CqlQuantity(1, "1");
            List<decimal?> expected = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        /// <summary>
        /// expand Interval[1, 10] per 1 day
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Int_Quantity_Day()
        {
            var interval = new CqlInterval<int?>(1, 10, true, true);
            var quantity = new CqlQuantity(1, "day");

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.Count() == 0);
        }

        /// <summary>
        /// expand Interval[1, 10] per 1
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Int_Quantity_Integer()
        {
            var interval = new CqlInterval<int?>(1, 10, true, true);
            var quantity = new CqlQuantity(1, "1");
            List<int?> expected = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        /// <summary>
        /// expand Interval[1, 10] per 1 day
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Long_Quantity_Day()
        {
            var interval = new CqlInterval<long?>(1, 10, true, true);
            var quantity = new CqlQuantity(1, "day");

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.Count() == 0);
        }

        /// <summary>
        /// expand Interval[1, 10] per 1
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Long_Quantity_Integer()
        {
            var interval = new CqlInterval<long?>(1, 10, true, true);
            var quantity = new CqlQuantity(1, "1");
            List<long?> expected = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        #endregion

        #region Expand Interval[Date, Date]
        /// <summary>
        /// expand Interval[@2022-01-01, @2022-01-04]
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Date_Null_Quantity()
        {
            var interval = new CqlInterval<CqlDate>(new CqlDate(2022, 1, 1), new CqlDate(2022, 1, 4), true, true);
            List<CqlDate> expected =
            [
                new CqlDate(2022, 1, 1),
                new CqlDate(2022, 1, 2),
                new CqlDate(2022, 1, 3),
                new CqlDate(2022, 1, 4)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, null);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        /// <summary>
        /// expand Interval[@2022-01, @2022-02-04]
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Date_Month_Null_Quantity()
        {
            var interval = new CqlInterval<CqlDate>(new CqlDate(2022, 1, null), new CqlDate(2022, 2, 4), true, true);
            List<CqlDate> expected =
            [
                new CqlDate(2022, 1, null),
                new CqlDate(2022, 2, null)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, null);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        /// <summary>
        /// expand Interval[@2022-01, @2022-02-04] per day
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Date_Month_MonthQuantity()
        {
            var interval = new CqlInterval<CqlDate>(new CqlDate(2022, 1, null), new CqlDate(2022, 2, 4), true, true);
            var quantity = new CqlQuantity(1, "month");
            List<CqlDate> expected =
            [
                new CqlDate(2022, 1, null),
                new CqlDate(2022, 2, null)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        /// <summary>
        /// expand Interval[@2022-01-01, @2022-01-04] per day
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Date_Day()
        {
            var interval = new CqlInterval<CqlDate>(new CqlDate(2022, 1, 1), new CqlDate(2022, 1, 4), true, true);
            var quantity = new CqlQuantity(1, "day");
            List<CqlDate> expected =
            [
                new CqlDate(2022, 1, 1),
                new CqlDate(2022, 1, 2),
                new CqlDate(2022, 1, 3),
                new CqlDate(2022, 1, 4)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        /// <summary>
        /// expand Interval[@2022-01-01, @2022-03-01] per 3 months
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Date_Month()
        {
            var interval = new CqlInterval<CqlDate>(new CqlDate(2022, 1, 1), new CqlDate(2022, 3, 1), true, true);
            var quantity = new CqlQuantity(3, "month");
            List<CqlDate> expected = [new CqlDate(2022, 1, 1)];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        /// <summary>
        /// expand Interval[@2022-01-01, @2024-03-01] per 2 years
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Date_Year()
        {
            var interval = new CqlInterval<CqlDate>(new CqlDate(2022, 1, 1), new CqlDate(2024, 3, 1), true, true);
            var quantity = new CqlQuantity(2, "years");
            List<CqlDate> expected =
            [
                new CqlDate(2022, 1, 1),
                new CqlDate(2024, 1, 1)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        /// <summary>
        /// expand Interval[@2022-01-01, @2022-02-01] per week
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Date_Week()
        {
            var interval = new CqlInterval<CqlDate>(new CqlDate(2022, 1, 1), new CqlDate(2022, 2, 1), true, true);
            var quantity = new CqlQuantity(1, "week");
            List<CqlDate> expected =
            [
                new CqlDate(2022, 1, 1),
                new CqlDate(2022, 1, 8),
                new CqlDate(2022, 1, 15),
                new CqlDate(2022, 1, 22),
                new CqlDate(2022, 1, 29)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        /// <summary>
        /// expand Interval[@2022-01-01, @2024-03-01] per minute
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Date_Minute()
        {
            var interval = new CqlInterval<CqlDate>(new CqlDate(2022, 1, 1), new CqlDate(2024, 3, 1), true, true);
            var quantity = new CqlQuantity(1, "minute");

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.Count() == 0);
        }

        /// <summary>
        /// expand Interval[@2022-01-01, @2024-03-01] per hour
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Date_Hour()
        {
            var interval = new CqlInterval<CqlDate>(new CqlDate(2022, 1, 1), new CqlDate(2024, 3, 1), true, true);
            var quantity = new CqlQuantity(1, "hour");

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.Count() == 0);
        }

        /// <summary>
        /// expand Interval[@2022-01-01, @2024-03-01] per second
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Date_Second()
        {
            var interval = new CqlInterval<CqlDate>(new CqlDate(2022, 1, 1), new CqlDate(2024, 3, 1), true, true);
            var quantity = new CqlQuantity(1, "second");

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.Count() == 0);
        }

        /// <summary>
        /// expand Interval[@2022-01-01, @2024-03-01] per millisecond
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Date_Millisecond()
        {
            var interval = new CqlInterval<CqlDate>(new CqlDate(2022, 1, 1), new CqlDate(2024, 3, 1), true, true);
            var quantity = new CqlQuantity(1, "millisecond");

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.Count() == 0);
        }

        /// <summary>
        /// expand Interval[@2022-01, @2022-04] per month
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Date_MonthYear()
        {
            var start = new CqlDate(2022, 1, null);
            var end = new CqlDate(2022, 4, null);

            var interval = new CqlInterval<CqlDate>(start, end, true, true);
            var quantity = new CqlQuantity(1, "month");
            List<CqlDate> expected =
            [
                new CqlDate(2022, 1, null),
                new CqlDate(2022, 2, null),
                new CqlDate(2022, 3, null),
                new CqlDate(2022, 4, null)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        /// <summary>
        /// /// expand Interval[@2022-01, @2022-04] per day
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Date_MonthYear_Quantity_Day()
        {
            var start = new CqlDate(2022, 1, null);
            var end = new CqlDate(2022, 4, null);

            var interval = new CqlInterval<CqlDate>(start, end, true, true);
            var quantity = new CqlQuantity(1, "day");

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.Count() == 0);
        }

        /// <summary>
        /// expand Interval[@2022, @2023] per day
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Date_Year_Quantity_Day()
        {
            var start = new CqlDate(2022, null, null);
            var end = new CqlDate(2023, null, null);

            var interval = new CqlInterval<CqlDate>(start, end, true, true);
            var quantity = new CqlQuantity(1, "day");

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.Count() == 0);
        }

        #endregion

        #region Expand Interval[DateTime, DateTime]
        /// <summary>
        /// expand Interval[@2022-01-01@T12:00:00:00, @2022-01-04@T12:00:00:05]
        /// </summary>
        [TestMethod]
        public void Expand_Interval_DateTime_Null_Quantity()
        {
            var start = new CqlDateTime(2022, 1, 1, 12, 0, 0, 0, 0, 0);
            var end = new CqlDateTime(2022, 1, 1, 12, 0, 0, 5, 0, 0);
            var interval = new CqlInterval<CqlDateTime>(start, end, true, true);
            List<CqlDateTime> expected =
            [
                new CqlDateTime(2022, 1, 1, 12, 0, 0, 0, 0, 0),
                new CqlDateTime(2022, 1, 1, 12, 0, 0, 1, 0, 0),
                new CqlDateTime(2022, 1, 1, 12, 0, 0, 2, 0, 0),
                new CqlDateTime(2022, 1, 1, 12, 0, 0, 3, 0, 0),
                new CqlDateTime(2022, 1, 1, 12, 0, 0, 4, 0, 0),
                new CqlDateTime(2022, 1, 1, 12, 0, 0, 5, 0, 0)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, null);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        /// <summary>
        /// expand Interval[@2022-01-01@T12:00:00, @2022-01-04]
        /// </summary>
        [TestMethod]
        public void Expand_Interval_DateTime_Hour_Null_Quantity()
        {
            var start = new CqlDateTime(2022, 1, 1, 12, 0, 0, 0, 0, 0);
            var end = new CqlDateTime(2022, 1, 4, null, null, null, null, null, null);
            var interval = new CqlInterval<CqlDateTime>(start, end, true, true);
            List<CqlDateTime> expected =
            [
                new CqlDateTime(2022, 1, 1, null, null, null, null, null, null),
                new CqlDateTime(2022, 1, 2, null, null, null, null, null, null),
                new CqlDateTime(2022, 1, 3, null, null, null, null, null, null),
                new CqlDateTime(2022, 1, 4, null, null, null, null, null, null)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, null);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        /// <summary>
        /// /// expand Interval[@2022-01-01@T12, @2022-01-04@T12] per minute
        /// </summary>
        [TestMethod]
        public void Expand_Interval_DateTime_Hour_Minute_Quantity()
        {
            var start = new CqlDateTime(2022, 1, 1, 12, null, null, null, null, null);
            var end = new CqlDateTime(2022, 1, 1, 12, null, null, null, null, null);

            var interval = new CqlInterval<CqlDateTime>(start, end, true, true);
            var quantity = new CqlQuantity(1, "minute");

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.Count() == 0);
        }

        /// <summary>
        /// expand Interval[@2022-01-01@T12:00:00:00, @2022-01-04@T12:00:00:00] per day
        /// </summary>
        [TestMethod]
        public void Expand_Interval_DateTime_Day()
        {
            var start = new CqlDateTime(2022, 1, 1, 12, 0, 0, 0, 0, 0);
            var end = new CqlDateTime(2022, 1, 4, 12, 0, 0, 0, 0, 0);

            var interval = new CqlInterval<CqlDateTime>(start, end, true, true);
            var quantity = new CqlQuantity(1, "day");
            List<CqlDateTime> expected =
            [
                new CqlDateTime(2022, 1, 1, 12, 0, 0, 0, 0, 0),
                new CqlDateTime(2022, 1, 2, 12, 0, 0, 0, 0, 0),
                new CqlDateTime(2022, 1, 3, 12, 0, 0, 0, 0, 0),
                new CqlDateTime(2022, 1, 4, 12, 0, 0, 0, 0, 0)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        /// <summary>
        /// expand Interval[@2022-01-01@T12:00:00:00, @2022-03-01@T00:00:00:00] per 3 months
        /// </summary>
        [TestMethod]
        public void Expand_Interval_DateTime_Month()
        {
            var start = new CqlDateTime(2022, 1, 1, 12, 0, 0, 0, 0, 0);
            var end = new CqlDateTime(2022, 3, 1, 0, 0, 0, 0, 0, 0);

            var interval = new CqlInterval<CqlDateTime>(start, end, true, true);
            var quantity = new CqlQuantity(3, "month");
            List<CqlDateTime> expected = [start];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        /// <summary>
        /// expand Interval[@2022-01-01@T12:00:00:00, @2024-03-01@T00:00:00:00] per 2 years
        /// </summary>
        [TestMethod]
        public void Expand_Interval_DateTime_Year()
        {
            var start = new CqlDateTime(2022, 1, 1, 12, 0, 0, 0, 0, 0);
            var end = new CqlDateTime(2024, 3, 1, 0, 0, 0, 0, 0, 0);

            var interval = new CqlInterval<CqlDateTime>(start, end, true, true);
            var quantity = new CqlQuantity(2, "years");
            List<CqlDateTime> expected =
            [
                new CqlDateTime(2022, 1, 1, 12, 0, 0, 0, 0, 0),
                new CqlDateTime(2024, 1, 1, 12, 0, 0, 0, 0, 0)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        /// <summary>
        /// expand Interval[@2022-01-01@T12:00:00:00, @2022-02-01@T12:00:00:00] per week
        /// </summary>
        [TestMethod]
        public void Expand_Interval_DateTime_Week()
        {
            var start = new CqlDateTime(2022, 1, 1, 12, 0, 0, 0, 0, 0);
            var end = new CqlDateTime(2022, 2, 1, 0, 0, 0, 0, 0, 0);

            var interval = new CqlInterval<CqlDateTime>(start, end, true, true);
            var quantity = new CqlQuantity(1, "week");
            List<CqlDateTime> expected =
            [
                new CqlDateTime(2022, 1, 1, 12, 0, 0, 0, 0, 0),
                new CqlDateTime(2022, 1, 8, 12, 0, 0, 0, 0, 0),
                new CqlDateTime(2022, 1, 15, 12, 0, 0, 0, 0, 0),
                new CqlDateTime(2022, 1, 22, 12, 0, 0, 0, 0, 0),
                new CqlDateTime(2022, 1, 29, 12, 0, 0, 0, 0, 0)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        /// <summary>
        /// expand Interval[@2022-01-01@T00:00:00:00, @2022-01-01@T00:05:00:00] per 2 minutes
        /// </summary>
        [TestMethod]
        public void Expand_Interval_DateTime_Minute()
        {
            var start = new CqlDateTime(2022, 1, 1, 0, 0, 0, 0, 0, 0);
            var end = new CqlDateTime(2022, 1, 1, 0, 5, 0, 0, 0, 0);

            var interval = new CqlInterval<CqlDateTime>(start, end, true, true);
            var quantity = new CqlQuantity(2, "minutes");
            List<CqlDateTime> expected =
            [
                new CqlDateTime(2022, 1, 1, 0, 0, 0, 0, 0, 0),
                new CqlDateTime(2022, 1, 1, 0, 2, 0, 0, 0, 0),
                new CqlDateTime(2022, 1, 1, 0, 4, 0, 0, 0, 0)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        /// <summary>
        /// expand Interval[@2022-01-01@T00:00:00:00, @2022-01-01@T06:00:00:00] per 2 hours
        /// </summary>
        [TestMethod]
        public void Expand_Interval_DateTime_Hour()
        {
            var start = new CqlDateTime(2022, 1, 1, 0, 0, 0, 0, 0, 0);
            var end = new CqlDateTime(2022, 1, 1, 6, 0, 0, 0, 0, 0);

            var interval = new CqlInterval<CqlDateTime>(start, end, true, true);
            var quantity = new CqlQuantity(2, "hours");
            List<CqlDateTime> expected =
            [
                new CqlDateTime(2022, 1, 1, 0, 0, 0, 0, 0, 0),
                new CqlDateTime(2022, 1, 1, 2, 0, 0, 0, 0, 0),
                new CqlDateTime(2022, 1, 1, 4, 0, 0, 0, 0, 0),
                new CqlDateTime(2022, 1, 1, 6, 0, 0, 0, 0, 0)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        /// <summary>
        /// expand Interval[@2022-01-01@T00:00:00:00, @2022-01-01@T00:00:06:00] per 3 seconds
        /// </summary>
        [TestMethod]
        public void Expand_Interval_DateTime_Second()
        {
            var start = new CqlDateTime(2022, 1, 1, 0, 0, 0, 0, 0, 0);
            var end = new CqlDateTime(2022, 1, 1, 0, 0, 6, 0, 0, 0);

            var interval = new CqlInterval<CqlDateTime>(start, end, true, true);
            var quantity = new CqlQuantity(3, "secondd");
            List<CqlDateTime> expected =
            [
                new CqlDateTime(2022, 1, 1, 0, 0, 0, 0, 0, 0),
                new CqlDateTime(2022, 1, 1, 0, 0, 3, 0, 0, 0),
                new CqlDateTime(2022, 1, 1, 0, 0, 6, 0, 0, 0)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        /// <summary>
        /// expand Interval[@2022-01-01@T00:00:00:00, @2022-01-01@T00:00:03:00] per 30 milliseconds
        /// </summary>
        [TestMethod]
        public void Expand_Interval_DateTime_Millisecond()
        {
            var start = new CqlDateTime(2022, 1, 1, 0, 0, 0, 0, 0, 0);
            var end = new CqlDateTime(2022, 1, 1, 0, 0, 3, 0, 0, 0);

            var interval = new CqlInterval<CqlDateTime>(start, end, true, true);
            var quantity = new CqlQuantity(500, "milliseconds");
            List<CqlDateTime> expected =
            [
                new CqlDateTime(2022, 1, 1, 0, 0, 0, 0, 0, 0),
                new CqlDateTime(2022, 1, 1, 0, 0, 0, 500, 0, 0),
                new CqlDateTime(2022, 1, 1, 0, 0, 1, 0, 0, 0),
                new CqlDateTime(2022, 1, 1, 0, 0, 1, 500, 0, 0),
                new CqlDateTime(2022, 1, 1, 0, 0, 2, 0, 0, 0),
                new CqlDateTime(2022, 1, 1, 0, 0, 2, 500, 0, 0),
                new CqlDateTime(2022, 1, 1, 0, 0, 3, 0, 0, 0)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }
        #endregion

        #region Expand Interval[Time, Time]
        /// <summary>
        /// expand Interval[@T10, @T12]
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Time_Hour_Null_Quantity()
        {
            var start = new CqlTime(10, null, null, null, null, null);
            var end = new CqlTime(12, null, null, null, null, null);

            var interval = new CqlInterval<CqlTime>(start, end, true, true);
            List<CqlTime> expected =
            [
                new CqlTime(10, null, null, null, null, null),
                new CqlTime(11, null, null, null, null, null),
                new CqlTime(12, null, null, null, null, null)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, null);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        /// <summary>
        /// expand Interval[@T10, @T10:05]
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Time_Minute_Null_Quantity()
        {
            var start = new CqlTime(10, null, null, null, null, null);
            var end = new CqlTime(11, 5, null, null, null, null);

            var interval = new CqlInterval<CqlTime>(start, end, true, true);
            List<CqlTime> expected =
            [
                new CqlTime(10, null, null, null, null, null),
                new CqlTime(11, null, null, null, null, null)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, null);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        /// <summary>
        /// expand Interval[@T10, @T12] per day
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Time_Day()
        {
            var start = new CqlTime(10, null, null, null, null, null);
            var end = new CqlTime(12, null, null, null, null, null);

            var interval = new CqlInterval<CqlTime>(start, end, true, true);
            var quantity = new CqlQuantity(1, "day");

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.Count() == 0);
        }

        /// <summary>
        /// expand Interval[@T10, @T12] per 3 months
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Time_Month()
        {
            var start = new CqlTime(10, null, null, null, null, null);
            var end = new CqlTime(12, null, null, null, null, null);

            var interval = new CqlInterval<CqlTime>(start, end, true, true);
            var quantity = new CqlQuantity(3, "month");

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.Count() == 0);
        }

        /// <summary>
        /// expand Interval[@T10, @T12] per 2 years
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Time_Year()
        {
            var start = new CqlTime(10, null, null, null, null, null);
            var end = new CqlTime(12, null, null, null, null, null);

            var interval = new CqlInterval<CqlTime>(start, end, true, true);
            var quantity = new CqlQuantity(2, "years");

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.Count() == 0);
        }

        /// <summary>
        /// expand Interval[@T10, @T12] per week
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Time_Week()
        {
            var start = new CqlTime(10, null, null, null, null, null);
            var end = new CqlTime(12, null, null, null, null, null);

            var interval = new CqlInterval<CqlTime>(start, end, true, true);
            var quantity = new CqlQuantity(1, "week");

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.Count() == 0);
        }

        /// <summary>
        /// expand Interval[@T10, @T12] per 30 minutes
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Time_Hour_With_Minute_Quantity()
        {
            var start = new CqlTime(10, null, null, null, null, null);
            var end = new CqlTime(12, null, null, null, null, null);

            var interval = new CqlInterval<CqlTime>(start, end, true, true);
            var quantity = new CqlQuantity(1, "minute");

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.Count() == 0);
        }

        /// <summary>
        /// expand Interval[@T10:00, @T12:00] per 30 minutes
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Time_Minute()
        {
            var start = new CqlTime(10, 0, null, null, null, null);
            var end = new CqlTime(12, 0, null, null, null, null);

            var interval = new CqlInterval<CqlTime>(start, end, true, true);
            var quantity = new CqlQuantity(30, "minutes");
            List<CqlTime> expected =
            [
                new CqlTime(10, 0, null, null, null, null),
                new CqlTime(10, 30, null, null, null, null),
                new CqlTime(11, 0, null, null, null, null),
                new CqlTime(11, 30, null, null, null, null),
                new CqlTime(12, 0, null, null, null, null)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        /// <summary>
        /// expand Interval[@T10, @T12] per hour
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Time_Hour()
        {
            var start = new CqlTime(10, null, null, null, null, null);
            var end = new CqlTime(12, null, null, null, null, null);

            var interval = new CqlInterval<CqlTime>(start, end, true, true);
            var quantity = new CqlQuantity(1, "hour");
            List<CqlTime> expected =
            [
                new CqlTime(10, null, null, null, null, null),
                new CqlTime(11, null, null, null, null, null),
                new CqlTime(12, null, null, null, null, null)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        /// <summary>
        /// expand Interval[@T10:00:00, @T10:00:05] per 5 seconds
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Time_Second()
        {
            var start = new CqlTime(10, 0, 0, null, null, null);
            var end = new CqlTime(10, 0, 5, null, null, null);

            var interval = new CqlInterval<CqlTime>(start, end, true, true);
            var quantity = new CqlQuantity(5, "seconds");
            List<CqlTime> expected =
            [
                new CqlTime(10, 0, 0, null, null, null),
                new CqlTime(10, 0, 5, null, null, null)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        /// <summary>
        /// expand Interval[@T10:00:00:00, @T10:00:00:10] per 5 seconds
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Time_Millisecond()
        {
            var start = new CqlTime(10, 0, 0, 0, null, null);
            var end = new CqlTime(10, 0, 0, 10, null, null);

            var interval = new CqlInterval<CqlTime>(start, end, true, true);
            var quantity = new CqlQuantity(5, "millisecond");
            List<CqlTime> expected =
            [
                new CqlTime(10, 0, 0, 0, null, null),
                new CqlTime(10, 0, 0, 5, null, null),
                new CqlTime(10, 0, 0, 10, null, null)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        /// <summary>
        /// expand Interval[@T10, @T10:05] per hour
        /// </summary>
        [TestMethod]
        public void Expand_Interval_Time_Minute_Hour_Quantity()
        {
            var start = new CqlTime(10, null, null, null, null, null);
            var end = new CqlTime(11, 5, null, null, null, null);

            var interval = new CqlInterval<CqlTime>(start, end, true, true);
            var quantity = new CqlQuantity(1, "hour");
            List<CqlTime> expected =
            [
                new CqlTime(10, null, null, null, null, null),
                new CqlTime(11, null, null, null, null, null)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.SequenceEqual(expected));
        }

        #endregion

        #region Expand List<Interval<int, decimal, long>>
        /// <summary>
        /// expand { Interval[1, 10] }
        /// </summary>
        [TestMethod]
        public void ExpandList_Interval_Int_Null_Quantity()
        {
            CqlInterval<int?>[] interval =
            [
                new CqlInterval<int?>(1, 10, true, true)
            ];

            CqlInterval<int>[] expected =
            [
                new CqlInterval<int>(1,1, true, true),
                new CqlInterval<int>(2,2, true, true),
                new CqlInterval<int>(3,3, true, true),
                new CqlInterval<int>(4,4, true, true),
                new CqlInterval<int>(5,5, true, true),
                new CqlInterval<int>(6,6, true, true),
                new CqlInterval<int>(7,7, true, true),
                new CqlInterval<int>(8,8, true, true),
                new CqlInterval<int>(9,9, true, true),
                new CqlInterval<int>(10,10, true, true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, null).ToArray();
            Assert.IsNotNull(expand);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.IsTrue(actual.low == expect.low);
                Assert.IsTrue(actual.high == expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[1, 10] } per 2
        /// </summary>
        [TestMethod]
        public void ExpandList_Interval_Int()
        {
            List<CqlInterval<int?>> interval = [new CqlInterval<int?>(1, 10, true, true)];
            var quantity = new CqlQuantity(2m, null);
            CqlInterval<int>[] expected =
            [
                new CqlInterval<int>(1,2, true, true),
                new CqlInterval<int>(3,4, true, true),
                new CqlInterval<int>(5,6, true, true),
                new CqlInterval<int>(7,8, true, true),
                new CqlInterval<int>(9,10, true, true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.IsTrue(actual.low == expect.low);
                Assert.IsTrue(actual.high == expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[1, 10] } per 1.5
        /// </summary>
        [TestMethod]
        public void ExpandList_Interval_Decimal()
        {
            List<CqlInterval<decimal?>> interval = [new CqlInterval<decimal?>(1, 10, true, true)];
            var quantity = new CqlQuantity(1.5m, null);
            CqlInterval<decimal>[] expected =
            [
                new CqlInterval<decimal>(1,2.49999999m, true, true),
                new CqlInterval<decimal>(2.5m, 3.99999999m, true, true),
                new CqlInterval<decimal>(4,5.49999999m, true, true),
                new CqlInterval<decimal>(5.5m, 6.99999999m, true, true),
                new CqlInterval<decimal>(7,8.49999999m, true, true),
                new CqlInterval<decimal>(8.5m, 9.99999999m, true, true),
                new CqlInterval<decimal>(10,11.49999999m, true, true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.IsTrue(actual.low == expect.low);
                Assert.IsTrue(actual.high == expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[1, 10] } per 4
        /// </summary>
        [TestMethod]
        public void ExpandList_Interval_Long()
        {
            List<CqlInterval<long?>> interval = [new CqlInterval<long?>(1, 10, true, true)];
            var quantity = new CqlQuantity(4m, null);
            CqlInterval<decimal>[] expected =
            [
                new CqlInterval<decimal>(1,4, true, true),
                new CqlInterval<decimal>(5,8, true, true),
                new CqlInterval<decimal>(9,12, true, true)
            ];
            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.IsTrue(actual.low == expect.low);
                Assert.IsTrue(actual.high == expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[1.0, 10.0] } per 1 day
        /// </summary>
        [TestMethod]
        public void ExpandList_Interval_Decimal_Quantity_Day()
        {
            List<CqlInterval<decimal?>> interval = [new CqlInterval<decimal?>(1, 10, true, true)];
            var quantity = new CqlQuantity(1, "day");

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.Count() == 0);
        }

        /// <summary>
        /// expand { Interval[1.0, 10.0] } per 1
        /// </summary>
        [TestMethod]
        public void ExpandList_Interval_Decimal_Quantity_Integer()
        {
            List<CqlInterval<decimal?>> interval = [new CqlInterval<decimal?>(1, 10, true, true)];
            var quantity = new CqlQuantity(1, "1");
            List<CqlInterval<decimal>> expected =
            [
                new CqlInterval<decimal>(1, 1.99999999m, true, true),
                new CqlInterval<decimal>(2, 2.99999999m, true, true),
                new CqlInterval<decimal>(3, 3.99999999m, true, true),
                new CqlInterval<decimal>(4, 4.99999999m, true, true),
                new CqlInterval<decimal>(5, 5.99999999m, true, true),
                new CqlInterval<decimal>(6, 6.99999999m, true, true),
                new CqlInterval<decimal>(7, 7.99999999m, true, true),
                new CqlInterval<decimal>(8, 8.99999999m, true, true),
                new CqlInterval<decimal>(9, 9.99999999m, true, true),
                new CqlInterval<decimal>(10, 10.99999999m, true, true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.IsTrue(actual.low == expect.low);
                Assert.IsTrue(actual.high == expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[1, 10] } per 1 day
        /// </summary>
        [TestMethod]
        public void ExpandList_Interval_Int_Quantity_Day()
        {
            List<CqlInterval<int?>> interval = [new CqlInterval<int?>(1, 10, true, true)];
            var quantity = new CqlQuantity(1, "day");

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.Count() == 0);
        }

        /// <summary>
        /// expand { Interval[1, 10] } per 1
        /// </summary>
        [TestMethod]
        public void ExpandList_Interval_Int_Quantity_Integer()
        {
            List<CqlInterval<int?>> interval = [new CqlInterval<int?>(1, 10, true, true)];
            var quantity = new CqlQuantity(1, "1");
            CqlInterval<int>[] expected =
            [
                new CqlInterval<int>(1,1, true, true),
                new CqlInterval<int>(2,2, true, true),
                new CqlInterval<int>(3,3, true, true),
                new CqlInterval<int>(4,4, true, true),
                new CqlInterval<int>(5,5, true, true),
                new CqlInterval<int>(6,6, true, true),
                new CqlInterval<int>(7,7, true, true),
                new CqlInterval<int>(8,8, true, true),
                new CqlInterval<int>(9,9, true, true),
                new CqlInterval<int>(10,10, true, true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.IsTrue(actual.low == expect.low);
                Assert.IsTrue(actual.high == expect.high);
            }
        }

        /// <summary>
        /// expand Interval[1, 10] per 1 day
        /// </summary>
        [TestMethod]
        public void ExpandList_Interval_Long_Quantity_Day()
        {
            List<CqlInterval<long?>> interval = [new CqlInterval<long?>(1, 10, true, true)];
            var quantity = new CqlQuantity(1, "day");

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.Count() == 0);
        }

        /// <summary>
        /// expand Interval[1, 10] per 1
        /// </summary>
        [TestMethod]
        public void ExpandList_Interval_Long_Quantity_Integer()
        {
            List<CqlInterval<long?>> interval = [new CqlInterval<long?>(1, 10, true, true)];
            var quantity = new CqlQuantity(1, "1");
            CqlInterval<long>[] expected =
            [
                new CqlInterval<long>(1,1, true, true),
                new CqlInterval<long>(2,2, true, true),
                new CqlInterval<long>(3,3, true, true),
                new CqlInterval<long>(4,4, true, true),
                new CqlInterval<long>(5,5, true, true),
                new CqlInterval<long>(6,6, true, true),
                new CqlInterval<long>(7,7, true, true),
                new CqlInterval<long>(8,8, true, true),
                new CqlInterval<long>(9,9, true, true),
                new CqlInterval<long>(10,10, true, true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.IsTrue(actual.low == expect.low);
                Assert.IsTrue(actual.high == expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[1, 5], Interval[5, 10] } per 1
        /// </summary>
        [TestMethod]
        public void ExpandList_Intervals_Overlap_Int()
        {
            List<CqlInterval<int?>> interval =
            [
                new CqlInterval<int?>(1, 5, true, true),
                new CqlInterval<int?>(5, 10, true, true)
            ];
            var quantity = new CqlQuantity(1, "1");
            CqlInterval<int>[] expected =
            [
                new CqlInterval<int>(1,1, true, true),
                new CqlInterval<int>(2,2, true, true),
                new CqlInterval<int>(3,3, true, true),
                new CqlInterval<int>(4,4, true, true),
                new CqlInterval<int>(5,5, true, true),
                new CqlInterval<int>(6,6, true, true),
                new CqlInterval<int>(7,7, true, true),
                new CqlInterval<int>(8,8, true, true),
                new CqlInterval<int>(9,9, true, true),
                new CqlInterval<int>(10,10, true, true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[1, 5], Interval[5, 10] } per 1
        /// </summary>
        [TestMethod]
        public void ExpandList_Intervals_Overlap_Decimal()
        {
            List<CqlInterval<decimal?>> interval =
            [
                new CqlInterval<decimal?>(1, 5, true, true),
                new CqlInterval<decimal?>(5, 10, true, true)
            ];
            var quantity = new CqlQuantity(1, "1");
            CqlInterval<decimal>[] expected =
            [
                new CqlInterval<decimal>(1,1.99999999m, true, true),
                new CqlInterval<decimal>(2,2.99999999m, true, true),
                new CqlInterval<decimal>(3,3.99999999m, true, true),
                new CqlInterval<decimal>(4,4.99999999m, true, true),
                new CqlInterval<decimal>(5,5.99999999m, true, true),
                new CqlInterval<decimal>(6,6.99999999m, true, true),
                new CqlInterval<decimal>(7,7.99999999m, true, true),
                new CqlInterval<decimal>(8,8.99999999m, true, true),
                new CqlInterval<decimal>(9,9.99999999m, true, true),
                new CqlInterval<decimal>(10,10.99999999m, true, true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[1, 5], Interval[5, 10] } per 1
        /// </summary>
        [TestMethod]
        public void ExpandList_Intervals_Overlap_Long()
        {
            List<CqlInterval<long?>> interval =
            [
                new CqlInterval<long?>(1, 5, true, true),
                new CqlInterval<long?>(5, 10, true, true)
            ];
            var quantity = new CqlQuantity(1, "1");
            CqlInterval<long>[] expected =
            [
                new CqlInterval<long>(1,1, true, true),
                new CqlInterval<long>(2,2, true, true),
                new CqlInterval<long>(3,3, true, true),
                new CqlInterval<long>(4,4, true, true),
                new CqlInterval<long>(5,5, true, true),
                new CqlInterval<long>(6,6, true, true),
                new CqlInterval<long>(7,7, true, true),
                new CqlInterval<long>(8,8, true, true),
                new CqlInterval<long>(9,9, true, true),
                new CqlInterval<long>(10,10, true, true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[1, 5], Interval[7, 10] } per 1
        /// </summary>
        [TestMethod]
        public void ExpandList_Intervals_Int()
        {
            List<CqlInterval<int?>> interval =
            [
                new CqlInterval<int?>(1, 5, true, true),
                new CqlInterval<int?>(7, 10, true, true)
            ];
            var quantity = new CqlQuantity(1, "1");
            CqlInterval<int>[] expected =
            [
                new CqlInterval<int>(1,1, true, true),
                new CqlInterval<int>(2,2, true, true),
                new CqlInterval<int>(3,3, true, true),
                new CqlInterval<int>(4,4, true, true),
                new CqlInterval<int>(5,5, true, true),
                new CqlInterval<int>(7,7, true, true),
                new CqlInterval<int>(8,8, true, true),
                new CqlInterval<int>(9,9, true, true),
                new CqlInterval<int>(10,10, true, true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[1, 5], Interval[7, 10] } per 1
        /// </summary>
        [TestMethod]
        public void ExpandList_Intervals_Decimal()
        {
            List<CqlInterval<decimal?>> interval =
            [
                new CqlInterval<decimal?>(1, 5, true, true),
                new CqlInterval<decimal?>(7, 10, true, true)
            ];
            var quantity = new CqlQuantity(1, "1");
            CqlInterval<decimal>[] expected =
            [
                new CqlInterval<decimal>(1,1.99999999m, true, true),
                new CqlInterval<decimal>(2,2.99999999m, true, true),
                new CqlInterval<decimal>(3,3.99999999m, true, true),
                new CqlInterval<decimal>(4,4.99999999m, true, true),
                new CqlInterval<decimal>(5,5.99999999m, true, true),
                new CqlInterval<decimal>(7,7.99999999m, true, true),
                new CqlInterval<decimal>(8,8.99999999m, true, true),
                new CqlInterval<decimal>(9,9.99999999m, true, true),
                new CqlInterval<decimal>(10,10.99999999m, true, true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[1, 5], Interval[7, 10] } per 1
        /// </summary>
        [TestMethod]
        public void ExpandList_Intervals_Long()
        {
            List<CqlInterval<long?>> interval =
            [
                new CqlInterval<long?>(1, 5, true, true),
                new CqlInterval<long?>(7, 10, true, true)
            ];
            var quantity = new CqlQuantity(1, "1");
            CqlInterval<long>[] expected =
            [
                new CqlInterval<long>(1,1, true, true),
                new CqlInterval<long>(2,2, true, true),
                new CqlInterval<long>(3,3, true, true),
                new CqlInterval<long>(4,4, true, true),
                new CqlInterval<long>(5,5, true, true),
                new CqlInterval<long>(7,7, true, true),
                new CqlInterval<long>(8,8, true, true),
                new CqlInterval<long>(9,9, true, true),
                new CqlInterval<long>(10,10, true, true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        #endregion

        #region Expand List<Interval[Date, Date]>
        /// <summary>
        /// expand { Interval[@2022-01-01, @2022-01-04] }
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_Date_Null_Quantity()
        {
            List<CqlInterval<CqlDate>> interval =
                [new CqlInterval<CqlDate>(new CqlDate(2022, 1, 1), new CqlDate(2022, 1, 4), true, true)];

            CqlInterval<CqlDate>[] expected =
            [
                new CqlInterval<CqlDate>(new CqlDate(2022, 1, 1), new CqlDate(2022, 1, 1), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022, 1, 2), new CqlDate(2022, 1, 2), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022, 1, 3), new CqlDate(2022, 1, 3), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022, 1, 4), new CqlDate(2022, 1, 4), true, true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, null).ToArray();
            Assert.IsNotNull(expand);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[@2022-01, @2022-04-01] }
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_Date_MonthPrecison_Null_Quantity()
        {
            List<CqlInterval<CqlDate>> interval =
                [new CqlInterval<CqlDate>(new CqlDate(2022, 1, null), new CqlDate(2022, 4, 1), true, true)];

            CqlInterval<CqlDate>[] expected =
            [
                new CqlInterval<CqlDate>(new CqlDate(2022, 1, null), new CqlDate(2022, 1, null), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022, 2, null), new CqlDate(2022, 2, null), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022, 3, null), new CqlDate(2022, 3, null), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022, 4, null), new CqlDate(2022, 4, null), true, true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, null).ToArray();
            Assert.IsNotNull(expand);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[@2022-01-01, @2022-01-04] } per day
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_Date_Day()
        {
            List<CqlInterval<CqlDate>> interval =
                [new CqlInterval<CqlDate>(new CqlDate(2022, 1, 1), new CqlDate(2022, 1, 4), true, true)];
            var quantity = new CqlQuantity(1, "day");
            CqlInterval<CqlDate>[] expected =
            [
                new CqlInterval<CqlDate>(new CqlDate(2022, 1, 1), new CqlDate(2022, 1, 1), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022, 1, 2), new CqlDate(2022, 1, 2), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022, 1, 3), new CqlDate(2022, 1, 3), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022, 1, 4), new CqlDate(2022, 1, 4), true, true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            Assert.IsTrue(expected.Length == expand.Length);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[@2022-01-01, @2022-03-01] } per 3 months
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_Date_Month()
        {
            List<CqlInterval<CqlDate>> interval =
                [new CqlInterval<CqlDate>(new CqlDate(2022, 1, 1), new CqlDate(2022, 3, 1), true, true)];
            var quantity = new CqlQuantity(3, "month");
            CqlInterval<CqlDate>[] expected =
            [
                new CqlInterval<CqlDate>(new CqlDate(2022, 1, 1), new CqlDate(2022, 3, 31), true, true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            Assert.IsTrue(expected.Length == expand.Length);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[@2022-01-01, @2024-03-01] } per 2 years
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_Date_Year()
        {
            List<CqlInterval<CqlDate>> interval =
                [new CqlInterval<CqlDate>(new CqlDate(2022, 1, 1), new CqlDate(2024, 3, 1), true, true)];
            var quantity = new CqlQuantity(2, "years");
            CqlInterval<CqlDate>[] expected =
            [
                new CqlInterval<CqlDate>(new CqlDate(2022, 1, 1), new CqlDate(2023, 12, 31), true, true),
                 new CqlInterval<CqlDate>(new CqlDate(2024, 1, 1), new CqlDate(2025, 12, 31), true, true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            Assert.IsTrue(expected.Length == expand.Length);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[@2022-01-01, @2022-02-01] } per week
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_Date_Week()
        {
            List<CqlInterval<CqlDate>> interval =
                [new CqlInterval<CqlDate>(new CqlDate(2022, 1, 1), new CqlDate(2022, 2, 1), true, true)];
            var quantity = new CqlQuantity(1, "week");
            CqlInterval<CqlDate>[] expected =
            [
                new CqlInterval<CqlDate>(new CqlDate(2022, 1, 1), new CqlDate(2022, 1, 7), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022, 1, 8), new CqlDate(2022, 1, 14), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022, 1, 15), new CqlDate(2022, 1, 21), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022, 1, 22), new CqlDate(2022, 1, 28), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022, 1, 29), new CqlDate(2022, 2, 4), true, true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            Assert.IsTrue(expected.Length == expand.Length);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[@2022-01-01, @2024-03-01] } per minute
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_Date_Minute()
        {
            List<CqlInterval<CqlDate>> interval =
                [new CqlInterval<CqlDate>(new CqlDate(2022, 1, 1), new CqlDate(2024, 3, 1), true, true)];
            var quantity = new CqlQuantity(1, "minute");

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.Count() == 0);
        }

        /// <summary>
        /// expand { Interval[@2022-01-01, @2024-03-01] } per hour
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_Date_Hour()
        {
            List<CqlInterval<CqlDate>> interval =
                [new CqlInterval<CqlDate>(new CqlDate(2022, 1, 1), new CqlDate(2024, 3, 1), true, true)];
            var quantity = new CqlQuantity(1, "hour");

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.Count() == 0);
        }

        /// <summary>
        /// expand { Interval[@2022-01-01, @2024-03-01] } per second
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_Date_Second()
        {
            List<CqlInterval<CqlDate>> interval =
                [new CqlInterval<CqlDate>(new CqlDate(2022, 1, 1), new CqlDate(2024, 3, 1), true, true)];
            var quantity = new CqlQuantity(1, "second");

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.Count() == 0);
        }

        /// <summary>
        /// expand { Interval[@2022-01-01, @2024-03-01] } per millisecond
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_Date_Millisecond()
        {
            List<CqlInterval<CqlDate>> interval =
                [new CqlInterval<CqlDate>(new CqlDate(2022, 1, 1), new CqlDate(2024, 3, 1), true, true)];
            var quantity = new CqlQuantity(1, "millisecond");

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.Count() == 0);
        }

        /// <summary>
        /// /// expand { Interval[@2022-01, @2022-04] } per month
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_Date_MonthYear()
        {
            var start = new CqlDate(2022, 1, null);
            var end = new CqlDate(2022, 4, null);

            List<CqlInterval<CqlDate>> interval = [new CqlInterval<CqlDate>(start, end, true, true)];
            var quantity = new CqlQuantity(1, "month");
            CqlInterval<CqlDate>[] expected =
            [
                new CqlInterval<CqlDate>(new CqlDate(2022, 1, null), new CqlDate(2022, 1, null), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022, 2, null), new CqlDate(2022, 2, null), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022, 3, null), new CqlDate(2022, 3, null), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022, 4, null), new CqlDate(2022, 4, null), true, true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            Assert.IsTrue(expected.Length == expand.Length);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// /// expand Interval[@2022-01, @2022-04] per day
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_Date_MonthYear_Quantity_Day()
        {
            var start = new CqlDate(2022, 1, null);
            var end = new CqlDate(2022, 4, null);

            List<CqlInterval<CqlDate>> interval = [new CqlInterval<CqlDate>(start, end, true, true)];

            var quantity = new CqlQuantity(1, "day");

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.Count() == 0);
        }

        /// <summary>
        /// /// expand Interval[@2022, @2023] per day
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_Date_Year_Quantity_Day()
        {
            var start = new CqlDate(2022, null, null);
            var end = new CqlDate(2023, null, null);

            List<CqlInterval<CqlDate>> interval = [new CqlInterval<CqlDate>(start, end, true, true)];
            var quantity = new CqlQuantity(1, "day");

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.Count() == 0);
        }

        /// <summary>
        /// expand { Interval[@2022-01-01, @2022-06-01], Interval[@2022-06-01, @2022-12-01] } per month
        /// </summary>
        [TestMethod]
        public void ExpandList_Intervals_Overlap_Date()
        {
            var aStart = new CqlDate(2022, 1, 1);
            var aEnd = new CqlDate(2022, 6, 1);

            var bStart = new CqlDate(2022, 6, 1);
            var bEnd = new CqlDate(2022, 12, 1);

            List<CqlInterval<CqlDate>> interval =
            [
                new CqlInterval<CqlDate>(aStart, aEnd, true, true),
                new CqlInterval<CqlDate>(bStart, bEnd, true, true)
            ];
            var quantity = new CqlQuantity(1, "month");
            CqlInterval<CqlDate>[] expected =
            [
                new CqlInterval<CqlDate>(new CqlDate(2022,1,1),new CqlDate(2022,1,31), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,2,1),new CqlDate(2022,2,28), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,3,1),new CqlDate(2022,3,31), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,4,1),new CqlDate(2022,4,30), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,5,1),new CqlDate(2022,5,31), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,6,1),new CqlDate(2022,6,30), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,7,1),new CqlDate(2022,7,31), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,8,1),new CqlDate(2022,8,31), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,9,1),new CqlDate(2022,9,30), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,10,1),new CqlDate(2022,10,31), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,11,1),new CqlDate(2022,11,30), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,12,1),new CqlDate(2022,12,31), true, true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            Assert.IsTrue(expected.Length == expand.Length);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[@2022-01-01, @2022-05-01], Interval[@2022-07-01, @2022-12-01] } per month
        /// </summary>
        [TestMethod]
        public void ExpandList_Intervals_Date()
        {
            var aStart = new CqlDate(2022, 1, 1);
            var aEnd = new CqlDate(2022, 5, 1);

            var bStart = new CqlDate(2022, 7, 1);
            var bEnd = new CqlDate(2022, 12, 1);

            List<CqlInterval<CqlDate>> interval =
            [
                new CqlInterval<CqlDate>(aStart, aEnd, true, true),
                new CqlInterval<CqlDate>(bStart, bEnd, true, true)
            ];
            var quantity = new CqlQuantity(1, "month");
            CqlInterval<CqlDate>[] expected =
            [
                new CqlInterval<CqlDate>(new CqlDate(2022,1,1),new CqlDate(2022,1,31), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,2,1),new CqlDate(2022,2,28), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,3,1),new CqlDate(2022,3,31), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,4,1),new CqlDate(2022,4,30), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,5,1),new CqlDate(2022,5,31), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,7,1),new CqlDate(2022,7,31), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,8,1),new CqlDate(2022,8,31), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,9,1),new CqlDate(2022,9,30), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,10,1),new CqlDate(2022,10,31), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,11,1),new CqlDate(2022,11,30), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,12,1),new CqlDate(2022,12,31), true, true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            Assert.IsTrue(expected.Length == expand.Length);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[@2023-01-01, @2023-12-31] } per 31 days
        /// </summary>
        [TestMethod]
        public void ExpandList_Intervals_Date_31_Days()
        {
            var aStart = new CqlDate(2022, 1, 1);
            var aEnd = new CqlDate(2022, 12, 31);

            List<CqlInterval<CqlDate>> interval = [new CqlInterval<CqlDate>(aStart, aEnd, true, true)];
            var quantity = new CqlQuantity(31, "days");
            CqlInterval<CqlDate>[] expected =
            [
                new CqlInterval<CqlDate>(new CqlDate(2022,1,1),new CqlDate(2022,1,31), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,2,1),new CqlDate(2022,3,3), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,3,4),new CqlDate(2022,4,3), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,4,4),new CqlDate(2022,5,4), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,5,5),new CqlDate(2022,6,4), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,6,5),new CqlDate(2022,7,5), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,7,6),new CqlDate(2022,8,5), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,8,6),new CqlDate(2022,9,5), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,9,6),new CqlDate(2022,10,6), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,10,7),new CqlDate(2022,11,6), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,11,7),new CqlDate(2022,12,7), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2022,12,8),new CqlDate(2023,1,7), true, true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            Assert.IsTrue(expected.Length == expand.Length);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        #endregion

        #region Expand Interval[DateTime, DateTime]
        /// <summary>
        /// expand { Interval[@2022-01-01@T12:00:00:00, @2022-01-04@T12:00:00:05] }
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_DateTime_Null_Quantity()
        {
            var start = new CqlDateTime(2022, 1, 1, 12, 0, 0, 0, 0, 0);
            var end = new CqlDateTime(2022, 1, 1, 12, 0, 0, 5, 0, 0);

            List<CqlInterval<CqlDateTime>> interval = [new CqlInterval<CqlDateTime>(start, end, true, true)];
            CqlInterval<CqlDateTime>[] expected =
            [
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,1,12,0,0,0,0,0), new CqlDateTime(2022,1,1,12,0,0,0,0,0), true, true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,1,12,0,0,1,0,0), new CqlDateTime(2022,1,1,12,0,0,1,0,0), true, true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,1,12,0,0,2,0,0), new CqlDateTime(2022,1,1,12,0,0,2,0,0), true, true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,1,12,0,0,3,0,0), new CqlDateTime(2022,1,1,12,0,0,3,0,0), true, true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,1,12,0,0,4,0,0), new CqlDateTime(2022,1,1,12,0,0,4,0,0), true, true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,1,12,0,0,5,0,0), new CqlDateTime(2022,1,1,12,0,0,5,0,0), true, true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, null).ToArray();
            Assert.IsNotNull(expand);
            Assert.IsTrue(expected.Length == expand.Length);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[@2022-01-01, @2022-01-04@T12:00:00:05] }
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_DateTime_Day_Precision_Null_Quantity()
        {
            var start = new CqlDateTime(2022, 1, 1, null, null, null, null, null, null);
            var end = new CqlDateTime(2022, 1, 4, 12, 0, 0, 5, 0, 0);

            List<CqlInterval<CqlDateTime>> interval = [new CqlInterval<CqlDateTime>(start, end, true, true)];
            CqlInterval<CqlDateTime>[] expected =
            [
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,1,null, null, null, null, null, null), new CqlDateTime(2022,1,1,null, null, null, null, null, null), true, true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,2,null, null, null, null, null, null), new CqlDateTime(2022,1,2,null, null, null, null, null, null), true, true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,3,null, null, null, null, null, null), new CqlDateTime(2022,1,3,null, null, null, null, null, null), true, true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,4,null, null, null, null, null, null), new CqlDateTime(2022,1,4,null, null, null, null, null, null), true, true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, null).ToArray();
            Assert.IsNotNull(expand);
            Assert.IsTrue(expected.Length == expand.Length);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// /// expand { Interval[@2022-01-01@T12, @2022-01-04@T12] } per minute
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_DateTime_Hour_Minute_Quantity()
        {
            var start = new CqlDateTime(2022, 1, 1, 12, null, null, null, null, null);
            var end = new CqlDateTime(2022, 1, 1, 12, null, null, null, null, null);

            List<CqlInterval<CqlDateTime>> interval = [new CqlInterval<CqlDateTime>(start, end, true, true)];
            var quantity = new CqlQuantity(1, "minute");

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.Count() == 0);
        }

        /// <summary>
        /// expand { Interval[@2022-01-01@T12:00:00:00, @2022-01-04@T12:00:00:00] } per day
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_DateTime_Day()
        {
            var start = new CqlDateTime(2022, 1, 1, 12, 0, 0, 0, 0, 0);
            var end = new CqlDateTime(2022, 1, 4, 12, 0, 0, 0, 0, 0);

            List<CqlInterval<CqlDateTime>> interval = [new CqlInterval<CqlDateTime>(start, end, true, true)];
            var quantity = new CqlQuantity(1, "day");
            CqlInterval<CqlDateTime>[] expected =
            [
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,1,12,0,0,0,0,0),new CqlDateTime(2022,1,2,11,59,59,999,0,0),true,true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,2,12,0,0,0,0,0),new CqlDateTime(2022,1,3,11,59,59,999,0,0),true,true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,3,12,0,0,0,0,0),new CqlDateTime(2022,1,4,11,59,59,999,0,0),true,true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,4,12,0,0,0,0,0),new CqlDateTime(2022,1,5,11,59,59,999,0,0),true,true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            Assert.IsTrue(expected.Length == expand.Length);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[@2022-01-01@T12:00:00:00, @2022-03-01@T00:00:00:00] } per 3 months
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_DateTime_Month()
        {
            var start = new CqlDateTime(2022, 1, 1, 12, 0, 0, 0, 0, 0);
            var end = new CqlDateTime(2022, 3, 1, 0, 0, 0, 0, 0, 0);

            List<CqlInterval<CqlDateTime>> interval = [new CqlInterval<CqlDateTime>(start, end, true, true)];
            var quantity = new CqlQuantity(3, "month");
            CqlInterval<CqlDateTime>[] expected =
            [
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,1,12,0,0,0,0,0),new CqlDateTime(2022,4,1,11,59,59,999,0,0),true,true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            Assert.IsTrue(expected.Length == expand.Length);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[@2022-01-01@T12:00:00:00, @2024-03-01@T00:00:00:00] } per 2 years
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_DateTime_Year()
        {
            var start = new CqlDateTime(2022, 1, 1, 12, 0, 0, 0, 0, 0);
            var end = new CqlDateTime(2024, 3, 1, 0, 0, 0, 0, 0, 0);

            List<CqlInterval<CqlDateTime>> interval = [new CqlInterval<CqlDateTime>(start, end, true, true)];
            var quantity = new CqlQuantity(2, "years");
            CqlInterval<CqlDateTime>[] expected =
            [
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,1,12,0,0,0,0,0),new CqlDateTime(2024,1,1,11,59,59,999,0,0),true,true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2024,1,1,12,0,0,0,0,0),new CqlDateTime(2026,1,1,11,59,59,999,0,0),true,true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            Assert.IsTrue(expected.Length == expand.Length);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[@2022-01-01@T12:00:00:00, @2022-02-01@T12:00:00:00] } per week
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_DateTime_Week()
        {
            var start = new CqlDateTime(2022, 1, 1, 12, 0, 0, 0, 0, 0);
            var end = new CqlDateTime(2022, 2, 1, 0, 0, 0, 0, 0, 0);

            List<CqlInterval<CqlDateTime>> interval = [new CqlInterval<CqlDateTime>(start, end, true, true)];
            var quantity = new CqlQuantity(1, "week");
            CqlInterval<CqlDateTime>[] expected =
            [
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,1,12,0,0,0,0,0),new CqlDateTime(2022,1,8,11,59,59,999,0,0),true,true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,8,12,0,0,0,0,0),new CqlDateTime(2022,1,15,11,59,59,999,0,0),true,true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,15,12,0,0,0,0,0),new CqlDateTime(2022,1,22,11,59,59,999,0,0),true,true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,22,12,0,0,0,0,0),new CqlDateTime(2022,1,29,11,59,59,999,0,0),true,true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,29,12,0,0,0,0,0),new CqlDateTime(2022,2,5,11,59,59,999,0,0),true,true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            Assert.IsTrue(expected.Length == expand.Length);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[@2022-01-01@T00:00:00:00, @2022-01-01@T00:05:00:00] } per 2 minutes
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_DateTime_Minute()
        {
            var start = new CqlDateTime(2022, 1, 1, 0, 0, 0, 0, 0, 0);
            var end = new CqlDateTime(2022, 1, 1, 0, 5, 0, 0, 0, 0);

            List<CqlInterval<CqlDateTime>> interval = [new CqlInterval<CqlDateTime>(start, end, true, true)];
            var quantity = new CqlQuantity(2, "minutes");
            CqlInterval<CqlDateTime>[] expected =
            [
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,1,0,0,0,0,0,0),new CqlDateTime(2022,1,1,0,1,59,999,0,0),true,true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,1,0,2,0,0,0,0),new CqlDateTime(2022,1,1,0,3,59,999,0,0),true,true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,1,0,4,0,0,0,0),new CqlDateTime(2022,1,1,0,5,59,999,0,0),true,true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            Assert.IsTrue(expected.Length == expand.Length);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[@2022-01-01@T00:00:00:00, @2022-01-01@T06:00:00:00] } per 2 hours
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_DateTime_Hour()
        {
            var start = new CqlDateTime(2022, 1, 1, 0, 0, 0, 0, 0, 0);
            var end = new CqlDateTime(2022, 1, 1, 6, 0, 0, 0, 0, 0);

            List<CqlInterval<CqlDateTime>> interval = [new CqlInterval<CqlDateTime>(start, end, true, true)];
            var quantity = new CqlQuantity(2, "hours");
            CqlInterval<CqlDateTime>[] expected =
            [
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,1,0,0,0,0,0,0),new CqlDateTime(2022,1,1,1,59,59,999,0,0),true,true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,1,2,0,0,0,0,0),new CqlDateTime(2022,1,1,3,59,59,999,0,0),true,true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,1,4,0,0,0,0,0),new CqlDateTime(2022,1,1,5,59,59,999,0,0),true,true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,1,6,0,0,0,0,0),new CqlDateTime(2022,1,1,7,59,59,999,0,0),true,true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            Assert.IsTrue(expected.Length == expand.Length);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[@2022-01-01@T00:00:00:00, @2022-01-01@T00:00:06:00] } per 3 seconds
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_DateTime_Second()
        {
            var start = new CqlDateTime(2022, 1, 1, 0, 0, 0, 0, 0, 0);
            var end = new CqlDateTime(2022, 1, 1, 0, 0, 6, 0, 0, 0);

            List<CqlInterval<CqlDateTime>> interval = [new CqlInterval<CqlDateTime>(start, end, true, true)];
            var quantity = new CqlQuantity(3, "seconds");
            CqlInterval<CqlDateTime>[] expected =
            [
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,1,0,0,0,0,0,0),new CqlDateTime(2022,1,1,0,0,2,999,0,0),true,true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,1,0,0,3,0,0,0),new CqlDateTime(2022,1,1,0,0,5,999,0,0),true,true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,1,0,0,6,0,0,0),new CqlDateTime(2022,1,1,0,0,8,999,0,0),true,true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            Assert.IsTrue(expected.Length == expand.Length);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[@2022-01-01@T00:00:00:00, @2022-01-01@T00:00:03:00] } per 30 milliseconds
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_DateTime_Millisecond()
        {
            var start = new CqlDateTime(2022, 1, 1, 0, 0, 0, 0, 0, 0);
            var end = new CqlDateTime(2022, 1, 1, 0, 0, 3, 0, 0, 0);

            List<CqlInterval<CqlDateTime>> interval = [new CqlInterval<CqlDateTime>(start, end, true, true)];
            var quantity = new CqlQuantity(500, "milliseconds");
            CqlInterval<CqlDateTime>[] expected =
            [
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,1,0,0,0,0,0,0),new CqlDateTime(2022,1,1,0,0,0,499,0,0),true,true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,1,0,0,0,500,0,0),new CqlDateTime(2022,1,1,0,0,0,999,0,0),true,true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,1,0,0,1,0,0,0),new CqlDateTime(2022,1,1,0,0,1,499,0,0),true,true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,1,0,0,1,500,0,0),new CqlDateTime(2022,1,1,0,0,1,999,0,0),true,true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,1,0,0,2,0,0,0),new CqlDateTime(2022,1,1,0,0,2,499,0,0),true,true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,1,0,0,2,500,0,0),new CqlDateTime(2022,1,1,0,0,2,999,0,0),true,true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,1,0,0,3,0,0,0),new CqlDateTime(2022,1,1,0,0,3,499,0,0),true,true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            Assert.IsTrue(expected.Length == expand.Length);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[@2022-01-01T00:00:00, @2022-06-01T00:00:00], Interval[@2022-06-01T00:00:00, @2022-12-01T00:00:00] } per month
        /// </summary>
        [TestMethod]
        public void ExpandList_Intervals_Overlap_DateTime()
        {
            var aStart = new CqlDateTime(2022, 1, 1, 0, 0, 0, 0, 0, 0);
            var aEnd = new CqlDateTime(2022, 6, 1, 0, 0, 0, 0, 0, 0);

            var bStart = new CqlDateTime(2022, 6, 1, 0, 0, 0, 0, 0, 0);
            var bEnd = new CqlDateTime(2022, 12, 1, 0, 0, 0, 0, 0, 0);

            List<CqlInterval<CqlDateTime>> interval =
            [
                new CqlInterval<CqlDateTime>(aStart, aEnd, true, true),
                new CqlInterval<CqlDateTime>(bStart, bEnd, true, true)
            ];
            var quantity = new CqlQuantity(1, "month");
            CqlInterval<CqlDateTime>[] expected =
            [
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,1,0,0,0,0,0,0),new CqlDateTime(2022,1,31,23,59,59,999,0,0), true, true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,2,1,0,0,0,0,0,0),new CqlDateTime(2022,2,28,23,59,59,999,0,0), true, true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,3,1,0,0,0,0,0,0),new CqlDateTime(2022,3,31,23,59,59,999,0,0), true, true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,4,1,0,0,0,0,0,0),new CqlDateTime(2022,4,30,23,59,59,999,0,0), true, true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,5,1,0,0,0,0,0,0),new CqlDateTime(2022,5,31,23,59,59,999,0,0), true, true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,6,1,0,0,0,0,0,0),new CqlDateTime(2022,6,30,23,59,59,999,0,0), true, true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,7,1,0,0,0,0,0,0),new CqlDateTime(2022,7,31,23,59,59,999,0,0), true, true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,8,1,0,0,0,0,0,0),new CqlDateTime(2022,8,31,23,59,59,999,0,0), true, true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,9,1,0,0,0,0,0,0),new CqlDateTime(2022,9,30,23,59,59,999,0,0), true, true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,10,1,0,0,0,0,0,0),new CqlDateTime(2022,10,31,23,59,59,999,0,0), true, true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,11,1,0,0,0,0,0,0),new CqlDateTime(2022,11,30,23,59,59,999,0,0), true, true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,12,1,0,0,0,0,0,0),new CqlDateTime(2022,12,31,23,59,59,999,0,0), true, true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            Assert.IsTrue(expected.Length == expand.Length);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[@2022-01-01T00:00:00, @2022-05-01T00:00:00], Interval[@2022-07-01T00:00:00, @2022-12-01T00:00:00] } per month
        /// </summary>
        [TestMethod]
        public void ExpandList_Intervals_DateTime()
        {
            var aStart = new CqlDateTime(2022, 1, 1, 0, 0, 0, 0, 0, 0);
            var aEnd = new CqlDateTime(2022, 5, 1, 0, 0, 0, 0, 0, 0);

            var bStart = new CqlDateTime(2022, 7, 1, 0, 0, 0, 0, 0, 0);
            var bEnd = new CqlDateTime(2022, 12, 1, 0, 0, 0, 0, 0, 0);

            List<CqlInterval<CqlDateTime>> interval =
            [
                new CqlInterval<CqlDateTime>(aStart, aEnd, true, true),
                new CqlInterval<CqlDateTime>(bStart, bEnd, true, true)
            ];
            var quantity = new CqlQuantity(1, "month");
            CqlInterval<CqlDateTime>[] expected =
            [
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,1,1,0,0,0,0,0,0),new CqlDateTime(2022,1,31,23,59,59,999,0,0), true, true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,2,1,0,0,0,0,0,0),new CqlDateTime(2022,2,28,23,59,59,999,0,0), true, true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,3,1,0,0,0,0,0,0),new CqlDateTime(2022,3,31,23,59,59,999,0,0), true, true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,4,1,0,0,0,0,0,0),new CqlDateTime(2022,4,30,23,59,59,999,0,0), true, true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,5,1,0,0,0,0,0,0),new CqlDateTime(2022,5,31,23,59,59,999,0,0), true, true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,7,1,0,0,0,0,0,0),new CqlDateTime(2022,7,31,23,59,59,999,0,0), true, true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,8,1,0,0,0,0,0,0),new CqlDateTime(2022,8,31,23,59,59,999,0,0), true, true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,9,1,0,0,0,0,0,0),new CqlDateTime(2022,9,30,23,59,59,999,0,0), true, true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,10,1,0,0,0,0,0,0),new CqlDateTime(2022,10,31,23,59,59,999,0,0), true, true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,11,1,0,0,0,0,0,0),new CqlDateTime(2022,11,30,23,59,59,999,0,0), true, true),
                new CqlInterval<CqlDateTime>(new CqlDateTime(2022,12,1,0,0,0,0,0,0),new CqlDateTime(2022,12,31,23,59,59,999,0,0), true, true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            Assert.IsTrue(expected.Length == expand.Length);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }
        #endregion

        #region Expand Interval[Time, Time]
        /// <summary>
        /// expand { Interval[@T10, @T12] }
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_Time_Hour_Null_Quantity()
        {
            var start = new CqlTime(10, null, null, null, null, null);
            var end = new CqlTime(12, null, null, null, null, null);

            List<CqlInterval<CqlTime>> interval = [new CqlInterval<CqlTime>(start, end, true, true)];
            CqlInterval<CqlTime>[] expected =
            [
                new CqlInterval<CqlTime>(new CqlTime(10,null,null,null,null,null),new CqlTime(10,null,null,null,null,null),true,true),
                new CqlInterval<CqlTime>(new CqlTime(11,null,null,null,null,null),new CqlTime(11,null,null,null,null,null),true,true),
                new CqlInterval<CqlTime>(new CqlTime(12,null,null,null,null,null),new CqlTime(12,null,null,null,null,null),true,true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, null).ToArray();
            Assert.IsNotNull(expand);
            Assert.IsTrue(expected.Length == expand.Length);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[@T10, @T10:05] }
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_Time_Minute_Null_Quantity()
        {
            var start = new CqlTime(10, null, null, null, null, null);
            var end = new CqlTime(11, 5, null, null, null, null);

            List<CqlInterval<CqlTime>> interval = [new CqlInterval<CqlTime>(start, end, true, true)];
            CqlInterval<CqlTime>[] expected =
            [
                new CqlInterval<CqlTime>(new CqlTime(10,null,null,null,null,null),new CqlTime(10,null,null,null,null,null),true,true),
                new CqlInterval<CqlTime>(new CqlTime(11,null,null,null,null,null),new CqlTime(11,null,null,null,null,null),true,true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, null).ToArray();
            Assert.IsNotNull(expand);
            Assert.IsTrue(expected.Length == expand.Length);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[@T10, @T10:05] } per hour
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_Time_Minute_Hour_Quantity()
        {
            var start = new CqlTime(10, null, null, null, null, null);
            var end = new CqlTime(11, 5, null, null, null, null);

            List<CqlInterval<CqlTime>> interval = [new CqlInterval<CqlTime>(start, end, true, true)];
            var quantity = new CqlQuantity(1, "hour");
            CqlInterval<CqlTime>[] expected =
            [
                new CqlInterval<CqlTime>(new CqlTime(10,null,null,null,null,null),new CqlTime(10,null,null,null,null,null),true,true),
                new CqlInterval<CqlTime>(new CqlTime(11,null,null,null,null,null),new CqlTime(11,null,null,null,null,null),true,true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, null).ToArray();
            Assert.IsNotNull(expand);
            Assert.IsTrue(expected.Length == expand.Length);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[@T10, @T12] } per day
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_Time_Day()
        {
            var start = new CqlTime(10, null, null, null, null, null);
            var end = new CqlTime(12, null, null, null, null, null);

            List<CqlInterval<CqlTime>> interval = [new CqlInterval<CqlTime>(start, end, true, true)];
            var quantity = new CqlQuantity(1, "day");

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.Count() == 0);
        }

        /// <summary>
        /// expand { Interval[@T10, @T12] } per 3 months
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_Time_Month()
        {
            var start = new CqlTime(10, null, null, null, null, null);
            var end = new CqlTime(12, null, null, null, null, null);

            List<CqlInterval<CqlTime>> interval = [new CqlInterval<CqlTime>(start, end, true, true)];
            var quantity = new CqlQuantity(3, "month");

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.Count() == 0);
        }

        /// <summary>
        /// expand { Interval[@T10, @T12] } per 2 years
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_Time_Year()
        {
            var start = new CqlTime(10, null, null, null, null, null);
            var end = new CqlTime(12, null, null, null, null, null);

            List<CqlInterval<CqlTime>> interval = [new CqlInterval<CqlTime>(start, end, true, true)];
            var quantity = new CqlQuantity(2, "years");

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.Count() == 0);
        }

        /// <summary>
        /// expand { Interval[@T10, @T12] } per week
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_Time_Week()
        {
            var start = new CqlTime(10, null, null, null, null, null);
            var end = new CqlTime(12, null, null, null, null, null);

            List<CqlInterval<CqlTime>> interval = [new CqlInterval<CqlTime>(start, end, true, true)];
            var quantity = new CqlQuantity(1, "week");

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.Count() == 0);
        }

        /// <summary>
        /// expand { Interval[@T10, @T12] } per 30 minutes
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_Time_Hour_With_Minute_Quantity()
        {
            var start = new CqlTime(10, null, null, null, null, null);
            var end = new CqlTime(12, null, null, null, null, null);

            List<CqlInterval<CqlTime>> interval = [new CqlInterval<CqlTime>(start, end, true, true)];
            var quantity = new CqlQuantity(1, "minute");

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity);
            Assert.IsNotNull(expand);
            Assert.IsTrue(expand.Count() == 0);
        }

        /// <summary>
        /// expand { Interval[@T10:00, @T12:00] } per 30 minutes
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_Time_Minute()
        {
            var start = new CqlTime(10, 0, null, null, null, null);
            var end = new CqlTime(12, 0, null, null, null, null);

            List<CqlInterval<CqlTime>> interval = [new CqlInterval<CqlTime>(start, end, true, true)];
            var quantity = new CqlQuantity(30, "minutes");
            CqlInterval<CqlTime>[] expected =
            [
                new CqlInterval<CqlTime>(new CqlTime(10,0,null,null,null,null),new CqlTime(10,29,null,null,null,null),true,true),
                new CqlInterval<CqlTime>(new CqlTime(10,30,null,null,null,null),new CqlTime(10,59,null,null,null,null),true,true),
                new CqlInterval<CqlTime>(new CqlTime(11,0,null,null,null,null),new CqlTime(11,29,null,null,null,null),true,true),
                new CqlInterval<CqlTime>(new CqlTime(11,30,null,null,null,null),new CqlTime(11,59,null,null,null,null),true,true),
                new CqlInterval<CqlTime>(new CqlTime(12,0,null,null,null,null),new CqlTime(12,29,null,null,null,null),true,true)
            ];


            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[@T10, @T12] } per hour
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_Time_Hour()
        {
            var start = new CqlTime(10, null, null, null, null, null);
            var end = new CqlTime(12, null, null, null, null, null);

            List<CqlInterval<CqlTime>> interval = [new CqlInterval<CqlTime>(start, end, true, true)];
            var quantity = new CqlQuantity(1, "hour");
            CqlInterval<CqlTime>[] expected =
            [
                new CqlInterval<CqlTime>(new CqlTime(10,null,null,null,null,null),new CqlTime(10,null,null,null,null,null),true,true),
                new CqlInterval<CqlTime>(new CqlTime(11,null,null,null,null,null),new CqlTime(11,null,null,null,null,null),true,true),
                new CqlInterval<CqlTime>(new CqlTime(12,null,null,null,null,null),new CqlTime(12,null,null,null,null,null),true,true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[@T10:00:00, @T10:00:05] } per 5 seconds
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_Time_Second()
        {
            var start = new CqlTime(10, 0, 0, null, null, null);
            var end = new CqlTime(10, 0, 5, null, null, null);

            List<CqlInterval<CqlTime>> interval = [new CqlInterval<CqlTime>(start, end, true, true)];
            var quantity = new CqlQuantity(5, "seconds");
            CqlInterval<CqlTime>[] expected =
            [
                new CqlInterval<CqlTime>(new CqlTime(10,0,0,null,null,null),new CqlTime(10,0,4,null,null,null),true,true),
                new CqlInterval<CqlTime>(new CqlTime(10,0,5,null,null,null),new CqlTime(10,0,9,null,null,null),true,true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand Interval[@T10:00:00:00, @T10:00:00:10] per 5 seconds
        /// </summary>
        [TestMethod]
        public void Expand_List_Interval_Time_Millisecond()
        {
            var start = new CqlTime(10, 0, 0, 0, null, null);
            var end = new CqlTime(10, 0, 0, 10, null, null);

            List<CqlInterval<CqlTime>> interval = [new CqlInterval<CqlTime>(start, end, true, true)];
            var quantity = new CqlQuantity(5, "millisecond");
            CqlInterval<CqlTime>[] expected =
            [
                new CqlInterval<CqlTime>(new CqlTime(10,0,0,0,null,null),new CqlTime(10,0,0,4,null,null),true,true),
                new CqlInterval<CqlTime>(new CqlTime(10,0,0,5,null,null),new CqlTime(10,0,0,9,null,null),true,true),
                new CqlInterval<CqlTime>(new CqlTime(10,0,0,10,null,null),new CqlTime(10,0,0,14,null,null),true,true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[@T10, @T12], Interval[@T12, @T16] } per hour
        /// </summary>
        [TestMethod]
        public void ExpandList_Intervals_Overlap_Time()
        {
            var aStart = new CqlTime(10, 0, 0, 0, null, null);
            var aEnd = new CqlTime(12, 0, 0, 0, null, null);

            var bStart = new CqlTime(12, 0, 0, 0, null, null);
            var bEnd = new CqlTime(16, 0, 0, 0, null, null);

            List<CqlInterval<CqlTime>> interval =
            [
                new CqlInterval<CqlTime>(aStart, aEnd, true, true),
                new CqlInterval<CqlTime>(bStart, bEnd, true, true)
            ];
            var quantity = new CqlQuantity(1, "hour");
            CqlInterval<CqlTime>[] expected =
            [
                new CqlInterval<CqlTime>(new CqlTime(10,0,0,0,null,null),new CqlTime(10,59,59,999,null,null), true, true),
                new CqlInterval<CqlTime>(new CqlTime(11,0,0,0,null,null),new CqlTime(11,59,59,999,null,null), true, true),
                new CqlInterval<CqlTime>(new CqlTime(12,0,0,0,null,null),new CqlTime(12,59,59,999,null,null), true, true),
                new CqlInterval<CqlTime>(new CqlTime(13,0,0,0,null,null),new CqlTime(13,59,59,999,null,null), true, true),
                new CqlInterval<CqlTime>(new CqlTime(14,0,0,0,null,null),new CqlTime(14,59,59,999,null,null), true, true),
                new CqlInterval<CqlTime>(new CqlTime(15,0,0,0,null,null),new CqlTime(15,59,59,999,null,null), true, true),
                new CqlInterval<CqlTime>(new CqlTime(16,0,0,0,null,null),new CqlTime(16,59,59,999,null,null), true, true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        /// <summary>
        /// expand { Interval[@T10, @T12], Interval[@T14, @T16] } per hour
        /// </summary>
        [TestMethod]
        public void ExpandList_Intervals_Time()
        {
            var aStart = new CqlTime(10, 0, 0, 0, null, null);
            var aEnd = new CqlTime(12, 0, 0, 0, null, null);

            var bStart = new CqlTime(14, 0, 0, 0, null, null);
            var bEnd = new CqlTime(16, 0, 0, 0, null, null);

            List<CqlInterval<CqlTime>> interval =
            [
                new CqlInterval<CqlTime>(aStart, aEnd, true, true),
                new CqlInterval<CqlTime>(bStart, bEnd, true, true)
            ];
            var quantity = new CqlQuantity(1, "hour");
            CqlInterval<CqlTime>[] expected =
            [
                new CqlInterval<CqlTime>(new CqlTime(10,0,0,0,null,null),new CqlTime(10,59,59,999,null,null), true, true),
                new CqlInterval<CqlTime>(new CqlTime(11,0,0,0,null,null),new CqlTime(11,59,59,999,null,null), true, true),
                new CqlInterval<CqlTime>(new CqlTime(12,0,0,0,null,null),new CqlTime(12,59,59,999,null,null), true, true),
                new CqlInterval<CqlTime>(new CqlTime(14,0,0,0,null,null),new CqlTime(14,59,59,999,null,null), true, true),
                new CqlInterval<CqlTime>(new CqlTime(15,0,0,0,null,null),new CqlTime(15,59,59,999,null,null), true, true),
                new CqlInterval<CqlTime>(new CqlTime(16,0,0,0,null,null),new CqlTime(16,59,59,999,null,null), true, true)
            ];

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
            Assert.IsNotNull(expand);
            for (var i = 0; i < expand.Length; i++)
            {
                var actual = expand[i];
                var expect = expected[i];

                Assert.AreEqual(actual.low, expect.low);
                Assert.AreEqual(actual.high, expect.high);
            }
        }

        [TestMethod]
        public void Expand_Per_Hour()
        {
            var aStart = new CqlTime(10, 0, 0, 0, null, null);
            var aEnd = new CqlTime(12, 30, 0, 0, null, null);

            var interval = new List<CqlInterval<CqlTime>>
            {
                new CqlInterval<CqlTime>(aStart, aEnd, true, true),
            };
            var quantity = new CqlQuantity(1, "hour");

            var rc = GetNewContext(); var fcq = rc.Operators;

            var expand = fcq.Expand(interval, quantity).ToArray();
        }

        #endregion

        #region Interval_Same_Or_Before
        /// <summary>
        /// Handles ([null, @2022] same or before [null, @2023]
        /// </summary>
        [TestMethod]
        public void Interval_Same_Or_Before_Overlapping()
        {
            var thru2022 = new CqlInterval<CqlDate>(null, new CqlDate(2022, null, null), true, true);
            var thru2023 = new CqlInterval<CqlDate>(null, new CqlDate(2023, null, null), true, true);

            var rc = GetNewContext(); var fcq = rc.Operators;

            var sameOrBefore = fcq.SameOrBefore(thru2022, thru2023, null);

            Assert.AreEqual(false, sameOrBefore);
        }

        /// <summary>
        /// Handles ([@2022, @2022] same or before [@2023, @2023]
        /// </summary>
        [TestMethod]
        public void Interval_Same_Or_Before()
        {
            var thru2022 = new CqlInterval<CqlDate>(new CqlDate(2022, null, null), new CqlDate(2022, null, null), true, true);
            var thru2023 = new CqlInterval<CqlDate>(new CqlDate(2023, null, null), new CqlDate(2023, null, null), true, true);

            var rc = GetNewContext(); var fcq = rc.Operators;

            var sameOrBefore = fcq.SameOrBefore(thru2022, thru2023, null);

            Assert.IsNotNull(sameOrBefore);
            Assert.IsTrue(sameOrBefore ?? false);
        }

        #endregion

        [TestMethod]
        public void Sort_Lists_Containing_Null()
        {
            var rtx = GetNewContext();
            List<int?> items = [1, 2, null, 4, 5];
            var ascending = rtx.Operators
                .ListSort(items, ListSortDirection.Ascending)
                .ToArray();
            Assert.AreEqual(null, ascending[0]);
            Assert.AreEqual(1, ascending[1]);
            Assert.AreEqual(2, ascending[2]);
            Assert.AreEqual(4, ascending[3]);
            Assert.AreEqual(5, ascending[4]);

            var descending = rtx.Operators
                .ListSort(items, ListSortDirection.Descending)
                .ToArray();
            Assert.AreEqual(5, descending[0]);
            Assert.AreEqual(4, descending[1]);
            Assert.AreEqual(2, descending[2]);
            Assert.AreEqual(1, descending[3]);
            Assert.AreEqual(null, descending[4]);
        }

        [TestMethod]
        public void Sort_Lists_Dates_Containing_Null()
        {
            var rtx = GetNewContext();
            List<CqlDate> items =
            [
                new CqlDate(2022, 12, 01),
                null,
                new CqlDate(2022, 05, 01)
            ];
            var ascending = rtx.Operators
                .ListSort(items, ListSortDirection.Ascending)
                .ToArray();
            Assert.AreEqual(null, ascending[0]);
            Assert.AreEqual(new CqlDate(2022, 05, 01), ascending[1]);
            Assert.AreEqual(new CqlDate(2022, 12, 01), ascending[2]);

            var descending = rtx.Operators
                .ListSort(items, ListSortDirection.Descending)
                .ToArray();
            Assert.AreEqual(new CqlDate(2022, 12, 01), descending[0]);
            Assert.AreEqual(new CqlDate(2022, 05, 01), descending[1]);
            Assert.AreEqual(null, descending[2]);
        }

        [TestMethod]
        public void Collapse_Properly_Included()
        {
            var rtx = GetNewContext();

            CqlInterval<CqlDate>[] expected =
            [
                new CqlInterval<CqlDate>(new CqlDate(2023, 1, 20), new CqlDate(2023, 1, 28),true, true),
                new CqlInterval<CqlDate>(new CqlDate(2023, 2, 18), new CqlDate(2023, 2, 28),true, true)
            ];

            CqlInterval<CqlDate>[] intervals =
            [
                new CqlInterval<CqlDate>(new CqlDate(2023, 1, 20), new CqlDate(2023, 1, 28), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2023, 1, 22), new CqlDate(2023, 1, 25), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2023, 2, 20), new CqlDate(2023, 2, 25), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2023, 2, 18), new CqlDate(2023, 2, 28), true, true)
            ];

            var collapsed = rtx.Operators.Collapse(intervals, null).ToArray();
            var result = rtx.Operators.Comparer.Compare(expected!, collapsed!, null);
            if (result != 0)
                throw new AssertFailedException($"Expected {expected}; actual {collapsed}");
        }

        [TestMethod]
        public void Collapse_Containing_Null()
        {
            var rtx = GetNewContext();

            CqlInterval<CqlDate>[] expected =
            [
                new CqlInterval<CqlDate>(null, new CqlDate(2022, 12, 1),true, true),
                new CqlInterval<CqlDate>(new CqlDate(2023, 1, 1), new CqlDate(2023, 9, 1),true, true),
                new CqlInterval<CqlDate>(new CqlDate(2023, 10, 2), null, true, true)
            ];

            CqlInterval<CqlDate>[] intervals =
            [
                new CqlInterval<CqlDate>(null, new CqlDate(2022, 12, 01), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2023, 1, 1), new CqlDate(2023, 4, 1), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2023, 4, 1), new CqlDate(2023, 8, 1), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2023, 7, 1), new CqlDate(2023, 9, 1), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2023, 10, 2), null, true, true)
            ];

            var collapsed = rtx.Operators.Collapse(intervals, null).ToArray();
            var result = rtx.Operators.Comparer.Compare(expected!, collapsed!, null);
            if (result != 0)
                throw new AssertFailedException($"Expected {expected}; actual {collapsed}");
        }

        [TestMethod]
        public void Aggregate_Query_Test()
        {
            using var serviceProvider = new ServiceCollection()
                                        .AddDebugLogging()
                                        .AddCqlCodeGenerationServices()
                                        .BuildServiceProvider(validateScopes: true);
            using var serviceScope = serviceProvider.CreateScope();

            var librarySet = new LibrarySet();
            librarySet.LoadLibraryAndDependencies(new DirectoryInfo("Input\\ELM\\Test"),"Aggregates", "1.0.0");
            var elmPackage = librarySet.GetLibrary("Aggregates-1.0.0");
            var definitions = serviceScope.ServiceProvider.GetLibraryExpressionBuilderScoped().ProcessLibrary(elmPackage);
            var writer = serviceProvider.GetCSharpLibrarySetToStreamsWriter();
            var isDone = false;
            writer.ProcessDefinitions(
                definitions,
                librarySet,
                callbacks:new(onAfterStep: step =>
                {
                    switch (step)
                    {
                        case CSharpSourceCodeStep.OnDone:
                            isDone = true;
                            break;
                    }
                }));
            Assert.IsTrue(isDone);
        }

        [TestMethod]
        public void Meets_Date()
        {
            var rtx = GetNewContext();

            var meets = rtx.Operators.Meets(
                new CqlInterval<CqlDate>(null, new CqlDate(2022, 12, 31), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2023, 1, 1), new CqlDate(2023, 4, 1), true, true),
                null);
            Assert.IsNotNull(meets);
            Assert.IsTrue(meets ?? false);

            meets = rtx.Operators.Meets(
                new CqlInterval<CqlDate>(null, new CqlDate(2022, 12, 31), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2023, 1, 1), null, true, true),
                null);
            Assert.IsNotNull(meets);
            Assert.IsTrue(meets ?? false);

            // Interval[null, 2022-12-31] meets Interval[2024-01-01, null] returns false
            meets = rtx.Operators.Meets(
                new CqlInterval<CqlDate>(null, new CqlDate(2022, 12, 31), true, true),
                new CqlInterval<CqlDate>(new CqlDate(2023, 7, 1), null, true, true),
                null);
            Assert.IsNotNull(meets);
            Assert.IsFalse(meets ?? false);
        }

        [TestMethod]
        public void DateTimeIncludedInNull()
        {
            var lhs = new CqlInterval<CqlDateTime>(
                new CqlDateTime(2017, 9, 1, 0, 0, 0, null, null, null),
                new CqlDateTime(2017, 9, 1, 0, 0, 0, null, null, null),
                true,
                true);
            var rhs = new CqlInterval<CqlDateTime>(
                new CqlDateTime(2017, 9, 1, 0, 0, 0, 999, null, null),
                new CqlDateTime(2017, 12, 30, 23, 59, 59, 999, null, null),
                true,
                true);
            var ops = GetNewContext().Operators;
            var result = ops.IntervalIncludesInterval(lhs, rhs, null);
            Assert.IsNull(result);
        }
        [TestMethod]
        public void TestIntersectNull()
        {
            var lhs = new CqlInterval<int?>(1, 10, true, true);
            var rhs = new CqlInterval<int?>(5, null, true, false);
            var ops = GetNewContext().Operators;
            var result = ops.Intersect(lhs, rhs);
            Assert.IsNull(result);
        }

        // { @T15:59:59.999, @T20:59:59.999, @T20:59:49.999 } properly includes @T15:59:59
        [TestMethod]
        public void ProperContainsTimeNull()
        {
            var list = new CqlTime[]
            {
                new CqlTime(15,59,59, 999, null, null),
                new CqlTime(20,59,59, 999, null, null),
                new CqlTime(20,59,49, 999, null, null),
            };
            var element = new CqlTime(15, 59, 59, null, null, null);
            var ops = GetNewContext().Operators;
            var result = ops.ListProperlyIncludesElement(list, element);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void UnionListNullAndListNull()
        {
            var ops = GetNewContext().Operators;
            var result = ops.Union<object>(new object[] { null }, new object[] { null });
            var equal = ops.Equal(result, new object[] { null });
            Assert.IsTrue(equal);
        }

        [TestMethod]
        public void TimeProperContainsFalse()
        {
            var ops = GetNewContext().Operators;
            var noon = new CqlTime(12, 0, 0, 0, null, null);
            var x = new CqlTime(21, 59, 59, 999, null, null);
            var interval = new CqlInterval<CqlTime>(noon, x, true, true);
            var result = ops.IntervalProperlyIncludesElement(interval, noon, null);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void NullBoundariesProperlyIncludesIntegerInterval()
        {
            var ops = GetNewContext().Operators;
            var lhs = new CqlInterval<int?>(null, null, true, true);
            var rhs = new CqlInterval<int?>(1, 10, true, true);
            var result = ops.IntervalProperlyIncludedInInterval(lhs, rhs, null);
            Assert.IsNull(result);

        }

        [TestMethod]
        public void LastPositionOf1()
        {
            var ops = GetNewContext().Operators;
            var lpo = ops.LastPositionOf("Ohio is the place to be!", "hi");
            lpo.Should().Be(1);
        }

        [TestMethod]
        public void QuantityToString()
        {
            var ops = GetNewContext().Operators;
            var s = ops.ConvertQuantityToString(new CqlQuantity(125, "cm"));
            s.Should().Be("125 'cm'");
        }
    }
}