using FluentAssertions;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class IndexTest : Base
    {
        [TestMethod]
        public void LastIndexOf()
        {
            var lib = CreateCqlApi().MakeLibraryFromExpression("LastPositionOf('hi', 'Ohio is the place to be!')");
            var lpo = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<LastPositionOf>();
            var result = Run<int?>(lpo, lib);
            result.Should().Be(1);
        }

    }
}
