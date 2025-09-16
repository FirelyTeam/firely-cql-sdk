/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Elm
{
    /// <summary>
    /// A walker that does a depth-first traversal of a tree and calls a visitor function for each node.
    /// </summary>
    /// <param name="visitor">A function that is passed the nodes in the tree. It should return <c>false</c> if this function
    /// handles the children of the nodes by itself, or <c>true</c> if the walker should visit the children automatically.</param>
    /// <param name="filter">A function that, given the type of a property, controls whether the walker visits that child property or not.</param>
    internal class ElmTreeWalker(
        ElmTreeWalker.Visitor visitor,
        ElmTreeWalker.Filter? filter = null) : BaseElmTreeWalker
    {
        public delegate bool Visitor(object node);
        public delegate bool VisitorWithSelf(ElmTreeWalker self, object node);
        public delegate bool Filter(Type type);
        public delegate bool FilterWithSelf(ElmTreeWalker self, Type type);

        public static ElmTreeWalker Create(
            VisitorWithSelf visitor,
            FilterWithSelf? filter = null)
        {
            ElmTreeWalker walker = null!;
            walker = new ElmTreeWalker(
                node => visitor(walker, node),
                filter is null ? null : type => filter(walker, type));
            return walker;
        }

        protected override bool IsRelevant(Type nodeType) => filter?.Invoke(nodeType) ?? base.IsRelevant(nodeType);

        protected override bool Process(object node) => visitor(node);
    }
}