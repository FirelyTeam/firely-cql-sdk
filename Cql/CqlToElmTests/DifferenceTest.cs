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
    public class DifferenceTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void Difference_Between_Days()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library DifferenceTest version '1.0.0'

                define private Difference_Between_Days: difference in days between @2023-01-01 and @2023-01-31
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DifferenceBetween));
            {
                var diff = (DifferenceBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Day, diff.precision);

                var result = Run(diff);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(30, result);
            }
        }
        [TestMethod]
        public void Difference_Between_Months()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library DifferenceTest version '1.0.0'

                define private Difference_Between_Months: difference in months between @2023-01-01 and @2023-02-01
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DifferenceBetween));
            {
                var diff = (DifferenceBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Month, diff.precision);

                var result = Run(diff);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(1, result);
            }
        }
        [TestMethod]
        public void Difference_Between_Weeks()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library DifferenceTest version '1.0.0'

                define private Difference_Between_Months: difference in weeks between @2023-01-01 and @2023-01-08
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DifferenceBetween));
            {
                var diff = (DifferenceBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Week, diff.precision);

                var result = Run(diff);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(1, result);
            }
        }


        [TestMethod]
        public void Difference_Between_Years()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library DifferenceTest version '1.0.0'

                define private Difference_Between_Months: difference in years between @2023-01-01 and @2024-02-01
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DifferenceBetween));
            {
                var diff = (DifferenceBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Year, diff.precision);

                var result = Run(diff);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(1, result);
            }
        }

        [TestMethod]
        public void Difference_Between_Date_In_Hours() =>
            Assert.ThrowsException<AggregateException>(() => DefaultConverter.ConvertLibrary(@"
                library DifferenceTest version '1.0.0'

                define private Difference_Between_Date_In_Hours: difference in hours between @2023-01-01 and @2024-02-01
            "));

        [TestMethod]
        public void Difference_Between_Hours()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library DifferenceTest version '1.0.0'

                define private Difference_Between_Hours: difference in hours between @T12:00:00 and @T20:00:00
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DifferenceBetween));
            {
                var diff = (DifferenceBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Hour, diff.precision);

                var result = Run(diff);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(8, result);
            }
        }

        [TestMethod]
        public void Difference_Between_Minutes()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library DifferenceTest version '1.0.0'

                define private Difference_Between_Minutes: difference in minutes between @T12:00:00 and @T20:00:00
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DifferenceBetween));
            {
                var diff = (DifferenceBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Minute, diff.precision);

                var result = Run(diff);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(480, result);
            }
        }

        [TestMethod]
        public void Difference_Between_Seconds()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library DifferenceTest version '1.0.0'

                define private Difference_Between_Minutes: difference in seconds between @T12:00:00 and @T12:00:30
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DifferenceBetween));
            {
                var diff = (DifferenceBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Second, diff.precision);

                var result = Run(diff);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(30, result);
            }
        }

        [TestMethod]
        public void Difference_Between_Milliseconds()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library DifferenceTest version '1.0.0'

                define private Difference_Between_Milliseconds: difference in milliseconds between @T12:00:00.100 and @T12:00:00.300
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DifferenceBetween));
            {
                var diff = (DifferenceBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Millisecond, diff.precision);

                var result = Run(diff);
                Assert.IsInstanceOfType(result, typeof(int?));
                Assert.AreEqual(200, result);
            }
        }

        [TestMethod]
        public void Difference_Between_Time_In_Days() =>
            Assert.ThrowsException<AggregateException>(() => DefaultConverter.ConvertLibrary(@"
                library DifferenceTest version '1.0.0'

                define private Difference_Between_Milliseconds: difference in days between @T12:00:00.100 and @T12:00:00.300
            "));

        [TestMethod]
        public void Difference_Between_DateTimes()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library DifferenceTest version '1.0.0'

                define private Difference_Between_DateTimes_Years: difference in years between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
                define private Difference_Between_DateTimes_Months: difference in months between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
                define private Difference_Between_DateTimes_Weeks: difference in weeks between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
                define private Difference_Between_DateTimes_Days: difference in days between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
                define private Difference_Between_DateTimes_Hours: difference in hours between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
                define private Difference_Between_DateTimes_Minutes: difference in minutes between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
                define private Difference_Between_DateTimes_Seconds: difference in seconds between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
                define private Difference_Between_DateTimes_Milliseconds: difference in milliseconds between @2023-01-01T12:00:00.100 and @2024-01-01T12:00:00.100
            ");
        }

        [TestMethod]
        public void Difference_Between_Null()
        {
            var library = DefaultConverter.ConvertLibrary(@"
                library DifferenceTest version '1.0.0'

                define private Difference_Between_Months: difference in weeks between null and @2023-01-08
            ");
            Assert.IsNotNull(library.statements);
            Assert.AreEqual(1, library.statements.Length);
            Assert.IsNotNull(library.statements[0].expression.localId);
            Assert.IsNotNull(library.statements[0].expression.locator);
            Assert.IsInstanceOfType(library.statements[0].expression, typeof(DifferenceBetween));
            {
                var diff = (DifferenceBetween)library.statements[0].expression;
                Assert.AreEqual(DateTimePrecision.Week, diff.precision);

                var result = Run(diff);
                Assert.IsNull(result);
            }
        }

        [TestMethod]
        public void Difference_Between_Null_Null() =>
            Assert.ThrowsException<InvalidOperationException>(() => DefaultConverter.ConvertLibrary(@"
                library DifferenceTest version '1.0.0'

                define private Difference_Between_Months: difference in weeks between null and null
            "));

    }
}
