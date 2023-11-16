using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreTests.Elm
{
    [TestClass]
    public class TestToString
    {
        [TestMethod]
        public void TupleTypeToString()
        {
            TestEquality.FullTT.ToString().Should().Be("Tuple { typeParam A, typeParam2 T, list List<B>, interval Interval<C>, interval2 Interval<C>, choice Choice<Integer, D, E>, named String }");

            var emptyExpected = "Tuple { typeParam Null, list List<>, interval Interval<>, interval2 Interval<>, choice Choice<>, named null, emptytt Tuple {  }, justname Null, null Null }";
            TestEquality.EmptyTT.ToString().Should().Be(emptyExpected);
        }
    }
}
