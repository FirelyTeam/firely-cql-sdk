using FluentAssertions;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class ComponentFromTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void YearFromDateTime()
        {
            var lib = CreateLibraryForExpression("year from DateTime(2003, 10, 29, 20, 50, 33, 955)");
            var cf = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<DateTimeComponentFrom>();
            var result = Run<int?>(cf);
            Assert.AreEqual(2003, result);
        }
        [TestMethod]
        public void YearFromDate()
        {
            var lib = CreateLibraryForExpression("year from Date(2003, 10, 29)");
            var cf = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<DateTimeComponentFrom>();
            var result = Run<int?>(cf);
            Assert.AreEqual(2003, result);
        }
        [TestMethod]
        public void HourFromTime()
        {
            var lib = CreateLibraryForExpression("hour from Time(20, 40, 20, 123)");
            var cf = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<DateTimeComponentFrom>();
            var result = Run<int?>(cf);
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void TimezoneOffsetFromDateTime()
        {
            var lib = CreateLibraryForExpression("timezoneoffset from DateTime(2003, 10, 29, 20, 50, 33, 955, 5.5)");
            var cf = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<TimezoneOffsetFrom>();
            var result = Run<decimal?>(cf);
            Assert.AreEqual(5.5m, result);
        }
        [TestMethod]
        public void DateFromDateTime()
        {
            var lib = CreateLibraryForExpression("date from DateTime(2003, 10, 29, 20, 50, 33, 955, 5.5)");
            var cf = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<DateFrom>();
            var result = Run<CqlDate>(cf);
            Assert.IsNotNull(result);
            Assert.AreEqual(2003, result.Value.Year);
            Assert.AreEqual(10, result.Value.Month);
            Assert.AreEqual(29, result.Value.Day);
        }
    }
}
