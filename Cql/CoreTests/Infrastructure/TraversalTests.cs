using Hl7.Cql.Runtime.Graphs;

namespace CoreTests.Infrastructure;


[TestClass]
public class TraversalTests
{
    private static TraversalCallbacks<int> PreventRevisits = TraversalCallbacks<int>.CreatePreventRevisits();

    private static TraversalCallbacks<int> PreventVisit4 = new(
        AllowEnter: t => t.Next != 4 // Also prevents continuing to its children
    );

    [TestClass]
    public class Tree
    {
        private static IEnumerable<int> GetNext(int node) =>
            node switch
            {
                /*
                 *        1
                 *       /|\
                 *     2  3  4
                 *     |    / \
                 *     5   6   7
                 *             |
                 *             8
                 */
                1 => [2, 3, 4],
                2 => [5],
                4 => [6, 7],
                7 => [8],
                _ => [],
            };

        [TestMethod]
        public void PreOrder_VisitsNodesInPreOrder()
        {
            var result = string.Join(", ", Traversal.PreOrder(1, GetNext));
            Assert.AreEqual("1, 2, 5, 3, 4, 6, 7, 8", result);
        }

        [TestMethod]
        public void PreOrderPreventVisit4_RespectsAllowEnterCallback()
        {
            var result = string.Join(", ", Traversal.PreOrder(1, GetNext, PreventVisit4));
            Assert.AreEqual("1, 2, 5, 3", result);
        }

        [TestMethod]
        public void TopologicalSort_VisitsNodesTopologicallySorted()
        {
            var result = string.Join(", ", Enumerable.Range(1, 8).TopologicalSort(GetNext));
            Assert.AreEqual("5, 2, 3, 6, 8, 7, 4, 1", result);
        }
    }

    [TestClass]
    public class DependencyGraph
    {
        private static IEnumerable<int> GetNext(int node) =>
            node switch
            {
                /*
                 *        1
                 *       /|\
                 *     2  3  4
                 *     |   X |
                 *     |  / \|
                 *     5  6  7
                 *       \   |
                 *         \ |
                 *           8
                 */
                1 => [2, 3, 4],
                2 => [5],
                3 => [7],
                4 => [6, 7],
                5 => [8],
                7 => [8],
                _ => [],
            };

        [TestMethod]
        public void PreOrder_VisitsNodesInPreOrder()
        {
            var result = string.Join(", ", Traversal.PreOrder(1, GetNext));
            Assert.AreEqual("1, 2, 5, 8, 3, 7, 8, 4, 6, 7, 8", result);
        }

        [TestMethod]
        public void PreOrderPreventRevisits_RespectsAllowEnterCallback()
        {
            var result = string.Join(", ", Traversal.PreOrder(1, GetNext, PreventRevisits));
            Assert.AreEqual("1, 2, 5, 8, 3, 7, 4, 6", result);
        }

        [TestMethod]
        public void PreOrderPreventVisit4_RespectsAllowEnterCallback()
        {
            var result = string.Join(", ", Traversal.PreOrder(1, GetNext, PreventVisit4));
            Assert.AreEqual("1, 2, 5, 8, 3, 7, 8", result);
        }

        [TestMethod]
        public void TopologicalSort_VisitsNodesTopologicallySorted()
        {
            var result = string.Join(", ", Enumerable.Range(1, 8).TopologicalSort(GetNext));
            Assert.AreEqual("8, 5, 2, 7, 3, 6, 4, 1", result);
        }
    }

}
