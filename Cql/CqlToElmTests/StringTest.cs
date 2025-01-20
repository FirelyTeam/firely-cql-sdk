using FluentAssertions;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class StringTest : Base
    {
        [TestMethod]
        public void ReplaceMatchesSpaces()
        {
            var library = CreateCqlApi().MakeLibraryFromExpression("ReplaceMatches('All that glitters is not gold', '\\\\s', '\\$')");
            var replace = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<ReplaceMatches>();
            var result = Run<string?>(replace, library);
            result.Should().Be("All$that$glitters$is$not$gold");
        }
    }
}
