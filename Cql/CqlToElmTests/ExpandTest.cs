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
    public class ExpandTest: Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
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
        }

    }
}
