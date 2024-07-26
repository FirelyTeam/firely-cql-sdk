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
    internal class ElmTreeWalker
    {
        /// <summary>
        /// Construct a walker.
        /// </summary>
        /// <param name="visitor">A function that is passed the nodes in the tree. It should return <c>false</c> if this function
        /// handles the children of the nodes by itself, or <c>true</c> if the walker should visit the children automatically.</param>
        /// <param name="filter">A function that controls whether the walker visits a child property or not.</param>
        /// <param name="additionalTypes">Additional non-ELM types to visit.</param>
        public ElmTreeWalker(Func<object, bool> visitor,
            Func<PropertyInfo, bool>? filter = null,
            params Type[] additionalTypes)
        {
            this.visitor = visitor;
            this.filter = filter;
            AdditionalTypes = additionalTypes;
        }

        private readonly Func<object, bool> visitor;
        private readonly Func<PropertyInfo, bool>? filter;

        private bool isRelevant(PropertyInfo t) => filter switch
            {
                { } => filter(t),
                null => true,
            };


        internal IReadOnlyCollection<Type> AdditionalTypes { get; private set; }

        /// <summary>
        /// Perform the walk.
        /// </summary>
        /// <param name="root"></param>
        public void Walk(object? root)
        {
            if (root is not null)
                Walk(root, [root]);
        }
        private void Walk(object root, object[] visited)
        {
            if (visitor(root)) return;

            var properties = root.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.CanRead && isRelevant(p) && p.GetValue(root) is { } propValue)
                .ToArray();

            foreach (var property in properties)
            {
                var propValue = property.GetValue(root)!;
                if (propValue is IEnumerable enumerable)
                {
                    foreach (var item in enumerable)
                    {
                        if (item is not null)
                        {
                            if (visited.Any(item => ReferenceEquals(item, propValue)))
                                throw new InvalidOperationException("Cycle in ELM graph detected.");
                            Walk(item, [.. visited, item]);
                        }
                    }
                }
                else
                {
                    if (visited.Any(obj => ReferenceEquals(obj, propValue)))
                        throw new InvalidOperationException("Cycle in ELM graph detected.");
                    Walk(propValue, [.. visited, propValue]);
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
