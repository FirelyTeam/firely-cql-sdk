using FluentAssertions;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class ComponentFromTest : Base
    {
        [TestMethod]
        public void YearFromDateTime()
        {
            var lib = CreateCqlApi().MakeLibraryFromExpression("year from DateTime(2003, 10, 29, 20, 50, 33, 955)");
            var cf = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<DateTimeComponentFrom>();
            var result = Run<int?>(cf, lib);
            Assert.AreEqual(2003, result);
        }
        [TestMethod]
        public void YearFromDate()
        {
            var lib = CreateCqlApi().MakeLibraryFromExpression("year from Date(2003, 10, 29)");
            var cf = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<DateTimeComponentFrom>();
            var result = Run<int?>(cf, lib);
            Assert.AreEqual(2003, result);
        }
        [TestMethod]
        public void HourFromTime()
        {
            var lib = CreateCqlApi().MakeLibraryFromExpression("hour from Time(20, 40, 20, 123)");
            var cf = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<DateTimeComponentFrom>();
            var result = Run<int?>(cf, lib);
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void TimezoneOffsetFromDateTime()
        {
            var lib = CreateCqlApi().MakeLibraryFromExpression("timezoneoffset from DateTime(2003, 10, 29, 20, 50, 33, 955, 5.5)");
            var cf = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<TimezoneOffsetFrom>();
            var result = Run<decimal?>(cf, lib);
            Assert.AreEqual(5.5m, result);
        }
        [TestMethod]
        public void DateFromDateTime()
        {
            var lib = CreateCqlApi().MakeLibraryFromExpression("date from DateTime(2003, 10, 29, 20, 50, 33, 955, 5.5)");
            var cf = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<DateFrom>();
            var result = Run<CqlDate>(cf, lib);
            Assert.IsNotNull(result);
            Assert.AreEqual(2003, result.Value.Year);
            Assert.AreEqual(10, result.Value.Month);
            Assert.AreEqual(29, result.Value.Day);
        }
    }
}
