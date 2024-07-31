/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Hl7.Cql.Elm
{
    /// <summary>
    /// Construct a walker.
    /// </summary>
    /// <param name="visitor">A function that is passed the nodes in the tree. It should return <c>false</c> if this function
    /// handles the children of the nodes by itself, or <c>true</c> if the walker should visit the children automatically.</param>
    /// <param name="filter">A function that controls whether the walker visits a child property or not.</param>
    internal class ElmTreeWalker(Func<object, bool> visitor,
                               Func<Type, bool>? filter = null) : BaseElmTreeWalker
    {
        public void Start(object root) => base.StartInternal(root);

        protected override bool IsRelevant(Type nodeType) => filter?.Invoke(nodeType) ?? base.IsRelevant(nodeType);

        protected override bool Process(object node) => visitor(node);
    }

    /// <summary>
    /// A walker that does a depth-first traversal of a tree and calls a visitor function for each node.
    /// </summary>
    internal abstract class BaseElmTreeWalker
    {
        /// <summary>
        /// Determine whether a node of a given type should be walked into.
        /// </summary>
        protected virtual bool IsRelevant(Type nodeType)
        {
            if (nodeType.IsAssignableTo(typeof(Element)) || nodeType.Assembly == typeof(Element).Assembly)
            {
                return true;
            }
            else if (nodeType.IsArray)
            {
                var elementType = nodeType.GetElementType()!;
                return IsRelevant(elementType);
            }

            return false;
        }

        /// <summary>
        /// Process a node that we have walked into.
        /// </summary>
        protected abstract bool Process(object node);

        /// <summary>
        /// Perform the walk.
        /// </summary>
        protected void StartInternal(object? root)
        {
            _visited = [];
            Walk(root);
        }

        private Stack<object> _visited = new();

        private void Walk(object? node)
        {
            if (node is null)
                return;

            if(!IsRelevant(node.GetType()))
                return;

            if (_visited.Any(i => ReferenceEquals(i, node)))
                throw new InvalidOperationException("Cycle in ELM graph detected.");

            if (Process(node)) return;

            var propertyValues = node.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                     .Where(p => p.CanRead && IsRelevant(p.PropertyType))
                                     .Select(p => p.GetValue(node))
                                     .Where(v => v is not null);

            try
            {
                _visited.Push(node);

                foreach (var propValue in propertyValues)
                {
                    if (propValue is IEnumerable enumerable)
                    {
                        foreach (var item in enumerable)
                            Walk(item);
                    }
                    else
                    {
                        Walk(propValue!);
                    }
                }
            }
            finally
            {
                _visited.Pop();
            }
        }
    }
}