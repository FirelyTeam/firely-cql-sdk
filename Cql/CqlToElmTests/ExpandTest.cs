using FluentAssertions;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class ExpandCollapseTest: Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize(co =>
        {
            co.AllowNullIntervals = true;
        });
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void ExpandPerDay()
        {
            var lib = CreateLibraryForExpression("expand { Interval[@2018-01-01, @2018-01-04] } per day");
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
            var lib = CreateLibraryForExpression("expand { Interval[10, 10] } per 0.1");
            var expand = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Expand>();
            expand.operand.Length.Should().Be(2);
            expand.operand[0].Should().HaveType(SystemTypes.DecimalType.ToIntervalType().ToListType());
            var result = Run(expand);
            // not implemented correctly
        }

        [TestMethod]
        public void Collapse_List_Null_Intervals()
        {
            var lib = CreateLibraryForExpression("collapse { Interval(null, null) }");
            var collapse = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Collapse>();
        }

    }
}
