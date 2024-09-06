/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;

namespace Hl7.Cql.Elm
{
    /// <summary>
    /// A walker that does a depth-first traversal of a tree and calls a visitor function for each node.
    /// </summary>
    /// <param name="visitor">A function that is passed the nodes in the tree. It should return <c>false</c> if this function
    /// handles the children of the nodes by itself, or <c>true</c> if the walker should visit the children automatically.</param>
    /// <param name="filter">A function that, given the type of a property, controls whether the walker visits that child property or not.</param>
    internal class ElmTreeWalker(Func<object, bool> visitor,
                               Func<Type, bool>? filter = null) : BaseElmTreeWalker
    {
        protected override bool IsRelevant(Type nodeType) => filter?.Invoke(nodeType) ?? base.IsRelevant(nodeType);

        protected override bool Process(object node) => visitor(node);
    }
}