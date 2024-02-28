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
    public class QueryTest: Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        public void StringLengths()
        {
            var lib = createLibraryForExpression("from ({'hello', 'world'}) str return Length(str)");
            var query = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Query>();
            query.Should().HaveType(SystemTypes.IntegerType.ToListType());
        }


        [TestMethod]
        public void SortAsc()
        {
            var lib = createLibraryForExpression("({4, 5, 1, 6, 2, 1}) sL sort asc");
            var query = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Query>();
            query.Should().HaveType(SystemTypes.IntegerType.ToListType());

        }

    }
}
