using FluentAssertions;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class LengthTest : Base
    {
        [TestMethod]
        public void LengthNullString()
        {
            var library = CreateCqlApi().MakeLibraryFromExpression("Length(null as String)");
            var length = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Length>();
            var result = Run<int?>(length, library);
            result.Should().BeNull();
        }
    }
}
