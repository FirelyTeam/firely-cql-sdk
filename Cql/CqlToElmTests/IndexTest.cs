using FluentAssertions;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class IndexTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void LastIndexOf()
        {
            var lib = CreateLibraryForExpression("LastPositionOf('hi', 'Ohio is the place to be!')");
            var lpo = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<LastPositionOf>();
            var result = Run<int?>(lpo, lib);
            result.Should().Be(1);
        }

    }
}
