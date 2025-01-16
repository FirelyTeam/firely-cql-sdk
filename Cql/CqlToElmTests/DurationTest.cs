using CqlSdkPrototype.Cql;
using FluentAssertions;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class DurationTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void Duration_Between_Days()
        {
            var library = CqlApi.MakeLibrary(@"
                library DurationTest version '1.0.0'

                define private Duration_Between_Days: duration in days between @2023-01-01 and @2023-01-31
            ", new string[0]);
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
            var library = CqlApi.MakeLibrary(@"
                library DurationTest version '1.0.0'

                define private Duration_Between_Days: days between @2023-01-01 and @2023-01-31
            ", new string[0]);
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
        public void Duration_Between_Months()
        {
            var library = CqlApi.MakeLibrary(@"
                library DurationTest version '1.0.0'

                define private Duration_Between_Months: duration in months between @2023-01-01 and @2023-02-01
            ", new string[0]);
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
            var library = CqlApi.MakeLibrary(@"
                library DurationTest version '1.0.0'

                define private Duration_Between_Months: duration in weeks between @2023-01-01 and @2023-01-08
            ", new string[0]);
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
            var library = CqlApi.MakeLibrary(@"
                library DurationTest version '1.0.0'

                define private Duration_Between_Months: duration in years between @2023-01-01 and @2024-02-01
            ", new string[0]);
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

        [TestMethod]
        public void Duration_Between_Date_In_Hours() =>
            TestExtensions.MakeLibrary(CqlApi, @"
                library DurationTest version '1.0.0'

                define private Duration_Between_Date_In_Hours: duration in hours between @2023-01-01 and @2024-02-01
            ", "For Date values, precision must be one of: years, months, weeks, or days.");

        [TestMethod]
        public void Duration_Between_Hours()
        {
            var library = CqlApi.MakeLibrary(@"
                library DurationTest version '1.0.0'

                define private Duration_Between_Hours: duration in hours between @T12:00:00 and @T20:00:00
            ", new string[0]);
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
            var library = CqlApi.MakeLibrary(@"
                library DurationTest version '1.0.0'

                define private Duration_Between_Minutes: duration in minutes between @T12:00:00 and @T20:00:00
            ", new string[0]);
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
            var library = CqlApi.MakeLibrary(@"
                library DurationTest version '1.0.0'

                define private Duration_Between_Minutes: duration in seconds between @T12:00:00 and @T12:00:30
            ", new string[0]);
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
            var library = CqlApi.MakeLibrary(@"
                library DurationTest version '1.0.0'

                define private Duration_Between_Milliseconds: duration in milliseconds between @T12:00:00.100 and @T12:00:00.300
            ", new string[0]);
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
            TestExtensions.MakeLibrary(CqlApi, @"
                library DurationTest version '1.0.0'

                define private Duration_Between_Milliseconds: duration in days between @T12:00:00.100 and @T12:00:00.300
            ", "For Time values, precision must be one of: hours, minutes, seconds, or milliseconds.");

        [TestMethod]
        public void Duration_Between_DateTimes()
        {
            var library = CqlApi.MakeLibrary(@"
                library DurationTest version '1.0.0'

                define private Duration_Between_DateTimes_Years: duration in years between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
                define private Duration_Between_DateTimes_Months: duration in months between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
                define private Duration_Between_DateTimes_Weeks: duration in weeks between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
                define private Duration_Between_DateTimes_Days: duration in days between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
                define private Duration_Between_DateTimes_Hours: duration in hours between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
                define private Duration_Between_DateTimes_Minutes: duration in minutes between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
                define private Duration_Between_DateTimes_Seconds: duration in seconds between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
                define private Duration_Between_DateTimes_Milliseconds: duration in milliseconds between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
            ", new string[0]);
        }

        [TestMethod]
        public void Duration_Between_Null()
        {
            var library = CqlApi.MakeLibrary(@"
                library DurationTest version '1.0.0'

                define private Duration_Between_Months: duration in weeks between null and @2023-01-08
            ", new string[0]);
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
            TestExtensions.MakeLibrary(CqlApi, @"
                library DurationTest version '1.0.0'

                define private Duration_Between_Months: duration in weeks between null and null
            ", "Call to operator DurationBetween(Any, Any, String) is ambiguous with*");

        [TestMethod]
        public void Duration_In_Days()
        {
            var lib = CqlApi.MakeLibrary(@"
                library DurationTest version '1.0.0'

                define d: duration in days of Interval[@2023-01-01, @2023-01-31]
            ", new string[0]);
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
            var lib = CqlApi.MakeLibrary(@"
                library DurationTest version '1.0.0'

                define d: duration in days of Interval[@2023-01-01, @2023-01-31T12:30:45]
            ", new string[0]);
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
            var lib = TestExtensions.MakeLibrary(CqlApi, @"
                library DurationTest version '1.0.0'

                define d: duration in days of 1
            ", "Could not resolve call to operator DurationBetween with signature (Integer, Integer, String).");
        }

        [TestMethod]
        public void Difference_In_Years()
        {
            var lib = CqlApi.MakeLibrary(@"
                library DurationTest version '1.0.0'

                define d: difference in years of Interval[@2023-01-01, @2023-01-31]
            ", new string[0]);
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
