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
            var ts = TestEquality.FullTT.ToString();
            ts.Should().Be("Tuple { list List<B>, interval Interval<C>, interval2 Interval<C>, choice Choice<Integer, D, E>, named String }");

            var empty = TestEquality.EmptyTT.ToString();
            var emptyExpected = "Tuple { list List<>, interval Interval<>, interval2 Interval<>, choice Choice<>, named null, emptytt Tuple {  }, justname Null, null Null }";
            empty.Should().Be(emptyExpected);
        }
    }
}
