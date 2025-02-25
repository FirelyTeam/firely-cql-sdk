using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class DistinctTest : Base
    {
        [TestMethod]
        public void DistinctABCABC()
        {
            var library = CreateCqlToolkit().MakeLibraryFromExpression("distinct { 'a', 'b', 'c', 'a', 'b', 'c'}");
            var distinct = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Distinct>();
            var result = Run<IEnumerable<string>?>(distinct, library)!.ToArray();
            result.Length.Should().Be(3);
            result.Contains("a").Should().BeTrue();
            result.Contains("b").Should().BeTrue();
            result.Contains("c").Should().BeTrue();

        }
    }
}
