using FluentAssertions;
using Hl7.Cql.Elm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hl7.Cql.CqlToElm.Test
{
    [TestClass]
    public class BetweenTest : Base
    {
        [ClassInitialize]
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Initialize(TestContext context) => ClassInitialize();
#pragma warning restore IDE0060 // Remove unused parameter

        [TestMethod]
        public void BetweenIntTrue()
        {
            var lib = CreateLibraryForExpression("4 between 2 and 6");
            var and = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<And>();
            and.operand.Should().HaveCount(2);
            var ge = and.operand[0].Should().BeOfType<GreaterOrEqual>().Subject;
            var le = and.operand[1].Should().BeOfType<LessOrEqual>().Subject;
            var result = Run<bool?>(and);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ProperBetweenIntFalse()
        {
            var lib = CreateLibraryForExpression("2 properly between 2 and 6");
            var and = lib.Should().BeACorrectlyInitializedLibraryWithStatementOfType<And>();
            and.operand.Should().HaveCount(2);
            var ge = and.operand[0].Should().BeOfType<Greater>().Subject;
            var le = and.operand[1].Should().BeOfType<Less>().Subject;
            var result = Run<bool?>(and);
            Assert.IsFalse(result);
        }

    }
}

