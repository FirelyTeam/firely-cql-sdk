/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class DurationTest : Base
    {
        [TestMethod]
        public void Duration_Between_Days()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library DurationTest version '1.0.0'

                define private Duration_Between_Days: duration in days between @2023-01-01 and @2023-01-31
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DurationBetween));
            {
                var diff = (DurationBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Day, diff.precision);

                var result = Run(diff, library);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(30, result);
            }
        }


        [TestMethod]
        public void Duration_Between_Days_Shortform()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library DurationTest version '1.0.0'

                define private Duration_Between_Days: days between @2023-01-01 and @2023-01-31
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DurationBetween));
            {
                var diff = (DurationBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Day, diff.precision);

                var result = Run(diff, library);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(30, result);
            }
        }
        //https://cql.hl7.org/15-h-timeintervalcalculations.html#calculating-duration-in-days
        [TestMethod]
        public void Duration_Between_Days_Scenario_1_Ex1()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library DurationTest version '1.0.0'

                define private Duration_Between_Days: duration in days between @2012-01-31T12:30:00Z and @2012-02-01T09:30:00Z
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DurationBetween));
            {
                var diff = (DurationBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Day, diff.precision);

                var result = Run(diff, library);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(0, result);
            }
        }
        [TestMethod]
        public void Duration_Between_Days_Scenario_1_Ex2()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library DurationTest version '1.0.0'

                define private Duration_Between_Days: duration in days between @2012-01-31T12:30:00Z and @2012-02-01T14:00:00Z
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DurationBetween));
            {
                var diff = (DurationBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Day, diff.precision);

                var result = Run(diff, library);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(1, result);
            }
        }

        [TestMethod]
        public void Duration_Between_Days_Scenario_1_Ex3()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library DurationTest version '1.0.0'

                define private Duration_Between_Days: duration in days between @2011-12-05T05:00:00Z and @2011-12-04T08:45:00Z
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DurationBetween));
            {
                var diff = (DurationBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Day, diff.precision);

                var result = Run(diff, library);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(0, result);
            }
        }

        [TestMethod]
        public void Duration_Between_Days_Scenario_1_Ex4()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library DurationTest version '1.0.0'

                define private Duration_Between_Days: duration in days between @2011-12-05T05:00:00Z and @2011-12-04T01:30:00Z
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DurationBetween));
            {
                var diff = (DurationBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Day, diff.precision);

                var result = Run(diff, library);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(-1, result);
            }
        }

        [TestMethod]
        public void Duration_Between_Months()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library DurationTest version '1.0.0'

                define private Duration_Between_Months: duration in months between @2023-01-01 and @2023-02-01
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DurationBetween));
            {
                var diff = (DurationBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Month, diff.precision);

                var result = Run(diff, library);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(1, result);
            }
        }
        [TestMethod]
        public void Duration_Between_Weeks()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library DurationTest version '1.0.0'

                define private Duration_Between_Months: duration in weeks between @2023-01-01 and @2023-01-08
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DurationBetween));
            {
                var diff = (DurationBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Week, diff.precision);

                var result = Run(diff, library);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(1, result);
            }
        }


        [TestMethod]
        public void Duration_Between_Years()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library DurationTest version '1.0.0'

                define private Duration_Between_Months: duration in years between @2023-01-01 and @2024-02-01
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DurationBetween));
            {
                var diff = (DurationBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Year, diff.precision);

                var result = Run(diff, library);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(1, result);
            }
        }

        // https://cql.hl7.org/15-h-timeintervalcalculations.html#calculating-duration-in-years
        // On the anniversary date the year or month is whole only once the start's time of day has been reached.
        [TestMethod]
        [DataRow("years between @2012-03-10T22:05:09 and @2013-03-10T19:10:03", 0)]
        [DataRow("years between @2012-03-10T22:05:09 and @2013-03-10T22:05:09", 1)]
        [DataRow("years between @2013-03-10T19:10:03 and @2012-03-10T22:05:09", 0)]
        [DataRow("years between @2013-03-10T22:05:09 and @2012-03-10T22:05:09", -1)]
        [DataRow("years between @2012-03-10T10:20:00 and @2013-03-10T09:20:00", 0)]
        [DataRow("years between (date from @2012-03-10T10:20:00) and (date from @2013-03-10T09:20:00)", 1)]
        [DataRow("months between @2012-03-10T22:05:09 and @2012-04-10T19:10:03", 0)]
        [DataRow("months between @2012-03-10T22:05:09 and @2012-04-10T22:05:09", 1)]
        [DataRow("months between @2012-04-10T19:10:03 and @2012-03-10T22:05:09", 0)]
        [DataRow("years between @2012-02-29T12:34:56 and @2014-02-28T12:34:55", 1)]
        [DataRow("CalculateAgeInYearsAt(@2012-03-10T22:05:09, @2013-03-10T19:10:03)", 0)]
        [DataRow("CalculateAgeInMonthsAt(@2012-03-10T22:05:09, @2012-04-10T19:10:03)", 0)]
        public void Duration_Between_DateTimes_OnTheAnniversaryDate_TheTimeOfDayDecides(string expression, int expected)
        {
            var library = CreateCqlToolkit().MakeLibrary($"""
                library DurationTest version '1.0.0'

                define private Whole_Periods: {expression}
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);

            var result = Run(library.statements[0].expression, library);
            Assert.IsInstanceOfType(result, typeof(int?));
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Pins the single count the SDK returns today for durations that the specification defines as an uncertainty
        /// interval, so that a change to it is noticed. These counts are not the specification's answer. When a value
        /// does not specify the time of day as far as the other, "the between operator does not return a strict
        /// integer, it returns an uncertainty" (CQL Language Semantics, "Determining Difference and Duration"):
        /// <c>DateTime(2014, 2, 28)</c> may be before or after 12:34:56, so the count is <c>[1, 2]</c>. Each row gives
        /// that interval. The SDK returns the count with the times of day compared at the coarser precision, one end of
        /// the interval. Uncertainty is tracked in https://github.com/FirelyTeam/firely-cql-sdk/issues/132.
        /// </summary>
        [TestMethod]
        [DataRow("years between @2012-02-29T12:34:56 and DateTime(2014, 2, 28)", 2, 1, 2)]
        public void Duration_Between_DateTimes_WhereTheSpecificationGivesAnUncertainty_PinsTheCurrentSingleCount(
            string expression, int current, int uncertaintyLow, int uncertaintyHigh)
        {
            var library = CreateCqlToolkit().MakeLibrary($"""
                library DurationTest version '1.0.0'

                define private Whole_Periods: {expression}
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);

            var result = Run(library.statements[0].expression, library);
            Assert.IsInstanceOfType(result, typeof(int?));
            var count = (int?)result;
            Assert.AreEqual(current, count);
            Assert.IsTrue(
                count == uncertaintyLow || count == uncertaintyHigh,
                $"{count} is not an end of the uncertainty [{uncertaintyLow}, {uncertaintyHigh}].");
        }

        // https://cql.hl7.org/15-h-timeintervalcalculations.html#calculating-duration-in-years
        // Counted back from or to 29 February, the whole years are the negative of those counted forwards, with
        // 28 February as the anniversary of 29 February in a year without one (the note on Example 4.b).
        [TestMethod]
        [DataRow("years between @2012-02-29 and @2012-01-15", 0)]
        [DataRow("years between @2016-02-29 and @2012-03-01", -3)]
        [DataRow("years between @2016-02-29 and @2012-01-15", -4)]
        [DataRow("years between @2012-02-29 and @2011-01-15", -1)]
        [DataRow("years between @2015-03-01 and @2012-02-29", -3)]
        [DataRow("years between @2012-03-01 and @2012-02-29", 0)]
        [DataRow("years between @2013-01-15 and @2012-02-29", 0)]
        [DataRow("years between @2012-03-01 and @2016-02-29", 3)]
        [DataRow("years between @2016-02-29T12:34:56 and @2012-03-01T12:34:56", -3)]
        [DataRow("years between @2013-02-28T12:34:55 and @2012-02-29T12:34:56", 0)]
        [DataRow("CalculateAgeInYearsAt(@2012-02-29, @2012-01-15)", 0)]
        public void Duration_Between_BackFromOrTo29February_IsTheNegativeOfForwards(string expression, int expected)
        {
            var library = CreateCqlToolkit().MakeLibrary($"""
                library DurationTest version '1.0.0'

                define private Whole_Years: {expression}
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);

            var result = Run(library.statements[0].expression, library);
            Assert.IsInstanceOfType(result, typeof(int?));
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Duration_Between_Date_In_Hours() =>
            CreateCqlToolkit().MakeLibrary("""
                library DurationTest version '1.0.0'

                define private Duration_Between_Date_In_Hours: duration in hours between @2023-01-01 and @2024-02-01
                """, "For Date values, precision must be one of: years, months, weeks, or days.");

        [TestMethod]
        public void Duration_Between_Hours()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library DurationTest version '1.0.0'

                define private Duration_Between_Hours: duration in hours between @T12:00:00 and @T20:00:00
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DurationBetween));
            {
                var diff = (DurationBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Hour, diff.precision);

                var result = Run(diff, library);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(8, result);
            }
        }

        [TestMethod]
        public void Duration_Between_Minutes()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library DurationTest version '1.0.0'

                define private Duration_Between_Minutes: duration in minutes between @T12:00:00 and @T20:00:00
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DurationBetween));
            {
                var diff = (DurationBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Minute, diff.precision);

                var result = Run(diff, library);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(480, result);
            }
        }

        [TestMethod]
        public void Duration_Between_Seconds()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library DurationTest version '1.0.0'

                define private Duration_Between_Minutes: duration in seconds between @T12:00:00 and @T12:00:30
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DurationBetween));
            {
                var diff = (DurationBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Second, diff.precision);

                var result = Run(diff, library);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(30, result);
            }
        }

        [TestMethod]
        public void Duration_Between_Milliseconds()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library DurationTest version '1.0.0'

                define private Duration_Between_Milliseconds: duration in milliseconds between @T12:00:00.100 and @T12:00:00.300
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DurationBetween));
            {
                var diff = (DurationBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Millisecond, diff.precision);

                var result = Run(diff, library);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(200, result);
            }
        }

        [TestMethod]
        public void Duration_Between_Time_In_Days() =>
            CreateCqlToolkit().MakeLibrary("""
                library DurationTest version '1.0.0'

                define private Duration_Between_Milliseconds: duration in days between @T12:00:00.100 and @T12:00:00.300
                """, "For Time values, precision must be one of: hours, minutes, seconds, or milliseconds.");

        [TestMethod]
        public void Duration_Between_DateTimes()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library DurationTest version '1.0.0'

                define private Duration_Between_DateTimes_Years: duration in years between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
                define private Duration_Between_DateTimes_Months: duration in months between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
                define private Duration_Between_DateTimes_Weeks: duration in weeks between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
                define private Duration_Between_DateTimes_Days: duration in days between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
                define private Duration_Between_DateTimes_Hours: duration in hours between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
                define private Duration_Between_DateTimes_Minutes: duration in minutes between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
                define private Duration_Between_DateTimes_Seconds: duration in seconds between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
                define private Duration_Between_DateTimes_Milliseconds: duration in milliseconds between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
                """);
        }

        [TestMethod]
        public void Duration_Between_Null()
        {
            var library = CreateCqlToolkit().MakeLibrary("""
                library DurationTest version '1.0.0'

                define private Duration_Between_Months: duration in weeks between null and @2023-01-08
                """);
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DurationBetween));
            {
                var diff = (DurationBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Week, diff.precision);

                var result = Run(diff, library);
                Assert.IsNull(result);
            }
        }

        [TestMethod]
        public void Duration_Between_Null_Null() =>
            CreateCqlToolkit().MakeLibrary("""
                library DurationTest version '1.0.0'

                define private Duration_Between_Months: duration in weeks between null and null
                """, "Call to operator DurationBetween(Any, Any, String) is ambiguous with*");

        [TestMethod]
        public void Duration_In_Days()
        {
            var lib = CreateCqlToolkit().MakeLibrary("""
                library DurationTest version '1.0.0'

                define d: duration in days of Interval[@2023-01-01, @2023-01-31]
                """);
            var db = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<DurationBetween>();
            db.operand.Should().HaveCount(2);
            var start = db.operand[0].Should().BeOfType<Start>().Subject;
            var si = start.operand.Should().BeOfType<Interval>().Subject;
            var sdl = si.low.Should().BeOfType<Date>().Subject;
            sdl.year.Should().BeLiteralInteger(2023);
            sdl.month.Should().BeLiteralInteger(1);
            sdl.day.Should().BeLiteralInteger(1);
            var sdh = si.high.Should().BeOfType<Date>().Subject;
            sdh.year.Should().BeLiteralInteger(2023);
            sdh.month.Should().BeLiteralInteger(1);
            sdh.day.Should().BeLiteralInteger(31);

            var end = db.operand[1].Should().BeOfType<End>().Subject;
            var ei = end.operand.Should().BeOfType<Interval>().Subject;
            var edl = ei.low.Should().BeOfType<Date>().Subject;
            edl.year.Should().BeLiteralInteger(2023);
            edl.month.Should().BeLiteralInteger(1);
            edl.day.Should().BeLiteralInteger(1);
            var edh = ei.high.Should().BeOfType<Date>().Subject;
            edh.year.Should().BeLiteralInteger(2023);
            edh.month.Should().BeLiteralInteger(1);
            edh.day.Should().BeLiteralInteger(31);
        }

        [TestMethod]
        public void Duration_In_Days_MixedPrecision()
        {
            var lib = CreateCqlToolkit().MakeLibrary("""
                library DurationTest version '1.0.0'

                define d: duration in days of Interval[@2023-01-01, @2023-01-31T12:30:45]
                """);
            var db = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<DurationBetween>();
            db.operand.Should().HaveCount(2);
            var start = db.operand[0].Should().BeOfType<Start>().Subject;
            var si = start.operand.Should().BeOfType<Interval>().Subject;
            si.Should().HaveType(SystemTypes.DateTimeType.ToIntervalType());
            var end = db.operand[1].Should().BeOfType<End>().Subject;
            var ei = end.operand.Should().BeOfType<Interval>().Subject;
            ei.Should().HaveType(SystemTypes.DateTimeType.ToIntervalType());
        }

        [TestMethod]
        public void Duration_In_Days_NonInterval()
        {
            var lib = CreateCqlToolkit().MakeLibrary("""
                library DurationTest version '1.0.0'

                define d: duration in days of 1
                """, "Could not resolve call to operator DurationBetween with signature (Integer, Integer, String).");
        }

        [TestMethod]
        public void Difference_In_Years()
        {
            var lib = CreateCqlToolkit().MakeLibrary("""
                library DurationTest version '1.0.0'

                define d: difference in years of Interval[@2023-01-01, @2023-01-31]
                """);
            var db = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<DifferenceBetween>();
            db.operand.Should().HaveCount(2);
            var start = db.operand[0].Should().BeOfType<Start>().Subject;
            var si = start.operand.Should().BeOfType<Interval>().Subject;
            var sdl = si.low.Should().BeOfType<Date>().Subject;
            sdl.year.Should().BeLiteralInteger(2023);
            sdl.month.Should().BeLiteralInteger(1);
            sdl.day.Should().BeLiteralInteger(1);
            var sdh = si.high.Should().BeOfType<Date>().Subject;
            sdh.year.Should().BeLiteralInteger(2023);
            sdh.month.Should().BeLiteralInteger(1);
            sdh.day.Should().BeLiteralInteger(31);

            var end = db.operand[1].Should().BeOfType<End>().Subject;
            var ei = end.operand.Should().BeOfType<Interval>().Subject;
            var edl = ei.low.Should().BeOfType<Date>().Subject;
            edl.year.Should().BeLiteralInteger(2023);
            edl.month.Should().BeLiteralInteger(1);
            edl.day.Should().BeLiteralInteger(1);
            var edh = ei.high.Should().BeOfType<Date>().Subject;
            edh.year.Should().BeLiteralInteger(2023);
            edh.month.Should().BeLiteralInteger(1);
            edh.day.Should().BeLiteralInteger(31);
        }

    }
}
