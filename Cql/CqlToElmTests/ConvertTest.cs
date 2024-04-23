using FluentAssertions;
using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class ConvertTest : Base
    {

        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize(options =>
        {
            options.EnableListPromotion = true;
            options.EnableListDemotion = true;
            options.EnableIntervalPromotion = true;
            options.EnableIntervalDemotion = true;
        });
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void Convert_Integer_to_String()
        {
            var library = CreateLibraryForExpression("convert 5 to String");
            library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<ToString>();
        }

        [TestMethod]
        public void Convert_String_to_DateTime()
        {
            var library = CreateLibraryForExpression("ToDateTime('2014-01-01T12:05:05.955-01:15')");
            var toDateTime = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<ToDateTime>();
            var result = Run(toDateTime);
            var dt = result.Should().BeOfType<CqlDateTime>().Subject;
            dt.Value.OffsetHour.Should().Be(-1);
            dt.Value.OffsetMinute.Should().Be(-15);
            dt.Value.DateTimeOffset.Offset.Should().Be(TimeSpan.FromMinutes(-75));
        }
    }
}