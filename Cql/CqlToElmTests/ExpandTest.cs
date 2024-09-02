using FluentAssertions;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    internal class ExpandCollapseTest: Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize(co =>
        {
            co.AllowNullIntervals = true;
        });
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void ExpandUnitUnspecified()
        {
            var lib = CreateLibraryForExpression("expand { Interval[1, 4], Interval[4, 8], Interval[7, 9] }");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Expand>();
        }

        [TestMethod]
        public void ExpandPerDay()
        {
            var lib = CreateLibraryForExpression("expand { Interval[@2018-01-01, @2018-01-04] } per day");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Expand>();
        }

        [TestMethod]
        public void ExpandPer2Days()
        {
            var lib = CreateLibraryForExpression("expand { Interval[@2018-01-01, @2018-01-04] } per 2 days");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Expand>();
        }

        [TestMethod]
        public void ExpandIntervalPer2()
        {
            var lib = CreateLibraryForExpression("expand { Interval [1, 10] } per 2");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Expand>();
        }


        [TestMethod]
        public void Expand_List_Interval()
        {
            var lib = CreateLibraryForExpression("expand { Interval[10.0, 10.0] } per 0.1");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Expand>();
            expand.operand.Length.Should().Be(2);
            expand.operand[0].Should().HaveType(SystemTypes.DecimalType.ToIntervalType().ToListType());
            var result = Run(expand);
            // not implemented correctly
        }

        [TestMethod]
        public void CollapseUnitUnspecified()
        {
            var lib = CreateLibraryForExpression("collapse { Interval[1, 4], Interval[4, 8], Interval[7, 9] }");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Collapse>();
        }


        [TestMethod]
        public void CollapseIntervalPerDay()
        {
            var lib = CreateLibraryForExpression("collapse { Interval [1, 10] } per day");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Collapse>();
        }


        [TestMethod]
        public void CollapseIntervalPer2Day()
        {
            var lib = CreateLibraryForExpression("collapse { Interval [1, 10] } per 2 day");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Collapse>();
        }

        [TestMethod]
        public void DateTimeCollapse()
        {
            var lib = CreateLibraryForExpression("collapse { Interval[DateTime(2012, 1, 1), DateTime(2012, 1, 15)], Interval[DateTime(2012, 1, 10), DateTime(2012, 1, 25)], Interval[DateTime(2012, 5, 10), DateTime(2012, 5, 25)], Interval[DateTime(2012, 5, 20), DateTime(2012, 5, 30)] }");
            var collapse = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Collapse>();
            // expected {Interval [ @2012-01-01T, @2012-01-25T ], Interval [ @2012-05-10T, @2012-05-30T ]}
            var result = Run(collapse);
        }
    }
}
