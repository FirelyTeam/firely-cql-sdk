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
    /// A walker that does a depth-first traversal of a tree and calls a visitor function for each node.
    /// </summary>
    public class ElmTreeWalker
    {
        /// <summary>
        /// Construct a walker.
        /// </summary>
        /// <param name="visitor">A function that is passed the nodes in the tree. It should return <c>false</c> if this function
        /// handles the children of the nodes by itself, or <c>true</c> if the walker should visit the children automatically.</param>
        /// <param name="additionalTypes">Additional non-ELM types to visit.</param>
        public ElmTreeWalker(Func<object, bool> visitor, params Type[] additionalTypes)
        {
            this.visitor = visitor;
            AdditionalTypes = additionalTypes;
        }

        private readonly Func<object, bool> visitor;

        private bool isRelevant(Type t) =>
            AdditionalTypes.Contains(t) ||
            t.Assembly == typeof(Element).Assembly ||
            t.IsAssignableTo(typeof(Element));

        internal IReadOnlyCollection<Type> AdditionalTypes { get; private set; }

        /// <summary>
        /// Perform the walk.
        /// </summary>
        /// <param name="root"></param>
        public void Walk(object? root)
        {
            if (root is null) return;

            if (getUnderlyingEnumerableType(root.GetType()) is { } collectionType &&
                isRelevant(collectionType))
            {
                foreach (var item in (IEnumerable)root) Walk(item);
                return;
            }

            if (!isRelevant(root.GetType())) return;

            if (visitor(root)) return;

            var properties = root.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var property in properties)
            {
                if (property.GetGetMethod()?.GetParameters().Length == 0)
                {
                    Walk(property.GetValue(root));
                }
            }
        }

        private static Type? getUnderlyingEnumerableType(Type enumerableType)
        {
            if (enumerableType.IsArray)
            {
                return enumerableType.GetElementType();
            }

            if (enumerableType.IsGenericType && !enumerableType.IsGenericTypeDefinition)
            {
                // instantiated generic type only
                Type genericType = enumerableType.GetGenericTypeDefinition();
                if (ReferenceEquals(genericType, typeof(IEnumerable<>)))
                {
                    return enumerableType.GetGenericArguments()[0];
                }
            }
            return null;
        }
    }
}
