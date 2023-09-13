using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var library = DefaultConverter.ConvertLibrary(@"
                library DurationTest version '1.0.0'

                define private Duration_Between_Days: duration in days between @2023-01-01 and @2023-01-31
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DurationBetween));
            {
                var diff = (DurationBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Day, diff.precision);

                var result = Run(diff);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(30, result);
            }
        }


        [TestMethod]
        public void Duration_Between_Days_Shortform()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library DurationTest version '1.0.0'

                define private Duration_Between_Days: days between @2023-01-01 and @2023-01-31
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DurationBetween));
            {
                var diff = (DurationBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Day, diff.precision);

                var result = Run(diff);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(30, result);
            }
        }

        [TestMethod]
        public void Duration_Between_Months()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library DurationTest version '1.0.0'

                define private Duration_Between_Months: duration in months between @2023-01-01 and @2023-02-01
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DurationBetween));
            {
                var diff = (DurationBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Month, diff.precision);

                var result = Run(diff);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(1, result);
            }
        }
        [TestMethod]
        public void Duration_Between_Weeks()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library DurationTest version '1.0.0'

                define private Duration_Between_Months: duration in weeks between @2023-01-01 and @2023-01-08
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DurationBetween));
            {
                var diff = (DurationBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Week, diff.precision);

                var result = Run(diff);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(1, result);
            }
        }


        [TestMethod]
        public void Duration_Between_Years()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library DurationTest version '1.0.0'

                define private Duration_Between_Months: duration in years between @2023-01-01 and @2024-02-01
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DurationBetween));
            {
                var diff = (DurationBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Year, diff.precision);

                var result = Run(diff);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(1, result);
            }
        }

        [TestMethod]
        public void Duration_Between_Date_In_Hours() =>
            Assert.ThrowsException<AggregateException>(() => DefaultConverter.ConvertLibrary(@"
                library DurationTest version '1.0.0'

                define private Duration_Between_Date_In_Hours: duration in hours between @2023-01-01 and @2024-02-01
            "));

        [TestMethod]
        public void Duration_Between_Hours()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library DurationTest version '1.0.0'

                define private Duration_Between_Hours: duration in hours between @T12:00:00 and @T20:00:00
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DurationBetween));
            {
                var diff = (DurationBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Hour, diff.precision);

                var result = Run(diff);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(8, result);
            }
        }

        [TestMethod]
        public void Duration_Between_Minutes()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library DurationTest version '1.0.0'

                define private Duration_Between_Minutes: duration in minutes between @T12:00:00 and @T20:00:00
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DurationBetween));
            {
                var diff = (DurationBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Minute, diff.precision);

                var result = Run(diff);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(480, result);
            }
        }

        [TestMethod]
        public void Duration_Between_Seconds()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library DurationTest version '1.0.0'

                define private Duration_Between_Minutes: duration in seconds between @T12:00:00 and @T12:00:30
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DurationBetween));
            {
                var diff = (DurationBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Second, diff.precision);

                var result = Run(diff);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(30, result);
            }
        }

        [TestMethod]
        public void Duration_Between_Milliseconds()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library DurationTest version '1.0.0'

                define private Duration_Between_Milliseconds: duration in milliseconds between @T12:00:00.100 and @T12:00:00.300
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DurationBetween));
            {
                var diff = (DurationBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Millisecond, diff.precision);

                var result = Run(diff);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(200, result);
            }
        }

        [TestMethod]
        public void Duration_Between_Time_In_Days() =>
            Assert.ThrowsException<AggregateException>(() => DefaultConverter.ConvertLibrary(@"
                library DurationTest version '1.0.0'

                define private Duration_Between_Milliseconds: duration in days between @T12:00:00.100 and @T12:00:00.300
            "));

        [TestMethod]
        public void Duration_Between_DateTimes()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library DurationTest version '1.0.0'

                define private Duration_Between_DateTimes_Years: duration in years between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
                define private Duration_Between_DateTimes_Months: duration in months between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
                define private Duration_Between_DateTimes_Weeks: duration in weeks between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
                define private Duration_Between_DateTimes_Days: duration in days between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
                define private Duration_Between_DateTimes_Hours: duration in hours between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
                define private Duration_Between_DateTimes_Minutes: duration in minutes between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
                define private Duration_Between_DateTimes_Seconds: duration in seconds between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
                define private Duration_Between_DateTimes_Milliseconds: duration in milliseconds between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
            ");
        }

        [TestMethod]
        public void Duration_Between_Null()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library DurationTest version '1.0.0'

                define private Duration_Between_Months: duration in weeks between null and @2023-01-08
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DurationBetween));
            {
                var diff = (DurationBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Week, diff.precision);

                var result = Run(diff);
                Assert.IsNull(result);
            }
        }

        [TestMethod]
        public void Duration_Between_Null_Null() =>
            Assert.ThrowsException<AggregateException>(() => DefaultConverter.ConvertLibrary(@"
                library DurationTest version '1.0.0'

                define private Duration_Between_Months: duration in weeks between null and null
            "));

    }
}
