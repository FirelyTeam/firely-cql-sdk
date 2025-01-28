using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class IndexTest : Base
    {
        [TestMethod]
        public void LastIndexOf()
        {
            var lib = CreateFluentCqlToolkit().MakeLibraryFromExpression("LastPositionOf('hi', 'Ohio is the place to be!')");
            var lpo = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<LastPositionOf>();
            var result = Run<int?>(lpo, lib);
            result.Should().Be(1);
        }

    }
}
