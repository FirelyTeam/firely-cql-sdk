using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;

namespace Hl7.Cql.Logging
{
    public class ExpressionLog
    {
        /// <summary>
        /// The definition name (for top level expressions) as defined in the CQL source
        /// </summary>
        public string? name { get; set; }

        /// <summary>
        /// The ELM local ID, if available.
        /// </summary>
        public int? localId { get; set; }

        public Locator? locator { get; set; }

        /// <summary>
        /// The CQL source code
        /// </summary>
        public string? cql { get; set; }

        public JsonNode? value { get; set; }

        public IList<ExpressionLog>? children { get; set; }

        private ExpressionLog? parent { get; set; }

        public IList<ExpressionLog>? callStack { get; set; }

        public override bool Equals(object obj)
        {
            if(obj is ExpressionLog otherLog)
            {
                if(this.locator != null && otherLog.locator != null 
                    && this.locator.CompareTo(otherLog.locator) == RangeComparisonResult.ExactlyEqual)
                {
                    if(this.callStack == null && otherLog.callStack == null)
                    {
                        return true;
                    }
                    if(this.callStack != null && otherLog.callStack != null)
                    {
                        return this.callStack.SequenceEqual(otherLog.callStack);
                    }
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static ExpressionLog BuildHierarchies(IEnumerable<ExpressionLog> sourceLogs)
        {
            ExpressionLog root = new ExpressionLog();
            root.locator = new Locator(0, 0, Int32.MaxValue, Int32.MaxValue); // use Int32.MaxValue
            root.name = "root";
            ExpressionLog? currNode = root;

            var allNodes = new List<ExpressionLog>();
            allNodes.Add(root);

            foreach(var log in sourceLogs)
            {
                AddLogToTree(root, log, allNodes);
            }
            if (root == null) return new ExpressionLog();

            SortLogChildren(root);
            return root;
        }

        private static void SortLogChildren(ExpressionLog currNode)
        {
            if (currNode.children != null)
            {
                currNode.children = currNode.children.OrderBy(c => c.locator!.StartLine).ToList();
                foreach (var child in currNode.children)
                {
                    SortLogChildren(child);
                }
            }
        }

        private static bool AddLogToTree(ExpressionLog currNode, ExpressionLog logToAdd, IList<ExpressionLog> nodes)
        {
            if (currNode.locator == null) return false;
            if (logToAdd.locator == null) return false;

           
            // Check for Redundency 
            foreach (var child in nodes)
            {
                if (child.locator!.CompareTo(logToAdd.locator!) == RangeComparisonResult.ExactlyEqual)
                    return false;
            }

            var compareResult = currNode.locator!.CompareTo(logToAdd.locator!);

            if (compareResult == RangeComparisonResult.Contains)
            {
                return HandleContains(currNode, logToAdd, nodes);
            }
            else if (compareResult == RangeComparisonResult.ContainedBy)
            {
                return HandleContainedBy(currNode, logToAdd, nodes);
            }


            if (currNode.parent == null) // We are the root, just add to children
            {
                if (currNode.children == null) 
                    currNode.children = new List<ExpressionLog>();

                logToAdd.parent = currNode;
                currNode.children.Add(logToAdd);
            }
            else // Add to current node's parent. the logToAdd is in the same depth as currNode
            {
                if (currNode.parent.children == null) 
                    currNode.parent.children = new List<ExpressionLog>();

                logToAdd.parent = currNode.parent;
                currNode.parent.children.Add(logToAdd);
            }
            nodes.Add(logToAdd);
            return true;


        }

        private static bool HandleContains(ExpressionLog currNode, ExpressionLog logToAdd, IList<ExpressionLog> nodes)
        {
            if (currNode.children == null)
            {
                currNode.children = new List<ExpressionLog>();
                currNode.children.Add(logToAdd);
                logToAdd.parent = currNode;
                nodes.Add(logToAdd);
                return true;
            }

            var newChildren = new List<ExpressionLog>();
            var containedByOtherNode = false;
            foreach (var child in currNode.children)
            {
                var comparisonWithLogToAdd = logToAdd.locator!.CompareTo(child.locator!);
                if (comparisonWithLogToAdd == RangeComparisonResult.Contains)
                {
                    if (logToAdd.children == null) 
                        logToAdd.children = new List<ExpressionLog>();

                    child.parent = logToAdd;
                    logToAdd.children.Add(child);
                }
                else
                {
                    if (comparisonWithLogToAdd == RangeComparisonResult.ContainedBy)
                    {
                        AddLogToTree(child, logToAdd, nodes);
                        return true;
                    }
                    newChildren.Add(child);
                }
            }

            currNode.children = newChildren;
            if (!containedByOtherNode)
            {
                currNode.children.Add(logToAdd);
                nodes.Add(logToAdd);
                return true;
            }

            foreach (var child in currNode.children)
            {
                if (AddLogToTree(child, logToAdd, nodes))
                    return true;
            }
            return false;
        }

        private static bool HandleContainedBy(ExpressionLog currNode, ExpressionLog logToAdd, IList<ExpressionLog> nodes)
        {
            if (currNode.parent == null)
            {
                throw new NotImplementedException("Root node should not be contained by another node");
            }

            if (logToAdd.children == null) logToAdd.children = new List<ExpressionLog>();
            var currNodeParent = currNode.parent;

            currNode.parent = logToAdd;
            logToAdd.children.Add(currNode);
            logToAdd.parent = currNodeParent;

            currNodeParent.children!.Add(logToAdd);
            if (currNodeParent.children!.Remove(currNode) == false)
                throw new Exception("Cannot remove old node");

            nodes.Add(logToAdd);

            return true;
        }

    }
}
