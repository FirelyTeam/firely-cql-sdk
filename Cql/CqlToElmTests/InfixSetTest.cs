using FluentAssertions;
using Hl7.Cql.Elm;
using Hl7.Cql.Primitives;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class InfixSetTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void Interval_Except()
        {
            var library = CreateLibraryForExpression("Interval[1, 10] except Interval[4, 10]");
            var except = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Except>();
            var result = Run<CqlInterval<int?>>(except);
            result.Should().NotBeNull();
            result!.low.Should().Be(1);
            result.high.Should().Be(3);
            result.lowClosed.Should().BeTrue();
            result.highClosed.Should().BeTrue();
        }

        [TestMethod]
        public void Interval_Union()
        {
            var library = CreateLibraryForExpression("Interval[1, 10] union Interval[4, 15]");
            var union = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Union>();
            var result = Run<CqlInterval<int?>>(union);
            result.Should().NotBeNull();
            result!.low.Should().Be(1);
            result.high.Should().Be(15);
            result.lowClosed.Should().BeTrue();
            result.highClosed.Should().BeTrue();
        }
        [TestMethod]
        public void Interval_Union_Pipe_Operator()
        {
            var library = CreateLibraryForExpression("Interval[1, 10] | Interval[4, 15]");
            var union = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Union>();
            var result = Run<CqlInterval<int?>>(union);
            result.Should().NotBeNull();
            result!.low.Should().Be(1);
            result.high.Should().Be(15);
            result.lowClosed.Should().BeTrue();
            result.highClosed.Should().BeTrue();
        }

        [TestMethod]
        public void Interval_Intersect_Operator()
        {
            var library = CreateLibraryForExpression("Interval[1, 5] intersect Interval[3, 7]");
            var intersect = library.Should().BeACorrectlyInitializedLibraryWithStatementOfType<Intersect>();
            var result = Run<CqlInterval<int?>>(intersect);
            result.Should().NotBeNull();
            result!.low.Should().Be(3);
            result.high.Should().Be(5);
            result.lowClosed.Should().BeTrue();
            result.highClosed.Should().BeTrue();
        }
    }
}
