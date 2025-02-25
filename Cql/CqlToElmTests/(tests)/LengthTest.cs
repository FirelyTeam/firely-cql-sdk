using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class LengthTest : Base
    {
        [TestMethod]
        public void LengthNullString()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("Length(null as String)");
            var length = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Length>();
            var result = Run<int?>(length, library);
            result.Should().BeNull();
        }
    }
}
